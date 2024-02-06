using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT5
{
    internal abstract class Food 
    {
        private string name;
        private string ingredients;
        private double price;
        private float calories;
        public Food()
        {
            //Empty Constructor
        }
        public Food(string name, string ingredients, double price, float calories)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.Price = price;
            this.Calories = calories;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
        public float Calories
        {
            get { return calories; }
            set
            {
                calories = value;
            }
        }
        public abstract void showDetails();
    }
}
