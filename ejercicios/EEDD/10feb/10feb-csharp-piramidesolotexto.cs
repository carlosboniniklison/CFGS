
// main de pirámide solo texto
            Console.WriteLine("Pirámide solo texto");
            
            // declaración sin conocerlos elementos iniciales
            int fil = 5;
             
            // piramide a la izquierda
            string piramide="";
            
            for (int f = 1; f < fil+1; f++)
            {
                // una linea de la piramide

                for (int c = 1; c < f+1; c++)
                {
                    piramide = piramide + f.ToString();
                }
                piramide = piramide + Environment.NewLine;
            }

            Console.WriteLine(piramide);

            // piramide centrada
            piramide = "";

            for (int f = 1; f < fil + 1; f++)
            {
                // espacios en blanco al inicio de cada linea
                for (int c = f; c < fil; c++)
                {
                    piramide = piramide + " ";
                }
                for (int c = 1; c < f + 1; c++)
                {
                    piramide = piramide + f.ToString();
                    piramide = piramide + f.ToString();
                }
                piramide = piramide + Environment.NewLine;
            }

            Console.WriteLine(piramide);

            // piramide a la derecha
            piramide = "";

            for (int f = 1; f < fil + 1; f++)
            {
                // espacios en blanco al inicio de cada linea
                for (int c = f; c < fil; c++)
                {
                    piramide = piramide + " ";
                }
                for (int c = 1; c < f + 1; c++)
                {
                    piramide = piramide + f.ToString();
                }
                piramide = piramide + Environment.NewLine;
            }

            Console.WriteLine(piramide);

            _ = Console.ReadKey();
			
			
			