namespace HausaufgabenV02;
using System.Collections.Generic;


public struct Kantenzug
{
    private List<Punkt> _list;
    /*==================================================================================================================================================*/    
    //    Mir ist nicht bewusst ob es gefordert war ein Array zu verwenden oder eine Liste.                                                             //   
    //    Bei der Formulierung war mir nicht klar ob man die Länge im Konstruktor mit übergeben soll oder die                                           //
    //    Länge simpel einfach nur via eine Property abrufbar machen soll. Ich denke die Problematik sollte ja bei dem Datentyp Array/Liste sein        //
    //    das wir keine Refernzkopie erhalten wollen. Diese Problematik habe ich behoben.                                                               //
    /*==================================================================================================================================================*/
    public List<Punkt> List{get => _list;}
    private List<Punkt> forCopy = new List<Punkt>();
    private int _anzahlKanten;
    public int AnzahlPunkte {get => _anzahlKanten; private set => _anzahlKanten = value; }

    public Kantenzug(List<Punkt> list, int anz){
        if(list == null || list.Count == 0){
            throw new Exception("Liste leer oder Null");
        }
        _list = list;
        AnzahlPunkte = anz;

    }

    public void verschieben(double x, double y){
        foreach(var e in _list){
            forCopy.Add(new Punkt(e.X+x,e.Y+y));
            
        }
        _list = forCopy;
        
        
    }

    override public string ToString() {
        string s = "";
        for(int i = 0; i < _list.Count; i++){
            s += $"{_list[i].X}:{_list[i].Y}  ";
        }
        
        return s;
    }

    public Kantenzug copy(){
    
        return new Kantenzug(this._list, AnzahlPunkte);
    } 
}
