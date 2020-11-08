namespace personnelMangement.forms
{
    partial class EditRespons
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
            this.elContainer1 = new Klik.Windows.Forms.v1.EntryLib.ELContainer();
            this.btn_edit = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.txtname = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.elDivider1 = new Klik.Windows.Forms.v1.EntryLib.ELDivider();
            this.txt_userName = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txtfamily = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_pass = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            ((System.ComponentModel.ISupportInitialize)(this.elContainer1)).BeginInit();
            this.elContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfamily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // elContainer1
            // 
            this.elContainer1.Controls.Add(this.btn_edit);
            this.elContainer1.Controls.Add(this.txtname);
            this.elContainer1.Controls.Add(this.elDivider1);
            this.elContainer1.Controls.Add(this.txt_userName);
            this.elContainer1.Controls.Add(this.txtfamily);
            this.elContainer1.Controls.Add(this.txt_pass);
            this.elContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elContainer1.Location = new System.Drawing.Point(0, 0);
            this.elContainer1.Name = "elContainer1";
            this.elContainer1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.elContainer1.Size = new System.Drawing.Size(410, 176);
            this.elContainer1.TabIndex = 3;
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_edit.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_edit.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_edit.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Location = new System.Drawing.Point(124, 121);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(151, 47);
            this.btn_edit.TabIndex = 93;
            this.btn_edit.TextStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_edit.TextStyle.Text = "ثبت ویرایش";
            this.btn_edit.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtname
            // 
            this.txtname.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txtname.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txtname.CaptionStyle.TextStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.CaptionStyle.TextStyle.Text = " نام";
            this.txtname.EditBoxStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtname.Location = new System.Drawing.Point(212, 12);
            this.txtname.Name = "txtname";
            this.txtname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtname.Size = new System.Drawing.Size(180, 29);
            this.txtname.TabIndex = 2;
            this.txtname.ValidationStyle.PasswordChar = '\0';
            this.txtname.Value = "";
            // 
            // elDivider1
            // 
            this.elDivider1.Location = new System.Drawing.Point(0, 91);
            this.elDivider1.Name = "elDivider1";
            this.elDivider1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.elDivider1.Size = new System.Drawing.Size(392, 24);
            this.elDivider1.TabIndex = 92;
            // 
            // txt_userName
            // 
            this.txt_userName.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_userName.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_userName.CaptionStyle.TextStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_userName.CaptionStyle.TextStyle.Text = "نام کاربری";
            this.txt_userName.EditBoxStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_userName.Location = new System.Drawing.Point(12, 12);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_userName.Size = new System.Drawing.Size(180, 29);
            this.txt_userName.TabIndex = 4;
            this.txt_userName.ValidationStyle.PasswordChar = '\0';
            this.txt_userName.Value = "";
            // 
            // txtfamily
            // 
            this.txtfamily.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txtfamily.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txtfamily.CaptionStyle.TextStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfamily.CaptionStyle.TextStyle.Text = "نام خانوادگی";
            this.txtfamily.EditBoxStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtfamily.Location = new System.Drawing.Point(212, 54);
            this.txtfamily.Name = "txtfamily";
            this.txtfamily.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtfamily.Size = new System.Drawing.Size(180, 29);
            this.txtfamily.TabIndex = 3;
            this.txtfamily.ValidationStyle.PasswordChar = '\0';
            this.txtfamily.Value = "";
            // 
            // txt_pass
            // 
            this.txt_pass.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_pass.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_pass.CaptionStyle.TextStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_pass.CaptionStyle.TextStyle.Text = "رمز عبور";
            this.txt_pass.EditBoxStyle.Font = new System.Drawing.Font("B Yekan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_pass.Location = new System.Drawing.Point(12, 56);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_pass.Size = new System.Drawing.Size(180, 29);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.ValidationStyle.PasswordChar = '\0';
            this.txt_pass.Value = "";
            // 
            // EditRespons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 176);
            this.Controls.Add(this.elContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(426, 215);
            this.MinimumSize = new System.Drawing.Size(426, 215);
            this.Name = "EditRespons";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  تنظیمات    ";
            this.Load += new System.EventHandler(this.EditRespons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elContainer1)).EndInit();
            this.elContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elDivider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfamily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Klik.Windows.Forms.v1.EntryLib.ELContainer elContainer1;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txtname;
        private Klik.Windows.Forms.v1.EntryLib.ELDivider elDivider1;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_userName;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_pass;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txtfamily;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_edit;
    }
}