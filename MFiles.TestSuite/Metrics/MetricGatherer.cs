using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using MFiles.TestSuite.MockObjectModels;

namespace MFiles.TestSuite.Metrics
{
	public class MetricGatherer
	{
		public bool TrackMetrics { get; set; }
		public Action<string> LoggingMethod { get; set; }
		public List<CalledMethod> MethodsCalled; 

		public MetricGatherer()
		{
			TrackMetrics = false;
			MethodsCalled = new List<CalledMethod>();
			LoggingMethod = Console.WriteLine;
		}

		public void Reset()
		{
			MethodsCalled = new List<CalledMethod>();
		}

		public void CallWithLogging(Action action, bool logresults = false)
		{
			bool trackMetricsWas = TrackMetrics;
			TrackMetrics = true;
			List<CalledMethod> previousCalls = new List<CalledMethod>();
			if( logresults )
			{
				previousCalls.AddRange( MethodsCalled.Select( calledMethod => calledMethod.Clone() ) );
				LoggingMethod( "Running action with logging." );
			}
			action();
			if( logresults )
			{
				LoggingMethod( "The following was called in the action:" );
				foreach( CalledMethod calledMethod in MethodsCalled )
				{
					CalledMethod previousCall =
						previousCalls.FirstOrDefault(
							call => call.ClassName == calledMethod.ClassName && call.MethodName == calledMethod.MethodName );
					if( previousCall == null )
					{
						LoggingMethod( "\t" + calledMethod );
					}
					else if( previousCall.Count != calledMethod.Count )
					{
						CalledMethod method = calledMethod.Clone();
						method.Count -= previousCall.Count;
						LoggingMethod( "\t" + method );
					}
				}
				LoggingMethod( "End Action.\n" );
			}
			TrackMetrics = trackMetricsWas;
		}

		public void MethodCalled()
		{
			if( !TrackMetrics )
				return;

			// get call stack
			StackTrace stackTrace = new StackTrace();

			// get calling method name
			MethodBase callingMethod = stackTrace.GetFrame( 1 ).GetMethod();

			try
			{
				MethodBase previousMethod = stackTrace.GetFrame( 2 ).GetMethod();

				// If the call was internal.
				if( previousMethod.ReflectedType != null && previousMethod.ReflectedType.Namespace == typeof( TestVault ).Namespace )
				{
					return;
				}
			}
			catch( Exception e )
			{
				Console.WriteLine("Error resolving method: "+stackTrace, e);
			}

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

		public void PrintResults()
		{
			foreach( CalledMethod calledMethod in MethodsCalled )
			{
				LoggingMethod( calledMethod.ToString() );
			}
		}
	}
}
