using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csscrap
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string url = "https://www.fnde.gov.br/siope/dadosInformadosMunicipio.do?acao=pesquisar&pag=result&anos=2015&periodos=1&cod_uf=31&municipios=317130&admin=3&planilhas=125&descricaoItem=Consolidado+de+Despesa&descricaodoItem=Consolidado+de+Receita&nivel=";
        
            WebScraper wb = new WebScraper(this.txtLink.Text);


            var s = wb.CommittedExpenses();
            //s, "tabela", "Tabela"
            ExcelOutput eo = new ExcelOutput(s, this.txtFile.Text, this.txtSheet.Text);
            eo.Save();
        }
    }
}
