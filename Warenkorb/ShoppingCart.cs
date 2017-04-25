using System;
using System.Text;

namespace Warenkorb
{
    internal class ShoppingCart
    {
        private WebShopItem[] cartItems;
        private int index;

        /// <summary>
        ///
        /// </summary>
        /// <param name="maxItems"></param>
        public ShoppingCart(int maxItems = 10)
        {
            cartItems = new WebShopItem[maxItems];
        }

        public string CartDescription()
        {
            StringBuilder sb = new StringBuilder();
            foreach (WebShopItem item in cartItems)
            {
                sb.AppendLine(item.Description());
            }
            return sb.ToString();
        }

        public double CartSum()
        {
            double sum = 0;
            foreach (WebShopItem item in cartItems)
            {
                sum += item.Price;
            }
            return sum;
        }

        public void Add(WebShopItem newItem)
        {
            if (!(index < cartItems.Length))
            {
                throw new Exception("Warenkorb ist voll!");
            }
            cartItems[index] = newItem;
            index++;
        }
    }
}