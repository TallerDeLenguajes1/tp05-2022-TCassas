// See https://aka.ms/new-console-template for more information
Console.WriteLine("- Ingrese el numero de la operación matematica que desea ralizar --");
int opcionElegida = printMenuYEligeOpcion();
List<int> numeros = new List<int>();

while(opcionElegida != 0) {
    numeros = solicitarNumeros();
    switch(opcionElegida) {
        case 1:
            sumar(numeros);
            break;
        case 2:
            restar(numeros);
            break;
    }

    Console.WriteLine("-- ¿Desea realizar otra operación matematica? --");
    opcionElegida = printMenuYEligeOpcion();
}

int printMenuYEligeOpcion() {
    Console.WriteLine("\t1: Sumar");
    Console.WriteLine("\t2: Restar");
    Console.WriteLine("\t3: Multiplicar");
    Console.WriteLine("\t4: Dividir");
    Console.WriteLine("\t0: Salir");

    int decision = Int32.Parse(Console.ReadLine());
    while(decision < 0 && decision > 4) {
        Console.WriteLine("Opcion invalida, elija un numero dentro de la lista");
        decision = Int32.Parse(Console.ReadLine());
    }

    return decision;
}

void sumar(List<int> numeros) {
    int acumulador = 0;
    Console.WriteLine("Resultado:");
    numeros.ForEach(numero => {
        acumulador += numero;
        Console.Write(numero + " + ");
        
    });
    Console.WriteLine(" = " + acumulador);
}

void restar(List<int> numeros) {
    int acumulador = numeros[0];
    Console.WriteLine("Resultado:");
    if(numeros.Count > 1) {
        for(int i = 1; i < numeros.Count; i++) {
            acumulador -= numeros[i];
            Console.Write(numeros[i] + " + ");
        }
        Console.WriteLine(" = " + acumulador);
    } else {
        Console.WriteLine(" = " + acumulador);
    }
}

List<int> solicitarNumeros() {
    List<int> numerosSolicitados = new List<int>();
    Console.WriteLine("¿Cuantos numeros desea ingrear?");
    int cantidadNumeros = Int32.Parse(Console.ReadLine());

    if(cantidadNumeros == 0) return solicitarNumeros();

    for(int i = 0; i < cantidadNumeros; i++) {
        Console.WriteLine("- Ingrese el numero° " + (i + 1));
        numerosSolicitados.Add(Int32.Parse(Console.ReadLine()));
    }

    return numerosSolicitados;
}