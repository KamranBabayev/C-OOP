using System;
namespace _01_SmartLamp
{
    public  class SmartLamp
    {
        private bool _isOn;
        private int _brightness;
        public int Brightness
        {
            get
            {
                return _brightness;
            }
            set
            {
                if (value < 0 ||value > 100)
                {
                    Console.WriteLine("Invalid brightness!");
                }
                else
                {
                    _brightness = value;
                }
            }
        }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _color = value;
                }
                else
                {
                    Console.WriteLine("Invalid color!");
                }
            }
        }



        public SmartLamp()
        {

        }

        public SmartLamp(int brightness,string color)
        {
            Brightness = brightness;
            Color = color;
        }


        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Lamp is ON");
        }
        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Lamp is OFF");
        }

        public void ShowStatus()
        {
            string status = _isOn ? "ON" :"OFF" ;
            Console.WriteLine($"Lamp status:{status},Brightness:{_brightness},Color:{_color}");
                

        }
    }
}
