using HtmlAgilityPack;
using PackageManagerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PackageManagerAPI.Helpers
{
    public class Crawler
    {
        public List<Product> Products = new List<Product>();
        public Crawler()
        {
            
        }

        public async Task ContentLoad()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://www.arukereso.hu/mobiltelefon-c3277/f:samsung,erintokepernyo/");
            var pageContents = await response.Content.ReadAsStringAsync();
            
            HtmlDocument pageDocument = new HtmlDocument();
          
            pageDocument.LoadHtml(pageContents);

            double productNumber = 0;
            string productNumNode = pageDocument.DocumentNode.Descendants(0)
                .Where(n => n.HasClass("product-num")).First().InnerText;

            double.TryParse(productNumNode.Replace("(", "")
            .Replace(")", "")
            .Replace("termék", "")
            .Replace(" ", ""), out productNumber);

            double pageCnt = Math.Ceiling(productNumber / 25); // products / page

            // First 25 products
            IEnumerable<HtmlNode> nodeElements = pageDocument.DocumentNode.Descendants(0)
                .Where(n => n.HasClass("product-box-container"));
           
           AppendProduct(nodeElements);

            // from 25 to last product
            for (int i = 1; i < (int)pageCnt; i++)
            {
                response = await client.GetAsync($"https://www.arukereso.hu/mobiltelefon-c3277/f:samsung,erintokepernyo/?start={i * 25}");
                pageContents = await response.Content.ReadAsStringAsync();
                pageDocument.LoadHtml(pageContents);

                nodeElements = pageDocument.DocumentNode.Descendants(0)
                .Where(n => n.HasClass("product-box-container"));
                
                AppendProduct(nodeElements);

            }
        }

        private async void AppendProduct(IEnumerable<HtmlNode> elements)
        {

            foreach (var node in elements)
            {
                String productName = node.Descendants(0)
                    .Where(n => n.HasClass("name"))
                    .First()
                    .InnerText
                    .Replace("\n", "")
                    .Replace("  ", "");

                float price = 0;
                
                float.TryParse(node.Descendants(0)
                    .Where(n => n.HasClass("price"))
                    .First()
                    .InnerText
                    .Replace(" ", "")
                    .Replace("Ft", "")
                    .Replace("-tól", ""), out price);

                Product product = new Product
                {
                    ProductId = this.Products.Count + 1,
                    ProductName = productName,
                    ProductPrice = price
                };

                Products.Add(product);
            }
        }
    }
}
