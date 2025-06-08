namespace GameEngine;

public class Board
{
    public List<Card> MyCards { get; set; } = new List<Card>();
    
    public List<Card> OpponentCards { get; set; } = new List<Card>();
}