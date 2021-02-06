using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketController.DataBase;
using TicketController.DTO;

namespace TicketController
{
    public partial class frmEditChamado : Form
    {
        frmChamados frm;

        public frmEditChamado(frmChamados fr)
        {
            InitializeComponent();
            frm = fr;
        }

        int id;
        TableDTO dto;
        public bool x;

        public void Carregar(TableDTO dto)
        {
            this.dto = dto;

            id = dto.id;
            comboBox1.Text = dto.nm_cliente;
            textBox1.Text = dto.id_cliente;
            textBox2.Text = dto.ds_obs;
            comboBox2.Text = dto.ds_status;
            comboBox3.Text = dto.nm_responsavel;
            dateTimePicker1.Value = dto.dt_create;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void frmEditChamado_Load(object sender, EventArgs e)
        {

        }

        private void frmEditChamado_FormClosing(object sender, FormClosingEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Apocryphoon");
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
                    db.Editar(selecionadoOne, idCliente, selecionadoTree, selecionadoTwo, data, visible, id, obs);

                    MessageBox.Show("Alterado com sucesso!", "Call Control - OK", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Hide();
                    frm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro inesperado. Tente novamente mais tarde!", "Call Control - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
