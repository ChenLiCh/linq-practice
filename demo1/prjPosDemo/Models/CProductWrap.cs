using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPosDemo.Models
{
    public class CProductWrap
    {
        public CProductWrap(tProduct p)
        {
            _product = p;
        }

        private tProduct _product;

        public tProduct product
        {
            get { return _product; }
            set { _product = value; }
        }

        public int fId { get { return _product.fId; } set { _product.fId = value; } }

        public string fName { get { return _product.fName; } set { _product.fName = value; } }

        public Nullable<int> fQty { get { return _product.fQty; } set { _product.fQty = value; } }

        public Nullable<decimal> fCost { get { return _product.fCost; } set { _product.fCost = value; } }

        public Nullable<decimal> fPrice { get { return _product.fPrice; } set { _product.fPrice = value; } }

        public string fMemo { get { return _product.fMemo; } set { _product.fMemo = value; } }

        public byte[] fImage { get { return _product.fImage; } set { _product.fImage = value; } }
    }
}
