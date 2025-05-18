using Newtonsoft.Json;

namespace LonginKP3.Models
{
    public class FacultyModel
    {
        public string username { get; set; }
        public string name { get; set; }
        public string tagline { get; set; }
        public string imagePath { get; set; }
        public string title { get; set; }
        public string interestArea { get; set; }
        public string office { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string twitter { get; set; }
        public string facebook { get; set; }

        /// <summary>
        /// Accesses the online API and returns the 
        /// response body as a string in an async 
        /// operation. The data is then converted 
        /// from a JSON object into a .NET object, 
        /// and returned in case it is not null. 
        /// In case it is null, an empty FacultyViewModel() 
        /// is created and returned.
        /// </summary>
        /// <returns>
        /// response or new FacultyViewModel()
        /// </returns>
        /// 
        public static async Task<FacultyViewModel> GetAsync() {

            string json = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/people/faculty");
            var response = JsonConvert.DeserializeObject<FacultyViewModel>(json);
            return response ??= new FacultyViewModel();
        }
    }

}
