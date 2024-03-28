namespace ATTIVATORE_LICENZE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-6, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 48);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("CARIBOLB", 29.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(199, 5);
            label1.Name = "label1";
            label1.Size = new Size(255, 43);
            label1.TabIndex = 2;
            label1.Text = "ATTIVATORE LICENZE";
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove_1;
            label1.MouseUp += label1_MouseUp;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Minecraft Ten", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.ImageAlign = ContentAlignment.BottomLeft;
            button1.Location = new Point(602, 11);
            button1.Name = "button1";
            button1.Size = new Size(21, 26);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(40, 40, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(29, 66);
            button2.Name = "button2";
            button2.Size = new Size(274, 65);
            button2.TabIndex = 1;
            button2.Text = "ATTIVA WINDOWS\r\nPER SEMPRE (HWID)\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(40, 40, 40);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(320, 66);
            button3.Name = "button3";
            button3.Size = new Size(274, 65);
            button3.TabIndex = 2;
            button3.Text = "ATTIVA OFFICE\r\nPER SEMPRE (OHook)\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(40, 40, 40);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(174, 139);
            button4.Name = "button4";
            button4.Size = new Size(274, 65);
            button4.TabIndex = 3;
            button4.Text = "ATTIVA WINDOWS E OFFICE\r\n(KMS online, 180 gg di attivazione)\r\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("CARIBOLB", 29.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(461, 156);
            label2.Name = "label2";
            label2.Size = new Size(151, 43);
            label2.TabIndex = 3;
            label2.Text = "- gabriele";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(624, 216);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
    }
}
