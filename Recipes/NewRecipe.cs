using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recipes
{
    public partial class NewRecipe : Form
    {
        string imagePath;
        public NewRecipe()
        {
            InitializeComponent();
            imagePath = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtRecipeName.Text == "")
            {
                MessageBox.Show("You must enter a name for the new recipe!");
            }
            else
            {
                Database recipeDB = new Database("root", "redwings", "recipes");
                Recipe newRecipe = new Recipe(recipeDB.getNumRecipes() + 1, txtRecipeName.Text,
                    getIngredients(), txtDirections.Text, txtCategory.Text,
                    txtPrepTime.Text, txtYield.Text, -1, imagePath);
                recipeDB.createNewRecipe(newRecipe);
                this.Dispose();
            }

        }

        private string[] getIngredients()
        {
            string[] ingredients = new string[grdIngredients.RowCount];
            for (int i = 0; i < grdIngredients.RowCount-1; i++)
            {
                ingredients[i] = grdIngredients.Rows[i].Cells[0].Value.ToString();
            }
            return ingredients;
        }

        private void btnScanImage_Click(object sender, EventArgs e)
        {
            DialogResult dlgRes = dlgScanImage.ShowDialog(this);
            new ViewImage(dlgScanImage.FileName.Replace("\\", "\\\\"));
            imagePath = dlgScanImage.FileName.Replace("\\","\\\\");
            MessageBox.Show("The image has been associated with this recipe.", "Association Successful");
        }

        private void NewRecipe_Load(object sender, EventArgs e)
        {

        }

        
    }
}
