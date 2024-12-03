using prjAdoDotNetDemo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prjPosDemo.Views
{
    public partial class FrmCustomerList : Form
    {
        private int _pageCount = 3;
        int _position = -1;
        private List<tCustomer> _list;
        public FrmCustomerList()
        {
            InitializeComponent();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            displayCustomers();
        }

        private void displayCustomers()
        {
            dbDemoEntities3 db = new dbDemoEntities3();
            var x = from c in db.tCustomer
                    select c;

            _list = x.ToList();
            dataGridView1.DataSource = _list;
            resetGridStyle();

            cboCustomerName.Items.Clear();
            cboCustomerName.Items.Add("顯示所有");
            foreach (var t in x)
            {
                cboCustomerName.Items.Add(t.fName + " [" + t.fEmail + "] ");
            }

            cboPage.Items.Clear();
            int page = x.ToList().Count / _pageCount;
            if (x.ToList().Count % _pageCount > 0) page++;
            for (int i = 1; i <= page; i++)
            {
                cboPage.Items.Add(i.ToString());
            }
        }

        private void resetGridStyle()
        {
            // 設定各欄位寬度
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;

            if (dataGridView1.Columns.Count > 2)
            {
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 200;
            }

            //dataGridView1.Columns[6].Width = 200;
            // RowHeadersWidth: 第一個欄位(只有箭頭)的寬度
            //dataGridView1.Columns[5].Width = dataGridView1.Width - 50 - 400 - 100 * 3 - 200 - dataGridView1.RowHeadersWidth;

            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged;

                // 各列的字體和大小
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 14);
                r.DefaultCellStyle.BackColor = Color.WhiteSmoke;

                // 各列的顏色交替變換
                if (isColorChanged) r.DefaultCellStyle.BackColor = Color.FromArgb(238, 238, 242);
            }
        }

        private void FrmCustomerList_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dbDemoEntities3 db = new dbDemoEntities3();
            var x = from c in db.tCustomer
                    where c.fEmail.Contains("@gmail.com") && c.fAddress == "Taipei"
                    select c;
            dataGridView1.DataSource = x.ToList();
            resetGridStyle();
        }

        private void cboCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboCustomerName.Text)) return;
            //MessageBox.Show(cboCustomerName.Text);

            dbDemoEntities3 db = new dbDemoEntities3();
            if (cboCustomerName.Text == "顯示所有")
            {
                displayCustomers();
            }
            else
            {
                var tb = from c in db.tCustomer
                         where (c.fName + " [" + c.fEmail + "]") == cboCustomerName.Text
                         select c;
                dataGridView1.DataSource = tb.ToList();
            }

            resetGridStyle();
        }

        // NEW 按鈕
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            // 這段程式碼是使用 Entity Framework 的語法，從資料庫中提取特定資料表(tCustomer) 的數據，
            // 並篩選出兩個欄位(fEmail 和 fPassword)，然後將這些欄位的內容重新命名為 "帳號" 和 "密碼"。
            dbDemoEntities3 db = new dbDemoEntities3();
            // 從每一筆資料中選取欄位 fEmail 和 fPassword，
            // 使用匿名類型(new { ... }) 把結果中的欄位重命名為：
            // 帳號 對應資料表中的 fEmail。
            // 密碼 對應資料表中的 fPassword。
            var tb = from c in db.tCustomer
                     select new { 帳號 = c.fEmail, 密碼 = c.fPassword };
            dataGridView1.DataSource = tb.ToList();
            resetGridStyle();
        }

        // Order By 按鈕
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dbDemoEntities3 db = new dbDemoEntities3();
            var tb = from c in db.tCustomer
                     orderby c.fName descending
                     select c;
            dataGridView1.DataSource = tb.ToList();
            resetGridStyle();
        }

        // Take button
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            dbDemoEntities3 db = new dbDemoEntities3();
            var tb = from c in db.tCustomer
                     orderby c.fName descending
                     select c;
            // tb.Take(2)：從排序結果中取出前 2 筆 資料。
            dataGridView1.DataSource = tb.Take(2).ToList();
            resetGridStyle();
        }

        // Skip button
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            dbDemoEntities3 db = new dbDemoEntities3();
            var tb = from c in db.tCustomer
                     orderby c.fName descending
                     select c;
            // Skip(2)：跳過排序結果的前 2 筆 資料。
            dataGridView1.DataSource = tb.Skip(2).Take(2).ToList();
            resetGridStyle();
        }

        // 選擇不同分頁
        private void cboPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cboPage.SelectedItem.ToString());
            dbDemoEntities3 db = new dbDemoEntities3();
            var tb = from c in db.tCustomer
                     orderby c.fName descending
                     select c;
            int n = (Convert.ToInt32(cboPage.Text) - 1) * _pageCount;
            // 每頁顯示 _pageCount 筆資料
            dataGridView1.DataSource = tb.Skip(n).Take(_pageCount).ToList();
            resetGridStyle();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmCustomerEditor f = new FrmCustomerEditor();
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                dbDemoEntities3 db = new dbDemoEntities3();
                
                // 新增資料
                db.tCustomer.Add(f.customer);

                // SaveChanges() 是 Entity Framework 的方法，把資料存進資料庫
                db.SaveChanges();

                displayCustomers();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        // 刪除按鈕
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_position < 0) return;

            // 第一個參數: "確定要刪除嗎?" 是對話框中顯示的訊息，表示詢問使用者是否確定要刪除。
            // 第二個參數: "確認" 是對話框的標題，表示該對話框的用途。
            // 第三個參數: MessageBoxButtons.YesNo 是按鈕選項，表示該對話框會有「是(Yes)」和「否(No)」兩個選擇。
            if (MessageBox.Show("確定要刪除嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.No) return;

            tCustomer uiCustomer = _list[_position]; // 畫面上的資料
            dbDemoEntities3 db = new dbDemoEntities3();

            // FirstOrDefault 是 C# LINQ（Language Integrated Query）的一個方法，用於從集合中檢索符合條件的第一個元素。
            // 如果找不到符合條件的元素，會返回集合的默認值（對於參考型別是 null，對於數值型別是該數值型別的默認值，例如 0）

            // 把 db.tCustomer 這個集合中的每一筆資料依序代入 t，如果符合後面的條件，就會返回第一筆符合的資料，
            // 如果找不到符合條件的資料，會返回 db.tCustomer 的默認值
            tCustomer dbCustomer = db.tCustomer.FirstOrDefault(t => t.fId == uiCustomer.fId); // 真正存在資料庫裡的資料
            
            if (dbCustomer == null) return;
            db.tCustomer.Remove(dbCustomer);
            db.SaveChanges();
            displayCustomers();
            //MessageBox.Show(t.fId.ToString());
        }

        // delegate 逐漸轉變成 Lambda 的過程==========================================
        //public void callM1()
        //{
        //    D1 d = new D1(this.m1);
        //    MessageBox.Show(d.ToString());
        //}

        public void callM1()
        {
            // 使用 delegate 關鍵字定義了一個匿名方法，這個方法的實現如下：
            // 接受一個參數 string p。
            // 回傳字串 "Hello," 與參數 p 的組合結果。

            // 匿名方法類似於一般的方法，但它沒有名稱，並且可以直接被指派給委派類型的變數。

            // D1 d 是委派類型的變數。
            // 使用 = 將匿名方法指派給變數 d。
            // 之後，變數 d 就可以被用來像函式一樣呼叫這個匿名方法。
            D1 d = delegate (string p)
            {
                return "Hello," + p;
            };
            MessageBox.Show(d("macro"));
        }

        public string m1(string p)
        {
            return "Hello," + p;
        }

        public delegate string D1(string P);
        // delegate 逐漸轉變成 Lambda 的過程==========================================
    }
}
