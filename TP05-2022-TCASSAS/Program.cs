// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero");
int numero = Int32.Parse(Console.ReadLine());
int numeroAuxiliar = numero;

String numeroInvertido = "";
if(numero >= 0) {
    while(numeroAuxiliar > 0) {
        int digito = numeroAuxiliar % 10;
        numeroAuxiliar /= 10;

        // Condición para evitar numeros con 0's a la izquierda (ejemplos: 500, 50050)
        if((numeroInvertido.Length == 0 && digito != 0) || (numeroInvertido.Length > 0)) {
            numeroInvertido += digito;
        }
    }
    Console.WriteLine("Numero invertido: " + numeroInvertido);
} else {
    Console.WriteLine("Numero negativo detectado, resultado: " + numero);
}