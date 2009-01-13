using System;

namespace Interface
{
	// Interface stuff.

	public enum CardType
	{
		Spades = 0, // Schoppen
		Hearts = 1, // Harten
        Clubs = 2, // Klaver
        Diamonds = 3 // Ruiten
	}

	public enum CardIndex
	{
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
		Jack = 11,
		Queen = 12,
		King = 13,
		Ace = 14
	}

	public class CardDesc
	{
		public CardDesc(
			CardType type,
			CardIndex index)
		{
			Type = type;
			Number = index;
		}

		public CardType Type;
		public CardIndex Number;
	}

	public class PlayerDesc
	{
		public String Name;
		public int Seat;
	}

	public class GameDesc
	{
		public PlayerDesc[] Players = new PlayerDesc[4]; // Filled with player info. Seat = index into array.
		public int MySeat; // Index of my player desc.
		public CardDesc[] MyCards = new CardDesc[13]; // Set of cards at begin of game.
	}

	public class RoundDesc
	{
		public int Round;
		public int StartPlayer;
		public int CurrentPlayer;
		public CardDesc[] PlayedCards;
		public int Turn;
	}
}
