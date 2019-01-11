using System;
using System.Collections.Generic;
using System.Text;
using Travel.Domain.Models;

namespace Travel.Service.IService
{
    public interface ICategoryService
    {
        /// <summary>
        /// 根据Id获取分类
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Category GetModelById(int Id);
        /// <summary>
        /// 获取所有分类
        /// </summary>
        /// <returns></returns>
        List<Category> GetCategoryList();
        /// <summary>
        /// 根据上级分类Id获取分类列表 parentId=0 为顶级分类
        /// </summary>
        /// <param name="parentId"></param>
        /// <returns></returns>
        List<Category> GetCategoryByParentId(int parentId);

    }
}
