namespace EnchIO
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
            this.pb = new System.Windows.Forms.PictureBox();
            this.parameters = new System.Windows.Forms.Label();
            this.EnchBtn = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.parameters2 = new System.Windows.Forms.Label();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.parameters3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(48, 47);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(136, 137);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // parameters
            // 
            this.parameters.AutoSize = true;
            this.parameters.Location = new System.Drawing.Point(84, 205);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(53, 75);
            this.parameters.TabIndex = 2;
            this.parameters.Text = "Ench: +0\r\nRarity :\r\nPower :\r\nSpeed :\r\nCost :";
            // 
            // EnchBtn
            // 
            this.EnchBtn.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnchBtn.Location = new System.Drawing.Point(298, 338);
            this.EnchBtn.Name = "EnchBtn";
            this.EnchBtn.Size = new System.Drawing.Size(156, 57);
            this.EnchBtn.TabIndex = 3;
            this.EnchBtn.Text = "Ench";
            this.EnchBtn.UseVisualStyleBackColor = true;
            this.EnchBtn.Click += new System.EventHandler(this.EnchBtn_Click);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(307, 47);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(136, 137);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // parameters2
            // 
            this.parameters2.AutoSize = true;
            this.parameters2.Location = new System.Drawing.Point(349, 205);
            this.parameters2.Name = "parameters2";
            this.parameters2.Size = new System.Drawing.Size(53, 75);
            this.parameters2.TabIndex = 2;
            this.parameters2.Text = "Ench: +0\r\nRarity :\r\nPower :\r\nSpeed :\r\nCost :";
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(566, 47);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(136, 137);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 1;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // parameters3
            // 
            this.parameters3.AutoSize = true;
            this.parameters3.Location = new System.Drawing.Point(608, 205);
            this.parameters3.Name = "parameters3";
            this.parameters3.Size = new System.Drawing.Size(53, 75);
            this.parameters3.TabIndex = 2;
            this.parameters3.Text = "Ench: +0\r\nRarity :\r\nPower :\r\nSpeed :\r\nCost :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnchBtn);
            this.Controls.Add(this.parameters3);
            this.Controls.Add(this.parameters2);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label parameters;
        private System.Windows.Forms.Button EnchBtn;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Label parameters2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Label parameters3;
    }
}