using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
namespace WebApi.Controllers
{
    [RoutePrefix("api/patient")]
    public class PatientController : ApiController
    {
        [Route("getAll")]
        public IHttpActionResult GetAll() 
        {
            return Ok(PatientBLL.GetAll());
        }
 
        [Route("add")]
        [HttpPost]
        public IHttpActionResult Add(PatientEntities patientEntities, HttpPostedFileBase image)
        {
            //trial to appload image
            //if (ModelState.IsValid)
            //{
            //    if (image != null && image.ContentLength > 0)
            //    {
            //        var imageBytes = new byte[image.ContentLength];
            //        using (var inputStream = image.InputStream)
            //        {
            //            inputStream.Read(imageBytes, 0, image.ContentLength);
            //        }
            //        patientEntities.Image = imageBytes;
            //    }
            //}

            return Ok(PatientBLL.Add(patientEntities));
        }
    }
}
