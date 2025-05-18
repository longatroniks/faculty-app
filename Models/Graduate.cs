namespace LonginKP3.Models
{
    /// <summary>
    /// Allows access to attributes inside of the
    /// DegreeModel.
    /// </summary>
    public class Graduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string[] concentrations { get; set; }
        public string[] availableCertificates { get; set; }
    }

}
