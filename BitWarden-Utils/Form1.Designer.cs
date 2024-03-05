namespace BitWarden_Utils
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            gridResults = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            txtFilter = new TextBox();
            btnSearch = new Button();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            itemsToolStripMenuItem = new ToolStripMenuItem();
            mergeToolStripMenuItem1 = new ToolStripMenuItem();
            cleanURLsToolStripMenuItem = new ToolStripMenuItem();
            gbResults = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            gbURIs = new GroupBox();
            gridURIs = new DataGridView();
            URI = new DataGridViewTextBoxColumn();
            ctxMenuStrip = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)gridResults).BeginInit();
            menuStrip.SuspendLayout();
            gbResults.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gbURIs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridURIs).BeginInit();
            SuspendLayout();
            // 
            // gridResults
            // 
            gridResults.AllowUserToAddRows = false;
            gridResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            gridResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridResults.BackgroundColor = Color.White;
            gridResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResults.Columns.AddRange(new DataGridViewColumn[] { colName, colUserName, colPassword });
            gridResults.Dock = DockStyle.Fill;
            gridResults.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridResults.Location = new Point(3, 19);
            gridResults.Name = "gridResults";
            gridResults.ReadOnly = true;
            gridResults.Size = new Size(563, 361);
            gridResults.TabIndex = 0;
            gridResults.SelectionChanged += gridResults_SelectionChanged;
            // 
            // colName
            // 
            colName.DataPropertyName = "name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 64;
            // 
            // colUserName
            // 
            colUserName.DataPropertyName = "loginUsername";
            colUserName.HeaderText = "UserName";
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            colUserName.Width = 87;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "loginPassword";
            colPassword.HeaderText = "Password";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            colPassword.Width = 82;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(12, 27);
            txtFilter.Name = "txtFilter";
            txtFilter.PlaceholderText = "Filter";
            txtFilter.Size = new Size(530, 23);
            txtFilter.TabIndex = 1;
            txtFilter.KeyPress += txtFilter_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(548, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, itemsToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1151, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(113, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // itemsToolStripMenuItem
            // 
            itemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mergeToolStripMenuItem1, cleanURLsToolStripMenuItem });
            itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            itemsToolStripMenuItem.Size = new Size(48, 20);
            itemsToolStripMenuItem.Text = "Items";
            // 
            // mergeToolStripMenuItem1
            // 
            mergeToolStripMenuItem1.Name = "mergeToolStripMenuItem1";
            mergeToolStripMenuItem1.Size = new Size(127, 22);
            mergeToolStripMenuItem1.Text = "Merge";
            mergeToolStripMenuItem1.Click += mergeToolStripMenuItem_Click;
            // 
            // cleanURLsToolStripMenuItem
            // 
            cleanURLsToolStripMenuItem.Name = "cleanURLsToolStripMenuItem";
            cleanURLsToolStripMenuItem.Size = new Size(127, 22);
            cleanURLsToolStripMenuItem.Text = "CleanURIs";
            cleanURLsToolStripMenuItem.Click += cleanURIsToolStripMenuItem_Click;
            // 
            // gbResults
            // 
            gbResults.Controls.Add(gridResults);
            gbResults.Dock = DockStyle.Fill;
            gbResults.Location = new Point(3, 3);
            gbResults.Name = "gbResults";
            gbResults.Size = new Size(569, 383);
            gbResults.TabIndex = 4;
            gbResults.TabStop = false;
            gbResults.Text = "Results";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(gbResults, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1151, 389);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(gbURIs, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(578, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.6370773F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 67.36292F));
            tableLayoutPanel2.Size = new Size(570, 383);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // gbURIs
            // 
            gbURIs.Controls.Add(gridURIs);
            gbURIs.Dock = DockStyle.Fill;
            gbURIs.Location = new Point(3, 128);
            gbURIs.Name = "gbURIs";
            gbURIs.Size = new Size(564, 252);
            gbURIs.TabIndex = 5;
            gbURIs.TabStop = false;
            gbURIs.Text = "URIs";
            // 
            // gridURIs
            // 
            gridURIs.AllowUserToAddRows = false;
            gridURIs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HotTrack;
            gridURIs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            gridURIs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridURIs.BackgroundColor = Color.White;
            gridURIs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridURIs.Columns.AddRange(new DataGridViewColumn[] { URI });
            gridURIs.Dock = DockStyle.Fill;
            gridURIs.Location = new Point(3, 19);
            gridURIs.Name = "gridURIs";
            gridURIs.ReadOnly = true;
            gridURIs.Size = new Size(558, 230);
            gridURIs.TabIndex = 0;
            // 
            // URI
            // 
            URI.DataPropertyName = "uri";
            URI.HeaderText = "URI";
            URI.Name = "URI";
            URI.ReadOnly = true;
            URI.Width = 50;
            // 
            // ctxMenuStrip
            // 
            ctxMenuStrip.Name = "ctxMenuStrip";
            ctxMenuStrip.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 445);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSearch);
            Controls.Add(txtFilter);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)gridResults).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            gbResults.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            gbURIs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridURIs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridResults;
        private TextBox txtFilter;
        private Button btnSearch;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private GroupBox gbResults;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gbURIs;
        private DataGridView gridURIs;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private ContextMenuStrip ctxMenuStrip;
        private ToolStripMenuItem itemsToolStripMenuItem;
        private ToolStripMenuItem mergeToolStripMenuItem1;
        private ToolStripMenuItem cleanURLsToolStripMenuItem;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn URI;
    }
}
