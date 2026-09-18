// ============================================================
// EJERCICIO 1: POTENCIA ELÉCTRICA DE UN MOTOR DE CD
// ============================================================
//
// PLANTEAMIENTO DEL PROBLEMA:
// Diseñe un programa que solicite al usuario el voltaje y
// la corriente consumida por un motor de corriente directa.
//
// El programa deberá calcular la potencia eléctrica mediante:
//
//                  P = V * I
//
// Después deberá clasificar el funcionamiento del motor:
//
// a) Si la potencia es menor o igual a 120 W:
//    "CONSUMO NORMAL".
//
// b) Si la potencia es mayor que 120 W:
//    "ADVERTENCIA: CONSUMO ELEVADO".
// ============================================================


// ------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA
// ------------------------------------------------------------
// Se utiliza Console.WriteLine() para mostrar en pantalla
// el nombre del ejercicio y el planteamiento del problema.
// Esto permite identificar claramente qué problema está
// ejecutando el usuario.

Console.WriteLine("============================================================");
Console.WriteLine("             EJERCICIO 1 - MOTOR DE CD");
Console.WriteLine("============================================================");

Console.WriteLine("PLANTEAMIENTO DEL PROBLEMA:");
Console.WriteLine("Diseñe un programa que solicite al usuario el voltaje");
Console.WriteLine("y la corriente consumida por un motor de corriente directa.");
Console.WriteLine("El programa calculará la potencia mediante P = V * I.");
Console.WriteLine("Si P <= 120 W: CONSUMO NORMAL.");
Console.WriteLine("Si P > 120 W: ADVERTENCIA: CONSUMO ELEVADO.");

Console.WriteLine("============================================================");
Console.WriteLine();


// ------------------------------------------------------------
// ENTRADAS
// ------------------------------------------------------------
// El programa necesita dos datos proporcionados por el usuario:
//
// 1. Voltaje del motor, expresado en volts (V).
// 2. Corriente consumida por el motor, expresada en amperes (A).
//
// Se utiliza el tipo de dato double porque permite almacenar
// números enteros y decimales.


// Solicitar el voltaje al usuario.
Console.Write("Ingrese el voltaje del motor (V): ");

// Console.ReadLine() recibe el dato como texto.
// Convert.ToDouble() convierte ese texto a un número decimal.
// El valor convertido se almacena en la variable "voltaje".
double voltaje = Convert.ToDouble(Console.ReadLine());


// Solicitar la corriente al usuario.
Console.Write("Ingrese la corriente consumida (A): ");

// Nuevamente, Console.ReadLine() recibe el dato como texto
// y Convert.ToDouble() lo convierte a un número decimal.
// El resultado se almacena en la variable "corriente".
double corriente = Convert.ToDouble(Console.ReadLine());


// ------------------------------------------------------------
// PROCESO
// ------------------------------------------------------------
// Para calcular la potencia eléctrica se utiliza la fórmula:
//
//                  P = V * I
//
// Donde:
// P = Potencia eléctrica en watts (W)
// V = Voltaje en volts (V)
// I = Corriente en amperes (A)
//
// Por lo tanto, multiplicamos el voltaje por la corriente.

double potencia = voltaje * corriente;


// ------------------------------------------------------------
// MOSTRAR RESULTADOS
// ------------------------------------------------------------
// Después de realizar el cálculo, mostramos los valores
// introducidos por el usuario y la potencia obtenida.

Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("RESULTADOS");
Console.WriteLine("------------------------------------------------------------");

// :F2 indica que el número se mostrará con dos decimales.
Console.WriteLine($"Voltaje: {voltaje:F2} V");
Console.WriteLine($"Corriente: {corriente:F2} A");
Console.WriteLine($"Potencia eléctrica: {potencia:F2} W");


// ------------------------------------------------------------
// CLASIFICACIÓN DEL CONSUMO
// ------------------------------------------------------------
// Ahora debemos determinar si el consumo del motor es normal
// o elevado.
//
// Se utiliza una estructura condicional if-else.
//
// La condición establece que si la potencia es menor o igual
// a 120 W, el consumo se considera normal.
//
// Si la condición NO se cumple, significa que la potencia
// es mayor a 120 W y se debe mostrar una advertencia.

if (potencia <= 120)
{
    // Esta instrucción se ejecuta cuando la potencia es
    // menor o igual a 120 W.
    Console.WriteLine("CONSUMO NORMAL");
}
else
{
    // Esta instrucción se ejecuta cuando la potencia
    // es mayor a 120 W.
    Console.WriteLine("ADVERTENCIA: CONSUMO ELEVADO");
}