namespace WebApplication2.entities
{
    public class Company
    {
        public string Name { get; set; }
        public int Employees { get; set; }

        public Company(string Name, int Employees)
        {
            this.Name = Name;
            this.Employees = Employees;
        }
    }
}
