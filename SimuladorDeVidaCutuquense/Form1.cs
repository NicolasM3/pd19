using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimuladorDeVidaCutuquense
{
    public partial class frmCotuca : Form
    {

        private void l_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int moedas = 0, vezesClickAngelo = 1, vezesClickGuerra = 1, vezesClickSeije = 1, vezesClickArruda = 1,
            vezesClickGo = 1, vezesClickEnzo = 1, vezesClickVeteranos = 1, ganhoEstudar = 1, ganhoJogar = 2,
            ganhoMatar = 5, ganhoGadiar = 10, ganhoAssistir = 50, ganhoChifre = 300, ganhoInstalar = 2000;

        public frmCotuca()
        {
            InitializeComponent();
        }

        // -----------------------------Backgrounds----------------------------------

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = (int)e.Argument;
            total = 1;
            pbEstudar.Value = 0;
            for (int i = 0; i < 10; i++)
            {
                bkwEstudar.ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = total;        
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            pbEstudar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbEstudar.Value = 0;
            AtualizarMoedas(ganhoEstudar);
        }


        private void bkwJogar_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = (int)e.Argument;
            total = 1;
            pbJogar.Value = 0;
            for (int i = 0; i < 15; i++)
            {
                bkwJogar.ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = total;
        }

        private void bkwJogar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbJogar.Value = e.ProgressPercentage;
        }

        private void bkwJogar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbJogar.Value = 0;
            AtualizarMoedas(ganhoJogar);
        }


        private void bkwMatar_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = (int)e.Argument;
            total = 1;
            pbMatar.Value = 0;
            for (int i = 0; i < 20; i++)
            {
                bkwMatar .ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = total;
        }

        private void bkwMatar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbMatar.Value = e.ProgressPercentage;
        }

        private void bkwMatar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbMatar.Value = 0;
            AtualizarMoedas(ganhoMatar);
        }


        private void bkwGadiar_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = (int)e.Argument;
            total = 1;
            pbGadiar.Value = 0;
            for (int i = 0; i < 35; i++)
            {
                bkwGadiar.ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = total;
        }

        private void bkwGadiar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbGadiar.Value = e.ProgressPercentage;
        }

        private void bkwGadiar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbGadiar.Value = 0;
            AtualizarMoedas(ganhoGadiar);
        }


        private void bkwAssistir_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = (int)e.Argument;
            total = 1;
            pbAssistir.Value = 0;
            for (int i = 0; i < 45; i++)
            {
                bkwAssistir.ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = total;
        }

        private void bkwAssistir_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbAssistir.Value = e.ProgressPercentage;
        }

        private void bkwAssistir_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbAssistir.Value = 0;
            AtualizarMoedas(ganhoAssistir);
        }


        private void bkwChifre_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = (int)e.Argument;
            total = 1;
            pbChifre.Value = 0;
            for (int i = 0; i < 60; i++)
            {
                bkwChifre.ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = total;
        }

        private void bkwChifre_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbChifre.Value = e.ProgressPercentage;
        }

        private void bkwChifre_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbChifre.Value = 0;
            AtualizarMoedas(ganhoChifre);
        }


        private void bkwInstalar_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = (int)e.Argument;
            total = 1;
            pbInstalar.Value = 0;
            for (int i = 0; i < 90; i++)
            {
                bkwInstalar.ReportProgress(i);
                Thread.Sleep(1000);
            }
            e.Result = total;
        }

        private void bkwInstalar_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbInstalar.Value = e.ProgressPercentage;
        }

        private void bkwInstalar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbInstalar.Value = 0;
            AtualizarMoedas(ganhoInstalar);
        }


        // ----------------------------Botões Cotuca-----------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            if (!bkwEstudar.IsBusy)
            {
                bkwEstudar.RunWorkerAsync(10);
            }
        }

        private void btnChifre_Click(object sender, EventArgs e)
        {
            if (!bkwChifre.IsBusy)
            {
                bkwChifre.RunWorkerAsync(10);
            }
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            if (!bkwInstalar.IsBusy)
            {
                bkwInstalar.RunWorkerAsync(10);
            }
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            if (!bkwJogar.IsBusy)
            {
                bkwJogar.RunWorkerAsync(10);
            }
        }
    
        private void btnMatar_Click(object sender, EventArgs e)
        {
            if (!bkwMatar.IsBusy)
            {
                bkwMatar.RunWorkerAsync(10);
            }
        }

        private void btnGadiar_Click(object sender, EventArgs e)
        {
            if (!bkwGadiar.IsBusy)
            {
                bkwGadiar.RunWorkerAsync(10);
            }
        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            if (!bkwGadiar.IsBusy)
            {
                bkwAssistir.RunWorkerAsync(10);
            }
        }



        // ---------------------------Botões Dompas-------------------------------------

        private void btnArruda_Click(object sender, EventArgs e)
        {
            switch (vezesClickArruda)
            {
                case 1:
                    if (moedas >= 500)
                    {
                        vezesClickArruda++;
                        pbGadiar.Visible = true;
                        btnGadiar.Visible = true;
                        pbGadiar.Enabled = true;
                        btnGadiar.Enabled = true;

                        btnGo.Enabled = true;
                        btnGo.Visible = true;
                        lbPreco5.Visible = true;
                        AtualizarMoedas(-500);
                        lbPreco4.Text = "800 Cotucoin";
                    }
                    break;
                case 2:
                    if (moedas >= 800)
                    {
                        vezesClickArruda++;
                        ganhoJogar = 30;
                        AtualizarMoedas(-800);
                        lbPreco4.Text = "1200 Cotucoin";
                    }
                    break;
                case 3:
                    if (moedas >= 1200)
                    {
                        ganhoJogar = 50;
                        AtualizarMoedas(-1200);
                        btnArruda.Enabled = false;
                        lbPreco4.Visible = false;
                    }
                    break;
                }
            }

        private void btnGo_Click(object sender, EventArgs e)
        {
            switch (vezesClickGo)
            {
                case 1:
                    if (moedas >= 1000)
                    {
                        vezesClickGo++;
                        pbAssistir.Visible = true;
                        btnAssistir.Visible = true;
                        pbAssistir.Enabled = true;
                        btnAssistir.Enabled = true;

                        btnEnzo.Enabled = true;
                        btnEnzo.Visible = true;
                        lbPreco6.Visible = true;
                        AtualizarMoedas(-1000);
                        lbPreco5.Text = "1300 Cotucoin";
                    }
                    break;
                case 2:
                    if (moedas >= 1350)
                    {
                        vezesClickGo++;
                        ganhoJogar = 80;
                        AtualizarMoedas(-1350);
                        lbPreco5.Text = "2000 Cotucoin";
                    }
                    break;
                case 3:
                    if (moedas >= 2000)
                    {
                        ganhoJogar = 100;
                        AtualizarMoedas(-2000);
                        btnGo.Enabled = false;
                        lbPreco5.Visible = false;
                    }
                    break;
            }
        }

        private void btnEnzo_Click(object sender, EventArgs e)
        {
            switch (vezesClickEnzo)
            {
                case 1:
                    if (moedas >= 5000)
                    {
                        vezesClickEnzo++;
                        pbChifre.Visible = true;
                        btnChifre.Visible = true;
                        pbChifre.Enabled = true;
                        btnChifre.Enabled = true;

                        btnVeteranos.Enabled = true;
                        btnVeteranos.Visible = true;
                        lbPreco7.Visible = true;
                        AtualizarMoedas(-5000);
                        lbPreco6.Text = " 10000 Cotucoin";
                    }
                    break;
                case 2:
                    if (moedas >= 10000)
                    {
                        vezesClickEnzo++;
                        ganhoJogar = 500;
                        AtualizarMoedas(-10000);
                        lbPreco6.Text = "25000 Cotucoin";
                    }
                    break;
                case 3:
                    if (moedas >= 25000)
                    {
                        ganhoJogar = 1000;
                        AtualizarMoedas(-25000);
                        btnEnzo.Enabled = false;
                        lbPreco6.Visible = false;
                    }
                    break;
            }
        }

        private void btnVeteranos_Click(object sender, EventArgs e)
        {
            switch (vezesClickVeteranos)
            {
                case 1:
                    if (moedas >= 20000)
                    {
                        vezesClickVeteranos++;
                        pbInstalar.Visible = true;
                        btnInstalar.Visible = true;
                        pbInstalar.Enabled = true;
                        btnInstalar.Enabled = true;

                        btnChico.Enabled = true;
                        btnChico.Visible = true;
                        lbPreco8.Visible = true;
                        AtualizarMoedas(-20000);
                        lbPreco7.Text = " 40000 Cotucoin";
                    }
                    break;
                case 2:
                    if (moedas >= 40000)
                    {
                        vezesClickEnzo++;
                        ganhoInstalar = 5000;
                        AtualizarMoedas(-40000);
                        lbPreco7.Text = "90000 Cotucoin";
                    }
                    break;
                case 3:
                    if (moedas >= 90000)
                    {
                        ganhoJogar = 10000;
                        AtualizarMoedas(-90000);
                        btnEnzo.Enabled = false;
                        lbPreco7.Visible = false;
                    }
                    break;
            }
        }

        private void btnChico_Click(object sender, EventArgs e)
        {
            MessageBox.Show("É por essa eu não esperava.");
        }

        private void btnSeije_Click(object sender, EventArgs e)
        {
            switch (vezesClickSeije)
            {
                case 1:
                    if (moedas >= 10)
                    {
                        vezesClickSeije++;
                        btnAngelo.Enabled = true;
                        btnAngelo.Visible = true;
                        lbPreco2.Visible = true;
                        ganhoEstudar = 2;
                        AtualizarMoedas(-10);
                        lbPreco1.Text = "25 Cotucoin";
                    }
                    break;
                case 2:
                    if (moedas >= 25)
                    {
                        vezesClickSeije++;
                        ganhoEstudar = 5;
                        AtualizarMoedas(-25);
                        lbPreco1.Text = "200 Cotucoin";
                    }
                    break;
                case 3:
                    if (moedas >= 200)
                    {
                        btnSeije.Enabled = false;
                        lbPreco1.Visible = false;
                        ganhoEstudar = 12;
                        AtualizarMoedas(-200);
                    }
                    break;
            }
        }

        private void VirarAmigo1_Click(object sender, EventArgs e)
        {
            switch (vezesClickAngelo)
            {
                case 1:
                    if (moedas >= 50)
                    {
                        vezesClickAngelo++;
                        pbJogar.Visible = true;
                        btnJogar.Visible = true;
                        pbJogar.Enabled = true;
                        btnJogar.Enabled = true;

                        btnGuerra.Enabled = true;
                        btnGuerra.Visible = true;
                        lbPreco3.Visible = true;
                        AtualizarMoedas(-50);
                        lbPreco2.Text = "150 Cotucoin";
                    }
                    break;
                case 2:
                    if (moedas >= 150)
                    {
                        vezesClickAngelo++;
                        ganhoJogar = 5;
                        AtualizarMoedas(-150);
                        lbPreco2.Text = "225 Cotucoin";
                    }
                    break;
                case 3:
                    if (moedas >= 225)
                    {
                        ganhoJogar = 15;
                        AtualizarMoedas(-220);
                        btnAngelo.Enabled = false;
                        lbPreco2.Visible = false;
                    }
                    break;
            }
        }

        private void btnGuerra_Click(object sender, EventArgs e)
        {
            switch (vezesClickGuerra)
            {
                case 1:
                    if (moedas >= 100)
                    {
                        vezesClickGuerra++;
                        pbMatar.Visible = true;
                        btnMatar.Visible = true;
                        pbMatar.Enabled = true;
                        btnMatar.Enabled = true;

                        btnArruda.Enabled = true;
                        btnArruda.Visible = true;
                        lbPreco4.Visible = true;
                        AtualizarMoedas(-50);
                        lbPreco3.Text = "400 Cotucoin";
                    }
                    break;
                case 2:
                    if (moedas >= 400)
                    {
                        vezesClickGuerra++;
                        ganhoJogar = 15;
                        AtualizarMoedas(-400);
                        lbPreco3.Text = "800 Cotucoin";
                    }
                    break;
                case 3:
                    if (moedas >= 800)
                    {
                        ganhoJogar = 20;
                        AtualizarMoedas(-800);
                        btnGuerra.Enabled = false;
                        lbPreco3.Visible = false;
                    }
                    break;
            }
        }



        // -----------------------------Coisas Adicionais-------------------------------

        private void lbHack_Click(object sender, EventArgs e)
        {
            AtualizarMoedas(10000);
        }

        private void AtualizarMoedas(int valor)
        {
            moedas += valor;
            lbQuantidadeDeMoedas.Text = lbQuantidadeDeMoedas2.Text = moedas + "";
        }
    }
}
