
namespace LibraryManagement
{
    partial class MemberInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInfo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewMember = new System.Windows.Forms.ToolStripButton();
            this.btnEditmember = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMember = new System.Windows.Forms.ToolStripButton();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.شناسه_عضویت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نام = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.نام_خانوادگی = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.جنسیت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخ_عضویت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخ_تولد = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.محل_تولد = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مدرک_تحصیلی = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.شماره_تلفن = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.آدرس = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ایمیل = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewMember,
            this.btnEditmember,
            this.btnDeleteMember,
            this.btnrefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewMember
            // 
            this.btnNewMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNewMember.Image = global::LibraryManagement.Properties.Resources._1371475930_filenew;
            this.btnNewMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(126, 64);
            this.btnNewMember.Text = "افزودن عضو جدید";
            this.btnNewMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnEditmember
            // 
            this.btnEditmember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditmember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditmember.Image = global::LibraryManagement.Properties.Resources._1371475973_document_edit;
            this.btnEditmember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditmember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditmember.Name = "btnEditmember";
            this.btnEditmember.Size = new System.Drawing.Size(95, 64);
            this.btnEditmember.Text = "ویرایش عضو";
            this.btnEditmember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditmember.Click += new System.EventHandler(this.btnEditmember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteMember.Image = global::LibraryManagement.Properties.Resources._1371476007_Close_Box_Red1;
            this.btnDeleteMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(81, 64);
            this.btnDeleteMember.Text = "حذف عضو";
            this.btnDeleteMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnrefresh.Image = global::LibraryManagement.Properties.Resources._1371476342_Refresh;
            this.btnrefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(76, 64);
            this.btnrefresh.Text = "بروزرسانی";
            this.btnrefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(209, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجوی عضو :";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.ForeColor = System.Drawing.Color.Black;
            this.txtFilter.Location = new System.Drawing.Point(27, 77);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(176, 22);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.شناسه_عضویت,
            this.نام,
            this.نام_خانوادگی,
            this.جنسیت,
            this.تاریخ_عضویت,
            this.تاریخ_تولد,
            this.محل_تولد,
            this.مدرک_تحصیلی,
            this.شماره_تلفن,
            this.آدرس,
            this.ایمیل});
            this.dgvMember.Location = new System.Drawing.Point(0, 115);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.ReadOnly = true;
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(887, 335);
            this.dgvMember.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // شناسه_عضویت
            // 
            this.شناسه_عضویت.DataPropertyName = "CodeMeli";
            this.شناسه_عضویت.HeaderText = "شناسه عضویت";
            this.شناسه_عضویت.MinimumWidth = 6;
            this.شناسه_عضویت.Name = "شناسه_عضویت";
            this.شناسه_عضویت.ReadOnly = true;
            this.شناسه_عضویت.Width = 125;
            // 
            // نام
            // 
            this.نام.DataPropertyName = "Name";
            this.نام.HeaderText = "نام";
            this.نام.MinimumWidth = 6;
            this.نام.Name = "نام";
            this.نام.ReadOnly = true;
            this.نام.Width = 125;
            // 
            // نام_خانوادگی
            // 
            this.نام_خانوادگی.DataPropertyName = "Family";
            this.نام_خانوادگی.HeaderText = "نام خانوادگی";
            this.نام_خانوادگی.MinimumWidth = 6;
            this.نام_خانوادگی.Name = "نام_خانوادگی";
            this.نام_خانوادگی.ReadOnly = true;
            this.نام_خانوادگی.Width = 125;
            // 
            // جنسیت
            // 
            this.جنسیت.DataPropertyName = "Jensiyat";
            this.جنسیت.HeaderText = "جنسیت";
            this.جنسیت.MinimumWidth = 6;
            this.جنسیت.Name = "جنسیت";
            this.جنسیت.ReadOnly = true;
            this.جنسیت.Width = 125;
            // 
            // تاریخ_عضویت
            // 
            this.تاریخ_عضویت.DataPropertyName = "TarikhOzviat";
            this.تاریخ_عضویت.HeaderText = "تاریخ عضویت";
            this.تاریخ_عضویت.MinimumWidth = 6;
            this.تاریخ_عضویت.Name = "تاریخ_عضویت";
            this.تاریخ_عضویت.ReadOnly = true;
            this.تاریخ_عضویت.Width = 125;
            // 
            // تاریخ_تولد
            // 
            this.تاریخ_تولد.DataPropertyName = "TarikhTavalod";
            this.تاریخ_تولد.HeaderText = "تاریخ تولد";
            this.تاریخ_تولد.MinimumWidth = 6;
            this.تاریخ_تولد.Name = "تاریخ_تولد";
            this.تاریخ_تولد.ReadOnly = true;
            this.تاریخ_تولد.Width = 125;
            // 
            // محل_تولد
            // 
            this.محل_تولد.DataPropertyName = "MahaleTavalod";
            this.محل_تولد.HeaderText = "محل تولد";
            this.محل_تولد.MinimumWidth = 6;
            this.محل_تولد.Name = "محل_تولد";
            this.محل_تولد.ReadOnly = true;
            this.محل_تولد.Width = 125;
            // 
            // مدرک_تحصیلی
            // 
            this.مدرک_تحصیلی.DataPropertyName = "MadrakeTahsili";
            this.مدرک_تحصیلی.HeaderText = "مدرک تحصیلی";
            this.مدرک_تحصیلی.MinimumWidth = 6;
            this.مدرک_تحصیلی.Name = "مدرک_تحصیلی";
            this.مدرک_تحصیلی.ReadOnly = true;
            this.مدرک_تحصیلی.Width = 125;
            // 
            // شماره_تلفن
            // 
            this.شماره_تلفن.DataPropertyName = "TelephoneNumber";
            this.شماره_تلفن.HeaderText = "شماره تلفن";
            this.شماره_تلفن.MinimumWidth = 6;
            this.شماره_تلفن.Name = "شماره_تلفن";
            this.شماره_تلفن.ReadOnly = true;
            this.شماره_تلفن.Width = 125;
            // 
            // آدرس
            // 
            this.آدرس.DataPropertyName = "Address";
            this.آدرس.HeaderText = "آدرس";
            this.آدرس.MinimumWidth = 6;
            this.آدرس.Name = "آدرس";
            this.آدرس.ReadOnly = true;
            this.آدرس.Width = 125;
            // 
            // ایمیل
            // 
            this.ایمیل.DataPropertyName = "Email";
            this.ایمیل.HeaderText = "ایمیل";
            this.ایمیل.MinimumWidth = 6;
            this.ایمیل.Name = "ایمیل";
            this.ایمیل.ReadOnly = true;
            this.ایمیل.Width = 125;
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources.YHOc2M;
            this.ClientSize = new System.Drawing.Size(887, 449);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MemberInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اطلاعات اعضا";
            this.Load += new System.EventHandler(this.MemberInfo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewMember;
        private System.Windows.Forms.ToolStripButton btnEditmember;
        private System.Windows.Forms.ToolStripButton btnDeleteMember;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn شناسه_عضویت;
        private System.Windows.Forms.DataGridViewTextBoxColumn نام;
        private System.Windows.Forms.DataGridViewTextBoxColumn نام_خانوادگی;
        private System.Windows.Forms.DataGridViewTextBoxColumn جنسیت;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخ_عضویت;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخ_تولد;
        private System.Windows.Forms.DataGridViewTextBoxColumn محل_تولد;
        private System.Windows.Forms.DataGridViewTextBoxColumn مدرک_تحصیلی;
        private System.Windows.Forms.DataGridViewTextBoxColumn شماره_تلفن;
        private System.Windows.Forms.DataGridViewTextBoxColumn آدرس;
        private System.Windows.Forms.DataGridViewTextBoxColumn ایمیل;
    }
}