using Library.Data.Context;
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
    public partial class Login : Form
    {

        public bool IsEdit = false;

        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری خود را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("لطفا رمز ورود را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Main main = new Main();

                    if (IsEdit)
                    {

                        var login = db.LoginRepository.Get().First();
                        login.UserName = txtUsername.Text;
                        login.Password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        Application.Restart();

                    }
                    else
                    {
                        if (db.LoginRepository.Get(a => a.UserName == txtUsername.Text && a.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;

                            Hide();
                            main.ShowDialog();
                            Application.Exit();


                        }
                        else
                        {
                            MessageBox.Show("کاربری یافت نشد !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "تغییر اطلاعات ورود به حساب";
                btnLogin.Text = "ثبت";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();
                    txtUsername.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }

            }
        }
    }
}
