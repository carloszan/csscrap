using System;

namespace csscrap
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.fnde.gov.br/siope/dadosInformadosMunicipio.do?acao=pesquisar&pag=result&anos=2015&periodos=1&cod_uf=31&municipios=317130&admin=3&planilhas=124&descricaoItem=Consolidado+de+Receita&descricaodoItem=&nivel=";
            WebScraper wb = new WebScraper(url);

            var s = wb.ItensList();

 
            ExcelOutput e = new ExcelOutput(s);
            e.Save();

            //Console.ReadLine();
        }
    }
}
