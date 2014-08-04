using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace MFiles.TestSuite.Metrics
{
	public class MetricGatherer
	{
		public bool TrackMetrics { get; set; }

		public List<CalledMethod> MethodsCalled; 

		public MetricGatherer()
		{
			TrackMetrics = false;
			MethodsCalled = new List<CalledMethod>();
		}

		public void Reset()
		{
			MethodsCalled = new List<CalledMethod>();
		}

		public void MethodCalled()
		{
			if( !TrackMetrics )
				return;

			// get call stack
			StackTrace stackTrace = new StackTrace();

			// get calling method name
			MethodBase callingMethod = stackTrace.GetFrame( 1 ).GetMethod();
			string methName = callingMethod.Name;
			string className = callingMethod.ReflectedType == null ? string.Empty : callingMethod.ReflectedType.Name;

			CalledMethod method =
				MethodsCalled.FirstOrDefault( meth => meth.ClassName == className && meth.MethodName == methName );
			if(method == null)
			{
				method = new CalledMethod
				{
					ClassName = className,
					Count = 0,
					MethodName = methName
				};
				MethodsCalled.Add( method );
			}
			++method.Count;
		}

		public void PrintResults(Action<string> writeMethod = null)
		{
			if( writeMethod == null )
				writeMethod = Console.WriteLine;

			foreach( CalledMethod calledMethod in MethodsCalled )
			{
				writeMethod( calledMethod.ToString() );
			}
		}
	}
}
