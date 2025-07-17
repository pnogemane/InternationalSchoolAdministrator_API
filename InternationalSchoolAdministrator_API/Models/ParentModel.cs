namespace InternationalSchoolAdministrator_API.Models
{
    public class ParentModel
    {
      
        public int ParentID { get; set; }
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CellphoneNumber { get; set; }
    }
}
