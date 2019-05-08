using System;
using System.Collections.Generic;
using System.Text;

namespace YY_Navigation
{
    public class WebsiteInfos
    {
        public static List<Website> Websites { get; private set; }
        public static void Init()
        {
            Websites = new List<Website>
            {
                new Website(@"https://www.moonhe.com/", "Moonhe", "d3d3Lm1vb25oZS5jb20.png"),
                new Website(@"https://nobugs.dev/", "Fuma's gadget", "bm9idWdzLmRldg.jpg"),
                new Website(@"https://iamsmally.github.io/", "SmallY's Home", "yy.jpg"),
                new Website(@"https://mizunashi.me/", "Mizunashi's Blog", "mizunashi.png"),
                new Website(@"https://www.gofun4.top/", "番茄瓜皮自嗨的地方", "fun4wut.gif")
            };
        }


        public class Website
        {
            public Website(string uri, string name, string imageUri)
            {
                Uri = uri;
                Name = name;
                ImageUri = imageUri;
            }
            public Website(){}
            public string Uri { get; set; }
            public string Name { get; set; }
            public string ImageUri { get; set; }
        }

    }
}
