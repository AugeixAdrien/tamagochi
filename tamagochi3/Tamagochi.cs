using System;

namespace tamagochi3
{
    public class Tamagochi
    {
        private int satisfaction = 10;
        private int taille = 10;
        private bool vivant = true;
        
        public int GetTaille()
        {
            return taille;
        }
        
        public int GetSatisfaction()
        {
            return satisfaction;
        }
        
        public void Jouer()
        {
            satisfaction += 1;
            taille += 1;
        }
        
        public void Nourrir()
        {
            satisfaction += 1;
            taille += 1;
        }
        
        public void Gronder()
        {
            PerdreSatisfaction();
            taille += 1;
        }
        
        public void Travailler()
        {
            PerdreSatisfaction();
            taille += 1;
        }
        
        public void Dormir()
        {
            satisfaction += 1;
            taille += 1;
        }
        
        public void Grandir()
        {
            taille += 1;
        }
        
        public void GagnerSatisfaction()
        {
            satisfaction += 1;
        }
        
        private void PerdreSatisfaction()
        {
            // si la satisfaction est à 0, le tamagochi meurt
            if (satisfaction <= 0)
            {
                vivant = false;
            }
            else
            {
                satisfaction -= 1;
            }
        }
        
        public bool EstVivant()
        {
            return vivant;
        }
    }
}