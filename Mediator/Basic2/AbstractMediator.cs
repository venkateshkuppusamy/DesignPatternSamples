using System.Collections.Generic;
using System.Text;

namespace Mediator.Basic2
{
    public abstract class AbstractMediator
    {
        public ILocalCollegue LocalCollegue { get; set; }
        public IRemoteCollegue RemoteCollegue { get; set; }

        public abstract void MessageLocalCollegue(string msg);
        public abstract void MessageRemoteCollegeue(string msg);
    }
}
