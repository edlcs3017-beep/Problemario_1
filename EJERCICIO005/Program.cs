// ============================================================
// EJERCICIO 5: ANÁLISIS DE VIBRACIÓN DE VARIOS MOTORES
// ============================================================
//
// PLANTEAMIENTO DEL PROBLEMA:
//
// Diseñe un programa que permita analizar la vibración de
// varios motores.
//
// Para cada motor se deberá:
// a) Solicitar el nombre o identificador.
// b) Pedir cuatro mediciones mediante un ciclo for.
// c) Calcular la vibración promedio.
// d) Clasificar el estado del motor.
// e) Preguntar si se desea analizar otro motor.
//
// La repetición de motores se controlará mediante un ciclo while.
//
// CLASIFICACIÓN:
//
// Promedio <= 4.5 mm/s:
// FUNCIONAMIENTO NORMAL DEL MOTOR.
//
// Promedio > 4.5 mm/s:
// EL MOTOR REQUIERE MANTENIMIENTO.
//
// Al finalizar se mostrará:
// - Total de motores evaluados.
// - Cantidad de motores normales.
// - Cantidad de motores que requieren mantenimiento.
// ============================================================


// ------------------------------------------------------------
// ENCABEZADO
// ------------------------------------------------------------

Console.WriteLine("============================================================");
Console.WriteLine("       EJERCICIO 5 - ANÁLISIS DE VIBRACIÓN");
Console.WriteLine("============================================================");

Console.WriteLine("PLANTEAMIENTO DEL PROBLEMA:");
Console.WriteLine("Se analizará la vibración de varios motores.");
Console.WriteLine();
Console.WriteLine("Cada motor tendrá cuatro mediciones de vibración.");
Console.WriteLine();
Console.WriteLine("Promedio <= 4.5 mm/s:");
Console.WriteLine("FUNCIONAMIENTO NORMAL DEL MOTOR.");
Console.WriteLine();
Console.WriteLine("Promedio > 4.5 mm/s:");
Console.WriteLine("EL MOTOR REQUIERE MANTENIMIENTO.");

Console.WriteLine("============================================================");
Console.WriteLine();


// ------------------------------------------------------------
// CONTADORES GENERALES
// ------------------------------------------------------------
// Estas variables permiten llevar un registro de todos los
// motores analizados durante la ejecución.
//
// Se inicializan en cero porque todavía no hemos analizado
// ningún motor.

int totalMotores = 0;
int motoresNormales = 0;
int motoresMantenimiento = 0;


// ------------------------------------------------------------
// VARIABLE PARA CONTROLAR EL WHILE
// ------------------------------------------------------------
// La variable "continuar" será verdadera mientras el usuario
// quiera seguir analizando motores.
//
// Al comenzar, establecemos true para que el programa
// entre al ciclo while.

bool continuar = true;


// ============================================================
// CICLO WHILE
// ============================================================
//
// Este ciclo controla la cantidad de motores que serán
// analizados.
//
// A diferencia del ejercicio 4, aquí NO sabemos desde el
// principio cuántos motores analizará el usuario.
//
// Por eso utilizamos while en lugar de for.
//
// El ciclo continuará mientras:
//             continuar == true
// ============================================================

while (continuar)
{
    // --------------------------------------------------------
    // IDENTIFICAR EL MOTOR
    // --------------------------------------------------------
    // Solicitamos un nombre o identificador para saber
    // qué motor estamos analizando.

    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine($"ANÁLISIS DEL MOTOR #{totalMotores + 1}");
    Console.WriteLine("------------------------------------------------------------");

    Console.Write("Ingrese el nombre o identificador del motor: ");

    string nombreMotor = Console.ReadLine() ?? "";


    // --------------------------------------------------------
    // VARIABLE PARA LA SUMA
    // --------------------------------------------------------
    // Cada motor tiene sus propias cuatro mediciones.
    //
    // Por eso debemos reiniciar la suma en cero antes
    // de comenzar a medir un nuevo motor.

    double suma = 0;


    // --------------------------------------------------------
    // CICLO FOR
    // --------------------------------------------------------
    // Este ciclo se encarga de obtener exactamente cuatro
    // mediciones para el motor actual.
    //
    // El ciclo comienza en 1 y termina en 4.

    for (int i = 1; i <= 4; i++)
    {
        // Solicitar la medición de vibración.

        Console.Write(
            $"Ingrese la vibración #{i} del motor {nombreMotor} (mm/s): ");

        double vibracion = Convert.ToDouble(Console.ReadLine());


        // ----------------------------------------------------
        // ACUMULAR LAS MEDICIONES
        // ----------------------------------------------------
        // Sumamos la vibración actual a la suma acumulada.
        //
        // Después de las cuatro repeticiones tendremos
        // la suma total de las cuatro mediciones.

        suma = suma + vibracion;
    }


    // --------------------------------------------------------
    // CALCULAR EL PROMEDIO
    // --------------------------------------------------------
    // Como cada motor tiene exactamente cuatro mediciones,
    // dividimos la suma entre cuatro.

    double promedio = suma / 4;


    // --------------------------------------------------------
    // MOSTRAR RESULTADO DEL MOTOR
    // --------------------------------------------------------

    Console.WriteLine();
    Console.WriteLine($"Motor analizado: {nombreMotor}");
    Console.WriteLine($"Vibración promedio: {promedio:F2} mm/s");


    // --------------------------------------------------------
    // CLASIFICAR EL MOTOR
    // --------------------------------------------------------
    // Se compara el promedio con el límite de 4.5 mm/s.
    //
    // Si es menor o igual a 4.5:
    // funcionamiento normal.
    //
    // Si es mayor a 4.5:
    // requiere mantenimiento.

    if (promedio <= 4.5)
    {
        Console.WriteLine("FUNCIONAMIENTO NORMAL DEL MOTOR");

        // Aumentamos el contador de motores normales.

        motoresNormales++;
    }
    else
    {
        Console.WriteLine("EL MOTOR REQUIERE MANTENIMIENTO");

        // Aumentamos el contador de motores que requieren
        // mantenimiento.

        motoresMantenimiento++;
    }


    // --------------------------------------------------------
    // ACTUALIZAR TOTAL DE MOTORES
    // --------------------------------------------------------
    // Como terminamos de analizar un motor, aumentamos
    // el contador general.

    totalMotores++;


    // --------------------------------------------------------
    // PREGUNTAR SI SE DESEA ANALIZAR OTRO MOTOR
    // --------------------------------------------------------
    // El usuario puede decidir si desea continuar.
    //
    // Se utiliza S para sí y N para no.

    Console.WriteLine();
    Console.Write("¿Desea analizar otro motor? (S/N): ");

    string respuesta = (Console.ReadLine() ?? "").ToUpper();


    // --------------------------------------------------------
    // CONTROL DEL CICLO WHILE
    // --------------------------------------------------------
    // Si el usuario responde N, cambiamos "continuar"
    // a false.
    //
    // Al regresar al while, la condición:
    //
    //        while (continuar)
    //
    // será falsa y el ciclo terminará.

    if (respuesta == "N")
    {
        continuar = false;
    }

    Console.WriteLine();
}


// ============================================================
// RESULTADOS FINALES
// ============================================================
// Cuando el usuario decide no analizar más motores,
// el ciclo while termina y llegamos a esta sección.
//
// Aquí mostramos el resumen de todo el proceso.
// ============================================================

Console.WriteLine("============================================================");
Console.WriteLine("                RESULTADOS FINALES");
Console.WriteLine("============================================================");

Console.WriteLine($"Total de motores evaluados: {totalMotores}");
Console.WriteLine($"Motores con funcionamiento normal: {motoresNormales}");
Console.WriteLine(
    $"Motores que requieren mantenimiento: {motoresMantenimiento}");

Console.WriteLine("============================================================");