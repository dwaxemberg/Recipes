namespace Recipes
{
    partial class ViewRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecipe));
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdIngredients = new System.Windows.Forms.DataGridView();
            this.txtDirections = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrepTime = new System.Windows.Forms.Label();
            this.lblYield = new System.Windows.Forms.Label();
            this.btnViewImage = new System.Windows.Forms.Button();
            this.star5 = new System.Windows.Forms.Button();
            this.star4 = new System.Windows.Forms.Button();
            this.star3 = new System.Windows.Forms.Button();
            this.star2 = new System.Windows.Forms.Button();
            this.star1 = new System.Windows.Forms.Button();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.Ingredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(243, 9);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(161, 29);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "Recipe Name";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingredients:";
            // 
            // grdIngredients
            // 
            this.grdIngredients.AllowUserToAddRows = false;
            this.grdIngredients.AllowUserToDeleteRows = false;
            this.grdIngredients.AllowUserToResizeRows = false;
            this.grdIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdIngredients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIngredients.ColumnHeadersVisible = false;
            this.grdIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdIngredients.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdIngredients.Location = new System.Drawing.Point(12, 81);
            this.grdIngredients.Name = "grdIngredients";
            this.grdIngredients.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdIngredients.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdIngredients.RowHeadersVisible = false;
            this.grdIngredients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdIngredients.RowTemplate.Height = 30;
            this.grdIngredients.RowTemplate.ReadOnly = true;
            this.grdIngredients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grdIngredients.Size = new System.Drawing.Size(619, 181);
            this.grdIngredients.TabIndex = 3;
            this.grdIngredients.Resize += new System.EventHandler(this.grdIngredients_Resize);
            // 
            // txtDirections
            // 
            this.txtDirections.AcceptsReturn = true;
            this.txtDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirections.Location = new System.Drawing.Point(12, 300);
            this.txtDirections.Multiline = true;
            this.txtDirections.Name = "txtDirections";
            this.txtDirections.ReadOnly = true;
            this.txtDirections.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDirections.Size = new System.Drawing.Size(619, 212);
            this.txtDirections.TabIndex = 4;
            this.txtDirections.Resize += new System.EventHandler(this.txtDirections_Resize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directions:";
            // 
            // lblPrepTime
            // 
            this.lblPrepTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrepTime.AutoSize = true;
            this.lblPrepTime.Location = new System.Drawing.Point(142, 38);
            this.lblPrepTime.Name = "lblPrepTime";
            this.lblPrepTime.Size = new System.Drawing.Size(55, 13);
            this.lblPrepTime.TabIndex = 6;
            this.lblPrepTime.Text = "Prep Time";
            // 
            // lblYield
            // 
            this.lblYield.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblYield.AutoSize = true;
            this.lblYield.Location = new System.Drawing.Point(424, 38);
            this.lblYield.Name = "lblYield";
            this.lblYield.Size = new System.Drawing.Size(33, 13);
            this.lblYield.TabIndex = 7;
            this.lblYield.Text = "Yield:";
            // 
            // btnViewImage
            // 
            this.btnViewImage.Location = new System.Drawing.Point(14, 9);
            this.btnViewImage.Name = "btnViewImage";
            this.btnViewImage.Size = new System.Drawing.Size(73, 35);
            this.btnViewImage.TabIndex = 9;
            this.btnViewImage.Text = "View Image";
            this.btnViewImage.UseVisualStyleBackColor = true;
            this.btnViewImage.Click += new System.EventHandler(this.btnViewImage_Click);
            // 
            // star5
            // 
            this.star5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star5.Image = ((System.Drawing.Image)(resources.GetObject("star5.Image")));
            this.star5.Location = new System.Drawing.Point(371, 58);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(24, 23);
            this.star5.TabIndex = 8;
            this.star5.UseVisualStyleBackColor = true;
            this.star5.Click += new System.EventHandler(this.star5_Click);
            this.star5.MouseLeave += new System.EventHandler(this.star_MouseLeave);
            this.star5.MouseHover += new System.EventHandler(this.star5_MouseHover);
            // 
            // star4
            // 
            this.star4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star4.Image = ((System.Drawing.Image)(resources.GetObject("star4.Image")));
            this.star4.Location = new System.Drawing.Point(341, 58);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(24, 23);
            this.star4.TabIndex = 8;
            this.star4.UseVisualStyleBackColor = true;
            this.star4.Click += new System.EventHandler(this.star4_Click);
            this.star4.MouseLeave += new System.EventHandler(this.star_MouseLeave);
            this.star4.MouseHover += new System.EventHandler(this.star4_MouseHover);
            // 
            // star3
            // 
            this.star3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star3.Image = ((System.Drawing.Image)(resources.GetObject("star3.Image")));
            this.star3.Location = new System.Drawing.Point(311, 58);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(24, 23);
            this.star3.TabIndex = 8;
            this.star3.UseVisualStyleBackColor = true;
            this.star3.Click += new System.EventHandler(this.star3_Click);
            this.star3.MouseLeave += new System.EventHandler(this.star_MouseLeave);
            this.star3.MouseHover += new System.EventHandler(this.star3_MouseHover);
            // 
            // star2
            // 
            this.star2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star2.Image = ((System.Drawing.Image)(resources.GetObject("star2.Image")));
            this.star2.Location = new System.Drawing.Point(281, 58);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(24, 23);
            this.star2.TabIndex = 8;
            this.star2.UseVisualStyleBackColor = true;
            this.star2.Click += new System.EventHandler(this.star2_Click);
            this.star2.MouseLeave += new System.EventHandler(this.star_MouseLeave);
            this.star2.MouseHover += new System.EventHandler(this.star2_MouseHover);
            // 
            // star1
            // 
            this.star1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.star1.Image = ((System.Drawing.Image)(resources.GetObject("star1.Image")));
            this.star1.Location = new System.Drawing.Point(251, 58);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(24, 23);
            this.star1.TabIndex = 8;
            this.star1.UseVisualStyleBackColor = true;
            this.star1.Click += new System.EventHandler(this.star1_Click);
            this.star1.MouseLeave += new System.EventHandler(this.star_MouseLeave);
            this.star1.MouseHover += new System.EventHandler(this.star1_MouseHover);
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRecipe.Location = new System.Drawing.Point(570, 9);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(61, 21);
            this.btnEditRecipe.TabIndex = 10;
            this.btnEditRecipe.Text = "Edit";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            this.btnEditRecipe.Click += new System.EventHandler(this.btnEditRecipe_Click);
            // 
            // Ingredient
            // 
            this.Ingredient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ingredient.HeaderText = "Ingredient";
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.ReadOnly = true;
            this.Ingredient.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ViewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 524);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.btnViewImage);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.lblYield);
            this.Controls.Add(this.lblPrepTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirections);
            this.Controls.Add(this.grdIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecipeName);
            this.MinimumSize = new System.Drawing.Size(400, 450);
            this.Name = "ViewRecipe";
            this.Text = "View Recipe";
            this.Load += new System.EventHandler(this.ViewRecipe_Load);
            this.Resize += new System.EventHandler(this.ViewRecipe_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grdIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdIngredients;
        private System.Windows.Forms.TextBox txtDirections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrepTime;
        private System.Windows.Forms.Label lblYield;
        private System.Windows.Forms.Button star1;
        private System.Windows.Forms.Button star2;
        private System.Windows.Forms.Button star3;
        private System.Windows.Forms.Button star4;
        private System.Windows.Forms.Button star5;
        private System.Windows.Forms.Button btnViewImage;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingredient;
    }
}