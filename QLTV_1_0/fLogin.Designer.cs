namespace QLTV_1_0
{
    partial class fLogin
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
            panel1 = new Panel();
            Exit = new Button();
            LogIn = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(LogIn);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 356);
            panel1.TabIndex = 0;
            // 
            // Exit
            // 
            Exit.Location = new Point(594, 280);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 45);
            Exit.TabIndex = 4;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // LogIn
            // 
            LogIn.Location = new Point(450, 280);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(112, 45);
            LogIn.TabIndex = 3;
            LogIn.Text = "Đăng nhập";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += LogIn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(25, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(726, 92);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(522, 31);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 32);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(24, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(726, 92);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(522, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click_1;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 367);
            Controls.Add(panel1);
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button Exit;
        private Button LogIn;
        private Panel panel3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
    }
}