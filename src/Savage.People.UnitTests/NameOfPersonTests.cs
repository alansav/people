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
            Assert.Contains("Fred", subject.GivenNames);
            Assert.Contains("George", subject.GivenNames);
            Assert.Equal("Smith", subject.FamilyName);

            Assert.Equal("Mr. Fred George Smith", subject.ToString());
        }

        [Fact]
        public void TestConstructorWithSingleGivenNames()
        {
            var subject = new NameOfPerson("Mr.", "Fred", "Smith");
            Assert.Equal("Mr.", subject.Title);
            Assert.True(subject.GivenNames.Length == 1);
            Assert.Contains("Fred", subject.GivenNames);
            Assert.Equal("Smith", subject.FamilyName);

            Assert.Equal("Mr. Fred Smith", subject.ToString());
        }
    }
}
