using System;

namespace OOPPractice3
{
    public class Person
    {
        private string _name;
        private int _age;

        // Property för ålder
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        // Uträknad property för isRetired
        public bool IsRetired
        {
            get
            {
                return _age >= 65;
            }
        }

        // Property för namn
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        // Statisk metod för att hitta den äldsta personen
        public static Person Oldest(Person person1, Person person2)
        {
            return person1.Age > person2.Age ? person1 : person2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Britt-Marie";
            person1.Age = 70;

            Person person2 = new Person();
            person2.Name = "Bob";
            person2.Age = 60;

            Console.WriteLine($"{person1.Name} är pensionär: {person1.IsRetired}");
            Console.WriteLine($"{person2.Name} är pensionär: {person2.IsRetired}");

            Person oldestPerson = Person.Oldest(person1, person2);
            Console.WriteLine($"Den äldsta personen är {oldestPerson.Name} och är {oldestPerson.Age} år gammal.");

            Console.ReadKey();
        }
    }
}
