﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
    public class EFProductReposistory : IProductRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Product> Products { get { return context.Products; } }
    }
}
