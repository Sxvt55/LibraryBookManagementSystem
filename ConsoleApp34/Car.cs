using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Car
    {
        private string _make;
        private string _model;
        private int _year;
        private int _speed;


        public string make { get { return _make; } set { _make = value; } }
        public string model { get { return _model; } set { _model = value; } }
        public int year { get { return _year; } set { _year = value; } }
        public int speed
        {
            get { return _speed; }
            set
            {
                if (value >= 0)
                {
                    if (value <= 220)
                    {
                        _speed = value;
                    }
                    else
                    {
                        Console.WriteLine("It's OK");
                    }
                }
                else
                {
                    Console.WriteLine("Speed cannot be negative");
                }
            }
        }





        public void SetCarInfo(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;

        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

    }

}
