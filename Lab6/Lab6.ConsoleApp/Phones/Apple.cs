using Lab5.ConsoleApp.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Phones
{
    public class Apple : PhoneExtented
    {
        public Apple(string manufacturer, string family, string model, string operatingSystem, string operatingSystemVersion,
                double screenSize, double rezolutionWidth, double rezolutionHeight) : base (manufacturer, family, model, operatingSystem,
                    operatingSystemVersion, screenSize, rezolutionWidth, rezolutionHeight)
        {

        }

        public override void Restart()
        {
            throw new NotImplementedException();
        }

        public override void TurnOff()
        {
            if (!isTurnedOn)
            {
                throw new Exception("Phone is already turned off!");
            }

            Console.WriteLine("Phone turning off!");
            isTurnedOn = false;
            Console.WriteLine("Phone turned off!");
        }

        public override void TurnOn()
        {
            if (isTurnedOn)
            {
                throw new Exception("Phone is already turned on!");
            }

            Console.WriteLine("Turning phone on!");
            isTurnedOn = true;
            Console.WriteLine("Phone turned on!");
        }
    }
}
