namespace it3
{
    partial class skipasses
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
            this.lastlbl = new System.Windows.Forms.Label();
            this.daysamount = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.mkorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastlbl
            // 
            this.lastlbl.Location = new System.Drawing.Point(36, 13);
            this.lastlbl.Name = "lastlbl";
            this.lastlbl.Size = new System.Drawing.Size(273, 64);
            this.lastlbl.TabIndex = 1;
            this.lastlbl.Text = "Вкажіть, будь ласка, кількість днів на яку б ви хоіли купити абонемент.";
            // 
            // daysamount
            // 
            this.daysamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.daysamount.ForeColor = System.Drawing.SystemColors.GrayText;
            this.daysamount.Location = new System.Drawing.Point(12, 119);
            this.daysamount.Multiline = true;
            this.daysamount.Name = "daysamount";
            this.daysamount.Size = new System.Drawing.Size(212, 40);
            this.daysamount.TabIndex = 2;
            this.daysamount.Text = "Введіть кількість днів";
            this.daysamount.Enter += new System.EventHandler(this.daysamount_Enter);
            this.daysamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daysamount_KeyPress);
            this.daysamount.Leave += new System.EventHandler(this.daysamount_Leave);
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(252, 119);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(105, 40);
            this.enter.TabIndex = 3;
            this.enter.Text = "Підтвердити";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(100, 198);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(89, 48);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.Text = "Вихід";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // mkorder
            // 
            this.mkorder.Location = new System.Drawing.Point(239, 198);
            this.mkorder.Name = "mkorder";
            this.mkorder.Size = new System.Drawing.Size(88, 49);
            this.mkorder.TabIndex = 5;
            this.mkorder.Text = "Замовити";
            this.mkorder.UseVisualStyleBackColor = true;
            this.mkorder.Click += new System.EventHandler(this.mkorder_Click);
            // 
            // skipasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 300);
            this.Controls.Add(this.mkorder);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.daysamount);
            this.Controls.Add(this.lastlbl);
            this.Name = "skipasses";
            this.Text = "Number of days";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastlbl;
        private System.Windows.Forms.TextBox daysamount;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button mkorder;
    }
}