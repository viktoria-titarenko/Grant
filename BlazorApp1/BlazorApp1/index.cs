namespace BlazorApp1
{
    public class index
    {
        public string? Name { get; set; }
        public string? Year { get; set; }
        public int Semestr { get; set; }

        public string? Faculty { get; set; }  
        
        public string? Fio { get; set; }    
        public string? Number { get; set; } 

        public string? Email { get; set; }

        public List<int> Nomination = new List<int>();
        public string? Date { get; set; }
    }
}
