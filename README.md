# people
This project is a .NET Standard 2.0 class library.

This project is designed to help developers when working with personal details. Any developer writing an application which tracks people will find this project a time saver.

##Usage

`Install-Package People`

```
var nameOfPerson = new Savage.People.NameOfPerson("Mr", "Joe", "Bloggs");
var dateOfBirth = new DateTime(1950, 7, 31);
var personalDetails = new Savage.People.PersonalDetails(nameOfPerson, Savage.People.Gender.Male, dateOfBirth);
```

Date of birth can be null if not known:
```
var nameOfPerson = new Savage.People.NameOfPerson("Dr.", "Alice", "Bloggs");
var personalDetails = new Savage.People.PersonalDetails(nameOfPerson, Savage.People.Gender.Male);
```
