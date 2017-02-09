using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMakesPerfect01 {
	public class Tools {

		// Ex A
		public int GetBiggerInt(int a, int b) {
			if (a > b) { // If they're the same, we still just return b, so all good
				return a;
			} else return b;
		}

		// Ex B
		public int GetBiggerInt(int a, int b, int c) {
			if (a > b && a > c) { // IF a is bigger than B and bigger than C
				return a;
			} else if (b > a && b > c) { // IF B is bigger than A and bigger than C
				return b;
			} else { // Neither A nor B was bigger than C, so theyre either all equal or C is the biggest.
				return c;
			}
		}

		// Ex C
		public int GetBiggerLetter(char a, char b) { // Chars convert easily to ints, and vise versa.
			return (char)GetBiggerInt((int)a, (int)b); // Lets just use the one we made already :)
		}

		// Ex D & E
		public int GetRemainder(int Number, int Divisor) {
			if (Divisor == 0) {
				throw new DivideByZeroException(); // Would very likely have been thrown automatically, but yeah....
			}
			int Remainder = Number;
			while(Remainder > Divisor) {
				Remainder = Remainder - Divisor;
			}

			return Remainder;
		}


		// Ex F
		public int CountCharsInString(char Char, string String) {
			int Counter = 0;
			foreach(Char A in String) {
				if (A == Char) Counter++;
			}

			return Counter;
		}

	}
}
