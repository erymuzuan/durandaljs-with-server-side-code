
Those of you that do everything on the client side when using SPA framework are often writing a more complex code in order to cater for something such as authorization, and security related code. Writing these code on the client is often very tedious and error prone, not to mention that once everything gets in the browser , someone could always find a way to beat you.

It's the best to control access on the server, but what if your views and view models are all .js files and .html files in ~/App/Views and ~/App/ViewModels directory, there's going to be a lot of <location> tag in your web.config

The best way is always to do in using ASP.Net MVC controller and action and spit out these js and html accordingly and being able to use C# and Razor on the server.

DuandalJs config is set to look for views and viewmodels in the default location in ~/App/Views/m.html and the view model in ~/App/ViewModels/<m>.js, and if the server find a disk file there, it will fetch it, but what is it's not there. Well then the default router will try to find a controller with name AppController , and ViewModels action in it, your m.js will become the id parameter. So you could write this controller and the action for Views, ViewModels, config and what ever that's directly under the ~/App folder.


[sourcecode language="csharp"]

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

[/sourcecode]

see http://erymuzuan.wordpress.com/2013/06/24/durandaljs-with-server-side-code