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

namespace MyGoalflow
{
	partial class Goalflow1
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
            this.goalActivity2 = new Sage.Platform.Process.Activities.GoalActivity();
            this.goalActivity1 = new Sage.Platform.Process.Activities.GoalActivity();
            this.goalActivity4 = new Sage.Platform.Process.Activities.GoalActivity();
            this.goalActivity3 = new Sage.Platform.Process.Activities.GoalActivity();
            this.goalDrivenActivity1 = new Sage.Platform.Process.Activities.GoalDrivenActivity();
            this.goalDrivenActivity2 = new Sage.Platform.Process.Activities.GoalDrivenActivity();
            this.goalDrivenScopeActivity1 = new Sage.Platform.Process.Activities.GoalDrivenScopeActivity();
            // 
            // goalActivity2
            // 
            this.goalActivity2.AssignedTo = null;
            this.goalActivity2.Description = "Initial Phone Call";
            this.goalActivity2.MessageUri = "goalActivity2";
            this.goalActivity2.Name = "goalActivity2";
            this.goalActivity2.Status = Sage.Platform.Process.Activities.GoalStatus.NotStarted;
            // 
            // goalActivity1
            // 
            this.goalActivity1.AssignedTo = null;
            this.goalActivity1.Description = "Initial Email";
            this.goalActivity1.MessageUri = "goalActivity1";
            this.goalActivity1.Name = "goalActivity1";
            this.goalActivity1.Status = Sage.Platform.Process.Activities.GoalStatus.NotStarted;
            // 
            // goalActivity4
            // 
            this.goalActivity4.AssignedTo = null;
            this.goalActivity4.Description = "Follow-up Phone Call";
            this.goalActivity4.MessageUri = "goalActivity4";
            this.goalActivity4.Name = "goalActivity4";
            this.goalActivity4.Status = Sage.Platform.Process.Activities.GoalStatus.NotStarted;
            // 
            // goalActivity3
            // 
            this.goalActivity3.AssignedTo = null;
            this.goalActivity3.Description = "Follow-up Email";
            this.goalActivity3.MessageUri = "goalActivity3";
            this.goalActivity3.Name = "goalActivity3";
            this.goalActivity3.Status = Sage.Platform.Process.Activities.GoalStatus.NotStarted;
            // 
            // goalDrivenActivity1
            // 
            this.goalDrivenActivity1.Activities.Add(this.goalActivity1);
            this.goalDrivenActivity1.Activities.Add(this.goalActivity2);
            this.goalDrivenActivity1.Description = "Initial Contact Items";
            this.goalDrivenActivity1.Name = "goalDrivenActivity1";
            // 
            // goalDrivenActivity2
            // 
            this.goalDrivenActivity2.Activities.Add(this.goalActivity3);
            this.goalDrivenActivity2.Activities.Add(this.goalActivity4);
            this.goalDrivenActivity2.Description = "Follow Ups";
            this.goalDrivenActivity2.Name = "goalDrivenActivity2";
            // 
            // goalDrivenScopeActivity1
            // 
            this.goalDrivenScopeActivity1.ActiveGoalSetName = null;
            this.goalDrivenScopeActivity1.Activities.Add(this.goalDrivenActivity1);
            this.goalDrivenScopeActivity1.Description = "Outter most";
            this.goalDrivenScopeActivity1.Name = "goalDrivenScopeActivity1";
            // 
            // Goalflow1
            // 
            this.Activities.Add(this.goalDrivenScopeActivity1);
            this.Activities.Add(this.goalDrivenActivity2);
            this.EntityId = null;
            this.EntityType = typeof(Sage.Entity.Interfaces.IAccount);
            this.Name = "Goalflow1";
            this.CanModifyActivities = false;

		}

		#endregion

        private Sage.Platform.Process.Activities.GoalActivity goalActivity2;
        private Sage.Platform.Process.Activities.GoalActivity goalActivity1;
        private Sage.Platform.Process.Activities.GoalActivity goalActivity3;
        private Sage.Platform.Process.Activities.GoalDrivenActivity goalDrivenActivity1;
        private Sage.Platform.Process.Activities.GoalDrivenActivity goalDrivenActivity2;
        private Sage.Platform.Process.Activities.GoalActivity goalActivity4;
        private Sage.Platform.Process.Activities.GoalDrivenScopeActivity goalDrivenScopeActivity1;


    }
}
