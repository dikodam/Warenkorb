namespace Warenkorb
{
    public abstract class WebShopItem
    {
        public long ItemID { get; }
        public double Price { get; set; }

        public WebShopItem(long itemId, double price)
        {
            this.ItemID = itemId;
            this.Price = price;
        }

        public virtual string Description()
        {
            return $"itemID: {ItemID}, price: {Price}";
        }
    }
}