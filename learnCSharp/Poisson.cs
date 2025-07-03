public class Poisson : Animal {

    public string attractedTo;

    public Poisson (string name, string color, string attractedTo) : base (name, color){
        this.attractedTo = attractedTo;
    }

    public string getAttractedTo(){
        return this.attractedTo;
    }

    public void setAttractedTo(string stuff){
        this.attractedTo = stuff;
    }

    public new void action(){
        Console.WriteLine("nager dans l'océan");
    }

    public override void toString(){
        Console.WriteLine("je suis " + this.name + " qui nage dans l'ocean");
    }
}