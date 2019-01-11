using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Travel.Domain;
using Travel.Domain.Models;
using Travel.Service.IService;

namespace Travel.Service.Service
{
    public class ProjectService : IProjectService
    {
        IBaseRepository<Project> _repository = null;
        public ProjectService(IBaseRepository<Project> repository)
        {
            _repository = repository;
        }
        public bool AddPeoject(Project project)
        {
            return _repository.Add(project);
        }
        public bool UpdateProject(Project project)
        {
            return _repository.Update(project);
        }
        public bool DeleteProject(int projectId)
        {
            Project porject = _repository.GetModel(projectId);
            porject.State = -1;
            return _repository.Update(porject);
        }

        public List<Project> GetProjectByCategory(int catrgoryId)
        {
            return _repository.GetModelList("where CategoryId=@CategoryId and State=1", new { CategoryId = catrgoryId })?.ToList();
        }

    }
}
