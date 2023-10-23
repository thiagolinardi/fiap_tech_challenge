using FIAP.TechChallenge.Domain.Commands;
using FluentValidation;

namespace FIAP.TechChallenge.Domain.Validations
{
    public class OrderValidation<TCommand> : AbstractValidator<TCommand> where TCommand : OrderCommand
    {
        protected void ValidateOrderId()
        {
            RuleFor(x => x.Id)
                .NotNull().NotEqual(Guid.Empty).WithMessage("O código do pedido é obrigatório");
        }

        protected void ValidateOrder()
        {
            RuleFor(x => x.CustomerId)
                .NotNull().NotEqual(Guid.Empty).WithMessage("O código do cliente é obrigatório");

            RuleFor(x => x.Total)
                .NotNull().WithMessage("O total do pedido é obrigatório");

            RuleForEach(x => x.OrderItems).SetInheritanceValidator(v =>
            {
                v.Add(new OrderItemValidation());
            });
        }
    }

    public class OrderItemValidation : AbstractValidator<OrderCommand.OrderItem>
    {
        protected void ValidateOrderItem()
        {
            RuleFor(x => x.Quantity)
                .NotNull().WithMessage("A quantidade de itens é obrigatória");

            RuleFor(x => x.ProductId)
                .NotNull().WithMessage("O id do produto é obrigatório");
        }
    }
}