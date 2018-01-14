namespace IsaretDili_UI
{
    partial class FrmArsiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArsiv));
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.lstGifName = new System.Windows.Forms.ListBox();
            this.txtCategoriesSearch = new System.Windows.Forms.TextBox();
            this.txtGifNameSearch = new System.Windows.Forms.TextBox();
            this.lblGifName = new System.Windows.Forms.Label();
            this.picBoxGif = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGif)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCategories
            // 
            this.lstCategories.Cursor = System.Windows.Forms.Cursors.Help;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(12, 71);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(120, 303);
            this.lstCategories.TabIndex = 2;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
            // 
            // lstGifName
            // 
            this.lstGifName.Cursor = System.Windows.Forms.Cursors.Help;
            this.lstGifName.FormattingEnabled = true;
            this.lstGifName.Location = new System.Drawing.Point(157, 71);
            this.lstGifName.Name = "lstGifName";
            this.lstGifName.Size = new System.Drawing.Size(133, 303);
            this.lstGifName.TabIndex = 3;
            this.lstGifName.SelectedIndexChanged += new System.EventHandler(this.lstGifName_SelectedIndexChanged);
            // 
            // txtCategoriesSearch
            // 
            this.txtCategoriesSearch.Location = new System.Drawing.Point(13, 45);
            this.txtCategoriesSearch.Name = "txtCategoriesSearch";
            this.txtCategoriesSearch.Size = new System.Drawing.Size(119, 20);
            this.txtCategoriesSearch.TabIndex = 4;
            this.txtCategoriesSearch.TextChanged += new System.EventHandler(this.txtCategoriesSearch_TextChanged);
            // 
            // txtGifNameSearch
            // 
            this.txtGifNameSearch.Location = new System.Drawing.Point(157, 45);
            this.txtGifNameSearch.Name = "txtGifNameSearch";
            this.txtGifNameSearch.Size = new System.Drawing.Size(133, 20);
            this.txtGifNameSearch.TabIndex = 5;
            this.txtGifNameSearch.TextChanged += new System.EventHandler(this.txtGifNameSearch_TextChanged);
            // 
            // lblGifName
            // 
            this.lblGifName.AutoSize = true;
            this.lblGifName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGifName.ForeColor = System.Drawing.Color.Brown;
            this.lblGifName.Location = new System.Drawing.Point(371, 43);
            this.lblGifName.Name = "lblGifName";
            this.lblGifName.Size = new System.Drawing.Size(129, 20);
            this.lblGifName.TabIndex = 6;
            this.lblGifName.Text = "Seçili Kelime Yok";
            // 
            // picBoxGif
            // 
            this.picBoxGif.Cursor = System.Windows.Forms.Cursors.No;
            this.picBoxGif.ErrorImage = null;
            this.picBoxGif.Location = new System.Drawing.Point(375, 71);
            this.picBoxGif.Name = "picBoxGif";
            this.picBoxGif.Size = new System.Drawing.Size(250, 250);
            this.picBoxGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGif.TabIndex = 1;
            this.picBoxGif.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategoriler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kelimeler";
            // 
            // btnSifirla
            // 
            this.btnSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.ForeColor = System.Drawing.Color.Maroon;
            this.btnSifirla.Location = new System.Drawing.Point(11, 380);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(121, 23);
            this.btnSifirla.TabIndex = 9;
            this.btnSifirla.Text = "Seçimi Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // FrmArsiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(680, 457);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGifName);
            this.Controls.Add(this.txtGifNameSearch);
            this.Controls.Add(this.txtCategoriesSearch);
            this.Controls.Add(this.lstGifName);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.picBoxGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArsiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArsiv";
            this.Load += new System.EventHandler(this.FrmArsiv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxGif;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.ListBox lstGifName;
        private System.Windows.Forms.TextBox txtCategoriesSearch;
        private System.Windows.Forms.TextBox txtGifNameSearch;
        private System.Windows.Forms.Label lblGifName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSifirla;
    }
}