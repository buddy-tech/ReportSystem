using System;
using System.Windows;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using System.Drawing;

using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Design;
using DevExpress.Utils.Design;
using DevExpress.XtraReports.Localization;
using DevExpress.Utils;
//using DevExpress.XtraGrid.Design;

using CurrentDesign = DevExpress.Utils.Design;  //08-13-2008@Scott

namespace Webb.Reports.ExControls.Design
{
	/// <summary>
	/// Summary description for ReportInfoLableDesigner.
	/// </summary>
	public class StatControlDesigner : ExControlDesigner
	{
		public StatControlDesigner(){}

		public override void Initialize(IComponent component)
		{
			base.Initialize (component);
			this._DesignForm = new UI.DF_StatControl();
			this._DesignForm.SetView(this._Control.MainView);
		}

		public override void InitializeActionList()
		{
			this._ActionLists.Add(new StatControlActionList(this));
		}

		public override void InitializeVerbs()
		{
			base.InitializeVerbs(true);
			
			this._Verbs.Add(new DesignerVerb("Update View",new EventHandler(UpdateView)));
		}

		public override void RunDesigner(object sender, EventArgs e)
		{
			this._DesignForm.SetView(this._Control.MainView);

			DialogResult m_Result = this._DesignForm.ShowDialog();
			
			if(m_Result==DialogResult.OK)
			{
				this._DesignForm.UpdateView(this._Control.MainView);
				
				this._Control.CalculateResult();
			}
		}

		private void UpdateView(object sender,EventArgs e)
		{
			this._Control.MainView.UpdateView();
		}

		internal class StatControlActionList : Webb.Reports.ExControls.Design.ExControlDesigner.ExControlActionList
		{
			//ctor
			public StatControlActionList(ExControlDesigner designer) : base(designer){}
			
			[EditorAttribute(typeof(Webb.Reports.Editors.DBFilterEditor), typeof(System.Drawing.Design.UITypeEditor))]	//06-17-2008@Scott
			public Webb.Data.DBFilter Filter
			{
				get { return ((StatControl)Component).Filter; }
				set { ((StatControl)Component).Filter = value;}
			}

			public bool Multiline
			{
				get{ return ((StatControl)Component).Multiline;}

				set{ ((StatControl)Component).Multiline = value;}
			}

			public bool Overlap
			{
				get{ return ((StatControl)Component).Overlap;}

				set{ ((StatControl)Component).Overlap = value;}
			}
            public bool AdjustWidth
			{
				get{ return ((StatControl)Component).AdjustWidth;}

				set{ ((StatControl)Component).AdjustWidth = value;}
			}
			protected override void FillActionItemCollection(CurrentDesign.DesignerActionItemCollection actionItems)
			{
				base.FillActionItemCollection (actionItems);

				AddPropertyItem(actionItems, "Filter", "Filter", "Filters");

				AddPropertyItem(actionItems, "Multiline", "Multiline", "Multiline");

//				AddPropertyItem(actionItems, "Overlap", "Overlap", "Overlap");

				AddPropertyItem(actionItems, "AdjustWidth", "AdjustWidth", "Adjust Widths By Manual");
			}
		}
	}
}