namespace Basics.Models{
    public class Candidate{

        public String? Email{get; set;}=String.Empty;
        public String? FirstName{get; set;}=String.Empty;
        public String? LastName{get; set;}=String.Empty;

        public int? Age{get; set;}
        public String? Topic{get; set;}=String.Empty;
        public DateTime Hour{get; set;}

        public Candidate(){
            Hour=DateTime.Now;
        }
    }
}