using AutoMapper;
using FavoriteService.API.Dtos;
using FavoriteService.API.Models;

namespace FavoriteService.API
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>()
                .ReverseMap();
                config.CreateMap<FavoriteProductDto, FavoriteProduct>()
                .ReverseMap();
            });

            return mappingConfig;
        }
    }
}
