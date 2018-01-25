using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomCafe_Assignement
{
    class OrderItem
    {
        private int quantity;
        private MenuItem item;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public MenuItem Item
        {
            get { return item; }
            set { item = value; }
        }

        /*Constructors*/
        public OrderItem() { } 
         
        public OrderItem(MenuItem i)
        {
            item = i;
        }

        /*Method*/

        public void AddQty()
        {

        }
        public bool RemoveQty()
        {
            return true;
        }
        public double GetItemGTotalAmt()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return base.ToString();
        }
     
    }
}
