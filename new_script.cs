using Godot;
using System;
namespace project {
	public partial class new_script : Node
	{
		private int _a = 2;
		private string _b = "textvar";
		public override void _Ready()
		{
			Robot bot = new Robot("AAAA", 67);
			bot.printVal();
		}
	}
}
