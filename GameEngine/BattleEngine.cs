namespace GameEngine;

public enum BattleResult
{
    PlayerWin,
    OpponentWin,
    Draw
}

public static class BattleEngine
{
    public static BattleResult SimulateBattle(Board board)
    {
        int playerScore = 0;
        int opponentScore = 0;

        for (int i = 0; i < 7; i++)
        {
            var playerCard = board.MyCards[i];
            var opponentCard = board.OpponentCards[i];

            int result = ResolveCardFight(playerCard, opponentCard);
            if (result > 0) playerScore++;
            else if (result < 0) opponentScore++;
        }

        if (playerScore > opponentScore) return BattleResult.PlayerWin;
        if (opponentScore > playerScore) return BattleResult.OpponentWin;
        return BattleResult.Draw;
    }


    private static int ResolveCardFight(Card playerCard, Card opponentCard)
    {
        int playerValue = playerCard.Value;
        int opponentValue = opponentCard.Value;

        // Example: Shield gives +2 bonus
        if (playerCard.Properties.HasFlag(CardProperty.Shield))
            playerValue += 2;
        if (opponentCard.Properties.HasFlag(CardProperty.Shield))
            opponentValue += 2;

        // Example: Poison = instant kill (win)
        if (playerCard.Properties.HasFlag(CardProperty.Poison) &&
            !opponentCard.Properties.HasFlag(CardProperty.Stealth))
            return 1;

        if (opponentCard.Properties.HasFlag(CardProperty.Poison) &&
            !playerCard.Properties.HasFlag(CardProperty.Stealth))
            return -1;

        // Regular comparison
        if (playerValue > opponentValue) return 1;
        if (playerValue < opponentValue) return -1;
        return 0; // draw
    }
}