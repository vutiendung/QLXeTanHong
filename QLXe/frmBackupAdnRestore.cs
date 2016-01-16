using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXe
{
    public partial class frmBackupAdnRestore : Form
    {
        private string path = "";

        public frmBackupAdnRestore()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm lự chọn file hoặc thư mục
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFileOnClick(object sender, EventArgs e)
        {
            if (rdBackup.Checked)
            {
                //Nếu là sao lưu

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    path = folderBrowserDialog.SelectedPath;
                    txtPathFile.Text = path;
                }
                
            }
            else
                if (rdRestore.Checked)
                {
                    //Nếu là phục hồi
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    openFileDialog.Title = "Chọn file phục hồi";
                    openFileDialog.Filter = "Backup Files(*.bak)|*.bak|All File(*.*)|*.*";
                    openFileDialog.FilterIndex = 0;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        path = openFileDialog.FileName;
                        txtPathFile.Text = path;
                    }
                }
        }

        private void btnCancelOnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRunOnClick(object sender, EventArgs e)
        {
            if (rdBackup.Checked)
            {
                if (Backup())
                {
                    MessageBox.Show("Sao lưu thành công!\nĐường dẫn file: " + path
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sao lưu không thành công!"
                                    , "Lỗi"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                }
            }
            else
                if (Restore())
                {
                    MessageBox.Show("Phục hồi thành công!\nFile phục hồi: " + path
                                    , "Thông báo"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Phục hồi không thành công!"
                                    , "Lỗi"
                                    , MessageBoxButtons.OK
                                    , MessageBoxIcon.Error);
                }
        }

        private bool Backup()
        {
            return true;
        }

        private bool Restore()
        {
            return true;
        }
    }
}
