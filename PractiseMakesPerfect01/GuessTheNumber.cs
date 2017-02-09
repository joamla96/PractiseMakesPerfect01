using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMakesPerfect01 {
	public class GuessTheNumber {
		public int MaxGuess = 7;

		public int Guesses = 0;
		private int RandomNumber;

		private static Random rnd = new Random();

		public GuessTheNumber() {
			RandomNumber = rnd.Next(1, 100);
		}

		public int Guess(int Guess) {
			Guesses++;
			int result = 0;
			if(Guess == RandomNumber) {
				result = 0;
			} else if(Guess > RandomNumber) {
				result = 1;
			} else if(Guess < RandomNumber) {
				result = -1;
			}
			
			return result;
		}
	}
}
