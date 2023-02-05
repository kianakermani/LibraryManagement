
namespace LibraryManagement
{
    partial class BookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfo));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnaddbook = new System.Windows.Forms.ToolStripButton();
            this.btneditbook = new System.Windows.Forms.ToolStripButton();
            this.btndeletebook = new System.Windows.Forms.ToolStripButton();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvbook = new System.Windows.Forms.DataGridView();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عنوان = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نویسنده = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ناشر = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.رده = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نوبت_چاپ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تعداد = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFilter.Location = new System.Drawing.Point(12, 64);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(252, 23);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnaddbook,
            this.btneditbook,
            this.btndeletebook,
            this.btnrefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 47);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnaddbook
            // 
            this.btnaddbook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnaddbook.Image = global::LibraryManagement.Properties.Resources.library;
            this.btnaddbook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaddbook.Name = "btnaddbook";
            this.btnaddbook.Size = new System.Drawing.Size(125, 44);
            this.btnaddbook.Text = "افزودن کتاب جدید";
            this.btnaddbook.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnaddbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnaddbook.Click += new System.EventHandler(this.btnaddbook_Click);
            // 
            // btneditbook
            // 
            this.btneditbook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditbook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btneditbook.Image = global::LibraryManagement.Properties.Resources.library_folder;
            this.btneditbook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneditbook.Name = "btneditbook";
            this.btneditbook.Size = new System.Drawing.Size(94, 44);
            this.btneditbook.Text = "ویرایش کتاب";
            this.btneditbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btneditbook.Click += new System.EventHandler(this.btneditbook_Click);
            // 
            // btndeletebook
            // 
            this.btndeletebook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndeletebook.Image = global::LibraryManagement.Properties.Resources._1371476007_Close_Box_Red;
            this.btndeletebook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndeletebook.Name = "btndeletebook";
            this.btndeletebook.Size = new System.Drawing.Size(80, 44);
            this.btndeletebook.Text = "حذف کتاب";
            this.btndeletebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndeletebook.Click += new System.EventHandler(this.btndeletebook_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnrefresh.Image = global::LibraryManagement.Properties.Resources.msdn_library;
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(76, 44);
            this.btnrefresh.Text = "بروزرسانی";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(287, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "جستجوی کتاب :";
            // 
            // dgvbook
            // 
            this.dgvbook.AllowUserToAddRows = false;
            this.dgvbook.AllowUserToDeleteRows = false;
            this.dgvbook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookId,
            this.عنوان,
            this.نویسنده,
            this.ناشر,
            this.رده,
            this.نوبت_چاپ,
            this.تعداد});
            this.dgvbook.Location = new System.Drawing.Point(0, 100);
            this.dgvbook.Name = "dgvbook";
            this.dgvbook.ReadOnly = true;
            this.dgvbook.RowHeadersWidth = 51;
            this.dgvbook.RowTemplate.Height = 24;
            this.dgvbook.Size = new System.Drawing.Size(775, 417);
            this.dgvbook.TabIndex = 8;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "Id";
            this.BookId.HeaderText = "BookId";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            // 
            // عنوان
            // 
            this.عنوان.DataPropertyName = "Onvan";
            this.عنوان.HeaderText = "عنوان";
            this.عنوان.MinimumWidth = 6;
            this.عنوان.Name = "عنوان";
            this.عنوان.ReadOnly = true;
            // 
            // نویسنده
            // 
            this.نویسنده.DataPropertyName = "Nevisande";
            this.نویسنده.HeaderText = "نویسنده";
            this.نویسنده.MinimumWidth = 6;
            this.نویسنده.Name = "نویسنده";
            this.نویسنده.ReadOnly = true;
            // 
            // ناشر
            // 
            this.ناشر.DataPropertyName = "Nasher";
            this.ناشر.HeaderText = "ناشر";
            this.ناشر.MinimumWidth = 6;
            this.ناشر.Name = "ناشر";
            this.ناشر.ReadOnly = true;
            // 
            // رده
            // 
            this.رده.DataPropertyName = "Category";
            this.رده.HeaderText = "رده";
            this.رده.MinimumWidth = 6;
            this.رده.Name = "رده";
            this.رده.ReadOnly = true;
            // 
            // نوبت_چاپ
            // 
            this.نوبت_چاپ.DataPropertyName = "NobatCahp";
            this.نوبت_چاپ.HeaderText = "نوبت_چاپ";
            this.نوبت_چاپ.MinimumWidth = 6;
            this.نوبت_چاپ.Name = "نوبت_چاپ";
            this.نوبت_چاپ.ReadOnly = true;
            // 
            // تعداد
            // 
            this.تعداد.DataPropertyName = "Tedad";
            this.تعداد.HeaderText = "تعداد";
            this.تعداد.MinimumWidth = 6;
            this.تعداد.Name = "تعداد";
            this.تعداد.ReadOnly = true;
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.Pictures_Background_Full_HD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 515);
            this.Controls.Add(this.dgvbook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtFilter);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اطلاعات کتاب ها";
            this.Load += new System.EventHandler(this.BookInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnaddbook;
        private System.Windows.Forms.ToolStripButton btneditbook;
        private System.Windows.Forms.ToolStripButton btndeletebook;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn عنوان;
        private System.Windows.Forms.DataGridViewTextBoxColumn نویسنده;
        private System.Windows.Forms.DataGridViewTextBoxColumn ناشر;
        private System.Windows.Forms.DataGridViewTextBoxColumn رده;
        private System.Windows.Forms.DataGridViewTextBoxColumn نوبت_چاپ;
        private System.Windows.Forms.DataGridViewTextBoxColumn تعداد;
    }
}