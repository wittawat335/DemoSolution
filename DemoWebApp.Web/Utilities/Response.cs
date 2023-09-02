namespace DemoWebApp.Web.Utilities
{
    public class Response<T>
    {
        public T Value { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string returnUrl { get; set; }
    }
}
