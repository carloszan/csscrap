using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csscrap
{
    public partial class frmMain : Form
    {
        BackgroundWorker bw = new BackgroundWorker();

        public frmMain()
        {
            InitializeComponent();

            bw.DoWork += BW_DoWork;
            bw.ProgressChanged += BW_ProgressChanged;
            bw.WorkerReportsProgress = true;
            bw.RunWorkerCompleted += BW_ChangeLabel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.pgBar.Value = 0;
            //this.lblCheck.Text = "Gerando";
            this.btnSave.Enabled = false;
            bw.RunWorkerAsync();
        }

        private void BW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int i;
            WebScraper wb = new WebScraper(this.txtLink.Text);
            var s = wb.CommittedExpenses();
            
            for (i = 0; i <= 50; i++)
                bw.ReportProgress(i);

            ExcelOutput eo = new ExcelOutput(s, this.txtFile.Text, this.txtSheet.Text);
            eo.Save(this.txtFile.Text);

            for (; i <= 100; i++)
                bw.ReportProgress(i);
        }

        private void BW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.pgBar.Value = e.ProgressPercentage;
        }

        private void BW_ChangeLabel(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnSave.Enabled = true;
            //his.lblCheck.Text = "Pronto";
        }

        private void RunAsync()
        {
            WebScraper wb = new WebScraper(this.txtLink.Text);

            var s = wb.CommittedExpenses();
            //s, "tabela", "Tabela"
            ExcelOutput eo = new ExcelOutput(s, this.txtFile.Text, this.txtSheet.Text);
            eo.Save();
        }
    }
}
