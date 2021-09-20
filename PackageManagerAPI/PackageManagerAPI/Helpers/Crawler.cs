using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PackageManagerAPI.Helpers
{
    public class Crawler
    {
        public Crawler()
        {
            ContentLoad();
        }

        private async void ContentLoad()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://www.arukereso.hu/mobiltelefon-c3277/f:samsung,erintokepernyo/");
            var pageContents = await response.Content.ReadAsStringAsync();
            HtmlDocument pageDocument = new HtmlDocument();
            pageDocument.LoadHtml(pageContents);

            var ProductsNode = pageDocument.DocumentNode.Descendants(0).Where(n => n.HasClass("name"));


        }
    }
}
