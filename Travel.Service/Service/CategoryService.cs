using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Travel.Domain;
using Travel.Domain.Models;
using Travel.Service.IService;
namespace Travel.Service.Service
{
    public class CategoryService : ICategoryService
    {
        IBaseRepository<Category> _repository = null;
        public CategoryService(IBaseRepository<Category> repository)
        {
            _repository = repository;
        }

        public List<Category> GetCategoryByParentId(int parentId)
        {
            return _repository.GetModelList("where ParentId=@ParentId and State=1", new { ParentId = parentId })?.ToList();
        }

        public List<Category> GetCategoryList()
        {
            return _repository.GetModelList("where State=1", null)?.ToList();
        }

        public Category GetModelById(int id)
        {
            return _repository.GetModel(id);
        }
    }
}
