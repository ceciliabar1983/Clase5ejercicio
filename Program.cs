// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Escribir un programa que haga lo siguiente:

//1) Borrar la pantalla.
//2) Pedir el nombre de una persona.
//3) Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"
//4) Preguntar si se quiere continuar.
//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".


//5) Si la respuesta es "S" repetir desde el punto 1.
//6) Si la respuesta es "N" finalizar el programa mostrando un mensaje que diga "Programa finalizado correctamente".
//7) Si la respuesta no es ni "S" ni "N" que tambien finalice el programa, pero mostrando un mensaje que diga "Opcion no valida".


string respuesta = "S";


while (respuesta.ToUpper() == "S")
{
    // Borrar la pantalla

    Console.Clear();

    //Pedir el nombre de una persona

    Console.WriteLine("¡ Hola! Ingrese su nombre: ");
    string nombre = Console.ReadLine();

    // Saludarlo con un texto que diga "¡Hola [NombreIngresado]!"

   
    Console.WriteLine($"¡Hola { nombre }!");

    // Preguntar si se quiere continuar.

    Console.WriteLine("Desea continuar? (Ingrese S para si o N para no)");
    respuesta = Console.ReadLine();



}
if (respuesta.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opcion no valida");
}
