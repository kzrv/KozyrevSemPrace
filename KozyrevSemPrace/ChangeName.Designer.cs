namespace KozyrevSemPrace
{
    partial class ChangeName
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
            textBox = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(12, 39);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(776, 78);
            textBox.TabIndex = 0;
            textBox.TabStop = false;
            textBox.Text = "NAME";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.8571434F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 145);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 78);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "SURNAME";
            // 
            // button1
            // 
            button1.Location = new Point(12, 241);
            button1.Name = "button1";
            button1.Size = new Size(192, 66);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(210, 241);
            button2.Name = "button2";
            button2.Size = new Size(192, 66);
            button2.TabIndex = 3;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChangeName
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 319);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(textBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeName";
            Text = "Zadejte Jmeno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}