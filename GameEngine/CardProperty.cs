namespace GameEngine;

[Flags]
public enum CardProperty
{
    None = 0,
    DoubleStrike = 1 << 0,
    Shield = 1 << 1,
    Poison = 1 << 2,
    Taunt = 1 << 3,
    Stealth = 1 << 4,
    Reborn = 1 << 5
}