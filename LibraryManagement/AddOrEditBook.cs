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
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class AddOrEditBook : Form
    {
        public int BookId = 0;
        UnitOfWork db = new UnitOfWork();

        public AddOrEditBook()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOnvan.Text == "")
            {
                MessageBox.Show("لطفا عنوان کتاب را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOnvan.Focus();
                return;
            }
            if (txtNevisande.Text == "")
            {
                MessageBox.Show("لطفا نام نویسنده کتاب را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNevisande.Focus();
                return;
            }
            else
            {
                Table_Book book = new Table_Book()
                {
                    Onvan = txtOnvan.Text,
                    Nevisande= txtNevisande.Text,
                    Nasher=txtNasher.Text,
                    Category= CBcategory.Text,
                    NobatCahp= (int?)numericChap.Value,
                    Tedad= (int?)numericTedad.Value
                };
                if (BookId == 0)
                {
                    db.BookRepository.InsertBook(book);
                }
                else
                {
                    book.Id = BookId;
                    db.BookRepository.UpdateBook(book);
                }

                db.Save();
                DialogResult = DialogResult.OK;
            }
            
        }

        private void AddOrEditBook_Load(object sender, EventArgs e)
        {
            if (BookId != 0)
            {
                Text = "ویرایش کتاب ";
                btnSave.Text = "ویرایش";
                var book = db.BookRepository.GetBookById(BookId);
                txtOnvan.Text = book.Onvan;
                txtNevisande.Text = book.Nevisande;
                txtNasher.Text = book.Nasher;
                CBcategory.Text = book.Category;
                numericChap.Value = (decimal)book.NobatCahp;
                numericTedad.Value = (decimal)book.Tedad;
            }


            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;

            con = new SqlConnection("server=KIANA\\SQLEXPRESS; Initial Catalog=library_DB;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Category FROM Table_Category";
            dr = cmd.ExecuteReader();



            while (dr.Read())
            {
                CBcategory.Items.Add(dr["Category"]);
            }
            con.Close();

        }

    }
}
