using System;
using System.Collections.Generic;
using System.Text;
using Travel.Domain.Models;

namespace Travel.Service.IService
{
    public interface ICategoryService
    {
        Category GetModelById(int Id);
    }
}
