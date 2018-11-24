using System;
using Xunit;

namespace Savage.People
{
        public class PersonalDetailsTests
    {
        [Fact]
        public void TestConstructor()
        {
            var name = new NameOfPerson("Mr.", "Fred", "Smith");

            var subject = new PersonalDetails(name, Gender.Male, new DateTime(1950, 8, 15));

            Assert.Equal(name, subject.Name);
            Assert.Equal(Gender.Male, subject.Gender);
            Assert.Equal(new DateTime(1950, 8, 15), subject.DateOfBirth);
        }
    }
}
