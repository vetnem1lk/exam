namespace EGRUL
{
    partial class EditLicenz
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
            this.comboBoxVidLic = new System.Windows.Forms.ComboBox();
            this.vidLicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klimentevDataSet = new EGRUL.KlimentevDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.numberLicBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainCheckBox = new System.Windows.Forms.CheckBox();
            this.dtEndPicker = new System.Windows.Forms.DateTimePicker();
            this.dtStartPicker = new System.Windows.Forms.DateTimePicker();
            this.licenzBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licenzTableAdapter = new EGRUL.KlimentevDataSetTableAdapters.LicenzTableAdapter();
            this.licenzBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vidLicTableAdapter = new EGRUL.KlimentevDataSetTableAdapters.VidLicTableAdapter();
            this.ButtonReady = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtReshPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtStartNowPicker = new System.Windows.Forms.DateTimePicker();
            this.dtStopPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.vidLicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klimentevDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenzBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenzBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxVidLic
            // 
            this.comboBoxVidLic.DataSource = this.vidLicBindingSource;
            this.comboBoxVidLic.DisplayMember = "vlName";
            this.comboBoxVidLic.FormattingEnabled = true;
            this.comboBoxVidLic.Location = new System.Drawing.Point(12, 42);
            this.comboBoxVidLic.Name = "comboBoxVidLic";
            this.comboBoxVidLic.Size = new System.Drawing.Size(336, 21);
            this.comboBoxVidLic.TabIndex = 0;
            this.comboBoxVidLic.ValueMember = "IdVidLic";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Номер лицензии";
            // 
            // numberLicBox
            // 
            this.numberLicBox.Location = new System.Drawing.Point(61, 114);
            this.numberLicBox.Name = "numberLicBox";
            this.numberLicBox.Size = new System.Drawing.Size(98, 20);
            this.numberLicBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Дата окончания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Дата начала";
            // 
            // mainCheckBox
            // 
            this.mainCheckBox.AutoSize = true;
            this.mainCheckBox.Location = new System.Drawing.Point(61, 278);
            this.mainCheckBox.Name = "mainCheckBox";
            this.mainCheckBox.Size = new System.Drawing.Size(226, 17);
            this.mainCheckBox.TabIndex = 11;
            this.mainCheckBox.Text = "Признак основного вида деятельности";
            this.mainCheckBox.UseVisualStyleBackColor = true;
            // 
            // dtEndPicker
            // 
            this.dtEndPicker.Checked = false;
            this.dtEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndPicker.Location = new System.Drawing.Point(61, 192);
            this.dtEndPicker.Name = "dtEndPicker";
            this.dtEndPicker.ShowCheckBox = true;
            this.dtEndPicker.Size = new System.Drawing.Size(98, 20);
            this.dtEndPicker.TabIndex = 10;
            // 
            // dtStartPicker
            // 
            this.dtStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartPicker.Location = new System.Drawing.Point(61, 166);
            this.dtStartPicker.Name = "dtStartPicker";
            this.dtStartPicker.Size = new System.Drawing.Size(98, 20);
            this.dtStartPicker.TabIndex = 9;
            // 
            // licenzBindingSource
            // 
            this.licenzBindingSource.DataMember = "Licenz";
            this.licenzBindingSource.DataSource = this.klimentevDataSet;
            // 
            // licenzTableAdapter
            // 
            this.licenzTableAdapter.ClearBeforeFill = true;
            // 
            // licenzBindingSource1
            // 
            this.licenzBindingSource1.DataMember = "Licenz";
            this.licenzBindingSource1.DataSource = this.klimentevDataSet;
            // 
            // vidLicTableAdapter
            // 
            this.vidLicTableAdapter.ClearBeforeFill = true;
            // 
            // ButtonReady
            // 
            this.ButtonReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReady.Location = new System.Drawing.Point(131, 336);
            this.ButtonReady.Name = "ButtonReady";
            this.ButtonReady.Size = new System.Drawing.Size(105, 36);
            this.ButtonReady.TabIndex = 16;
            this.ButtonReady.Text = "Ready";
            this.ButtonReady.UseVisualStyleBackColor = true;
            this.ButtonReady.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата принятия решения";
            // 
            // dtReshPicker
            // 
            this.dtReshPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtReshPicker.Location = new System.Drawing.Point(61, 140);
            this.dtReshPicker.Name = "dtReshPicker";
            this.dtReshPicker.Size = new System.Drawing.Size(98, 20);
            this.dtReshPicker.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выберите деятельность";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Дата возобнавления";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Дата приостановления";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(61, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 2);
            this.panel1.TabIndex = 23;
            // 
            // dtStartNowPicker
            // 
            this.dtStartNowPicker.Checked = false;
            this.dtStartNowPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartNowPicker.Location = new System.Drawing.Point(61, 252);
            this.dtStartNowPicker.Name = "dtStartNowPicker";
            this.dtStartNowPicker.ShowCheckBox = true;
            this.dtStartNowPicker.Size = new System.Drawing.Size(98, 20);
            this.dtStartNowPicker.TabIndex = 22;
            // 
            // dtStopPicker
            // 
            this.dtStopPicker.Checked = false;
            this.dtStopPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStopPicker.Location = new System.Drawing.Point(61, 226);
            this.dtStopPicker.Name = "dtStopPicker";
            this.dtStopPicker.ShowCheckBox = true;
            this.dtStopPicker.Size = new System.Drawing.Size(98, 20);
            this.dtStopPicker.TabIndex = 21;
            // 
            // EditLicenz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 384);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtStartNowPicker);
            this.Controls.Add(this.dtStopPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtReshPicker);
            this.Controls.Add(this.ButtonReady);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberLicBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainCheckBox);
            this.Controls.Add(this.dtEndPicker);
            this.Controls.Add(this.dtStartPicker);
            this.Controls.Add(this.comboBoxVidLic);
            this.Name = "EditLicenz";
            this.Text = "Редактировать запись";
            this.Load += new System.EventHandler(this.EditLicenz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vidLicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klimentevDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenzBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licenzBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.TextBox numberLicBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.CheckBox mainCheckBox;
        protected internal System.Windows.Forms.DateTimePicker dtEndPicker;
        protected internal System.Windows.Forms.DateTimePicker dtStartPicker;
        private KlimentevDataSet klimentevDataSet;
        private System.Windows.Forms.BindingSource licenzBindingSource;
        private KlimentevDataSetTableAdapters.LicenzTableAdapter licenzTableAdapter;
        private System.Windows.Forms.BindingSource licenzBindingSource1;
        private System.Windows.Forms.BindingSource vidLicBindingSource;
        private KlimentevDataSetTableAdapters.VidLicTableAdapter vidLicTableAdapter;
        protected internal System.Windows.Forms.ComboBox comboBoxVidLic;
        private System.Windows.Forms.Button ButtonReady;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.DateTimePicker dtReshPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        protected internal System.Windows.Forms.DateTimePicker dtStartNowPicker;
        protected internal System.Windows.Forms.DateTimePicker dtStopPicker;
    }
}