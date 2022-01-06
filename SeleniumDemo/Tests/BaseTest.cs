using NUnit.Framework;

namespace SeleniumDemo.Tests
{
	[TestFixture]
	public class TestBase
	{
		[SetUp]
		public static void Initialize()
		{
			Browser.Initialize();
		}

		[TearDown]
		public static void TestFixtureTearDown()
		{
			Browser.Close();
		}

	}
}