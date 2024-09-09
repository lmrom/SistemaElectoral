int sw= Console.WindowWidth;
int sh= Console.WindowHeight;
string lineDec = new string('-', sw);
string numvotos = "";
int contador = 0;
int cand1 = 0, cand2 = 0, cand3 = 0, votosblanco = 0;
Random rnd = new Random(); // Generador de números aleatorios
bool continuar = true; // Variable de control para el bucle principal


while (continuar) // Bucle principal
{

    string[] lines = {
           "  .d8888.  d888888b  .d8888.   d888888b  d88888b .88b  d88.   .d8b.  ",
            " 88'  YP    `88'    88'  YP   `~~88~~'  88'     88'YbdP`88  d8' `8b ",
            " `8bo.       88     `8bo.        88     88ooooo 88  88  88  88ooo88 ",
            "   `Y8b.     88       `Y8b.      88     88~~~~~ 88  88  88  88~~~88 ",
            " db   8D    .88.    db   8D      88     88.     88  88  88  88   88 ",
            " `8888Y'  Y888888P  `8888Y'      YP     Y88888P YP  YP  YP  YP   YP ",
            "                                                                       ",
            " d88888b  db      d88888b  .o88b.  d888888b   .d88b.   d8888b.   .d8b.   db      ",
            " 88'      88      88'     d8P  Y8  `~~88~~'  .8P  Y8.  88  `8D  d8' `8b  88      ",
            " 88ooooo  88      88ooooo 8P          88     88    88  88oobY'  88ooo88  88      ",
            " 88~~~~~  88      88~~~~~ 8b          88     88    88  88`8b    88~~~88  88      ",
            " 88.      88booo. 88.     Y8b  d8     88     `8b  d8'  88 `88.  88   88  88booo. ",
            " Y88888P  Y88888P Y88888P  `Y88P'     YP      `Y88P'   88   YD  YP   YP  Y88888P "
     };

   
    foreach (string line in lines) //Para cada Línea
    {
        
        int leftSapce = (sw - line.Length) / 2; //espacio a la derecha quitando el largo de cada linea y dividiendo a la mitad para encontrar la mitad
        Console.Write(new string(' ', leftSapce));

        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < line.Length / 3; i++)//Dividimos el string en tercios 
        {
            Console.Write(line[i]);
        }

        Console.ForegroundColor = ConsoleColor.White;
        for (int i = line.Length / 3; i < (line.Length / 3) * 2; i++)
        {
            Console.Write(line[i]);
        }

        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = (line.Length / 3) * 2; i < line.Length; i++)
        {
            Console.Write(line[i]);
        }
        Console.WriteLine(); //deja de escribir (line[i])
        Console.ResetColor();
    }




    Console.WriteLine("\nBienvenido al Sistema Electoral recuerda que tu voto es libre y secreto, recuerda votar a conciencia.");

    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine($"\n" + lineDec + "\n");
    Console.ResetColor();

    string textoVotos = $"Votos actuales: {contador}";
    Console.WriteLine(textoVotos.PadLeft((sw + textoVotos.Length) / 2));

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n" + lineDec);
    Console.ResetColor();

    Console.WriteLine("Escoge a el candidato de tu preferencia colocando el número que tiene en la lista. \n");
    Console.WriteLine("1. Elgar Gajo");
    Console.WriteLine("2. Mcclovin");
    Console.WriteLine("3. Mequedan Novaro");
    Console.WriteLine("4. Voto en blanco");
    Console.WriteLine("5. Mostrar resultados");
    Console.WriteLine("6. Simular elecciones");

    Console.Write("Ingresa tu voto: ");
    numvotos = Console.ReadLine(); // Se lee la opción del usuario

    switch (numvotos)
    {
        case "1":
            cand1++;
            contador++;
            break;
        case "2":
            cand2++;
            contador++;
            break;
        case "3":
            cand3++;
            contador++;
            break;
        case "4":
            votosblanco++;
            contador++;
            break;
        case "5":
            // Mostrar resultados
            {
                double porcentajecand1 = 0, porcentajecand2 = 0, porcentajecand3 = 0, porcentajeblanco = 0;

                if (contador > 0)
                {
                    // Calculamos porcentajes
                    porcentajecand1 = ((double)cand1 / contador) * 100;
                    porcentajecand2 = ((double)cand2 / contador) * 100;
                    porcentajecand3 = ((double)cand3 / contador) * 100;
                    porcentajeblanco = ((double)votosblanco / contador) * 100;
                }

                // Mostramos los resultados con barra de porcentaje
                Console.WriteLine($"Elgar Gajo ({cand1})  {porcentajecand1:F1}%  {new string('#', (int)(porcentajecand1 / 2))}");
                Console.WriteLine($"Mcclovin ({cand2})  {porcentajecand2:F1}%  {new string('#', (int)(porcentajecand2 / 2))}");
                Console.WriteLine($"Mequedan Novaro ({cand3})  {porcentajecand3:F1}%  {new string('#', (int)(porcentajecand3 / 2))}");
                Console.WriteLine($"Voto en blanco ({votosblanco})  {porcentajeblanco:F1}%  {new string('#', (int)(porcentajeblanco / 2))}");

                Console.WriteLine("\nElige una opción:");
                Console.WriteLine("1. Continuar ingresando votos");
                Console.WriteLine("2. Terminar elecciones y mostrar los resultados finales");
                string resultados = Console.ReadLine();

                if (resultados == "1")
                {
                    break; // Volvemos al inicio del bucle para seguir ingresando votos
                }
                else if (resultados == "2")
                {
                    Console.Clear();

                    double porcentajefincand1 = 0, porcentajefincand2 = 0, porcentajefincand3 = 0, porcentajefinblanco = 0;

                    if (contador > 0)
                    {
                        porcentajefincand1 = ((double)cand1 / contador) * 100;
                        porcentajefincand2 = ((double)cand2 / contador) * 100;
                        porcentajefincand3 = ((double)cand3 / contador) * 100;
                        porcentajefinblanco = ((double)votosblanco / contador) * 100;
                    }

                    Console.WriteLine($"Elgar Gajo ({cand1})  {porcentajefincand1:F1}%  {new string('#', (int)(porcentajefincand1 / 2))}");
                    Console.WriteLine($"Mcclovin ({cand2})  {porcentajefincand2:F1}%  {new string('#', (int)(porcentajefincand2 / 2))}");
                    Console.WriteLine($"Mequedan Novaro ({cand3})  {porcentajefincand3:F1}%  {new string('#', (int)(porcentajefincand3 / 2))}");
                    Console.WriteLine($"Voto en blanco ({votosblanco})  {porcentajefinblanco:F1}%  {new string('#', (int)(porcentajefinblanco / 2))}");

                    // Determinamos el ganador o si hubo un empate
                    int maxVotos = Math.Max(cand1, Math.Max(cand2, Math.Max(cand3, votosblanco)));
                    bool empate = false;

                    if (cand1 == cand2 && cand1 == cand3 && cand1 == votosblanco)
                    {
                        Console.WriteLine("Empate total entre todos los candidatos y los votos en blanco.");
                    }
                    else
                    {
                        if (cand1 == maxVotos && cand2 == maxVotos && cand1 != cand3 && cand1 != votosblanco)
                        {
                            Console.WriteLine("Empate entre Elgar Gajo y Mcclovin.");
                        }
                        else if (cand1 == maxVotos && cand3 == maxVotos && cand1 != cand2 && cand1 != votosblanco)
                        {
                            Console.WriteLine("Empate entre Elgar Gajo y Mequedan Novaro.");
                        }
                        else if (cand2 == maxVotos && cand3 == maxVotos && cand2 != cand1 && cand2 != votosblanco)
                        {
                            Console.WriteLine("Empate entre Mcclovin y Mequedan Novaro.");
                        }
                        else if (cand1 == maxVotos)
                        {
                            Console.WriteLine($"Elgar Gajo es el ganador con {cand1} votos.");
                        }
                        else if (cand2 == maxVotos)
                        {
                            Console.WriteLine($"Mcclovin es el ganador con {cand2} votos.");
                        }
                        else if (cand3 == maxVotos)
                        {
                            Console.WriteLine($"Mequedan Novaro es el ganador con {cand3} votos.");
                        }
                        else if (votosblanco == maxVotos)
                        {
                            Console.WriteLine($"Voto en blanco es el más votado con {votosblanco} votos.");
                        }
                    }

                    Console.WriteLine("Presiona cualquier tecla para finalizar...");
                    Console.ReadKey();

                    // Salir del bucle principal
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey(); // Pausa para que el usuario pueda leer el mensaje antes de limpiar la pantalla
                }
            }
            break;
        case "6":
            // Simulación de votos aleatorios hasta alcanzar 3000
            Console.WriteLine("Simulando elecciones...");

            while (contador < 3000)
            {
                int simulacionvotos = rnd.Next(1, 5); // Genera un número aleatorio entre 1 y 4

                if (simulacionvotos == 1)
                    cand1++;
                else if (simulacionvotos == 2)
                    cand2++;
                else if (simulacionvotos == 3)
                    cand3++;
                else if (simulacionvotos == 4)
                    votosblanco++;

                contador++;
            }

            // Mostramos los resultados finales de la simulación
            Console.Clear();

            double porcentajecand1_sim = 0, porcentajecand2_sim = 0, porcentajecand3_sim = 0, porcentajeblanco_sim = 0;

            if (contador > 0)
            {
                porcentajecand1_sim = ((double)cand1 / contador) * 100;
                porcentajecand2_sim = ((double)cand2 / contador) * 100;
                porcentajecand3_sim = ((double)cand3 / contador) * 100;
                porcentajeblanco_sim = ((double)votosblanco / contador) * 100;
            }

            Console.WriteLine($"Elgar Gajo ({cand1})  {porcentajecand1_sim:F1}%  {new string('#', (int)(porcentajecand1_sim / 2))}");
            Console.WriteLine($"Mcclovin ({cand2})  {porcentajecand2_sim:F1}%  {new string('#', (int)(porcentajecand2_sim / 2))}");
            Console.WriteLine($"Mequedan Novaro ({cand3})  {porcentajecand3_sim:F1}%  {new string('#', (int)(porcentajecand3_sim / 2))}");
            Console.WriteLine($"Voto en blanco ({votosblanco})  {porcentajeblanco_sim:F1}%  {new string('#', (int)(porcentajeblanco_sim / 2))}");

            // Determinamos el ganador o si hubo un empate
            int maxVotos_sim = Math.Max(cand1, Math.Max(cand2, Math.Max(cand3, votosblanco)));
            bool empate_sim = false;

            if (cand1 == cand2 && cand1 == cand3 && cand1 == votosblanco)
            {
                Console.WriteLine("Empate total entre todos los candidatos y los votos en blanco.");
            }
            else
            {
                if (cand1 == maxVotos_sim && cand2 == maxVotos_sim && cand1 != cand3 && cand1 != votosblanco)
                {
                    Console.WriteLine("Empate entre Elgar Gajo y Mcclovin.");
                }
                else if (cand1 == maxVotos_sim && cand3 == maxVotos_sim && cand1 != cand2 && cand1 != votosblanco)
                {
                    Console.WriteLine("Empate entre Elgar Gajo y Mequedan Novaro.");
                }
                else if (cand2 == maxVotos_sim && cand3 == maxVotos_sim && cand2 != cand1 && cand2 != votosblanco)
                {
                    Console.WriteLine("Empate entre Mcclovin y Mequedan Novaro.");
                }
                else if (cand1 == maxVotos_sim)
                {
                    Console.WriteLine($"Elgar Gajo es el ganador con {cand1} votos.");
                }
                else if (cand2 == maxVotos_sim)
                {
                    Console.WriteLine($"Mcclovin es el ganador con {cand2} votos.");
                }
                else if (cand3 == maxVotos_sim)
                {
                    Console.WriteLine($"Mequedan Novaro es el ganador con {cand3} votos.");
                }
                else if (votosblanco == maxVotos_sim)
                {
                    Console.WriteLine($"Voto en blanco es el más votado con {votosblanco} votos.");
                }
            }

            Console.WriteLine("Presiona cualquier tecla para finalizar...");
            Console.ReadKey();

            // Salir del bucle principal
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida. Intenta de nuevo.");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey(); // Pausa para que el usuario pueda leer el mensaje antes de limpiar la pantalla
            break;
    }
}



