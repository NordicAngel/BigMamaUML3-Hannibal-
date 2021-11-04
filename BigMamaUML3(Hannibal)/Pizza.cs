using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3_Hannibal_
{
    public class Pizza : MenuItem
    {
        private bool _DeepPan;

        public bool DeepPan
        {
            get { return _DeepPan; }
            set { _DeepPan = value; }
        }

        public Pizza(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic, bool deepPan)
            : base(number, name, description, price, type, isVegan, isOrganic)
        {
            _DeepPan = deepPan;
        }
    }
}
