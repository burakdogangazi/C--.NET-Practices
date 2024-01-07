using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIntroduction.Controllers
{
    [Route("admin")] // admin gelirse urle bura çalışşsın istedik
    public class AdminController : Controller
    {
        //admin yazınca url default olan boş çalışır 

        [Route("")] // default route
        [Route("save")]
        [Route("~/save")] // önündeki her şeyi umursamaaz save diyince de bu çalışır.
        public string Save()
        {
            return "saved";
        }
        [Route("delete/{id?}")]
        public string Delete(int id= 0)
        {
            return String.Format("Deleted {0}", id);
        }
        [Route("update")]
        public string Update()
        {
            return "updated";
        }

        //Sadece /admin yazınca default olan save çalışır
        //admin/save der isek yine save çalışır
        //admin/delete/2 der isek deleted 2 der

    }
}
