namespace App3_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* --------------- Method Chaning Example --------------- */
            var p = new Pizza();
            p.AddDough("thin").AddSauce().AddCheeze(true).AddToppings("Black Olives", 3.50m);

            Console.WriteLine(p);
        }
    }

    class Pizza
    {
        public string Content { get; set; }
        public decimal TotalPrice {  get; set; }

        public override string ToString()
        {
            return $"{Content} \n ------------------ \nTotal Price: ${TotalPrice.ToString("#.##")}";
        }
    }

    static class PizzaExtensions
    {
        public static Pizza AddDough (this Pizza value, string type)
        {
            value.Content += $"\n{type} Dough x $4.00";
            value.TotalPrice += 4m;
            return value ;
        }
        public static Pizza AddSauce (this Pizza value)
        {
            value.Content += $"\nTomato sauce x $2.00";
            value.TotalPrice += 2m;
            return value ;
        }
        public static Pizza AddCheeze (this Pizza value, bool extra)
        {
            value.Content += extra ? $"\nextra Cheeze x $6.00" : $"\nCheeze x $4.00";
            value.TotalPrice += extra ? 6m : 4m;
            return value ;
        }

        public static Pizza AddToppings (this Pizza value, string type, decimal price)
        {
            value.Content += $"\n{type} x ${price.ToString("#.##")}";
            value.TotalPrice += price;
            return value;
        }
    }

}
