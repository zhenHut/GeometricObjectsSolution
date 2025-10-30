using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public class GraphicCircle : Circle, IDraw
    {
        #region Constructors

        public GraphicCircle() : base(0, 0, 0) { }
        public GraphicCircle(int radius) : base(radius, 0, 0)
        {
          
        }

        public GraphicCircle(int radius, double xCoordinate, double yCoordinate) : base(radius, xCoordinate, yCoordinate)
        {

        }

        public virtual void Draw()
        {
            Console.WriteLine("Das Rechteck wird gezeichnet");
        }
        #endregion
    }
}
