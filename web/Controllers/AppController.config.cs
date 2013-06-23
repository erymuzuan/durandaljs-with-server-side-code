using System.Web.Mvc;

namespace Bespoke.Station.Web.Controllers
{
    public partial class AppController
    {

        public ActionResult ConfigJs()
        {
            return View();
        }

        [ActionName("config.js")]
        public ActionResult Config(string id)
        {
            this.Response.ContentType = APPLICATION_JAVASCRIPT;
            var script = this.RenderScript("ConfigJs");
            return Content(script);
        }


    }
}
