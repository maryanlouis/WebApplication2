﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        //ICollection<T> FindAll();
        Task <ICollection<T>> FindAll();
        //T FindById(int id);
        Task <T> FindById(int id);
        Task <bool> isExists(int id);
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Save();
    }
	
}
