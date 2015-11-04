using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.TestSite.Hubs
{
    public class TesterHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}