using System;
using System.Collections.Generic;
using System.Text;
using Travel.Domain;
using Travel.Domain.Models;
using Travel.Service.IService;
namespace Travel.Service.Service
{
    public class CategorySvc : ICategoryService
    {
        IBaseRepository<Category> _repository = null;
        public CategorySvc(IBaseRepository<Category> repository)
        {
            _repository = repository;
        }

        public Category GetModelById(int id)
        {
            return _repository.GetModel(id);
        }
    }
}
