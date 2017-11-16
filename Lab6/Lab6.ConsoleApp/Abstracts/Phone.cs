using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.ConsoleApp.Abstracts
{
    public abstract class Phone
    {
        private string aspectRatio;

        public string Manufacturer { get; set; }

        public string Family { get; set; }

        public string Model { get; set; }

        public double ScreenSize { get; set; }

        public int RezolutionHeight { get; set; }

        public int RezolutionWidth { get; set; }

        public string OperatingSystem { get; set; }

        public string OperatingSystemVersion { get; set; }

        protected bool IsTurnedOn { get;set; }

        public Phone(string manufacturer, string family, string model)
        {
            Manufacturer = manufacturer;
            Family = family;
            Model = model;
        }

        public void SetScreenDimensions(double screenSize, int heigth, int width)
        {
            ScreenSize = screenSize;
            RezolutionHeight = heigth;
            RezolutionWidth = width;

            CalculateAspectRatio();
        }

        public string DisplayAspectRatio()
        {
            return aspectRatio;
        }

        private void CalculateAspectRatio()
        {
            aspectRatio = "";
        }
    }
}
