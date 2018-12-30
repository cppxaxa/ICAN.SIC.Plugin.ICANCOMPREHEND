using ICAN.SIC.Abstractions.IMessageVariants;
using Syn.Bot.Siml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICAN.SIC.Plugin.ICANCOMPREHEND.DataTypes
{
    public class BotResult : IBotResult
    {
        IUserResponse userResponse;
        string message;

        public BotResult(string message, IUserResponse userResponse)
        {
            this.userResponse = userResponse;
            this.message = message;
        }

        public Syn.Bot.Siml.ChatResult ChatResult
        {
            get { return null; }
        }

        public string Text
        {
            get { return message; }
        }

        public IUserResponse UserResponse
        {
            get { return userResponse; }
        }
    }
}
