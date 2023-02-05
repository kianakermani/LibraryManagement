using Library.Data;
using Library.Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Amanat : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int ReportId = 0;

        public Amanat()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvAmanat.AutoGenerateColumns = false;
                dgvAmanat.DataSource = db.AmanatRepository.GetAllReports();
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            CBbook.SelectedIndex = -1;
            CBozv.SelectedIndex = -1;
            CBvaziyat.SelectedIndex = -1;
            dateAmanat.Value = DateTime.Today;
            dateTahvil.Value = DateTime.Today;
            txtFilter.Text = "";
            BindGrid();
        }

        private void Amanat_Load(object sender, EventArgs e)
        {
            BindGrid();

            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;

            con = new SqlConnection("server=KIANA\\SQLEXPRESS; Initial Catalog=library_DB;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Onvan FROM Table_Book";
            dr = cmd.ExecuteReader();
            


            while (dr.Read())
            {
                CBbook.Items.Add(dr["Onvan"]);
            }
            con.Close();

            SqlConnection con1;
            SqlCommand cmd1;
            SqlDataReader dr1;

            con1 = new SqlConnection("server=KIANA\\SQLEXPRESS; Initial Catalog=library_DB;Integrated Security=True");
            cmd1 = new SqlCommand();
            con1.Open();
            cmd1.Connection = con1;
            cmd1.CommandText = "SELECT CodeMeli FROM Table_Member";
            dr1 = cmd1.ExecuteReader();



            while (dr1.Read())
            {
                CBozv.Items.Add(dr1["CodeMeli"]);
            }
            con.Close();

            SqlConnection con2;
            SqlCommand cmd2;
            SqlDataReader dr2;

            con2 = new SqlConnection("server=KIANA\\SQLEXPRESS; Initial Catalog=library_DB;Integrated Security=True");
            cmd2 = new SqlCommand();
            con2.Open();
            cmd2.Connection = con2;
            cmd2.CommandText = "SELECT Vaziyat FROM Table_Vaziyat";
            dr2 = cmd2.ExecuteReader();



            while (dr2.Read())
            {
                CBvaziyat.Items.Add(dr2["Vaziyat"]);
            }
            con.Close();

            if (ReportId != 0)
            {
                Text = "ویرایش گزارش";
                var r = db.AmanatRepository.GetReportById(ReportId);
                CBbook.Text = r.TitleBook;
                CBozv.Text = r.Member;
                dateAmanat.Value = r.TarikheAmanat;
                dateTahvil.Value = r.TarikheTahvil;
                CBvaziyat.Text = r.Vazyat;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CBbook.Text == "")
            {
                MessageBox.Show("لطفا عنوان کتاب را انتخاب کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBbook.Focus();
                return;
            }
            if (CBozv.Text == "")
            {
                MessageBox.Show("لطفا شناسه ی عضویت را انتخاب کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBozv.Focus();
                return;
            }
            if ( CBvaziyat.Text== "")
            {
                MessageBox.Show("لطفا وضعیت را مشخص کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBvaziyat.Focus();
                return;
            }
            else
            {
                Table_Amanat report = new Table_Amanat()
                {
                    TarikheAmanat= (DateTime)dateAmanat.Value,
                    TarikheTahvil= (DateTime)dateTahvil.Value,
                    TitleBook=CBbook.Text,
                    Member=CBozv.Text,
                    Vazyat=CBvaziyat.Text
                };
                if (ReportId == 0)
                {
                    db.AmanatRepository.InsertReport(report);
                    db.Save();
                    Amanat a = new Amanat();
                    a.ShowDialog();

                }
                else
                {
                    report.Id=ReportId;
                    db.AmanatRepository.UpdateReport(report);
                    db.Save(); 
                }
                DialogResult=DialogResult.OK;

            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvAmanat.DataSource = db.AmanatRepository.GetReportbyFilter(txtFilter.Text);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAmanat.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (MessageBox.Show ("آیا از حذف این گزارش مطمئن هستید؟", "Attention", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int ReportId = int.Parse(dgvAmanat.CurrentRow.Cells[0].Value.ToString());
                        db.AmanatRepository.DeleteReport(ReportId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک سطر یا گزارش را انتخاب کنید !");

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvAmanat.CurrentRow != null)
            {
                int ReportId=int.Parse(dgvAmanat.CurrentRow.Cells[0].Value.ToString());
                Amanat amanat = new Amanat();
                amanat.ReportId=ReportId;
                if (amanat.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnChap_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("TitleBook");
            dtPrint.Columns.Add("Member");
            dtPrint.Columns.Add("TarikheAmanat");
            dtPrint.Columns.Add("TarikheTahvil");
            dtPrint.Columns.Add("Vazyat");
            foreach (DataGridViewRow item in dgvAmanat.Rows)
            {
                dtPrint.Rows.Add(item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString()
                    );
            }


            stiPrint.Load(Application.StartupPath + "/Report.mrt");
            stiPrint.RegData("DT", dtPrint);
            stiPrint.Show();
        }
    }
}
