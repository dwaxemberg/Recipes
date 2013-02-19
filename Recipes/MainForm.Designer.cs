namespace Recipes
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datRecipeList = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recData = new System.Data.DataSet();
            this.recipeTable = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.btnSelectRecipe = new System.Windows.Forms.Button();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datRecipeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // datRecipeList
            // 
            this.datRecipeList.AllowUserToAddRows = false;
            this.datRecipeList.AllowUserToDeleteRows = false;
            this.datRecipeList.AllowUserToResizeRows = false;
            this.datRecipeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.datRecipeList.AutoGenerateColumns = false;
            this.datRecipeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datRecipeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datRecipeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.datRecipeList.DataMember = "Table1";
            this.datRecipeList.DataSource = this.recData;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datRecipeList.DefaultCellStyle = dataGridViewCellStyle2;
            this.datRecipeList.Location = new System.Drawing.Point(12, 12);
            this.datRecipeList.MultiSelect = false;
            this.datRecipeList.Name = "datRecipeList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datRecipeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datRecipeList.RowHeadersVisible = false;
            this.datRecipeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datRecipeList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datRecipeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datRecipeList.Size = new System.Drawing.Size(599, 419);
            this.datRecipeList.TabIndex = 0;
            this.datRecipeList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datRecipeList_CellContentDoubleClick);
            this.datRecipeList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datRecipeList_KeyPress);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recData
            // 
            this.recData.DataSetName = "recipeData";
            this.recData.Tables.AddRange(new System.Data.DataTable[] {
            this.recipeTable});
            // 
            // recipeTable
            // 
            this.recipeTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.recipeTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ID"}, true)});
            this.recipeTable.MinimumCapacity = 1000;
            this.recipeTable.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.recipeTable.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "ID";
            this.dataColumn1.ColumnName = "ID";
            this.dataColumn1.ReadOnly = true;
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Name";
            this.dataColumn2.ColumnName = "Name";
            this.dataColumn2.ReadOnly = true;
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Category";
            this.dataColumn3.ColumnName = "Category";
            this.dataColumn3.ReadOnly = true;
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Rating";
            this.dataColumn4.ColumnName = "Rating";
            this.dataColumn4.DefaultValue = "No Rating";
            this.dataColumn4.ReadOnly = true;
            // 
            // btnSelectRecipe
            // 
            this.btnSelectRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectRecipe.AutoSize = true;
            this.btnSelectRecipe.Location = new System.Drawing.Point(429, 437);
            this.btnSelectRecipe.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnSelectRecipe.MinimumSize = new System.Drawing.Size(50, 20);
            this.btnSelectRecipe.Name = "btnSelectRecipe";
            this.btnSelectRecipe.Size = new System.Drawing.Size(116, 43);
            this.btnSelectRecipe.TabIndex = 1;
            this.btnSelectRecipe.Text = "Select Recipe";
            this.btnSelectRecipe.UseVisualStyleBackColor = true;
            this.btnSelectRecipe.Click += new System.EventHandler(this.btnSelectRecipe_Click);
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewRecipe.AutoSize = true;
            this.btnNewRecipe.Location = new System.Drawing.Point(77, 437);
            this.btnNewRecipe.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnNewRecipe.MinimumSize = new System.Drawing.Size(50, 20);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(116, 43);
            this.btnNewRecipe.TabIndex = 2;
            this.btnNewRecipe.Text = "New Recipe";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            this.btnNewRecipe.Click += new System.EventHandler(this.btnNewRecipe_Click);
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(253, 437);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(116, 43);
            this.btnDeleteRecipe.TabIndex = 3;
            this.btnDeleteRecipe.Text = "Delete Recipe";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSelectRecipe;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 492);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnNewRecipe);
            this.Controls.Add(this.btnSelectRecipe);
            this.Controls.Add(this.datRecipeList);
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "MainForm";
            this.Text = "Recipe Organizer";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datRecipeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datRecipeList;
        private System.Windows.Forms.Button btnSelectRecipe;
        private System.Data.DataSet recData;
        private System.Data.DataTable recipeTable;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.Button btnNewRecipe;
        private System.Windows.Forms.Button btnDeleteRecipe;
    }
}

