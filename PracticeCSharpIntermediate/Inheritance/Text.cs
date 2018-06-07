using System;

namespace Inheritance
{
    class Text: PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a hyperlink to {0}", url);
        }
    }
}