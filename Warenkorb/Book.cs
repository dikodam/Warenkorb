namespace Warenkorb
{
    public class Book : WebShopItem
    {
        public string Author { get;  }

        public string Title { get; }

        public string Publisher { get; }

        public Book(long itemId, double price, string author, string title, string publisher) : base(itemId, price)
        {
            Author = author;
            Title = title;
            Publisher = publisher;
        }

        public override string Description()
        {
            return $"{base.Description()}, author: {Author}, title: {Title}, publisher: {Publisher}";
        }
    }
}