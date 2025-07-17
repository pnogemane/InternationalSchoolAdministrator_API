namespace InternationalSchoolAdministrator_API.Models
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public int ParentID { get; set; }
        public int CourseID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CellphoneNumber { get; set; }

        public StudentModel GetStudentByParentID(string parentID)
        {
            return new StudentModel();
        }

    }
}
