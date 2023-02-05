using Library.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void اطلاعاتکتابهاToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookInfo book = new BookInfo();
            book.ShowDialog();
        }

        private void اطلاعاتاعضاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberInfo member = new MemberInfo();
            member.ShowDialog();
        }

        private void گزارشامانتهایکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Amanat amanat = new Amanat();
            amanat.ShowDialog();
        }

        private void تغییررمزورودToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Login login = new Login
            {
                IsEdit = true
            };
            login.ShowDialog();

        }

        private void خروجازحسابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            Login frmLog = new Login();
            frmLog.ShowDialog();
        }

        private void خروجازبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از خروج از برنامه اطمینان دارید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Show();
            lblDate.Text = DateTime.Now.ToShamsi();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
