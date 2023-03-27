namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string> {"Super Mario Brothers", "Uncharted", "Uncharted 2", "Uncharted 3", "MLB The Show 2019", 
                "MLB The Show 2023", "TECMO Super Bowl", "Sudoku", "Lego Lord of the Rings" };
            
            var NewGames = games.OrderBy(x => x.Length);
            foreach (var game in NewGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
