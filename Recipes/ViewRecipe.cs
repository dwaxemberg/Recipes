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

    public partial class ViewRecipe : Form
    {
        Database recipeDB;
        Recipe viewRec;
        Bitmap b;
        Bitmap s;
        bool editing = false;

        TextBox txtEditName = new TextBox();
        TextBox txtEditPrepTime = new TextBox();
        TextBox txtEditYield = new TextBox();
        
        public ViewRecipe(int recipeID, Database recipeDB)
        {
            InitializeComponent();
            this.recipeDB = recipeDB;
            viewRec = recipeDB.getRecipe(recipeID);
            displayRecipe(viewRec);
            this.Text = viewRec.getName();
            this.Show();
        }

        public void displayRecipe(Recipe viewRec)
        {
            b = new Bitmap(star1.Image, star1.Size);
            s = new Bitmap(star2.Image, star2.Size);
            changeStars(viewRec.getStars());
            lblRecipeName.Text = viewRec.getName();
            if (viewRec.getPrepTime().Length > 0)
            {
                lblPrepTime.Text = "Preparation Time: " + viewRec.getPrepTime();
            }
            else
            {
                lblPrepTime.Visible = false;
            }
            if (viewRec.getYield().Length > 0)
            {
                lblYield.Text = "Yield: " + viewRec.getYield();
            }
            else
            {
                lblYield.Visible = false;
            }
            lblRecipeName.Location = new System.Drawing.Point((int)(.5 * this.Size.Width) - (int)(.5 * lblRecipeName.Width), lblRecipeName.Location.Y);
            grdIngredients.Rows.Clear();
            for (int i = 0; i < viewRec.getNumIngredients(); i++)
            {
                grdIngredients.Rows.Add(viewRec.getIngredients()[i]);
            }
            
            txtDirections.Text = viewRec.getDirections();
            
        }

        private void changeStars(int Rating)
        {
            #region Stars
            switch (Rating)
            {
                case 0:
                    {
                        star1.Image = b;
                        star2.Image = b;
                        star3.Image = b;
                        star4.Image = b;
                        star5.Image = b;
                        break;
                    }
                case 1:
                    {
                        star1.Image = s;
                        star2.Image = b;
                        star3.Image = b;
                        star4.Image = b;
                        star5.Image = b;
                        break;
                    }
                case 2:
                    {
                        star1.Image = s;
                        star2.Image = s;
                        star3.Image = b;
                        star4.Image = b;
                        star5.Image = b;
                        break;
                    }
                case 3:
                    {
                        star1.Image = s;
                        star2.Image = s;
                        star3.Image = s;
                        star4.Image = b;
                        star5.Image = b;
                        break;
                    }
                case 4:
                    {
                        star1.Image = s;
                        star2.Image = s;
                        star3.Image = s;
                        star4.Image = s;
                        star5.Image = b;
                        break;
                    }
                case 5:
                    {
                        star1.Image = s;
                        star2.Image = s;
                        star3.Image = s;
                        star4.Image = s;
                        star5.Image = s;
                        break;
                    }
                default:
                    {
                        star1.Image = b;
                        star2.Image = b;
                        star3.Image = b;
                        star4.Image = b;
                        star5.Image = b;
                        break;
                    }
            }
            #endregion
        }
            

        private void ViewRecipe_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewRecipe_Resize(object sender, EventArgs e)
        {
            lblRecipeName.Location = new System.Drawing.Point((int)(.5 * this.Size.Width) - (int)(.5 * lblRecipeName.Width), lblRecipeName.Location.Y);
        }

        private void txtDirections_Resize(object sender, EventArgs e)
        {
            txtDirections.Font = new System.Drawing.Font(txtDirections.Font.FontFamily, (float)(((txtDirections.Size.Height / 100) * txtDirections.Size.Width)/80));
            if (txtDirections.Font.Size > 20)
            {
                txtDirections.Font = new System.Drawing.Font(txtDirections.Font.FontFamily, (float)20);
            }
            if (txtDirections.Font.Size < 8)
            {
                txtDirections.Font = new System.Drawing.Font(txtDirections.Font.FontFamily, (float)8);
            }
        }

        private void grdIngredients_Resize(object sender, EventArgs e)
        {

            grdIngredients.Font = new System.Drawing.Font(grdIngredients.Font.FontFamily, (float)((grdIngredients.Size.Width) / 80));
            if (grdIngredients.Font.Size > 20)
            {
                grdIngredients.Font = new System.Drawing.Font(grdIngredients.Font.FontFamily, (float)20);
            }
            if (grdIngredients.Font.Size < 8)
            {
                grdIngredients.Font = new System.Drawing.Font(grdIngredients.Font.FontFamily, (float)8);
            }
        }

        private void star1_Click(object sender, EventArgs e)
        {
            changeStars(1);
            viewRec.setRating(1);
            recipeDB.updateRecipe(viewRec);
        }

        private void star2_Click(object sender, EventArgs e)
        {
            changeStars(2);
            viewRec.setRating(2);
            recipeDB.updateRecipe(viewRec);
        }

        private void star3_Click(object sender, EventArgs e)
        {
            changeStars(3);
            viewRec.setRating(3);
            recipeDB.updateRecipe(viewRec);
        }

        private void star4_Click(object sender, EventArgs e)
        {
            changeStars(4);
            viewRec.setRating(4);
            recipeDB.updateRecipe(viewRec);
        }

        private void star5_Click(object sender, EventArgs e)
        {
            changeStars(5);
            viewRec.setRating(5);
            recipeDB.updateRecipe(viewRec);
        }

        private void star1_MouseHover(object sender, EventArgs e)
        {
            changeStars(1);
        }

        private void star2_MouseHover(object sender, EventArgs e)
        {
            changeStars(2);
        }

        private void star3_MouseHover(object sender, EventArgs e)
        {
            changeStars(3);
        }

        private void star4_MouseHover(object sender, EventArgs e)
        {
            changeStars(4);
        }

        private void star5_MouseHover(object sender, EventArgs e)
        {
            changeStars(5);
        }

        private void star_MouseLeave(object sender, EventArgs e)
        {
            changeStars(viewRec.getStars());
        }

        private void btnViewImage_Click(object sender, EventArgs e)
        {
            new ViewImage(viewRec);
        }

        private void btnEditRecipe_Click(object sender, EventArgs e)
        {
           
            if (!editing)
            {
                editing = true;
                btnEditRecipe.Text = "Save";
                txtDirections.ReadOnly = false;

                grdIngredients.ReadOnly = false;
                grdIngredients.AllowUserToAddRows = true;
                grdIngredients.AllowUserToDeleteRows = true;
                
                grdIngredients.RowHeadersVisible = true;
                grdIngredients.ColumnHeadersVisible = true;
                grdIngredients.Refresh();

                txtEditName.Parent = this;
                txtEditName.Location = lblRecipeName.Location;
                txtEditName.Text = lblRecipeName.Text;
                txtEditName.Visible = true;
                
                txtEditPrepTime.Parent = this;
                txtEditPrepTime.Location = lblPrepTime.Location;
                txtEditPrepTime.Text = lblPrepTime.Text;
                txtEditPrepTime.Visible = true;
                
                txtEditYield.Parent = this;
                txtEditYield.Location = lblYield.Location;
                txtEditYield.Text = lblYield.Text;
                txtEditYield.Visible = true;

                lblPrepTime.Visible = false;
                lblYield.Visible = false;
                lblRecipeName.Visible = false;
            }
            else
            {
                editing = false;
                btnEditRecipe.Text = "Edit";
                txtDirections.ReadOnly = true;
                
                grdIngredients.ReadOnly = true;
                grdIngredients.AllowUserToDeleteRows = false;
                grdIngredients.AllowUserToAddRows = false;
                grdIngredients.RowHeadersVisible = false;
                grdIngredients.ColumnHeadersVisible = false;

                txtEditName.Visible = false;
                lblRecipeName.Text = txtEditName.Text;
                txtEditPrepTime.Visible = false;
                lblPrepTime.Text = txtEditPrepTime.Text;
                txtEditYield.Visible = false;
                lblYield.Text = txtEditYield.Text;
                lblRecipeName.Location = new System.Drawing.Point((int)(.5 * this.Size.Width) - (int)(.5 * lblRecipeName.Width), lblRecipeName.Location.Y);

                this.Text = lblRecipeName.Text;
                lblRecipeName.Visible = true;
                lblYield.Visible = true;
                lblPrepTime.Visible = true;

                viewRec.setName(lblRecipeName.Text);
                viewRec.setPrepTime(lblPrepTime.Text.Replace("Preparation Time:",""));
                viewRec.setDirections(txtDirections.Text);
                viewRec.setYield(lblYield.Text.Replace("Yield:",""));
                recipeDB.updateRecipe(viewRec);

            }
        }

    }
}
