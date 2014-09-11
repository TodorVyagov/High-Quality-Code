using System;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;

        public Student(string firstName, string lastName, string birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = ConvertStringToDateTime(birthDate);
        }

        public Student(string firstName, string lastName, string birthDate, string additionalInfo)
            : this(firstName, lastName, birthDate)
        {
            this.OtherInfo = additionalInfo;
        }

        public string OtherInfo { get; set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                ValidateName(value);
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                ValidateName(value);
                this.lastName = value;
            }
        }


        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            private set
            {
                this.birthDate = value;
            }
        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name cannot be null or empty!");
            }

            foreach (var letter in name)
            {
                if (!char.IsLetter(letter)) //if char is not letter
                {
                    throw new ArgumentException("Name must contain only letters!");
                }
            }
        }

        private DateTime ConvertStringToDateTime(string dateString)
        {
            DateTime date;
            bool isValidDate = DateTime.TryParse(dateString, out date);

            if (isValidDate)
            {
                return date;
            }
            else
            {
                throw new ArgumentException("Given date is invalid!");
            }
        }

        public bool IsOlderThan(Student other)
        {
            bool isOlder = this.BirthDate < other.BirthDate;
            return isOlder;
        }
    }
}
