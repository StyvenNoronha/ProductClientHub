using ProductClientHub.API.Infraestructure;
using ProductClientHub.Communication.Response;

namespace ProductClientHub.API.UseCases.Clients.GetAll
{
    public class GetAllClientsCase
    {
        public ResponseAllClientJson Execute()
        {
            var dbContext = new ProductClientHubDbContext();

            var clients = dbContext.Clients.ToList();

            return new ResponseAllClientJson
            {
                Clients = clients.Select(client => new ResponseShortClientJson
                {
                    Id = client.Id,
                    Name = client.Name,
                }).ToList()
            };


        }
    }
}
