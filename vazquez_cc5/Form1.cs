using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vazquez_cc5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vazquezMedicalDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vazquezMedicalDataSet.patientInfo' table. You can move, or remove it, as needed.
            this.patientInfoTableAdapter.Fill(this.vazquezMedicalDataSet.patientInfo);

        }

        private void weightAButton_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByweight(this.vazquezMedicalDataSet.patientInfo);
        }

        private void heightDButton_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByheight(this.vazquezMedicalDataSet.patientInfo);
        }

        private void a1cButton_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillBya1cvalue(this.vazquezMedicalDataSet.patientInfo);
        }

        private void ageButton_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByage(this.vazquezMedicalDataSet.patientInfo);
        }

        private void weightBButton_Click(object sender, EventArgs e)
        {
            this.patientInfoTableAdapter.FillByweightunder100(this.vazquezMedicalDataSet.patientInfo);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
