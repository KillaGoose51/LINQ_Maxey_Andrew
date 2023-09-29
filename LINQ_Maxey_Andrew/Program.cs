namespace LINQ_Maxey_Andrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game[] games = new Game[]
            {
                new Game("Minecraft", 'E', "Action-Adventure"),
                new Game("CS:GO", 'M', "FPS"),
                new Game("Elden Ring", 'M', "Action-Adventure"),
                new Game("Valorant", 'T', "FPS"),
                new Game("Halo 3", 'M', "Action FPS"),
                new Game("ZombCube", 'E', "FPS Survival"),
                new Game("Magnet Destroyer", 'E', "Hyper-Casual"),
                new Game("Paddle Balls", 'E', "Arcade Casual"),
                new Game("Rocket League", 'E', "Action Racing"),
                new Game("Fifa 22", 'E', "Sport"),
            };

            var shortgames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            foreach(var game in shortgames)
            {
                Console.WriteLine(game);
            }

            var mineCraft = games.Where(game => game.Title == "Minecraft")
                .Select(Game => $"Title: {Game.Title}, ESRB: {Game.Esrb}, Genre: {Game.Genre}");

            Console.WriteLine(mineCraft.FirstOrDefault());

            var tRated = from game in games
                         where game.Esrb == 'T'
                         select game.Title;

            Console.WriteLine("T Rated Games:");
            foreach(var game in tRated)
            {
                Console.WriteLine(game);
            }

            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            Console.WriteLine("E Rated Action Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}