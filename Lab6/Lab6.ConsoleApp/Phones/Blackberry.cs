using Lab5.ConsoleApp.Abstracts;
using Lab5.ConsoleApp.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Phones
{
    public class Blackberry : Phone, IPhoneFunctionality
    {
        public Blackberry(string manufactures, string family, string model) : base(manufactures, family, model)
        {
            IsTurnedOn = false;
        }

        public void Restart()
        {
            if (!IsTurnedOn)
            {
                throw new Exception("Cannot restart phone because its turned off!");
            }
        }

        public void TurnOff()
        {
            if (!IsTurnedOn)
            {
                throw new Exception("Phone is already turned off!");
            }

            Console.WriteLine("Device is turning off");

            IsTurnedOn = false;

            Console.WriteLine("Device is turned off");
        }

        public void TurnOn()
        {
            if (IsTurnedOn)
            {
                throw new Exception("Phone is already turned on!");
            }

            Console.WriteLine("Device is turning on");
            Console.WriteLine("Loading device settings ==>");

            IsTurnedOn = true;

            Console.WriteLine("Device turned on!");
        }
    }
}
