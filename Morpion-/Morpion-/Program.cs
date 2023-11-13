using System;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading;

namespace Morpion
{
    class Program
    {
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        public static void AfficherMorpion(int j, int k)
        {
            for (j = 0; j < grille.GetLength(0); j++)
            {
                Console.Write("\n|===|===|===|\n");
                Console.Write("|");
                for (k = 0; k < grille.GetLength(1); k++)
                {
                	if (grille[j,k] == 2)
                		Console.Write(" 0 ");
                	if (grille[j,k] == 1)
                		Console.Write(" X ");
                	if (grille[j,k] == 10)
                		Console.Write(" - ");
                    
                    Console.Write("|");
                }
                
            }
            Console.Write("\n|===|===|===|");


            Console.ReadKey();
        }

        // Fonction permettant de changer
        // dans le tableau qu'elle est le 
        // joueur qui à jouer
        // Bien vérifier que le joueur ne sort
        // pas du tableau et que la position
        // n'est pas déjà jouée
        public static bool AJouer(int j, int k, int joueur)
        {
            // A compléter 
            return false;
        }

        // Fonction permettant de vérifier
        // si un joueur à gagner
        public static bool Gagner(int l, int c, int joueur)
        {
            // A compléter 
            //dans cette partie la condition gagner est égale à zéro donc fausse 
            bool gagner = false;
            // ici ce sont les conditions pour que l'un des deux joueurs gagnent et retourne donc la valeur de gagner en true, cela fonctionne en récupérant la valeur de la grille et a quel endroit chaque joueur
            //est positionné tout les cas possible pour gagner ont été instanciés 
            				if(grille[0,0]==1 && grille[0,1]==1 && grille[0,2]==1 || grille[0,0]==2 && grille[0,1]==2 && grille[0,2]==2)
                        	{
                        		return true;
                        	}
							if(grille[1,0]==1 && grille[1,1]==1 && grille[1,2]==1 || grille[1,0]==2 && grille[1,1]==2 && grille[1,2]==2)
                        	{
                        		return true;
                        	}
							if(grille[2,0]==1 && grille[2,1]==1 && grille[2,2]==1 || grille[2,0]==2 && grille[2,1]==2 && grille[2,2]==2)
                        	{
                        		return true;
                        	}
							if(grille[0,0]==1 && grille[1,0]==1 && grille[2,0]==1 || grille[0,0]==2 && grille[1,0]==2 && grille[2,0]==2)
                        	{
                        		return true;
                        	}
							if(grille[0,1]==1 && grille[1,1]==1 && grille[2,1]==1 || grille[0,1]==2 && grille[1,1]==2 && grille[2,1]==2)
                        	{
                        		return true;
                        	}
							if(grille[0,2]==1 && grille[1,2]==1 && grille[2,2]==1 || grille[0,2]==2 && grille[1,2]==2 && grille[2,2]==2)
                        	{
                        		return true;
                        	}
							if(grille[0,0]==1 && grille[1,1]==1 && grille[2,2]==1 || grille[0,0]==2 && grille[1,1]==2 && grille[2,2]==2)
                        	{
                        		return true;
                        	}
							if(grille[0,2]==1 && grille[1,1]==1 && grille[2,0]==1 || grille[0,2]==2 && grille[1,1]==2 && grille[2,0]==2)
                        	{
                        		return true;
                        	}
							
            return false;
        }

        // Programme principal
        static void Main(string[] args)
        {
            //--- Déclarations et initialisations --
            int LigneDébut = Console.CursorTop;     // par rapport au sommet de la fenêtre
            int ColonneDébut = Console.CursorLeft; // par rapport au sommet de la fenêtre
            int essais = 0;    // compteur d'essais
	        int joueur = 1 ;   // 1 pour la premier joueur, 2 pour le second
	        int l, c = 0;      // numéro de ligne et de colonne
            int j, k = 0;      // Parcourir le tableau en 2 dimensions
            bool gagner = false; // Permet de vérifier si un joueur à gagné 
            bool bonnePosition = false; // Permet de vérifier si la position souhaité est disponible

	        //--- initialisation de la grille ---
            // On met chaque valeur du tableau à 10
	        for (j=0; j < grille.GetLength(0); j++)
		        for (k=0; k < grille.GetLength(1); k++)
			        grille[j,k] = 10;
					while(!gagner && essais != 9)
					{
						//cette partie est simplement utilisée si la condition gagner est vraie elle permet donc d'afficher quel joueur a gagné (bonus la console se ferme automatiquement au bout de 5s)
						if(Gagner(0,0,1))
						   {
						   	gagner = true;
						   	if (joueur==2)
						   	{
						   		Console.Clear();
						   		Console.WriteLine("Le joueur 1 a gagné");
						   		Thread.Sleep(5000);
								System.Environment.Exit(0);
						   	}
						   	else
						   	{
						   		Console.Clear();
						   		Console.WriteLine("Le joueur 2 a gagné");
						   		Thread.Sleep(5000);
								System.Environment.Exit(0);
						   	}
						   	
						   }
						AfficherMorpion(j, k);

						// A compléter 
						try
						{
							
							if (joueur == 1)
							{
								Console.WriteLine();
								Console.WriteLine("Joueur 1 à toi !");
							}
							if (joueur == 2)
							{
								Console.WriteLine();
								
								Console.WriteLine("Joueur 2 à toi !");
							}
							Console.WriteLine("Ligne   =    ");
							Console.WriteLine("Colonne =    ");
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9); // Permet de manipuler le curseur dans la fenêtre 
							l = int.Parse(Console.ReadLine()) - 1; 
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10); // Permet de manipuler le curseur dans la fenêtre 
							c = int.Parse(Console.ReadLine()) - 1;
							Console.WriteLine();
							Console.WriteLine();
							//cette partie permet de positionner le choix de la case du joueur 1 ou du joueur 2
							for (j=0; j < grille.GetLength(0); j++)
		        			for (k=0; k < grille.GetLength(1); k++)
							{
								
									if ((j==l)&&(k==c))
							{
								if (joueur==1)
								{
									if (grille[j,k] != 1 && grille[j,k] != 2)
									grille[j,k] = 1;
								}
								if (joueur==2)
								{
									if (grille[j,k] != 1 && grille[j,k] != 2)
									grille[j,k] = 2;
								}
								
								
                        	
							}}
							//cela permet de revenir au joueur précédent
							joueur++;
                        	
                        	if(joueur==3)
                        		joueur=joueur-2;
                        	
								
							// A compléter 

						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}
						Console.Clear();

						// Changement de joueur
						// A compléter 

					}; // Fin TQ
					

            // Fin de la partie
            // A compléter 

            Console.ReadKey();
    }
  }
}
