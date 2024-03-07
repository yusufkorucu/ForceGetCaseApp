namespace ForceGet.Entity.Entites
{
    public class Unit1
    {
        public int Unit1Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
