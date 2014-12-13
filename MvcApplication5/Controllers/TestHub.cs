using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using MvcApplication5.Models;

namespace MvcApplication5.Controllers
{
    public class TestHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Chat(Point p)
        {
            Clients.Others.addNewMessageToPage(p);
        }
    }
}