using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMamaUML3_Hannibal_
{
    public class MenuCatalog : IMenuCatalog
    {
        public MenuCatalog()
        {
            _items = new List<IMenuItem>();
        }
        private List<IMenuItem> _items;

        public int Count => _items.Count;

        public void Add(IMenuItem aMenuItem)
        {
            _items.Add(aMenuItem);
        }

        public IMenuItem Search(int number)
        {
            throw new NotImplementedException();
        }

        public void Delete(int number)
        {
            throw new NotImplementedException();
        }

        public void PrintPizzasMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintBeveragesMenu()
        {
            throw new NotImplementedException();
        }

        public void PrintToppingsMenu()
        {
            throw new NotImplementedException();
        }

        public void Update(int number, IMenuItem theMenuItem)
        {
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllVegan(MenuType type)
        {
            throw new NotImplementedException();
        }

        public List<IMenuItem> FindAllOrganic(MenuType type)
        {
            throw new NotImplementedException();
        }

        public IMenuItem MostExpensiveMenuItem()
        {
            throw new NotImplementedException();
        }
    }
}
