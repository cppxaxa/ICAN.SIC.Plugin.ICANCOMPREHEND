using ICAN.SIC.Abstractions;
using ICAN.SIC.Abstractions.IMessageVariants;
using ICAN.SIC.Plugin.ICANCOMPREHEND.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICAN.SIC.Plugin.ICANCOMPREHEND
{
    public class ICANCOMPREHEND : AbstractPlugin
    {
        ICANCOMPREHENDUtility utility;
        ICANCOMPREHENDHelper helper;

        public ICANCOMPREHEND() : base("ICANCOMPREHENDv1")
        {
            utility = new ICANCOMPREHENDUtility();
            helper = new ICANCOMPREHENDHelper(utility);

            Hub.Subscribe<IBotResult>(this.ProcessBotResult);
        }

        public override void Dispose()
        {
            utility = null;
            helper = null;
        }

        private void ProcessBotResult(IBotResult botResult)
        {
            Hub.Publish<IBotResult>(new BotResult("Dummy - Message reached ICANCOMPREHEND", botResult.UserResponse));
        }
    }
}
