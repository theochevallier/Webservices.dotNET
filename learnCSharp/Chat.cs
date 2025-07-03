using System.Drawing;

public class Chat : Animal {


    public Chat(string name, string color) : base (name, color){
        
    }

    public new void action(){
        Console.WriteLine("voir la nuit");
    }

    public override void toString(){
        Console.WriteLine("je suis " + this.name + " qui voit la nuit");
    }
}