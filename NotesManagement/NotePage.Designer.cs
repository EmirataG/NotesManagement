namespace NotesManagement
{
    partial class NotePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePage));
            contentBox = new TextBox();
            titleBox = new TextBox();
            addButton = new Button();
            backButton = new Button();
            exportButton = new Button();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // contentBox
            // 
            contentBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            contentBox.Location = new Point(31, 98);
            contentBox.Multiline = true;
            contentBox.Name = "contentBox";
            contentBox.PlaceholderText = "Note content...";
            contentBox.Size = new Size(707, 270);
            contentBox.TabIndex = 0;
            // 
            // titleBox
            // 
            titleBox.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            titleBox.Location = new Point(31, 36);
            titleBox.Name = "titleBox";
            titleBox.PlaceholderText = "Note Title";
            titleBox.Size = new Size(247, 41);
            titleBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(644, 36);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 41);
            addButton.TabIndex = 2;
            addButton.Text = "Save";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += SaveButton_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(337, 386);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 41);
            backButton.TabIndex = 3;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += BackButton_Click;
            // 
            // exportButton
            // 
            exportButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exportButton.Location = new Point(544, 36);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(94, 41);
            exportButton.TabIndex = 4;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(444, 36);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 41);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // NotePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(exportButton);
            Controls.Add(backButton);
            Controls.Add(addButton);
            Controls.Add(titleBox);
            Controls.Add(contentBox);
            Name = "NotePage";
            Text = "NotePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox contentBox;
        private TextBox titleBox;
        private Button addButton;
        private Button backButton;
        private Button exportButton;
        private Button deleteButton;
    }
}