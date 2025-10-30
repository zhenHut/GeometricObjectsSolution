using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class Airplane : Aircraft
    {
        public double Wingspan {  get; set; }


        public override void Start()
        {
            Console.WriteLine("Das Flugzeug startet.");
        }
    }
}
