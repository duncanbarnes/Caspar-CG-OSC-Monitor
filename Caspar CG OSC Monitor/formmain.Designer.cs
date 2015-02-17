namespace Caspar_CG_OSC_Monitor
{
    partial class formMain
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
            this.splitContainerToolbarLogs = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartStopServer = new System.Windows.Forms.Button();
            this.numericUpDownOSCPort = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewIncomingMessages = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxFilterMixer = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterOutputConsume = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterStage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarLogs)).BeginInit();
            this.splitContainerToolbarLogs.Panel1.SuspendLayout();
            this.splitContainerToolbarLogs.Panel2.SuspendLayout();
            this.splitContainerToolbarLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSCPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerToolbarLogs
            // 
            this.splitContainerToolbarLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerToolbarLogs.IsSplitterFixed = true;
            this.splitContainerToolbarLogs.Location = new System.Drawing.Point(0, 0);
            this.splitContainerToolbarLogs.Name = "splitContainerToolbarLogs";
            this.splitContainerToolbarLogs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerToolbarLogs.Panel1
            // 
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.checkBoxFilterStage);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.checkBoxFilterOutputConsume);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.checkBoxFilterMixer);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.label1);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.buttonStartStopServer);
            this.splitContainerToolbarLogs.Panel1.Controls.Add(this.numericUpDownOSCPort);
            // 
            // splitContainerToolbarLogs.Panel2
            // 
            this.splitContainerToolbarLogs.Panel2.Controls.Add(this.dataGridViewIncomingMessages);
            this.splitContainerToolbarLogs.Size = new System.Drawing.Size(1205, 469);
            this.splitContainerToolbarLogs.SplitterDistance = 70;
            this.splitContainerToolbarLogs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monitor Port:";
            // 
            // buttonStartStopServer
            // 
            this.buttonStartStopServer.Location = new System.Drawing.Point(294, 15);
            this.buttonStartStopServer.Name = "buttonStartStopServer";
            this.buttonStartStopServer.Size = new System.Drawing.Size(128, 42);
            this.buttonStartStopServer.TabIndex = 1;
            this.buttonStartStopServer.Text = "Start Server";
            this.buttonStartStopServer.UseVisualStyleBackColor = true;
            this.buttonStartStopServer.Click += new System.EventHandler(this.buttonStartStopServer_Click);
            // 
            // numericUpDownOSCPort
            // 
            this.numericUpDownOSCPort.Location = new System.Drawing.Point(138, 24);
            this.numericUpDownOSCPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownOSCPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOSCPort.Name = "numericUpDownOSCPort";
            this.numericUpDownOSCPort.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownOSCPort.TabIndex = 0;
            this.numericUpDownOSCPort.Value = new decimal(new int[] {
            6250,
            0,
            0,
            0});
            // 
            // dataGridViewIncomingMessages
            // 
            this.dataGridViewIncomingMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomingMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Address,
            this.Data1,
            this.Data2,
            this.Data3});
            this.dataGridViewIncomingMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIncomingMessages.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewIncomingMessages.Name = "dataGridViewIncomingMessages";
            this.dataGridViewIncomingMessages.RowHeadersVisible = false;
            this.dataGridViewIncomingMessages.RowTemplate.Height = 28;
            this.dataGridViewIncomingMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewIncomingMessages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIncomingMessages.Size = new System.Drawing.Size(1205, 395);
            this.dataGridViewIncomingMessages.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "OSC Message Address";
            this.Address.Name = "Address";
            // 
            // Data1
            // 
            this.Data1.HeaderText = "Data 1";
            this.Data1.Name = "Data1";
            // 
            // Data2
            // 
            this.Data2.HeaderText = "Data 2";
            this.Data2.Name = "Data2";
            // 
            // Data3
            // 
            this.Data3.HeaderText = "Data 3";
            this.Data3.Name = "Data3";
            // 
            // checkBoxFilterMixer
            // 
            this.checkBoxFilterMixer.AutoSize = true;
            this.checkBoxFilterMixer.Location = new System.Drawing.Point(453, 12);
            this.checkBoxFilterMixer.Name = "checkBoxFilterMixer";
            this.checkBoxFilterMixer.Size = new System.Drawing.Size(156, 24);
            this.checkBoxFilterMixer.TabIndex = 3;
            this.checkBoxFilterMixer.Text = "/channel/*/mixer/*";
            this.checkBoxFilterMixer.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterOutputConsume
            // 
            this.checkBoxFilterOutputConsume.AutoSize = true;
            this.checkBoxFilterOutputConsume.Location = new System.Drawing.Point(453, 40);
            this.checkBoxFilterOutputConsume.Name = "checkBoxFilterOutputConsume";
            this.checkBoxFilterOutputConsume.Size = new System.Drawing.Size(263, 24);
            this.checkBoxFilterOutputConsume.TabIndex = 4;
            this.checkBoxFilterOutputConsume.Text = "/channel/*/output/consume_time";
            this.checkBoxFilterOutputConsume.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterStage
            // 
            this.checkBoxFilterStage.AutoSize = true;
            this.checkBoxFilterStage.Location = new System.Drawing.Point(755, 12);
            this.checkBoxFilterStage.Name = "checkBoxFilterStage";
            this.checkBoxFilterStage.Size = new System.Drawing.Size(159, 24);
            this.checkBoxFilterStage.TabIndex = 5;
            this.checkBoxFilterStage.Text = "/channel/*/stage/*";
            this.checkBoxFilterStage.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 469);
            this.Controls.Add(this.splitContainerToolbarLogs);
            this.Name = "formMain";
            this.Text = "Caspar CG OSC Monitor";
            this.splitContainerToolbarLogs.Panel1.ResumeLayout(false);
            this.splitContainerToolbarLogs.Panel1.PerformLayout();
            this.splitContainerToolbarLogs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerToolbarLogs)).EndInit();
            this.splitContainerToolbarLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOSCPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerToolbarLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartStopServer;
        private System.Windows.Forms.NumericUpDown numericUpDownOSCPort;
        private System.Windows.Forms.DataGridView dataGridViewIncomingMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data3;
        private System.Windows.Forms.CheckBox checkBoxFilterOutputConsume;
        private System.Windows.Forms.CheckBox checkBoxFilterMixer;
        private System.Windows.Forms.CheckBox checkBoxFilterStage;
    }
}

