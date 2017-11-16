
using Lab5.ConsoleApp.Abstracts;
using Lab5.ConsoleApp.Common;
using Lab5.ConsoleApp.Intefaces;
using Lab5.ConsoleApp.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceExample1();

            Console.ReadKey();
        }

        #region Exceptions

        static void ExceptionNotTreated()
        {
            Console.WriteLine("Insert number: ");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);

            Console.WriteLine($"Number raised at the power 2: {Math.Pow(number, 2)}");
        }

        static void ExceptionTreated()
        {
            Console.WriteLine("Insert number: ");
            string input = Console.ReadLine();
            int number = 0;

            try
            {
                number = Convert.ToInt32(input);
            }
            catch (Exception ex)
            {
                string errorMessage = "";
                Console.WriteLine($"Error message: {ex.Message}");
            }
            finally
            {
                string finalMessage = string.Empty;
            }

            Console.WriteLine($"Number raised at the power 2: {Math.Pow(number, 2)}");
        }

        #endregion Exceptions

        #region Interfaces

        static void InterfaceExample1()
        {
            try
            {
                Samsung samsung = new Samsung("Samsung", "Galaxy", "S8+");
                samsung.SetScreenDimensions(6.2, 1440, 2960);
                samsung.DisplayAspectRatio();
                Console.WriteLine(samsung.ToString());

                samsung.TurnOn();
                samsung.TurnOff();
                samsung.Restart();
            }
            catch (Exception ex)
            {
                var errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                Console.WriteLine($"Error message: {errorMessage}");
            }

            try
            {
                Blackberry blackberry = new Blackberry("Blackberry", "", "Priv");
                blackberry.OperatingSystem = OperatingSystemEnum.Android.ToString();
                blackberry.OperatingSystemVersion = "7.1.0";
                blackberry.SetScreenDimensions(5.4, 1440, 2560);
                Console.WriteLine(blackberry.ToString());

                blackberry.Restart();
                blackberry.TurnOff();
                blackberry.TurnOn();
            }
            catch (Exception ex)
            {
                var errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                Console.WriteLine($"Error message: {errorMessage}");
            }
        }

        #endregion Interfaces

        #region Abstract classes

        static void AbstractClassExample1()
        {
            try
            {
                Apple apple = new Apple("Apple", "iPhone", "x", OperatingSystemEnum.iOS.ToString(), "10.0", 5.8, 1125, 2436);
                apple.ToString();

                apple.Restart();
                apple.TurnOn();
                apple.TurnOff();
            }
            catch (Exception ex)
            {
                var errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                Console.WriteLine($"Error message: {errorMessage}");
            }
        }

        static void ConversionExample1()
        {
            Samsung samsung = new Samsung("Samsung", "Galaxy", "S8+");
            Blackberry blackberry = new Blackberry("Blackberry", "", "Priv");
            Apple apple = new Apple("Apple", "iPhone", "x", OperatingSystemEnum.iOS.ToString(), "10.0", 5.8, 1125, 2436);

            object[] objectArray = { samsung, blackberry, apple };
            IPhoneFunctionality[] phoneFunctionalityArray = { samsung, blackberry };

            foreach (var _class in objectArray)
            {
                if (_class is IPhoneFunctionality)
                {
                    Console.WriteLine($"{_class.ToString()} is type IPhoneFunctionality interface");
                }
                else if (_class is PhoneExtented)
                {
                    Console.WriteLine($"{_class.ToString()} is type PhoneExtended abstract class");
                }
            }

        }

        #endregion Abstract classes
    }
}
