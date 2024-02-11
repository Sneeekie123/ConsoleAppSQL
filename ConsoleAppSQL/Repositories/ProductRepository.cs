﻿using ConsoleAppSQL.Contexts;
using ConsoleAppSQL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleAppSQL.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    private readonly DataContext _context;
    public ProductRepository(DataContext context) : base(context)
    {
        _context = context;
    }


    public override ProductEntity Get(Expression<Func<ProductEntity, bool>> expression)
    {
        var entity = _context.Products
             .Include(i => i.Category)
             .FirstOrDefault(expression);

        return entity!;
    }


    public override IEnumerable<ProductEntity> GetAll()
    {
        return _context.Products
            .Include(i => i.Category)
            .ToList();
    }
}

