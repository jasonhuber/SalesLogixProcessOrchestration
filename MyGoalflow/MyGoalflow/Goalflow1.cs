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

namespace MyGoalflow
{
    public sealed partial class Goalflow1 : Sage.Platform.Process.Activities.GoalDrivenWorkflow
	{
		public Goalflow1()
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
	}

}
