using Microsoft.AspNetCore.Mvc;
   using GammaExposureAPI.Models;
   using System;
   using System.Collections.Generic;

   namespace GammaExposureAPI.Controllers
   {
       [ApiController]
       [Route("api/[controller]")]
       public class GammaExposureController : ControllerBase
       {
           [HttpGet]
           public ActionResult<IEnumerable<GammaExposureData>> Get()
           {
               var data = new List<GammaExposureData>
               {
                   new GammaExposureData { Symbol = "SPX", Date = DateTime.Now, GammaExposure = 1.5m, Price = 4000m },
                   new GammaExposureData { Symbol = "AAPL", Date = DateTime.Now, GammaExposure = 0.8m, Price = 150m },
                   new GammaExposureData { Symbol = "GOOGL", Date = DateTime.Now, GammaExposure = 1.2m, Price = 2800m }
               };

               return Ok(data);
           }
       }
   }