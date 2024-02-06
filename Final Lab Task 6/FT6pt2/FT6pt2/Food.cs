using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT6pt2
{
    internal class Food
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
        public void showDetails()
        {
            Console.WriteLine("Drinks:\nName: " + Name);
            Console.WriteLine("Ingredients: " + Ingredients);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Calories: " + Calories);
        }
    }
}
