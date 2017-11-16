using Lab5.ConsoleApp.Abstracts;
using Lab5.ConsoleApp.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Phones
{
    public class Samsung : Phone, IPhoneFunctionality
    {
        public Samsung(string manufacturer, string family, string model) : base(manufacturer, family, model)
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

            Console.WriteLine("Saving user configurations");
            Console.WriteLine("Reset memory");

            IsTurnedOn = false;

            Console.WriteLine("Device is turned off");
        }

        public void TurnOn()
        {
            if (IsTurnedOn)
            {
                throw new Exception("Phone is already turned on!");
            }

            Console.WriteLine("Turning device on...");
            Console.WriteLine("Initializating components ==>");
            Console.WriteLine("Loading device settings ==>");

            IsTurnedOn = true;

            Console.WriteLine("Device turned on!");
        }

        public override string ToString()
        {
            CheckPhoneProperties();

            string phoneDisplay = string.Empty;

            phoneDisplay += Environment.NewLine;
            phoneDisplay += "--- Phone details ---";
            phoneDisplay += $"Manufacturer: {Manufacturer}, Family: {Family}, Model:{Model}";
            phoneDisplay += $"Operating system: {OperatingSystem} {OperatingSystemVersion}";
            phoneDisplay += $"Screen information: {ScreenSize}, Rezolution: {RezolutionHeight}x{RezolutionWidth}";
            phoneDisplay += $"Aspect Ratio: {DisplayAspectRatio()}";
            phoneDisplay += "--- Phone details end ---";
            phoneDisplay += Environment.CommandLine;

            return phoneDisplay;
        }

        private void CheckPhoneProperties()
        {
            if(string.IsNullOrWhiteSpace(OperatingSystem))
            {
                throw new Exception("Please provide an Operating System!");
            }

            if(string.IsNullOrWhiteSpace(OperatingSystemVersion))
            {
                throw new Exception("Please provide a version for the Operationg System!");
            }

            if(ScreenSize <= 1)
            {
                throw new Exception("Please provide the screen size for your phone!");
            }

            if(RezolutionWidth < 1)
            {
                throw new Exception("Please provide the width for rezolution!");
            }

            if(RezolutionHeight < 1)
            {
                throw new Exception("Please provide the height for rezolution!");
            }
        }
    }

    public class Huawei : IPhoneFunctionality
    {
        public void Restart()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
