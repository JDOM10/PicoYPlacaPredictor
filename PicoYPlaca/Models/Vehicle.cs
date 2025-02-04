using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicoYPlaca.Models
{
    public class Vehicle
    {
        private string plate;
        private int lastDigit;

        public Vehicle(string plate)
        {
            this.plate = plate;
            this.lastDigit = int.Parse(plate.Substring(plate.Length - 1));
        }

        public string Plate
        {
            get { return this.plate; }
            set { this.plate = value; }
        }

        public int LastDigit
        {
            get { return this.lastDigit; }
        }


    }
}
