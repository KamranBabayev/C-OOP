using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDoor.Models
{
    internal class SmartDoor
    {
        private bool _isLocked;
        private bool _isOpen;
        private string _password;
        public string Password {
            get
            {
                return _password;

            }

            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Password too short!");
                }
                else
                {
                    _password = value;
                }
            }

        }


        public SmartDoor()
        {
            _isLocked = true;
            _isOpen = false;

        }
        public void LockDoor()
        {
            _isLocked = true;
            _isOpen = false;
            Console.WriteLine("Door locked");
        }


        public void UnlockDoor(string password)
        {
          
            if (password==_password)
            {
                _isLocked = false;
                Console.WriteLine("Door unlocked");
            }
            else
            {
                Console.WriteLine("incorrect password");
            }
        }


        public void OpenDoor()
        {
            if (_isLocked)
            {
                Console.WriteLine("Door is locked!");
                return;
            }

            _isOpen = true;
            Console.WriteLine("Door is open");
        }


        public void CloseDoor()
        {
            _isOpen = false;
            Console.WriteLine("Door closed");
        }

        public void ShowStatus()
        {
            string doorStatus = _isLocked ? "Locked" : "Unlocked";
            string openStatus = _isOpen ? "Yes" : "No";

            Console.WriteLine($"Door status: {doorStatus}");
            Console.WriteLine($"Is open: {openStatus}");
        }
    }
}
