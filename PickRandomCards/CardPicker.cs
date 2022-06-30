using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
	internal class CardPicker
	{
		static Random random = new Random();


		public static string[] PickSomeCards(int numberOfCards)
		{
			string[] pickedCards = new string[numberOfCards];
			for (int i = 0; i < numberOfCards; i++)
			{
				pickedCards[i] = RandomValue() + " of " + RandomSuit();
			}
			return pickedCards;
		}

		private static string RandomSuit()
		{
			int value = random.Next(1, 5);
			string suit;
			switch(value)
			{
				case 1:
					suit = "Spades";
					break;
				case 2:
					suit = "Hearts";
					break;
				case 3:
					suit = "Clubs";
					break;
				default:
					suit = "Diamonds";
					break;
			}
			return suit;
		}

		private static string RandomValue()
		{
			int value = random.Next(1, 14);
			string number;
			switch (value)
			{
				case 1:
					number = "Ace";
					break;
				case 11:
					number = "Jack";
					break;
				case 12:
					number = "Queen";
					break;
				case 13:
					number = "King";
					break;
				default:
					number = value.ToString();
					break;
			}
			return number;
		}
	}
}
