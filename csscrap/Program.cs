using System;

namespace csscrap
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.fnde.gov.br/siope/dadosInformadosMunicipio.do?acao=pesquisar&pag=result&anos=2015&periodos=1&cod_uf=31&municipios=317130&admin=3&planilhas=125&descricaoItem=Consolidado+de+Despesa&descricaodoItem=Consolidado+de+Receita&nivel=";
            WebScraper wb = new WebScraper(url);

            var s = wb.CommittedExpenses();

            ExcelOutput e = new ExcelOutput(s, "tabela", "Tabela");
            e.Save();

            //Console.ReadLine();
        }
    }
}
