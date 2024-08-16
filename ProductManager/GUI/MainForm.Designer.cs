namespace ProductManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProductList = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalculator = new DevExpress.XtraBars.BarButtonItem();
            this.btnPaint = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnProductList,
            this.btnAddProduct,
            this.btnCategory,
            this.btnAddCategory,
            this.btnCalculator,
            this.btnPaint,
            this.btnExit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1006, 172);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnProductList
            // 
            this.btnProductList.Caption = "Product List";
            this.btnProductList.Id = 1;
            this.btnProductList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProductList.ImageOptions.SvgImage")));
            this.btnProductList.LargeWidth = 75;
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductList_ItemClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Caption = "Add Product";
            this.btnAddProduct.Id = 2;
            this.btnAddProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddProduct.ImageOptions.SvgImage")));
            this.btnAddProduct.LargeWidth = 75;
            this.btnAddProduct.Name = "btnAddProduct";
            // 
            // btnCategory
            // 
            this.btnCategory.Caption = "Category";
            this.btnCategory.Id = 3;
            this.btnCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCategory.ImageOptions.SvgImage")));
            this.btnCategory.LargeWidth = 75;
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategory_ItemClick);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Caption = "Add Category";
            this.btnAddCategory.Id = 4;
            this.btnAddCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddCategory.ImageOptions.SvgImage")));
            this.btnAddCategory.LargeWidth = 75;
            this.btnAddCategory.Name = "btnAddCategory";
            // 
            // btnCalculator
            // 
            this.btnCalculator.Caption = "Calculator";
            this.btnCalculator.Id = 5;
            this.btnCalculator.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCalculator.ImageOptions.SvgImage")));
            this.btnCalculator.LargeWidth = 75;
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalculator_ItemClick);
            // 
            // btnPaint
            // 
            this.btnPaint.Caption = "Microsoft Paint";
            this.btnPaint.Id = 6;
            this.btnPaint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPaint.ImageOptions.SvgImage")));
            this.btnPaint.LargeWidth = 75;
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPaint_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 7;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.LargeWidth = 75;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Products";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProductList);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCategory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddCategory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCalculator);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPaint);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 610);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1006, 30);
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 640);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Product List - Product Manager";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnProductList;
        private DevExpress.XtraBars.BarButtonItem btnAddProduct;
        private DevExpress.XtraBars.BarButtonItem btnCategory;
        private DevExpress.XtraBars.BarButtonItem btnAddCategory;
        private DevExpress.XtraBars.BarButtonItem btnCalculator;
        private DevExpress.XtraBars.BarButtonItem btnPaint;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
    }
}