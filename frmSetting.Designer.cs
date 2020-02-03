namespace InterfaceRequest
{
    partial class FrmSetting
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
            this.gbxRequestDataSource = new System.Windows.Forms.GroupBox();
            this.lblRequestDataSourcePath = new System.Windows.Forms.Label();
            this.lblRequestDataSourceStatus = new System.Windows.Forms.Label();
            this.tbRequestDataSourcePath = new System.Windows.Forms.TextBox();
            this.lilRequestDataSourceStatus = new System.Windows.Forms.LinkLabel();
            this.lblRequestDataSourceStatusValue = new System.Windows.Forms.Label();
            this.gbxMySqlDataSource = new System.Windows.Forms.GroupBox();
            this.tbMySqlDataSourceHostName = new System.Windows.Forms.TextBox();
            this.tbMySqlDataSourceDatabaseName = new System.Windows.Forms.TextBox();
            this.tbMySqlDataSourceUserName = new System.Windows.Forms.TextBox();
            this.tbMySqlDataSourcePassword = new System.Windows.Forms.TextBox();
            this.tbMySqlDataSourcePort = new System.Windows.Forms.TextBox();
            this.lblMySqlDataSourcePort = new System.Windows.Forms.Label();
            this.lblMySqlDataSourcePassword = new System.Windows.Forms.Label();
            this.lblMySqlDataSourceUserName = new System.Windows.Forms.Label();
            this.lblMySqlDataSourceHostName = new System.Windows.Forms.Label();
            this.lblMySqlDataSourceDatabaseName = new System.Windows.Forms.Label();
            this.lblMySqlDatasourceStatusValue = new System.Windows.Forms.Label();
            this.lilCheckMySqlDatasourceStatus = new System.Windows.Forms.LinkLabel();
            this.lblMySqlDatasourceStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxRequestDataSource.SuspendLayout();
            this.gbxMySqlDataSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRequestDataSource
            // 
            this.gbxRequestDataSource.Controls.Add(this.lblRequestDataSourcePath);
            this.gbxRequestDataSource.Controls.Add(this.lblRequestDataSourceStatus);
            this.gbxRequestDataSource.Controls.Add(this.tbRequestDataSourcePath);
            this.gbxRequestDataSource.Controls.Add(this.lilRequestDataSourceStatus);
            this.gbxRequestDataSource.Controls.Add(this.lblRequestDataSourceStatusValue);
            this.gbxRequestDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRequestDataSource.Location = new System.Drawing.Point(28, 11);
            this.gbxRequestDataSource.Name = "gbxRequestDataSource";
            this.gbxRequestDataSource.Size = new System.Drawing.Size(439, 102);
            this.gbxRequestDataSource.TabIndex = 91;
            this.gbxRequestDataSource.TabStop = false;
            this.gbxRequestDataSource.Text = "Request Datasource";
            // 
            // lblRequestDataSourcePath
            // 
            this.lblRequestDataSourcePath.AutoSize = true;
            this.lblRequestDataSourcePath.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestDataSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDataSourcePath.ForeColor = System.Drawing.Color.Black;
            this.lblRequestDataSourcePath.Location = new System.Drawing.Point(18, 29);
            this.lblRequestDataSourcePath.Name = "lblRequestDataSourcePath";
            this.lblRequestDataSourcePath.Size = new System.Drawing.Size(41, 16);
            this.lblRequestDataSourcePath.TabIndex = 66;
            this.lblRequestDataSourcePath.Text = "Path :";
            // 
            // lblRequestDataSourceStatus
            // 
            this.lblRequestDataSourceStatus.AutoSize = true;
            this.lblRequestDataSourceStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestDataSourceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDataSourceStatus.ForeColor = System.Drawing.Color.Black;
            this.lblRequestDataSourceStatus.Location = new System.Drawing.Point(18, 64);
            this.lblRequestDataSourceStatus.Name = "lblRequestDataSourceStatus";
            this.lblRequestDataSourceStatus.Size = new System.Drawing.Size(51, 16);
            this.lblRequestDataSourceStatus.TabIndex = 68;
            this.lblRequestDataSourceStatus.Text = "Status :";
            // 
            // tbRequestDataSourcePath
            // 
            this.tbRequestDataSourcePath.BackColor = System.Drawing.SystemColors.Window;
            this.tbRequestDataSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRequestDataSourcePath.Location = new System.Drawing.Point(100, 26);
            this.tbRequestDataSourcePath.Name = "tbRequestDataSourcePath";
            this.tbRequestDataSourcePath.Size = new System.Drawing.Size(321, 22);
            this.tbRequestDataSourcePath.TabIndex = 76;
            // 
            // lilRequestDataSourceStatus
            // 
            this.lilRequestDataSourceStatus.AutoSize = true;
            this.lilRequestDataSourceStatus.Location = new System.Drawing.Point(97, 64);
            this.lilRequestDataSourceStatus.Name = "lilRequestDataSourceStatus";
            this.lilRequestDataSourceStatus.Size = new System.Drawing.Size(46, 16);
            this.lilRequestDataSourceStatus.TabIndex = 72;
            this.lilRequestDataSourceStatus.TabStop = true;
            this.lilRequestDataSourceStatus.Text = "Check";
            this.lilRequestDataSourceStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilRequestDataSourceStatus_LinkClicked);
            // 
            // lblRequestDataSourceStatusValue
            // 
            this.lblRequestDataSourceStatusValue.AutoSize = true;
            this.lblRequestDataSourceStatusValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestDataSourceStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDataSourceStatusValue.ForeColor = System.Drawing.Color.Black;
            this.lblRequestDataSourceStatusValue.Location = new System.Drawing.Point(145, 64);
            this.lblRequestDataSourceStatusValue.Name = "lblRequestDataSourceStatusValue";
            this.lblRequestDataSourceStatusValue.Size = new System.Drawing.Size(134, 16);
            this.lblRequestDataSourceStatusValue.TabIndex = 75;
            this.lblRequestDataSourceStatusValue.Text = ":Connect/ Disconnect";
            // 
            // gbxMySqlDataSource
            // 
            this.gbxMySqlDataSource.Controls.Add(this.tbMySqlDataSourceHostName);
            this.gbxMySqlDataSource.Controls.Add(this.tbMySqlDataSourceDatabaseName);
            this.gbxMySqlDataSource.Controls.Add(this.tbMySqlDataSourceUserName);
            this.gbxMySqlDataSource.Controls.Add(this.tbMySqlDataSourcePassword);
            this.gbxMySqlDataSource.Controls.Add(this.tbMySqlDataSourcePort);
            this.gbxMySqlDataSource.Controls.Add(this.lblMySqlDataSourcePort);
            this.gbxMySqlDataSource.Controls.Add(this.lblMySqlDataSourcePassword);
            this.gbxMySqlDataSource.Controls.Add(this.lblMySqlDataSourceUserName);
            this.gbxMySqlDataSource.Controls.Add(this.lblMySqlDataSourceHostName);
            this.gbxMySqlDataSource.Controls.Add(this.lblMySqlDataSourceDatabaseName);
            this.gbxMySqlDataSource.Controls.Add(this.lblMySqlDatasourceStatusValue);
            this.gbxMySqlDataSource.Controls.Add(this.lilCheckMySqlDatasourceStatus);
            this.gbxMySqlDataSource.Controls.Add(this.lblMySqlDatasourceStatus);
            this.gbxMySqlDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMySqlDataSource.Location = new System.Drawing.Point(28, 128);
            this.gbxMySqlDataSource.Name = "gbxMySqlDataSource";
            this.gbxMySqlDataSource.Size = new System.Drawing.Size(439, 239);
            this.gbxMySqlDataSource.TabIndex = 92;
            this.gbxMySqlDataSource.TabStop = false;
            this.gbxMySqlDataSource.Text = "MySQL Datasource";
            // 
            // tbMySqlDataSourceHostName
            // 
            this.tbMySqlDataSourceHostName.BackColor = System.Drawing.SystemColors.Window;
            this.tbMySqlDataSourceHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMySqlDataSourceHostName.Location = new System.Drawing.Point(100, 23);
            this.tbMySqlDataSourceHostName.Name = "tbMySqlDataSourceHostName";
            this.tbMySqlDataSourceHostName.Size = new System.Drawing.Size(321, 22);
            this.tbMySqlDataSourceHostName.TabIndex = 80;
            // 
            // tbMySqlDataSourceDatabaseName
            // 
            this.tbMySqlDataSourceDatabaseName.BackColor = System.Drawing.SystemColors.Window;
            this.tbMySqlDataSourceDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMySqlDataSourceDatabaseName.Location = new System.Drawing.Point(100, 55);
            this.tbMySqlDataSourceDatabaseName.Name = "tbMySqlDataSourceDatabaseName";
            this.tbMySqlDataSourceDatabaseName.Size = new System.Drawing.Size(321, 22);
            this.tbMySqlDataSourceDatabaseName.TabIndex = 81;
            // 
            // tbMySqlDataSourceUserName
            // 
            this.tbMySqlDataSourceUserName.BackColor = System.Drawing.SystemColors.Window;
            this.tbMySqlDataSourceUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMySqlDataSourceUserName.Location = new System.Drawing.Point(100, 88);
            this.tbMySqlDataSourceUserName.Name = "tbMySqlDataSourceUserName";
            this.tbMySqlDataSourceUserName.Size = new System.Drawing.Size(321, 22);
            this.tbMySqlDataSourceUserName.TabIndex = 82;
            // 
            // tbMySqlDataSourcePassword
            // 
            this.tbMySqlDataSourcePassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbMySqlDataSourcePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMySqlDataSourcePassword.Location = new System.Drawing.Point(100, 122);
            this.tbMySqlDataSourcePassword.Name = "tbMySqlDataSourcePassword";
            this.tbMySqlDataSourcePassword.PasswordChar = '*';
            this.tbMySqlDataSourcePassword.Size = new System.Drawing.Size(321, 22);
            this.tbMySqlDataSourcePassword.TabIndex = 83;
            // 
            // tbMySqlDataSourcePort
            // 
            this.tbMySqlDataSourcePort.BackColor = System.Drawing.SystemColors.Window;
            this.tbMySqlDataSourcePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMySqlDataSourcePort.Location = new System.Drawing.Point(100, 159);
            this.tbMySqlDataSourcePort.Name = "tbMySqlDataSourcePort";
            this.tbMySqlDataSourcePort.Size = new System.Drawing.Size(321, 22);
            this.tbMySqlDataSourcePort.TabIndex = 84;
            // 
            // lblMySqlDataSourcePort
            // 
            this.lblMySqlDataSourcePort.AutoSize = true;
            this.lblMySqlDataSourcePort.BackColor = System.Drawing.Color.Transparent;
            this.lblMySqlDataSourcePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySqlDataSourcePort.ForeColor = System.Drawing.Color.Black;
            this.lblMySqlDataSourcePort.Location = new System.Drawing.Point(18, 162);
            this.lblMySqlDataSourcePort.Name = "lblMySqlDataSourcePort";
            this.lblMySqlDataSourcePort.Size = new System.Drawing.Size(38, 16);
            this.lblMySqlDataSourcePort.TabIndex = 79;
            this.lblMySqlDataSourcePort.Text = "Port :";
            // 
            // lblMySqlDataSourcePassword
            // 
            this.lblMySqlDataSourcePassword.AutoSize = true;
            this.lblMySqlDataSourcePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblMySqlDataSourcePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySqlDataSourcePassword.ForeColor = System.Drawing.Color.Black;
            this.lblMySqlDataSourcePassword.Location = new System.Drawing.Point(18, 125);
            this.lblMySqlDataSourcePassword.Name = "lblMySqlDataSourcePassword";
            this.lblMySqlDataSourcePassword.Size = new System.Drawing.Size(74, 16);
            this.lblMySqlDataSourcePassword.TabIndex = 78;
            this.lblMySqlDataSourcePassword.Text = "Password :";
            // 
            // lblMySqlDataSourceUserName
            // 
            this.lblMySqlDataSourceUserName.AutoSize = true;
            this.lblMySqlDataSourceUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblMySqlDataSourceUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySqlDataSourceUserName.ForeColor = System.Drawing.Color.Black;
            this.lblMySqlDataSourceUserName.Location = new System.Drawing.Point(18, 91);
            this.lblMySqlDataSourceUserName.Name = "lblMySqlDataSourceUserName";
            this.lblMySqlDataSourceUserName.Size = new System.Drawing.Size(80, 16);
            this.lblMySqlDataSourceUserName.TabIndex = 77;
            this.lblMySqlDataSourceUserName.Text = "UserName :";
            // 
            // lblMySqlDataSourceHostName
            // 
            this.lblMySqlDataSourceHostName.AutoSize = true;
            this.lblMySqlDataSourceHostName.BackColor = System.Drawing.Color.Transparent;
            this.lblMySqlDataSourceHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySqlDataSourceHostName.ForeColor = System.Drawing.Color.Black;
            this.lblMySqlDataSourceHostName.Location = new System.Drawing.Point(18, 26);
            this.lblMySqlDataSourceHostName.Name = "lblMySqlDataSourceHostName";
            this.lblMySqlDataSourceHostName.Size = new System.Drawing.Size(42, 16);
            this.lblMySqlDataSourceHostName.TabIndex = 66;
            this.lblMySqlDataSourceHostName.Text = "Host :";
            // 
            // lblMySqlDataSourceDatabaseName
            // 
            this.lblMySqlDataSourceDatabaseName.AutoSize = true;
            this.lblMySqlDataSourceDatabaseName.BackColor = System.Drawing.Color.Transparent;
            this.lblMySqlDataSourceDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySqlDataSourceDatabaseName.ForeColor = System.Drawing.Color.Black;
            this.lblMySqlDataSourceDatabaseName.Location = new System.Drawing.Point(18, 58);
            this.lblMySqlDataSourceDatabaseName.Name = "lblMySqlDataSourceDatabaseName";
            this.lblMySqlDataSourceDatabaseName.Size = new System.Drawing.Size(74, 16);
            this.lblMySqlDataSourceDatabaseName.TabIndex = 76;
            this.lblMySqlDataSourceDatabaseName.Text = "Database :";
            // 
            // lblMySqlDatasourceStatusValue
            // 
            this.lblMySqlDatasourceStatusValue.AutoSize = true;
            this.lblMySqlDatasourceStatusValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMySqlDatasourceStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySqlDatasourceStatusValue.ForeColor = System.Drawing.Color.Black;
            this.lblMySqlDatasourceStatusValue.Location = new System.Drawing.Point(145, 199);
            this.lblMySqlDatasourceStatusValue.Name = "lblMySqlDatasourceStatusValue";
            this.lblMySqlDatasourceStatusValue.Size = new System.Drawing.Size(134, 16);
            this.lblMySqlDatasourceStatusValue.TabIndex = 75;
            this.lblMySqlDatasourceStatusValue.Text = ":Connect/ Disconnect";
            // 
            // lilCheckMySqlDatasourceStatus
            // 
            this.lilCheckMySqlDatasourceStatus.AutoSize = true;
            this.lilCheckMySqlDatasourceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilCheckMySqlDatasourceStatus.Location = new System.Drawing.Point(97, 199);
            this.lilCheckMySqlDatasourceStatus.Name = "lilCheckMySqlDatasourceStatus";
            this.lilCheckMySqlDatasourceStatus.Size = new System.Drawing.Size(46, 16);
            this.lilCheckMySqlDatasourceStatus.TabIndex = 72;
            this.lilCheckMySqlDatasourceStatus.TabStop = true;
            this.lilCheckMySqlDatasourceStatus.Text = "Check";
            this.lilCheckMySqlDatasourceStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LilCheckMySqlDatasourceStatus_LinkClicked);
            // 
            // lblMySqlDatasourceStatus
            // 
            this.lblMySqlDatasourceStatus.AutoSize = true;
            this.lblMySqlDatasourceStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblMySqlDatasourceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySqlDatasourceStatus.ForeColor = System.Drawing.Color.Black;
            this.lblMySqlDatasourceStatus.Location = new System.Drawing.Point(18, 199);
            this.lblMySqlDatasourceStatus.Name = "lblMySqlDatasourceStatus";
            this.lblMySqlDatasourceStatus.Size = new System.Drawing.Size(51, 16);
            this.lblMySqlDatasourceStatus.TabIndex = 68;
            this.lblMySqlDatasourceStatus.Text = "Status :";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(392, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 411);
            this.Controls.Add(this.gbxRequestDataSource);
            this.Controls.Add(this.gbxMySqlDataSource);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.gbxRequestDataSource.ResumeLayout(false);
            this.gbxRequestDataSource.PerformLayout();
            this.gbxMySqlDataSource.ResumeLayout(false);
            this.gbxMySqlDataSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRequestDataSource;
        private System.Windows.Forms.Label lblRequestDataSourcePath;
        private System.Windows.Forms.Label lblRequestDataSourceStatus;
        private System.Windows.Forms.TextBox tbRequestDataSourcePath;
        private System.Windows.Forms.LinkLabel lilRequestDataSourceStatus;
        private System.Windows.Forms.Label lblRequestDataSourceStatusValue;
        private System.Windows.Forms.GroupBox gbxMySqlDataSource;
        private System.Windows.Forms.TextBox tbMySqlDataSourceHostName;
        private System.Windows.Forms.TextBox tbMySqlDataSourceDatabaseName;
        private System.Windows.Forms.TextBox tbMySqlDataSourceUserName;
        private System.Windows.Forms.TextBox tbMySqlDataSourcePassword;
        private System.Windows.Forms.TextBox tbMySqlDataSourcePort;
        private System.Windows.Forms.Label lblMySqlDataSourcePort;
        private System.Windows.Forms.Label lblMySqlDataSourcePassword;
        private System.Windows.Forms.Label lblMySqlDataSourceUserName;
        private System.Windows.Forms.Label lblMySqlDataSourceHostName;
        private System.Windows.Forms.Label lblMySqlDataSourceDatabaseName;
        private System.Windows.Forms.Label lblMySqlDatasourceStatusValue;
        private System.Windows.Forms.LinkLabel lilCheckMySqlDatasourceStatus;
        private System.Windows.Forms.Label lblMySqlDatasourceStatus;
        private System.Windows.Forms.Button btnSave;
    }
}