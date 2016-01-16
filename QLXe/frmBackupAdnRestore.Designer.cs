namespace QLXe
{
    partial class frmBackupAdnRestore
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBackup = new System.Windows.Forms.RadioButton();
            this.rdRestore = new System.Windows.Forms.RadioButton();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::QLXe.Properties.Resources.import_thuoc_wizard;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(136, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 104);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(63, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thật rắc rối khi không thường xuyên sao lưu cơ sở dữ liệu.\r\nNếu có vẫn đề trục tr" +
    "ặc hãy gọi ngay cho đội kĩ thuật viên!";
            // 
            // rdBackup
            // 
            this.rdBackup.AutoSize = true;
            this.rdBackup.Checked = true;
            this.rdBackup.Location = new System.Drawing.Point(157, 120);
            this.rdBackup.Name = "rdBackup";
            this.rdBackup.Size = new System.Drawing.Size(120, 21);
            this.rdBackup.TabIndex = 2;
            this.rdBackup.TabStop = true;
            this.rdBackup.Text = "Sao lưu dữ liệu";
            this.rdBackup.UseVisualStyleBackColor = true;
            // 
            // rdRestore
            // 
            this.rdRestore.AutoSize = true;
            this.rdRestore.Location = new System.Drawing.Point(305, 120);
            this.rdRestore.Name = "rdRestore";
            this.rdRestore.Size = new System.Drawing.Size(127, 21);
            this.rdRestore.TabIndex = 3;
            this.rdRestore.Text = "Phục hồi dữ liệu";
            this.rdRestore.UseVisualStyleBackColor = true;
            // 
            // txtPathFile
            // 
            this.txtPathFile.Location = new System.Drawing.Point(265, 175);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(276, 23);
            this.txtPathFile.TabIndex = 0;
            this.txtPathFile.Click += new System.EventHandler(this.btnSelectFileOnClick);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(561, 171);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(77, 30);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Chọn file";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFileOnClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(159, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đường dẫn file";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(561, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelOnClick);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(445, 234);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(96, 29);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Thực hiện";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRunOnClick);
            // 
            // frmBackupAdnRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 280);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtPathFile);
            this.Controls.Add(this.rdRestore);
            this.Controls.Add(this.rdBackup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupAdnRestore";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sao lưu và phục hồi dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBackup;
        private System.Windows.Forms.RadioButton rdRestore;
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
    }
}