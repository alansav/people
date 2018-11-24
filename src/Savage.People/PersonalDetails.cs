using System;

namespace Savage.People
{
    public class PersonalDetails
    {
        public readonly NameOfPerson Name;
        public readonly Gender Gender;
        public readonly DateTime? DateOfBirth;

        public PersonalDetails(NameOfPerson name, Gender gender, DateTime? dateOfBirth = null)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
    }
}
