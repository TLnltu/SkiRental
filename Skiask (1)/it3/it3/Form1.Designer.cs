namespace it3
{
    partial class menu
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
            this.Welcome = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.mkorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.Location = new System.Drawing.Point(12, 22);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(366, 49);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Доброго дня, якщо вам потрібні лижі, абонемент та решта спорядження, натиніть кно" +
    "пку замовити";
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(15, 93);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(131, 42);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "Вийти";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // mkorder
            // 
            this.mkorder.Location = new System.Drawing.Point(174, 93);
            this.mkorder.Name = "mkorder";
            this.mkorder.Size = new System.Drawing.Size(131, 42);
            this.mkorder.TabIndex = 1;
            this.mkorder.Text = "Замовити";
            this.mkorder.UseVisualStyleBackColor = true;
            this.mkorder.Click += new System.EventHandler(this.mkorder_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 253);
            this.Controls.Add(this.mkorder);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "menu";
            this.Text = "Замовлення лиж";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button mkorder;
    }
}

