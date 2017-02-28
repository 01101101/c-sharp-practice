using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_task
{
    class Car
    {
        private string _brand;//one way is to name private variables ex. _mark or variables that show outside with Uppercase ex. Mark
        private double _speed;

        //Default Constructor
        public Car ()
        {
            _brand = "Ford";
            _speed = 80.0;
        }
        //Constructor with parameters
        public Car(string brand, double speed)// variables named almost the same but could be different. Same function so almost the same
        {
            this._brand = brand;
            this._speed = speed;
        }
        //Properties
        public string Brand
        {
            get { return _brand; } //it is possible to remove either of these so to not be able to set or retrieve the value
            set { _brand = value; } //
        }
        public double Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        //Methods
        public string RetrieveData()
        {
            return string.Format("Merkki: {0}\nNopeus: {1} km/h", _brand, _speed);
        }
        public void Accelerate(double acceleration)
        {
            _speed = _speed + (_speed * acceleration);
        }
        public void Decelarate(double deceleration)
        {
            _speed = _speed - (_speed * deceleration);
        }

        public override string ToString()
        {
            return Print();
        }

        private string Print()
        {
            return "Brand: " +_brand + "  Speed:" + _speed;
        }
    }
}
