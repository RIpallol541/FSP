using fsp_project_models.Interfaces;

namespace fsp_project_models.Models
{
    internal class Sportsman : IEntity, IUser
    {
        public Guid Id => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string Surname => throw new NotImplementedException();

        public string Login => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public string Avatar => throw new NotImplementedException();
        public int Rating { get; set; }
        public IEnumerable<string> Skills { get; set; }
    }
}
