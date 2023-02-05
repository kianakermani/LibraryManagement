using Library.Data;
using Library.Data.Context;
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
using System.Globalization;

namespace LibraryManagement
{
    public partial class AddOrEditMember : Form
    {
        public int MemberId = 0;
        UnitOfWork db = new UnitOfWork();
        

        public AddOrEditMember()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام خود را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtFamily.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی خود را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFamily.Focus();
                return;
            }
            if (txtCodeMeli.Text == "")
            {
                MessageBox.Show("لطفا کد ملی خود را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodeMeli.Focus();
                return;
            }
            if (txtMadrakeTahsili.Text == "")
            {
                MessageBox.Show("لطفا مدرک تحصیلی خود را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMadrakeTahsili.Focus();
                return;
            }
            if (txtTelephoneNumber.Text == "")
            {
                MessageBox.Show("لطفا شماره تلفن را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelephoneNumber.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("لطفا ایمیل خود را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if(!rbFemale.Checked && !rbMale.Checked)
            {
                MessageBox.Show("لطفا جنسیت خود را انتخاب کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Table_Member member = new Table_Member()
                {
                    Name = txtName.Text,
                    Family= txtFamily.Text,
                    Jensiyat= rbMale.Checked ? "مرد" : "زن",
                    CodeMeli=txtCodeMeli.Text,
                    TarikhOzviat= (DateTime)dateOzv.Value,
                    TarikhTavalod= (DateTime)dateTavalod.Value,
                    MahaleTavalod=txtMahaleTavalod.Text,
                    MadrakeTahsili=txtMadrakeTahsili.Text,
                    TelephoneNumber=txtTelephoneNumber.Text,
                    Address=txtAddress.Text,
                    Email=txtEmail.Text
                };
                if (MemberId == 0)
                {
                    db.MemberRepository.InsertMember(member);
                }
                else
                {
                    member.Id = MemberId;
                    db.MemberRepository.UpdateMember(member);
                }
                db.Save();
                DialogResult=DialogResult.OK;

            }
        }

        private void AddOrEditMember_Load(object sender, EventArgs e)
        {
            if (MemberId != 0)
            {

                Text = "ویرایش عضو";
                btnSave.Text = "ویرایش";
                var member = db.MemberRepository.GetMemberById(MemberId);
                txtName.Text = member.Name;
                txtFamily.Text = member.Family;
                txtCodeMeli.Text = member.CodeMeli;
                dateOzv.Value = member.TarikhOzviat;
                dateTavalod.Value = member.TarikhTavalod;
                txtMahaleTavalod.Text = member.MahaleTavalod;
                txtMadrakeTahsili.Text = member.MadrakeTahsili;
                txtTelephoneNumber.Text = member.TelephoneNumber;
                txtAddress.Text = member.Address;
                txtEmail.Text = member.Email;
            }
        }
    }
}
