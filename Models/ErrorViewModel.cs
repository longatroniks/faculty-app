namespace LonginKP3.Models
{
    /// <summary>
    /// Allows for easier debugging by displaying
    /// data from an error that occured inside of
    /// the view.
    /// </summary>
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}