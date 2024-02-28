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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gridResults = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            txtFilter = new TextBox();
            btnSearch = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mergeToolStripMenuItem = new ToolStripMenuItem();
            gbResults = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            gbURLs = new GroupBox();
            gridURLs = new DataGridView();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)gridResults).BeginInit();
            menuStrip1.SuspendLayout();
            gbResults.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            gbURLs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridURLs).BeginInit();
            SuspendLayout();
            // 
            // gridResults
            // 
            gridResults.AllowUserToAddRows = false;
            gridResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            gridResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            // 
            // colUserName
            // 
            colUserName.DataPropertyName = "loginUsername";
            colUserName.HeaderText = "UserName";
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "loginPassword";
            colPassword.HeaderText = "Passwrod";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1151, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mergeToolStripMenuItem, refreshToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // mergeToolStripMenuItem
            // 
            mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            mergeToolStripMenuItem.Size = new Size(180, 22);
            mergeToolStripMenuItem.Text = "Merge";
            mergeToolStripMenuItem.Click += mergeToolStripMenuItem_Click;
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
            tableLayoutPanel2.Controls.Add(gbURLs, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(578, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.6370773F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 67.36292F));
            tableLayoutPanel2.Size = new Size(570, 383);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // gbURLs
            // 
            gbURLs.Controls.Add(gridURLs);
            gbURLs.Dock = DockStyle.Fill;
            gbURLs.Location = new Point(3, 128);
            gbURLs.Name = "gbURLs";
            gbURLs.Size = new Size(564, 252);
            gbURLs.TabIndex = 5;
            gbURLs.TabStop = false;
            gbURLs.Text = "URLs";
            // 
            // gridURLs
            // 
            gridURLs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridURLs.Dock = DockStyle.Fill;
            gridURLs.Location = new Point(3, 19);
            gridURLs.Name = "gridURLs";
            gridURLs.Size = new Size(558, 230);
            gridURLs.TabIndex = 0;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(180, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 445);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSearch);
            Controls.Add(txtFilter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)gridResults).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gbResults.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            gbURLs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridURLs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridResults;
        private TextBox txtFilter;
        private Button btnSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mergeToolStripMenuItem;
        private GroupBox gbResults;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colPassword;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox gbURLs;
        private DataGridView gridURLs;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}
