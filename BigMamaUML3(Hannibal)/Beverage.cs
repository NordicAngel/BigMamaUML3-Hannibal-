using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3_Hannibal_
{
    public class Beverage : MenuItem
    {
        private bool _alcoholic;

        public Beverage(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool alcoholic) : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _alcoholic = alcoholic;
        }

        public bool Alcoholic
        {
            get { return _alcoholic; }
            set { _alcoholic = value; }
        }

    }
}
