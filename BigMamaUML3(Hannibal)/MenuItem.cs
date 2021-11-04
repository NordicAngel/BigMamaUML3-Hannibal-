using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3_Hannibal_
{
    public abstract class MenuItem : IMenuItem
    {
        private int _number;
        private string _name;
        private string _description;
        private double _price;
        private MenuType _type;
        private bool _isVegan;
        private bool _isOrganic;

        public MenuItem(int number, string name, string description, double price, MenuType type, bool isVegan, bool isOrganic)
        {
            _number = number;
            _name = name;
            _description = description;
            _price = price;
            _type = type;
            _isVegan = isVegan;
            _isOrganic = isOrganic;
        }

        public int Number => _number;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public MenuType Type
        {
            get => _type;
            set => _type = value;
        }

        public bool IsVegan
        {
            get => _isVegan;
            set => _isVegan = value;
        }

        public bool IsOrganic
        {
            get => _isOrganic;
            set => _isOrganic = value;
        }

        public string PrintInfo()
        {
            return $"{_number}. {_name} {_price} kr. {_type}\n{_description}\nOrganic: {_isOrganic} Vegan: {_isVegan}";
        }
    }
}
