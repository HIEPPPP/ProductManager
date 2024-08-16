using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Diagnostics;
using ProductManager.GUI;

namespace ProductManager
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPaint_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("mspaint.exe");
        }

        private void btnCalculator_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void btnProductList_ItemClick(object sender, ItemClickEventArgs e)
        {
            fProductList pList = new fProductList();
            pList.MdiParent = ActiveForm;
            pList.Show();
        }

        private void btnCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
}