namespace OneToManyRelationShip.Models
{
    public class Employe
    {
        public int EmployeID { get; set; }
        public string? Name { get; set; }
        public int DepartmentID { get; set; }
        public Department? Department { get; set; }
    }
}
