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

namespace TicketController
{
    public partial class frmMenu : Form
    {
        frmChamados frm;
        public frmMenu()
        {
            InitializeComponent();

            frm = new frmChamados(this);
        }

        public bool x;

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult b = MessageBox.Show("Tem certeza que deseja sair?", "Call Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (b == DialogResult.Yes)
                {
                    x = true;
                    string teste = "TicketController";
                    var processes = Process.GetProcessesByName(teste);
                    foreach (var p in processes)
                    {
                        p.Kill();
                    }

                    //Application.Exit();//pra fechar a aplicação
                }

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro, está tudo corretamente preenchido?", "Call Control - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio();
            frm.Show();
            //Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }
    

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Apocryphoon");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
