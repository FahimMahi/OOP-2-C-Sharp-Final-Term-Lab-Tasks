using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT6pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("Madchef");
            restaurant.showDetails();
            Console.WriteLine();

            Drinks drinks = new Drinks("Pepsi", "Carbonated water, high fructose corn syrup, caramel color, sugar, phosphoric acid, caffeine, citric acid, and natural flavors.", 60, 105, "Carbonated soft drink", 1);
            drinks.showDetails();
            Console.WriteLine();
            Drinks drinks1 = new Drinks("Coca Cola", "CARBONATED WATER, HIGH FRUCTOSE CORN SYRUP, CARAMEL COLOR, PHOSPHORIC ACID, NATURAL FLAVORS, CAFFEINE.", 70, 350, "Soft Drinks", 1);
            drinks1.showDetails();
            Console.WriteLine();
            Drinks drinks2 = new Drinks("Mojo", "CARBONATED WATER, HIGH FRUCTOSE CORN SYRUP, CARAMEL COLOR, PHOSPHORIC ACID, NATURAL FLAVORS, CAFFEINE.", 40, 350, "Soft Drinks", 1);
            drinks2.showDetails();
            Console.WriteLine();
            Drinks drinks3 = new Drinks("Colors", "Carbonated water, high fructose corn syrup, caramel color, sugar, phosphoric acid, caffeine, citric acid, and natural flavors.", 40, 105, "Carbonated soft drink", 1);
            drinks3.showDetails();
            Console.WriteLine();
            Drinks drinks4 = new Drinks("Fanta", "Carbonated water, high fructose corn syrup, caramel color, sugar, phosphoric acid, caffeine, citric acid, and natural flavors.", 70, 200, "Carbonated soft drink", 1);
            drinks4.showDetails();
            Console.WriteLine();

            Burger burger = new Burger("Naga Burger", "Spice, Patty and Beef", 150, 301, 2);
            burger.showDetails();
            Console.WriteLine();
            Burger burger1 = new Burger("Beef Burger", "Salad, Patty and Beef", 130, 290, 2);
            burger1.showDetails();
            Console.WriteLine();
            Burger burger2 = new Burger("Egg Burger", "Egg, Salad and Patty", 100, 200, 1);
            burger2.showDetails();
            Console.WriteLine();
            Burger burger3 = new Burger("Chicken Burger", "Salad, Patty and Chicken", 150, 270, 2);
            burger3.showDetails();
            Console.WriteLine();
            Burger burger4 = new Burger("Big Burger", "Salad, Beef Patty and Chicken", 250, 350, 4);
            burger4.showDetails();
            Console.WriteLine();

            Pizza pizza1 = new Pizza("Big Pizza", "Beef, Chicken, Capsicum, Mashroom and Pepper", 450, 288, 14);
            pizza1.showDetails();
            Console.WriteLine();
            Pizza pizza2 = new Pizza("Chicken Pizza", "Chicken, Capsicum, Mashroom and Pepper", 400, 278, 14);
            pizza2.showDetails();
            Console.WriteLine();
            Pizza pizza3 = new Pizza("Beef Pizza", "Beef, Capsicum, Mashroom and Pepper", 420, 275, 14);
            pizza3.showDetails();
            Console.WriteLine();
            Pizza pizza4 = new Pizza("Small Pizza", "Beef, Chicken, Capsicum, Mashroom and Pepper", 300, 228, 8);
            pizza4.showDetails();
            Console.WriteLine();
            Pizza pizza5 = new Pizza("Wonder Pizza", "Beef, Chicken, Capsicum, Mashroom and Pepper", 350, 250, 10);
            pizza5.showDetails();
            Console.WriteLine();

            restaurant.ShowOrders();
        }
    }
}
