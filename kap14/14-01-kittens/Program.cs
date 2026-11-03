for(int i = 0; i<11; i++){
    Kitten kitten = new Kitten(i); 
}
Console.WriteLine(Kitten.GetCount());





class Kitten {
    private double cuteness;

    private static int count = 0;

    public Kitten (double cuteness){
        this.cuteness = cuteness;
        
        count++;
    }

    public static int GetCount(){
    return count;

    }
}