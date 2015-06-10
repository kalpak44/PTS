using System.Linq;
using System.Web.Mvc;
using MvcApplication1.Models; 

namespace MvcApplication1.Controllers

{
    public class StudentController : Controller
    {
        //
        // GET: /Students/All/

        public ActionResult Index()

        {

            var entities = new StudentDBEntities ();
            return View(entities.StudentSet.ToList());
        } 
    }
}
