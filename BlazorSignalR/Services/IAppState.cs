using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalR.Services
{
    public interface IAppState
    {
        event Action Loggedin;
        void LoggedinRefresh();

        event Action Loggedout;
        void LoggedoutRefresh();
    }
}
