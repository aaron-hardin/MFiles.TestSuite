namespace MFiles.TestSuite.Metrics
{
	public class CalledMethod
	{
		public string MethodName { get; set; }
		public string ClassName { get; set; }
		public int Count { get; set; }

		public override string ToString()
		{
			return string.Format( "{0}.{1}: Called {2} times", ClassName, MethodName, Count );
		}
	}
}
