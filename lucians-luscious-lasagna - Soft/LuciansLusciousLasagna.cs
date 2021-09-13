class Lasagna
{
    public int ExpectedMinutesInOven() => 40; 
    public double RemainingMinutesInOven(double minutes) => ExpectedMinutesInOven()-minutes;
    public int PreparationTimeInMinutes(int layers) => layers*2;
    //could add a exeption if they try use double with parameter. Layers always will be integers (i think, rs).
    public double ElapsedTimeInMinutes(int layers, double minutes) => PreparationTimeInMinutes(layers)+ minutes;

}
