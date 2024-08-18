namespace _11_MVC_FulboolOrnek.Models
{
    public class Futbolcu
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Yas { get; set; }    
        public int TakimID {  get; set; }   
        public Takim Takim { get; set; }
        public int MevkiID {  get; set; }
        public Mevki Mevki { get; set; }    
    }
}
