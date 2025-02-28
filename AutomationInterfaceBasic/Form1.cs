using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationInterfaceBasic
{
    public partial class Main : Form
    {
        private Type t;
        private EnvDTE.DTE dte;

        public Main()
        {
            InitializeComponent();
        }

        private async void btnCreateTwinCATInstance_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                t = System.Type.GetTypeFromProgID("TcXaeShell.DTE.15.0");
                dte = (EnvDTE.DTE)System.Activator.CreateInstance(t);
                dte.SuppressUI = false;
                dte.MainWindow.Visible = true;
            });
           
        }
    }
}
