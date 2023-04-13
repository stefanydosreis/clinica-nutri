using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicadenutri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cONSULTAPACIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONSULTAPACIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cLINICANUTRIDataSet);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cONSULTAPACIENTETableAdapter.Fill(this.cLINICANUTRIDataSet.CONSULTAPACIENTE, "%"+dADOToolStripTextBox.Text +"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
