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

        public Vehicle(string plate)
        {
            this.plate = plate;
        }

        public string Plate
        {
            get { return this.plate; }
            set { this.plate = value; }
        }

        public int GetLastDigit()
        {
            return int.Parse(plate.Substring(plate.Length - 1)); 
        }


    }
}
