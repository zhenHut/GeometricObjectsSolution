﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GeometricObjectsSolution
{

	[Serializable]
	public class InvalidMeasureException : Exception
	{
		public InvalidMeasureException() { }
		public InvalidMeasureException(string message) : base(message) { }
		public InvalidMeasureException(string message, Exception inner) : base(message, inner) { }
		protected InvalidMeasureException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
