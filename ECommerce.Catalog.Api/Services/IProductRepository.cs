﻿using System;
using System.Collections.Generic;
using ECommerce.Catalog.Api.Models;

namespace ECommerce.Catalog.Api.Services
{
    public interface IProductRepository
    {
        void Add(Product prod);

        IEnumerable<Product> GetAll();

        Product GetByID(int id);

        void Delete(int id);

        void Update(Product prod);
    }
}
