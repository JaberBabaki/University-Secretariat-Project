namespace personnelMangement.forms
{
    partial class ListOfMessage
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
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfMessage));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.Btn_Save = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elButton1 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.elButton2 = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridEX1.DataMember = "id";
            this.gridEX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Font = new System.Drawing.Font("B Yekan", 8.25F);
            this.gridEX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.gridEX1.GroupByBoxVisible = false;
            this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.AllCharacters;
            this.gridEX1.Location = new System.Drawing.Point(1, 1);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.RecordNavigator = true;
            this.gridEX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridEX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.gridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.gridEX1.Size = new System.Drawing.Size(553, 309);
            this.gridEX1.TabIndex = 84;
            this.gridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Btn_Save.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.Btn_Save.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.Btn_Save.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Save.Location = new System.Drawing.Point(386, 329);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(157, 48);
            this.Btn_Save.TabIndex = 1;
            this.Btn_Save.TextStyle.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Save.TextStyle.Text = "نمایش";
            this.Btn_Save.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // elButton1
            // 
            this.elButton1.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.elButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.elButton1.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton1.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elButton1.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.Location = new System.Drawing.Point(199, 329);
            this.elButton1.Name = "elButton1";
            this.elButton1.Size = new System.Drawing.Size(157, 48);
            this.elButton1.TabIndex = 2;
            this.elButton1.TextStyle.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.elButton1.TextStyle.Text = "حذف";
            this.elButton1.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton1.Click += new System.EventHandler(this.elButton1_Click);
            // 
            // elButton2
            // 
            this.elButton2.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.elButton2.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.elButton2.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.elButton2.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton2.Location = new System.Drawing.Point(12, 329);
            this.elButton2.Name = "elButton2";
            this.elButton2.Size = new System.Drawing.Size(157, 48);
            this.elButton2.TabIndex = 3;
            this.elButton2.TextStyle.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.elButton2.TextStyle.Text = "ارسال پیام";
            this.elButton2.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elButton2.Click += new System.EventHandler(this.elButton2_Click);
            // 
            // ListOfMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 389);
            this.Controls.Add(this.elButton2);
            this.Controls.Add(this.elButton1);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.gridEX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(571, 428);
            this.MinimumSize = new System.Drawing.Size(571, 428);
            this.Name = "ListOfMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    لیست پیام";
            this.Activated += new System.EventHandler(this.Form10_Activated);
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton Btn_Save;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton elButton2;
    }
}