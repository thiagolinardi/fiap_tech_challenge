using FIAP.Crosscutting.Domain.Commands.Handlers;
using FIAP.Crosscutting.Domain.MediatR;
using FIAP.TechChallenge.Domain.Commands;
using FIAP.TechChallenge.Domain.Entities;
using FIAP.TechChallenge.Domain.Enumerators;
using FIAP.TechChallenge.Domain.Helpers.Constants;
using FIAP.TechChallenge.Domain.Interfaces.Repositories;
using FIAP.TechChallenge.Domain.Interfaces.UnitOfWork;

namespace FIAP.TechChallenge.Domain.CommandHandlers
{
    public class AddOrderCommandHandler : MediatorCommandHandler<AddOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AddOrderCommandHandler(
            IOrderRepository orderRepository,
            IUnitOfWork unitOfWork,
            IMediatorHandler mediator,
            IOrderItemRepository orderItemRepository) : base(mediator)
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _orderItemRepository = orderItemRepository;
        }

        public override async Task AfterValidation(AddOrderCommand request)
        {
            Int64 lastOrderNumber = await _orderRepository.CountAllAsync();

            var order = new Entities.Order
            {
                CustomerId = request.CustomerId,
                Number = lastOrderNumber + 1,
                Total = request.Total,
                OrderSituationEnum = OrderSituationEnum.Received
            };

            await _orderRepository.InsertAsync(order);

            await _orderItemRepository.InsertRangeAsync(request.OrderItems.Select(x => new OrderItem()
            {
                OrderId = order.Id,
                ProductId = x.ProductId,
                Quantity = x.Quantity
            }).ToList());

            if (HasNotification() || !await _unitOfWork.CommitAsync())
                NotifyError(Values.Message.DefaultError);
        }
    }
}
