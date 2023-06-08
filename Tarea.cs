enum estado{
    pendiente=0,
    realizada=1
}
class tarea{
    private int tareaid;
    public string? descripcion;
    private int duracion;
    public estado estadotarea;

    public int Tareaid { get => tareaid; set => tareaid = value; }
    public int Duracion { get => duracion; set => duracion = value; }
    
    public tarea(int ingresartareaid, string? descripciontarea){
        tareaid=ingresartareaid;
        descripcion=descripciontarea;
        Random numaleatorio=new Random();
        duracion=numaleatorio.Next(10,101);
        estadotarea=0;
    }
    public void Mostrar(){
            Console.WriteLine($"DESCRIPCION: {descripcion}");
            Console.WriteLine($"ID: {Tareaid}");
            Console.WriteLine($"DURACION: {Duracion}");
        }
    public void Cambiarestadoarealizado(){
        estadotarea=estado.realizada;
    }
    public void mostrartareascondesc(string? desc){
        if(descripcion==desc){
            Mostrar();
        }
    }
}
