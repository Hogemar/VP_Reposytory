using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyApp
{

    public partial class AddItemForm : Form
    {
        private int _id;
        private string _name;
        private string _manufacturer;
        private decimal _price;


        public AddItemForm()
        {
            InitializeComponent();
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
            if(true)
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

        private void txtManufacturer_Validating(object sender, CancelEventArgs e)
        {
            string input = txtManufacturer.Text.Trim();
            if (true)
            {
                errorProvider.SetError(txtManufacturer, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtManufacturer, "Ошибка!");
                e.Cancel = true;
            }
        }
        private void txtManufacturer_Validated(object sender, EventArgs e)
        {
            _manufacturer = txtManufacturer.Text.Trim();
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            string input = txtPrice.Text.Trim();
            if (true)
            {
                errorProvider.SetError(txtPrice, String.Empty);
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtPrice, "Ошибка!");
                e.Cancel = true;
            }
        }
        private void txtPrice_Validated(object sender, EventArgs e)
        {
            _price = Convert.ToDecimal(txtPrice.Text.Trim());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
            if (DialogResult == DialogResult.OK)
            {
                AddItem();
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

        private void AddItem()
        {
            try
            {
                using (var db = new SupplyModel())
                {
                    db.Item.Add(new Item
                    {
                        Id = _id,
                        Name = _name,
                        Manufacturer = _manufacturer,
                        Price = _price
                    });
                    db.SaveChanges();
                }
                MessageBox.Show("Данные добавлены!", "Добавлено", MessageBoxButtons.OK);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ошибка в данных!", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }

}
