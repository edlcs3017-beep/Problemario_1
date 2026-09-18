// ============================================================
// EJERCICIO 2: PROMEDIO DE TEMPERATURA DE UN MOTOR
// ============================================================
//
// PLANTEAMIENTO DEL PROBLEMA:
//
// Un sensor mide diez veces la temperatura de un motor.
// Diseñe un programa en el que se escriba una sola vez
// las instrucciones para solicitar las diez mediciones,
// sumarlas y calcular la temperatura promedio.
//
// El programa deberá indicar:
//
// a) TEMPERATURA NORMAL, si el promedio es menor o igual
//    que 70 °C.
//
// b) ALERTA DE TEMPERATURA, si el promedio es mayor
//    que 70 °C.
// ============================================================


// ------------------------------------------------------------
// ENCABEZADO DEL PROGRAMA
// ------------------------------------------------------------
// Se muestra el nombre del ejercicio y el planteamiento
// del problema en la consola.

Console.WriteLine("============================================================");
Console.WriteLine("       EJERCICIO 2 - TEMPERATURA DE UN MOTOR");
Console.WriteLine("============================================================");

Console.WriteLine("PLANTEAMIENTO DEL PROBLEMA:");
Console.WriteLine("Un sensor mide diez veces la temperatura de un motor.");
Console.WriteLine("El programa solicitará las diez mediciones,");
Console.WriteLine("las sumará y calculará la temperatura promedio.");
Console.WriteLine();
Console.WriteLine("Si el promedio es menor o igual que 70 °C:");
Console.WriteLine("TEMPERATURA NORMAL.");
Console.WriteLine();
Console.WriteLine("Si el promedio es mayor que 70 °C:");
Console.WriteLine("ALERTA DE TEMPERATURA.");

Console.WriteLine("============================================================");
Console.WriteLine();


// ------------------------------------------------------------
// VARIABLES
// ------------------------------------------------------------
// La variable "suma" almacenará la suma de las diez
// temperaturas.
//
// Se inicializa en 0 porque todavía no hemos ingresado
// ninguna medición.
//
// Se utiliza double porque las temperaturas pueden tener
// valores decimales.

double suma = 0;


// ------------------------------------------------------------
// CICLO FOR
// ------------------------------------------------------------
// El problema solicita exactamente diez mediciones.
//
// El ciclo for permite escribir las instrucciones para
// solicitar la temperatura una sola vez y repetirlas
// automáticamente diez veces.
//
// La variable "i" comienza en 1.
// Mientras i sea menor o igual que 10, el ciclo continúa.
// Después de cada repetición, i aumenta en 1.
//
// Por lo tanto, el ciclo se ejecutará:
//
// 1, 2, 3, 4, 5, 6, 7, 8, 9 y 10.

for (int i = 1; i <= 10; i++)
{
    // --------------------------------------------------------
    // ENTRADA DE DATOS
    // --------------------------------------------------------
    // En cada repetición solicitamos una nueva medición
    // de temperatura.

    Console.Write($"Ingrese la temperatura #{i} (°C): ");

    // Console.ReadLine() recibe el dato como texto.
    // Convert.ToDouble() convierte el texto a un número
    // decimal y lo almacena en la variable temperatura.

    double temperatura = Convert.ToDouble(Console.ReadLine());


    // --------------------------------------------------------
    // ACUMULACIÓN DE LAS TEMPERATURAS
    // --------------------------------------------------------
    // Se agrega la temperatura actual a la variable "suma".
    //
    // Por ejemplo, si las primeras mediciones fueran:
    //
    // 60 + 65 + 70
    //
    // la variable suma irá almacenando:
    //
    // Primera medición: suma = 60
    // Segunda medición: suma = 125
    // Tercera medición: suma = 195
    //
    // y así sucesivamente hasta completar las 10 mediciones.

    suma = suma + temperatura;
}


// ------------------------------------------------------------
// CÁLCULO DEL PROMEDIO
// ------------------------------------------------------------
// Después de que el ciclo termina, ya tenemos las diez
// temperaturas acumuladas en la variable "suma".
//
// Para obtener el promedio utilizamos:
//
//       Promedio = Suma de temperaturas / Número de mediciones
//
// Como siempre son diez mediciones, dividimos entre 10.

double promedio = suma / 10;


// ------------------------------------------------------------
// MOSTRAR RESULTADOS
// ------------------------------------------------------------
// Se muestran la suma total y el promedio calculado.
//
// ":F2" permite mostrar los valores con dos decimales.

Console.WriteLine();
Console.WriteLine("------------------------------------------------------------");
Console.WriteLine("RESULTADOS");
Console.WriteLine("------------------------------------------------------------");

Console.WriteLine($"Suma de las temperaturas: {suma:F2} °C");
Console.WriteLine($"Temperatura promedio: {promedio:F2} °C");


// ------------------------------------------------------------
// CLASIFICACIÓN DE LA TEMPERATURA
// ------------------------------------------------------------
// Ahora se compara el promedio con el límite establecido
// en el problema: 70 °C.
//
// Si el promedio es menor o igual a 70 °C, se considera
// que la temperatura es normal.
//
// Si el promedio es mayor a 70 °C, se genera una alerta.

if (promedio <= 70)
{
    // Esta instrucción se ejecuta cuando el promedio
    // es menor o igual a 70 °C.

    Console.WriteLine("TEMPERATURA NORMAL");
}
else
{
    // Esta instrucción se ejecuta cuando el promedio
    // es mayor a 70 °C.

    Console.WriteLine("ALERTA DE TEMPERATURA");
}