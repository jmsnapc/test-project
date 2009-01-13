using System;

namespace Interface
{
	public interface IInterface
	{
		void HandleGameCreate(GameDesc gameDesc); // New game has been started. No passing yet.
		void HandleGameBegin(GameDesc gameDesc); // Passing done. Game has started.
		void HandleRoundBegin(); // New round. Give AI a chance to prepare, redraw, whatever.
		void HandlePlay(RoundDesc round, CardDesc card); // Player played card.
		void RequestPass(int toPlayer, out CardDesc[] out_cards); // Select 3 cards to pass to player.
		void RequestCard(RoundDesc round, out CardDesc out_card); // Request player to play card.
	}
}
