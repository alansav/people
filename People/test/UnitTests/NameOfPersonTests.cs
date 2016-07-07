using System.Linq;
using Xunit;

namespace Savage.People
{
    public class NameOfPersonTests
    {
        [Fact]
        public void TestConstructorWithMultipleGivenNames()
        {
            var subject = new NameOfPerson("Mr.", new[] { "Fred", "George" }, "Smith");

            Assert.Equal("Mr.", subject.Title);
            Assert.True(subject.GivenNames.Length == 2);
            Assert.True(subject.GivenNames.Contains("Fred"));
            Assert.True(subject.GivenNames.Contains("George"));
            Assert.Equal("Smith", subject.FamilyName);

            Assert.Equal("Mr. Fred George Smith", subject.ToString());
        }

        [Fact]
        public void TestConstructorWithSingleGivenNames()
        {
            var subject = new NameOfPerson("Mr.", "Fred", "Smith");
            Assert.Equal("Mr.", subject.Title);
            Assert.True(subject.GivenNames.Length == 1);
            Assert.True(subject.GivenNames.Contains("Fred"));
            Assert.Equal("Smith", subject.FamilyName);

            Assert.Equal("Mr. Fred Smith", subject.ToString());
        }
    }
}
