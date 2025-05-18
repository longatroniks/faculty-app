using Newtonsoft.Json;

namespace LonginKP3.Models
{
    /// <summary>
    /// Accesses external resources and makes 
    /// them available for the controller (view).
    /// </summary>
    public class EmploymentModel
    {

        public Cooptable coopTable { get; set; }
        public Employmenttable employmentTable { get; set; }

        /// <summary>
        /// Accesses the online API and returns the 
        /// response body as a string in an async 
        /// operation. The data is then converted 
        /// from a JSON object into a .NET object, 
        /// and returned in case it is not null. 
        /// In case it is null, an empty EmploymentModel() 
        /// is created and returned.
        /// </summary>
        /// <returns>
        /// response or EmploymentModel()
        /// </returns>
        public static async Task<EmploymentModel> GetAsync()
        {
            var data = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/employment");
            var response = JsonConvert.DeserializeObject<EmploymentModel>(data);
            return response ??= new EmploymentModel();
        }
    }

}
