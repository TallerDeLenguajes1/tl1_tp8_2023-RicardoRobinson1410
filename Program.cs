// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
string rutacarpeta =@"C:\Users\USUARIO\Desktop\arquitecturadecomputadorasI";
string[] archivos=Directory.GetFiles(rutacarpeta);
string rutaarchivo=@"C:\Users\USUARIO\tl1_tp8_2023-RicardoRobinson1410\";
string nombre=@"index.csv";
string nombrearchivo=rutaarchivo+nombre;
StreamWriter guardararchivo=new StreamWriter(nombrearchivo);
int i=0;
foreach (var item in archivos)
{
    Console.WriteLine(item);
    string[] dividirnombreguardar=item.Split(@"\");
    string nombreguardar=dividirnombreguardar[dividirnombreguardar.Count()-1];
    string[] dividirextension=nombreguardar.Split('.');
    string extension=dividirextension[dividirextension.Count()-1];
    guardararchivo.WriteLine(i+nombreguardar+extension);
    i++;

}
guardararchivo.Close();

