using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Min.Entities;
using Min.Infrastructure.Interfaces.DataAccess;
using Min.Infrastructure.Interfaces.Services;

namespace Min.UseCases.Handlers.Orders.Commands.CreateOrder
{
    public class CreateOrderRequestHandler : AsyncRequestHandler<CreateOrderRequest>
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private readonly ICurrentUserService _currentUserService;

        public CreateOrderRequestHandler(
            IDbContext dbContext, 
            IMapper mapper, 
            IEmailService emailService,
            ICurrentUserService currentUserService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _emailService = emailService;
            _currentUserService = currentUserService;
        }

        protected override async Task Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Order>(request.OrderDto);
            order.CreationDate = DateTime.Now;

            _dbContext.Orders.Add(order);

            await _dbContext.SaveChangesAsync(cancellationToken);

            await _emailService.SendEmailAsync(_currentUserService.Email, "Order created", $"Your order {order.Id} created successfully");
        }
    }
}
