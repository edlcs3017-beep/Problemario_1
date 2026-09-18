// ============================================================
// EJERCICIO 4: MEDICIONES DE CORRIENTE DE UN ACTUADOR
// ============================================================
//
// PLANTEAMIENTO DEL PROBLEMA:
//
// Durante una prueba se realizan ocho mediciones de corriente
// de un actuador eléctrico.
//
// Cada medición será clasificada de la siguiente manera:
//
// Si la corriente es menor o igual que 5 A:
// MEDICIÓN NORMAL.
//
// Si la corriente es mayor que 5 A:
// SOBRECORRIENTE DETECTADA.
//
// Al finalizar se mostrará:
// - Corriente promedio.
// - Cantidad de mediciones normales.
// - Cantidad de sobrecorrientes.
// - Resultado general del actuador.
// ============================================================


// ------------------------------------------------------------
// ENCABEZADO
// ------------------------------------------------------------

Console.WriteLine("============================================================");
Console.WriteLine("    EJERCICIO 4 - CORRIENTE DE UN ACTUADOR ELÉCTRICO");
Console.WriteLine("============================================================");

Console.WriteLine("PLANTEAMIENTO DEL PROBLEMA:");
Console.WriteLine("Se realizarán ocho mediciones de corriente.");
Console.WriteLine();
Console.WriteLine("Corriente <= 5 A: MEDICIÓN NORMAL.");
Console.WriteLine("Corriente > 5 A: SOBRECORRIENTE DETECTADA.");
Console.WriteLine();
Console.WriteLine("Al finalizar se calculará la corriente promedio");
Console.WriteLine("y se determinará el resultado general del actuador.");

Console.WriteLine("============================================================");
Console.WriteLine();


// ------------------------------------------------------------
// VARIABLES
// ------------------------------------------------------------

// "suma" almacenará la suma de las ocho mediciones.
// Se utiliza double porque las corrientes pueden tener
// valores decimales.

double suma = 0;


// Estos contadores comienzan en cero porque todavía
// no hemos realizado ninguna medición.

int normales = 0;
int sobrecorrientes = 0;


// ------------------------------------------------------------
// CICLO FOR
// ------------------------------------------------------------
// El problema requiere exactamente ocho mediciones.
//
// El ciclo for permite escribir una sola vez las instrucciones
// y repetirlas automáticamente ocho veces.

for (int i = 1; i <= 8; i++)
{
    // --------------------------------------------------------
    // ENTRADA
    // --------------------------------------------------------
    // Solicitamos la corriente correspondiente a la medición.

    Console.Write($"Ingrese la corriente de la medición #{i} (A): ");

    double corriente = Convert.ToDouble(Console.ReadLine());


    // --------------------------------------------------------
    // ACUMULAR LA CORRIENTE
    // --------------------------------------------------------
    // Sumamos la medición actual a la suma acumulada.
    //
    // Por ejemplo:
    //
    // suma = suma + corriente

    suma = suma + corriente;


    // --------------------------------------------------------
    // CLASIFICAR LA MEDICIÓN
    // --------------------------------------------------------
    // Se compara la corriente con el límite de 5 A.
    //
    // Si es menor o igual a 5 A, la medición es normal.
    // Si es mayor a 5 A, existe una sobrecorriente.

    if (corriente <= 5)
    {
        Console.WriteLine("MEDICIÓN NORMAL");

        // Aumentamos en uno la cantidad de mediciones normales.

        normales++;
    }
    else
    {
        Console.WriteLine("SOBRECORRIENTE DETECTADA");

        // Aumentamos en uno la cantidad de sobrecorrientes.

        sobrecorrientes++;
    }

    Console.WriteLine();
}


// ------------------------------------------------------------
// CÁLCULO DEL PROMEDIO
// ------------------------------------------------------------
// Al terminar el ciclo ya tenemos las ocho mediciones
// acumuladas en "suma".
//
// Para calcular el promedio:
//
//        promedio = suma / 8

double promedio = suma / 8;


// ------------------------------------------------------------
// MOSTRAR RESULTADOS
// ------------------------------------------------------------

Console.WriteLine("============================================================");
Console.WriteLine("                    RESULTADOS FINALES");
Console.WriteLine("============================================================");

Console.WriteLine($"Corriente promedio: {promedio:F2} A");
Console.WriteLine($"Mediciones normales: {normales}");
Console.WriteLine($"Sobrecorrientes: {sobrecorrientes}");


// ------------------------------------------------------------
// RESULTADO GENERAL DEL ACTUADOR
// ------------------------------------------------------------
// El problema establece que:
//
// Si no existe ninguna sobrecorriente:
// ACTUADOR APROBADO.
//
// Si existe una o más:
// EL ACTUADOR REQUIERE REVISIÓN.
//
// Por eso comprobamos si el contador de sobrecorrientes
// es igual a cero.

if (sobrecorrientes == 0)
{
    Console.WriteLine("ACTUADOR APROBADO");
}
else
{
    Console.WriteLine("EL ACTUADOR REQUIERE REVISIÓN");
}