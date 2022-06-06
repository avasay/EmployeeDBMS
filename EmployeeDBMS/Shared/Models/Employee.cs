namespace EmployeeDBMS.Shared.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }

        public DateTime? DateOfHire { get; set; } = DateTime.Now;

        public DateTime? DateOfBirth { get; set; } = DateTime.Now;

        public string Position { get; set; }

        public string Department { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }
    }
}
