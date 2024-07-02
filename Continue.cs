using Godot;
using System;
namespace project {
	public partial class Continue : Button
	{
		public void printCS(string s, int a){
			Robot bot = new Robot(s, a);
			bot.printVal();
		}
	}
}
