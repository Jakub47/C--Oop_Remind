using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Teoria.Adaptery.Forum
{
    class Messenger : IMessenger
    {
        private readonly MessageManager _messageManager;

        public Messenger(MessageManager messageManager)
        {
            _messageManager = messageManager;
        }

        public void Send(string msg)
        {
            _messageManager.SendMessage(msg);
        }
    }
}
