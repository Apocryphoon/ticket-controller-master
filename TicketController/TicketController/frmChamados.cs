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
    public partial class frmChamados : Form
    {
        frmMenu frmo;
        frmAddChamado frm;
        frmEditChamado frmEdit;

        public frmChamados(frmMenu fr)
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            CarregarTela();

            frmo = fr;
            frm = new frmAddChamado(this);
            frmEdit = new frmEditChamado(this);

        }

        public bool x;
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmo.Show();
        }

        private void frmChamados_FormClosing(object sender, FormClosingEventArgs e)
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
        private void frmChamados_VisibleChanged(object sender, EventArgs e)
        {
            //Sempre que mudar de tela é atualizado a grid
            CarregarTela();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Apocryphoon");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string responsavel = textBox2.Text;
            string cliente = Convert.ToString(comboBox1.SelectedItem);

            Bravo b = new Bravo();
            List<TableDTO> retorno = b.Filtro(id, responsavel, cliente);

            dataGridView1.DataSource = retorno;
        }

        public void CarregarTela()
        {
            Bravo db = new Bravo();
            List<TableDTO> retorno = db.listarAll();

            dataGridView1.DataSource = retorno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idChamado = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());

            if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["COPIAR"])
            {
                MessageBox.Show("Copiado:" + idChamado);
            }
            if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["EXCLUIR"])
            {
                try
                {
                    TableDTO dto = dataGridView1.Rows[e.RowIndex].DataBoundItem as TableDTO;

                    Bravo db = new Bravo();
                    dto.ds_visible = true;
                    db.selectRemoved(dto);

                    MessageBox.Show("Chamado removido com sucesso!", "Call Control", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarTela();
                }
                catch
                {
                    MessageBox.Show("Algo deu errado, tente novamene mais tarde!", "Call Control - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex] == dataGridView1.Columns["EDITAR"])
            {
                TableDTO dto = dataGridView1.Rows[e.RowIndex].DataBoundItem as TableDTO;

                frmEdit.Carregar(dto);
                frmEdit.Show();
                this.Hide();
            }
        }

        private void frmChamados_Shown(object sender, EventArgs e)
        {
        }

        private void frmChamados_MaximumSizeChanged(object sender, EventArgs e)
        {
        }
        private void frmChamados_Load(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

    }
}
