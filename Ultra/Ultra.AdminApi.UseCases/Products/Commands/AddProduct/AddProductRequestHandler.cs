using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Ultra.Entities.Models;
using Ultra.Infrastructure.DataAccess.Interfaces;
using Ultra.Infrastructure.ServiceBus.Interfaces;

namespace Ultra.AdminApi.UseCases.Products.Commands.AddProduct
{
    public class AddProductRequestHandler : IRequestHandler<AddProductRequest, int>
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _mapper;

        public AddProductRequestHandler(IDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<int> Handle(AddProductRequest request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Product>(request.AddProductDto);
            _dbContext.Products.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }
    }
}
