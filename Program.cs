using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es30
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Variabile che memorizza la risposta dell'utente alla domanda "Vuoi rigiocare?"
            string ripetizione;
            //variabili x le statistiche, non vanno mai resettate
            int vittorie = 0, tentativiSuperati = 0, somma = 0, partiteGiocate = 0;

            //ripete l'intero gioco finché l'utente risponde YES a "Vuoi rigiocare?"
            do
            {
                // creazione di una nuova istanza della classe Random e assegnata alla variabile nRan
                Random nRan = new Random();
                // generatore numero
                int valore = nRan.Next(1, 101);

                // variabile per opzione del menù
                int opzione;

                Console.Clear();
                //validazione input menù
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔═══════════════════════════════════════════════╗");
                    Console.WriteLine("║              INDOVINA IL NUMERO               ║");
                    Console.WriteLine("╠═══════════════════════════════════════════════╣");
                    Console.WriteLine("║  Scegli il livello con cui vuoi giocare       ║");
                    Console.WriteLine("║                                               ║");
                    Console.WriteLine("║  1) Livello Base    (max 50 tentativi)        ║");
                    Console.WriteLine("║  2) Livello Medio   (max 45 tentativi)        ║");
                    Console.WriteLine("║  3) Livello Avanzato (max 40 tentativi)       ║");
                    Console.WriteLine("║  4) Livello Superavanzato (max 30 tentativi)  ║");
                    Console.WriteLine("╚═══════════════════════════════════════════════╝");
                    Console.ResetColor();
                    Console.Write("\nScelta >> ");
                    opzione = int.Parse(Console.ReadLine());
                    if (opzione < 1 || opzione > 4) Console.WriteLine("!! Non esiste alcun livello con questo numero, inserire un valore da 1 a 4 !!");
                } while (opzione < 1 || opzione > 4);

                //aggiungo una partita giocata (x statistiche)
                partiteGiocate++;

                // switch x selezione livello
                switch (opzione)
                {
                    //LIVELLO BASE
                    case 1:
                        //variabili da usare per il livello base
                        int indovinello, tentativi = 0;
                        do
                        {
                            // Conto un nuovo tentativo e aggiungo un tentativo alla variabile x la media
                            tentativi++;
                            do
                            {
                                Console.WriteLine("Inserisci il numero");
                                indovinello = int.Parse(Console.ReadLine());
                                if (indovinello < 1 || indovinello > 100) Console.WriteLine("Hai inserito un valore non valido");
                            } while (indovinello < 1 || indovinello > 100);
                            //creazione stringa con valore di giusto o meno del tentativo appena fatto
                            string risposta = (indovinello == valore) ? "Hai indovinato il numero" : "Riprova";
                            if (risposta == "Riprova") Console.WriteLine(risposta);
                            else if (risposta == "Hai indovinato il numero")
                            {
                                Console.WriteLine(risposta);
                                //aggiungo una vittoria
                                vittorie++;
                                //aggiungo il numero di tentativi fatti per indovinare il numero (x statistiche)
                                somma += tentativi;
                            }
                            //aiuto all'utente al tentativo 3 e 7
                            if (risposta == "Riprova" && (tentativi == 3 || tentativi == 7))
                            {
                                //aiuti fascia
                                if (valore > 50) Console.WriteLine("Il valore che cerchi è maggiore di 50");
                                else if (valore > 25 && valore <= 50) Console.WriteLine("Il valore è compreso tra 25 e 50 ");
                                else Console.WriteLine("Il valore è minore di 25");
                            }
                            //aiuto di vicinanza al numero
                            if ((indovinello - valore) < 5 || (valore - indovinello) < 5) Console.WriteLine("Il numero è massimo a + o - 5 di distanza");
                            else Console.WriteLine("non ci sei vicino");
                            // continuo fino ad aver azzeccato il numero o non ho superato i tentativi
                        } while (indovinello != valore && tentativi < 50);
                        // Avviso di fine tentativi + rivelazione numero
                        if (indovinello != valore)
                        {
                            Console.WriteLine("Hai superato il numero massimo di tentativi" + $"\nIl numero che cercavi era il: {valore}");
                            //aggiunta x aver superato il numero di tentativi (statistiche)
                            tentativiSuperati++;
                        }
                        break;

                    //LIVELLO MEDIO
                    case 2:
                        //variabili da usare per il livello medio
                        int indovinellino, Tentativi = 0;
                        do
                        {
                            // Conto un nuovo tentativo e aggiungo un tentativo alla variabile x la media
                            Tentativi++;
                            do
                            {
                                Console.WriteLine("Inserisci il numero");
                                indovinellino = int.Parse(Console.ReadLine());
                                if (indovinellino < 1 || indovinellino > 100) Console.WriteLine("Hai inserito un valore non valido");
                            } while (indovinellino < 1 || indovinellino > 100);
                            //creazione stringa con valore di giusto o meno del tentativo appena fatto
                            string risposta = (indovinellino == valore) ? "Hai indovinato il numero" : "Riprova";
                            if (risposta == "Riprova") Console.WriteLine(risposta);
                            else if (risposta == "Hai indovinato il numero")
                            {
                                Console.WriteLine(risposta);
                                //aggiungo numero vittorie (x statistiche)
                                vittorie++;
                                //aggiungo il numero di tentativi fatti per indovinare il numero (x statistiche)
                                somma += Tentativi;
                            }
                            // Aiuto all'utente al tentativo 3
                            if (risposta == "Riprova" && Tentativi == 3)
                            {
                                if (valore > 50) Console.WriteLine("Il valore che cerchi è maggiore di 50");
                                else Console.WriteLine("Il valore è minore di 50");
                            }
                            if ((indovinellino - valore) < 10 || (valore - indovinellino) < 10) Console.WriteLine("Il numero è massimo a + o - 10 di distanza");
                            else Console.WriteLine("non ci sei vicino");
                            // continuo fino ad aver azzeccato il numero o non ho superato i tentativi
                        } while (indovinellino != valore && Tentativi < 45);
                        // Avviso di fine tentativi + rivelazione numero
                        if (indovinellino != valore)
                        {
                            Console.WriteLine("Hai superato il numero massimo di tentativi" + $"\nIl numero che cercavi era il: {valore}");
                            //aggiunta per i tentativi superati (statistiche)
                            tentativiSuperati++;
                        }
                        break;

                    //LIVELLO AVANZATO
                    case 3:
                        int userValue, TeNTaTiVi = 0;
                        do
                        {
                            // Conto un nuovo tentativo e aggiungo un tentativo alla variabile x la media
                            TeNTaTiVi++;
                            do
                            {
                                Console.WriteLine("Inserisci il numero");
                                userValue = int.Parse(Console.ReadLine());
                                if (userValue < 1 || userValue > 100) Console.WriteLine("Hai inserito un valore non valido");
                            } while (userValue < 1 || userValue > 100);
                            //creazione stringa con valore di giusto o meno del tentativo appena fatto
                            string risposta = (userValue == valore) ? "Hai indovinato il numero" : "Riprova";
                            if (risposta == "Riprova") Console.WriteLine(risposta);
                            else if (risposta == "Hai indovinato il numero")
                            {
                                Console.WriteLine(risposta);
                                //aggiunta vittoria (x statistiche)
                                vittorie++;
                                //aggiungo il numero di tentativi fatti per indovinare il numero (x statistiche)
                                somma += TeNTaTiVi;
                            }
                            if ((userValue - valore) < 20 || (valore - userValue) < 20) Console.WriteLine("Il numero è massimo a + o - 20 di distanza");
                            else Console.WriteLine("non ci sei vicino");
                            // continuo fino ad aver azzeccato il numero o non ho superato i tentativi
                        } while (userValue != valore && TeNTaTiVi < 40);
                        // Avviso di fine tentativi + rivelazione numero
                        if (userValue != valore)
                        {
                            Console.WriteLine("Hai superato il numero massimo di tentativi" + $"\nIl numero che cercavi era il: {valore}");
                            //aggiungo per valore di partite perse per massimo raggiunto di tentativi (statistiche)
                            tentativiSuperati++;
                        }
                        break;

                    //LIVELLO SUPERAVANZATO
                    case 4:
                        int valoreutente, TentaTivi = 0;
                        do
                        {
                            // Conto un nuovo tentativo e aggiungo un tentativo alla variabile x la media
                            TentaTivi++;
                            do
                            {
                                Console.WriteLine("Inserisci il numero");
                                valoreutente = int.Parse(Console.ReadLine());
                                if (valoreutente < 1 || valoreutente > 100) Console.WriteLine("Hai inserito un valore non valido");
                            } while (valoreutente < 1 || valoreutente > 100);
                            //creazione stringa con valore di giusto o meno del tentativo appena fatto
                            string risposta = (valoreutente == valore) ? "Hai indovinato il numero" : "Riprova";
                            if (risposta == "Riprova") Console.WriteLine(risposta);
                            else if (risposta == "Hai indovinato il numero")
                            {
                                Console.WriteLine(risposta);
                                //aggiunta vittoria (x statistiche)
                                vittorie++;
                                //aggiungo il numero di tentativi fatti per indovinare il numero (x statistiche)
                                somma += TentaTivi;
                            }
                            // continuo fino ad aver azzeccato il numero o non ho superato i tentativi
                        } while (valoreutente != valore && TentaTivi < 30);
                        // Avviso di fine tentativi + rivelazione numero
                        if (valoreutente != valore)
                        {
                            Console.WriteLine("Hai superato il numero massimo di tentativi" + $"\nIl numero che cercavi era il: {valore}");
                            //aggiungo per valore di partite perse per massimo raggiunto di tentativi (statistiche)
                            tentativiSuperati++;
                        }
                        break;

                    default:
                        Console.WriteLine("hai inserito un numero non valido");
                        break;
                }


                // Chiedo se l'utente vuole vedere le statistiche
                string statistiche;
                Console.WriteLine("Vuoi vedere le tue statistiche? (YES/NO)");
                statistiche = Console.ReadLine().ToUpper();
                if (statistiche == "YES")
                {

                    //numero di Partite giocate
                    Console.WriteLine($"Hai giocato in totale {partiteGiocate} partite");
                    //numero vittorie
                    Console.WriteLine($"Hai indovinato il numero {vittorie} volte");
                    //numero tentativi superato
                    Console.WriteLine($"Hai superato il numero di tentativi: {tentativiSuperati} volte");
                    //controllo se le vittorie sono maggiori di zero, senò non posso eseguire la divisione
                    if (vittorie > 0)
                    {
                        //calcolo media
                        double media = (double)somma / vittorie;
                        //media di tentativi per indovinare
                        Console.WriteLine($"La media dei tentativi fatti per vincere è di: {media}");
                    }
                }

                // Chiedo se l'utente vuole fare un'altra partita
                Console.WriteLine("Vuoi rigiocare? (YES/NO)");
                ripetizione = Console.ReadLine().ToUpper();
            } while (ripetizione == "YES");

            //segnalazione uscita dal programma
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!Clicca invio per uscire dal programma!!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}