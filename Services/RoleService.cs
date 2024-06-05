using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleRepository _roleRepository;

        public RoleService(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public bool AddRole(Role role)
        {
            return _roleRepository.AddRole(role);
        }

        public bool DelRoles(int id)
        {
            return _roleRepository.DelRoles(id);
        }

        public List<Role> GetRoles()
        {
            return _roleRepository.GetRoles();
        }

        public bool UpdateAccounts(Role role)
        {
            return _roleRepository.UpdateAccounts(role);
        }
    }
}
