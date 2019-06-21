using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ButtonEditWithPadding
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            gridControl1.DataSource = CreateTable();

            gridView1.Columns[0].ColumnEdit = repositoryItemPaddingButtonEdit1;
            gridView1.Columns[1].ColumnEdit = repositoryItemPaddingButtonEdit2;

        }

        DataTable CreateTable()
        {
            DataTable table = new DataTable();
            DataRow dataRow;

            table.Columns.Add("Prod_NO", typeof(string));
            table.Columns.Add("Prod_Name", typeof(string));
            table.Columns.Add("Order_Date", typeof(string));
            table.Columns.Add("Quantity", typeof(string));

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "101";
            dataRow["Prod_Name"] = "Product1";
            dataRow["Order_Date"] = "12/06/2012";
            dataRow["Quantity"] = "50";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "102";
            dataRow["Prod_Name"] = "Product2";
            dataRow["Order_Date"] = "15/06/2012";
            dataRow["Quantity"] = "70";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "103";
            dataRow["Prod_Name"] = "Product3";
            dataRow["Order_Date"] = "18/06/2012";
            dataRow["Quantity"] = "30";
            table.Rows.Add(dataRow);

            dataRow = table.NewRow();
            dataRow["Prod_NO"] = "104";
            dataRow["Prod_Name"] = "Product4";
            dataRow["Order_Date"] = "25/06/2012";
            dataRow["Quantity"] = "20";
            table.Rows.Add(dataRow);

            return table;
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e)
		{
			Padding buttonPadding = new Padding(Convert.ToInt32(((SpinEdit)sender).EditValue));
            paddingButtonEdit1.Properties.Padding = buttonPadding;
			((RepositoryItemPaddingButtonEdit)gridView1.Columns[0].ColumnEdit).Padding = buttonPadding;
			((RepositoryItemPaddingButtonEdit)gridView1.Columns[1].ColumnEdit).Padding = buttonPadding;
		}
	}
}
