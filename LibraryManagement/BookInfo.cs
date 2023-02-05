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
    public partial class BookInfo : Form
    {
        UnitOfWork db = new UnitOfWork();

        public BookInfo()
        {
            InitializeComponent();
        }


        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvbook.AutoGenerateColumns = false;
                dgvbook.DataSource = db.BookRepository.GetAllBooks();
            }
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvbook.DataSource = db.BookRepository.GetBookByFilter(txtFilter.Text);
            }
        }

        private void btndeletebook_Click(object sender, EventArgs e)
        {
            if (dgvbook.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string Onvan = dgvbook.CurrentRow.Cells[1].Value.ToString();
                    if (MessageBox.Show($"آیا از حذف کتاب {Onvan} مطمئن هستید؟", "Attention", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int BookId = int.Parse(dgvbook.CurrentRow.Cells[0].Value.ToString());
                        db.BookRepository.DeleteBook(BookId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا یک سطر یا کتاب را انتخاب کنید !");
                    
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void btnaddbook_Click(object sender, EventArgs e)
        {
            AddOrEditBook Addbook = new AddOrEditBook();

            if (Addbook.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }

        }

        private void btneditbook_Click(object sender, EventArgs e)
        {
            if (dgvbook.CurrentRow != null)
            {
                int BookId = int.Parse(dgvbook.CurrentRow.Cells[0].Value.ToString());
                AddOrEditBook EditBook = new AddOrEditBook();
                EditBook.BookId = BookId;
                if(EditBook.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

    }
}
