using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3_Hannibal_
{
    public class MenuCatalog : IMenuCatalog
    {
        public MenuCatalog()
        {
            _items = new Dictionary<int, IMenuItem>();
        }
        private Dictionary<int, IMenuItem> _items;

        public int Count => _items.Count;

        public void Add(IMenuItem aMenuItem)
        {
            if (!_items.ContainsKey(aMenuItem.Number))
            {
                _items.Add(aMenuItem.Number, aMenuItem); 
            }
            else
            {
                throw new MenuItemNumberExist();
            }
        }

        public IMenuItem Search(int number)
        {
            if (_items.ContainsKey(number))
            {
                return _items[number]; 
            }
            else
            {
                return null;
            }
        }

        public void Delete(int number)
        {
            _items.Remove(number);
        }

        public void PrintPizzasMenu()
        {
            Console.WriteLine(string.Join(
                "\n", from item in _items.Values where item.Type is MenuType.Pizza select item.PrintInfo()));
        }

        public void PrintBeveragesMenu()
        {
            Console.WriteLine(string.Join(
                "\n", from item in _items.Values 
                where item.Type is MenuType.SoftDrink or MenuType.AlcoholicDrink 
                select item.PrintInfo()));
        }

        public void PrintToppingsMenu()
        {
            Console.WriteLine(string.Join(
                "\n", from item in _items.Values
                where item.Type is MenuType.Topping
                select item.PrintInfo()));
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            if (theMenuItem.Number == number && _items.ContainsKey(number))
            {
                Delete(number);
                Add(theMenuItem);
            }
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            return (from item in _items.Values
                where item.Type == type
                where item.IsVegan 
                select item).ToList();
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            return (from item in _items.Values 
                where item.Type == type
                where item.IsOrganic 
                select item).ToList();
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            return (from item in _items.Values orderby item.Price descending select item).First();
        }
    }
}
