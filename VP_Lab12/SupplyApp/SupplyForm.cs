using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplyApp
{

    public partial class SupplyForm : Form
    {

        public SupplyForm()
        {
            InitializeComponent();
        }

        public IEnumerable<Item> GetItems()
        {
            using (var db = new SupplyModel())
            {
                return db.Item.ToList();
            }
        }
        private void SetItemGrid()
        {
            if (itemGrid.ColumnCount < 4)
            {
                itemGrid.Columns.Add("colId", "Артикул");
                itemGrid.Columns.Add("colName", "Наименование");
                itemGrid.Columns.Add("colManufacturer", "Производитель");
                itemGrid.Columns.Add("colPrice", "Цена");
            }
            itemGrid.Rows.Clear();
            foreach (var item in GetItems())
            {
                itemGrid.Rows.Add(item.Id, item.Name, item.Manufacturer, item.Price);
            }
        }

        private void SupplyForm_Load(object sender, EventArgs e)
        {
            SetItemGrid();
        }
        private void refreshItem_Click(object sender, EventArgs e)
        {
            SetItemGrid();
        }
        private void addItem_Click(object sender, EventArgs e)
        {
            AddItemForm add = new AddItemForm();
            if (add.ShowDialog(this) == DialogResult.OK)
            {
                SetItemGrid();
            }
        }
        private void removeItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот элемент ? ",
                                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (itemGrid.SelectedCells.Count > 0)
                {
                    var i = itemGrid.SelectedCells[0].OwningRow.Index;
                    int itemId = (int)itemGrid[0, i].Value;
                    using (var db = new SupplyModel())
                    {
                        Item item = db.Item.Where(x => x.Id == itemId).First();
                        db.Item.Remove(item);
                        db.SaveChanges();
                    }
                }
            }
            SetItemGrid();

        }
    }

}
