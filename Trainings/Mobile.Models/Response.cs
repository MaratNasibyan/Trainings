namespace Mobile.Models
{
    public class ResponseSuccess : IResponse
    {
        public ResponseSuccess()
        {
            this.Result = new { };
        }

        public ResponseSuccess(object result)
        {
            this.Result = result;
        }

        public Status Status { get; set; } = new Status();
        public object Result { get; set; }
    }

    public class ResponseError : IResponse
    {
        public ErrorStatus Status { get; set; }       
    }

    public class Status
    {
        public bool Success { get; set; } = true;
    }

    public class ErrorStatus : Status
    {
        public string FriendlyErrorMessage { get; set; }
        public string DeveloperErrorMessage { get; set; }
    }

    public interface IResponse { }   
}
