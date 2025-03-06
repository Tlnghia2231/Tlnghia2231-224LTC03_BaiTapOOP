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

    class Program
    {
        static void Main()
        {
            
        }
    }

}
