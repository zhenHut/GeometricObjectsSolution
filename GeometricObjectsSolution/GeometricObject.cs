﻿using System.ComponentModel;

namespace GeometricObjectsSolution
{
    public abstract class GeometricObject : IComparable, INotifyPropertyChanged
    {
        #region Ereignisse
        public event PropertyChangedEventHandler? PropertyChanged;
        public event InvalidMeasureEventHandler? InvalidMeasure;
        public event MovingEventHandler? Moving;
        public event MovedEventHandler? Moved;
        #endregion

        #region Konstruktor
        public GeometricObject() => CountGeometricObjects++;
        #endregion

        #region Eigenschaften
        protected Point _center = new Point();

        public virtual double XCoordinate
        {
            get => _center.X;
            set
            {
                _center.X = value;
                OnPropertyChanged("XCoordinate");
            }
        }


        public virtual double YCoordinate
        {
            get => _center.Y;
            set
            {
                _center.Y = value;
                OnPropertyChanged("YCoordinate");
            }
        }
        #endregion

        #region Instanzmethoden
        public virtual int CompareTo(Object? obj)
        {
            GeometricObject? geoObject = obj as GeometricObject;
            if (geoObject != null)
            {
                if (GetArea() < geoObject.GetArea()) return -1;
                if (GetArea() == geoObject.GetArea()) return 0;
                return 1;
            }
            // Auslösen einer Ausnahme
            throw new ArgumentException("Es wird der Typ 'GeometricObject' erwartet.");
        }

        public virtual void Move(Point center)
        {
            MovingEventArgs e = new MovingEventArgs();
            OnMoving(e);
            if (e.Cancel == true)
                return;

            _center = center;
            OnMoved(new EventArgs());
        }

        protected virtual void OnInvalidMeasure(InvalidMeasureEventArgs e)
        {
            if (InvalidMeasure != null)
            {
                InvalidMeasure.Invoke(this, e);
            }
            else
            {
                throw e.Error;
            }
        }

        protected virtual void OnMoving(MovingEventArgs e) => Moving?.Invoke(this, e);

        protected virtual void OnMoved(EventArgs e) => Moved?.Invoke(this, e);

        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion

        #region Abstrakte Methoden
        public abstract double GetArea();
        public abstract double GetPerimeter();
        #endregion

        #region Klasseneigenschaft
        public static int CountGeometricObjects { get; protected set; }
        #endregion

        #region Klassenmethode
        public static int Bigger(GeometricObject geo1, GeometricObject geo2)
        {
            if (geo1 == null && geo2 == null) return 0;
            if (geo1 == null) return -1;
            if (geo1 == null) return 1;
            if (geo1.GetArea() > geo2.GetArea()) return 1;
            if (geo1.GetArea() < geo2.GetArea()) return -1;
            return 0;
        }
        #endregion
    }
}
