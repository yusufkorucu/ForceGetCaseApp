namespace ForceGet.Entity.Entites
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
     
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Unit1> Units1 { get; set; }
        public virtual ICollection<Unit2> Units2 { get; set; }

    }
}
