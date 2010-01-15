using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace MyNewWorkflow
{
    public sealed partial class Workflow2 : Sage.Platform.Process.Activities.SequentialEntityWorkflow
	{
		public Workflow2()
		{
			InitializeComponent();
        }

        public Sage.Entity.Interfaces.IAccount CurrentEntity
        {
            get
            {
                return ((Sage.Entity.Interfaces.IAccount)(this.GetEntity()));
            }
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
        this.createToDo1.Notes = this.CurrentEntity.AccountName + " was changed - division";
        System.Net.Mail.SmtpClient sendnow = new System.Net.Mail.SmtpClient("localhost");
        sendnow.Send("website@yourdomain.com", "someoneelse@yourdomain.com", "Division was changed!","The Division on account " + this.CurrentEntity.AccountName);
        sendnow = null;
        }
	}

}
