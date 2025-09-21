﻿Console.WriteLine("===== Universidad Estatal Amazónica =====");
Console.WriteLine("===== ESTRUCTURA DE DATOS (A) =====");
Console.WriteLine("===== Tercer Semestre =====");
Console.WriteLine("===== Luis Alfonso Maigua Sisalema =====\n");  // Salto de línea para mejor formato

bool continuar = true;
while (continuar)
{
    //Console.Clear(); // Limpia la pantalla en cada iteración (mejora visual)
    Console.WriteLine("=== MENÚ PRINCIPAL ===");
    Console.WriteLine("1. TraductorBasico");
    Console.WriteLine("2. CampaniaVacunacionTarea");
    Console.WriteLine("3. TorneoFutbolTarea");
    Console.WriteLine("4. CatalogoRevistass");
    Console.WriteLine("5. Salir");
    Console.Write("\nSelecciona una opción: "); 
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            TraductorBasico.run();
            break;
        case "2":
            CampaniaVacunacionTarea.run(); 
            break;
        case "3":
            TorneoFutbolTarea.run(); 
            break;
        case "4":
            CatalogoRevistass.run();
            break;
        case "5":
            Console.WriteLine("Saliendo... ¡Hasta pronto!");
            continuar = false; // Termina el bucle
            break;
        default:
            Console.WriteLine("Opción inválida. selecciona una opción del 1 al 5.");
            break;
    }

        // Pausa solo si NO se está saliendo
    if (continuar)
    {
        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
        // Console.ReadKey(); // Espera una tecla (mejora usabilidad)
    }
}
