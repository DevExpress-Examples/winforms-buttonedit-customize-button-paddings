using System;
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
			this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
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
