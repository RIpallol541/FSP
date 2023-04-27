using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsp_project_models.Interfaces
{
    public interface IUser
    {
        string Name { get; }
        string Surname { get; }
        string Login { get; }
        string Password { get; }
        string Avatar { get; }
    }
}
