using System;

namespace Tablesheet
{
    partial class Timesheet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbJobCode = new System.Windows.Forms.ComboBox();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.cbActivity = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBreak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobAdmin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripEmpName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripNextShift = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(789, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 48);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbJobCode
            // 
            this.cbJobCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobCode.FormattingEnabled = true;
            this.cbJobCode.Location = new System.Drawing.Point(93, 50);
            this.cbJobCode.Name = "cbJobCode";
            this.cbJobCode.Size = new System.Drawing.Size(75, 21);
            this.cbJobCode.TabIndex = 2;
            this.cbJobCode.SelectedIndexChanged += new System.EventHandler(this.cbJobCode_SelectedIndexChanged);
            // 
            // cbAccount
            // 
            this.cbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(174, 50);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(91, 21);
            this.cbAccount.TabIndex = 3;
            // 
            // cbActivity
            // 
            this.cbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivity.FormattingEnabled = true;
            this.cbActivity.Location = new System.Drawing.Point(271, 50);
            this.cbActivity.Name = "cbActivity";
            this.cbActivity.Size = new System.Drawing.Size(91, 21);
            this.cbActivity.TabIndex = 4;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(580, 51);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(107, 20);
            this.txtComment.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(693, 48);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(51, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnBreak
            // 
            this.btnBreak.Location = new System.Drawing.Point(750, 48);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(51, 23);
            this.btnBreak.TabIndex = 7;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Comments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Job Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Activity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Account";
            // 
            // txtJobAdmin
            // 
            this.txtJobAdmin.Location = new System.Drawing.Point(368, 51);
            this.txtJobAdmin.Name = "txtJobAdmin";
            this.txtJobAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtJobAdmin.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Job Admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Deadline";
            // 
            // txtDeadline
            // 
            this.txtDeadline.Location = new System.Drawing.Point(474, 51);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.ReadOnly = true;
            this.txtDeadline.Size = new System.Drawing.Size(100, 20);
            this.txtDeadline.TabIndex = 16;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripEmpName,
            this.stripStatus,
            this.stripNextShift});
            this.statusStrip1.Location = new System.Drawing.Point(0, 297);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(813, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripEmpName
            // 
            this.stripEmpName.Name = "stripEmpName";
            this.stripEmpName.Size = new System.Drawing.Size(63, 17);
            this.stripEmpName.Text = "EmpName";
            // 
            // stripNextShift
            // 
            this.stripNextShift.Name = "stripNextShift";
            this.stripNextShift.Size = new System.Drawing.Size(55, 17);
            this.stripNextShift.Text = "NextShift";
            this.stripNextShift.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stripStatus
            // 
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(39, 17);
            this.stripStatus.Text = "Status";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // Timesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 319);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJobAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cbActivity);
            this.Controls.Add(this.cbAccount);
            this.Controls.Add(this.cbJobCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Timesheet";
            this.Text = "Timesheet";
            this.Load += new System.EventHandler(this.Timesheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.ComboBox cbActivity;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJobAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbJobCode;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripEmpName;
        private System.Windows.Forms.ToolStripStatusLabel stripNextShift;
        private System.Windows.Forms.ToolStripStatusLabel stripStatus;
        private System.Windows.Forms.Button btnOpen;
    }
}