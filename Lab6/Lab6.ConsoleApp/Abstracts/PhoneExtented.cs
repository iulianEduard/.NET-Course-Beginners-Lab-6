using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Abstracts
{
    public abstract class PhoneExtented
    {
        #region Attributes

        private string manufacturer;
        private string family;
        private string model;

        private string operatingSystem;
        private string operatingSystemVersion;

        private double screenSize;
        private double rezolutionWidth;
        private double rezolutionHeight;

        private string aspectRatio;

        protected bool isTurnedOn;

        #endregion Attributes

        #region Properties

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if(string.IsNullOrWhiteSpace(manufacturer))
                {
                    throw new Exception("Please provide manufacturer!");
                }

                manufacturer = value;
            }
        }

        public string Family
        {
            get { return family; }
            set
            {
                if(string.IsNullOrWhiteSpace(family))
                {
                    throw new Exception("Please provide family!");
                }

                family = value;
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(model))
                {
                    throw new Exception("Please provide a model!");
                }

                model = value;
            }
        }

        public string OperatingSystem
        {
            get { return operatingSystem; }
            set
            {
                if(string.IsNullOrWhiteSpace(operatingSystem))
                {
                    throw new Exception("Please provide an Operating System!");
                }

                operatingSystem = value;
            }
        }

        public string OperatingSystemVersion
        {
            get { return operatingSystemVersion; }
            set
            {
                if(string.IsNullOrWhiteSpace(operatingSystemVersion))
                {
                    throw new Exception("Please provide an Operating System Version!");
                }

                operatingSystemVersion = value;
            }
        }

        public double ScreenSize
        {
            get { return screenSize; }
            set
            {
                if(screenSize < 1)
                {
                    throw new Exception("Please provide a screen size!");
                }

                screenSize = value;
            }
        }

        public double RezolutionWidth
        {
            get { return rezolutionWidth; }
            set
            {
                if(rezolutionWidth < 1)
                {
                    throw new Exception("Please provide a rezolution width!");
                }

                rezolutionWidth = value;
            }
        }

        public double RezolutionHeight
        {
            get { return rezolutionHeight; }
            set
            {
                if(rezolutionHeight < 1)
                {
                    throw new Exception("Please provide a rezolution height!");
                }

                rezolutionHeight = value;
            }
        }

        #endregion Properties

        #region Constructors

        public PhoneExtented(string _manufacturer, string _family, string _model, string _operatingSystem,
                string _operatingSystemVersion, double _screenSize, double _rezolutionWidht, double _rezolutionHeight)
        {
            Manufacturer = _manufacturer;
            Family = _family;
            Model = _model;

            OperatingSystem = _operatingSystem;
            OperatingSystemVersion = _operatingSystemVersion;

            ScreenSize = _screenSize;
            RezolutionHeight = _rezolutionHeight;
            RezolutionWidth = _rezolutionWidht;

            isTurnedOn = false;
        }

        #endregion Constructors

        #region Public Methods

        public abstract void TurnOn();

        public abstract void TurnOff();

        public abstract void Restart();

        public override string ToString()
        {
            string phoneDisplay = Environment.NewLine;
            phoneDisplay += "--- Phone details ---";
            phoneDisplay += $"Manufacturer: {Manufacturer}, Family: {Family}, Model:{Model}";
            phoneDisplay += $"Operating system: {OperatingSystem} {OperatingSystemVersion}";
            phoneDisplay += $"Screen information: {ScreenSize}, Rezolution: {RezolutionHeight}x{RezolutionWidth}";
            phoneDisplay += $"Aspect Ratio: {CalculateAspectRatio()}";
            phoneDisplay += "--- Phone details end ---";
            phoneDisplay += Environment.CommandLine;

            return phoneDisplay;
        }

        #endregion Public Methods

        #region Private Methods

        private string CalculateAspectRatio()
        {
            aspectRatio = string.Empty;
            return aspectRatio;
        }

        #endregion Private Methods
    }
}
