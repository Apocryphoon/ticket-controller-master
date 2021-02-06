using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketController.DataBase;
using TicketController.DTO;

namespace TicketController
{
    public partial class frmAddChamado : Form
    {
        frmChamados frm;
        public frmAddChamado(frmChamados fr)
        {
            InitializeComponent();
            CarregarCombo();
            frm = fr;
        }

        public bool x;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }
        public void CarregarCombo()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool visible = false;

                string idCliente = textBox1.Text;
                string obs = textBox2.Text;

                DateTime data = dateTimePicker1.Value;

                string selecionadoOne = Convert.ToString(comboBox1.SelectedItem);
                string selecionadoTwo = Convert.ToString(comboBox2.SelectedItem);
                string selecionadoTree = Convert.ToString(comboBox3.SelectedItem);

                if (selecionadoOne == "SELECIONE CLIENTE" || selecionadoTwo == "SELECIONE STATUS" || selecionadoTree == "SELECIONE RESPONSAVEL")
                {
                    MessageBox.Show("EXISTEM CAMPOS VAZIO!", "Call Control - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Bravo db = new Bravo();
                    db.Salvar(selecionadoOne, idCliente, selecionadoTree, selecionadoTwo, data, visible, obs);

                    MessageBox.Show("Cadastrado com sucesso!", "Call Control - OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro inesperado. Tente novamente mais tarde!", "Call Control - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimparCampos()
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Apocryphoon");
        }

        private void frmAddChamado_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                if (x == true)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Cancele a entrada da maneira correta!", "Call Control - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro!", "Call Control - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
