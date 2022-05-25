using FluentAssertions;
using NUnit.Framework;

namespace CleanArchitecture.Domain.UnitTests
{
    public class ExampleModelTests
    {
        [Test]
        public void ShouldReturnValue()
        {
            var dummy = new Ping();

            dummy.Value.Should().Be(1);
        }
    }
}