﻿namespace GeometricObjectsSolution
{
    public class Rectangle : GeometricObject, IDisposable
    {
        #region Objektzerstörung
        private bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                CountRectangles--;
                CountGeometricObjects--;
                GC.SuppressFinalize(this);
                disposed = true;
            }
        }

        ~Rectangle() => Dispose();
        #endregion

        #region Konstruktoren
        public Rectangle() : this(0, 0, 0, 0) { }

        public Rectangle(int length, int width) : this(length, width, 0, 0) { }

        public Rectangle(int length, int width, Point center)
        {
            Length = length;
            Width = width;
            _center = center;
            Rectangle.CountRectangles++;
        }

        public Rectangle(int length, int width, double x, double y)
        {
            Length = length;
            Width = width;
            _center.X = x;
            _center.Y = y;
            Rectangle.CountRectangles++;
        }
        #endregion

        #region Instanzeigenschaften
        private int _Length;
        public int Length
        {
            get => _Length;
            set
            {
                if (value >= 0)
                {
                    _Length = value;
                    OnPropertyChanged("Length");
                }
                else
                {
                    InvalidMeasureException exception = new InvalidMeasureException($"Die Länge von {value} ist nicht zulässig");
                    exception.Data.Add("Time", DateTime.Now);
                    OnInvalidMeasure(new InvalidMeasureEventArgs(value, "Length", exception));
                }
            }
        }

        private int _Width;
        public int Width
        {
            get => _Width;
            set
            {
                if (value >= 0)
                {
                    _Width = value;
                    OnPropertyChanged("Width");
                }
                else
                {
                    InvalidMeasureException exception = new InvalidMeasureException($"Die Breite von {value} ist nicht zulässig");
                    exception.Data.Add("Time", DateTime.Now);
                    OnInvalidMeasure(new InvalidMeasureEventArgs(value, "Width", exception));
                }
            }
        }
        #endregion

        #region Instanzmethoden
        public override double GetArea() => Length * Width;

        public override double GetPerimeter() => 2 * (Length + Width);

        public virtual void Move(double dx, double dy, int dWidth, int dLength)
        {
            MovingEventArgs e = new MovingEventArgs();
            OnMoving(e);
            if (e.Cancel == true) return;

            XCoordinate += dx;
            YCoordinate += dy;
            Width += dWidth;
            Length += dLength;

            OnMoved(new EventArgs());
        }

        public override string ToString() => "Rectangle, L=" + Length + ",B=" + Width + ",Fläche=" + GetArea();
        #endregion

        #region Klasseneigenschaft
        public static int CountRectangles { get; private set; }
        #endregion

        #region Klassenmethoden
        public static double GetArea(int length, int width) => length * width;

        public static double GetPerimeter(int length, int width) => 2 * (length + width);
        #endregion
    }
}
