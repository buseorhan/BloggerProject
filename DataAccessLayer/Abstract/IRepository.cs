﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Add(T item);
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        List<T> List(Expression<Func<T,bool>> filter);
    }
}
