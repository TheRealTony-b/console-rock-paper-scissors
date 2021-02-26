using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int ScoreJoueur = 0 ;
            int ScoreOrdi = 0 ;
           
            if (ScoreJoueur == 3)
            {
                Console.WriteLine("You won the game!" + ScoreJoueur + "-" + ScoreOrdi);
            }
            if (ScoreOrdi == 3)
            {
                Console.WriteLine("You lost the game!" + ScoreJoueur + "-" + ScoreOrdi);
            }
            while (ScoreJoueur < 3 & ScoreOrdi < 3)
            {        
            Console.WriteLine("Rock(1) Paper(2) Scissors(3)");
            int joueur = Convert.ToInt32 (Console.ReadLine());
            
            Random rnd = new Random();
            int ordi = rnd.Next(1, 3);
            if (joueur == ordi)
            {
                Console.WriteLine("Draw!");
            }                
            switch(ordi)
            {
                case 1:
                    Console.WriteLine("The computer chose Rock");
                    if (joueur == 2)
                    {
                            ScoreJoueur++;
                            Console.WriteLine("You won the game!" + ScoreJoueur + "-" + ScoreOrdi);
                        
                    }
                    else if (joueur == 3)
                    {
                            ScoreOrdi++;
                            Console.WriteLine("You lost the game :(" + ScoreJoueur + "-" + ScoreOrdi);
                        
                    }
                    break;
                case 2:
                    Console.WriteLine("The computer chose paper ");
                    if (joueur == 3)                 
                    {
                            ScoreJoueur++;
                            Console.WriteLine("You won the game" + ScoreJoueur + "-" + ScoreOrdi);
                        
                    }
                    else if (joueur == 1)
                    {
                            ScoreOrdi++;
                            Console.WriteLine("You lost the game :(" + ScoreJoueur + "-" + ScoreOrdi);
                        
                    }
                    break;
                case 3:
                    Console.WriteLine("The computer chose scissors");
                    if (joueur == 1)
                    {
                            ScoreJoueur++;
                            Console.WriteLine("You won the game!" + ScoreJoueur + "-" + ScoreOrdi);
                       
                    }
                    else if (joueur == 1)
                    {
                            ScoreOrdi++;
                            Console.WriteLine("You lost the game :(" + ScoreJoueur + "-" + ScoreOrdi);
                        
                    }
                    break;
                }

            }

            
        }
    }
}
