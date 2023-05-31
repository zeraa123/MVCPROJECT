namespace Proje.Models{
    public static class Repository{
     private static List<Candidate> applications = new();
     private static IEnumerable<Candidate> Applications=>applications;

     public static void Add(Candidate candidate){
        applications.Add(candidate);
     }
    }
}