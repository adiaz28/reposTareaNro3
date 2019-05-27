﻿using Cibertec.Repositories.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository Customers { get; }  
        IOrderItemRepository OrderItems { get; }
        IProductRepository Products { get; }
        ISupplierRepository Suppliers { get; }
        IUserRepository Users { get; }
        IOrderRepository Orders { get; }
    }
}
