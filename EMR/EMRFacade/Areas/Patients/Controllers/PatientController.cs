using EMRFacade.Areas.Patients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMRFacade.Areas.Patients.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patients/Patient
        public ActionResult Index()
        {
            List<PatientViewModel> patientList = new PatientModel().Get();
            return View(patientList);
        }
    }
}