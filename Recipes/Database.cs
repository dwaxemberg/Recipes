using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Recipes
{
    public class Database
    {
        MySqlConnection con;

        //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
        public Database(string username, string password, string database)
        {
            String connectionString = "SERVER=localhost;" +
                                      "DATABASE=" + database +
                                      ";USERNAME=" + username +
                                      ";PASSWORD=" + password + ";";
            this.con = new MySqlConnection(connectionString);
        }

        public void closeConnection()
        {
            con.Close();
        }

        public ushort getNumRecipes()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from recipe",con);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            ushort numRecipes = 0;
            while (reader.Read())
            {
                numRecipes++;
            }
            con.Close();
            return numRecipes;
        }

        public Recipe getRecipe(int ID)
        {
            //get recipe from database, make instance, return it

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from recipe where ID=" + ID;
            MySqlDataReader reader;
            string recipe = "";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    recipe += reader.GetValue(i).ToString() + ",";
                }
            }
            recipe = recipe.Substring(recipe.IndexOf(',')+1);
            string recipeName = recipe.Substring(0, recipe.IndexOf(','));
            recipe = recipe.Substring(recipe.IndexOf(',')+1);
            string longIngredients = recipe.Substring(0, recipe.IndexOf(','));
            recipe = recipe.Substring(recipe.IndexOf(',')+1);
            string[] recipeIngredients = new string[getNumIngredients(longIngredients)];
            ushort j = 0;
            while (longIngredients.Contains('$'))
            {
                recipeIngredients[j] = longIngredients.Substring(0, longIngredients.IndexOf('$'));
                longIngredients = longIngredients.Substring(longIngredients.IndexOf('$')+1);
                j++;
            }
            recipeIngredients[j] = longIngredients;
            string recipeDirections = recipe.Substring(0, recipe.IndexOf(','));
            recipe = recipe.Substring(recipe.IndexOf(',')+1);
            string recipeCategory = recipe.Substring(0, recipe.IndexOf(','));
            recipe = recipe.Substring(recipe.IndexOf(',') + 1);
            string recipePreparation = recipe.Substring(0, recipe.IndexOf(','));
            recipe = recipe.Substring(recipe.IndexOf(',') + 1);
            string recipeYield = recipe.Substring(0, recipe.IndexOf(','));
            recipe = recipe.Substring(recipe.IndexOf(',') + 1);
            int recipeRating = Convert.ToInt32(recipe.Substring(0, recipe.IndexOf(',')));
            recipe = recipe.Substring(recipe.IndexOf(',') + 1);
            string recipeImagePath = recipe.Substring(0, recipe.IndexOf(','));
            con.Close();
            return new Recipe(ID, recipeName, recipeIngredients, recipeDirections, recipeCategory, recipePreparation, recipeYield, recipeRating, recipeImagePath);
            
        }

        public ushort getNumIngredients(string allIngredients)
        {
            ushort numIngredients = 0;
            while (allIngredients.Contains('$'))
            {
                allIngredients = allIngredients.Substring(allIngredients.IndexOf('$')+1);
                numIngredients++;
            }
            numIngredients++;
            return numIngredients;
        }

        public void updateRecipe(Recipe rec)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE `recipe` SET "
                + "`Name`='" + rec.getName()
                + "', `Ingredients`='" + rec.getLongIngredients()
                + "', `Directions`='" + rec.getLongDirections()
                + "', `Category`='" + rec.getCategory()
                + "', `PreparationTime`='" + rec.getPrepTime()
                + "', `Yield`='" + rec.getYield()
                + "', `Rating`='" + rec.getStars()
                + "', `ImagePath`='" + rec.getImagePath()
                + "' WHERE (`ID`='" + rec.getID() + "')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void createNewRecipe(Recipe rec)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO `recipe` (`Name`,`Ingredients`,`Directions`,"
                + "`Category`,`PreparationTime`,`Yield`,`Rating`,`ImagePath`) VALUES "
                + "('" + rec.getName() + "','" + rec.getLongIngredients() + "','"
                + rec.getLongDirections() + "','" + rec.getCategory() + "','"
                + rec.getPrepTime() + "','" + rec.getYield() + "','" + rec.getStars()
                + "','" + rec.getImagePath()
                + "')";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
             
        }

        public void deleteRecipe(int recipeID)
        {
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM `recipe` WHERE `ID`='" + recipeID + "'";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
