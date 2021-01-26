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
    public partial class NewVid : Form
    {
        public NewVid()
        {
            InitializeComponent();
        }

        private void NewVid_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klimentevDataSet.SostLic". При необходимости она может быть перемещена или удалена.
            this.sostLicTableAdapter.Fill(this.klimentevDataSet.SostLic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "klimentevDataSet.VidLic". При необходимости она может быть перемещена или удалена.
            this.vidLicTableAdapter.Fill(this.klimentevDataSet.VidLic);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numberLicBox.TextLength == 0)
            {
                MessageBox.Show("Введите номер лицензии");
                return;
            }
            if (dtEndPicker.Checked && dtStartPicker.Value > dtEndPicker.Value)
            {
                MessageBox.Show("Дата начала не может быть больше даты окончания");
                return;
            }
            if (dtReshPicker.Value > dtStartPicker.Value)
            {
                MessageBox.Show("Дата принятия решения не может быть больше даты начала деятельности");
                return;
            }
            if ((dtStartNowPicker.Checked && dtStartNowPicker.Value < dtStartPicker.Value) || 
                    (dtStopPicker.Checked && dtStopPicker.Value < dtStartPicker.Value) ||
                        (dtStartNowPicker.Checked && dtEndPicker.Checked && dtStartNowPicker.Value > dtEndPicker.Value ) ||
                            (dtStopPicker.Checked && dtEndPicker.Checked && dtStopPicker.Value > dtEndPicker.Value))
            {
                MessageBox.Show("Даты возобновления или остановки деятельности не соответсвуют действительности");
                return;
            }
            if (dtStartNowPicker.Value < dtStopPicker.Value)
            {
                MessageBox.Show("Дата возобновления не может быть раньше остановки деятельности");
                return;
            }
            if (dtStartNowPicker.Checked && !dtStopPicker.Checked)
            {
                MessageBox.Show("Дата возобновления не может быть без даты остановки");
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
