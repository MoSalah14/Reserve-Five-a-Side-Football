using System.Drawing;
using System.Windows.Forms;

namespace Login_
{
    partial class Login_Form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            Cancel_Btn = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 74);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 126);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 74);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 127);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(115, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 29);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(115, 118);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(195, 29);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F);
            button1.Location = new Point(177, 277);
            button1.Name = "button1";
            button1.Size = new Size(133, 51);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Cancel_Btn
            // 
            Cancel_Btn.Font = new Font("Segoe UI", 20.25F);
            Cancel_Btn.Location = new Point(177, 362);
            Cancel_Btn.Name = "Cancel_Btn";
            Cancel_Btn.Size = new Size(133, 57);
            Cancel_Btn.TabIndex = 7;
            Cancel_Btn.Text = "Cancel";
            Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(26, 186);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login_Btn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 431);
            Controls.Add(checkBox1);
            Controls.Add(Cancel_Btn);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Login_Btn";
            Text = "Login";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button Cancel_Btn;
        private CheckBox checkBox1;
    }
}
