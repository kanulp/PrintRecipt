namespace PrintRecipt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Team_Member_Phone_2 = new System.Windows.Forms.MaskedTextBox();
            this.Team_Member_Phone_1 = new System.Windows.Forms.MaskedTextBox();
            this.Team_Member_2_Year = new System.Windows.Forms.ComboBox();
            this.Team_Member_2_Batch = new System.Windows.Forms.ComboBox();
            this.Team_Member_2_Branch = new System.Windows.Forms.ComboBox();
            this.Team_Member_Name_2 = new System.Windows.Forms.TextBox();
            this.Team_Member_1_Year = new System.Windows.Forms.ComboBox();
            this.Team_Member_1_Batch = new System.Windows.Forms.ComboBox();
            this.Team_Member_1_Branch = new System.Windows.Forms.ComboBox();
            this.Team_Member_Name_1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.print = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider8 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider9 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider10 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider11 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider12 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider13 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider13)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1115, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Team_Member_Phone_2);
            this.panel1.Controls.Add(this.Team_Member_Phone_1);
            this.panel1.Controls.Add(this.Team_Member_2_Year);
            this.panel1.Controls.Add(this.Team_Member_2_Batch);
            this.panel1.Controls.Add(this.Team_Member_2_Branch);
            this.panel1.Controls.Add(this.Team_Member_Name_2);
            this.panel1.Controls.Add(this.Team_Member_1_Year);
            this.panel1.Controls.Add(this.Team_Member_1_Batch);
            this.panel1.Controls.Add(this.Team_Member_1_Branch);
            this.panel1.Controls.Add(this.Team_Member_Name_1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 167);
            this.panel1.TabIndex = 35;
            // 
            // Team_Member_Phone_2
            // 
            this.Team_Member_Phone_2.Location = new System.Drawing.Point(800, 41);
            this.Team_Member_Phone_2.Mask = "000-0000-000";
            this.Team_Member_Phone_2.Name = "Team_Member_Phone_2";
            this.Team_Member_Phone_2.Size = new System.Drawing.Size(214, 20);
            this.Team_Member_Phone_2.TabIndex = 1007;
            // 
            // Team_Member_Phone_1
            // 
            this.Team_Member_Phone_1.Location = new System.Drawing.Point(180, 41);
            this.Team_Member_Phone_1.Mask = "000-0000-000";
            this.Team_Member_Phone_1.Name = "Team_Member_Phone_1";
            this.Team_Member_Phone_1.Size = new System.Drawing.Size(214, 20);
            this.Team_Member_Phone_1.TabIndex = 1006;
            // 
            // Team_Member_2_Year
            // 
            this.Team_Member_2_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Team_Member_2_Year.FormattingEnabled = true;
            this.Team_Member_2_Year.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.Team_Member_2_Year.Location = new System.Drawing.Point(800, 140);
            this.Team_Member_2_Year.Name = "Team_Member_2_Year";
            this.Team_Member_2_Year.Size = new System.Drawing.Size(214, 21);
            this.Team_Member_2_Year.TabIndex = 1003;
            // 
            // Team_Member_2_Batch
            // 
            this.Team_Member_2_Batch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Team_Member_2_Batch.FormattingEnabled = true;
            this.Team_Member_2_Batch.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.Team_Member_2_Batch.Location = new System.Drawing.Point(800, 109);
            this.Team_Member_2_Batch.Name = "Team_Member_2_Batch";
            this.Team_Member_2_Batch.Size = new System.Drawing.Size(214, 21);
            this.Team_Member_2_Batch.TabIndex = 1002;
            // 
            // Team_Member_2_Branch
            // 
            this.Team_Member_2_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Team_Member_2_Branch.FormattingEnabled = true;
            this.Team_Member_2_Branch.Items.AddRange(new object[] {
            "CH",
            "CIVIL",
            "CO",
            "EC",
            "EL",
            "IC",
            "IT",
            "MCA",
            "Mech",
            "TT"});
            this.Team_Member_2_Branch.Location = new System.Drawing.Point(801, 78);
            this.Team_Member_2_Branch.Name = "Team_Member_2_Branch";
            this.Team_Member_2_Branch.Size = new System.Drawing.Size(214, 21);
            this.Team_Member_2_Branch.TabIndex = 1001;
            // 
            // Team_Member_Name_2
            // 
            this.Team_Member_Name_2.Location = new System.Drawing.Point(800, 11);
            this.Team_Member_Name_2.Name = "Team_Member_Name_2";
            this.Team_Member_Name_2.Size = new System.Drawing.Size(214, 20);
            this.Team_Member_Name_2.TabIndex = 56;
            // 
            // Team_Member_1_Year
            // 
            this.Team_Member_1_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Team_Member_1_Year.FormattingEnabled = true;
            this.Team_Member_1_Year.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.Team_Member_1_Year.Location = new System.Drawing.Point(180, 141);
            this.Team_Member_1_Year.Name = "Team_Member_1_Year";
            this.Team_Member_1_Year.Size = new System.Drawing.Size(214, 21);
            this.Team_Member_1_Year.TabIndex = 53;
            // 
            // Team_Member_1_Batch
            // 
            this.Team_Member_1_Batch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Team_Member_1_Batch.FormattingEnabled = true;
            this.Team_Member_1_Batch.Items.AddRange(new object[] {
            "Morning",
            "Evening"});
            this.Team_Member_1_Batch.Location = new System.Drawing.Point(180, 108);
            this.Team_Member_1_Batch.Name = "Team_Member_1_Batch";
            this.Team_Member_1_Batch.Size = new System.Drawing.Size(214, 21);
            this.Team_Member_1_Batch.TabIndex = 52;
            // 
            // Team_Member_1_Branch
            // 
            this.Team_Member_1_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Team_Member_1_Branch.FormattingEnabled = true;
            this.Team_Member_1_Branch.Items.AddRange(new object[] {
            "CH",
            "CIVIL",
            "CO",
            "EC",
            "EL",
            "IC",
            "IT",
            "MCA",
            "Mech",
            "TT"});
            this.Team_Member_1_Branch.Location = new System.Drawing.Point(180, 75);
            this.Team_Member_1_Branch.Name = "Team_Member_1_Branch";
            this.Team_Member_1_Branch.Size = new System.Drawing.Size(214, 21);
            this.Team_Member_1_Branch.TabIndex = 51;
            this.Team_Member_1_Branch.SelectedIndexChanged += new System.EventHandler(this.Team_Member_1_Branch_SelectedIndexChanged);
            // 
            // Team_Member_Name_1
            // 
            this.Team_Member_Name_1.Location = new System.Drawing.Point(180, 15);
            this.Team_Member_Name_1.Name = "Team_Member_Name_1";
            this.Team_Member_Name_1.Size = new System.Drawing.Size(214, 20);
            this.Team_Member_Name_1.TabIndex = 49;
            this.Team_Member_Name_1.TextChanged += new System.EventHandler(this.Team_Member_Name_1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Team_Member_2_Batch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Team_Member_1_Batch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(629, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Team_Member_2_Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Team_Member_1_Branch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Team_Member_1_Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(629, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Team_Member_2_Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Team_Member_Phone_2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Team_Member_Phone_1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Team_Member_Name_2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Team_Member_Name_1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.print);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.add);
            this.panel2.Location = new System.Drawing.Point(52, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 100);
            this.panel2.TabIndex = 39;
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(801, 20);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(143, 61);
            this.print.TabIndex = 41;
            this.print.Text = "PRINT";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(447, 20);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(143, 61);
            this.clear.TabIndex = 40;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(110, 20);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(143, 61);
            this.add.TabIndex = 39;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            this.errorProvider8.ContainerControl = this;
            // 
            // errorProvider9
            // 
            this.errorProvider9.ContainerControl = this;
            // 
            // errorProvider10
            // 
            this.errorProvider10.ContainerControl = this;
            // 
            // errorProvider11
            // 
            this.errorProvider11.ContainerControl = this;
            // 
            // errorProvider12
            // 
            this.errorProvider12.ContainerControl = this;
            // 
            // errorProvider13
            // 
            this.errorProvider13.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN WINDOW";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Team_Member_Name_2;
        private System.Windows.Forms.ComboBox Team_Member_1_Year;
        private System.Windows.Forms.ComboBox Team_Member_1_Batch;
        private System.Windows.Forms.ComboBox Team_Member_1_Branch;
        private System.Windows.Forms.TextBox Team_Member_Name_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProvider8;
        private System.Windows.Forms.ErrorProvider errorProvider9;
        private System.Windows.Forms.ErrorProvider errorProvider10;
        private System.Windows.Forms.ErrorProvider errorProvider11;
        private System.Windows.Forms.ErrorProvider errorProvider12;
        private System.Windows.Forms.ErrorProvider errorProvider13;
        private System.Windows.Forms.ComboBox Team_Member_2_Branch;
        private System.Windows.Forms.ComboBox Team_Member_2_Batch;
        private System.Windows.Forms.ComboBox Team_Member_2_Year;
        private System.Windows.Forms.MaskedTextBox Team_Member_Phone_1;
        private System.Windows.Forms.MaskedTextBox Team_Member_Phone_2;
    }
}

