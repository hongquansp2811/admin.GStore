using Admin.DTOs;
using Admin.Models;
using Admin.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Services
{
    public interface ISystemRoleService
    {
        bool Create(RoleDTO Dto);
        List<Role> GetAll();
        RoleDTO GetDTOById(int id);
        bool DeleteById(int id);
        bool Update(RoleDTO Dto);
    }

    public class SystemRoleService : ISystemRoleService
    {
        private ISystemRoleRepository _systemRoleRepository;
        public SystemRoleService()
        {
            this._systemRoleRepository = new SystemRoleRepository();
        }

        public bool Create(RoleDTO Dto)
        {
            if (!_systemRoleRepository.GetRole().Any(x => x.RoleName.Equals(Dto.RoleName)))
            {
                var entity = new Role()
                {
                    RoleName = Dto.RoleName,    
                };
                _systemRoleRepository.Add(entity);
                return true;
            }
            else return false;
        }

        public bool DeleteById(int id)
        {
            var current = _systemRoleRepository.GetById(id);
            if (current != null)
            {
                _systemRoleRepository.GetAll().Remove(current);
                _systemRoleRepository.SaveChanges();
                return true;
            }else return false; 
        }

        public List<Role> GetAll()
        {
            return _systemRoleRepository.GetAll();
        }

        public RoleDTO GetDTOById(int id)
        {
            var current = _systemRoleRepository.GetById(id);
            RoleDTO Dto = new RoleDTO()
            {
                Id = current.RoleId,
                RoleName =current.RoleName, 
            };
            return Dto;
        }

        public bool Update(RoleDTO Dto)
        {
            var current = _systemRoleRepository.GetById(Dto.Id);
            if (current != null)
            {
                current.RoleName = Dto.RoleName;
                _systemRoleRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
