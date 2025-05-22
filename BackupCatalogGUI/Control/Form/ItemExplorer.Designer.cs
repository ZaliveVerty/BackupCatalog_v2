
namespace BackupCatalogGUI {
    partial class ItemExplorer {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemExplorer));
            this.MenuStrip = new CustomDialogs.DarkContextMenuStrip(this.components);
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGroupSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.NewFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItemBundleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.UpdateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.SetDestinationFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetDestinationFolderSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.MoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ViewUpdateHistoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GlobalContainer = new System.Windows.Forms.TableLayoutPanel();
            this.BottomContainer = new System.Windows.Forms.TableLayoutPanel();
            this.CloseSeperatorLabel = new CustomDialogs.DarkLabel();
            this.UpdateSchemesButton = new System.Windows.Forms.Button();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.InformationSeperator = new CustomDialogs.DarkLabel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AmountOfItemsLabel = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.GlobalContainer.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MenuStrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.NewSeperator,
            this.UpdateMenuItem,
            this.UpdateSeperator,
            this.SetDestinationFolderMenuItem,
            this.SetDestinationFolderSeperator,
            this.CopyMenuItem,
            this.PasteMenuItem,
            this.PasteSeperator,
            this.MoveMenuItem,
            this.EditMenuItem,
            this.DeleteMenuItem,
            this.DeleteSeperator,
            this.ViewUpdateHistoryMenuItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(195, 232);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGroupMenuitem,
            this.NewGroupSeperator,
            this.NewFolderMenuItem,
            this.NewItemBundleMenuItem});
            this.NewMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._16pxAdd;
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(194, 22);
            this.NewMenuItem.Text = "New                                ";
            // 
            // NewGroupMenuitem
            // 
            this.NewGroupMenuitem.Image = global::BackupCatalogGUI.Properties.Resources._22pxLargeGroup;
            this.NewGroupMenuitem.Name = "NewGroupMenuitem";
            this.NewGroupMenuitem.Size = new System.Drawing.Size(191, 22);
            this.NewGroupMenuitem.Text = "Group                            ";
            this.NewGroupMenuitem.Click += new System.EventHandler(this.NewGroupMenuitem_Click);
            // 
            // NewGroupSeperator
            // 
            this.NewGroupSeperator.Name = "NewGroupSeperator";
            this.NewGroupSeperator.Size = new System.Drawing.Size(188, 6);
            // 
            // NewFolderMenuItem
            // 
            this.NewFolderMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._64pxDirectory;
            this.NewFolderMenuItem.Name = "NewFolderMenuItem";
            this.NewFolderMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NewFolderMenuItem.Text = "Folder";
            this.NewFolderMenuItem.Click += new System.EventHandler(this.NewFolderMenuItem_Click);
            // 
            // NewItemBundleMenuItem
            // 
            this.NewItemBundleMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._64pxDirectoryBundle;
            this.NewItemBundleMenuItem.Name = "NewItemBundleMenuItem";
            this.NewItemBundleMenuItem.Size = new System.Drawing.Size(191, 22);
            this.NewItemBundleMenuItem.Text = "Item Bundle";
            this.NewItemBundleMenuItem.Click += new System.EventHandler(this.NewItemBundleMenuItem_Click);
            // 
            // NewSeperator
            // 
            this.NewSeperator.Name = "NewSeperator";
            this.NewSeperator.Size = new System.Drawing.Size(191, 6);
            // 
            // UpdateMenuItem
            // 
            this.UpdateMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._16pxUpload;
            this.UpdateMenuItem.Name = "UpdateMenuItem";
            this.UpdateMenuItem.Size = new System.Drawing.Size(194, 22);
            this.UpdateMenuItem.Text = "Update";
            this.UpdateMenuItem.Click += new System.EventHandler(this.UpdateMenuItem_Click);
            // 
            // UpdateSeperator
            // 
            this.UpdateSeperator.Name = "UpdateSeperator";
            this.UpdateSeperator.Size = new System.Drawing.Size(191, 6);
            // 
            // SetDestinationFolderMenuItem
            // 
            this.SetDestinationFolderMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._16pxTreeView;
            this.SetDestinationFolderMenuItem.Name = "SetDestinationFolderMenuItem";
            this.SetDestinationFolderMenuItem.Size = new System.Drawing.Size(194, 22);
            this.SetDestinationFolderMenuItem.Text = "Set destination folder";
            this.SetDestinationFolderMenuItem.Click += new System.EventHandler(this.SetDestinationFolderMenuItem_Click);
            // 
            // SetDestinationFolderSeperator
            // 
            this.SetDestinationFolderSeperator.Name = "SetDestinationFolderSeperator";
            this.SetDestinationFolderSeperator.Size = new System.Drawing.Size(191, 6);
            // 
            // CopyMenuItem
            // 
            this.CopyMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._16pxCopyItem;
            this.CopyMenuItem.Name = "CopyMenuItem";
            this.CopyMenuItem.Size = new System.Drawing.Size(194, 22);
            this.CopyMenuItem.Text = "Copy";
            this.CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // PasteMenuItem
            // 
            this.PasteMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._16pxPaste;
            this.PasteMenuItem.Name = "PasteMenuItem";
            this.PasteMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PasteMenuItem.Text = "Paste";
            this.PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // PasteSeperator
            // 
            this.PasteSeperator.Name = "PasteSeperator";
            this.PasteSeperator.Size = new System.Drawing.Size(191, 6);
            // 
            // MoveMenuItem
            // 
            this.MoveMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._64pxMove;
            this.MoveMenuItem.Name = "MoveMenuItem";
            this.MoveMenuItem.Size = new System.Drawing.Size(194, 22);
            this.MoveMenuItem.Text = "Move";
            this.MoveMenuItem.Click += new System.EventHandler(this.MoveMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._16pxEdit;
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(194, 22);
            this.EditMenuItem.Text = "Edit";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._16pxTrash;
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.Size = new System.Drawing.Size(194, 22);
            this.DeleteMenuItem.Text = "Delete";
            this.DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // DeleteSeperator
            // 
            this.DeleteSeperator.Name = "DeleteSeperator";
            this.DeleteSeperator.Size = new System.Drawing.Size(191, 6);
            // 
            // ViewUpdateHistoryMenuItem
            // 
            this.ViewUpdateHistoryMenuItem.Image = global::BackupCatalogGUI.Properties.Resources._64pxCalendar;
            this.ViewUpdateHistoryMenuItem.Name = "ViewUpdateHistoryMenuItem";
            this.ViewUpdateHistoryMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ViewUpdateHistoryMenuItem.Text = "View update history";
            this.ViewUpdateHistoryMenuItem.Click += new System.EventHandler(this.ViewUpdateHistoryMenuItem_Click);
            // 
            // GlobalContainer
            // 
            this.GlobalContainer.ColumnCount = 1;
            this.GlobalContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.Controls.Add(this.BottomContainer, 0, 1);
            this.GlobalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalContainer.Location = new System.Drawing.Point(0, 0);
            this.GlobalContainer.Margin = new System.Windows.Forms.Padding(0);
            this.GlobalContainer.Name = "GlobalContainer";
            this.GlobalContainer.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.GlobalContainer.RowCount = 1;
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GlobalContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GlobalContainer.Size = new System.Drawing.Size(916, 523);
            this.GlobalContainer.TabIndex = 3;
            // 
            // BottomContainer
            // 
            this.BottomContainer.AutoSize = true;
            this.BottomContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomContainer.ColumnCount = 8;
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BottomContainer.Controls.Add(this.CloseSeperatorLabel, 5, 0);
            this.BottomContainer.Controls.Add(this.UpdateSchemesButton, 4, 0);
            this.BottomContainer.Controls.Add(this.DeselectButton, 6, 0);
            this.BottomContainer.Controls.Add(this.InformationSeperator, 3, 0);
            this.BottomContainer.Controls.Add(this.MoveDownButton, 2, 0);
            this.BottomContainer.Controls.Add(this.MoveUpButton, 1, 0);
            this.BottomContainer.Controls.Add(this.CloseButton, 7, 0);
            this.BottomContainer.Controls.Add(this.AmountOfItemsLabel, 0, 0);
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomContainer.Location = new System.Drawing.Point(7, 498);
            this.BottomContainer.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.RowCount = 1;
            this.BottomContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomContainer.Size = new System.Drawing.Size(902, 23);
            this.BottomContainer.TabIndex = 3;
            // 
            // CloseSeperatorLabel
            // 
            this.CloseSeperatorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseSeperatorLabel.AutoSize = true;
            this.CloseSeperatorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.CloseSeperatorLabel.Location = new System.Drawing.Point(790, 3);
            this.CloseSeperatorLabel.Margin = new System.Windows.Forms.Padding(9, 0, 7, 1);
            this.CloseSeperatorLabel.Name = "CloseSeperatorLabel";
            this.CloseSeperatorLabel.Size = new System.Drawing.Size(10, 15);
            this.CloseSeperatorLabel.TabIndex = 8;
            this.CloseSeperatorLabel.Text = "|";
            // 
            // UpdateSchemesButton
            // 
            this.UpdateSchemesButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UpdateSchemesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.UpdateSchemesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSchemesButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateSchemesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UpdateSchemesButton.Image = global::BackupCatalogGUI.Properties.Resources._16pxUpload;
            this.UpdateSchemesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateSchemesButton.Location = new System.Drawing.Point(661, 0);
            this.UpdateSchemesButton.Margin = new System.Windows.Forms.Padding(0);
            this.UpdateSchemesButton.Name = "UpdateSchemesButton";
            this.UpdateSchemesButton.Size = new System.Drawing.Size(120, 23);
            this.UpdateSchemesButton.TabIndex = 10;
            this.UpdateSchemesButton.Text = "Update schemes";
            this.UpdateSchemesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateSchemesButton.UseVisualStyleBackColor = false;
            this.UpdateSchemesButton.Click += new System.EventHandler(this.UpdateSchemesButton_Click);
            // 
            // DeselectButton
            // 
            this.DeselectButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DeselectButton.BackgroundImage = global::BackupCatalogGUI.Properties.Resources._16pxDeselect;
            this.DeselectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeselectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DeselectButton.FlatAppearance.BorderSize = 0;
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeselectButton.Location = new System.Drawing.Point(807, 0);
            this.DeselectButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(23, 23);
            this.DeselectButton.TabIndex = 11;
            this.DeselectButton.UseVisualStyleBackColor = false;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // InformationSeperator
            // 
            this.InformationSeperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InformationSeperator.AutoSize = true;
            this.InformationSeperator.ForeColor = System.Drawing.Color.DarkGray;
            this.InformationSeperator.Location = new System.Drawing.Point(643, 3);
            this.InformationSeperator.Margin = new System.Windows.Forms.Padding(9, 0, 8, 1);
            this.InformationSeperator.Name = "InformationSeperator";
            this.InformationSeperator.Size = new System.Drawing.Size(10, 15);
            this.InformationSeperator.TabIndex = 12;
            this.InformationSeperator.Text = "|";
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveDownButton.BackgroundImage = global::BackupCatalogGUI.Properties.Resources._16pxMoveDown;
            this.MoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveDownButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveDownButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveDownButton.Location = new System.Drawing.Point(611, 0);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(23, 23);
            this.MoveDownButton.TabIndex = 13;
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MoveUpButton.BackgroundImage = global::BackupCatalogGUI.Properties.Resources._16pxMoveUp;
            this.MoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MoveUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveUpButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoveUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveUpButton.Location = new System.Drawing.Point(581, 0);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(23, 23);
            this.MoveUpButton.TabIndex = 14;
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(837, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AmountOfItemsLabel
            // 
            this.AmountOfItemsLabel.AutoSize = true;
            this.AmountOfItemsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AmountOfItemsLabel.Location = new System.Drawing.Point(0, 4);
            this.AmountOfItemsLabel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.AmountOfItemsLabel.Name = "AmountOfItemsLabel";
            this.AmountOfItemsLabel.Size = new System.Drawing.Size(39, 15);
            this.AmountOfItemsLabel.TabIndex = 16;
            this.AmountOfItemsLabel.Text = "Items:";
            // 
            // ItemExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(916, 523);
            this.Controls.Add(this.GlobalContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Catalog";
            this.Load += new System.EventHandler(this.ItemExplorer_Load);
            this.MenuStrip.ResumeLayout(false);
            this.GlobalContainer.ResumeLayout(false);
            this.GlobalContainer.PerformLayout();
            this.BottomContainer.ResumeLayout(false);
            this.BottomContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDialogs.DarkContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewGroupMenuitem;
        private System.Windows.Forms.ToolStripSeparator NewGroupSeperator;
        private System.Windows.Forms.ToolStripMenuItem NewFolderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewItemBundleMenuItem;
        private System.Windows.Forms.ToolStripSeparator NewSeperator;
        private System.Windows.Forms.ToolStripMenuItem UpdateMenuItem;
        private System.Windows.Forms.ToolStripSeparator UpdateSeperator;
        private System.Windows.Forms.ToolStripMenuItem SetDestinationFolderMenuItem;
        private System.Windows.Forms.ToolStripSeparator SetDestinationFolderSeperator;
        private System.Windows.Forms.ToolStripMenuItem CopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator PasteSeperator;
        private System.Windows.Forms.ToolStripMenuItem MoveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripSeparator DeleteSeperator;
        private System.Windows.Forms.ToolStripMenuItem ViewUpdateHistoryMenuItem;
        private System.Windows.Forms.TableLayoutPanel GlobalContainer;
        private System.Windows.Forms.TableLayoutPanel BottomContainer;
        private CustomDialogs.DarkLabel CloseSeperatorLabel;
        private System.Windows.Forms.Button UpdateSchemesButton;
        private System.Windows.Forms.Button DeselectButton;
        private CustomDialogs.DarkLabel InformationSeperator;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label AmountOfItemsLabel;
    }
}

