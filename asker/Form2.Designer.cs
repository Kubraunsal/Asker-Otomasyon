namespace asker
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
            this.components = new System.ComponentModel.Container();
            this.askeriPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.askeriPersonelDataSet1 = new asker.AskeriPersonelDataSet1();
            this.askeriPersonelTableAdapter = new asker.AskeriPersonelDataSet1TableAdapters.AskeriPersonelTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.lbxPzrtesi = new System.Windows.Forms.ListBox();
            this.lbxSalı = new System.Windows.Forms.ListBox();
            this.lbxCrşbma = new System.Windows.Forms.ListBox();
            this.lbxPrşmbe = new System.Windows.Forms.ListBox();
            this.lbxCuma = new System.Windows.Forms.ListBox();
            this.lbxCmartsi = new System.Windows.Forms.ListBox();
            this.lbxPazar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.askeriPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.askeriPersonelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // askeriPersonelBindingSource
            // 
            this.askeriPersonelBindingSource.DataMember = "AskeriPersonel";
            this.askeriPersonelBindingSource.DataSource = this.askeriPersonelDataSet1;
            // 
            // askeriPersonelDataSet1
            // 
            this.askeriPersonelDataSet1.DataSetName = "AskeriPersonelDataSet1";
            this.askeriPersonelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // askeriPersonelTableAdapter
            // 
            this.askeriPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Verileri Dağıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbxPzrtesi
            // 
            this.lbxPzrtesi.FormattingEnabled = true;
            this.lbxPzrtesi.ItemHeight = 16;
            this.lbxPzrtesi.Location = new System.Drawing.Point(352, 51);
            this.lbxPzrtesi.Name = "lbxPzrtesi";
            this.lbxPzrtesi.Size = new System.Drawing.Size(144, 228);
            this.lbxPzrtesi.TabIndex = 4;
            // 
            // lbxSalı
            // 
            this.lbxSalı.FormattingEnabled = true;
            this.lbxSalı.ItemHeight = 16;
            this.lbxSalı.Location = new System.Drawing.Point(502, 51);
            this.lbxSalı.Name = "lbxSalı";
            this.lbxSalı.Size = new System.Drawing.Size(144, 228);
            this.lbxSalı.TabIndex = 5;
            // 
            // lbxCrşbma
            // 
            this.lbxCrşbma.FormattingEnabled = true;
            this.lbxCrşbma.ItemHeight = 16;
            this.lbxCrşbma.Location = new System.Drawing.Point(652, 51);
            this.lbxCrşbma.Name = "lbxCrşbma";
            this.lbxCrşbma.Size = new System.Drawing.Size(144, 228);
            this.lbxCrşbma.TabIndex = 6;
            // 
            // lbxPrşmbe
            // 
            this.lbxPrşmbe.FormattingEnabled = true;
            this.lbxPrşmbe.ItemHeight = 16;
            this.lbxPrşmbe.Location = new System.Drawing.Point(802, 51);
            this.lbxPrşmbe.Name = "lbxPrşmbe";
            this.lbxPrşmbe.Size = new System.Drawing.Size(144, 228);
            this.lbxPrşmbe.TabIndex = 7;
            // 
            // lbxCuma
            // 
            this.lbxCuma.FormattingEnabled = true;
            this.lbxCuma.ItemHeight = 16;
            this.lbxCuma.Location = new System.Drawing.Point(419, 323);
            this.lbxCuma.Name = "lbxCuma";
            this.lbxCuma.Size = new System.Drawing.Size(144, 228);
            this.lbxCuma.TabIndex = 8;
            // 
            // lbxCmartsi
            // 
            this.lbxCmartsi.FormattingEnabled = true;
            this.lbxCmartsi.ItemHeight = 16;
            this.lbxCmartsi.Location = new System.Drawing.Point(569, 323);
            this.lbxCmartsi.Name = "lbxCmartsi";
            this.lbxCmartsi.Size = new System.Drawing.Size(144, 228);
            this.lbxCmartsi.TabIndex = 9;
            // 
            // lbxPazar
            // 
            this.lbxPazar.FormattingEnabled = true;
            this.lbxPazar.ItemHeight = 16;
            this.lbxPazar.Location = new System.Drawing.Point(719, 323);
            this.lbxPazar.Name = "lbxPazar";
            this.lbxPazar.Size = new System.Drawing.Size(144, 228);
            this.lbxPazar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pazartesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Salı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Çarşamba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(838, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Perşembe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cuma";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cumartesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(768, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pazar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 226);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 620);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxPazar);
            this.Controls.Add(this.lbxCmartsi);
            this.Controls.Add(this.lbxCuma);
            this.Controls.Add(this.lbxPrşmbe);
            this.Controls.Add(this.lbxCrşbma);
            this.Controls.Add(this.lbxSalı);
            this.Controls.Add(this.lbxPzrtesi);
            this.Controls.Add(this.button2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.askeriPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.askeriPersonelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AskeriPersonelDataSet1 askeriPersonelDataSet1;
        private System.Windows.Forms.BindingSource askeriPersonelBindingSource;
        private AskeriPersonelDataSet1TableAdapters.AskeriPersonelTableAdapter askeriPersonelTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbxPzrtesi;
        private System.Windows.Forms.ListBox lbxSalı;
        private System.Windows.Forms.ListBox lbxCrşbma;
        private System.Windows.Forms.ListBox lbxPrşmbe;
        private System.Windows.Forms.ListBox lbxCuma;
        private System.Windows.Forms.ListBox lbxCmartsi;
        private System.Windows.Forms.ListBox lbxPazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}