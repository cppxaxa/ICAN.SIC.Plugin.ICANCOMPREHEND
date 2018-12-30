using ICAN.SIC.Abstractions;
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
        }


    }
}
