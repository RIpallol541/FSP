using fsp_project_models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fsp_project_models.Models
{
    public class Partner : IEntity, IUser
    {
        public Guid Id => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Surname => throw new NotImplementedException();

        public string Login => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public string Avatar => throw new NotImplementedException();
    }
}
