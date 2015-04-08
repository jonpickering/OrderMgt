namespace OrderMgt
{
    partial class UpdateOrderForm
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
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.btnOrderSearch = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.grpPlanning = new System.Windows.Forms.GroupBox();
            this.chkRejected = new System.Windows.Forms.CheckBox();
            this.lblPlanningRejected = new System.Windows.Forms.Label();
            this.chkPlanningPay = new System.Windows.Forms.CheckBox();
            this.chkPlanning = new System.Windows.Forms.CheckBox();
            this.lblPlanningPay = new System.Windows.Forms.Label();
            this.lblPlanningGranted = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFoundationDate = new System.Windows.Forms.DateTimePicker();
            this.lblFoundationDate = new System.Windows.Forms.Label();
            this.chkFullPayment = new System.Windows.Forms.CheckBox();
            this.lblFullPayment = new System.Windows.Forms.Label();
            this.chkContract = new System.Windows.Forms.CheckBox();
            this.lblContract = new System.Windows.Forms.Label();
            this.picSidePanel = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.grpOrders.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpPlanning.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrders
            // 
            this.grpOrders.Controls.Add(this.txtOrderNum);
            this.grpOrders.Controls.Add(this.lblOrderNum);
            this.grpOrders.Controls.Add(this.btnOrderSearch);
            this.grpOrders.Location = new System.Drawing.Point(159, 12);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(546, 67);
            this.grpOrders.TabIndex = 9;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Order Search";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(135, 30);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(136, 20);
            this.txtOrderNum.TabIndex = 2;
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(38, 35);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(76, 13);
            this.lblOrderNum.TabIndex = 1;
            this.lblOrderNum.Text = "Order Number:";
            // 
            // btnOrderSearch
            // 
            this.btnOrderSearch.Location = new System.Drawing.Point(316, 27);
            this.btnOrderSearch.Name = "btnOrderSearch";
            this.btnOrderSearch.Size = new System.Drawing.Size(75, 23);
            this.btnOrderSearch.TabIndex = 0;
            this.btnOrderSearch.Text = "Search";
            this.btnOrderSearch.UseVisualStyleBackColor = true;
            this.btnOrderSearch.Click += new System.EventHandler(this.btnOrderSearch_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblStatus);
            this.grpSummary.Controls.Add(this.lblOrderStatus);
            this.grpSummary.Location = new System.Drawing.Point(159, 85);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(546, 143);
            this.grpSummary.TabIndex = 10;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(126, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(41, 31);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(69, 13);
            this.lblOrderStatus.TabIndex = 0;
            this.lblOrderStatus.Text = "Order Status:";
            // 
            // grpPlanning
            // 
            this.grpPlanning.Controls.Add(this.chkRejected);
            this.grpPlanning.Controls.Add(this.lblPlanningRejected);
            this.grpPlanning.Controls.Add(this.chkPlanningPay);
            this.grpPlanning.Controls.Add(this.chkPlanning);
            this.grpPlanning.Controls.Add(this.lblPlanningPay);
            this.grpPlanning.Controls.Add(this.lblPlanningGranted);
            this.grpPlanning.Location = new System.Drawing.Point(159, 234);
            this.grpPlanning.Name = "grpPlanning";
            this.grpPlanning.Size = new System.Drawing.Size(546, 79);
            this.grpPlanning.TabIndex = 11;
            this.grpPlanning.TabStop = false;
            this.grpPlanning.Text = "Planning";
            // 
            // chkRejected
            // 
            this.chkRejected.AutoSize = true;
            this.chkRejected.Location = new System.Drawing.Point(127, 53);
            this.chkRejected.Name = "chkRejected";
            this.chkRejected.Size = new System.Drawing.Size(15, 14);
            this.chkRejected.TabIndex = 5;
            this.chkRejected.UseVisualStyleBackColor = true;
            this.chkRejected.CheckedChanged += new System.EventHandler(this.chkRejected_CheckedChanged);
            // 
            // lblPlanningRejected
            // 
            this.lblPlanningRejected.AutoSize = true;
            this.lblPlanningRejected.Location = new System.Drawing.Point(16, 54);
            this.lblPlanningRejected.Name = "lblPlanningRejected";
            this.lblPlanningRejected.Size = new System.Drawing.Size(100, 13);
            this.lblPlanningRejected.TabIndex = 4;
            this.lblPlanningRejected.Text = "Planning Rejected: ";
            // 
            // chkPlanningPay
            // 
            this.chkPlanningPay.AutoSize = true;
            this.chkPlanningPay.Location = new System.Drawing.Point(403, 30);
            this.chkPlanningPay.Name = "chkPlanningPay";
            this.chkPlanningPay.Size = new System.Drawing.Size(15, 14);
            this.chkPlanningPay.TabIndex = 3;
            this.chkPlanningPay.UseVisualStyleBackColor = true;
            // 
            // chkPlanning
            // 
            this.chkPlanning.AutoSize = true;
            this.chkPlanning.Location = new System.Drawing.Point(127, 30);
            this.chkPlanning.Name = "chkPlanning";
            this.chkPlanning.Size = new System.Drawing.Size(15, 14);
            this.chkPlanning.TabIndex = 2;
            this.chkPlanning.UseVisualStyleBackColor = true;
            this.chkPlanning.CheckedChanged += new System.EventHandler(this.chkPlanning_CheckedChanged);
            // 
            // lblPlanningPay
            // 
            this.lblPlanningPay.AutoSize = true;
            this.lblPlanningPay.Location = new System.Drawing.Point(293, 30);
            this.lblPlanningPay.Name = "lblPlanningPay";
            this.lblPlanningPay.Size = new System.Drawing.Size(103, 13);
            this.lblPlanningPay.TabIndex = 1;
            this.lblPlanningPay.Text = "Payment Recieved: ";
            // 
            // lblPlanningGranted
            // 
            this.lblPlanningGranted.AutoSize = true;
            this.lblPlanningGranted.Location = new System.Drawing.Point(16, 30);
            this.lblPlanningGranted.Name = "lblPlanningGranted";
            this.lblPlanningGranted.Size = new System.Drawing.Size(95, 13);
            this.lblPlanningGranted.TabIndex = 0;
            this.lblPlanningGranted.Text = "Planning Granted: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFoundationDate);
            this.groupBox2.Controls.Add(this.lblFoundationDate);
            this.groupBox2.Controls.Add(this.chkFullPayment);
            this.groupBox2.Controls.Add(this.lblFullPayment);
            this.groupBox2.Controls.Add(this.chkContract);
            this.groupBox2.Controls.Add(this.lblContract);
            this.groupBox2.Location = new System.Drawing.Point(159, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(546, 88);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract and Payment";
            // 
            // dtpFoundationDate
            // 
            this.dtpFoundationDate.Location = new System.Drawing.Point(114, 56);
            this.dtpFoundationDate.Name = "dtpFoundationDate";
            this.dtpFoundationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFoundationDate.TabIndex = 9;
            // 
            // lblFoundationDate
            // 
            this.lblFoundationDate.AutoSize = true;
            this.lblFoundationDate.Location = new System.Drawing.Point(16, 56);
            this.lblFoundationDate.Name = "lblFoundationDate";
            this.lblFoundationDate.Size = new System.Drawing.Size(92, 13);
            this.lblFoundationDate.TabIndex = 8;
            this.lblFoundationDate.Text = "Foundation Date: ";
            // 
            // chkFullPayment
            // 
            this.chkFullPayment.AutoSize = true;
            this.chkFullPayment.Location = new System.Drawing.Point(406, 26);
            this.chkFullPayment.Name = "chkFullPayment";
            this.chkFullPayment.Size = new System.Drawing.Size(15, 14);
            this.chkFullPayment.TabIndex = 7;
            this.chkFullPayment.UseVisualStyleBackColor = true;
            // 
            // lblFullPayment
            // 
            this.lblFullPayment.AutoSize = true;
            this.lblFullPayment.Location = new System.Drawing.Point(297, 26);
            this.lblFullPayment.Name = "lblFullPayment";
            this.lblFullPayment.Size = new System.Drawing.Size(103, 13);
            this.lblFullPayment.TabIndex = 6;
            this.lblFullPayment.Text = "Payment Recieved: ";
            // 
            // chkContract
            // 
            this.chkContract.AutoSize = true;
            this.chkContract.Location = new System.Drawing.Point(127, 26);
            this.chkContract.Name = "chkContract";
            this.chkContract.Size = new System.Drawing.Size(15, 14);
            this.chkContract.TabIndex = 5;
            this.chkContract.UseVisualStyleBackColor = true;
            this.chkContract.CheckedChanged += new System.EventHandler(this.chkContract_CheckedChanged);
            // 
            // lblContract
            // 
            this.lblContract.AutoSize = true;
            this.lblContract.Location = new System.Drawing.Point(16, 26);
            this.lblContract.Name = "lblContract";
            this.lblContract.Size = new System.Drawing.Size(89, 13);
            this.lblContract.TabIndex = 4;
            this.lblContract.Text = "Contract Signed: ";
            // 
            // picSidePanel
            // 
            this.picSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picSidePanel.BackColor = System.Drawing.Color.White;
            this.picSidePanel.Location = new System.Drawing.Point(0, 0);
            this.picSidePanel.Name = "picSidePanel";
            this.picSidePanel.Size = new System.Drawing.Size(143, 520);
            this.picSidePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSidePanel.TabIndex = 8;
            this.picSidePanel.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(159, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 58);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assembly";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(604, 490);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(484, 490);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(375, 490);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 16;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // UpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 517);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpPlanning);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpOrders);
            this.Controls.Add(this.picSidePanel);
            this.Name = "UpdateOrderForm";
            this.Text = "UpdateOrderStatusForm";
            this.grpOrders.ResumeLayout(false);
            this.grpOrders.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpPlanning.ResumeLayout(false);
            this.grpPlanning.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSidePanel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSidePanel;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Button btnOrderSearch;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.GroupBox grpPlanning;
        private System.Windows.Forms.Label lblPlanningPay;
        private System.Windows.Forms.Label lblPlanningGranted;
        private System.Windows.Forms.CheckBox chkPlanningPay;
        private System.Windows.Forms.CheckBox chkPlanning;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFoundationDate;
        private System.Windows.Forms.CheckBox chkFullPayment;
        private System.Windows.Forms.Label lblFullPayment;
        private System.Windows.Forms.CheckBox chkContract;
        private System.Windows.Forms.Label lblContract;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkRejected;
        private System.Windows.Forms.Label lblPlanningRejected;
        private System.Windows.Forms.DateTimePicker dtpFoundationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUndo;

    }
}