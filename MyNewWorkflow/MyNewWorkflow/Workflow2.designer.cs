using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace MyNewWorkflow
{
    partial class Workflow2 : Sage.Platform.Process.Activities.SequentialEntityWorkflow
	{
		#region Designer generated code
		
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
		private void InitializeComponent()
		{
            this.CanModifyActivities = true;
            System.Workflow.ComponentModel.ActivityBind activitybind1 = new System.Workflow.ComponentModel.ActivityBind();
            System.Workflow.ComponentModel.ActivityBind activitybind2 = new System.Workflow.ComponentModel.ActivityBind();
            Sage.SalesLogix.Process.Activities.RelativeDateTime relativedatetime1 = new Sage.SalesLogix.Process.Activities.RelativeDateTime();
            System.Workflow.Activities.Rules.RuleSetReference rulesetreference1 = new System.Workflow.Activities.Rules.RuleSetReference();
            this.createToDo1 = new Sage.SalesLogix.Process.Activities.CreateToDo();
            this.codeActivity1 = new System.Workflow.Activities.CodeActivity();
            this.policyActivity1 = new System.Workflow.Activities.PolicyActivity();
            activitybind1.Name = "Workflow2";
            activitybind1.Path = "CurrentEntity.Id";
            activitybind2.Name = "Workflow2";
            activitybind2.Path = "CurrentEntity.ModifyUser";
            // 
            // createToDo1
            // 
            this.createToDo1.ActivityDescription = "Created from Process";
            this.createToDo1.Description = "Created from Process";
            this.createToDo1.Name = "createToDo1";
            relativedatetime1.BaseDateTime = new System.DateTime(2008, 10, 2, 0, 0, 0, 0);
            relativedatetime1.Offset = System.TimeSpan.Parse("00:00:00");
            relativedatetime1.RelativeTo = Sage.SalesLogix.Process.Activities.RelativeTo.UtcNow;
            this.createToDo1.StartDate = relativedatetime1;
            this.createToDo1.SetBinding(Sage.SalesLogix.Process.Activities.CreateActivityBase.AccountIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind1)));
            this.createToDo1.SetBinding(Sage.SalesLogix.Process.Activities.CreateActivityBase.UserIdProperty, ((System.Workflow.ComponentModel.ActivityBind)(activitybind2)));
            // 
            // codeActivity1
            // 
            this.codeActivity1.Name = "codeActivity1";
            this.codeActivity1.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // policyActivity1
            // 
            this.policyActivity1.Name = "policyActivity1";
            rulesetreference1.RuleSetName = "Rule Set1";
            this.policyActivity1.RuleSetReference = rulesetreference1;
            // 
            // Workflow2
            // 
            this.Activities.Add(this.policyActivity1);
            this.Activities.Add(this.codeActivity1);
            this.Activities.Add(this.createToDo1);
            this.Description = "y 2nd Workflow";
            this.EntityId = null;
            this.EntityType = typeof(Sage.Entity.Interfaces.IAccount);
            this.Name = "Workflow2";
            this.CanModifyActivities = false;

		}

		#endregion

        private PolicyActivity policyActivity1;
        private CodeActivity codeActivity1;
        private Sage.SalesLogix.Process.Activities.CreateToDo createToDo1;




    }
}
