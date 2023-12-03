using AutoMapper;
using Microsoft.OpenApi.Extensions;
using ProductService.API.Dtos;
using ProductService.API.Models;

namespace ProductService.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                // Convert enum to string
                .ForMember(dest => dest.Labels, opt => opt.MapFrom(src => src.Labels.GetDisplayName()))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.GetDisplayName()))
                .ReverseMap();
            });

            return mappingConfig;
        }
    }
}
