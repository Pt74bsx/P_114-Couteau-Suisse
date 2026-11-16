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

/******************************************************************************
** Qu'est-ce que le code Morse ?                                             **
**                                                                           **     
**                            	                                             **
**                                                                           **
** Pourquoi coder l'information ?                                            **
**                                                                           **
**                                                                           **
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
            bool isRun = true;

            // ── Programme
            while (isRun)
            {
                // ── Déclaration des variables qui doivent se rénitialiser 
                bool isValide = false;
                int intChoice = -1;

                Console.Clear();

                // ── Message d'accueil
                Console.WriteLine("Le Couteau Suisse est un programme console qui sert d'outils. Il possède plusieurs outils comme un couteau Suisse.\n" +
                    "Ces outils sont principalement accée sur le chiffrement, morse, etc.\n");

                // ── Menu d'accueil
                Console.WriteLine("=== Couteau Suisse ===");
                Console.WriteLine("1. Texte -> Morse");
                Console.WriteLine("2. Morse -> Texte");
                Console.WriteLine("3. (à venir)");
                Console.WriteLine("4. (à venir)");
                Console.WriteLine("0. Quitter");

                // ── Tant que l'entrée n'est pas valide, le choix est de nouveau demandé
                while (!isValide)
                {
                    Console.Write("\nVotre choix : ");
                    string inputChoice = Console.ReadLine();

                    bool isNumber = int.TryParse(inputChoice, out intChoice);

                    // Si c'est un nombre et que ce nombre est entre 0 et 4 (compris)
                    if (isNumber && intChoice >= 0 && intChoice <= 4)
                    {
                        isValide = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[ERREUR] Saissie invalide, séléctionnez un nombre entre 0 et 4\n");
                        Console.ResetColor();
                    }
                }

                // ── Redirection des choix
                switch (intChoice)
                {
                    // ── Quitter
                    case 0:
                        Console.WriteLine("\nMerci d'avoir utilisé le Couteau Suisse !");
                        isRun = false;
                        break;

                    // ── Texte -> Morse
                    case 1:
                        ConvertTextToMorse();
                        break;

                    // ── Morse -> Texte
                    case 2:
                        ConvertMorseToText();
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

        static void ConvertTextToMorse()
        {
            string strInputText = "";
            string strResult = "";
            bool isValide = false;

            // ── Tant que l'entrée n'est pas correct on re demande 
            while (!isValide)
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
                    isValide = true;
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

        static void ConvertMorseToText()
        {
            string strInputText = "";
            string strResult = "";
            bool isValide = false;

            // ── Tant que l'entrée n'est pas correct on re demande 
            while (!isValide)
            {
                Console.WriteLine("\n=== Morse -> Texte ===");
                Console.Write("Entrez du Morse : ");
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
                    isValide = true;

                    foreach(char caractere in strInputText)
                    {
                        if (caractere != '.' && caractere != '-' && caractere != ' ' && caractere != '/')
                        {
                            isValide = false;
                        }
                    }

                    if (isValide == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[ERREUR] Morse invalide");
                        Console.ResetColor();
                    }
                }
            }

            // ── Séparer le Morse
            string[] codes = strInputText.Split(' ');

            // ── Parcours chaque caractère
            foreach (string strCode in codes)
            {
                if (strCode == "/")
                {
                    strResult = strResult + " ";
                }
                else if (strCode != "")
                {
                    bool isFind = false;

                    foreach(char charLetter in morse.Keys)
                    {
                        if (morse[charLetter] == strCode)
                        {
                            strResult = strResult + charLetter;
                            isFind = true;
                        }
                    }

                    if (isFind == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n[AVERTISSEMENT] Code Morse inconnu : " + strCode);
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }
            }

            // ── Affichage de la convertion
            Console.WriteLine("\nRésultat en texte : " + strResult);

            Console.Write("\nAppuyez sur une touche pour retourner au menu ...\n\n");
            Console.ReadKey(true);
        }
    }
}
