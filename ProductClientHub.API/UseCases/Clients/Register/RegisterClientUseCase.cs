﻿using ProductClientHub.API.Entities;
using ProductClientHub.API.Infraestructure;
using ProductClientHub.API.UseCases.Clients.ShareValidator;
using ProductClientHub.Communication.Request;
using ProductClientHub.Communication.Response;
using ProductClientHub.Exceptions.ExcptionsBase;

namespace ProductClientHub.API.UseCases.Clients.Register
{
    public class RegisterClientUseCase
    {
        public ResponseShortClientJson Execute(RequestClientJson request)
        {

            Validate(request);
            var dbContext = new ProductClientHubDbContext();

            var entity = new Client
            {
                Name = request.Name,
                Email = request.Email,
                
            };

            dbContext.Clients.Add(entity);
            dbContext.SaveChanges();
            return new ResponseShortClientJson
            {   
                Id= entity.Id,
                Name = entity.Name
            };
        }

        private void Validate(RequestClientJson request)
        {
            var validator = new RequestrClientValidator();

            var result = validator.Validate(request);

            if (result.IsValid == false)
            {
                var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

            }
        }
    }
}
