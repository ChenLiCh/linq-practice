//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjPosDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class tCustomer
    {
        public int fId { get; set; }

        // [DisplayName("姓名")] 是一個屬性(Attribute)，主要用來為屬性(Property) 添加描述或顯示名稱。
        // 於資料表格(DataGridView) 或其他 UI 控件中，屬性名稱可能會自動用作欄位標題，而 DisplayName 可以提供更友好的名稱。
        // 這個屬性不會改變程式邏輯或資料庫結構，它純粹是為了 UI 或開發者的友好性。
        // 對於資料庫欄位或程式碼屬性名稱，還是使用 fName，但在用戶界面上顯示的文字會是 姓名。
        [DisplayName("姓名")]
        public string fName { get; set; }

        [DisplayName("電話")]
        public string fPhone { get; set; }

        public string fEmail { get; set; }

        [DisplayName("地址")]
        public string fAddress { get; set; }

        [DisplayName("密碼")]
        public string fPassword { get; set; }
    }
}
