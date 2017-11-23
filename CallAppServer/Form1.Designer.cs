namespace CallAppServer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwakenColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CalledColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CallColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EemergencyColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SetButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.AwakenColumn,
            this.CalledColumn,
            this.CallColumn,
            this.EemergencyColumn,
            this.SetButtonColumn,
            this.TextColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(727, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 67;
            // 
            // AwakenColumn
            // 
            this.AwakenColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AwakenColumn.HeaderText = "Waken";
            this.AwakenColumn.Name = "AwakenColumn";
            this.AwakenColumn.ReadOnly = true;
            this.AwakenColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AwakenColumn.Width = 52;
            // 
            // CalledColumn
            // 
            this.CalledColumn.HeaderText = "Called";
            this.CalledColumn.Name = "CalledColumn";
            this.CalledColumn.ReadOnly = true;
            this.CalledColumn.Width = 48;
            // 
            // CallColumn
            // 
            this.CallColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CallColumn.HeaderText = "Call";
            this.CallColumn.Name = "CallColumn";
            this.CallColumn.ReadOnly = true;
            this.CallColumn.Width = 34;
            // 
            // EemergencyColumn
            // 
            this.EemergencyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EemergencyColumn.HeaderText = "EMG";
            this.EemergencyColumn.Name = "EemergencyColumn";
            this.EemergencyColumn.Width = 39;
            // 
            // SetButtonColumn
            // 
            this.SetButtonColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SetButtonColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.SetButtonColumn.HeaderText = "";
            this.SetButtonColumn.Name = "SetButtonColumn";
            this.SetButtonColumn.Text = "";
            this.SetButtonColumn.Width = 22;
            // 
            // TextColumn
            // 
            this.TextColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextColumn.HeaderText = "Text";
            this.TextColumn.Name = "TextColumn";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(751, 362);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "CallAppServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AwakenColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CalledColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CallColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EemergencyColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SetButtonColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextColumn;
    }
}

