﻿using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Morpion
{
    class Program
    {
    	 // Déclaration d'un tableau en 2 dimensions
            // On définit la longueur de chaque dimensions
            int [,] grilleInt = new int[3, 3];
            string[,] grilleString = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };


            int[,] grilleInt2 = new int[6, 4];

            // Pour accéder à la longueur du tableau dans sa dimensions 
            // 0 pour la première dimensions
            Console.WriteLine("Longeur première dimension : " + grilleInt.GetLength(0));
            // 1 pour la seconde dimensions
            Console.WriteLine("Longeur deuxième dimension: " + grilleInt.GetLength(1));
            Console.WriteLine("Total : " + grilleInt.Length);
            Console.WriteLine();
            // Pour accéder à la longueur du tableau dans sa dimensions 
            // 0 pour la première dimensions
            Console.WriteLine("Longeur première dimension : " + grilleString.GetLength(0));
            // 1 pour la seconde dimensions
            Console.WriteLine("Longeur deuxième dimension: " + grilleString.GetLength(1));

            // Parcourir un tableau int sans valeurs
            for (var j = 0; j < grilleInt.GetLength(0); j++)
            {
                for (var i = 0; i < grilleInt.GetLength(1); i++)
                {
                    Console.WriteLine("Matrix : " + j.ToString() + " . " + i.ToString() + " valeur : " + grilleInt[j, i]);

                }
            }

            Console.WriteLine();

            // Parcourir un tableau string avec des valeurs
            for (var j = 0; j < grilleString.GetLength(0); j++)
            {
                for (var i = 0; i < grilleString.GetLength(1); i++)
                {
                    Console.WriteLine("Matrix : " + j.ToString() + " . " + i.ToString() + " valeur : " + grilleString[j, i]);

                }
            }

            Console.WriteLine();
            // Pour accéder à la longueur du tableau dans sa dimensions 
            // 0 pour la première dimensions
            Console.WriteLine("Longeur première dimension : " + grilleInt2.GetLength(0));
            // 1 pour la seconde dimensions
            Console.WriteLine("Longeur deuxième dimension: " + grilleInt2.GetLength(1));
            Console.WriteLine("Affichage grille");

            // Dessiner une grille
            for (var j = 0; j < grilleInt2.GetLength(0); j++)
            {
                Console.Write("\n|====|====|====|====|\n");
                Console.Write("|");
                for (var i = 0; i < grilleInt2.GetLength(1); i++)
                {
                    Console.Write(" -- ");
                    Console.Write("|");
                }
                
            }
            Console.Write("\n|====|====|====|====|");


            Console.ReadKey();
        public static int[,] grille = new int[3, 3]; // matrice pour stocker les coups joués

        // Fonction permettant l'affichage du Morpion
        public static void AfficherMorpion(int j, int k)
        {
            // A compléter 
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

						// A compléter 
						try
						{
							Console.WriteLine("Ligne   =    ");
							Console.WriteLine("Colonne =    ");
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 9); // Permet de manipuler le curseur dans la fenêtre 
							l = int.Parse(Console.ReadLine()) - 1; 
							// Peut changer en fonction de comment vous avez fait votre tableau.
							Console.SetCursorPosition(LigneDébut + 10, ColonneDébut + 10); // Permet de manipuler le curseur dans la fenêtre 
							c = int.Parse(Console.ReadLine()) - 1;

							// A compléter 

						}
						catch (Exception e)
						{
							Console.WriteLine(e.ToString());
						}

						// Changement de joueur
						// A compléter 

					}; // Fin TQ

            // Fin de la partie
            // A compléter 

            Console.ReadKey();
    }
  }
}
