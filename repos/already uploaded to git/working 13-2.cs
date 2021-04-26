using System;

namespace bonus13_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string [] gameCharacters = { "Wizard 1","Wizard 2", "Wizard 3", "Warrior 1", "Wiarrior 2" };

            GameCharacter myGameCharacter = new GameCharacter();
            Warrior myWarrior = new Warrior();
            MagicUsingCharacter myMagicUsingCharacter = new MagicUsingCharacter();
            Wizard myWizard = new Wizard();

            foreach (string i in gameCharacters)
            {
                if (i == "Wizard 1" || i =="Wizard 2" || i == "Wizard 3")
                {
                    myWizard.Play();
                }
                else
                {
                    myWarrior.Play();
                }
            }
            Console.ReadLine();
        }
        
    }

}
