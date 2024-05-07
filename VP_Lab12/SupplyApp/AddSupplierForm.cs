using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyApp
{

	public partial class AddSupplierForm : Form
	{
		private int _id;
		private string _name;
		private string _address;
		private string _phone;


		public AddSupplierForm()
		{
			InitializeComponent();
		}
		public AddSupplierForm(Supplier supplier)
		{
			InitializeComponent();

			this.Text = "Редактировать поставщика";
			txtId.ReadOnly = true;
			btnAdd.Text = "Изменить";

			txtId.Text = supplier.Id.ToString();
			txtName.Text = supplier.Name;
			txtAddress.Text = supplier.Address;
			txtPhone.Text = supplier.Phone;
		}

		private void txtId_Validating(object sender, CancelEventArgs e)
		{
			string input = txtId.Text.Trim();
			if (Regex.IsMatch(input, @"(?<=\s|^)\d+(?=\s|$)"))
			{
				errorProvider.SetError(txtId, String.Empty);
				e.Cancel = false;
			}
			else
			{
				errorProvider.SetError(txtId, "Ошибка!");
				e.Cancel = true;
			}

		}
		private void txtId_Validated(object sender, EventArgs e)
		{
			_id = Convert.ToInt32(txtId.Text.Trim());
		}

		private void txtName_Validating(object sender, CancelEventArgs e)
		{
			string input = txtName.Text.Trim();
			if (Regex.IsMatch(input, @"^[А-Яа-яЁё\s\-]+$"))
			{
				errorProvider.SetError(txtName, String.Empty);
				e.Cancel = false;
			}
			else
			{
				errorProvider.SetError(txtName, "Ошибка!");
				e.Cancel = true;
			}
		}
		private void txtName_Validated(object sender, EventArgs e)
		{
			_name = txtName.Text.Trim();
		}

		private void txtAddress_Validating(object sender, CancelEventArgs e)
		{
			string input = txtAddress.Text.Trim();
			if (Regex.IsMatch(input, @"^[А-Яа-яЁё]+(?: [\s-][А-Яа-яЁё]+)*(?:\sул\.\s[А-Яа-яЁё]+(?: [\s-][А-Яа-яЁё]+)*\s\d+)?$"))
			{
				errorProvider.SetError(txtAddress, String.Empty);
				e.Cancel = false;
			}
			else
			{
				errorProvider.SetError(txtAddress, "Ошибка!");
				e.Cancel = true;
			}
		}
		private void txtAddress_Validated(object sender, EventArgs e)
		{
			_address = txtAddress.Text.Trim();
        }
		
		private void txtPhone_Validating(object sender, CancelEventArgs e)
		{
			string input = txtPhone.Text.Trim();
        if (Regex.IsMatch(input, @"^\d{5,7}$"))
        {
            errorProvider.SetError(txtPhone, String.Empty);
				e.Cancel = false;
			}
			else
			{
				errorProvider.SetError(txtPhone, "Ошибка!");
				e.Cancel = true;
			}
		}
		private void txtPhone_Validated(object sender, EventArgs e)
		{
			_phone = txtPhone.Text.Trim();
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{
			DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
			if (DialogResult == DialogResult.OK)
			{
				AddSupplier();
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

		private void AddSupplier()
		{
			try
			{
				using (var db = new SupplyModel())
				{
					if (txtId.ReadOnly)
					{
						Supplier old = db.Supplier.Find(_id);
						db.Supplier.Remove(old);
					}

					db.Supplier.Add(new Supplier
					{
						Id = _id,
						Name = _name,
						Address = _address,
						Phone = _phone
					});
					db.SaveChanges();
				}
				if (txtId.ReadOnly)
					MessageBox.Show("Данные изменены!", "Обновлено", MessageBoxButtons.OK);
				else
					MessageBox.Show("Данные добавлены!", "Добавлено", MessageBoxButtons.OK);
			}
			catch (Exception exc)
			{
				MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
			}
		}

	}

}
