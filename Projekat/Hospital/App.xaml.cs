using Controllers;
using Hospital_class_diagram.Controllers;
using Hospital_class_diagram.Repository;
using Hospital_class_diagram.Services;
using Model;
using Repository;
using Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Hospital
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var doctorRepository = new DoctorRepository();
            var drugRepository = new DrugRepository();
            var managerRepository = new ManagerRepository();
            var medicalExamRepository = new MedicalExamRepository();
            var medicalRecordRepository = new MedicalRecordRepository();
            var medicalSupplyRepository = new MedicalSupplyRepository();
            var notificationRepository = new NotificationRepository();
            var patientRepository = new PatientRepository();
            var reportRepository = new ReportRepository();
            var resourceRepository = new ResourceRepository();
            var roomRepository = new RoomRepository();
            var secretaryRepository = new SecretaryRepository();
            var textContentRepository = new TextContentRepository();
            var renovationRepository = new RenovationRepository();
            var guestUserRepository = new GuestUserRepository();

            var notificationService = new NotificationService(notificationRepository);
            var doctorService = new DoctorService(doctorRepository, notificationService);
            var doctorReviewService = new DoctorReviewService(medicalExamRepository);
            var drugService = new DrugService(drugRepository, doctorService);
            var employeeService = new EmployeeService(managerRepository, doctorService, secretaryRepository);
            var guestUserService = new GuestUserService(guestUserRepository);
            var medicalExamService = new MedicalExamService(medicalExamRepository);
            var medicalSupplyService = new MedicalSupplyService(medicalSupplyRepository);
            var patientService = new PatientService(patientRepository);
            var reportService = new ReportService(reportRepository, managerRepository);
            var resourceService = new ResourceService(resourceRepository);
            var roomService = new RoomService(roomRepository, renovationRepository, medicalExamService, patientService, resourceService);
            var userService = new UserService(employeeService, patientService);
            var textContentService = new TextContentService(textContentRepository);

            TextContentController = new TextContentController(textContentService);
            NotificationController = new NotificationController(notificationService);
            DoctorController = new DoctorController(doctorService);
            DoctorReviewController = new DoctorReviewController(doctorReviewService);
            DrugController = new DrugController(drugService);
            EmployeeController = new EmployeeController(employeeService);
            GuestUserController = new GuestUserController(guestUserService);
            MedicalExamController = new MedicalExamController(medicalExamService);
            MedicalSupplyController = new MedicalSupplyController(medicalSupplyService);
            PatientController = new PatientController(patientService);
            ReportController = new ReportController(reportService);
            ResourceController = new ResourceController(resourceService);
            RoomController = new RoomController(roomService);
            UserController = new UserController(userService);
        }

        public TextContentController TextContentController { get; private set; }
        public NotificationController NotificationController { get; private set; }
        public DoctorController DoctorController { get; private set; }
        public DoctorReviewController DoctorReviewController { get; private set; }
        public DrugController DrugController { get; private set; }
        public EmployeeController EmployeeController { get; private set; }
        public GuestUserController GuestUserController { get; private set; }
        public MedicalExamController MedicalExamController { get; private set; }
        public MedicalSupplyController MedicalSupplyController { get; private set; }
        public PatientController PatientController { get; private set; }
        public ReportController ReportController { get; private set; }
        public ResourceController ResourceController { get; private set; }
        public RoomController RoomController { get; private set; }
        public UserController UserController { get; private set; }
    }
}
