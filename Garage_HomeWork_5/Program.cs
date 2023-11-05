using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1

            //Person person =new Person ("PersonName", "PersonSurname", 17);
            //Console.WriteLine(person.IsAdult);


            //2

            //Car car = new Car("Mercedes", "E-class", 2023, "Benzin", "Black");
            //car.PrintInfo();

            //3

            //Carr carr = new Carr("BMW", "X5", 2023, 260, 4);

            //Motorcycle motorcycle = new Motorcycle("MotoBrend", "MotoModel", 2023, 110, true);

            //4

            User user = new User("Name", "pass123", "email");

            Console.WriteLine(user.IsPasswordValid());

        }
    }
}
