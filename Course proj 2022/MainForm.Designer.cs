namespace Course_proj_2022
{
    partial class MainForm
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
            this.simpleModeBT = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.middleModeBT = new System.Windows.Forms.Button();
            this.hardModeBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleModeBT
            // 
            this.simpleModeBT.Location = new System.Drawing.Point(251, 104);
            this.simpleModeBT.Name = "simpleModeBT";
            this.simpleModeBT.Size = new System.Drawing.Size(135, 32);
            this.simpleModeBT.TabIndex = 0;
            this.simpleModeBT.Text = "Простой режим";
            this.simpleModeBT.UseVisualStyleBackColor = true;
            this.simpleModeBT.Click += new System.EventHandler(this.simpleModeBT_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackgroundImage = global::Course_proj_2022.Properties.Resources.спички_icon_ill;
            this.mainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(220, 147);
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainLabel.Location = new System.Drawing.Point(251, 12);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(280, 30);
            this.mainLabel.TabIndex = 2;
            this.mainLabel.Text = "Головоломки со спичками";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aboutLabel.Location = new System.Drawing.Point(251, 63);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(378, 20);
            this.aboutLabel.TabIndex = 3;
            this.aboutLabel.Text = "Разработал студент группы ИСТ-Tb31 Игнатенко Н.А.";
            // 
            // middleModeBT
            // 
            this.middleModeBT.Location = new System.Drawing.Point(392, 104);
            this.middleModeBT.Name = "middleModeBT";
            this.middleModeBT.Size = new System.Drawing.Size(135, 32);
            this.middleModeBT.TabIndex = 0;
            this.middleModeBT.Text = "Средний режим";
            this.middleModeBT.UseVisualStyleBackColor = true;
            this.middleModeBT.Click += new System.EventHandler(this.middleModeBT_Click);
            // 
            // hardModeBT
            // 
            this.hardModeBT.Location = new System.Drawing.Point(533, 104);
            this.hardModeBT.Name = "hardModeBT";
            this.hardModeBT.Size = new System.Drawing.Size(135, 32);
            this.hardModeBT.TabIndex = 0;
            this.hardModeBT.Text = "Сложный режим";
            this.hardModeBT.UseVisualStyleBackColor = true;
            this.hardModeBT.Click += new System.EventHandler(this.hardModeBT_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 172);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.hardModeBT);
            this.Controls.Add(this.middleModeBT);
            this.Controls.Add(this.simpleModeBT);
            this.Name = "MainForm";
            this.Text = "Головоломки со спичками";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button simpleModeBT;
        private PictureBox mainPictureBox;
        private Label mainLabel;
        private Label aboutLabel;
        private Button middleModeBT;
        private Button hardModeBT;
    }
}