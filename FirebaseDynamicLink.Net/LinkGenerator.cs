using System;

namespace FirebaseDynamicLink.Net
{
    public class LinkGenerator
    {
        public string Link { get; set; }

        public string GetDynamicLink()
        {
            Console.WriteLine("initial commit");
            return "http://localhost:8080";
        }
    }
}
