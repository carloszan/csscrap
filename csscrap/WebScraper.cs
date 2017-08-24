using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csscrap
{
    
    class WebScraper
    {
        private HtmlAgilityPack.HtmlWeb web;
        private HtmlAgilityPack.HtmlDocument doc;

        public WebScraper(string url)
        {
            this.web = new HtmlAgilityPack.HtmlWeb();
            this.web.OverrideEncoding = Encoding.UTF7; // doesnt work with utf8, idk y
            this.doc = this.web.Load(url);
        }

        private List<string> ItensRow()
        {
            // List<HtmlAgilityPack.HtmlNode>
            //("//div[contains(@class, 'item__price')]")
            //return this.doc.DocumentNode.SelectNodes("//table").ToList();

            List<string> itensList = new List<string>();

            foreach (var table in doc.DocumentNode.SelectNodes("//table//tr//td"))
            {
                itensList.Add(table.InnerText);
            }
            return itensList;
        }

        public List<List<string>> ItensList()
        {
            List<List<string>> tableList = new List<List<string>>();
            List<string> aux = new List<string>();
            var arrayRow = ItensRow().ToArray();

            int j = 0;
            for (int i = 9; i < arrayRow.Length; i++)
            {
                if(j <= 7)
                {
                    if (j == 7)
                    {
                        //deep copy. could code a Clone Method but this works
                        List<string> copy = new List<string>(aux);
                        tableList.Add(copy);
                        aux.Clear();
                        j = 0;
                    }
                    aux.Add(arrayRow[i]);
                    j++;
                    
                }
            }

            return tableList;
        }

        public List<List<string>> CommittedExpenses()
        {
            List<List<string>> tableList = new List<List<string>>();
            var arrayRow = ItensRow().ToArray();

            int j = 0; int i;
            for (i = 9; i < arrayRow.Length - 12; i++)
            {
                if (j <= 7)
                {
                    if (j == 4)
                    {
                        //deep copy. could code a Clone Method but this works
                        List<string> copy = new List<string>();
                        copy.Add(arrayRow[i]);
                        tableList.Add(copy);
                    }
                    if (j == 7)
                        j = 0;
                    j++;
                }
            }

            i++; i++;
            List<string> copyD = new List<string>();
            copyD.Add(arrayRow[i]);
            tableList.Add(copyD);
            for (int k = 0; k < 6; k++)
                i++;
            List<string> copyF = new List<string>();
            copyF.Add(arrayRow[i]);
            tableList.Add(copyF);

            return tableList;
        }
    }
}