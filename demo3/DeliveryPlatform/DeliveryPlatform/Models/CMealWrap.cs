using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryPlatform.Models {
    public class CMealWrap {
        private tMeal _meal;
        public CMealWrap(tMeal m) {
            _meal = m;
        }

        public tMeal meal {
            get { return _meal; }
            set { _meal = value; }
        }

        public int fId { get { return _meal.fMealId; } set { _meal.fMealId = value; } }

        public string fName { get { return _meal.fMealName; } set { _meal.fMealName = value; } }

        public Nullable<int> fQty { get { return _meal.fMealQuantity; } set { _meal.fMealQuantity = value; } }

        public Nullable<decimal> fCost { get { return _meal.fMealCost; } set { _meal.fMealCost = value; } }

        public Nullable<decimal> fPrice { get { return _meal.fMealPrice; } set { _meal.fMealPrice = value; } }

        public string fMemo { get { return _meal.fMealMemo; } set { _meal.fMealMemo = value; } }

        public byte[] fImage { get { return _meal.fMealImage; } set { _meal.fMealImage = value; } }
    }
}
