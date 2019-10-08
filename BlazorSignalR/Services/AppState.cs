using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSignalR.Services
{
    public class AppState : IAppState
    {
        public event Action Loggedin;
        public void LoggedinRefresh()
        {
            Loggedin?.Invoke();
        }
        public event Action Loggedout;
        public void LoggedoutRefresh()
        {
            Loggedout?.Invoke();
        }
    }
}
