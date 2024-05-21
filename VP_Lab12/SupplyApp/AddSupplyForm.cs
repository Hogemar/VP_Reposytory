using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SupplyApp
{

	public partial class AddSupplyForm : Form
	{
		private int _supplier;
		private int _item;
		private DateTime _date;
		private int? _volume;


		public AddSupplyForm()
		{
			InitializeComponent();
		}
		public AddSupplyForm(Supply supply)
		{
			InitializeComponent();

			this.Text = "Редактировать поставку";
			btnAdd.Text = "Изменить";

			_supplier = supply.Supplier;
			_item = supply.Item;

			txtDate.Text = supply.Date.ToShortDateString();
			txtDate.ReadOnly = true;
			txtVolume.Text = supply.Volume.ToString();
		}


		private void AddSupplyForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "itemDataSet.Item". При необходимости она может быть перемещена или удалена.
			this.itemTableAdapter1.Fill(this.itemDataSet.Item);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "supplierDataSet.Supplier". При необходимости она может быть перемещена или удалена.
			this.supplierTableAdapter1.Fill(this.supplierDataSet.Supplier);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "supplyDataSet1.Item". При необходимости она может быть перемещена или удалена.
			this.itemTableAdapter.Fill(this.supplyDataSet1.Item);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "supplyDataSet.Supplier". При необходимости она может быть перемещена или удалена.
			this.supplierTableAdapter.Fill(this.supplyDataSet.Supplier);
		}
		private void AddSupplyForm_Shown(object sender, EventArgs e)
		{
			if(_supplier != 0)
			{
				boxSupplier.SelectedValue = _supplier;
				boxItem.SelectedValue = _item;

				boxItem.Enabled = false;
				boxSupplier.Enabled = false;
			}

			Calendar.MaxDate = Calendar.TodayDate;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
			if (DialogResult == DialogResult.OK)
			{
				AddSupply();
				this.Close();
			}
			else
			{
				MessageBox.Show("Введите корректные данные!", "Ошибка",
			   MessageBoxButtons.OK);
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.None;
			this.Close();
		}
		private void txtPhone_MouseClick(object sender, MouseEventArgs e)
		{
			(sender as MaskedTextBox).Select(0, 0);
		}

		private void AddSupply()
		{
			try
			{
				using (var db = new SupplyModel())
				{
					if (boxSupplier.Enabled == false)
					{
						Supply old = db.Supply.Find(_supplier, _item, _date);
						db.Supply.Remove(old);
					}

					db.Supply.Add(new Supply
					{
						Supplier = _supplier,
						Item = _item,
						Date = _date,
						Volume = _volume
					});
					db.SaveChanges();
				}
				if (boxSupplier.Enabled == false)
					MessageBox.Show("Данные изменены!", "Обновлено", MessageBoxButtons.OK);
				else
					MessageBox.Show("Данные добавлены!", "Добавлено", MessageBoxButtons.OK);
			}
			catch (Exception exc)
			{
				MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
			}
		}


		private void txtDate_Validating(object sender, CancelEventArgs e)
		{
			if (!String.IsNullOrEmpty(txtDate.Text))
			{
				errorProvider.SetError(txtDate, String.Empty);
					e.Cancel = false;
					return;
			}

			errorProvider.SetError(txtDate, "Ошибка!");
			e.Cancel = true;
		}
		private void txtDate_Validated(object sender, EventArgs e)
		{
			_date = Convert.ToDateTime(txtDate.Text.Trim());
		}

		private void boxSupplier_Validating(object sender, CancelEventArgs e)
		{
			string input = boxSupplier.Text.Trim();
			if (Regex.IsMatch(input, @"^[А-Яа-яЁё\s\-]+$"))
			{
				errorProvider.SetError(boxSupplier, String.Empty);
				e.Cancel = false;
			}
			else
			{
				errorProvider.SetError(boxSupplier, "Ошибка!");
				e.Cancel = true;
			}

		}
		private void boxSupplier_Validated(object sender, EventArgs e)
		{
			using (var db = new SupplyModel())
			{
				_supplier = (int) boxSupplier.SelectedValue;
			}
		}

		private void boxItem_Validating(object sender, CancelEventArgs e)
		{
			string input = boxItem.Text.Trim();
			if (Regex.IsMatch(input, @"^[А-Яа-яЁё\s\-]+$"))
			{
				errorProvider.SetError(boxItem, String.Empty);
				e.Cancel = false;
			}
			else
			{
				errorProvider.SetError(boxItem, "Ошибка!");
				e.Cancel = true;
			}

		}
		private void boxItem_Validated(object sender, EventArgs e)
		{
			_item = (int) boxItem.SelectedValue;
		}

		private void txtVolume_Validating(object sender, CancelEventArgs e)
		{
			string input = txtVolume.Text.Trim();
			if (Regex.IsMatch(input, @"^\d+$"))
			{
				errorProvider.SetError(txtVolume, String.Empty);
				e.Cancel = false;
			}
			else
			{
				errorProvider.SetError(txtVolume, "Ошибка!");
				e.Cancel = true;
			}
		}
		private void txtVolume_Validated(object sender, EventArgs e)
		{
			_volume = Convert.ToInt32(txtVolume.Text.Trim());
		}

		private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			txtDate.Text = Calendar.SelectionStart.ToShortDateString();
		}
	}

}
