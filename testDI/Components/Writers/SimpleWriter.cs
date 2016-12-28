using System;
namespace testDI
{
	public class SimpleWriter : IWriter
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
