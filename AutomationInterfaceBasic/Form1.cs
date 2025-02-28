using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCatSysManagerLib;

namespace AutomationInterfaceBasic
{
    public partial class Main : Form
    {
        private Type t;
        private EnvDTE.DTE dte;
        private EnvDTE.Solution sol;
        private EnvDTE.Project prj;
        private ITcSysManager sysManager;
        private ITcSmTreeItem plc;
        private ITcSmTreeItem newPlcProject;

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

        private async void btnCreateTwinCATPrj_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                sol = dte.Solution;
                sol.Create(@"C:\Users\GokulG\Desktop\New folder", "SolProj");
                sol.SaveAs(@"C:\Users\GokulG\Desktop\New folder\SolProj.sln");
                string template = @"C:\TwinCAT\3.1\Components\Base\PrjTemplate\TwinCAT Project.tsproj"; //path to project template
                prj = sol.AddFromTemplate(template, @"C:\Users\GokulG\Desktop\New folder\TwinCATPrj", "TwinCATPrj");
                
            });
        }

        private async void btnActivateConfig_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (sysManager == null)
                {
                    sysManager = (ITcSysManager)prj.Object;
                }
                sysManager.ActivateConfiguration();
            });
        }

        private async void btnRestartTwincat_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (sysManager == null)
                {
                    sysManager = (ITcSysManager)prj.Object;
                }
                sysManager.StartRestartTwinCAT();
            });
        }

        private async void btnCreatePLCProject_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (sysManager == null){
                    sysManager = (ITcSysManager)prj.Object;
                }
                plc = sysManager.LookupTreeItem("TIPC");
                //string pathToTemplateFile = @"C:\TwinCAT\3.x\Components\Plc\PlcTemplate\Plc Templates\Standard PLC Template.plcproj";
                //ITcSmTreeItem newProject = plc.CreateChild("NameOfProject", 0, "", pathToTemplateFile);
                //If you are using beckhoff template just enter the template name path is not Required;
                newPlcProject = plc.CreateChild("PLCProject1", 0, "", "Standard PLC Template.plcproj"); 
            });
        }


    }
}
