namespace HausaufgabenV02;

public struct Punkt
{
    private double _x, _y;
    public double X {get => _x;}
    public double Y {get => _y;}

    public Punkt(double x, double y){
        // Ein Kopierkonstruktor ist bei einem  Struct obsolet da bei einem Struct kein Referenzverweis kopiert wird.
        _x = x;
        _y = y;
    }

}
