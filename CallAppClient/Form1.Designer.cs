namespace CallAppClient
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
            this.labelCall = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CloseButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelCall
            // 
            this.labelCall.AutoSize = true;
            this.labelCall.BackColor = System.Drawing.Color.Transparent;
            this.labelCall.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCall.Location = new System.Drawing.Point(115, 125);
            this.labelCall.Name = "labelCall";
            this.labelCall.Size = new System.Drawing.Size(638, 122);
            this.labelCall.TabIndex = 0;
            this.labelCall.Text = "Calling You!!";
            this.labelCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseButton.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(12, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(261, 239);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.labelCall);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Font = new System.Drawing.Font("Meiryo UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Timer timer2;
    }
}

