using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT5
{
    internal class RestaurantOperation : Restaurant
    {
        private double calculateBill;
        public bool addToOrder(Food f)
        {
            if(this.index == 100)
                return false;
            this.Order[index++] = f;
            return true;
        }
        public bool removeFromOrder(Food f)
        {
            if (this.index == 0)
                return false;
            this.Order[index--] = f;
            return true;

        }
        public void ShowOrders()
        {
            CalculateBill = 0;

            Pizza pizza7 = new Pizza("Big Pizza", "Beef, Chicken, Capsicum, Mashroom and Pepper", 450, 288, 14);

            Burger burger7 = new Burger("Naga Burger", "Spice, Patty and Beef", 150, 301, 2);

            Drinks drinks7 = new Drinks("Mojo", "CARBONATED WATER, HIGH FRUCTOSE CORN SYRUP, CARAMEL COLOR, PHOSPHORIC ACID, NATURAL FLAVORS, CAFFEINE.", 40, 350, "Soft Drinks", 1);
            Console.WriteLine();
            Console.WriteLine("Order 1 Name: " +pizza7.Name);
            Console.WriteLine("Order 1 Price: " + pizza7.Price);
            Console.WriteLine("Order 2 Name: " + burger7.Name);
            Console.WriteLine("Order 2 Price: " + burger7.Price);
            Console.WriteLine("Order 3 Name: " + drinks7.Name);
            Console.WriteLine("Order 3 Price: " + drinks7.Price);
            CalculateBill = pizza7.Price + burger7.Price + drinks7.Price;
            Console.WriteLine("Total Price: " + CalculateBill);
            Console.WriteLine();
        }
        public double CalculateBill
        {
            get { return calculateBill; }
            set { calculateBill = value; }
        }
    }
}
