namespace ConsoleApp1
{
    public interface IEmployee
    {
        int CalculateSalary();
        string GetName();
    }

    public abstract class Employee : IEmployee
    {
        private string name;
        private int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetPaymentPerHour()
        {
            return paymentPerHour;
        }

        public void SetPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public abstract int CalculateSalary();
    }

    public class PartTimeEmployee : Employee
    {
        private int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int CalculateSalary()
        {
            return workingHours * GetPaymentPerHour();
        }
    }

    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour)
            : base(name, paymentPerHour)
        {
        }

        public override int CalculateSalary()
        {
            return 8 * GetPaymentPerHour();
        }
    }
    class Program
    {
        static void Main()
        {
            IEmployee employee1 = new PartTimeEmployee("Trung", 45000, 7);
            Console.WriteLine("Name: " + employee1.GetName());
            Console.WriteLine("Salary per day: " + employee1.CalculateSalary());

            IEmployee employee2 = new FullTimeEmployee("Linh", 65000);
            Console.WriteLine("Name: " + employee2.GetName());
            Console.WriteLine("Salary per day: " + employee2.CalculateSalary());
        }
    }

}
