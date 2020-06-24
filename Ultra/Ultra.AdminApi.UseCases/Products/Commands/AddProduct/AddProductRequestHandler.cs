using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Ultra.Common.Domain.Entities.Models;
using Ultra.Common.Infrastructure.DataAccess.Interfaces;

namespace Ultra.Web.AdminApi.UseCases.Products.Commands.AddProduct
{
    public class AddProductRequestHandler : IRequestHandler<AddProductRequest, int>
    {
        private readonly ICommonDbContext _dbContext;
        private readonly IMapper _mapper;

        public AddProductRequestHandler(ICommonDbContext dbContext, IMapper mapper)
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
