using FluentAssertions;
using NUnit.Framework;
using TestGithubActionsWithSonar;

namespace TestProject
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			var t = new TestCalculator();

			t.Add(5, 3).Should().Be(8);
		}
	}
}