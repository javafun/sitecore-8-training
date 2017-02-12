using events.Models;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace events.Controllers
{
    public class EventIntroController : Controller
    {
        public ActionResult Index()
        {
            return View(CreateModel());
        }

        private static EventIntro CreateModel()
        {
            var item = RenderingContext.Current.ContextItem;

            var eventIntro = new EventIntro
            {
                Heading = new System.Web.HtmlString(FieldRenderer.Render(item, "ContentHeading")),
                EventImage = new System.Web.HtmlString(FieldRenderer.Render(item, "Event Image", "mw=400")),
                Highlights = new System.Web.HtmlString(FieldRenderer.Render(item, "Highlights")),
                Intro = new System.Web.HtmlString(FieldRenderer.Render(item, "ContentIntro")),
                StartDate = new System.Web.HtmlString(FieldRenderer.Render(item, "Start Date")),
                Duration = new System.Web.HtmlString(FieldRenderer.Render(item, "Duration")),
                Difficulity = new System.Web.HtmlString(FieldRenderer.Render(item, "Difficulity"))

            };


            return eventIntro;
        }
    }
}
