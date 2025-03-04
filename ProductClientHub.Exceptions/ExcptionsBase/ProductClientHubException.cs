namespace ProductClientHub.Exceptions.ExcptionsBase
{
   public abstract  class ProductClientHubException : SystemException
    {
        public ProductClientHubException(string errorMessage): base(errorMessage)
        {
            
        }

        public abstract List<string> GetErrors();
    }
}
