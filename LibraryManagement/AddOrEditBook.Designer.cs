
namespace LibraryManagement
{
    partial class AddOrEditBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOnvan = new System.Windows.Forms.TextBox();
            this.txtNevisande = new System.Windows.Forms.TextBox();
            this.txtNasher = new System.Windows.Forms.TextBox();
            this.numericChap = new System.Windows.Forms.NumericUpDown();
            this.numericTedad = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.CBcategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericChap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTedad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان کتاب :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "نویسنده :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ناشر :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "رده :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "نوبت چاپ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "تعداد :";
            // 
            // txtOnvan
            // 
            this.txtOnvan.Location = new System.Drawing.Point(79, 23);
            this.txtOnvan.Name = "txtOnvan";
            this.txtOnvan.Size = new System.Drawing.Size(148, 22);
            this.txtOnvan.TabIndex = 7;
            // 
            // txtNevisande
            // 
            this.txtNevisande.Location = new System.Drawing.Point(81, 70);
            this.txtNevisande.Name = "txtNevisande";
            this.txtNevisande.Size = new System.Drawing.Size(148, 22);
            this.txtNevisande.TabIndex = 8;
            // 
            // txtNasher
            // 
            this.txtNasher.Location = new System.Drawing.Point(81, 123);
            this.txtNasher.Name = "txtNasher";
            this.txtNasher.Size = new System.Drawing.Size(148, 22);
            this.txtNasher.TabIndex = 9;
            // 
            // numericChap
            // 
            this.numericChap.Location = new System.Drawing.Point(98, 213);
            this.numericChap.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericChap.Name = "numericChap";
            this.numericChap.Size = new System.Drawing.Size(120, 22);
            this.numericChap.TabIndex = 12;
            this.numericChap.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericTedad
            // 
            this.numericTedad.Location = new System.Drawing.Point(98, 267);
            this.numericTedad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTedad.Name = "numericTedad";
            this.numericTedad.Size = new System.Drawing.Size(120, 22);
            this.numericTedad.TabIndex = 13;
            this.numericTedad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CBcategory
            // 
            this.CBcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CBcategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBcategory.FormattingEnabled = true;
            this.CBcategory.Location = new System.Drawing.Point(81, 171);
            this.CBcategory.Name = "CBcategory";
            this.CBcategory.Size = new System.Drawing.Size(148, 24);
            this.CBcategory.TabIndex = 15;
            // 
            // AddOrEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagement.Properties.Resources._247_2477130_light_colours_wallpapers_hd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 371);
            this.Controls.Add(this.CBcategory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericTedad);
            this.Controls.Add(this.numericChap);
            this.Controls.Add(this.txtNasher);
            this.Controls.Add(this.txtNevisande);
            this.Controls.Add(this.txtOnvan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrEditBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن کتاب جدید";
            this.Load += new System.EventHandler(this.AddOrEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericChap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTedad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOnvan;
        private System.Windows.Forms.TextBox txtNevisande;
        private System.Windows.Forms.TextBox txtNasher;
        private System.Windows.Forms.NumericUpDown numericChap;
        private System.Windows.Forms.NumericUpDown numericTedad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox CBcategory;
    }
}