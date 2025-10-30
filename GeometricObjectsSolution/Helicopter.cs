using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class Helicopter : Aircraft
    {
        public double Rotor {  get; set; }

        public override void Start()
        {
            Console.WriteLine("Der Helikopter startet.");
        }
    }
}
