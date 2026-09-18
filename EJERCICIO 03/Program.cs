// ============================================================
// EJERCICIO 3: SIMULACIÓN DE CARGA DE UNA BATERÍA
// ============================================================
//
// PLANTEAMIENTO DEL PROBLEMA:
//
// Diseñe un programa que simule la carga de una batería
// de 12.6 V.
//
// El usuario deberá ingresar:
// a) El voltaje inicial de la batería.
// b) El incremento de voltaje producido en cada ciclo.
//
// Mediante un ciclo while, el programa aumentará el voltaje
// hasta alcanzar 12.6 V.
//
// En cada repetición deberá mostrar el número de ciclo
// y el voltaje actual.
//
// Si el incremento introducido es igual o menor que cero,
// el programa deberá mostrar un mensaje de error y no
// ejecutar la simulación.
// ============================================================


// ------------------------------------------------------------
// ENCABEZADO
// ------------------------------------------------------------

Console.WriteLine("============================================================");
Console.WriteLine("       EJERCICIO 3 - CARGA DE UNA BATERÍA");
Console.WriteLine("============================================================");

Console.WriteLine("PLANTEAMIENTO DEL PROBLEMA:");
Console.WriteLine("Simular la carga de una batería de 12.6 V.");
Console.WriteLine("El usuario ingresará el voltaje inicial y");
Console.WriteLine("el incremento de voltaje de cada ciclo.");
Console.WriteLine();
Console.WriteLine("La simulación utilizará un ciclo WHILE.");
Console.WriteLine("Si el incremento es menor o igual a cero,");
Console.WriteLine("se mostrará un mensaje de error.");

Console.WriteLine("============================================================");
Console.WriteLine();


// ------------------------------------------------------------
// ENTRADAS
// ------------------------------------------------------------

// Se solicita el voltaje inicial.
// Se utiliza double porque puede contener decimales.

Console.Write("Ingrese el voltaje inicial de la batería (V): ");
double voltaje = Convert.ToDouble(Console.ReadLine());


// Se solicita el incremento que tendrá el voltaje
// en cada ciclo.

Console.Write("Ingrese el incremento de voltaje por ciclo (V): ");
double incremento = Convert.ToDouble(Console.ReadLine());


// ------------------------------------------------------------
// VALIDACIÓN
// ------------------------------------------------------------

// El incremento debe ser mayor que cero.
// Si es cero o negativo, no se puede realizar la simulación.

if (incremento <= 0)
{
    Console.WriteLine();
    Console.WriteLine("ERROR: El incremento debe ser mayor que cero.");
    Console.WriteLine("La simulación no puede ejecutarse.");
}
else
{
    // --------------------------------------------------------
    // INICIO DE LA SIMULACIÓN
    // --------------------------------------------------------

    // El contador comienza en 1 porque la primera medición
    // corresponde al ciclo 1.

    int ciclo = 1;

    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("SIMULACIÓN DE CARGA");
    Console.WriteLine("------------------------------------------------------------");


    // --------------------------------------------------------
    // CICLO WHILE
    // --------------------------------------------------------
    //
    // El ciclo continúa mientras el voltaje todavía no haya
    // alcanzado los 12.6 V.

    while (voltaje < 12.6)
    {
        // Mostramos el ciclo y el voltaje actual.

        Console.WriteLine(
            $"Ciclo {ciclo}: Voltaje actual = {voltaje:F2} V");


        // Calculamos cuál sería el siguiente voltaje.

        double siguienteVoltaje = voltaje + incremento;


        // ----------------------------------------------------
        // COMPROBAR SI SE ALCANZARÁ O SUPERARÁ 12.6 V
        // ----------------------------------------------------
        //
        // Si el siguiente voltaje supera 12.6 V, no queremos
        // mostrar un valor como 13 V.
        //
        // En ese caso establecemos directamente 12.6 V.
        //
        // De esta manera, el último ciclo representa la llegada
        // de la batería a su voltaje máximo.

        if (siguienteVoltaje >= 12.6)
        {
            voltaje = 12.6;
        }
        else
        {
            voltaje = siguienteVoltaje;
        }


        // Aumentamos el número de ciclo.

        ciclo++;
    }


    // --------------------------------------------------------
    // MOSTRAR EL ÚLTIMO CICLO
    // --------------------------------------------------------
    //
    // Cuando el while termina, el voltaje ya es 12.6 V.
    //
    // Como este valor representa el último ciclo de la carga,
    // también lo mostramos.

    Console.WriteLine(
        $"Ciclo {ciclo}: Voltaje actual = {voltaje:F2} V");


    // --------------------------------------------------------
    // RESULTADO FINAL
    // --------------------------------------------------------

    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("CARGA COMPLETADA");
    Console.WriteLine("------------------------------------------------------------");

    Console.WriteLine($"Voltaje final de la batería: {voltaje:F2} V");
    Console.WriteLine($"Ciclos mostrados: {ciclo}");
}