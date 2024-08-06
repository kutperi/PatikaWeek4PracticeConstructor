using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PracticeConstructor
{
    // Creating the class
    public class Baby
    {
        public string _name;
        public string _surname;
        public DateTime _birthday;

        // Constructor which taking parameters
        public Baby(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _birthday = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        // Default constructor
        public Baby()
        {
            _birthday = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }

        // Method to print information about Baby objects.
        public void BabyInfo()
        {
            Console.WriteLine($"Bebeğin Adı: {_name}\nBebeğin Soyadı: {_surname}\nDoğum Tarihi: {_birthday}");
        }
    }
}
