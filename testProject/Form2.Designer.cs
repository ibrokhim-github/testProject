namespace testProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.back_but = new System.Windows.Forms.Button();
            this.search_but = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.search_but);
            this.panel1.Controls.Add(this.back_but);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 578);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(57, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(531, 473);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // back_but
            // 
            this.back_but.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.back_but.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_but.Location = new System.Drawing.Point(23, 19);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(123, 44);
            this.back_but.TabIndex = 1;
            this.back_but.Text = "Back";
            this.back_but.UseVisualStyleBackColor = false;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // search_but
            // 
            this.search_but.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.search_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_but.BackgroundImage")));
            this.search_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_but.Location = new System.Drawing.Point(622, 30);
            this.search_but.Name = "search_but";
            this.search_but.Size = new System.Drawing.Size(41, 36);
            this.search_but.TabIndex = 2;
            this.search_but.UseVisualStyleBackColor = false;
            this.search_but.Click += new System.EventHandler(this.search_but_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(486, 30);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(130, 36);
            this.searchBox.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 633);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button search_but;
    }
}