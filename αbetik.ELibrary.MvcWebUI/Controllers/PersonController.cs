using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using αbetik.ELibrary.Business.Abstract;

namespace αbetik.ELibrary.MvcWebUI.Controllers
{
    public class PersonController : Controller
    {
        private IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        public ActionResult Index()
        {
            var model = new PersonListViewModel
            {
                People = _personService.GetPeople()
            };
            return View(model);
        }
    }
}