using AutoMapper;
using FIAP.Crosscutting.Domain.Helpers.Pagination;
using FIAP.TechChallenge.Application.ViewModels;
using FIAP.TechChallenge.Domain.DataTransferObjects;

namespace FIAP.TechChallenge.Application.Mappings
{
    public class ToViewModelMappingProfile : Profile
    {
        public ToViewModelMappingProfile()
        {
            CreateMap<CustomerDto, CustomerResponseViewModel>();
            CreateMap<PagedResult<CustomerDto>, PagedResult<CustomerResponseViewModel>>();

            CreateMap<CustomerDto, CustomerResponseViewModel>();
            CreateMap<PagedResult<CustomerDto>, PagedResult<CustomerResponseViewModel>>();

            CreateMap<OrderDto, OrderResponseViewModel>();
            CreateMap<PagedResult<OrderDto>, PagedResult<OrderResponseViewModel>>();
        }
    }
}
