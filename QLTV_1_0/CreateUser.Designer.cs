namespace QLTV_1_0
{
    partial class CreateUser
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(22, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 380);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(309, 322);
            button1.Name = "button1";
            button1.Size = new Size(126, 42);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(29, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 295);
            panel2.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(185, 242);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 31);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 245);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 10;
            label5.Text = "Ngày lập thẻ";
            label5.Click += label5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(185, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 31);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 192);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 8;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(185, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 31);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 141);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 31);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 84);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Loại DG";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 24);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 2;
            label1.Text = "Họ và tên";
            label1.Click += label1_Click;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 427);
            Controls.Add(panel1);
            Name = "CreateUser";
            Text = "Lập thẻ độc giả";
            Load += CreateUser_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}