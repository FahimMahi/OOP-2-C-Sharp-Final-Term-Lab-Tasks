using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT5
{
    internal class FoodOperation : Food
    {
        public int index;
        public bool removeIngredient(string ingredient)
        {
            if (this.index == 0)
                return false;
            index--;
            return true;
        }
        public bool addingredient(string ingredient)
        {
            if (this.index == 100)
                return false;
            index++;
            return true;
        }

        public override void showDetails()
        {
            Pizza pizza6 = new Pizza("Beef Pizza", "Beef, Capsicum, Mashroom and Pepper", 420, 275, 14);
            pizza6.showDetails();
            Console.WriteLine();

            Burger burger6 = new Burger("Big Burger", "Salad, Beef Patty and Chicken", 250, 350, 4);
            burger6.showDetails();
            Console.WriteLine();

            Drinks drinks6 = new Drinks("Fanta", "Carbonated water, high fructose corn syrup, caramel color, sugar, phosphoric acid, caffeine, citric acid, and natural flavors.", 70, 200, "Carbonated soft drink", 1);
            drinks6.showDetails();
            Console.WriteLine();
        }
    }
}
