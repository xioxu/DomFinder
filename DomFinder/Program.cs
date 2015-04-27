using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using ArtOfTest.WebAii.Controls.HtmlControls;
using DomFinderLibrary;

namespace DomFinderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var href = "http://quote.eastmoney.com/sz000599.html";

            WebClient client = new WebClient();

            var htmlContent = client.DownloadString(href);

          //  var table = new DomFinder(htmlContent).Find.ByExpression<HtmlTable>("id=wahaha", "|", "tagIndex=table:0");

            var table = new DomFinder(htmlContent).Find.ByExpression<HtmlTable>("id=rtp2");

            if (table != null)
            {
                foreach (var row in table.BodyRows)
                {
                    foreach (var cell in row.Cells)
                    {
                        Console.Write(cell.InnerText + "   ");
                    }
                }

                Console.WriteLine("\r\n-------------------------------");
            }

            Console.WriteLine("Done");
            Console.Read();
        }
    }
}
