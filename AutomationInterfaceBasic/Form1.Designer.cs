
namespace AutomationInterfaceBasic
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateTwinCATInstance = new System.Windows.Forms.Button();
            this.btnCreateTwinCATPrj = new System.Windows.Forms.Button();
            this.btnActivateConfig = new System.Windows.Forms.Button();
            this.btnRestartTwincat = new System.Windows.Forms.Button();
            this.btnCreatePLCProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTwinCATInstance
            // 
            this.btnCreateTwinCATInstance.Location = new System.Drawing.Point(12, 12);
            this.btnCreateTwinCATInstance.Name = "btnCreateTwinCATInstance";
            this.btnCreateTwinCATInstance.Size = new System.Drawing.Size(141, 23);
            this.btnCreateTwinCATInstance.TabIndex = 0;
            this.btnCreateTwinCATInstance.Text = "Create Instance of XAE Shell";
            this.btnCreateTwinCATInstance.UseVisualStyleBackColor = true;
            this.btnCreateTwinCATInstance.Click += new System.EventHandler(this.btnCreateTwinCATInstance_Click);
            // 
            // btnCreateTwinCATPrj
            // 
            this.btnCreateTwinCATPrj.Location = new System.Drawing.Point(12, 51);
            this.btnCreateTwinCATPrj.Name = "btnCreateTwinCATPrj";
            this.btnCreateTwinCATPrj.Size = new System.Drawing.Size(141, 23);
            this.btnCreateTwinCATPrj.TabIndex = 1;
            this.btnCreateTwinCATPrj.Text = "Create TwinCAT Project";
            this.btnCreateTwinCATPrj.UseVisualStyleBackColor = true;
            this.btnCreateTwinCATPrj.Click += new System.EventHandler(this.btnCreateTwinCATPrj_Click);
            // 
            // btnActivateConfig
            // 
            this.btnActivateConfig.Location = new System.Drawing.Point(159, 51);
            this.btnActivateConfig.Name = "btnActivateConfig";
            this.btnActivateConfig.Size = new System.Drawing.Size(125, 23);
            this.btnActivateConfig.TabIndex = 2;
            this.btnActivateConfig.Text = "Activate Configuration";
            this.btnActivateConfig.UseVisualStyleBackColor = true;
            this.btnActivateConfig.Click += new System.EventHandler(this.btnActivateConfig_Click);
            // 
            // btnRestartTwincat
            // 
            this.btnRestartTwincat.Location = new System.Drawing.Point(290, 51);
            this.btnRestartTwincat.Name = "btnRestartTwincat";
            this.btnRestartTwincat.Size = new System.Drawing.Size(109, 23);
            this.btnRestartTwincat.TabIndex = 3;
            this.btnRestartTwincat.Text = "Restart TwinCAT";
            this.btnRestartTwincat.UseVisualStyleBackColor = true;
            this.btnRestartTwincat.Click += new System.EventHandler(this.btnRestartTwincat_Click);
            // 
            // btnCreatePLCProject
            // 
            this.btnCreatePLCProject.Location = new System.Drawing.Point(12, 90);
            this.btnCreatePLCProject.Name = "btnCreatePLCProject";
            this.btnCreatePLCProject.Size = new System.Drawing.Size(141, 23);
            this.btnCreatePLCProject.TabIndex = 4;
            this.btnCreatePLCProject.Text = "Create PLC Project";
            this.btnCreatePLCProject.UseVisualStyleBackColor = true;
            this.btnCreatePLCProject.Click += new System.EventHandler(this.btnCreatePLCProject_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreatePLCProject);
            this.Controls.Add(this.btnRestartTwincat);
            this.Controls.Add(this.btnActivateConfig);
            this.Controls.Add(this.btnCreateTwinCATPrj);
            this.Controls.Add(this.btnCreateTwinCATInstance);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTwinCATInstance;
        private System.Windows.Forms.Button btnCreateTwinCATPrj;
        private System.Windows.Forms.Button btnActivateConfig;
        private System.Windows.Forms.Button btnRestartTwincat;
        private System.Windows.Forms.Button btnCreatePLCProject;
    }
}

