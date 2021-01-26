namespace EGRUL
{
    partial class NewVid
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
            this.idVidLicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidLicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klimentevDataSet = new EGRUL.KlimentevDataSet();
            this.dtStartPicker = new System.Windows.Forms.DateTimePicker();
            this.dtEndPicker = new System.Windows.Forms.DateTimePicker();
            this.mainCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vidLicTableAdapter = new EGRUL.KlimentevDataSetTableAdapters.VidLicTableAdapter();
            this.buttonReady = new System.Windows.Forms.Button();
            this.numberLicBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sostLicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sostLicTableAdapter = new EGRUL.KlimentevDataSetTableAdapters.SostLicTableAdapter();
            this.dtReshPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtStopPicker = new System.Windows.Forms.DateTimePicker();
            this.dtStartNowPicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidLicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klimentevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostLicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVidLicDataGridViewTextBoxColumn,
            this.vlNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vidLicBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(318, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // idVidLicDataGridViewTextBoxColumn
            // 
            this.idVidLicDataGridViewTextBoxColumn.DataPropertyName = "IdVidLic";
            this.idVidLicDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idVidLicDataGridViewTextBoxColumn.Name = "idVidLicDataGridViewTextBoxColumn";
            this.idVidLicDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVidLicDataGridViewTextBoxColumn.Width = 25;
            // 
            // vlNameDataGridViewTextBoxColumn
            // 
            this.vlNameDataGridViewTextBoxColumn.DataPropertyName = "vlName";
            this.vlNameDataGridViewTextBoxColumn.HeaderText = "Наименование деятельости";
            this.vlNameDataGridViewTextBoxColumn.Name = "vlNameDataGridViewTextBoxColumn";
            this.vlNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // vidLicBindingSource
            // 
            this.vidLicBindingSource.DataMember = "VidLic";
            this.vidLicBindingSource.DataSource = this.klimentevDataSet;
            // 
            // klimentevDataSet
            // 
            this.klimentevDataSet.DataSetName = "KlimentevDataSet";
            this.klimentevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtStartPicker
            // 
            this.dtStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartPicker.Location = new System.Drawing.Point(336, 64);
            this.dtStartPicker.Name = "dtStartPicker";
            this.dtStartPicker.Size = new System.Drawing.Size(98, 20);
            this.dtStartPicker.TabIndex = 1;
            // 
            // dtEndPicker
            // 
            this.dtEndPicker.Checked = false;
            this.dtEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndPicker.Location = new System.Drawing.Point(336, 90);
            this.dtEndPicker.Name = "dtEndPicker";
            this.dtEndPicker.ShowCheckBox = true;
            this.dtEndPicker.Size = new System.Drawing.Size(98, 20);
            this.dtEndPicker.TabIndex = 2;
            // 
            // mainCheckBox
            // 
            this.mainCheckBox.AutoSize = true;
            this.mainCheckBox.Location = new System.Drawing.Point(336, 181);
            this.mainCheckBox.Name = "mainCheckBox";
            this.mainCheckBox.Size = new System.Drawing.Size(226, 17);
            this.mainCheckBox.TabIndex = 3;
            this.mainCheckBox.Text = "Признак основного вида деятельности";
            this.mainCheckBox.UseVisualStyleBackColor = true;
            this.mainCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата начала деятельности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата окончания деятельности";
            // 
            // vidLicTableAdapter
            // 
            this.vidLicTableAdapter.ClearBeforeFill = true;
            // 
            // buttonReady
            // 
            this.buttonReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReady.Location = new System.Drawing.Point(418, 214);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(114, 27);
            this.buttonReady.TabIndex = 6;
            this.buttonReady.Text = "Ready";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberLicBox
            // 
            this.numberLicBox.Location = new System.Drawing.Point(336, 12);
            this.numberLicBox.Name = "numberLicBox";
            this.numberLicBox.Size = new System.Drawing.Size(98, 20);
            this.numberLicBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер лицензии";
            // 
            // sostLicBindingSource
            // 
            this.sostLicBindingSource.DataMember = "SostLic";
            this.sostLicBindingSource.DataSource = this.klimentevDataSet;
            // 
            // sostLicTableAdapter
            // 
            this.sostLicTableAdapter.ClearBeforeFill = true;
            // 
            // dtReshPicker
            // 
            this.dtReshPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReshPicker.Location = new System.Drawing.Point(336, 38);
            this.dtReshPicker.Name = "dtReshPicker";
            this.dtReshPicker.Size = new System.Drawing.Size(98, 20);
            this.dtReshPicker.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата принятия решения";
            // 
            // dtStopPicker
            // 
            this.dtStopPicker.Checked = false;
            this.dtStopPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStopPicker.Location = new System.Drawing.Point(336, 124);
            this.dtStopPicker.Name = "dtStopPicker";
            this.dtStopPicker.ShowCheckBox = true;
            this.dtStopPicker.Size = new System.Drawing.Size(98, 20);
            this.dtStopPicker.TabIndex = 11;
            // 
            // dtStartNowPicker
            // 
            this.dtStartNowPicker.Checked = false;
            this.dtStartNowPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartNowPicker.Location = new System.Drawing.Point(336, 150);
            this.dtStartNowPicker.Name = "dtStartNowPicker";
            this.dtStartNowPicker.ShowCheckBox = true;
            this.dtStartNowPicker.Size = new System.Drawing.Size(98, 20);
            this.dtStartNowPicker.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(336, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 2);
            this.panel1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата приостановления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата возобнавления";
            // 
            // NewVid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 253);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtStartNowPicker);
            this.Controls.Add(this.dtStopPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtReshPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberLicBox);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainCheckBox);
            this.Controls.Add(this.dtEndPicker);
            this.Controls.Add(this.dtStartPicker);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewVid";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.NewVid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidLicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klimentevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostLicBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private KlimentevDataSet klimentevDataSet;
        private System.Windows.Forms.BindingSource vidLicBindingSource;
        private KlimentevDataSetTableAdapters.VidLicTableAdapter vidLicTableAdapter;
        protected internal System.Windows.Forms.DateTimePicker dtStartPicker;
        protected internal System.Windows.Forms.DateTimePicker dtEndPicker;
        protected internal System.Windows.Forms.CheckBox mainCheckBox;
        private System.Windows.Forms.Button buttonReady;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox numberLicBox;
        private System.Windows.Forms.BindingSource sostLicBindingSource;
        private KlimentevDataSetTableAdapters.SostLicTableAdapter sostLicTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVidLicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlNameDataGridViewTextBoxColumn;
        protected internal System.Windows.Forms.DateTimePicker dtReshPicker;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.DateTimePicker dtStopPicker;
        protected internal System.Windows.Forms.DateTimePicker dtStartNowPicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}