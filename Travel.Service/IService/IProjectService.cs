using System;
using System.Collections.Generic;
using System.Text;
using Travel.Domain.Models;

namespace Travel.Service.IService
{
    public interface IProjectService
    {
        /// <summary>
        /// 添加线路
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        bool AddPeoject(Project project);
        /// <summary>
        /// 修改线路
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        bool UpdateProject(Project project);
        /// <summary>
        /// 删除线路
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        bool DeleteProject(int projectId);
        /// <summary>
        /// 根据分类获取线路列表
        /// </summary>
        /// <param name="catrgoryId"></param>
        /// <returns></returns>
        List<Project> GetProjectByCategory(int catrgoryId);

    }
}
