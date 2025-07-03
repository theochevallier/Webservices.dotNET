public abstract class Animal {
    public string name;
    public string color;

    public Animal(string name, string color){
        this.name = name;
        this.color = color;
    }

    public string getName(){
        return this.name;
    }

    public void setName(string name){
        this.name = name;
    }

    public string getColor(){
        return this.color;
    }

    public void setColor(string color){
        this.color = color;
    }

    public abstract void toString();
    // public override string ToString()
    // {
    //     return base.ToString();
    // }

    public void action(){
        Console.WriteLine("animal");
    }

    
}