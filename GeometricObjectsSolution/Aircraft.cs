using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public abstract class Aircraft
    {
        public string Producer { get; set; } = "";
        public int ConstructionYear { get; set; }
        public abstract void Start();
       

    }
}
