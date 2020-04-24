namespace CrmUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.EntitiesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sellerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.languageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bindingSource1, "EntitiesMenu", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.menuStrip2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "EntitiesMenu", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntitiesMenu,
            this.addToolStripMenuItem,
            this.settingsMenu});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // EntitiesMenu
            // 
            this.EntitiesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productMenuItem,
            this.sellerMenuItem,
            this.customerToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.markToolStripMenuItem});
            this.EntitiesMenu.Name = "EntitiesMenu";
            this.EntitiesMenu.Size = new System.Drawing.Size(57, 20);
            this.EntitiesMenu.Text = "Entities";
            // 
            // productMenuItem
            // 
            this.productMenuItem.Name = "productMenuItem";
            this.productMenuItem.Size = new System.Drawing.Size(126, 22);
            this.productMenuItem.Text = "Product";
            this.productMenuItem.Click += new System.EventHandler(this.ProductToolStripMenuItem_Click);
            // 
            // sellerMenuItem
            // 
            this.sellerMenuItem.Name = "sellerMenuItem";
            this.sellerMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sellerMenuItem.Text = "Seller";
            this.sellerMenuItem.Click += new System.EventHandler(this.SellerToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.CustomerToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.CheckToolStripMenuItem_Click);
            // 
            // markToolStripMenuItem
            // 
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.markToolStripMenuItem.Text = "Mark";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem1,
            this.productToolStripMenuItem1,
            this.sellerToolStripMenuItem1,
            this.markToolStripMenuItem1});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // customerToolStripMenuItem1
            // 
            this.customerToolStripMenuItem1.Name = "customerToolStripMenuItem1";
            this.customerToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.customerToolStripMenuItem1.Text = "Customer";
            this.customerToolStripMenuItem1.Click += new System.EventHandler(this.CustomerToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem1
            // 
            this.productToolStripMenuItem1.Name = "productToolStripMenuItem1";
            this.productToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.productToolStripMenuItem1.Text = "Product";
            this.productToolStripMenuItem1.Click += new System.EventHandler(this.ProductToolStripMenuItem1_Click);
            // 
            // sellerToolStripMenuItem1
            // 
            this.sellerToolStripMenuItem1.Name = "sellerToolStripMenuItem1";
            this.sellerToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.sellerToolStripMenuItem1.Text = "Seller";
            this.sellerToolStripMenuItem1.Click += new System.EventHandler(this.SellerToolStripMenuItem1_Click);
            // 
            // markToolStripMenuItem1
            // 
            this.markToolStripMenuItem1.Name = "markToolStripMenuItem1";
            this.markToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.markToolStripMenuItem1.Text = "Mark";
            this.markToolStripMenuItem1.Click += new System.EventHandler(this.markToolStripMenuItem1_Click);
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageMenuItem});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(61, 20);
            this.settingsMenu.Text = "Settings";
            // 
            // languageMenuItem
            // 
            this.languageMenuItem.Name = "languageMenuItem";
            this.languageMenuItem.Size = new System.Drawing.Size(126, 22);
            this.languageMenuItem.Text = "Language";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(CrmBL.Models.Language);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1157, 794);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem entitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem EntitiesMenu;
        private System.Windows.Forms.ToolStripMenuItem productMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sellerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem languageMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

