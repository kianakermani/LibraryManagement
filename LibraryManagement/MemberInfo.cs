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
    public partial class MemberInfo : Form
    {
        UnitOfWork db = new UnitOfWork();

        public MemberInfo()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMember.AutoGenerateColumns = false;
                dgvMember.DataSource = db.MemberRepository.GetAllMembers();
            }
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMember.DataSource = db.MemberRepository.GetMemberByFilter(txtFilter.Text);
            }
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            AddOrEditMember AddMember = new AddOrEditMember();
            if (AddMember.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMember.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string Name = dgvMember.CurrentRow.Cells[2].Value.ToString();
                    string Family = dgvMember.CurrentRow.Cells[3].Value.ToString();
                    if (MessageBox.Show($"آیااز حذف {Name} {Family} مطمئن هستید؟  ", "Attention", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int MemberId = int.Parse(dgvMember.CurrentRow.Cells[0].Value.ToString());
                        db.MemberRepository.DeleteMember(MemberId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک سطر یا عضو را انتخاب کنید !");

            }
        }

        private void btnEditmember_Click(object sender, EventArgs e)
        {
            if (dgvMember.CurrentRow != null)
            {
                int MemberId = int.Parse(dgvMember.CurrentRow.Cells[0].Value.ToString());
                AddOrEditMember EditMember = new AddOrEditMember();
                EditMember.MemberId = MemberId;
                if (EditMember.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

    }
}
