using System;
using System.Linq;

namespace RefactorCode
{
    class MainClass
    {
        enum Gender { Male, Female };

        class Person
        {
            public Gender Sex { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public void AddPerson(int socialSecurityNumber) 
        {
            Person newPerson = new Person();
            newPerson.Age = socialSecurityNumber;
            if (socialSecurityNumber % 2 == 0)
            {
                newPerson.Name = "Batkata";
                newPerson.Sex = Gender.Male;
            }
            else
            {
                newPerson.Name = "Maceto";
                newPerson.Sex = Gender.Female;
            }
        }
    }
}
