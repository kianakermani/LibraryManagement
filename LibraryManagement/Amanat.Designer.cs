
namespace LibraryManagement
{
    partial class Amanat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amanat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBbook = new System.Windows.Forms.ComboBox();
            this.CBozv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvAmanat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عنوان_کتاب = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عضو = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخ_امانت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تاریخ_تحویل = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.وضعیت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.GBReport = new System.Windows.Forms.GroupBox();
            this.CBvaziyat = new System.Windows.Forms.ComboBox();
            this.btnChap = new System.Windows.Forms.Button();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.dateAmanat = new Atf.UI.DateTimeSelector();
            this.dateTahvil = new Atf.UI.DateTimeSelector();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmanat)).BeginInit();
            this.GBReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(702, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب کتاب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(702, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "به شناسه عضویت : ";
            // 
            // CBbook
            // 
            this.CBbook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBbook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBbook.BackColor = System.Drawing.Color.White;
            this.CBbook.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CBbook.FormattingEnabled = true;
            this.CBbook.Location = new System.Drawing.Point(495, 31);
            this.CBbook.Name = "CBbook";
            this.CBbook.Size = new System.Drawing.Size(174, 24);
            this.CBbook.TabIndex = 2;
            // 
            // CBozv
            // 
            this.CBozv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBozv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBozv.FormattingEnabled = true;
            this.CBozv.Location = new System.Drawing.Point(495, 87);
            this.CBozv.Name = "CBozv";
            this.CBozv.Size = new System.Drawing.Size(174, 24);
            this.CBozv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(256, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاریخ امانت :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(256, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "تاریخ تحویل :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(256, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "وضعیت :";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(787, 149);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 38);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(684, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(582, 149);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 38);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvAmanat
            // 
            this.dgvAmanat.AllowUserToAddRows = false;
            this.dgvAmanat.AllowUserToDeleteRows = false;
            this.dgvAmanat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAmanat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmanat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.عنوان_کتاب,
            this.عضو,
            this.تاریخ_امانت,
            this.تاریخ_تحویل,
            this.وضعیت});
            this.dgvAmanat.Location = new System.Drawing.Point(1, 209);
            this.dgvAmanat.Name = "dgvAmanat";
            this.dgvAmanat.ReadOnly = true;
            this.dgvAmanat.RowHeadersWidth = 51;
            this.dgvAmanat.RowTemplate.Height = 24;
            this.dgvAmanat.Size = new System.Drawing.Size(885, 303);
            this.dgvAmanat.TabIndex = 14;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // عنوان_کتاب
            // 
            this.عنوان_کتاب.DataPropertyName = "TitleBook";
            this.عنوان_کتاب.HeaderText = "عنوان کتاب";
            this.عنوان_کتاب.MinimumWidth = 6;
            this.عنوان_کتاب.Name = "عنوان_کتاب";
            this.عنوان_کتاب.ReadOnly = true;
            // 
            // عضو
            // 
            this.عضو.DataPropertyName = "Member";
            this.عضو.HeaderText = "شناسه عضو";
            this.عضو.MinimumWidth = 6;
            this.عضو.Name = "عضو";
            this.عضو.ReadOnly = true;
            // 
            // تاریخ_امانت
            // 
            this.تاریخ_امانت.DataPropertyName = "TarikheAmanat";
            this.تاریخ_امانت.HeaderText = "تاریخ امانت";
            this.تاریخ_امانت.MinimumWidth = 6;
            this.تاریخ_امانت.Name = "تاریخ_امانت";
            this.تاریخ_امانت.ReadOnly = true;
            // 
            // تاریخ_تحویل
            // 
            this.تاریخ_تحویل.DataPropertyName = "TarikheTahvil";
            this.تاریخ_تحویل.HeaderText = "تاریخ تحویل";
            this.تاریخ_تحویل.MinimumWidth = 6;
            this.تاریخ_تحویل.Name = "تاریخ_تحویل";
            this.تاریخ_تحویل.ReadOnly = true;
            // 
            // وضعیت
            // 
            this.وضعیت.DataPropertyName = "Vazyat";
            this.وضعیت.HeaderText = "وضعیت";
            this.وضعیت.MinimumWidth = 6;
            this.وضعیت.Name = "وضعیت";
            this.وضعیت.ReadOnly = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(462, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 38);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "حذف گزارش";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(215, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "جستجوی گزارش :";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 157);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(197, 22);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // GBReport
            // 
            this.GBReport.BackColor = System.Drawing.Color.Transparent;
            this.GBReport.Controls.Add(this.dateTahvil);
            this.GBReport.Controls.Add(this.dateAmanat);
            this.GBReport.Controls.Add(this.CBvaziyat);
            this.GBReport.Controls.Add(this.label1);
            this.GBReport.Controls.Add(this.label2);
            this.GBReport.Controls.Add(this.CBbook);
            this.GBReport.Controls.Add(this.CBozv);
            this.GBReport.Controls.Add(this.label3);
            this.GBReport.Controls.Add(this.label4);
            this.GBReport.Controls.Add(this.label5);
            this.GBReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GBReport.Location = new System.Drawing.Point(1, 0);
            this.GBReport.Name = "GBReport";
            this.GBReport.Size = new System.Drawing.Size(885, 143);
            this.GBReport.TabIndex = 18;
            this.GBReport.TabStop = false;
            this.GBReport.Text = "ثبت گزارش";
            // 
            // CBvaziyat
            // 
            this.CBvaziyat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBvaziyat.FormattingEnabled = true;
            this.CBvaziyat.Location = new System.Drawing.Point(50, 107);
            this.CBvaziyat.Name = "CBvaziyat";
            this.CBvaziyat.Size = new System.Drawing.Size(188, 24);
            this.CBvaziyat.TabIndex = 9;
            // 
            // btnChap
            // 
            this.btnChap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChap.Location = new System.Drawing.Point(345, 149);
            this.btnChap.Name = "btnChap";
            this.btnChap.Size = new System.Drawing.Size(101, 38);
            this.btnChap.TabIndex = 19;
            this.btnChap.Text = "چاپ گزارش";
            this.btnChap.UseVisualStyleBackColor = false;
            this.btnChap.Click += new System.EventHandler(this.btnChap_Click);
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "40e449157d78418fb4046b06862d6ace";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // dateAmanat
            // 
            this.dateAmanat.Location = new System.Drawing.Point(92, 26);
            this.dateAmanat.Name = "dateAmanat";
            this.dateAmanat.Size = new System.Drawing.Size(146, 23);
            this.dateAmanat.TabIndex = 12;
            this.dateAmanat.UsePersianFormat = true;
            // 
            // dateTahvil
            // 
            this.dateTahvil.Location = new System.Drawing.Point(92, 69);
            this.dateTahvil.Name = "dateTahvil";
            this.dateTahvil.Size = new System.Drawing.Size(146, 23);
            this.dateTahvil.TabIndex = 13;
            this.dateTahvil.UsePersianFormat = true;
            // 
            // Amanat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources._7639492a081f0b653a416e7b19368ba3__wood_texture_wallpaper_pictures;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 514);
            this.Controls.Add(this.btnChap);
            this.Controls.Add(this.GBReport);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAmanat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Amanat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش امانت های کتاب";
            this.Load += new System.EventHandler(this.Amanat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmanat)).EndInit();
            this.GBReport.ResumeLayout(false);
            this.GBReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBbook;
        private System.Windows.Forms.ComboBox CBozv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvAmanat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.GroupBox GBReport;
        private System.Windows.Forms.ComboBox CBvaziyat;
        private System.Windows.Forms.Button btnChap;
        private Stimulsoft.Report.StiReport stiPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn عنوان_کتاب;
        private System.Windows.Forms.DataGridViewTextBoxColumn عضو;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخ_امانت;
        private System.Windows.Forms.DataGridViewTextBoxColumn تاریخ_تحویل;
        private System.Windows.Forms.DataGridViewTextBoxColumn وضعیت;
        private Atf.UI.DateTimeSelector dateTahvil;
        private Atf.UI.DateTimeSelector dateAmanat;
    }
}