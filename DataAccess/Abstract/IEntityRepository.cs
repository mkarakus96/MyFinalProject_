﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAllByCategory(int categoryId);
    }
}
