namespace Warenkorb
{
    public class CD : WebShopItem
    {
        public string Interpret { get; }
        public string AlbumName { get; }
        public int SongCount { get; }

        public CD(long itemId, double price, string interpret, string albumName, int songCount) : base(itemId, price)
        {
            Interpret = interpret;
            AlbumName = albumName;
            SongCount = songCount;
        }

        public override string Description()
        {
            return $"CD: {base.Description()}, interpret: {Interpret}, album name: {AlbumName}, song count: {SongCount}";
        }
    }
}