// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
Console.WriteLine("Ingrese la cantidad de tareas que desea ingresar");
string? a= Console.ReadLine();
int canttareas;
int duracion=0;
bool anda1=int.TryParse(a,out canttareas);
if(anda1){
    Console.WriteLine("Ingreso cantidad de tareas exitoso");
}
var tareaspendientes=new List<tarea>();
var tareasrealizadas=new List<tarea>();

for (int i = 0; i < canttareas; i++)
{
    Console.WriteLine("Ingrese la descripcion");
    string? desc=Console.ReadLine();
    tareaspendientes.Add(new tarea(i,desc));
    duracion+=tareaspendientes[i].Duracion;
}
void MoverTareas(List<tarea> tareaspendientes, List<tarea> tareasrealizadas, int canttareas){
    int indice=0;
    for(int i=0;i<canttareas;i++){
        Console.WriteLine("marque como realizada (1) o pendiente (0)");
        string? b=Console.ReadLine();
        int marcar;
        bool anda2=int.TryParse(b, out marcar);
        if(anda2){
            Console.WriteLine("Ingreso exitoso");
        }
        if(marcar==1){
            tareaspendientes[indice].Cambiarestadoarealizado();
            tareasrealizadas.Add(tareaspendientes[indice]);
            tareaspendientes.RemoveAt(indice);
            indice--;
        }
        indice++;
            }
        }
    MoverTareas(tareaspendientes,tareasrealizadas, tareaspendientes.Count);
    Console.WriteLine("=============TAREAS PENDIENTES==========");
    for(int j=0;j<tareaspendientes.Count;j++){
        tareaspendientes[j].Mostrar();
    }
    Console.WriteLine("==========TAREAS EN PROCESO===========");
    for(int k=0;k<tareasrealizadas.Count;k++){
        tareasrealizadas[k].Mostrar();
    }
    Console.WriteLine("===========TAREAS EN PROCESO CON DESCRIPCION========");
    Console.WriteLine("Ingrese la descripcion que desea");
    string? ingresardesc=Console.ReadLine();
    for(int s=0;s<tareaspendientes.Count;s++){
        tareaspendientes[s].mostrartareascondesc(ingresardesc);
    }

StreamWriter archivo=new StreamWriter(@"C:\Users\USUARIO\tl1_tp8_2023-RicardoRobinson1410/Punto1.4.txt");
archivo.WriteLine($"DURACION: {duracion}");
archivo.Close();

    
    

