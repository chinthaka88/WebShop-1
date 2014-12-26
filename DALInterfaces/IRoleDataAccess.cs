using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface IRoleDataAccess
    {
        void AddNew(RoleDTO ex);
        void Update(RoleDTO ex);
        void Delete(int roleid);
        IEnumerable<RoleDTO> GetRole();
    }
}
