using Classes;

public class GameEngine
{
    private BaseGameAccount player1;
    private BaseGameAccount player2;

    public GameEngine(BaseGameAccount player1, BaseGameAccount player2)
    {
        this.player1 = player1;
        this.player2 = player2;
    }

    // Метод для проведення гри
    public void PlayGame(BaseGame game, string result, IGameService gameService)
    {
        if (result == "Win")
        {
            player1.WinGame(game, player2.UserName);
            player2.LoseGame(game, player1.UserName);

            // Запис гри для переможця
            gameService.CreateGame(new Game(player1.UserName, "Win", game.CalculateRating()));
        }
        else if (result == "Lose")
        {
            player1.LoseGame(game, player2.UserName);
            player2.WinGame(game, player1.UserName);

            // Запис гри для переможця
            gameService.CreateGame(new Game(player2.UserName, "Win", game.CalculateRating()));
        }
        else
        {
            throw new ArgumentException("Некоректний результат гри");
        }
    }

}
