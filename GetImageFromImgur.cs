using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetRandomImage
{
    public class GetRandomImageFromImgur
    {
        public static string GetRandomImg()
        {

            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://imgur.com/");

            string input = downloadString;
            string regexcode = @"(i.img)([\w_-]+(?:(?:\.[\w_-]+)+))([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])+.jpg";

            Regex regex = new Regex(regexcode);

            Random r = new Random();
            int rInt = r.Next(0, regex.Matches(input).Count); 

            string rndimg = regex.Matches(input)[rInt].ToString();
            client.Dispose();
            return rndimg;
        }
    }
}
