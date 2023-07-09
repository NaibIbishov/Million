namespace FormProyekt
{
    partial class BankCash
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button37 = new Button();
            button38 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(178, 98);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(168, 35);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 1;
            label2.Text = "Naib İbişov Həbib oğlu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(167, 156);
            label3.Name = "label3";
            label3.Size = new Size(279, 32);
            label3.TabIndex = 2;
            label3.Text = "Cari ödənilməli məbləğ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(178, 227);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 3;
            // 
            // button37
            // 
            button37.BackColor = Color.LimeGreen;
            button37.BackgroundImageLayout = ImageLayout.Zoom;
            button37.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button37.ImageAlign = ContentAlignment.BottomCenter;
            button37.Location = new Point(474, 373);
            button37.Name = "button37";
            button37.Size = new Size(152, 53);
            button37.TabIndex = 49;
            button37.Text = "İrəli";
            button37.UseVisualStyleBackColor = false;
            button37.Click += button37_Click;
            // 
            // button38
            // 
            button38.BackColor = Color.Firebrick;
            button38.BackgroundImageLayout = ImageLayout.Zoom;
            button38.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button38.ImageAlign = ContentAlignment.BottomCenter;
            button38.Location = new Point(279, 373);
            button38.Name = "button38";
            button38.Size = new Size(152, 53);
            button38.TabIndex = 48;
            button38.Text = "Geri";
            button38.UseVisualStyleBackColor = false;
            button38.Click += button38_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(78, 373);
            button1.Name = "button1";
            button1.Size = new Size(152, 53);
            button1.TabIndex = 50;
            button1.Text = "Ana səhifə";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BankCash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button37);
            Controls.Add(button38);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BankCash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BankCash";
            Load += BankCash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button37;
        private Button button38;
        private Button button1;
    }
}