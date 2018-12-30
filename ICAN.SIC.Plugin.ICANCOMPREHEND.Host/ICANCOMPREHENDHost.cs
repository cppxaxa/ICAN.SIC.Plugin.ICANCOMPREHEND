using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICAN.SIC.Plugin.ICANCOMPREHEND.Host
{
    public partial class ICANCOMPREHENDHost : Form
    {
        ICANCOMPREHEND controller;

        public ICANCOMPREHENDHost()
        {
            InitializeComponent();

            controller = new ICANCOMPREHEND();
        }
    }
}
