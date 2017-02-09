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

			Console.WriteLine("\n 0. Exit");
		}

		private void ActMenu() {
			switch(GetInput("number")) {
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
