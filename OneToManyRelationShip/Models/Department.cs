namespace OneToManyRelationShip.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string? Name { get; set; }

        public ICollection<Employe>? Employes { get; set; }
    }
}
