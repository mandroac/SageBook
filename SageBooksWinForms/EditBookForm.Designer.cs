namespace SageBooksWinForms
{
    partial class EditBookForm
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
            components = new System.ComponentModel.Container();
            sageBindingSource = new BindingSource(components);
            bookSagesLabel = new Label();
            bookDescriptionRichTextBox = new RichTextBox();
            bookNameTextBox = new TextBox();
            bookDescriptionLabel = new Label();
            bookNameLabel = new Label();
            saveChangesButton = new Button();
            deleteBookButton = new Button();
            cancelButton = new Button();
            bookSagesCheckedListBox = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // sageBindingSource
            // 
            sageBindingSource.DataSource = typeof(Domain.Models.Sage);
            // 
            // bookSagesLabel
            // 
            bookSagesLabel.AutoSize = true;
            bookSagesLabel.Location = new Point(12, 186);
            bookSagesLabel.Name = "bookSagesLabel";
            bookSagesLabel.Size = new Size(40, 15);
            bookSagesLabel.TabIndex = 20;
            bookSagesLabel.Text = "Sages:";
            // 
            // bookDescriptionRichTextBox
            // 
            bookDescriptionRichTextBox.Location = new Point(104, 40);
            bookDescriptionRichTextBox.Margin = new Padding(3, 2, 3, 2);
            bookDescriptionRichTextBox.Name = "bookDescriptionRichTextBox";
            bookDescriptionRichTextBox.Size = new Size(478, 134);
            bookDescriptionRichTextBox.TabIndex = 19;
            bookDescriptionRichTextBox.Text = "";
            // 
            // bookNameTextBox
            // 
            bookNameTextBox.Location = new Point(104, 9);
            bookNameTextBox.Margin = new Padding(3, 2, 3, 2);
            bookNameTextBox.Name = "bookNameTextBox";
            bookNameTextBox.Size = new Size(478, 23);
            bookNameTextBox.TabIndex = 18;
            // 
            // bookDescriptionLabel
            // 
            bookDescriptionLabel.AutoSize = true;
            bookDescriptionLabel.Location = new Point(12, 36);
            bookDescriptionLabel.Name = "bookDescriptionLabel";
            bookDescriptionLabel.Size = new Size(70, 15);
            bookDescriptionLabel.TabIndex = 17;
            bookDescriptionLabel.Text = "Description:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(12, 11);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(42, 15);
            bookNameLabel.TabIndex = 16;
            bookNameLabel.Text = "Name:";
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.PaleGreen;
            saveChangesButton.Location = new Point(475, 277);
            saveChangesButton.Margin = new Padding(3, 2, 3, 2);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(103, 32);
            saveChangesButton.TabIndex = 22;
            saveChangesButton.Text = "Save changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // deleteBookButton
            // 
            deleteBookButton.BackColor = Color.IndianRed;
            deleteBookButton.Location = new Point(368, 278);
            deleteBookButton.Margin = new Padding(3, 2, 3, 2);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(101, 31);
            deleteBookButton.TabIndex = 23;
            deleteBookButton.Text = "Delete book";
            deleteBookButton.UseVisualStyleBackColor = false;
            deleteBookButton.Click += deleteBookButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 278);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 32);
            cancelButton.TabIndex = 24;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // bookSagesCheckedListBox
            // 
            bookSagesCheckedListBox.FormattingEnabled = true;
            bookSagesCheckedListBox.Location = new Point(104, 179);
            bookSagesCheckedListBox.Name = "bookSagesCheckedListBox";
            bookSagesCheckedListBox.Size = new Size(478, 94);
            bookSagesCheckedListBox.TabIndex = 25;
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 316);
            Controls.Add(bookSagesCheckedListBox);
            Controls.Add(cancelButton);
            Controls.Add(deleteBookButton);
            Controls.Add(saveChangesButton);
            Controls.Add(bookSagesLabel);
            Controls.Add(bookDescriptionRichTextBox);
            Controls.Add(bookNameTextBox);
            Controls.Add(bookDescriptionLabel);
            Controls.Add(bookNameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditBookForm";
            Text = "EditBookForm";
            Load += EditBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label bookSagesLabel;
        private RichTextBox bookDescriptionRichTextBox;
        private TextBox bookNameTextBox;
        private Label bookDescriptionLabel;
        private Label bookNameLabel;
        private Button saveChangesButton;
        private Button deleteBookButton;
        private Button cancelButton;
        private BindingSource sageBindingSource;
        private CheckedListBox bookSagesCheckedListBox;
    }
}