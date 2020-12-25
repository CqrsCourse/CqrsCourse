﻿using System.Linq;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Entities;
using Infrastructure.Interfaces;
using Layers.ApplicationServices.Interfaces;
using Layers.ApplicationServices.Interfaces.Product;
using Microsoft.EntityFrameworkCore;

namespace ApplicationServices.Implementation
{
    public class ProductService : EntityService<Product, ChangeProductDto>, IProductService
    {
        public ProductService(IDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        
    }
}
