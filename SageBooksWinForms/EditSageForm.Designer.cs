namespace SageBooksWinForms
{
    partial class EditSageForm
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
            selectedSagePhotoLabel = new Label();
            sagePhotoButton = new Button();
            sagePhotoLabel = new Label();
            sageBooksComboBox = new ComboBox();
            sageBooksLabel = new Label();
            sageCityListBox = new ListBox();
            sageCityLabel = new Label();
            sageAgeNumericUpDown = new NumericUpDown();
            sageAgeLabel = new Label();
            sageNameTextBox = new TextBox();
            sageNameLabel = new Label();
            cancelButton = new Button();
            deleteSageButton = new Button();
            saveChangesButton = new Button();
            sagePhotoPictureBox = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)sageAgeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sagePhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // selectedSagePhotoLabel
            // 
            selectedSagePhotoLabel.AutoSize = true;
            selectedSagePhotoLabel.Location = new Point(169, 135);
            selectedSagePhotoLabel.Name = "selectedSagePhotoLabel";
            selectedSagePhotoLabel.Size = new Size(0, 15);
            selectedSagePhotoLabel.TabIndex = 28;
            // 
            // sagePhotoButton
            // 
            sagePhotoButton.Location = new Point(16, 131);
            sagePhotoButton.Margin = new Padding(3, 2, 3, 2);
            sagePhotoButton.Name = "sagePhotoButton";
            sagePhotoButton.Size = new Size(147, 22);
            sagePhotoButton.TabIndex = 27;
            sagePhotoButton.Text = "Click to select photo";
            sagePhotoButton.UseVisualStyleBackColor = true;
            sagePhotoButton.Click += sagePhotoButton_Click;
            // 
            // sagePhotoLabel
            // 
            sagePhotoLabel.AutoSize = true;
            sagePhotoLabel.Location = new Point(16, 24);
            sagePhotoLabel.Name = "sagePhotoLabel";
            sagePhotoLabel.Size = new Size(0, 15);
            sagePhotoLabel.TabIndex = 26;
            // 
            // sageBooksComboBox
            // 
            sageBooksComboBox.DisplayMember = "Name";
            sageBooksComboBox.FormattingEnabled = true;
            sageBooksComboBox.Location = new Point(108, 269);
            sageBooksComboBox.Margin = new Padding(3, 2, 3, 2);
            sageBooksComboBox.Name = "sageBooksComboBox";
            sageBooksComboBox.Size = new Size(467, 23);
            sageBooksComboBox.TabIndex = 25;
            // 
            // sageBooksLabel
            // 
            sageBooksLabel.AutoSize = true;
            sageBooksLabel.Location = new Point(16, 269);
            sageBooksLabel.Name = "sageBooksLabel";
            sageBooksLabel.Size = new Size(42, 15);
            sageBooksLabel.TabIndex = 24;
            sageBooksLabel.Text = "Books:";
            // 
            // sageCityListBox
            // 
            sageCityListBox.FormattingEnabled = true;
            sageCityListBox.ItemHeight = 15;
            sageCityListBox.Items.AddRange(new object[] { "Lviv", "Kyiv", "Kharkiv", "Odessa", "Dnipro", "Vinnytsia" });
            sageCityListBox.Location = new Point(108, 234);
            sageCityListBox.Margin = new Padding(3, 2, 3, 2);
            sageCityListBox.Name = "sageCityListBox";
            sageCityListBox.Size = new Size(467, 19);
            sageCityListBox.TabIndex = 23;
            // 
            // sageCityLabel
            // 
            sageCityLabel.AutoSize = true;
            sageCityLabel.Location = new Point(16, 237);
            sageCityLabel.Name = "sageCityLabel";
            sageCityLabel.Size = new Size(31, 15);
            sageCityLabel.TabIndex = 22;
            sageCityLabel.Text = "City:";
            // 
            // sageAgeNumericUpDown
            // 
            sageAgeNumericUpDown.Location = new Point(108, 201);
            sageAgeNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            sageAgeNumericUpDown.Name = "sageAgeNumericUpDown";
            sageAgeNumericUpDown.Size = new Size(466, 23);
            sageAgeNumericUpDown.TabIndex = 21;
            // 
            // sageAgeLabel
            // 
            sageAgeLabel.AutoSize = true;
            sageAgeLabel.Location = new Point(16, 203);
            sageAgeLabel.Name = "sageAgeLabel";
            sageAgeLabel.Size = new Size(31, 15);
            sageAgeLabel.TabIndex = 20;
            sageAgeLabel.Text = "Age:";
            // 
            // sageNameTextBox
            // 
            sageNameTextBox.Location = new Point(108, 166);
            sageNameTextBox.Margin = new Padding(3, 2, 3, 2);
            sageNameTextBox.Name = "sageNameTextBox";
            sageNameTextBox.Size = new Size(467, 23);
            sageNameTextBox.TabIndex = 19;
            // 
            // sageNameLabel
            // 
            sageNameLabel.AutoSize = true;
            sageNameLabel.Location = new Point(16, 168);
            sageNameLabel.Name = "sageNameLabel";
            sageNameLabel.Size = new Size(42, 15);
            sageNameLabel.TabIndex = 18;
            sageNameLabel.Text = "Name:";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(14, 305);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 31;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // deleteSageButton
            // 
            deleteSageButton.BackColor = Color.IndianRed;
            deleteSageButton.Location = new Point(473, 305);
            deleteSageButton.Margin = new Padding(3, 2, 3, 2);
            deleteSageButton.Name = "deleteSageButton";
            deleteSageButton.Size = new Size(101, 22);
            deleteSageButton.TabIndex = 30;
            deleteSageButton.Text = "Delete sage";
            deleteSageButton.UseVisualStyleBackColor = false;
            deleteSageButton.Click += deleteSageButton_Click;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.PaleGreen;
            saveChangesButton.Location = new Point(365, 305);
            saveChangesButton.Margin = new Padding(3, 2, 3, 2);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(103, 22);
            saveChangesButton.TabIndex = 29;
            saveChangesButton.Text = "Save changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // sagePhotoPictureBox
            // 
            sagePhotoPictureBox.Location = new Point(16, 12);
            sagePhotoPictureBox.Name = "sagePhotoPictureBox";
            sagePhotoPictureBox.Size = new Size(147, 106);
            sagePhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            sagePhotoPictureBox.TabIndex = 32;
            sagePhotoPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditSageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 336);
            Controls.Add(sagePhotoPictureBox);
            Controls.Add(cancelButton);
            Controls.Add(deleteSageButton);
            Controls.Add(saveChangesButton);
            Controls.Add(selectedSagePhotoLabel);
            Controls.Add(sagePhotoButton);
            Controls.Add(sagePhotoLabel);
            Controls.Add(sageBooksComboBox);
            Controls.Add(sageBooksLabel);
            Controls.Add(sageCityListBox);
            Controls.Add(sageCityLabel);
            Controls.Add(sageAgeNumericUpDown);
            Controls.Add(sageAgeLabel);
            Controls.Add(sageNameTextBox);
            Controls.Add(sageNameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditSageForm";
            Text = "EditSageForm";
            Load += EditSageForm_Load;
            ((System.ComponentModel.ISupportInitialize)sageAgeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)sagePhotoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectedSagePhotoLabel;
        private Button sagePhotoButton;
        private Label sagePhotoLabel;
        private ComboBox sageBooksComboBox;
        private Label sageBooksLabel;
        private ListBox sageCityListBox;
        private Label sageCityLabel;
        private NumericUpDown sageAgeNumericUpDown;
        private Label sageAgeLabel;
        private TextBox sageNameTextBox;
        private Label sageNameLabel;
        private Button cancelButton;
        private Button deleteSageButton;
        private Button saveChangesButton;
        private PictureBox sagePhotoPictureBox;
        private OpenFileDialog openFileDialog1;
    }
}