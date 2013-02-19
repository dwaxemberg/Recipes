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
    public partial class ViewImage : Form
    {
        Database recipeDB = new Database("root", "redwings", "recipes");
        Recipe rec;
        Bitmap source;

        public ViewImage(string imageSource)
        {
            InitializeComponent();
            try
            {
                source = new Bitmap(imageSource);
                Bitmap b = new Bitmap((Image)source, picImage.Size);
                picImage.Image = (Image)b;
            }
            catch (Exception)
            {
                MessageBox.Show("The specified file could not be opened.");
                picImage.Image = picImage.ErrorImage;
            }
            this.Show();
        }
        public ViewImage(Recipe rec)
        {
            InitializeComponent();
            this.rec = rec;
            if (rec.getImagePath() != "")
            {
                try
                {
                    showImage();
                }
                catch (Exception)
                {
                    DialogResult res = MessageBox.Show("The specified file was not found. Would you like to locate it?",
                         "File Not Found", MessageBoxButtons.YesNo);
                    if (res == DialogResult.No)
                    {
                        picImage.Image = picImage.ErrorImage;
                    }
                    else if (res == DialogResult.Yes)
                    {
                        DialogResult dlgRes = dlgOpenFile.ShowDialog(this);
                        rec.setImagePath(dlgOpenFile.FileName.Replace("\\", "\\\\"));
                        showImage();
                        recipeDB.updateRecipe(rec);
                    }
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("No image associated with this recipe. \n Would you like to locate one?",
                    "No Image", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.No)
                {
                    picImage.Image = picImage.ErrorImage;
                }
                else if (res == DialogResult.Yes)
                {
                    DialogResult dlgRes = dlgOpenFile.ShowDialog(this);
                    rec.setImagePath(dlgOpenFile.FileName.Replace("\\", "\\\\"));
                    showImage();
                    recipeDB.updateRecipe(rec);
                    
                }
                else if (res == DialogResult.Cancel)
                {
                    this.Dispose();
                }
            }
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void showImage()
        {
            source = new Bitmap(rec.getImagePath());
            Bitmap b = new Bitmap((Image)source, picImage.Size);
            picImage.Image = (Image)b;
        }

        private void ViewImage_Resize(object sender, EventArgs e)
        {
            picImage.Image = (Image)new Bitmap(source, picImage.Size);
        }
    }
}
