using Godot;
using System;
namespace project {
	public partial class Robot : Node
	{
		private String name;
		private int weight;
		
		public int Weight{
				get{
					return this.weight;
				}
				set{
					if(value < 1)
						this.weight = 1;
					else
						this.weight = value;
				}
			}
		public string Name{get {
				return name;
		}
		private set{}}
		public Robot(String name, int weight) {
				this.setValues(name,weight);
		}
		 public void setValues(String name, int weight){
				this.name = name;
				this.weight = weight;
		 }
		public static void print(){
				System.Console.WriteLine("Hello");
			}
		public void printVal()
			{
				GD.Print(this.Name + " weight:" + this.Weight);
			}
	}
}
