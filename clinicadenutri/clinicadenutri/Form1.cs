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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pACIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (nomeTextBox.Text == "" || sexoComboBox.Text == "" || pesoTextBox.Text == "" ||
 alturaTextBox.Text == "" || iMCTextBox.Text == "" || condicaoTextBox.Text == "")
                MessageBox.Show("Preencha os campos obrigatórios.");
            else
            {
                this.Validate();
                this.pACIENTESBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cLINICANUTRIDataSet);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cLINICANUTRIDataSet.PACIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.pACIENTESTableAdapter.Fill(this.cLINICANUTRIDataSet.PACIENTES);

        }

        private void codigoLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2();
            tela2.Show();
        }

        private void iMCTextBox_TextChanged(object sender, EventArgs e)
        {
            if (iMCTextBox.Text != "")
                if (pesoTextBox.Text == "" || alturaTextBox.Text == "")
                    MessageBox.Show("Digite Altura e peso.");
                else
                    iMCTextBox.Text = (float.Parse(pesoTextBox.Text) /
(float.Parse(alturaTextBox.Text) * float.Parse(alturaTextBox.Text))).ToString();
        }

        private void condicaoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (condicaoTextBox.Text != "")
                if (sexoComboBox.Text == "" || iMCTextBox.Text == "")
                    MessageBox.Show("Selecione o sexo e calcule o IMC.");
                else
                if (sexoComboBox.Text == "Masculino")
                    if (float.Parse(iMCTextBox.Text) < 20)
                        condicaoTextBox.Text = "Abaixo do peso ideal";
                    else
                    if (float.Parse(iMCTextBox.Text) > 25)
                        condicaoTextBox.Text = "Acima do peso ideal";
                    else
                        condicaoTextBox.Text = "No peso ideal";
                else
                if (float.Parse(iMCTextBox.Text) < 19)
                    condicaoTextBox.Text = "Abaixo do peso ideal";
                else
                if (float.Parse(iMCTextBox.Text) > 24)
                    condicaoTextBox.Text = "Acima do peso ideal";
                else
                    condicaoTextBox.Text = "No peso ideal";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
                fotoPictureBox.ImageLocation = OFD.FileName;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
