using FluentAssertions;
using SampleApp.Testing;
using Xunit;

namespace SampleApp
{
	public class AClassToTest
	{
		[Fact]
		public void unitUnderTest_scenario_expectation()
		{
			// Arrange
			AClass aClass = new();

			// Act
			string result = aClass.Hello();

			// Assert
			result
				.Should()
				.Be("To You.");

			SomeSharedContent
				.IsThisASharedTestingLibrary
				.Should()
				.BeTrue();
		}
	}
}
