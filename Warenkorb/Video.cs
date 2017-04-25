namespace Warenkorb
{
    public class Video : WebShopItem
    {
        public string Title { get; }

        public string Regisseur { get; }

        public bool IsDlcAvaiable { get; }

        public Video(long itemId, double price, string title, string regisseur, bool isDlcAvaiable) : base(itemId,
            price)
        {
            Title = title;
            Regisseur = regisseur;
            IsDlcAvaiable = isDlcAvaiable;
        }

        public override string Description()
        {
            return $"{base.Description()}, title: {Title}, regisseur: {Regisseur}, avaiavle as DLC: {IsDlcAvaiable}";
        }
    }
}