namespace CrmUi
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сущностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SellerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductAddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сущностиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сущностиToolStripMenuItem
            // 
            this.сущностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductToolStripMenuItem,
            this.SellerToolStripMenuItem,
            this.CustomerToolStripMenuItem,
            this.ChekToolStripMenuItem});
            this.сущностиToolStripMenuItem.Name = "сущностиToolStripMenuItem";
            this.сущностиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.сущностиToolStripMenuItem.Text = "Сущности";
            // 
            // ProductToolStripMenuItem
            // 
            this.ProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductAddToolStripMenuItem1});
            this.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem";
            this.ProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProductToolStripMenuItem.Text = "Товар";
            this.ProductToolStripMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // SellerToolStripMenuItem
            // 
            this.SellerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SellerAddToolStripMenuItem});
            this.SellerToolStripMenuItem.Name = "SellerToolStripMenuItem";
            this.SellerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellerToolStripMenuItem.Text = "Продавец";
            this.SellerToolStripMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // CustomerToolStripMenuItem
            // 
            this.CustomerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerAddToolStripMenuItem1});
            this.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem";
            this.CustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomerToolStripMenuItem.Text = "Покупатель";
            this.CustomerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // ChekToolStripMenuItem
            // 
            this.ChekToolStripMenuItem.Name = "ChekToolStripMenuItem";
            this.ChekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ChekToolStripMenuItem.Text = "Чек";
            this.ChekToolStripMenuItem.Click += new System.EventHandler(this.ChekToolStripMenuItem_Click);
            // 
            // SellerAddToolStripMenuItem
            // 
            this.SellerAddToolStripMenuItem.Name = "SellerAddToolStripMenuItem";
            this.SellerAddToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SellerAddToolStripMenuItem.Text = "Добавить";
            this.SellerAddToolStripMenuItem.Click += new System.EventHandler(this.SellerAddToolStripMenuItem_Click);
            // 
            // CustomerAddToolStripMenuItem1
            // 
            this.CustomerAddToolStripMenuItem1.Name = "CustomerAddToolStripMenuItem1";
            this.CustomerAddToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.CustomerAddToolStripMenuItem1.Text = "Добавить";
            this.CustomerAddToolStripMenuItem1.Click += new System.EventHandler(this.CustomerAddToolStripMenuItem1_Click);
            // 
            // ProductAddToolStripMenuItem1
            // 
            this.ProductAddToolStripMenuItem1.Name = "ProductAddToolStripMenuItem1";
            this.ProductAddToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ProductAddToolStripMenuItem1.Text = "Добавить";
            this.ProductAddToolStripMenuItem1.Click += new System.EventHandler(this.ProductAddToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 330);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сущностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SellerAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerAddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ProductAddToolStripMenuItem1;
    }
}

