namespace _8_ra_mintaZH
{
    partial class Form2
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            versenyzoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)versenyzoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "Nev", true));
            textBox1.Location = new Point(235, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "Nemzetiseg", true));
            textBox2.Location = new Point(235, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "EredmenyPerc", true));
            textBox3.Location = new Point(235, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(291, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "Kategoria", true));
            textBox4.Location = new Point(235, 332);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(291, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", versenyzoBindingSource, "VersenyzoID", true));
            textBox5.Location = new Point(235, 42);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(291, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 5;
            label1.Text = "AZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 70);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 6;
            label2.Text = "Név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 138);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 7;
            label3.Text = "Nemzetiség";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 219);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Eredmény";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 309);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 9;
            label5.Text = "Kategória";
            // 
            // versenyzoBindingSource
            // 
            versenyzoBindingSource.DataSource = typeof(Versenyzo);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)versenyzoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private BindingSource versenyzoBindingSource;
    }
}