using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BookWebApi23112022.Util
{
    public class MlaFormatter
    {
        public static string Author(string firstname, string lastname)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<span style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: yellow; font-weight: 600;\">");
            sb.Append($"{firstname},{lastname}");
            sb.Append("</span>");
            return sb.ToString();


        }
        public static string TitleOfSource(string titlesource)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<span style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: #AAEBFA;font-weight: 600;\">");
            sb.Append($"{titlesource}:");
            sb.Append("</span>");
            return sb.ToString();
        }
        public static string TitleOfContainer(string titlecontainer)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<span style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: #FFA47D; font-style:italic;font-weight: 600;\">");
            sb.Append($"{titlecontainer}");
            sb.Append("</span>");
            return sb.ToString();
        }
        public static string PublisherDate(string publisherdate)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<span style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: #FFc3DC; font-weight: 600;\">");
            sb.Append($"{publisherdate}");
            sb.Append("</span>");
            return sb.ToString();
        }
        public static string Publisher(string publisher)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<span style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: #B4f596; font-weight: 600;\">");
            sb.Append($"{publisher}");
            sb.Append("</span>");
            return sb.ToString();
        }
        public static string PageNumbers(string pageNumbers)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<span style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: #A0C8ff; font-weight: 600;\">");
            sb.Append($"{pageNumbers}");
            sb.Append("</span>");
            return sb.ToString();
        }
        public static string Price(string price)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<span style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: #A0C8ff; font-weight: 600;\">");
            sb.Append($"{price}");
            sb.Append("</span>");
            return sb.ToString();
        }

        public static string Chicagostyle(string JournalTitle, string VolumeNo  , string IssueNo, string PageRange , string URL_DOI)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<p style=\"font-family: \'Courier New\', Courier, monospace; border-radius: 10px; padding: 10px; background-color: yellow; font-weight: 600;\">");
            sb.Append($"{JournalTitle} {VolumeNo} {IssueNo} {PageRange} {URL_DOI}");
            sb.Append("</p>");
            return sb.ToString();


        }

    }
}
