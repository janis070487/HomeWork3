using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Person
    {

       private DateTime nowTime;
        private string surname;
        private string name;
        private int yearOfBirth;
        private int monthOfBirth;
        private string sex;
        private string hobby;
        private int age;
        private int datebirth;
        

        public string Surname { get { return surname; } set { surname = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        public int MonthOfBirth { get { return monthOfBirth; } set { monthOfBirth = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
        public int Age { get { return age; } }
        public string Hobby { get { return hobby; } set { hobby = value; } }  
        public int DateBirth { get { return datebirth; } }

        public Person(int yearOfBirth, int monthOfBirth, int datebirth)
        {
            nowTime = DateTime.Now;
            this.yearOfBirth = yearOfBirth;
            this.monthOfBirth = monthOfBirth;
            this.datebirth = datebirth;
            
        }

        public int GetAge()
        {

            return age;
        }
        public void ToGreeting()
        {
            Console.WriteLine(nowTime.Minute);
        }
    }
}
