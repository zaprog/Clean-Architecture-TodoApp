﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.ViewModel;
using TodoApp.Domain.Entities;

namespace TodoApp.Application.Services.Interfce
{
    public interface ILinkService
    {
        Task<QueryResult<LinkModel>> GetAll(UserParamsModel userParams);
        Task<LinkModel> GetById(Guid id);
        Task Add(LinkModel entity);
        Task Update(LinkModel entity);
        Task Delete(Guid id);
        Task<QueryResult<LinkModel>> GetBySubCategoryId(Guid Id, UserParamsModel userParams);
    }
}
