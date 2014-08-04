namespace MFiles.TestSuite.Metrics
{
	public class CalledMethod
	{
		public string MethodName { get; set; }
		public string ClassName { get; set; }
		public int Count { get; set; }

		public CalledMethod Clone()
		{
			CalledMethod method = new CalledMethod
			{
				ClassName = ClassName,
				MethodName = MethodName
			};
			return method;
		}

		public override string ToString()
		{
			return string.Format( "{0}.{1}: Called {2} times", ClassName, MethodName, Count );
		}

		public static implicit operator string(CalledMethod method)
		{
			return method.ToString();
		}
	}
}
