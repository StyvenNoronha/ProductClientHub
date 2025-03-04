namespace ProductClientHub.Communication.Response
{
    public class ResponseErrorMessageJson
    {
        public List<string> Errors { get;  private set; }


        public ResponseErrorMessageJson(string message)
        {
            Errors = [message];
        }
    }
}
