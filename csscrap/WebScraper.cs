using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csscrap
{
    
    class WebScraper
    {
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
                if(j <= 5)
                {
                    if (j == 5)
                    {
                        List<string> copy = new List<string>(aux); //deep copy. could code a Clone Method but this works
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

        private HtmlAgilityPack.HtmlWeb web;
        private HtmlAgilityPack.HtmlDocument doc;
    }
}