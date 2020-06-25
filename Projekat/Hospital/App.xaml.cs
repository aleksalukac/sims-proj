using Controllers;
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

            var doctorService = new DoctorService(doctorRepository);
            var doctorReviewService = new DoctorReviewService(medicalExamRepository);
            var drugService = new DrugService(drugRepository);
            var employeeService = new EmployeeService(managerRepository, doctorService, secretaryRepository);
            var feedbackService = new FeedbackService(textContentRepository);
            var guestUserService = new GuestUserService(medicalExamRepository);
            var medicalExamService = new MedicalExamService(medicalExamRepository);
            var medicalSupplyService = new MedicalSupplyService(medicalSupplyRepository);
            var patientService = new PatientService(patientRepository);
            var questionService = new QuestionService(textContentRepository);
            var reportService = new ReportService(reportRepository);
            var resourceService = new ResourceService(resourceRepository);
            var roomService = new RoomService(roomRepository);
            var userService = new UserService(employeeService, patientService);

            DoctorController = new DoctorController(doctorService);
            DoctorReviewController = new DoctorReviewController(doctorReviewService);
            DrugController = new DrugController(drugService);
            EmployeeController = new EmployeeController(employeeService);
            FeedbackController = new FeedbackController(feedbackService);
            GuestUserController = new GuestUserController(guestUserService);
            MedicalExamController = new MedicalExamController(medicalExamService);
            MedicalSupplyController = new MedicalSupplyController(medicalSupplyService);
            PatientController = new PatientController(patientService);
            QuestionController = new QuestionController(questionService);
            ReportController = new ReportController(reportService);
            ResourceController = new ResourceController(resourceService);
            RoomController = new RoomController(roomService);
            UserController = new UserController(userService);
        }

        public DoctorController DoctorController { get; private set; }
        public DoctorReviewController DoctorReviewController { get; private set; }
        public DrugController DrugController { get; private set; }
        public EmployeeController EmployeeController { get; private set; }
        public FeedbackController FeedbackController { get; private set; }
        public GuestUserController GuestUserController { get; private set; }
        public MedicalExamController MedicalExamController { get; private set; }
        public MedicalSupplyController MedicalSupplyController { get; private set; }
        public PatientController PatientController { get; private set; }
        public QuestionController QuestionController { get; private set; }
        public ReportController ReportController { get; private set; }
        public ResourceController ResourceController { get; private set; }
        public RoomController RoomController { get; private set; }
        public UserController UserController { get; private set; }
    }
}
