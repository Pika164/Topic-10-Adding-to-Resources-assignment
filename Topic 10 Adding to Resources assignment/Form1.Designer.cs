namespace Topic_10_Adding_to_Resources_assignment
{
    partial class Animals
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
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCat = new System.Windows.Forms.Button();
            this.btnFox = new System.Windows.Forms.Button();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnTurtle = new System.Windows.Forms.Button();
            this.btnAxolotl = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.Image = global::Topic_10_Adding_to_Resources_assignment.Properties.Resources.Cat;
            this.imgBox.Location = new System.Drawing.Point(239, 105);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(473, 384);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            this.imgBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 43);
            this.label1.MaximumSize = new System.Drawing.Size(650, 100);
            this.label1.MinimumSize = new System.Drawing.Size(172, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on the buttons to Learn more about the animals!";
            // 
            // btnCat
            // 
            this.btnCat.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat.Location = new System.Drawing.Point(24, 80);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(122, 61);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "Cat";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            this.btnCat.MouseHover += new System.EventHandler(this.btnCat_MouseHover);
            // 
            // btnFox
            // 
            this.btnFox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFox.Location = new System.Drawing.Point(24, 187);
            this.btnFox.Name = "btnFox";
            this.btnFox.Size = new System.Drawing.Size(122, 61);
            this.btnFox.TabIndex = 3;
            this.btnFox.Text = "Fox";
            this.btnFox.UseVisualStyleBackColor = true;
            this.btnFox.Click += new System.EventHandler(this.btnFox_Click);
            this.btnFox.MouseHover += new System.EventHandler(this.btnFox_MouseHover);
            // 
            // btnDog
            // 
            this.btnDog.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDog.Location = new System.Drawing.Point(24, 296);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(122, 61);
            this.btnDog.TabIndex = 4;
            this.btnDog.Text = "Dog";
            this.btnDog.UseVisualStyleBackColor = true;
            // 
            // btnTurtle
            // 
            this.btnTurtle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurtle.Location = new System.Drawing.Point(24, 405);
            this.btnTurtle.Name = "btnTurtle";
            this.btnTurtle.Size = new System.Drawing.Size(122, 61);
            this.btnTurtle.TabIndex = 5;
            this.btnTurtle.Text = "Turtle";
            this.btnTurtle.UseVisualStyleBackColor = true;
            // 
            // btnAxolotl
            // 
            this.btnAxolotl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAxolotl.Location = new System.Drawing.Point(24, 504);
            this.btnAxolotl.Name = "btnAxolotl";
            this.btnAxolotl.Size = new System.Drawing.Size(122, 61);
            this.btnAxolotl.TabIndex = 6;
            this.btnAxolotl.Text = "Axolotl";
            this.btnAxolotl.UseVisualStyleBackColor = true;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(223, 526);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(128, 21);
            this.lblinfo.TabIndex = 7;
            this.lblinfo.Text = "Waiting for input";
            this.lblinfo.Visible = false;
            // 
            // Animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(878, 596);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnAxolotl);
            this.Controls.Add(this.btnTurtle);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.btnFox);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBox);
            this.Name = "Animals";
            this.Text = "Animal Info";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Button btnFox;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnTurtle;
        private System.Windows.Forms.Button btnAxolotl;
        private System.Windows.Forms.Label lblinfo;
    }
}

