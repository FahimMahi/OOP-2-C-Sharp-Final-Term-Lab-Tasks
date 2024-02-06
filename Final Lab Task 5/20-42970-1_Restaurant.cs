using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT5
{
    internal class Restaurant : Food
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
        public Food [] Order
        {
            get { return order; }
            set { order = value; }
        }
        public override void showDetails()
        {
            Console.WriteLine("Resturant Name: " +RestaurantName);
        }
    }
}
