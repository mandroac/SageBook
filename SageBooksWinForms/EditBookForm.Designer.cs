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
            bookSagesComboBox = new ComboBox();
            bookSagesLabel = new Label();
            bookDescriptionRichTextBox = new RichTextBox();
            bookNameTextBox = new TextBox();
            bookDescriptionLabel = new Label();
            bookNameLabel = new Label();
            saveChangesButton = new Button();
            deleteBookButton = new Button();
            cancelButton = new Button();
            sageBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bookSagesComboBox
            // 
            bookSagesComboBox.DataSource = sageBindingSource;
            bookSagesComboBox.DisplayMember = "Name";
            bookSagesComboBox.FormattingEnabled = true;
            bookSagesComboBox.Location = new Point(119, 245);
            bookSagesComboBox.Name = "bookSagesComboBox";
            bookSagesComboBox.Size = new Size(546, 28);
            bookSagesComboBox.TabIndex = 21;
            // 
            // bookSagesLabel
            // 
            bookSagesLabel.AutoSize = true;
            bookSagesLabel.Location = new Point(14, 248);
            bookSagesLabel.Name = "bookSagesLabel";
            bookSagesLabel.Size = new Size(51, 20);
            bookSagesLabel.TabIndex = 20;
            bookSagesLabel.Text = "Sages:";
            // 
            // bookDescriptionRichTextBox
            // 
            bookDescriptionRichTextBox.Location = new Point(119, 53);
            bookDescriptionRichTextBox.Name = "bookDescriptionRichTextBox";
            bookDescriptionRichTextBox.Size = new Size(546, 177);
            bookDescriptionRichTextBox.TabIndex = 19;
            bookDescriptionRichTextBox.Text = "";
            // 
            // bookNameTextBox
            // 
            bookNameTextBox.Location = new Point(119, 12);
            bookNameTextBox.Name = "bookNameTextBox";
            bookNameTextBox.Size = new Size(546, 27);
            bookNameTextBox.TabIndex = 18;
            // 
            // bookDescriptionLabel
            // 
            bookDescriptionLabel.AutoSize = true;
            bookDescriptionLabel.Location = new Point(14, 48);
            bookDescriptionLabel.Name = "bookDescriptionLabel";
            bookDescriptionLabel.Size = new Size(88, 20);
            bookDescriptionLabel.TabIndex = 17;
            bookDescriptionLabel.Text = "Description:";
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new Point(14, 15);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new Size(52, 20);
            bookNameLabel.TabIndex = 16;
            bookNameLabel.Text = "Name:";
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.PaleGreen;
            saveChangesButton.Location = new Point(423, 290);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(118, 29);
            saveChangesButton.TabIndex = 22;
            saveChangesButton.Text = "Save changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            // 
            // deleteBookButton
            // 
            deleteBookButton.BackColor = Color.IndianRed;
            deleteBookButton.Location = new Point(547, 290);
            deleteBookButton.Name = "deleteBookButton";
            deleteBookButton.Size = new Size(115, 29);
            deleteBookButton.TabIndex = 23;
            deleteBookButton.Text = "Delete book";
            deleteBookButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(14, 290);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 24;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // sageBindingSource
            // 
            sageBindingSource.DataSource = typeof(Domain.Models.Sage);
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 331);
            Controls.Add(cancelButton);
            Controls.Add(deleteBookButton);
            Controls.Add(saveChangesButton);
            Controls.Add(bookSagesComboBox);
            Controls.Add(bookSagesLabel);
            Controls.Add(bookDescriptionRichTextBox);
            Controls.Add(bookNameTextBox);
            Controls.Add(bookDescriptionLabel);
            Controls.Add(bookNameLabel);
            Name = "EditBookForm";
            Text = "EditBookForm";
            Load += EditBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)sageBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox bookSagesComboBox;
        private Label bookSagesLabel;
        private RichTextBox bookDescriptionRichTextBox;
        private TextBox bookNameTextBox;
        private Label bookDescriptionLabel;
        private Label bookNameLabel;
        private Button saveChangesButton;
        private Button deleteBookButton;
        private Button cancelButton;
        private BindingSource sageBindingSource;
    }
}