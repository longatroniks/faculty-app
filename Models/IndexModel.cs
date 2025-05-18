using Newtonsoft.Json;

namespace LonginKP3.Models
{
    /// <summary>
    /// Accesses external resources and makes 
    /// them available for the controller (view).
    /// </summary>
    public class IndexModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string quote { get; set; }
        public string quoteAuthor { get; set; }

        public static async Task<IndexModel> GetAsync()
        {
            var data = await new HttpClient().GetStringAsync("http://ist.rit.edu/api/about");
            var response = JsonConvert.DeserializeObject<IndexModel>(data);
            return response ??= new IndexModel();
        }
    }

}
