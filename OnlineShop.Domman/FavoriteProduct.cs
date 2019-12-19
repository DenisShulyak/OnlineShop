namespace OnlineShop.Domans
{
    public class FavoriteProduct : Entity
    {
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}