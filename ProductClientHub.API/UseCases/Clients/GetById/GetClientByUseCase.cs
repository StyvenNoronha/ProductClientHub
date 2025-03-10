﻿using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Infraestructure;
using ProductClientHub.Communication.Response;
using ProductClientHub.Exceptions.ExcptionsBase;

namespace ProductClientHub.API.UseCases.Clients.GetById
{
    public class GetClientByUseCase
    {
        public ResponseClientJson Execute(Guid id)
        {
            var dbContext = new ProductClientHubDbContext();

            var entity = dbContext.Clients.Include(client => client.Products).FirstOrDefault(client => client.Id == id);

            if (entity is null)
                throw new NotFoundException("Cliente não encontrado.");

            return new ResponseClientJson
            {
                Id = id,
                Name = entity.Name,
                Email = entity.Email,
                Product = entity.Products.Select(product => new ResponseShortProductJson
                {
                    Id = product.Id,
                    Name = product.Name,
                }).ToList()

            };
        }
    }
}
