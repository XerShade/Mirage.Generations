using Mirage.Generations.Client.MonoGame;

namespace Mirage.Generations.Client;

public class MirageClient
{
    private static void Main(string[] args)
    {
        using var game = new MirageGame();
        game.Run();
    }
}