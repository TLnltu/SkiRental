namespace it3
{
    partial class Skiask
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
            this.askskitext = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.weight = new System.Windows.Forms.TextBox();
            this.skillbox = new System.Windows.Forms.ComboBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // askskitext
            // 
            this.askskitext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.askskitext.Location = new System.Drawing.Point(12, 20);
            this.askskitext.Name = "askskitext";
            this.askskitext.Size = new System.Drawing.Size(407, 58);
            this.askskitext.TabIndex = 0;
            this.askskitext.Text = "Введіть, будь ласка, дані, щоб ми могли підібрати лижі для вас.";
            this.askskitext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(264, 250);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(86, 43);
            this.exitbutton.TabIndex = 5;
            this.exitbutton.Text = "Вихід";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(377, 250);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(86, 43);
            this.nextbutton.TabIndex = 1;
            this.nextbutton.Text = "Далі";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // weight
            // 
            this.weight.ForeColor = System.Drawing.Color.Gray;
            this.weight.Location = new System.Drawing.Point(16, 102);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(127, 22);
            this.weight.TabIndex = 4;
            this.weight.Text = "Введіть вагу";
            this.weight.Enter += new System.EventHandler(this.weight_Enter);
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            this.weight.Leave += new System.EventHandler(this.weight_Leave);
            // 
            // skillbox
            // 
            this.skillbox.AccessibleName = "";
            this.skillbox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.skillbox.AllowDrop = true;
            this.skillbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.skillbox.FormattingEnabled = true;
            this.skillbox.Items.AddRange(new object[] {
            "Початківець",
            "Середній",
            "Професіонал"});
            this.skillbox.Location = new System.Drawing.Point(16, 130);
            this.skillbox.Name = "skillbox";
            this.skillbox.Size = new System.Drawing.Size(254, 24);
            this.skillbox.TabIndex = 5;
            this.skillbox.Tag = "";
            this.skillbox.Text = "Виберіть рівень професіоналізму";
            this.skillbox.UseWaitCursor = true;
            this.skillbox.SelectedIndexChanged += new System.EventHandler(this.skillbox_SelectedIndexChanged);
            this.skillbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skillbox_KeyPress);
            this.skillbox.Leave += new System.EventHandler(this.skillbox_Leave);
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(296, 102);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(135, 42);
            this.enterbutton.TabIndex = 7;
            this.enterbutton.Text = "Записати характеристики";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // Skiask
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 305);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.skillbox);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.askskitext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Skiask";
            this.Text = "Skiask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Label askskitext;
        private System.Windows.Forms.TextBox weight;
        public System.Windows.Forms.ComboBox skillbox;
        private System.Windows.Forms.Button enterbutton;
    }
}