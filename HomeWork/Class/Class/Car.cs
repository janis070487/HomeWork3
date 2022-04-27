
namespace Class
{
    public class Car
    {
        private string _brand;
        private string numberPlate;
        private double speed;

        public Car(string brand) { _brand = brand; }
        public string Brand { get { return _brand; } }

        public double Speed { get { return speed; } }
        public string NumberPlace
        {
            get
            {
                return numberPlate;
            }
            set
            {
                numberPlate = value;
            }
        }

        public void StartDriving(double _speed)
        {
            speed = _speed;
            Console.WriteLine($"Jūs sākāt kustību ar ātrumu {_speed} Km/h");
        }
       
        public void IncreaseSpeed(double _speed)
        {
            speed += _speed;
        }

        public void StopDriving()
        {
            speed = 0;
            Console.WriteLine("Jūs beidzāt kustību");
        }
      
        public void ReduceSpeed(double _speed)
        {
            speed -= _speed;
        }

        public void ToSignal()
        {
            Console.WriteLine("Beep beep");
        }

    }
}
