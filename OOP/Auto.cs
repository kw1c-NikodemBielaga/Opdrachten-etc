using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Auto
    {
        //Constructor -> public <naam claas> (?????)
        //Constructor = bouwen -> method die een object bouwt. 
        //clas -> bouwtekening          object -> huis gebouwd volgends de bouwtekening 
        public Auto()
        {
        }
        private int snelheid;
        //Read-only  property/attrobuut Snelheid
        public int Snelheid
        {
            get { return snelheid; }
            set {
                if
                    (value > MaxSnelheid)
                    snelheid = MaxSnelheid;
                else 
                    snelheid = value;
            }
            
        }

        public int Merk { get; set; }
        public int MotorStatus { get; set; }
        public int MaxSnelheid { get; set; }

        public void GeefGas()
        {
            if (MotorStatus)
            {
                snelheid += 20;
            }
        }
    }
}
