using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Phone
    {


        private double width;
        private double height;
        private double lenght;
        private string brand;
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Brand { get { return brand; } }
        public double Width { get { return width; } set { width = value; } }
        public double Height { get { return height; } set { height = value; } }
        public double Lenght { get { return lenght; } set { lenght = value; } }
        public Phone(string _brand)
        {
            brand = _brand;
        }

        public void SendSms(string number, string mesage)
        {
            Console.WriteLine($"Jus nosūtījāt ziņu {"\n"}{mesage}{"\n"} uz numuru > {number}");
        }

        public void Call(string numbers)
        {
            Console.WriteLine($"Jūs zvanāt uz numuru > {numbers}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Telefona Zīmols  : {brand}{"\t"}Telefona Modelis : {model}");
            Console.WriteLine($"telefona izmērs{"\n"}Platums : {width}{"\n"}Garums : {lenght}{"\n"}Augstums : {height}");
            double volume = width * height * lenght;
            Console.WriteLine($"Telefona tilpums : {volume}");
        }


    }
}
