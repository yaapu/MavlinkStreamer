namespace MavlinkStreamer
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btTLOG = new System.Windows.Forms.Button();
            this.txtTlogFileName = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.txtByteCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.tlog";
            this.openFileDialog.Filter = "File tlog|*.tlog|All files|*.*";
            // 
            // btTLOG
            // 
            this.btTLOG.Location = new System.Drawing.Point(34, 39);
            this.btTLOG.Name = "btTLOG";
            this.btTLOG.Size = new System.Drawing.Size(124, 20);
            this.btTLOG.TabIndex = 0;
            this.btTLOG.Text = "Load TLOG...";
            this.btTLOG.UseVisualStyleBackColor = true;
            this.btTLOG.Click += new System.EventHandler(this.btTLOG_Click);
            // 
            // txtTlogFileName
            // 
            this.txtTlogFileName.Location = new System.Drawing.Point(164, 39);
            this.txtTlogFileName.Name = "txtTlogFileName";
            this.txtTlogFileName.Size = new System.Drawing.Size(323, 20);
            this.txtTlogFileName.TabIndex = 1;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(34, 99);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(204, 74);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(356, 126);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(131, 20);
            this.txtFileSize.TabIndex = 3;
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(356, 99);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(72, 21);
            this.cbSerialPort.TabIndex = 4;
            // 
            // txtByteCount
            // 
            this.txtByteCount.Location = new System.Drawing.Point(356, 153);
            this.txtByteCount.Name = "txtByteCount";
            this.txtByteCount.Size = new System.Drawing.Size(131, 20);
            this.txtByteCount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "file size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "serial port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "streamed bytes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtByteCount);
            this.Controls.Add(this.cbSerialPort);
            this.Controls.Add(this.txtFileSize);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.txtTlogFileName);
            this.Controls.Add(this.btTLOG);
            this.Name = "MainForm";
            this.Text = "MavlinkStreamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btTLOG;
        private System.Windows.Forms.TextBox txtTlogFileName;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.TextBox txtByteCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

