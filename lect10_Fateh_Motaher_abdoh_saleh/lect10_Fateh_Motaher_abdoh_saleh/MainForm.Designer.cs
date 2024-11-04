namespace lect10_Fateh_Motaher_abdoh_saleh
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.إدارةالملفاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالطلابToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(355, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إدارةالملفاتToolStripMenuItem,
            this.ملفToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(355, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // إدارةالملفاتToolStripMenuItem
            // 
            this.إدارةالملفاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةطالبToolStripMenuItem,
            this.عرضالطلابToolStripMenuItem});
            this.إدارةالملفاتToolStripMenuItem.Name = "إدارةالملفاتToolStripMenuItem";
            this.إدارةالملفاتToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.إدارةالملفاتToolStripMenuItem.Text = "إدارة بيانات الطلاب";
            this.إدارةالملفاتToolStripMenuItem.Click += new System.EventHandler(this.إدارةالملفاتToolStripMenuItem_Click);
            // 
            // اضافةطالبToolStripMenuItem
            // 
            this.اضافةطالبToolStripMenuItem.Name = "اضافةطالبToolStripMenuItem";
            this.اضافةطالبToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اضافةطالبToolStripMenuItem.Text = "اضافة طالب";
            this.اضافةطالبToolStripMenuItem.Click += new System.EventHandler(this.اضافةطالبToolStripMenuItem_Click);
            // 
            // عرضالطلابToolStripMenuItem
            // 
            this.عرضالطلابToolStripMenuItem.Name = "عرضالطلابToolStripMenuItem";
            this.عرضالطلابToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.عرضالطلابToolStripMenuItem.Text = "عرض الطلاب";
            this.عرضالطلابToolStripMenuItem.Click += new System.EventHandler(this.عرضالطلابToolStripMenuItem_Click);
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اغلاقToolStripMenuItem,
            this.اغلاقالكلToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // اغلاقToolStripMenuItem
            // 
            this.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem";
            this.اغلاقToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اغلاقToolStripMenuItem.Text = "اغلاق";
            this.اغلاقToolStripMenuItem.Click += new System.EventHandler(this.اغلاقToolStripMenuItem_Click);
            // 
            // اغلاقالكلToolStripMenuItem
            // 
            this.اغلاقالكلToolStripMenuItem.Name = "اغلاقالكلToolStripMenuItem";
            this.اغلاقالكلToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.اغلاقالكلToolStripMenuItem.Text = "اغلاق الكل";
            this.اغلاقالكلToolStripMenuItem.Click += new System.EventHandler(this.اغلاقالكلToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 297);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem إدارةالملفاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالطلابToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقالكلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
    }
}