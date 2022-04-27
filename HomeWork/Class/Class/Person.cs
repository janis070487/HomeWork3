
namespace Class
{
    public class Person
    {
        private string surname;
        private string name;
        private int yearOfBirth;
        private int monthOfBirth;
        private string sex;
        private string hobby;
        private int datebirth;
        

        public string Surname { get { return surname; } set { surname = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        public int MonthOfBirth { get { return monthOfBirth; } set { monthOfBirth = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
      
        public string Hobby { get { return hobby; } set { hobby = value; } }  
        public int DateBirth { get { return datebirth; } }

        public Person(int yearOfBirth, int monthOfBirth, int datebirth)
        {
            
            this.yearOfBirth = yearOfBirth;
            this.monthOfBirth = monthOfBirth;
            this.datebirth = datebirth;
            
        }

        public int GetAge()
        {
            int age;
            age = DateTime.Now.Year - yearOfBirth;

            if(DateTime.Now.Month <= monthOfBirth)
            {
                if (DateTime.Now.Month < monthOfBirth)
                {
                    age--;
                }

                if (DateTime.Now.Month == monthOfBirth)
                {
                    if (DateTime.Now.Day < datebirth)
                    {
                        age--;
                    }
                }
            }

            return age;
        }
        public void ToGreeting()
        {
            Console.WriteLine();
            Console.WriteLine($"Hello my name is {name} {surname} and I am {GetAge()} year");
        }
    }
}
