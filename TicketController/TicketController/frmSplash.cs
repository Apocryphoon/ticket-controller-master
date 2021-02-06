using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketController.ENTREMEIOS.GLOBAL;
using System.Runtime.InteropServices;

namespace TicketController
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            ProgressBarColor.SetState(progressBar1, 2);

            // Configurações para se tornar Splash Screen
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            // Coloca a Imagem que será a Splash Screen
            //BackgroundImage = Properties.Resources.LogoSplash;



            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    System.Threading.Thread.Sleep(23);
                    Invoke(new Action(() => progressBar1.Increment(1)));
                }
            });


            // Inicia contagem para término da Splash Screen
            Task.Factory.StartNew(() =>
            {

                // Espera 2 segundos para iniciar o sistema
                System.Threading.Thread.Sleep(2700);

                Invoke(new Action(() =>
                {
                    // Abre a tela Inicial
                    frmMenu frm = new frmMenu();
                    frm.Show();
                    Hide();
                }));
            });

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
