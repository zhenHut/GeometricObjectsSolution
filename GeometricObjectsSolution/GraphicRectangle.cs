using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class GraphicRectangle : IDraw
    {
        public virtual void Draw()
        {
            Console.WriteLine("Das Rechteck wird gezeichnet");
        }
    }
}
