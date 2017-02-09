using System;
using TextValidator;
using PractiseMakesPerfect01;

namespace UserInterface.CLI {
	class Program {
		Tools Tool = new Tools();
		private bool running = true;
		static void Main(string[] args) {
			Program program = new Program();
			program.Run();
		}

		private void Run() {
			
			while(this.running) {
				PrintMenu();
				ActMenu();
			}
		}

		private void PrintMenu() {
			Console.Clear();

			Console.WriteLine("1. Biggest Int");
			Console.WriteLine("2. Biggest Letter");
			Console.WriteLine("3. Modulo");
			Console.WriteLine("4. Guess The Number");

			Console.WriteLine("\n0. Exit");
		}

		private void ActMenu() {
			string Input = GetInput("number");
			Console.Clear();
			switch(Input) {
				case "0":
					this.running = false;
					break;
				case "3":
					Console.WriteLine("Number: ");
					int Number = int.Parse(GetInput("number"));

					Console.WriteLine("Divisor: ");
					int Divisor = int.Parse(GetInput("number"));

					Console.WriteLine("Actual Mod: " + Number % Divisor);
					Console.WriteLine("My Mod: " + Tool.GetRemainder(Number, Divisor));
					break;

				case "4":
					GuessTheNumber GTN = new GuessTheNumber();
					bool InGame = true;
					while(GTN.Guesses <= GTN.MaxGuess && InGame) {
						Console.WriteLine("\nGuess a number: ");
						int Guess = int.Parse(GetInput());

						int Result = GTN.Guess(Guess);
						if(Result == 0) {
							InGame = false;
							Console.WriteLine("You gussed right!");
						} else if(Result < 0) {
							Console.WriteLine("Your guess was too low");
						} else if(Result > 0) {
							Console.WriteLine("Your guess was too high");
						}
					}

					Console.WriteLine("\nGame Over!");
					Console.ReadKey();
					break;

				default:
					Console.WriteLine("Could not find menu action...");
					break;
			}

			Console.ReadKey();
		}

		private string GetInput(string Type = "", string error = "") {
			Validator Valid = new Validator();
			string input = Console.ReadLine();
			switch(Type) {
				case "number":
					if (!Valid.Number(input)) return this.GetInput(Type, "Please type a valid numbers");
					break;
			}

			return input;
		}
	}
}
