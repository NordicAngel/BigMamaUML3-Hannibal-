namespace BigMamaUML3_Hannibal_
{
    public enum MenuType { Pizza, Pasta, Topping, SoftDrink, AlcoholicDrink }

    public interface IMenuItem
    {
        int Number { get; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        MenuType Type { get; set; }
        bool IsVegan { get; set; }
        bool IsOrganic { get; set; }
        string PrintInfo();
    }
}