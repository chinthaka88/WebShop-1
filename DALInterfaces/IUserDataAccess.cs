using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DALInterfaces
{
    public interface IUserDataAccess
    {
        void AddNew(UserDTO ex);
        void Update(UserDTO ex);
        void Delete(int userid);
        IEnumerable<UserDTO> GetUser();
    }
}
