namespace SampleApi.WebFramework.ApiHelper
{
    public class ApiResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }


    public class ApiResult<T> : ApiResult
    {
        public T Data { get; set; }
    }
}
