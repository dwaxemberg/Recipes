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
    public partial class MainForm : Form
    {
        Database recipeDB = new Database("root", "redwings", "recipes");
        public MainForm()
        {
            InitializeComponent();
            loadRecipes();
        }

        public void loadRecipes()
        {
            ushort numRecipes = recipeDB.getNumRecipes();
            for (int i = 1; i <= numRecipes; i++)
            {
                Recipe rec = recipeDB.getRecipe(i);
                recipeTable.Rows.Add(rec.getID(), rec.getName(), rec.getCategory(), rec.getRate());
            }
            
        }

        public void refreshTable()
        {
            ushort numRecipes = recipeDB.getNumRecipes();
            recipeTable.Clear();
            for (int i = 1; i <= numRecipes; i++)
            {
                Recipe rec = recipeDB.getRecipe(i);
                recipeTable.Rows.Add(rec.getID(), rec.getName(), rec.getCategory(), rec.getRate());
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {            
            refreshTable();                     
        }

        private void btnSelectRecipe_Click(object sender, EventArgs e)
        {
            new ViewRecipe(Convert.ToInt16(datRecipeList.CurrentRow.Cells[0].Value.ToString()), recipeDB);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void datRecipeList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelectRecipe.PerformClick();
        }

        private void datRecipeList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btnSelectRecipe.PerformClick();
            }
        }

        private void btnNewRecipe_Click(object sender, EventArgs e)
        {
            new NewRecipe().Show();
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            int recipeID = Convert.ToInt16(datRecipeList.CurrentRow.Cells[0].Value);
            recipeDB.deleteRecipe(recipeID);
            refreshTable();
        }
    }
}
