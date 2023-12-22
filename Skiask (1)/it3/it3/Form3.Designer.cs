namespace it3
{
    partial class equipmentask
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
            this.label1 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.shoesize = new System.Windows.Forms.TextBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.enterbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вкажіть, будь ласка, ваш зріст та розмір взуття, для пібору решти спорядження.";
            // 
            // height
            // 
            this.height.ForeColor = System.Drawing.SystemColors.GrayText;
            this.height.Location = new System.Drawing.Point(12, 84);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(100, 22);
            this.height.TabIndex = 3;
            this.height.Text = "Введіть зріст";
            this.height.Enter += new System.EventHandler(this.height_Enter);
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            this.height.Leave += new System.EventHandler(this.height_Leave);
            // 
            // shoesize
            // 
            this.shoesize.ForeColor = System.Drawing.SystemColors.GrayText;
            this.shoesize.Location = new System.Drawing.Point(12, 127);
            this.shoesize.Name = "shoesize";
            this.shoesize.Size = new System.Drawing.Size(159, 22);
            this.shoesize.TabIndex = 2;
            this.shoesize.Text = "Введіть розмір взуття";
            this.shoesize.Enter += new System.EventHandler(this.shoesize_Enter);
            this.shoesize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shoesize_KeyPress);
            this.shoesize.Leave += new System.EventHandler(this.shoesize_Leave);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(137, 200);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(86, 43);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "Вихід";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(265, 200);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(86, 43);
            this.nextbutton.TabIndex = 1;
            this.nextbutton.Text = "Далі";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(210, 95);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(128, 54);
            this.enterbutton.TabIndex = 5;
            this.enterbutton.Text = "Записати характеристики";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // equipmentask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.shoesize);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "equipmentask";
            this.Text = "Equipment";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox shoesize;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button enterbutton;
    }
}