namespace Velocity.Frontend
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            dataGridView1 = new DataGridView();
            New = new ToolStripButton();
            Refresh = new ToolStripButton();
            Exit = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            Sno = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            IsCustomer = new DataGridViewCheckBoxColumn();
            IsVendor = new DataGridViewCheckBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Sno, Name, Description, IsCustomer, IsVendor, Edit, Delete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 423);
            dataGridView1.TabIndex = 3;
            // 
            // New
            // 
            New.AccessibleName = "";
            New.Image = (Image)resources.GetObject("New.Image");
            New.ImageTransparentColor = Color.Magenta;
            New.Name = "New";
            New.Size = new Size(63, 24);
            New.Text = "New";
            New.ToolTipText = "toolStripButton1";
            // 
            // Refresh
            // 
            Refresh.Image = (Image)resources.GetObject("Refresh.Image");
            Refresh.ImageTransparentColor = Color.Magenta;
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(82, 24);
            Refresh.Text = "Refresh";
            // 
            // Exit
            // 
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.ImageTransparentColor = Color.Magenta;
            Exit.Name = "Exit";
            Exit.Size = new Size(57, 24);
            Exit.Text = "Exit";
            Exit.Click += Exit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { New, Refresh, Exit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // Sno
            // 
            Sno.HeaderText = "#";
            Sno.MinimumWidth = 6;
            Sno.Name = "Sno";
            Sno.ReadOnly = true;
            Sno.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            Name.Width = 125;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // IsCustomer
            // 
            IsCustomer.HeaderText = "Customer";
            IsCustomer.MinimumWidth = 6;
            IsCustomer.Name = "IsCustomer";
            IsCustomer.ReadOnly = true;
            IsCustomer.Width = 125;
            // 
            // IsVendor
            // 
            IsVendor.HeaderText = "Vendor";
            IsVendor.MinimumWidth = 6;
            IsVendor.Name = "IsVendor";
            IsVendor.ReadOnly = true;
            IsVendor.Width = 125;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 125;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStripButton New;
        private ToolStripButton Refresh;
        private ToolStripButton Exit;
        private ToolStrip toolStrip1;
        private DataGridViewTextBoxColumn Sno;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewCheckBoxColumn IsCustomer;
        private DataGridViewCheckBoxColumn IsVendor;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}