namespace Spotify
{
    partial class Qeydiyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qeydiyat));
            name = new TextBox();
            surname = new TextBox();
            gender = new TextBox();
            username = new TextBox();
            password = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            surname.Location = new Point(209, 189);
            surname.Name = "name";
            surname.Size = new Size(196, 27);
            surname.TabIndex = 1;

            // 
            // surname
            // 
            surname.Location = new Point(209, 189);
            surname.Name = "surname";
            surname.Size = new Size(196, 27);
            surname.TabIndex = 1;
            // 
            // gender
            // 
            gender.Location = new Point(209, 222);
            gender.Name = "gender";
            gender.Size = new Size(196, 27);
            gender.TabIndex = 2;
            // 
            // username
            // 
            username.Location = new Point(209, 255);
            username.Name = "username";
            username.Size = new Size(196, 27);
            username.TabIndex = 3;
            // 
            // password
            // 
            password.Location = new Point(209, 288);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(196, 27);
            password.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.SeaShell;
            button1.Location = new Point(168, 338);
            button1.Name = "button1";
            button1.Size = new Size(272, 75);
            button1.TabIndex = 5;
            button1.Text = "Qeydiyatdan Kec";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(139, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(336, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Qeydiyat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(607, 450);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(gender);
            Controls.Add(surname);
            Controls.Add(name);
            Name = "Qeydiyat";
            Text = "Qeydiyat";
            Load += Qeydiyat_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox surname;
        private TextBox gender;
        private TextBox username;
        private TextBox password;
        private Button button1;
        private PictureBox pictureBox2;
    }
}