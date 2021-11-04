using System.Collections.Generic;

namespace BigMamaUML3_Hannibal_
{
    public interface IMenuCatalog
    {
        int Count { get; }
        void Add(IMenuItem aMenuItem);
        IMenuItem Search(int number);
        void Delete(int number);
        void PrintPizzasMenu();
        void PrintBeveragesMenu();
        void PrintToppingsMenu();
        void Update(int number, IMenuItem theMenuItem);
        List<IMenuItem> FindAllVegan(MenuType type);
        List<IMenuItem> FindAllOrganic(MenuType type);
        IMenuItem MostExpensiveMenuItem();
    }
}