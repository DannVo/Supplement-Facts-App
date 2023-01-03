using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineApp
{
    public class TempImpReceipt
    {
        private int proID;
        private string proName;
        private string proImg;
        private string proDesc;
        private int quantity;
        private float price;
        public int ProID { get => proID; set => proID = value; }
        public string ProName { get => proName; set => proName = value; }
        public string ProImg { get => proImg; set => proImg = value; }
        public string ProDesc { get => proDesc; set => proDesc = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
    }
}
