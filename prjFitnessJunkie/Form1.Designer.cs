    namespace prjFitnessJunkie
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
            lblName = new Label();
            lblSurname = new Label();
            label3 = new Label();
            txtName = new TextBox();
            textBox2 = new TextBox();
            txtWeight = new TextBox();
            btn = new Button();
            panel1 = new Panel();
            txtHeight = new TextBox();
            lblHeight = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(30, 94);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(86, 25);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 131);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 2;
            label3.Text = "Weight";
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(184, 131);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(150, 31);
            txtWeight.TabIndex = 5;
            // 
            // btn
            // 
            btn.Location = new Point(184, 246);
            btn.Name = "btn";
            btn.Size = new Size(112, 34);
            btn.TabIndex = 6;
            btn.Text = "button1";
            btn.UseVisualStyleBackColor = true;
            btn.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(402, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 8;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(184, 168);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(150, 31);
            txtHeight.TabIndex = 9;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(30, 168);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(65, 25);
            lblHeight.TabIndex = 10;
            lblHeight.Text = "Height";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeight);
            Controls.Add(txtHeight);
            Controls.Add(panel1);
            Controls.Add(btn);
            Controls.Add(txtWeight);
            Controls.Add(textBox2);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private Label label3;
        private TextBox txtName;
        private TextBox textBox2;
        private TextBox txtWeight;
        private Button btn;
        private Panel panel1;
        private TextBox txtHeight;
        private Label lblHeight;
    }
}
