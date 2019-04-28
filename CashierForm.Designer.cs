namespace WinCasino
{
    partial class CashierForm
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
            this.casinoDataDataSet = new WinCasino.CasinoDataDataSet();
            this.casinoDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomerSearchUnKeyTB = new System.Windows.Forms.TextBox();
            this.CustomerSearchSSNTB = new System.Windows.Forms.TextBox();
            this.CustomerSearchNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(398, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // casinoDataDataSet
            // 
            this.casinoDataDataSet.DataSetName = "CasinoDataDataSet";
            this.casinoDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // casinoDataDataSetBindingSource
            // 
            this.casinoDataDataSetBindingSource.DataSource = this.casinoDataDataSet;
            this.casinoDataDataSetBindingSource.Position = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "any";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(82, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Customer Unique Key";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(82, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer SSN ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(82, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Customer First Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::WinCasino.Properties.Resources.cs1;
            this.pictureBox1.Location = new System.Drawing.Point(25, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerSearchUnKeyTB
            // 
            this.CustomerSearchUnKeyTB.Location = new System.Drawing.Point(193, 146);
            this.CustomerSearchUnKeyTB.Name = "CustomerSearchUnKeyTB";
            this.CustomerSearchUnKeyTB.ReadOnly = true;
            this.CustomerSearchUnKeyTB.Size = new System.Drawing.Size(100, 20);
            this.CustomerSearchUnKeyTB.TabIndex = 11;
            // 
            // CustomerSearchSSNTB
            // 
            this.CustomerSearchSSNTB.Location = new System.Drawing.Point(193, 120);
            this.CustomerSearchSSNTB.Name = "CustomerSearchSSNTB";
            this.CustomerSearchSSNTB.Size = new System.Drawing.Size(100, 20);
            this.CustomerSearchSSNTB.TabIndex = 10;
            this.CustomerSearchSSNTB.TextChanged += new System.EventHandler(this.CustomerSearchSSNTB_TextChanged);
            // 
            // CustomerSearchNameTB
            // 
            this.CustomerSearchNameTB.Location = new System.Drawing.Point(193, 94);
            this.CustomerSearchNameTB.Name = "CustomerSearchNameTB";
            this.CustomerSearchNameTB.Size = new System.Drawing.Size(100, 20);
            this.CustomerSearchNameTB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CustomerSearchUnKeyTB);
            this.Controls.Add(this.CustomerSearchSSNTB);
            this.Controls.Add(this.CustomerSearchNameTB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casinoDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource casinoDataDataSetBindingSource;
        private CasinoDataDataSet casinoDataDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CustomerSearchUnKeyTB;
        private System.Windows.Forms.TextBox CustomerSearchSSNTB;
        private System.Windows.Forms.TextBox CustomerSearchNameTB;
        private System.Windows.Forms.Label label1;

    }
}