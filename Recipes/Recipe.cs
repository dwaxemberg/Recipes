using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipes
{
    public class Recipe
    {
        int ID;
        string name;
        string[] ingredients;
        string directions;
        string category;
        string prepTime;
        string yield;
        int rating;
        string imagePath;


        public Recipe(int ID, string name, string[] ingredients, string directions, string category, string prepTime, string yield, int rating, string imagePath)
        {
            this.ID = ID;
            this.name = name;
            this.ingredients = ingredients;
            this.directions = multiline(directions);
            this.category = category;
            this.prepTime = prepTime;
            this.yield = yield;
            this.rating = rating;
            this.imagePath = imagePath;
        }

        public void setImagePath(string path)
        {
            imagePath = path;
        }

        public string getImagePath()
        {
            return imagePath;
        }

        public string getLongDirections()
        {
            return directions.Replace("\r\n", "@");
        }

        public string getLongIngredients()
        {
            string longIngredients = "";
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (i < ingredients.Length - 1)
                    longIngredients = longIngredients + ingredients[i] + "$";
                else
                    longIngredients = longIngredients + ingredients[i];
            }
            return longIngredients;
        }

        public void setRating(int rating)
        {
            this.rating = rating;
        }

        public int getStars()
        {
            return rating;
        }

        public string getRate()
        {
            if (rating >= 0)
            {
                return "" + rating + " out of 5";
            }
            return "No Rating";
        }
        public string multiline(string text)
        {
            return text.Replace("@", "\r\n");
        }

        public string getPrepTime()
        {
            return prepTime;
        }

        public void setPrepTime(string prepTime)
        {
            this.prepTime = prepTime;
        }

        public string getYield()
        {
            return yield;
        }

        public void setYield(string yield)
        {
            this.yield = yield;
        }

        public int getNumIngredients()
        {
            return ingredients.Length;
        }  

        public int getID()
        {
            return ID;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string[] getIngredients()
        {
            return ingredients;
        }

        public string getDirections()
        {
            return directions;
        }

        public void setDirections(string directions)
        {
            this.directions = directions;
        }

        public string getCategory()
        {
            return category;
        }

        public void setCategory(string category)
        {
            this.category = category;
        }
    }
}
