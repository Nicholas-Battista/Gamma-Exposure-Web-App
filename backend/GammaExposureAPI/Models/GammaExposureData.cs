   namespace GammaExposureAPI.Models
   {
       public class GammaExposureData
       {
           public required string Symbol { get; set; }
           public DateTime Date { get; set; }
           public decimal GammaExposure { get; set; }
           public decimal Price { get; set; }
       }
   }