using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjShoppingApp.Models {
    public class CShoppingCartItem {
        [DisplayName("產品名稱")]
        public string productName { get; set; }
        [DisplayName("採購量")]
        public int count { get; set; }
        [DisplayName("單價")]
        public decimal price { get; set; }
        [DisplayName("小計")]
        public decimal pay {
            get { return this.price * this.count; }
        }
    }
}
