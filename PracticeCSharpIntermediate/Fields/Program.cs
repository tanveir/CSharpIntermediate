using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();
            
            
           var customer = new Customer(1);
           customer.Orders.Add(new Order());
           customer.Orders.Add(new Order());

           customer.Promote();

           Console.WriteLine(customer.Orders.Count);
        }
    }
}
