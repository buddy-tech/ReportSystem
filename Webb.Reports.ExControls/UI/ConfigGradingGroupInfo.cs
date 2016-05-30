﻿/***********************************************************************
 * IDE:Microsoft Development Environment Ver:7.10
 * Module:ConfigGroupingInfo.cs
 * Author:Country.Wu [EMail:Webb.Country.Wu@163.com]
 * Create Time:11/15/2007 02:22:41 PM
 * Copyright:1986-2007@Webb Electronics all right reserved.
 * Purpose:
 * ***********************************************************************/
#region History
/*
 * //Author@DateTime : Description
 * */
#endregion History

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Webb.Reports.ExControls;
using Webb.Reports.ExControls.Data;
using Webb.Reports.ExControls.Views;
using Webb.Collections;

using Webb.Reports.Editors;

namespace Webb.Reports.ExControls.UI
{
    public class ConfigGradingGroupInfo : Webb.Reports.ExControls.UI.ExControlDesignerControlBase
    {
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button C_NewGroup;
        private System.Windows.Forms.PropertyGrid C_PropertyGrid;
        private System.Windows.Forms.TreeView C_GroupInfoTree;
        private System.Windows.Forms.ContextMenu C_Menu;
        private System.Windows.Forms.MenuItem Menu_AddGroup;
        private System.Windows.Forms.MenuItem Menu_RemoveGroup;
        private System.Windows.Forms.MenuItem Menu_MoveUp;
        private System.Windows.Forms.MenuItem Menu_MoveDown;
        private System.Windows.Forms.Button C_MoveUp;
        private System.Windows.Forms.Button C_MoveDown;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuItem Menu_AddSummary;
        private System.Windows.Forms.Button C_AddSummary;
        private System.Windows.Forms.Button C_Remove;
        private System.Windows.Forms.Button C_CopySummary;
        private System.Windows.Forms.MenuItem Menu_CopySummary;
        private System.Windows.Forms.CheckBox C_CheckHeader;
        private System.Windows.Forms.Button C_BtnRevertStyle;
        private ImageList imageList1;
        private System.ComponentModel.IContainer components = null;

        public ConfigGradingGroupInfo()
            : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            this.Load += new EventHandler(ConfigGroupingInfo_Load);
            // TODO: Add any initialization after the InitializeComponent call
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Group");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigGradingGroupInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.C_CopySummary = new System.Windows.Forms.Button();
            this.C_AddSummary = new System.Windows.Forms.Button();
            this.C_MoveDown = new System.Windows.Forms.Button();
            this.C_MoveUp = new System.Windows.Forms.Button();
            this.C_Remove = new System.Windows.Forms.Button();
            this.C_NewGroup = new System.Windows.Forms.Button();
            this.C_CheckHeader = new System.Windows.Forms.CheckBox();
            this.C_PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.C_GroupInfoTree = new System.Windows.Forms.TreeView();
            this.C_Menu = new System.Windows.Forms.ContextMenu();
            this.Menu_AddGroup = new System.Windows.Forms.MenuItem();
            this.Menu_AddSummary = new System.Windows.Forms.MenuItem();
            this.Menu_CopySummary = new System.Windows.Forms.MenuItem();
            this.Menu_RemoveGroup = new System.Windows.Forms.MenuItem();
            this.Menu_MoveUp = new System.Windows.Forms.MenuItem();
            this.Menu_MoveDown = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.C_BtnRevertStyle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.C_CopySummary);
            this.panel1.Controls.Add(this.C_AddSummary);
            this.panel1.Controls.Add(this.C_MoveDown);
            this.panel1.Controls.Add(this.C_MoveUp);
            this.panel1.Controls.Add(this.C_Remove);
            this.panel1.Controls.Add(this.C_NewGroup);
            this.panel1.Controls.Add(this.C_CheckHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 40);
            this.panel1.TabIndex = 0;
            // 
            // C_CopySummary
            // 
            this.C_CopySummary.BackColor = System.Drawing.SystemColors.Control;
            this.C_CopySummary.Location = new System.Drawing.Point(208, 8);
            this.C_CopySummary.Name = "C_CopySummary";
            this.C_CopySummary.Size = new System.Drawing.Size(110, 23);
            this.C_CopySummary.TabIndex = 5;
            this.C_CopySummary.Text = "Copy Summary";
            this.C_CopySummary.UseVisualStyleBackColor = false;
            this.C_CopySummary.Click += new System.EventHandler(this.Menu_CopySummary_Click);
            // 
            // C_AddSummary
            // 
            this.C_AddSummary.BackColor = System.Drawing.SystemColors.Control;
            this.C_AddSummary.Location = new System.Drawing.Point(96, 8);
            this.C_AddSummary.Name = "C_AddSummary";
            this.C_AddSummary.Size = new System.Drawing.Size(105, 23);
            this.C_AddSummary.TabIndex = 4;
            this.C_AddSummary.Text = "Add Summary";
            this.C_AddSummary.UseVisualStyleBackColor = false;
            this.C_AddSummary.Click += new System.EventHandler(this.Menu_NewSummary_Click);
            // 
            // C_MoveDown
            // 
            this.C_MoveDown.BackColor = System.Drawing.SystemColors.Control;
            this.C_MoveDown.Location = new System.Drawing.Point(508, 8);
            this.C_MoveDown.Name = "C_MoveDown";
            this.C_MoveDown.Size = new System.Drawing.Size(90, 23);
            this.C_MoveDown.TabIndex = 3;
            this.C_MoveDown.Text = "Move Down";
            this.C_MoveDown.UseVisualStyleBackColor = false;
            this.C_MoveDown.Click += new System.EventHandler(this.Menu_MoveDown_Click);
            // 
            // C_MoveUp
            // 
            this.C_MoveUp.BackColor = System.Drawing.SystemColors.Control;
            this.C_MoveUp.Location = new System.Drawing.Point(431, 8);
            this.C_MoveUp.Name = "C_MoveUp";
            this.C_MoveUp.Size = new System.Drawing.Size(70, 23);
            this.C_MoveUp.TabIndex = 2;
            this.C_MoveUp.Text = "Move Up";
            this.C_MoveUp.UseVisualStyleBackColor = false;
            this.C_MoveUp.Click += new System.EventHandler(this.Menu_MoveUp_Click);
            // 
            // C_Remove
            // 
            this.C_Remove.BackColor = System.Drawing.SystemColors.Control;
            this.C_Remove.Location = new System.Drawing.Point(324, 8);
            this.C_Remove.Name = "C_Remove";
            this.C_Remove.Size = new System.Drawing.Size(100, 23);
            this.C_Remove.TabIndex = 1;
            this.C_Remove.Text = "Remove Item";
            this.C_Remove.UseVisualStyleBackColor = false;
            this.C_Remove.Click += new System.EventHandler(this.Menu_RemoveGroup_Click);
            // 
            // C_NewGroup
            // 
            this.C_NewGroup.BackColor = System.Drawing.SystemColors.Control;
            this.C_NewGroup.Location = new System.Drawing.Point(8, 8);
            this.C_NewGroup.Name = "C_NewGroup";
            this.C_NewGroup.Size = new System.Drawing.Size(80, 23);
            this.C_NewGroup.TabIndex = 0;
            this.C_NewGroup.Text = "Add Group";
            this.C_NewGroup.UseVisualStyleBackColor = false;
            this.C_NewGroup.Click += new System.EventHandler(this.Menu_NewGroup_Click);
            // 
            // C_CheckHeader
            // 
            this.C_CheckHeader.Location = new System.Drawing.Point(604, 8);
            this.C_CheckHeader.Name = "C_CheckHeader";
            this.C_CheckHeader.Size = new System.Drawing.Size(72, 24);
            this.C_CheckHeader.TabIndex = 8;
            this.C_CheckHeader.Text = "Header";
            this.C_CheckHeader.Visible = false;
            // 
            // C_PropertyGrid
            // 
            this.C_PropertyGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.C_PropertyGrid.LineColor = System.Drawing.SystemColors.Control;
            this.C_PropertyGrid.Location = new System.Drawing.Point(400, 40);
            this.C_PropertyGrid.Name = "C_PropertyGrid";
            this.C_PropertyGrid.Size = new System.Drawing.Size(280, 324);
            this.C_PropertyGrid.TabIndex = 1;
            // 
            // C_GroupInfoTree
            // 
            this.C_GroupInfoTree.AllowDrop = true;
            this.C_GroupInfoTree.ContextMenu = this.C_Menu;
            this.C_GroupInfoTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C_GroupInfoTree.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_GroupInfoTree.ForeColor = System.Drawing.Color.Black;
            this.C_GroupInfoTree.ImageIndex = 0;
            this.C_GroupInfoTree.ImageList = this.imageList1;
            this.C_GroupInfoTree.Location = new System.Drawing.Point(0, 40);
            this.C_GroupInfoTree.Name = "C_GroupInfoTree";
            treeNode1.Name = "";
            treeNode1.Text = "Group";
            this.C_GroupInfoTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.C_GroupInfoTree.SelectedImageIndex = 0;
            this.C_GroupInfoTree.Size = new System.Drawing.Size(400, 324);
            this.C_GroupInfoTree.TabIndex = 2;
            this.C_GroupInfoTree.Enter += new System.EventHandler(this.C_GroupInfoTree_Click);
            this.C_GroupInfoTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.C_GroupInfoTree_DragDrop);
            this.C_GroupInfoTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.C_GroupInfoTree_AfterSelect);
            this.C_GroupInfoTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.C_GroupInfoTree_DragEnter);
            this.C_GroupInfoTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.C_GroupInfoTree_BeforeSelect);
            this.C_GroupInfoTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.C_GroupInfoTree_KeyDown);
            this.C_GroupInfoTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.C_GroupInfoTree_ItemDrag);
            this.C_GroupInfoTree.DragOver += new System.Windows.Forms.DragEventHandler(this.C_GroupInfoTree_DragOver);
            this.C_GroupInfoTree.Click += new System.EventHandler(this.C_GroupInfoTree_Click);
            // 
            // C_Menu
            // 
            this.C_Menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_AddGroup,
            this.Menu_AddSummary,
            this.Menu_CopySummary,
            this.Menu_RemoveGroup,
            this.Menu_MoveUp,
            this.Menu_MoveDown});
            // 
            // Menu_AddGroup
            // 
            this.Menu_AddGroup.Index = 0;
            this.Menu_AddGroup.Text = "Add Group";
            this.Menu_AddGroup.Click += new System.EventHandler(this.Menu_NewGroup_Click);
            // 
            // Menu_AddSummary
            // 
            this.Menu_AddSummary.Index = 1;
            this.Menu_AddSummary.Text = "Add Summary";
            this.Menu_AddSummary.Click += new System.EventHandler(this.Menu_AddSummary_Click);
            // 
            // Menu_CopySummary
            // 
            this.Menu_CopySummary.Index = 2;
            this.Menu_CopySummary.Text = "Copy Summary";
            this.Menu_CopySummary.Click += new System.EventHandler(this.Menu_CopySummary_Click);
            // 
            // Menu_RemoveGroup
            // 
            this.Menu_RemoveGroup.Index = 3;
            this.Menu_RemoveGroup.Text = "Remove Item";
            this.Menu_RemoveGroup.Click += new System.EventHandler(this.Menu_RemoveGroup_Click);
            // 
            // Menu_MoveUp
            // 
            this.Menu_MoveUp.Index = 4;
            this.Menu_MoveUp.Text = "Move Up";
            this.Menu_MoveUp.Click += new System.EventHandler(this.Menu_MoveUp_Click);
            // 
            // Menu_MoveDown
            // 
            this.Menu_MoveDown.Index = 5;
            this.Menu_MoveDown.Text = "Move Down";
            this.Menu_MoveDown.Click += new System.EventHandler(this.Menu_MoveDown_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "TreeIcon_Group.bmp");
            this.imageList1.Images.SetKeyName(1, "TreeIcon_Group_Selected.bmp");
            this.imageList1.Images.SetKeyName(2, "TreeIcon_Summary.bmp");
            this.imageList1.Images.SetKeyName(3, "TreeIcon_Summary_Selected.bmp");
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(395, 40);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 324);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // C_BtnRevertStyle
            // 
            this.C_BtnRevertStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.C_BtnRevertStyle.Location = new System.Drawing.Point(568, 328);
            this.C_BtnRevertStyle.Name = "C_BtnRevertStyle";
            this.C_BtnRevertStyle.Size = new System.Drawing.Size(96, 23);
            this.C_BtnRevertStyle.TabIndex = 4;
            this.C_BtnRevertStyle.Text = "Revert Style";
            this.C_BtnRevertStyle.Click += new System.EventHandler(this.C_BtnRevertStyle_Click);
            // 
            // ConfigGradingGroupInfo
            // 
            this.Controls.Add(this.C_BtnRevertStyle);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.C_GroupInfoTree);
            this.Controls.Add(this.C_PropertyGrid);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigGradingGroupInfo";
            this.Size = new System.Drawing.Size(680, 364);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void C_GroupInfoTree_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            this.C_PropertyGrid.SelectedObject = this.C_GroupInfoTree.SelectedNode.Tag;
        }

        private void ConfigGroupingInfo_Load(object sender, EventArgs e)
        {
            if (this.C_GroupInfoTree.Nodes.Count > 0)
            {
                this.C_PropertyGrid.SelectedObject = this.C_GroupInfoTree.Nodes[0].Tag;
            }
        }

        private void SetView(GroupInfo groupInfo, TreeNode parentNode)
        {
            if (groupInfo == null||!(groupInfo is  FieldGradingInfo)) return;

            TreeNode node = this.CreateGroupNode(groupInfo);

            if (groupInfo.Summaries != null)
            {
                foreach (GroupSummary summary in groupInfo.Summaries)
                {
                    TreeNode summaryNode = this.CreateSummaryNode(summary);

                    node.Nodes.Add(summaryNode);
                }
            }

            foreach (GroupInfo subGroupInfo in groupInfo.SubGroupInfos)
            {
                this.SetView(subGroupInfo, node);
            }

            if (parentNode == null)
            {
                this.C_GroupInfoTree.Nodes.Clear();

                this.C_GroupInfoTree.Nodes.Add(node);
            }
            else
            {
                parentNode.Nodes.Add(node);
            }
        }

        public override void SetView(Webb.Reports.ExControls.Views.ExControlView i_View)
        {
            this.C_GroupInfoTree.Nodes.Clear();

            GradingView m_GradingView = i_View as GradingView;

            SetColumnsWidth(m_GradingView);

            this.C_CheckHeader.Checked = m_GradingView.HaveHeader;

            GroupInfo m_GroupInfo = m_GradingView.RootGroupInfo;           

            this.SetView(m_GroupInfo, null);
        }

        private TreeNode CreateGroupNode(GroupInfo groupInfo)
        {
            TreeNode node = new TreeNode(groupInfo.ToString());

            node.Tag = groupInfo.Copy();

            node.ImageIndex = 0;

            node.SelectedImageIndex = 1;

            return node;
        }

        private TreeNode CreateSummaryNode(GroupSummary summary)
        {
            TreeNode node = new TreeNode(summary.ToString());

            node.Tag = summary.Copy();

            node.ImageIndex = 2;

            node.SelectedImageIndex = 3;

            return node;
        }

        private void UpdateView(GroupInfo groupInfo, TreeNode node)
        {
            if (groupInfo == null || node == null) return;

            if (groupInfo.Summaries != null) groupInfo.Summaries.Clear();

            groupInfo.SubGroupInfos.Clear();

            for (int index = 0; index < node.Nodes.Count; index++)
            {
                TreeNode subNode = node.Nodes[index];

                if (subNode.Tag is GroupSummary)
                {
                    if (groupInfo.Summaries == null) groupInfo.Summaries = new GroupSummaryCollection();

                    groupInfo.Summaries.Add(subNode.Tag as GroupSummary);
                }

                if (subNode.Tag is GroupInfo)
                {
                    groupInfo.SubGroupInfos.Add(subNode.Tag as GroupInfo);

                    this.UpdateView(subNode.Tag as GroupInfo, subNode);
                }
            }
        }

        //begin Edit @simon 08/19/2008
        #region Edit Set  and Update ColumnsWidth
        private void SetColumnsWidth(GradingView i_View)
        {
            if (i_View == null) return;
            if (i_View.ColumnsWidth == null || i_View.ColumnsWidth.Count <= 0) return;
            if (i_View.PrintingTable != null)
            {
                int ColumnsCount = i_View.PrintingTable.GetColumns();
                i_View.ColumnsWidth.Clear();
                Int32Collection ColumnsWidthCopy = new Int32Collection();
                for (int i = 0; i < ColumnsCount; i++)
                {
                    i_View.ColumnsWidth.Add(i_View.PrintingTable.GetColumnWidth(i));
                }


            }
            int nCol = 0;

            if (i_View.ShowRowIndicators)
            {
                nCol++;
            }
            GroupInfo m_GroupInfo = i_View.RootGroupInfo;

            this.SetColumnsWidth(m_GroupInfo, ref nCol, i_View.ColumnsWidth);
        }
        private void SetColumnsWidth(GroupInfo groupInfo, ref int nCol, Int32Collection ColumnsWidth)
        {
            if (groupInfo.FollowSummaries)
            {
                if (groupInfo.Summaries != null)
                {
                    foreach (GroupSummary m_Summary in groupInfo.Summaries)
                    {
                        if (nCol >= ColumnsWidth.Count) return;
                        m_Summary.ColumnWidth = ColumnsWidth[nCol];
                        nCol++;
                    }
                }
            }
            bool visible = GroupInfo.IsVisible(groupInfo);

            if (!groupInfo.DistinctValues && visible)	//if set OnValuePerRow,
            {
                if (nCol >= ColumnsWidth.Count) return;
                groupInfo._ColumnWidth = ColumnsWidth[nCol];
                nCol++;
            }

            if (groupInfo.FollowSummaries)
            { }
            else
            {
                if (groupInfo.Summaries != null)
                {
                    foreach (GroupSummary m_Summary in groupInfo.Summaries)
                    {
                        if (nCol >= ColumnsWidth.Count) return;
                        m_Summary.ColumnWidth = ColumnsWidth[nCol];
                        nCol++;
                    }
                }
            }

            foreach (GroupInfo subGroupInfo in groupInfo.SubGroupInfos)
            {
                SetColumnsWidth(subGroupInfo, ref nCol, ColumnsWidth);
            }
        }

        private void UpdateColumnsWidth(GradingView i_View)
        {
            int nRowIndicatorWidth = 0;

            if (i_View.ShowRowIndicators) nRowIndicatorWidth = i_View.ColumnsWidth[0];

            i_View.ColumnsWidth.Clear();

            if (i_View.ShowRowIndicators)
            {
                i_View.ColumnsWidth.Add(nRowIndicatorWidth);
            }

            this.UpdateColumnsWidth(i_View.RootGroupInfo, i_View.ColumnsWidth);
        }
        private void UpdateColumnsWidth(GroupInfo groupInfo, Int32Collection ColumnsWidth)
        {
            if (groupInfo.ReportScType != ReportScType.Custom)
            {
                groupInfo.UpdateSectionSummaries();
            }

            if (groupInfo.FollowSummaries)
            {
                if (groupInfo.Summaries != null)
                {
                    foreach (GroupSummary m_Summary in groupInfo.Summaries)
                    {
                        ColumnsWidth.Add(m_Summary.ColumnWidth);
                    }
                }
            }

            bool visible = GroupInfo.IsVisible(groupInfo);

            if (!groupInfo.DistinctValues && visible)	//if set OnValuePerRow,
            {
                ColumnsWidth.Add(groupInfo._ColumnWidth);

            }

            if (groupInfo.FollowSummaries)
            { }
            else
            {
                if (groupInfo.Summaries != null)
                {
                    foreach (GroupSummary m_Summary in groupInfo.Summaries)
                    {
                        ColumnsWidth.Add(m_Summary.ColumnWidth);
                    }
                }
            }

            foreach (GroupInfo subGroupInfo in groupInfo.SubGroupInfos)
            {
                UpdateColumnsWidth(subGroupInfo, ColumnsWidth);
            }

        }
        #endregion
        //end Edit
        public override void UpdateView(Webb.Reports.ExControls.Views.ExControlView i_View)
        {
            if (this.C_GroupInfoTree.Nodes.Count <= 0) return;

            GroupInfo m_GroupInfo = this.C_GroupInfoTree.Nodes[0].Tag as GroupInfo;

            this.UpdateView(m_GroupInfo, this.C_GroupInfoTree.Nodes[0]);

            GradingView m_GradingView = i_View as GradingView;

            //begin Edit @simon
            this.UpdateColumnsWidth(m_GradingView);
            //end Edit

            m_GradingView.HaveHeader = this.C_CheckHeader.Checked;

            GroupInfo m_RootGroupInfo = this.C_GroupInfoTree.Nodes[0].Tag as GroupInfo;


            m_GradingView.RootGroupInfo = m_RootGroupInfo;
            
        }

        private void Menu_NewGroup_Click(object sender, System.EventArgs e)
        {
            TreeNode node = this.C_GroupInfoTree.SelectedNode;

            if (node == null) return;

            this.AddGroup(node);
        }      

        private void Menu_NewSummary_Click(object sender, System.EventArgs e)
        {
            Menu_AddSummary_Click(sender, e);
        }

        private void Menu_AddSummary_Click(object sender, System.EventArgs e)
        {
            TreeNode m_Node = this.C_GroupInfoTree.SelectedNode;

            if (m_Node == null) return;

            while (!(m_Node.Tag is GroupInfo))
            {
                m_Node = m_Node.Parent;
            }
            this.AddSummary(m_Node, null);
        }
   
   
        private void Menu_CopySummary_Click(object sender, System.EventArgs e)
        {
            TreeNode node = this.C_GroupInfoTree.SelectedNode;

            if (node == null || !(node.Tag is GroupSummary)) return;

            TreeNode rootNode = this.C_GroupInfoTree.SelectedNode;

            while (!(rootNode.Tag is GroupInfo))
            {
                rootNode = rootNode.Parent;
            }

            GroupSummary newSummary = (node.Tag as GroupSummary).Copy();

            newSummary.ColumnHeading = (node.Tag as GroupSummary).ColumnHeading;

            TreeNode newNode = this.CreateSummaryNode(newSummary);

            bool bFindSubGroup = false;

            int index = 0;

            for (; index < rootNode.Nodes.Count; index++)
            {
                if (rootNode.Nodes[index].Tag is GroupInfo)
                {
                    bFindSubGroup = true;

                    break;
                }
            }

            if (bFindSubGroup || index == rootNode.Nodes.Count)
            {
                rootNode.Nodes.Insert(index, newNode);
            }

            this.C_GroupInfoTree.SelectedNode = node;

            this.C_GroupInfoTree.Focus();
        }

        private void Menu_RemoveGroup_Click(object sender, System.EventArgs e)
        {
            if (this.C_GroupInfoTree.SelectedNode == null) return;

            if (this.C_GroupInfoTree.SelectedNode == this.C_GroupInfoTree.Nodes[0])
            {
                Webb.Utilities.MessageBoxEx.ShowMessage("Cannot remove the root group.");

                return;
            }
            this.C_GroupInfoTree.SelectedNode.Remove();

            this.C_GroupInfoTree.Focus();
        }

        private void Menu_MoveUp_Click(object sender, System.EventArgs e)
        {
            TreeNode m_SelectedNode = this.C_GroupInfoTree.SelectedNode;

            if (m_SelectedNode == null) return;

            int m_Index = m_SelectedNode.Index;

            if (m_Index >= 1)
            {
                TreeNodeCollection m_Nodes = null;

                if (m_SelectedNode.Parent == null)
                {
                    m_Nodes = this.C_GroupInfoTree.Nodes;
                }
                else
                {
                    m_Nodes = m_SelectedNode.Parent.Nodes;
                }

                TreeNode preNode = m_Nodes[m_Index - 1];

                if (m_SelectedNode.Tag is GroupInfo && !(preNode.Tag is GroupInfo)) goto EXIT;

                m_SelectedNode.Remove();

                m_Nodes.Insert(m_Index - 1, m_SelectedNode);
            }
        EXIT:
            {
                this.C_GroupInfoTree.SelectedNode = m_SelectedNode;

                this.C_GroupInfoTree.Focus();
            }
        }

        private void Menu_MoveDown_Click(object sender, System.EventArgs e)
        {
            TreeNode m_SelectedNode = this.C_GroupInfoTree.SelectedNode;

            if (m_SelectedNode == null) return;

            int m_Index = m_SelectedNode.Index;

            TreeNodeCollection m_Nodes = null;

            if (m_SelectedNode.Parent == null)
            {
                m_Nodes = this.C_GroupInfoTree.Nodes;
            }
            else
            {
                m_Nodes = m_SelectedNode.Parent.Nodes;
            }

            if (m_Index < m_Nodes.Count - 1)
            {
                TreeNode nextNode = m_Nodes[m_Index + 1];

                if (m_SelectedNode.Tag is GroupSummary && !(nextNode.Tag is GroupSummary)) goto EXIT;

                m_SelectedNode.Remove();

                m_Nodes.Insert(m_Index + 1, m_SelectedNode);
            }
        EXIT:
            {
                this.C_GroupInfoTree.SelectedNode = m_SelectedNode;

                this.C_GroupInfoTree.Focus();
            }
        }

        private void AddSummary(TreeNode i_ParentNode, SectionFilter secFilter)
        {
            GroupInfo gi = i_ParentNode.Tag as GroupInfo;

            GradingSummary m_Summary = new GradingSummary();

            if (i_ParentNode.Tag is FieldGradingInfo)
            {
                m_Summary.Field = (i_ParentNode.Tag as FieldGradingInfo).GroupByField;
            }
            else
            {
                m_Summary.Field = string.Empty;
            }

            m_Summary.SummaryType = SummaryTypes.Frequence;

            if (secFilter != null)
            {
                m_Summary.Filter = secFilter.Filter.Copy();

                m_Summary.ColumnHeading = secFilter.FilterName;
            }

            TreeNode m_node = this.CreateSummaryNode(m_Summary);

            bool bFindSubGroup = false;

            int index = 0;

            for (; index < i_ParentNode.Nodes.Count; index++)
            {
                if (i_ParentNode.Nodes[index].Tag is GroupInfo)
                {
                    bFindSubGroup = true;

                    break;
                }
            }

            if (bFindSubGroup || index == i_ParentNode.Nodes.Count)
            {
                i_ParentNode.Nodes.Insert(index, m_node);
            }
        }

        private void AddGroup(TreeNode node)
        {
            if (!(node.Tag is GroupInfo)) return;

            FieldGradingInfo m_GroupInfo = new FieldGradingInfo();

            m_GroupInfo.GroupByField = Webb.Data.PublicDBFieldConverter.AvialableFields[0].ToString();

            m_GroupInfo.ColumnHeading = "New Group";

            TreeNode m_Node = this.CreateGroupNode(m_GroupInfo);

            node.Nodes.Add(m_Node);
        }
            


        private void C_GroupInfoTree_BeforeSelect(object sender, System.Windows.Forms.TreeViewCancelEventArgs e)
        {
            e.Node.Text = e.Node.Tag.ToString();
        }

        private void C_GroupInfoTree_Click(object sender, System.EventArgs e)
        {
            if (this.C_GroupInfoTree.SelectedNode != null)
            {
                this.C_GroupInfoTree.SelectedNode.Text = this.C_GroupInfoTree.SelectedNode.Tag.ToString();
            }
        }

        private void GroupData_Changed(object sender, EventArgs e)
        {
            this.C_PropertyGrid.Refresh();
        }

        private void C_GroupInfoTree_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void C_GroupInfoTree_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse position.
            Point targetPoint = this.C_GroupInfoTree.PointToClient(new Point(e.X, e.Y));

            // Select the node at the mouse position.
            this.C_GroupInfoTree.SelectedNode = this.C_GroupInfoTree.GetNodeAt(targetPoint);
        }

        private void C_GroupInfoTree_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
        {
            // Move the dragged node when the left mouse button is used.
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
            // Copy the dragged node when the right mouse button is used.
            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }

        private void C_GroupInfoTree_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = this.C_GroupInfoTree.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = this.C_GroupInfoTree.GetNodeAt(targetPoint);

            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Confirm that the node at the drop location is not 
            // the dragged node or a descendant of the dragged node.
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode) && CheckNode(draggedNode, targetNode))
            {
                // If it is a move operation, remove the node from its current 
                // location and add it to the node at the drop location.
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();

                    this.AddNode(draggedNode, targetNode);
                }
                // If it is a copy operation, clone the dragged node 
                // and add it to the node at the drop location.
                else if (e.Effect == DragDropEffects.Copy && draggedNode.Tag is GroupSummary)
                {
                    GroupSummary summary = (draggedNode.Tag as GroupSummary).Copy();

                    TreeNode node = this.CreateSummaryNode(summary);

                    this.AddNode(node, targetNode);
                }

                // Expand the node at the location 
                // to show the dropped node.
                targetNode.Expand();
            }
        }

        // Determine whether one node is a parent 
        // or ancestor of a second node.
        private bool ContainsNode(TreeNode draggedNode, TreeNode targetNode)
        {
            // Check the parent node of the second node.
            if (targetNode.Parent == null) return false;
            if (targetNode.Parent.Equals(draggedNode)) return true;

            // If the parent node is not null or equal to the first node, 
            // call the ContainsNode method recursively using the parent of 
            // the second node.
            return ContainsNode(draggedNode, targetNode.Parent);
        }

        private void AddNode(TreeNode draggedNode, TreeNode targetNode)
        {
            if (draggedNode.Tag is GroupSummary)
            {
                int index = 0;

                for (; index < targetNode.Nodes.Count; index++)
                {
                    TreeNode node = targetNode.Nodes[index];

                    if (node.Tag is GroupInfo) break;
                }

                targetNode.Nodes.Insert(index, draggedNode);
            }
            else if (draggedNode.Tag is GroupInfo)
            {
                targetNode.Nodes.Add(draggedNode);
            }
        }

        private bool CheckNode(TreeNode draggedNode, TreeNode targetNode)
        {
            bool bRet = true;

            if (targetNode.Tag is GroupSummary) bRet = false;

            return bRet;
        }

        private void C_GroupInfoTree_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {//07-15-2008@Scott
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    this.Menu_RemoveGroup_Click(null, null);
                    break;
                default:
                    break;
            }
        }

        private void C_BtnRevertStyle_Click(object sender, System.EventArgs e)
        {
            TreeNode node = this.C_GroupInfoTree.SelectedNode;

            if (node == null) return;

            if (node.Tag is GroupInfo)
            {
                GroupInfo groupInfo = node.Tag as GroupInfo;

                groupInfo.Style.Revert();
            }

            if (node.Tag is GroupSummary)
            {
                GroupSummary summary = node.Tag as GroupSummary;

                summary.Style.Revert();
            }

            this.C_PropertyGrid.Refresh();
        }
      
    }
}

