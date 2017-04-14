using NUnit.Framework;
using System;
using JenkinsTP;


namespace JenkinsTest
{
	[TestFixture ()]
	public class Test
	{
		int a = 12;
		int b = 2;

		[Test ()]
		public void TestAdd()
		{
			Program app = new Program ();

			int result = app.Add (a, b);

			Assert.AreEqual (a + b, result);
		}

		[Test ()]
		public void TestDiv()
		{
			Program app = new Program ();

			int result = app.Div (a, b);

			Assert.AreEqual (a / b, result);
		}
	}
}

