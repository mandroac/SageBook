namespace SageBooksWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            booksTab = new TabPage();
            deleteBookButton = new Button();
            editBookButton = new Button();
            createBookButton = new Button();
            booksDataGrid = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Sages = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            sagesTab = new TabPage();
            deleteSageButton = new Button();
            editSageButton = new Button();
            createSageButton = new Button();
            sagesDataGrid = new DataGridView();
            Photo = new DataGridViewImageColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Books = new DataGridViewTextBoxColumn();
            sageBindingSource = new BindingSource(components);
            sageBookDbContextBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            sagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sagesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sageBookDbContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(booksTab);
            tabControl1.Controls.Add(sagesTab);
            tabControl1.Location = new Point(10, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1111, 460);
            tabControl1.TabIndex = 1;
            // 
            // booksTab
            // 
            booksTab.Controls.Add(deleteBookButton);
            booksTab.Controls.Add(editBookButton);
            booksTab.Controls.Add(createBookButton);
            booksTab.Controls.Add(booksDataGrid);
            booksTab.Location = new Point(4, 24);
            booksTab.Margin = new Padding(3, 2, 3, 2);
            booksTab.Name = "booksTab";
            booksTab.Padding = new Padding(3, 2, 3, 2);
            booksTab.Size = new Size(1103, 432);
            booksTab.TabIndex = 0;
            booksTab.Text = "Books";
            booksTab.UseVisualStyleBackColor = true;
            // 
            // deleteBookButton
            // 
            deleteBookButton.BackColor = Color.LightCoral;
            deleteBookButton.Enabled = false;
            deleteBookButton.Location = new Point(659, 5);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(199, 47);
            deleteBookButton.TabIndex = 22;
            deleteBookButton.Text = "Delete Book";
            deleteBookButton.UseVisualStyleBackColor = false;
            deleteBookButton.Click += deleteBookButton_Click;
            // 
            // editBookButton
            // 
            editBookButton.BackColor = Color.LightBlue;
            editBookButton.Enabled = false;
            editBookButton.Location = new Point(454, 5);
            editBookButton.Name = "editBookButton";
            editBookButton.Size = new Size(199, 47);
            editBookButton.TabIndex = 21;
            editBookButton.Text = "Edit Book";
            editBookButton.UseVisualStyleBackColor = false;
            editBookButton.Click += editBookButton_Click;
            // 
            // createBookButton
            // 
            createBookButton.BackColor = Color.LightGreen;
            createBookButton.Location = new Point(249, 5);
            createBookButton.Name = "createBookButton";
            createBookButton.Size = new Size(199, 47);
            createBookButton.TabIndex = 20;
            createBookButton.Text = "Create Book";
            createBookButton.UseVisualStyleBackColor = false;
            createBookButton.Click += createBookButton_Click;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AllowUserToAddRows = false;
            booksDataGrid.AllowUserToDeleteRows = false;
            booksDataGrid.AutoGenerateColumns = false;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn, Sages });
            booksDataGrid.DataSource = bookBindingSource;
            booksDataGrid.Location = new Point(17, 68);
            booksDataGrid.Margin = new Padding(3, 2, 3, 2);
            booksDataGrid.MultiSelect = false;
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.ReadOnly = true;
            booksDataGrid.RowHeadersWidth = 51;
            booksDataGrid.RowTemplate.Height = 29;
            booksDataGrid.Size = new Size(1068, 366);
            booksDataGrid.TabIndex = 0;
            booksDataGrid.CellClick += booksDataGrid_CellClick;
            booksDataGrid.CellFormatting += booksDataGrid_CellFormatting;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            nameDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 200;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 300;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 500;
            // 
            // Sages
            // 
            Sages.DataPropertyName = "Sages";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Sages.DefaultCellStyle = dataGridViewCellStyle3;
            Sages.HeaderText = "Sages";
            Sages.MinimumWidth = 200;
            Sages.Name = "Sages";
            Sages.ReadOnly = true;
            Sages.Width = 297;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Domain.Models.Book);
            // 
            // sagesTab
            // 
            sagesTab.Controls.Add(deleteSageButton);
            sagesTab.Controls.Add(editSageButton);
            sagesTab.Controls.Add(createSageButton);
            sagesTab.Controls.Add(sagesDataGrid);
            sagesTab.Location = new Point(4, 24);
            sagesTab.Margin = new Padding(3, 2, 3, 2);
            sagesTab.Name = "sagesTab";
            sagesTab.Padding = new Padding(3, 2, 3, 2);
            sagesTab.Size = new Size(1103, 432);
            sagesTab.TabIndex = 1;
            sagesTab.Text = "Sages";
            sagesTab.UseVisualStyleBackColor = true;
            // 
            // deleteSageButton
            // 
            deleteSageButton.BackColor = Color.LightCoral;
            deleteSageButton.Enabled = false;
            deleteSageButton.Location = new Point(661, 5);
            deleteSageButton.Name = "deleteSageButton";
            deleteSageButton.Size = new Size(199, 47);
            deleteSageButton.TabIndex = 25;
            deleteSageButton.Text = "Delete Sage";
            deleteSageButton.UseVisualStyleBackColor = false;
            deleteSageButton.Click += deleteSageButton_Click;
            // 
            // editSageButton
            // 
            editSageButton.BackColor = Color.LightBlue;
            editSageButton.Enabled = false;
            editSageButton.Location = new Point(456, 5);
            editSageButton.Name = "editSageButton";
            editSageButton.Size = new Size(199, 47);
            editSageButton.TabIndex = 24;
            editSageButton.Text = "Edit Sage";
            editSageButton.UseVisualStyleBackColor = false;
            editSageButton.Click += editSageButton_Click;
            // 
            // createSageButton
            // 
            createSageButton.BackColor = Color.LightGreen;
            createSageButton.Location = new Point(251, 5);
            createSageButton.Name = "createSageButton";
            createSageButton.Size = new Size(199, 47);
            createSageButton.TabIndex = 23;
            createSageButton.Text = "Create Sage";
            createSageButton.UseVisualStyleBackColor = false;
            createSageButton.Click += createSageButton_Click;
            // 
            // sagesDataGrid
            // 
            sagesDataGrid.AllowUserToAddRows = false;
            sagesDataGrid.AllowUserToDeleteRows = false;
            sagesDataGrid.AutoGenerateColumns = false;
            sagesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sagesDataGrid.Columns.AddRange(new DataGridViewColumn[] { Photo, nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, Books });
            sagesDataGrid.DataSource = sageBindingSource;
            sagesDataGrid.Location = new Point(18, 68);
            sagesDataGrid.Margin = new Padding(3, 2, 3, 2);
            sagesDataGrid.Name = "sagesDataGrid";
            sagesDataGrid.ReadOnly = true;
            sagesDataGrid.RowHeadersWidth = 51;
            sagesDataGrid.RowTemplate.Height = 29;
            sagesDataGrid.Size = new Size(1068, 360);
            sagesDataGrid.TabIndex = 0;
            sagesDataGrid.CellClick += sagesDataGrid_CellClick;
            sagesDataGrid.CellFormatting += sagesDataGrid_CellFormatting;
            // 
            // Photo
            // 
            Photo.DataPropertyName = "Photo";
            Photo.HeaderText = "Photo";
            Photo.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Photo.MinimumWidth = 60;
            Photo.Name = "Photo";
            Photo.ReadOnly = true;
            Photo.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 200;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 60;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            ageDataGridViewTextBoxColumn.Width = 60;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 200;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 250;
            // 
            // Books
            // 
            Books.DataPropertyName = "Books";
            Books.HeaderText = "Books";
            Books.MinimumWidth = 300;
            Books.Name = "Books";
            Books.ReadOnly = true;
            Books.Width = 342;
            // 
            // sageBindingSource
            // 
            sageBindingSource.DataSource = typeof(Domain.Models.Sage);
            // 
            // sageBookDbContextBindingSource
            // 
            sageBookDbContextBindingSource.DataSource = typeof(DataAccess.SageBookDbContext);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 478);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            booksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            sagesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sagesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sageBookDbContextBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage booksTab;
        private TabPage sagesTab;
        private DataGridView booksDataGrid;
        private BindingSource bookBindingSource;
        private DataGridView sagesDataGrid;
        private BindingSource sageBindingSource;
        private BindingSource sageBookDbContextBindingSource;
        private Button createBookButton;
        private Button editBookButton;
        private Button deleteBookButton;
        private Button deleteSageButton;
        private Button editSageButton;
        private Button createSageButton;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Sages;
        private DataGridViewImageColumn Photo;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Books;
    }
}