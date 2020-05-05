using AutoMapper;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.ConfigMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Order
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
            CreateMap<OrderDetailDto, OrderDetail>();
            CreateMap<OrderDetail, OrderDetailDto>();
            CreateMap<DishExtraDto, DishExtra>();
            CreateMap<DishExtra, DishExtraDto>();
            CreateMap<OrderStateDto, Order>();
            CreateMap<OrderStateDto, OrderDto>();
            CreateMap<DataCollection<Order>,DataCollection<OrderDto>>();

            //OrderCreate
            CreateMap<OrderCreateDto, Order>();
            CreateMap<OrderDetailCreateDto, OrderDetail>();
            CreateMap<DishExtraCreateDto, DishExtra>();

            //Extra
            CreateMap<Extra, ExtraDto>();
            CreateMap<DataCollection<Extra>, DataCollection<ExtraDto>>();

            //Card
            CreateMap<Card, CardDto>();
            CreateMap<CardCreateDto, Card>();

            //Client
            CreateMap<Client, ClientDto>();
            CreateMap<ClientDto, Client>();
            CreateMap<ClientLoginDto, Client>();
            CreateMap<ClientLoginDto, ClientDto>();
            CreateMap<DataCollection<Client>, DataCollection<ClientDto>>();
            CreateMap<ClientCreateDto, Client>();

            //Dish
            CreateMap<Dish, DishDto>();
            CreateMap<DataCollection<DishDto>, DataCollection<Dish>>();
            CreateMap<DataCollection<Dish>, DataCollection<DishDto>>();

            //Restaurant
            CreateMap<Restaurant, RestaurantDto>();
            CreateMap<RestaurantDto, Restaurant>();
            CreateMap<DataCollection<Restaurant>, DataCollection<RestaurantDto>>();

            //Restaurant Owner
            CreateMap<RestaurantOwner, RestaurantOwnerDto>();
            CreateMap<DataCollection<RestaurantOwner>, DataCollection<RestaurantOwnerDto>>();
            CreateMap<RestaurantOwnerDto, RestaurantOwner>();
        }
    }
}
