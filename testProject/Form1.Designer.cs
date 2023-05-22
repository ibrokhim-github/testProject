namespace testProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseConDataSet = new testProject.baseConDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_pay = new System.Windows.Forms.TextBox();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_snack = new System.Windows.Forms.TextBox();
            this.textBox_main = new System.Windows.Forms.TextBox();
            this.snakDrop = new System.Windows.Forms.ComboBox();
            this.dishDrop = new System.Windows.Forms.ComboBox();
            this.numDrop = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.history_but = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            this.updateBut = new System.Windows.Forms.Button();
            this.deletBut = new System.Windows.Forms.Button();
            this.pay_but = new System.Windows.Forms.Button();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTableTableAdapter = new testProject.baseConDataSetTableAdapters.dateTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseConDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 271);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateTableBindingSource
            // 
            this.dateTableBindingSource.DataMember = "dateTable";
            this.dateTableBindingSource.DataSource = this.baseConDataSet;
            // 
            // baseConDataSet
            // 
            this.baseConDataSet.DataSetName = "baseConDataSet";
            this.baseConDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "jnjnj";
            this.panel1.Controls.Add(this.textBox_pay);
            this.panel1.Controls.Add(this.textBox_total);
            this.panel1.Controls.Add(this.textBox_snack);
            this.panel1.Controls.Add(this.textBox_main);
            this.panel1.Controls.Add(this.snakDrop);
            this.panel1.Controls.Add(this.dishDrop);
            this.panel1.Controls.Add(this.numDrop);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.history_but);
            this.panel1.Controls.Add(this.saveBut);
            this.panel1.Controls.Add(this.updateBut);
            this.panel1.Controls.Add(this.deletBut);
            this.panel1.Controls.Add(this.pay_but);
            this.panel1.Controls.Add(this.textBox_num);
            this.panel1.Controls.Add(this.textBox_date);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1151, 632);
            this.panel1.TabIndex = 3;
            // 
            // textBox_pay
            // 
            this.textBox_pay.Location = new System.Drawing.Point(850, 519);
            this.textBox_pay.Multiline = true;
            this.textBox_pay.Name = "textBox_pay";
            this.textBox_pay.ReadOnly = true;
            this.textBox_pay.Size = new System.Drawing.Size(160, 30);
            this.textBox_pay.TabIndex = 19;
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(389, 597);
            this.textBox_total.Multiline = true;
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(160, 30);
            this.textBox_total.TabIndex = 18;
            // 
            // textBox_snack
            // 
            this.textBox_snack.Location = new System.Drawing.Point(389, 561);
            this.textBox_snack.Multiline = true;
            this.textBox_snack.Name = "textBox_snack";
            this.textBox_snack.Size = new System.Drawing.Size(160, 30);
            this.textBox_snack.TabIndex = 17;
            // 
            // textBox_main
            // 
            this.textBox_main.Location = new System.Drawing.Point(389, 525);
            this.textBox_main.Multiline = true;
            this.textBox_main.Name = "textBox_main";
            this.textBox_main.Size = new System.Drawing.Size(160, 30);
            this.textBox_main.TabIndex = 16;
            // 
            // snakDrop
            // 
            this.snakDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.snakDrop.FormattingEnabled = true;
            this.snakDrop.Location = new System.Drawing.Point(96, 519);
            this.snakDrop.Name = "snakDrop";
            this.snakDrop.Size = new System.Drawing.Size(136, 24);
            this.snakDrop.TabIndex = 15;
            // 
            // dishDrop
            // 
            this.dishDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dishDrop.FormattingEnabled = true;
            this.dishDrop.Location = new System.Drawing.Point(96, 474);
            this.dishDrop.Name = "dishDrop";
            this.dishDrop.Size = new System.Drawing.Size(136, 24);
            this.dishDrop.TabIndex = 14;
            // 
            // numDrop
            // 
            this.numDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numDrop.FormattingEnabled = true;
            this.numDrop.Location = new System.Drawing.Point(96, 434);
            this.numDrop.Name = "numDrop";
            this.numDrop.Size = new System.Drawing.Size(137, 24);
            this.numDrop.TabIndex = 13;
            this.numDrop.SelectedIndexChanged += new System.EventHandler(this.numDrop_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormatString = "d";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(624, 519);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // history_but
            // 
            this.history_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("history_but.BackgroundImage")));
            this.history_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.history_but.Location = new System.Drawing.Point(930, 420);
            this.history_but.Name = "history_but";
            this.history_but.Size = new System.Drawing.Size(50, 50);
            this.history_but.TabIndex = 5;
            this.history_but.UseVisualStyleBackColor = true;
            this.history_but.Click += new System.EventHandler(this.history_but_Click);
            // 
            // saveBut
            // 
            this.saveBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBut.BackgroundImage")));
            this.saveBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveBut.Location = new System.Drawing.Point(617, 420);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(50, 50);
            this.saveBut.TabIndex = 11;
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // updateBut
            // 
            this.updateBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBut.BackgroundImage")));
            this.updateBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updateBut.Location = new System.Drawing.Point(850, 420);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(50, 50);
            this.updateBut.TabIndex = 4;
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // deletBut
            // 
            this.deletBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletBut.BackgroundImage")));
            this.deletBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deletBut.Location = new System.Drawing.Point(695, 420);
            this.deletBut.Name = "deletBut";
            this.deletBut.Size = new System.Drawing.Size(50, 50);
            this.deletBut.TabIndex = 10;
            this.deletBut.UseVisualStyleBackColor = true;
            this.deletBut.Click += new System.EventHandler(this.deletBut_Click);
            // 
            // pay_but
            // 
            this.pay_but.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pay_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pay_but.BackgroundImage")));
            this.pay_but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pay_but.Location = new System.Drawing.Point(773, 420);
            this.pay_but.Name = "pay_but";
            this.pay_but.Size = new System.Drawing.Size(50, 50);
            this.pay_but.TabIndex = 7;
            this.pay_but.UseVisualStyleBackColor = false;
            this.pay_but.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(389, 489);
            this.textBox_num.Multiline = true;
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(160, 30);
            this.textBox_num.TabIndex = 7;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(389, 453);
            this.textBox_date.Multiline = true;
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(160, 30);
            this.textBox_date.TabIndex = 6;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(389, 420);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(160, 27);
            this.textBox_id.TabIndex = 5;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.date);
            this.panel2.Location = new System.Drawing.Point(23, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 60);
            this.panel2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(775, 21);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(201, 22);
            this.date.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTableTableAdapter
            // 
            this.dateTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseConDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button history_but;
        private System.Windows.Forms.Button updateBut;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private baseConDataSet baseConDataSet;
        private System.Windows.Forms.BindingSource dateTableBindingSource;
        private baseConDataSetTableAdapters.dateTableTableAdapter dateTableTableAdapter;
        private System.Windows.Forms.Button pay_but;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button deletBut;
        private System.Windows.Forms.Button saveBut;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox snakDrop;
        private System.Windows.Forms.ComboBox dishDrop;
        private System.Windows.Forms.ComboBox numDrop;
        private System.Windows.Forms.TextBox textBox_pay;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_snack;
        private System.Windows.Forms.TextBox textBox_main;
    }
}