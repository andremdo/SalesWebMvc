﻿using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext Context;

        public SellerService(SalesWebMvcContext context)
        {
            Context = context;
        }
        public List<Seller> FindAll()
        {
            return Context.Seller.ToList();
        }
    }
}
