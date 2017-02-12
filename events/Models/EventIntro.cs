using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace events.Models
{
    public class EventIntro
    {
        public EventIntro()
        {

        }

        public HtmlString Heading { get; set; }
        public HtmlString Intro { get; set; }
        public HtmlString Body { get; set; }
        public HtmlString EventImage { get; set; }
        public HtmlString Highlights { get; set; }
        public HtmlString StartDate { get; set; }
        public HtmlString Duration { get; set; }
        public HtmlString Difficulity { get; set; }
    }
}
