namespace NotesManagement
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            dataGridView = new DataGridView();
            welcomeLabel = new Label();
            newButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(59, 93);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(671, 278);
            dataGridView.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Brush Script MT", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(238, 33);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(305, 46);
            welcomeLabel.TabIndex = 1;
            welcomeLabel.Text = "Welcome to Your Notes!";
            // 
            // newButton
            // 
            newButton.Cursor = Cursors.Hand;
            newButton.FlatStyle = FlatStyle.Popup;
            newButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            newButton.Location = new Point(350, 393);
            newButton.Name = "newButton";
            newButton.Size = new Size(94, 29);
            newButton.TabIndex = 2;
            newButton.Text = "New Note";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += NewButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(newButton);
            Controls.Add(welcomeLabel);
            Controls.Add(dataGridView);
            Name = "HomePage";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Label welcomeLabel;
        private Button newButton;
    }
}