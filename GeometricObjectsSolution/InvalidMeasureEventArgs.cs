using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{
    public delegate void InvalidMeasureEventHandler(Object sender, InvalidMeasureEventArgs e);
    public delegate void MovingEventHandler(Object sender, MovingEventArgs e);
    public delegate void MovedEventHandler(Object sender, EventArgs e);

    public class InvalidMeasureEventArgs : EventArgs
    {
        #region Felder
        private int _invalidMeasure;
        private string _propertyName;
        private Exception _error;
        #endregion

        #region Eigenschaften
        public int InvalidMeasure
        {
            get => _invalidMeasure;
        }

        public string PropertyName
        {
            get => _propertyName;
        }

        public Exception Error
        {
            get=>_error;
        }
        #endregion

        #region Konstruktor
        public InvalidMeasureEventArgs(int invalidMeasure, string propertyName, Exception error)
        {
            _invalidMeasure = invalidMeasure;
            _error = error;

            if (propertyName == "" || propertyName == null)
                _propertyName = "[unknown]";
            else
                _propertyName = propertyName;
        }
        #endregion
    }

    public class MovingEventArgs : EventArgs
    {
        public bool Cancel { get; set; }
    }

}

