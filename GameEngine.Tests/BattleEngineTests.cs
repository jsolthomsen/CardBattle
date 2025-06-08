namespace GameEngine.Tests;

[TestClass]
public class BattleEngineTests
{
    [TestMethod]
    public void SimulateBattle_PlayerWins_MostRounds()
    {
        var board = new Board
        {
            MyCards = Enumerable.Repeat(new Card { Value = 7 }, 7).ToList(),
            OpponentCards = Enumerable.Repeat(new Card { Value = 5 }, 7).ToList()
        };

        var result = BattleEngine.SimulateBattle(board);

        Assert.AreEqual(BattleResult.PlayerWin, result);
    }
}
