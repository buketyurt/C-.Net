﻿using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.DataAccess
{
    public class ProductDal : IProductDal
    {
        private List<Product> _products;

        public ProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId = 1, ProductName = "Acer Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 2, UnitPrice = 1000},
                new Product{ProductId = 2, ProductName = "Asus Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 1, UnitPrice = 1000},
                new Product{ProductId = 3, ProductName = "HP Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 0, UnitPrice = 1000},
                new Product{ProductId = 4, ProductName = "Mac Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 3, UnitPrice = 1000},
                new Product{ProductId = 5, ProductName = "Dell Bilgisayar", QuantityPerUnit = "32 GB rAM", UnitInStock = 10, UnitPrice = 1000},
            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            Console.WriteLine("Ado.NET ile eklendi.");
        }

        public List<Product> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Remove(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
