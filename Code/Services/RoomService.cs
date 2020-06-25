// File:    RoomService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:25:14 PM
// Purpose: Definition of Class RoomService

using Hospital_class_diagram.Repository;
using Model;
using Repository;
using System; using System.Collections.Generic;
using System.Linq;

namespace Services
{
   public class RoomService
   {

        public List<Room> GetAllRoom()
        {
            throw new NotImplementedException();
        }
      
        public Room SetRoomRenovation(DateTime start, DateTime finish)
        {
            throw new NotImplementedException();
        }

        public Room Get(int id)
              => _roomRepository.Get(id);

        public List<Room> GetFreeRoom(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
      
        public List<Room> GetOccupiedRoom(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        internal Renovation GetFutureRenovation(int id)
        {
            Room room = Get(id);

            if (room == null || room.Renovation == null)
                return null;

            foreach(var renovationId in room.Renovation)
            {
                Renovation renovation = _renovationRepository.Get(renovationId);
                if(renovation != null)
                {
                    if (renovation.Date > DateTime.Now.Date)
                        return renovation;
                }
            }
            return null;
        }

        internal List<Room> GetByType(RoomType roomType)
            => GetAll().FindAll(room => room.RoomType == roomType);

        internal Room Remove(int id)
        {
            Room room = Get(id);
            if (room == null)
                return null;

            var sameTypeRooms = GetByType(room.RoomType);
            if (sameTypeRooms.Count == 1)
                return null;

            foreach(var sameTypeRoom in sameTypeRooms)
            {
                if (sameTypeRoom.Id == id)
                    continue;

                var mergeResult = Merge(sameTypeRoom.Id, id);

                if (mergeResult != null)
                    return mergeResult;
            }

            return null;
        }

        internal Room Add(Room room)
            => _roomRepository.Add(room);

        internal Room Merge(int id1, int id2)
        {
            Room room1 = Get(id1);
            Room room2 = Get(id2);

            if(room1.RoomType != room2.RoomType)
            {
                return null;
            }

            //check if rooms have exams scheduled at the same time
            //if not, all the exams from room2 will be transfered
            //to room1
            var medicalExamsRoom1 = GetMedicalExams(id1);
            var medicalExamsRoom2 = GetMedicalExams(id2);

            foreach(var medicalExam1 in medicalExamsRoom1)
            {
                foreach(var medicalExam2 in medicalExamsRoom2)
                {
                    if (medicalExam1.AppointmentStart.Date > DateTime.Now.Date && medicalExam1.AppointmentStart == medicalExam2.AppointmentStart)
                        return null;
                }
            }

            room1.MedicalExam.AddRange(room2.MedicalExam);

            //all lying patients from room2 will be
            //transfered to room1
            foreach (var patientId in GetPatients(id2))
            {
                Patient patient = _patientService.Get(patientId);
                patient.Room = id1;
                _patientService.Update(patient);

                room1.Patient.Add(patient.Id);
            }

            //all resource from room2 till be 
            //transfered to room1
            foreach (var resource in _resourceService.GetAll())
            {
                if(resource.Room == id2)
                {
                    resource.Room = id1;
                    _resourceService.Update(resource);
                }
            }

            _roomRepository.Remove(id2);

            return Update(room1);
        }

        private List<int> GetPatients(int id)
            => Get(id).Patient;
        

        internal Renovation AddRenovation(Renovation renovation)
            => _renovationRepository.Add(renovation);

        internal Room Update(Room room)
            => _roomRepository.Update(room);

        internal List<MedicalExam> GetMedicalExams(int id)
        {
            List<MedicalExam> medicalExams = new List<MedicalExam>();
            Room room = Get(id);

            foreach (var medicalExamId in room.MedicalExam)
            {
                medicalExams.Add(_medicalExamService.Get(medicalExamId));
            }

            return medicalExams;
        }

        internal bool CanRenovate(int id, DateTime renovationDateTime)
        {
            Room room = Get(id);
            if(room != null && renovationDateTime > DateTime.Now)
            {
                if (GetFutureRenovation(id) != null)
                    return false;

                var medicalExams = GetMedicalExams(id);

                foreach(var medicalExam in medicalExams)
                {
                    if(medicalExam.AppointmentStart.Date == renovationDateTime.Date)
                    {
                        return false;
                    }
                }

                return true;
            }
            return false;
        }

        internal List<Room> GetAll()
            => _roomRepository.GetAll();

        private RoomRepository _roomRepository;
        private RenovationRepository _renovationRepository;
        private MedicalExamService _medicalExamService;
        private PatientService _patientService;
        private ResourceService _resourceService;
        private RoomRepository roomRepository;

        public RoomService(RoomRepository roomRepository, RenovationRepository renovationRepository, MedicalExamService medicalExamService, PatientService patientService, ResourceService resourceService)
        {
            this._resourceService = resourceService;
            this._patientService = patientService;
            this._roomRepository = roomRepository;
            this._renovationRepository = renovationRepository;
            this._medicalExamService = medicalExamService;
        }

        public RoomService(RoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }
    }
}