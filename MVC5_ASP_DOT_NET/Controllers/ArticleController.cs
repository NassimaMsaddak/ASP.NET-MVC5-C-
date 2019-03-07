using MVC5_ASP_DOT_NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_ASP_DOT_NET.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article 
        [Route("Lire/{id}/{title}")]
        public ActionResult Lire(int id ,string title )
        {
            //var title = Request.Params["title"];
            /* ViewBag.ArticleID = id;
           if (!string.IsNullOrEmpty(title)) {
                ViewBag.ArticleTitle = title.Replace('-',' ');
           } */


            var model = new LireModel();
            model.ID = id;
            model.Title = title;
            return View(model);
        }

        //[Route("All"),Route("Tous")]
        //ou bien
        [Route("{Type:regex(All|Tous)}")]
        public ActionResult AllArticles()
        {
            return View();
        }
    }
}