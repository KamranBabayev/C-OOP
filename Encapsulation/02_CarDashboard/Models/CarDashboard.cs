using System;
using System.Collections.Generic;
using System.Text;

namespace _02_CarDashboard.Models
{
    internal class CarDashboard
    {
        private bool _engineOn;
        private int _speed;

        public int Speed {
            get 
            {
                return _speed;

            }
            set
            {
                if (!_engineOn)
                {
                    Console.WriteLine("Engine is OFF! ");
                    return;
                }
                if (value >=0&& value <= 200)
                {
                    _speed = value;
                }
                else
                {
                    Console.WriteLine($"Invalid Speed!");
                }

            }
             
        }

        private int _fuelLevel;
        public int FuelLevel
        {
            get
            {
                return _fuelLevel;
                
            }
            set
            {
               
                if (value >=0 && value <= 100)
                {
                    _fuelLevel = value;
                    if (value < 10)
                    {
                        Console.WriteLine("Low fuel!");
                    }

                }
               


            }
        }

     

        public CarDashboard(int fuellevel)
        {
           
            FuelLevel = fuellevel; 
            
        }


       public void StartEngine()
        {
            _engineOn = true;
           Console.WriteLine("Engine started");
        }

        public void StopEngine()
        {
            _engineOn = false;
            _speed = 0;
            Console.WriteLine("Engine stopped");
        }

        public void ShowStatus()
        {
            string status = _engineOn ? "ON" : "OFF";
            Console.WriteLine($"Engine: {status}");
            Console.WriteLine($"Speed: {_speed}km/h");
            Console.WriteLine($"Fuel level :{_fuelLevel}%");

        }
    }
}
