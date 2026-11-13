/******************************************************************************
** Couteau Suisse  Program.cs                                                **
**                                                                           **
** Lieu      : ETML - section informatique                                   **
** Auteur    : Romain Augusto                                                **
** Date      : 13.11.2026                                                    **
**                                                                           **
** Modifications                                                             **
**   Auteur  :                                                               **
**   Version : X.X                                                           **
**   Date    :                                                               **
**   Raisons :                                                               **
**                                                                           **
**                                                                           **
******************************************************************************/

/******************************************************************************
** DESCRIPTION                                                               **
** Application console qui regroupe plusieurs outils informatique            **     
** comme de la convertion de texte, etc.                            	     **
**                                                                           **
******************************************************************************/

namespace EasyPasswords_Augusto
{
    internal class Program
    {
        // ── Dictionnaire du Morse
        static Dictionary<char, string> morse = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."},
            {'D', "-.."}, {'E', "."}, {'F', "..-."},
            {'G', "--."}, {'H', "...."}, {'I', ".."},
            {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
            {'M', "--"}, {'N', "-."}, {'O', "---"},
            {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."},
            {'S', "..."}, {'T', "-"}, {'U', "..-"},
            {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."},
            {'0', "-----"}, {'1', ".----"},
            {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."},
            {'6', "-...."}, {'7', "--..."},
            {'8', "---.."}, {'9', "----."},
            {' ', "/"}
        };

        static void Main(string[] args)
        {
            // ── Paramètre de la console
            Console.Title = "Couteau Suisse";

            // ── Déclaration des variables 
            bool run = true;

            // ── Programme
            while (run)
            {
                // ── Déclaration des variables qui doivent se rénitialiser 
                bool valide = false;
                int choice = -1;

                // ── Menu d'accueil
                Console.WriteLine("=== Couteau Suisse ===");
                Console.WriteLine("1. Texte -> Morse");
                Console.WriteLine("2. Morse -> Texte");
                Console.WriteLine("3. (à venir)");
                Console.WriteLine("4. (à venir)");
                Console.WriteLine("0. Quitter");

                // ── Tant que l'entrée n'est pas valide, le choix est de nouveau demandé
                while (!valide)
                {
                    Console.Write("\nVotre choix : ");
                    string inputChoice = Console.ReadLine();

                    bool isNumber = int.TryParse(inputChoice, out choice);

                    // Si c'est un nombre et que ce nombre est entre 0 et 4 (compris)
                    if (isNumber && choice >= 0 && choice <= 4)
                    {
                        valide = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[ERREUR] Saissie invalide, séléctionnez un nombre entre 0 et 4\n");
                        Console.ResetColor();
                    }
                }

                // ── Redirection des choix
                switch (choice)
                {
                    // ── Quitter
                    case 0:
                        Console.WriteLine("\nMerci d'avoir utilisé le Couteau Suisse !");
                        run = false;
                        break;

                    // ── Texte -> Morse
                    case 1:
                        ConvertTextToMorse(choice);
                        break;

                    // ── Morse -> Texte
                    case 2:
                        break;

                    // ── A venir 
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n[Avertissement] Option disponnible prochainement\n");
                        Console.ResetColor();
                        break;

                    // ── A venir 
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n[AVERTISSEMENT] Option disponnible prochainement\n");
                        Console.ResetColor();
                        break;
                }
            } 
        }

        /// <summary>
        /// Permet de convertir un texte en Morse
        /// </summary>
        /// <param name="choice"></param>
        static void ConvertTextToMorse(int choice)
        {
            string strInputText = "";
            string strResult = "";
            bool valide = false;

            // ── Tant que l'entrée n'est pas correct on re demande 
            while (!valide)
            {
                Console.WriteLine("\n=== Texte -> Morse ===");
                Console.Write("Entrez un texte (lettres A-Z, chiffres) : ");
                strInputText = Console.ReadLine();

                // ── Si l'entrée est vide
                if (String.IsNullOrWhiteSpace(strInputText))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[ERREUR] L'entrée ne doit pas être vide");
                    Console.ResetColor();
                }
                else
                {
                    valide = true;
                }
            }

            // ── Convertion de l'entrée en majuscule
            strInputText = strInputText.ToUpper();

            // ── Parcours chaque caractère
            foreach (char caractere in strInputText)
            {
                if (morse.ContainsKey(caractere))
                {
                    if (strResult != "")
                    {
                        strResult = strResult + " ";
                    }

                    strResult = strResult + morse[caractere];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n[AVERTISSEMENT] Le caractère : '" + caractere + "', n'est pas pris en charge");
                    Console.ResetColor();
                }
            }

            // ── Affichage de la convertion
            Console.WriteLine("\nRésultat en Morse : " + strResult);

            Console.Write("\nAppuyez sur une touche pour retourner au menu ...\n\n");
            Console.ReadKey(true);
        }
    }
}
