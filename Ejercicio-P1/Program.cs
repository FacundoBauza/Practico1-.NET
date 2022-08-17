using Entidades;

bool exit = false;
int op = 0;
Persona p;
List<Persona> aux = new List<Persona>();
string Nombre;
string Apellido;
string Documento;
int edad;
int dia;
int mes;
int anio;


while (exit == false)
{
    Console.WriteLine("Bienvenido");
    Console.WriteLine();
    Console.WriteLine("-Agregar Usuario: 1");
    Console.WriteLine("-Exit: 2");
    Console.WriteLine();
    Console.WriteLine("-Op: ");
    op = int.Parse(Console.ReadLine());

    if(op != 1 && op != 2)
    {
        Console.Clear();
        Console.WriteLine("Opcion incorrecta");
        Console.WriteLine("-Agregar Usuario: 1");
        Console.WriteLine("-Exit: 2");
        Console.WriteLine();
        Console.WriteLine("-Op: ");
    }
    else if(op == 1)
    {
        Console.Clear();
        Console.WriteLine("Nombre: ");
        Nombre = Console.ReadLine();
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Apellido: ");
        Apellido = Console.ReadLine();
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Documento: ");
        Documento = Console.ReadLine();
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Edad: ");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Fecha de Nacimiento");
        Console.WriteLine();
        Console.WriteLine("Dia: ");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Mes: ");
        mes = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Anio: ");
        anio = int.Parse(Console.ReadLine());
        Console.WriteLine();

        p = new Persona(Nombre, Apellido, Documento, edad, fechaNac(dia, mes, anio));
        aux.Add(p);
    }
    else if(op == 2)
    {
        aux = (List<Persona>)aux.OrderBy(x => x.Edad).ToList();

        foreach( Persona z in aux){
            Console.WriteLine(z.Nombre);
        }
        exit = true;
    }

}

DateTime fechaNac(int dia, int mes, int anio)
{
    DateTime x = new DateTime();

    if (dia != null && mes != null && anio != null)
    {
        if(dia > 0 && mes > 0 && anio > 0)
        {
            x = new DateTime(anio, mes, dia);
        }
        else
        {
            Console.WriteLine("Los valores no corresponden");
        }
    }
    else
    {
        if (dia == null)
        {
            Console.WriteLine("Falta ingresar el dia");
        }
        else if (mes == null)
        {
            Console.WriteLine("Falta ingresar el mes");
        }
        else if (anio == null)
        {
            Console.WriteLine("Falta ingresar el anio ");
        }
    }

    return x;
}