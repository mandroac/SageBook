﻿namespace SageBooksWinForms
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
            bookSagesComboBox = new ComboBox();
            sageBindingSource = new BindingSource(components);
            saveBookButton = new Button();
            bookSagesLabel = new Label();
            bookDescriptionRichTextBox = new RichTextBox();
            bookNameTextBox = new TextBox();
            bookDescriptionLabel = new Label();
            bookNameLabel = new Label();
            addBookLabel = new Label();
            booksDataGrid = new DataGridView();
            Details = new DataGridViewLinkColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Sages = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            sagesTab = new TabPage();
            selectedSagePhotoLabel = new Label();
            sagePhotoButton = new Button();
            sagePhotoLabel = new Label();
            sageBooksComboBox = new ComboBox();
            saveSageButton = new Button();
            sageBooksLabel = new Label();
            sageCityListBox = new ListBox();
            sageCityLabel = new Label();
            sageAgeNumericUpDown = new NumericUpDown();
            sageAgeLabel = new Label();
            sageNameTextBox = new TextBox();
            sageNameLabel = new Label();
            addSageLabel = new Label();
            sagesDataGrid = new DataGridView();
            SageDetails = new DataGridViewLinkColumn();
            Photo = new DataGridViewImageColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Books = new DataGridViewTextBoxColumn();
            sagesErrorProvider = new ErrorProvider(components);
            booksErrorProvider = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            booksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            sagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sageAgeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sagesDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sagesErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)booksErrorProvider).BeginInit();
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
            booksTab.Controls.Add(bookSagesComboBox);
            booksTab.Controls.Add(saveBookButton);
            booksTab.Controls.Add(bookSagesLabel);
            booksTab.Controls.Add(bookDescriptionRichTextBox);
            booksTab.Controls.Add(bookNameTextBox);
            booksTab.Controls.Add(bookDescriptionLabel);
            booksTab.Controls.Add(bookNameLabel);
            booksTab.Controls.Add(addBookLabel);
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
            // bookSagesComboBox
            // 
            bookSagesComboBox.DataSource = sageBindingSource;
            bookSagesComboBox.DisplayMember = "Name";
            bookSagesComboBox.FormattingEnabled = true;
            bookSagesComboBox.Location = new Point(113, 203);
            bookSagesComboBox.Margin = new Padding(3, 2, 3, 2);
            bookSagesComboBox.Name = "bookSagesComboBox";
            bookSagesComboBox.Size = new Size(959, 23);
            bookSagesComboBox.TabIndex = 15;
            // 
            // sageBindingSource
            // 
            sageBindingSource.DataSource = typeof(Domain.Models.Sage);
            // 
            // saveBookButton
            // 
            saveBookButton.Location = new Point(989, 2);
            saveBookButton.Margin = new Padding(3, 2, 3, 2);
            saveBookButton.Name = "saveBookButton";
            saveBookButton.Size = new Size(82, 22);
            saveBookButton.TabIndex = 14;
            saveBookButton.Text = "Save";
            saveBookButton.UseVisualStyleBackColor = true;
            saveBookButton.Click += saveBookButton_Click;
            // 
            // bookSagesLabel
            // 
            bookSagesLabel.AutoSize = true;
            bookSagesLabel.Location = new Point(21, 206);
            bookSagesLabel.Name = "bookSagesLabel";
            bookSagesLabel.Size = new Size(40, 15);
            bookSagesLabel.TabIndex = 6;
            bookSagesLabel.Text = "Sages:";
            // 
            // bookDescriptionRichTextBox
            // 
            bookDescriptionRichTextBox.Location = new Point(113, 59);
            bookDescriptionRichTextBox.Margin = new Padding(3, 2, 3, 2);
            bookDescriptionRichTextBox.Name = "bookDescriptionRichTextBox";
            bookDescriptionRichTextBox.Size = new Size(959, 134);
            bookDescriptionRichTextBox.TabIndex = 5;
            bookDescriptionRichTextBox.Text = "";
            bookDescriptionRichTextBox.Validating += bookDescriptionRichTextBox_Validating;
            // 
            // bookNameTextBox
            // 
            bookNameTextBox.Location = new Point(113, 28);
            bookNameTextBox.Margin = new Padding(3, 2, 3, 2);
            bookNameTextBox.Name = "bookNameTextBox";
            bookNameTextBox.Size = new Size(959, 23);
            bookNameTextBox.TabIndex = 4;
            bookNameTextBox.Validating += bookNameTextBox_Validating;
            // 
            // bookDescriptionLabel
            // 
            bookDescriptionLabel.AutoSize = true;
            bookDescriptionLabel.Location = new Point(21, 56);
            bookDescriptionLabel.Name = "bookDescriptionLabel";
            bookDescriptionLabel.Size = new Size(70, 15);
            bookDescriptionLabel.TabIndex = 3;
            bookDescriptionLabel.Text = "Description:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(21, 31);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(42, 15);
            bookNameLabel.TabIndex = 2;
            bookNameLabel.Text = "Name:";
            // 
            // addBookLabel
            // 
            addBookLabel.AutoSize = true;
            addBookLabel.Location = new Point(516, 10);
            addBookLabel.Name = "addBookLabel";
            addBookLabel.Size = new Size(86, 15);
            addBookLabel.TabIndex = 1;
            addBookLabel.Text = "Add New Book";
            addBookLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // booksDataGrid
            // 
            booksDataGrid.AllowUserToAddRows = false;
            booksDataGrid.AllowUserToDeleteRows = false;
            booksDataGrid.AutoGenerateColumns = false;
            booksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            booksDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            booksDataGrid.Columns.AddRange(new DataGridViewColumn[] { Details, nameDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn, Sages });
            booksDataGrid.DataSource = bookBindingSource;
            booksDataGrid.Location = new Point(21, 238);
            booksDataGrid.Margin = new Padding(3, 2, 3, 2);
            booksDataGrid.Name = "booksDataGrid";
            booksDataGrid.ReadOnly = true;
            booksDataGrid.RowHeadersWidth = 51;
            booksDataGrid.RowTemplate.Height = 29;
            booksDataGrid.Size = new Size(1050, 196);
            booksDataGrid.TabIndex = 0;
            booksDataGrid.CellClick += booksDataGrid_CellClick;
            booksDataGrid.CellFormatting += booksDataGrid_CellFormatting;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Details.HeaderText = "";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Resizable = DataGridViewTriState.False;
            Details.Text = "Details";
            Details.Width = 6;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            nameDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 125;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            descriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 300;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // Sages
            // 
            Sages.DataPropertyName = "Sages";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Sages.DefaultCellStyle = dataGridViewCellStyle3;
            Sages.HeaderText = "Sages";
            Sages.MinimumWidth = 300;
            Sages.Name = "Sages";
            Sages.ReadOnly = true;
            Sages.Width = 300;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Domain.Models.Book);
            // 
            // sagesTab
            // 
            sagesTab.Controls.Add(selectedSagePhotoLabel);
            sagesTab.Controls.Add(sagePhotoButton);
            sagesTab.Controls.Add(sagePhotoLabel);
            sagesTab.Controls.Add(sageBooksComboBox);
            sagesTab.Controls.Add(saveSageButton);
            sagesTab.Controls.Add(sageBooksLabel);
            sagesTab.Controls.Add(sageCityListBox);
            sagesTab.Controls.Add(sageCityLabel);
            sagesTab.Controls.Add(sageAgeNumericUpDown);
            sagesTab.Controls.Add(sageAgeLabel);
            sagesTab.Controls.Add(sageNameTextBox);
            sagesTab.Controls.Add(sageNameLabel);
            sagesTab.Controls.Add(addSageLabel);
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
            // selectedSagePhotoLabel
            // 
            selectedSagePhotoLabel.AutoSize = true;
            selectedSagePhotoLabel.Location = new Point(260, 43);
            selectedSagePhotoLabel.Name = "selectedSagePhotoLabel";
            selectedSagePhotoLabel.Size = new Size(0, 15);
            selectedSagePhotoLabel.TabIndex = 17;
            // 
            // sagePhotoButton
            // 
            sagePhotoButton.Location = new Point(113, 40);
            sagePhotoButton.Margin = new Padding(3, 2, 3, 2);
            sagePhotoButton.Name = "sagePhotoButton";
            sagePhotoButton.Size = new Size(134, 22);
            sagePhotoButton.TabIndex = 16;
            sagePhotoButton.Text = "Click to select photo";
            sagePhotoButton.UseVisualStyleBackColor = true;
            sagePhotoButton.Click += sagePhotoButton_Click;
            // 
            // sagePhotoLabel
            // 
            sagePhotoLabel.AutoSize = true;
            sagePhotoLabel.Location = new Point(21, 43);
            sagePhotoLabel.Name = "sagePhotoLabel";
            sagePhotoLabel.Size = new Size(42, 15);
            sagePhotoLabel.TabIndex = 15;
            sagePhotoLabel.Text = "Photo:";
            // 
            // sageBooksComboBox
            // 
            sageBooksComboBox.DataSource = bookBindingSource;
            sageBooksComboBox.DisplayMember = "Name";
            sageBooksComboBox.FormattingEnabled = true;
            sageBooksComboBox.Location = new Point(113, 179);
            sageBooksComboBox.Margin = new Padding(3, 2, 3, 2);
            sageBooksComboBox.Name = "sageBooksComboBox";
            sageBooksComboBox.Size = new Size(956, 23);
            sageBooksComboBox.TabIndex = 14;
            // 
            // saveSageButton
            // 
            saveSageButton.Location = new Point(986, 4);
            saveSageButton.Margin = new Padding(3, 2, 3, 2);
            saveSageButton.Name = "saveSageButton";
            saveSageButton.Size = new Size(82, 22);
            saveSageButton.TabIndex = 13;
            saveSageButton.Text = "Save";
            saveSageButton.UseVisualStyleBackColor = true;
            saveSageButton.Click += saveSageButton_Click;
            // 
            // sageBooksLabel
            // 
            sageBooksLabel.AutoSize = true;
            sageBooksLabel.Location = new Point(21, 179);
            sageBooksLabel.Name = "sageBooksLabel";
            sageBooksLabel.Size = new Size(42, 15);
            sageBooksLabel.TabIndex = 11;
            sageBooksLabel.Text = "Books:";
            // 
            // sageCityListBox
            // 
            sageCityListBox.FormattingEnabled = true;
            sageCityListBox.ItemHeight = 15;
            sageCityListBox.Items.AddRange(new object[] { "Lviv", "Kyiv", "Kharkiv", "Odessa", "Dnipro", "Vinnytsia" });
            sageCityListBox.Location = new Point(113, 144);
            sageCityListBox.Margin = new Padding(3, 2, 3, 2);
            sageCityListBox.Name = "sageCityListBox";
            sageCityListBox.Size = new Size(956, 19);
            sageCityListBox.TabIndex = 10;
            sageCityListBox.Validating += sageCityListBox_Validating;
            // 
            // sageCityLabel
            // 
            sageCityLabel.AutoSize = true;
            sageCityLabel.Location = new Point(21, 147);
            sageCityLabel.Name = "sageCityLabel";
            sageCityLabel.Size = new Size(31, 15);
            sageCityLabel.TabIndex = 9;
            sageCityLabel.Text = "City:";
            // 
            // sageAgeNumericUpDown
            // 
            sageAgeNumericUpDown.Location = new Point(113, 111);
            sageAgeNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            sageAgeNumericUpDown.Name = "sageAgeNumericUpDown";
            sageAgeNumericUpDown.Size = new Size(956, 23);
            sageAgeNumericUpDown.TabIndex = 8;
            sageAgeNumericUpDown.Validating += sageAgeNumericUpDown_Validating;
            // 
            // sageAgeLabel
            // 
            sageAgeLabel.AutoSize = true;
            sageAgeLabel.Location = new Point(21, 112);
            sageAgeLabel.Name = "sageAgeLabel";
            sageAgeLabel.Size = new Size(31, 15);
            sageAgeLabel.TabIndex = 7;
            sageAgeLabel.Text = "Age:";
            // 
            // sageNameTextBox
            // 
            sageNameTextBox.Location = new Point(113, 76);
            sageNameTextBox.Margin = new Padding(3, 2, 3, 2);
            sageNameTextBox.Name = "sageNameTextBox";
            sageNameTextBox.Size = new Size(956, 23);
            sageNameTextBox.TabIndex = 6;
            sageNameTextBox.Validating += sageNameTextBox_Validating;
            // 
            // sageNameLabel
            // 
            sageNameLabel.AutoSize = true;
            sageNameLabel.Location = new Point(21, 78);
            sageNameLabel.Name = "sageNameLabel";
            sageNameLabel.Size = new Size(42, 15);
            sageNameLabel.TabIndex = 5;
            sageNameLabel.Text = "Name:";
            // 
            // addSageLabel
            // 
            addSageLabel.AutoSize = true;
            addSageLabel.Location = new Point(516, 10);
            addSageLabel.Name = "addSageLabel";
            addSageLabel.Size = new Size(84, 15);
            addSageLabel.TabIndex = 2;
            addSageLabel.Text = "Add New Sage";
            addSageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sagesDataGrid
            // 
            sagesDataGrid.AllowUserToAddRows = false;
            sagesDataGrid.AllowUserToDeleteRows = false;
            sagesDataGrid.AutoGenerateColumns = false;
            sagesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sagesDataGrid.Columns.AddRange(new DataGridViewColumn[] { SageDetails, Photo, nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, Books });
            sagesDataGrid.DataSource = sageBindingSource;
            sagesDataGrid.Location = new Point(18, 215);
            sagesDataGrid.Margin = new Padding(3, 2, 3, 2);
            sagesDataGrid.Name = "sagesDataGrid";
            sagesDataGrid.ReadOnly = true;
            sagesDataGrid.RowHeadersWidth = 51;
            sagesDataGrid.RowTemplate.Height = 29;
            sagesDataGrid.Size = new Size(1050, 220);
            sagesDataGrid.TabIndex = 0;
            sagesDataGrid.CellClick += sagesDataGrid_CellClick;
            sagesDataGrid.CellFormatting += sagesDataGrid_CellFormatting;
            // 
            // SageDetails
            // 
            SageDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SageDetails.HeaderText = "";
            SageDetails.Name = "SageDetails";
            SageDetails.ReadOnly = true;
            SageDetails.Text = "Details";
            SageDetails.Width = 5;
            // 
            // Photo
            // 
            Photo.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
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
            nameDataGridViewTextBoxColumn.MinimumWidth = 125;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 47;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            ageDataGridViewTextBoxColumn.Width = 147;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "City";
            cityDataGridViewTextBoxColumn.MinimumWidth = 300;
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 300;
            // 
            // Books
            // 
            Books.DataPropertyName = "Books";
            Books.HeaderText = "Books";
            Books.MinimumWidth = 300;
            Books.Name = "Books";
            Books.ReadOnly = true;
            Books.Width = 300;
            // 
            // sagesErrorProvider
            // 
            sagesErrorProvider.ContainerControl = this;
            // 
            // booksErrorProvider
            // 
            booksErrorProvider.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            booksTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            sagesTab.ResumeLayout(false);
            sagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sageAgeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)sagesDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)sagesErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)booksErrorProvider).EndInit();
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
        private TextBox bookNameTextBox;
        private Label bookDescriptionLabel;
        private Label bookNameLabel;
        private Label addBookLabel;
        private RichTextBox bookDescriptionRichTextBox;
        private Label addSageLabel;
        private TextBox sageNameTextBox;
        private Label sageNameLabel;
        private Label sageCityLabel;
        private NumericUpDown sageAgeNumericUpDown;
        private Label sageAgeLabel;
        private Label bookSagesLabel;
        private ListBox sageCityListBox;
        private Button saveBookButton;
        private Button saveSageButton;
        private Label sageBooksLabel;
        private ComboBox bookSagesComboBox;
        private ComboBox sageBooksComboBox;
        private ErrorProvider sagesErrorProvider;
        private ErrorProvider booksErrorProvider;
        private Label sagePhotoLabel;
        private Label selectedSagePhotoLabel;
        private Button sagePhotoButton;
        private OpenFileDialog openFileDialog1;
        private DataGridViewLinkColumn Details;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Sages;
        private DataGridViewLinkColumn SageDetails;
        private DataGridViewImageColumn Photo;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Books;
    }
}