using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace MySequentialflow
{
    public sealed partial class Workflow1 : Sage.Platform.Process.Activities.SequentialEntityWorkflow
	{
		public Workflow1()
		{
			InitializeComponent();
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            this.createToDo1.Notes = "This is a reminder to send an email to the client since they have moved divisions!";
        }

        public Sage.Entity.Interfaces.IAccount CurrentEntity
        {
            get
            {
                return ((Sage.Entity.Interfaces.IAccount)(this.GetEntity()));
            }
        }
	}

}
