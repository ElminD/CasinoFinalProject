using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class user
    {

        private string _name;
        private int _chips;

        public user(string name, int chips)
        {
            _name = "";
            _chips = 1000;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Chips
        {
            get { return _chips; }
            set { _chips = value; }
        }
    }
}
