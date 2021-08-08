using AutoMapper;
using Mango.Services.ShoppingCartApi.Model;
using Mango.Services.ShoppingCartApi.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mango.Services.ShoppingCartApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ShoppingCartDto, ShoppingCart>();
                config.CreateMap<ShoppingCart, ShoppingCartDto>();
            });

            return mappingConfig;
        }
    }
}
