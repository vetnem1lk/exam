using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EGRUL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool DataChanged;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klimentevDataSet.Licenz". При необходимости она может быть перемещена или удалена.
            this.licenzTableAdapter.Fill(this.klimentevDataSet.Licenz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klimentevDataSet.Licenz". При необходимости она может быть перемещена или удалена.
            this.licenzTableAdapter.Fill(this.klimentevDataSet.Licenz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klimentevDataSet.UL". При необходимости она может быть перемещена или удалена.
            this.uLTableAdapter.Fill(this.klimentevDataSet.UL);
            this.vidLicTableAdapter1.Fill(this.klimentevDataSet.VidLic);
            FillData();
            DataChanged = false;
        }

        private void FillData()
        {
            if (!dataFilter.Checked)
                fKLicenzULBindingSource.Filter = "";
            else
            {
                string curDate = dataFilter.Value.ToShortDateString();
                fKLicenzULBindingSource.Filter = "(DtStart <= '" + curDate + "') AND (DtEnd IS NULL OR DtEnd > = '" + curDate + "')";
            }
            for (int i = 0; i < dataGridView2.RowCount; i++) 
                dataGridView2["NameVid", i].Value = 
                    klimentevDataSet.VidLic.FindByIdVidLic((int)dataGridView2["VidLicDataGridViewTextBoxColumn",
                                                                                   i].Value).vlName;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            dataGridView2.EndEdit();
            fKLicenzULBindingSource.EndEdit();
            try
            {
                licenzTableAdapter.Update(klimentevDataSet.Licenz);
                klimentevDataSet.Licenz.AcceptChanges();
                FillData();
                DataChanged = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи в базу  данных\n" + ex.Message);
            } 
        } 

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void addRows_Click(object sender, EventArgs e)
        {
            NewVid newVid = new NewVid();
           
            if (newVid.ShowDialog() != DialogResult.OK)
                return;
            
            KlimentevDataSet.LicenzRow row = (KlimentevDataSet.LicenzRow)klimentevDataSet.Licenz.NewRow();
            
            row.idUl = (int)dataGridView1["idUlDataGridViewTextBoxColumn", dataGridView1.CurrentRow.Index].Value;
            row.DtStart = DateTime.Parse(newVid.dtStartPicker.Value.ToShortDateString());
            
            if (newVid.dtEndPicker.Checked)
                row.DtEnd = DateTime.Parse(newVid.dtStartPicker.Value.ToShortDateString());
            
            row.MainLic = (newVid.mainCheckBox.Checked);
            row.VidLic = (int)newVid.dataGridView1["idVidLicDataGridViewTextBoxColumn",
                                          newVid.dataGridView1.CurrentRow.Index].Value;
            
            row.NumLic = Convert.ToString(newVid.numberLicBox.Text);
            row.DtResh = DateTime.Parse(newVid.dtReshPicker.Value.ToShortDateString());
            row.LicOrg = row.VidLic;
            
            if (!newVid.dtEndPicker.Checked)
                row.SostLic = 1;
            else
                row.SostLic = 2;
            if (newVid.dtStopPicker.Checked)
            {
                row.DtStop = DateTime.Parse(newVid.dtStopPicker.Value.ToShortDateString());
                row.SostLic = 3;
                if (newVid.dtStartNowPicker.Checked)
                {
                    row.DtStartNow = DateTime.Parse(newVid.dtStartNowPicker.Value.ToShortDateString());
                    row.SostLic = 1;
                }
            }

            klimentevDataSet.Licenz.Rows.Add(row);
            dataGridView2["NameVid", dataGridView2.RowCount - 1].Value =
                newVid.dataGridView1["vlNameDataGridViewTextBoxColumn",
                                      newVid.dataGridView1.CurrentRow.Index].Value;
            
            fKLicenzULBindingSource.Position = fKLicenzULBindingSource.Count - 1;
            
            DataChanged = true;

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
                return;
            
            int ind = dataGridView2.CurrentRow.Index;
            
            EditLicenz editLicenz = new EditLicenz();
            
            editLicenz.dtStartPicker.Value = (DateTime)dataGridView2["DtStartDataGridViewTextBoxColumn", ind].Value;

            if (dataGridView2["dtEndDataGridViewTextBoxColumn", ind].Value != DBNull.Value)
            {
                editLicenz.dtEndPicker.Checked = true;
                editLicenz.dtEndPicker.Value = (DateTime)dataGridView2["DtEndDataGridViewTextBoxColumn", ind].Value;
            }
            else
                editLicenz.dtEndPicker.Checked = false;

            if (dataGridView2["dtStopDataGridViewTextBoxColumn", ind].Value != DBNull.Value)
            {
                editLicenz.dtStopPicker.Checked = true;
                editLicenz.dtStopPicker.Value = (DateTime)dataGridView2["DtStopDataGridViewTextBoxColumn", ind].Value;
            }
            else
                editLicenz.dtStopPicker.Checked = false;

            if (dataGridView2["dtStartNowDataGridViewTextBoxColumn", ind].Value != DBNull.Value)
            {
                editLicenz.dtStartNowPicker.Checked = true;
                editLicenz.dtStartNowPicker.Value = (DateTime)dataGridView2["DtStartNowDataGridViewTextBoxColumn", ind].Value;
            }
            else
                editLicenz.dtStartNowPicker.Checked = false;

            editLicenz.mainCheckBox.Checked = (bool)dataGridView2["Main", ind].Value;
            editLicenz.kodVid = (int)dataGridView2["vidLicDataGridViewTextBoxColumn", ind].Value;
            editLicenz.numberLicBox.Text = (string)dataGridView2["numLicDataGridViewTextBoxColumn", ind].Value;
            editLicenz.dtReshPicker.Value = (DateTime)dataGridView2["dtReshDataGridViewTextBoxColumn", ind].Value;

            if (editLicenz.ShowDialog() != DialogResult.OK)
                return;
            
            dataGridView2["DtStartDataGridViewTextBoxColumn", ind].Value = editLicenz.dtStartPicker.Value;
            
            if (editLicenz.dtEndPicker.Checked)
            { 
                dataGridView2["DtEndDataGridViewTextBoxColumn", ind].Value = editLicenz.dtEndPicker.Value;
                dataGridView2["sostLicDataGridViewTextBoxColumn", ind].Value = 2;
            }
            else
            {
                dataGridView2["DtEndDataGridViewTextBoxColumn", ind].Value = DBNull.Value;
                dataGridView2["sostLicDataGridViewTextBoxColumn", ind].Value = 1;
            }

            if (editLicenz.dtStopPicker.Checked)
            {
                dataGridView2["DtStopDataGridViewTextBoxColumn", ind].Value = editLicenz.dtStopPicker.Value;
                dataGridView2["sostLicDataGridViewTextBoxColumn", ind].Value = 3;
            }
            else
            {
                dataGridView2["DtStopDataGridViewTextBoxColumn", ind].Value = DBNull.Value;
            }
            if (editLicenz.dtStartNowPicker.Checked)
            {
                dataGridView2["DtStartNowDataGridViewTextBoxColumn", ind].Value = editLicenz.dtStartNowPicker.Value;
                dataGridView2["sostLicDataGridViewTextBoxColumn", ind].Value = 1;
            }
            else
            {
                dataGridView2["DtStartNowDataGridViewTextBoxColumn", ind].Value = DBNull.Value;
            }

            dataGridView2["Main", ind].Value = editLicenz.mainCheckBox.Checked;
            dataGridView2["vidLicDataGridViewTextBoxColumn", ind].Value = editLicenz.comboBoxVidLic.SelectedValue;
            dataGridView2["NameVid", ind].Value = editLicenz.Vidname;
            dataGridView2["licOrgDataGridViewTextBoxColumn", ind].Value = editLicenz.comboBoxVidLic.SelectedValue;
            dataGridView2["dtReshDataGridViewTextBoxColumn", ind].Value = editLicenz.dtReshPicker.Value;
            
            if (editLicenz.numberLicBox.TextLength > 1)
                dataGridView2["numLicDataGridViewTextBoxColumn", ind].Value = editLicenz.numberLicBox.Text;
            DataChanged = true;
        }

        private void deleteRows_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
                return;
            
            int id = (int)dataGridView2["idLicDataGridViewTextBoxColumn", dataGridView2.CurrentRow.Index].Value;
            
            klimentevDataSet.Licenz.FindByIdLic(id).Delete();
            
            DataChanged = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DataChanged)
                return;
            
            DialogResult dr =
                MessageBox.Show("Сохранить данные?","Вы не сохранили данные", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.No)
                return;
            if (dr == DialogResult.Cancel)
                e.Cancel = true;
        
            toolStripButtonSave.PerformClick();
        }


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
