using System.Text;

namespace Savage.People
{
    public class NameOfPerson
    {
        public readonly string Title;
        public readonly string[] GivenNames;
        public readonly string FamilyName;

        public NameOfPerson(string title, string[] givenNames, string familyName)
        {
            Title = title;
            GivenNames = givenNames;
            FamilyName = familyName;
        }

        public NameOfPerson(string title, string givenName, string familyName)
            : this(title, new[] { givenName }, familyName)
        {
            
        }

        public override string ToString()
        {
            StringBuilder fullname = new StringBuilder();
            fullname.Append($"{Title} ");

            if (GivenNames != null)
            {
                fullname.Append(string.Join(" ", GivenNames));
            }

            fullname.Append($" {FamilyName}");

            return fullname.ToString().Trim();
        }
    }
}