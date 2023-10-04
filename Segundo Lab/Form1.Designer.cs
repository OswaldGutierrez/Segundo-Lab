namespace Segundo_Lab
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
            radioButton1 = new RadioButton();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxFuncion1 = new TextBox();
            textBoxFuncion2 = new TextBox();
            buttonCalcular = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(42, 11);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCalcular);
            panel1.Controls.Add(textBoxFuncion2);
            panel1.Controls.Add(textBoxFuncion1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(42, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 403);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Primera función:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Segunda función:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 197);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 2;
            label3.Text = "Punto de intersección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 261);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 3;
            label4.Text = "¿Las rectas son paralelas?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 325);
            label5.Name = "label5";
            label5.Size = new Size(177, 15);
            label5.TabIndex = 4;
            label5.Text = "¿Las rectas son perpendiculares?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 197);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 261);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(287, 325);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // textBoxFuncion1
            // 
            textBoxFuncion1.Location = new Point(156, 17);
            textBoxFuncion1.Name = "textBoxFuncion1";
            textBoxFuncion1.Size = new Size(100, 23);
            textBoxFuncion1.TabIndex = 8;
            // 
            // textBoxFuncion2
            // 
            textBoxFuncion2.Location = new Point(156, 67);
            textBoxFuncion2.Name = "textBoxFuncion2";
            textBoxFuncion2.Size = new Size(100, 23);
            textBoxFuncion2.TabIndex = 9;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(308, 46);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 10;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 601);
            Controls.Add(panel1);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private Panel panel1;
        private Button buttonCalcular;
        private TextBox textBoxFuncion2;
        private TextBox textBoxFuncion1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}