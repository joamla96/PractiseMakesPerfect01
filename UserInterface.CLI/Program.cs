using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.CLI {
	class Program {
		static void Main(string[] args) {
			Program program = new Program();
			program.Run();
		}

		private void Run() {
			bool running = true;
			while(running) {
				PrintMenu();
				ActMenu();
			}
		}

		private void PrintMenu() {
			Console.WriteLine("1. Biggest Int");
			Console.WriteLine("2. Biggest Letter");

			Console.WriteLine("\n 0. Exit");
		}

		private void ActMenu() {
			
		}
	}
}
