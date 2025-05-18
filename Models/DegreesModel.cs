using Newtonsoft.Json;

namespace LonginKP3.Models
{
    /// <summary>
    /// Accesses external resources and makes 
    /// them available for the controller (view).
    /// </summary>
    public class DegreesModel
    {
        public Undergraduate[] undergraduate { get; set; }
        public Graduate[] graduate { get; set; }

        /// <summary>
        /// Accesses the online API and returns the 
        /// response body as a string in an async 
        /// operation. The data is then converted 
        /// from a JSON object into a .NET object, 
        /// and returned in case it is not null. 
        /// In case it is null, an empty DegreesModel() 
        /// is created and returned.
        /// </summary>
        /// <returns>
        /// response or DegreesModel()
        /// </returns>
        /// 

        public  static async Task<DegreesModel> GetAsync() 
        {
            var data = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/degrees");
            var response = JsonConvert.DeserializeObject<DegreesModel>(data);
            return response ??= new DegreesModel();
        }
    }

}
