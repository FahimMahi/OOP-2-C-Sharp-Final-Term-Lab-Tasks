using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT6pt2
{
    internal class Restaurant
    {
        private string restaurantName;
        private Food[] order;
        public int index;
        public Restaurant()
        {
            //Empty Constructor
        }
        public Restaurant(string restaurantName)
        {
            this.RestaurantName = restaurantName;
            this.Order = new Food[100];
            this.index = 0;
        }
        public string RestaurantName
        {
            get { return restaurantName; }
            set { restaurantName = value; }
        }
        public Food[] Order
        {
            get { return order; }
            set { order = value; }
        }
        public void showDetails()
        {
            Console.WriteLine("Resturant Name: " + RestaurantName);
        }
        private double calculateBill;
        public double CalculateBill
        {
            get { return calculateBill; }
            set { calculateBill = value; }
        }
        public bool addToOrder(Food f)
        {
            if (this.index == 100)
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
            Console.WriteLine("Order 1 Name: " + pizza7.Name);
            Console.WriteLine("Order 1 Price: " + pizza7.Price);
            Console.WriteLine("Order 2 Name: " + burger7.Name);
            Console.WriteLine("Order 2 Price: " + burger7.Price);
            Console.WriteLine("Order 3 Name: " + drinks7.Name);
            Console.WriteLine("Order 3 Price: " + drinks7.Price);
            CalculateBill = pizza7.Price + burger7.Price + drinks7.Price;
            Console.WriteLine("Total Price: " + CalculateBill);
            Console.WriteLine();
        }
    }
}
