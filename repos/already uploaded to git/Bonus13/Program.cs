using System;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gameCharacters = new string[5];
            
            GameCharacter myGameCharacter = new GameCharacter();
            Warrior myWarrior = new Warrior();
            MagicUsingCharacter myMagicUsingCharacter = new MagicUsingCharacter();
            Wizard myWizard = new Wizard();


            Console.Write("Enter the character name "); 
            var Name = Console.ReadLine();
           
            Console.Write("Enter the character strength: ");
            var Strength = int.Parse(Console.ReadLine()),
            
            Console.Write("Enter the character intelligence: ");
            var Intelligence = int.Parse(Console.ReadLine());


            foreach (var GameCharacter in gameCharacters)
            {
                
                for (int i = 0; i < 3; i++)
                {
                   myWizard.Play();
                }
                for (int i = 3; i > 2; i++)
                {
                   myWarrior.Play();
                }
                break;
            }

           /* myGameCharacter.Play();
            myWarrior.Play();
            myMagicUsingCharacter.Play();
            myWizard.Play(); */

        }
    }

    public class GameCharacter
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

        public virtual void Play(string Name, int Strength, int Intelligence)
        {
            Console.WriteLine($"Character name: {Name} ");
            Console.WriteLine($"Character strength: {Strength} ");
            Console.WriteLine($"Character intelligence: {Intelligence} ");
        }

    }

    public class Warrior : GameCharacter
    {
        public Warrior(string name, int strength, int intelligence, string weapontype)
        {

        }
        public string weaponType { get; set; }
        {

        }
        public override void Play(string Name, int Strength, int Intelligence)
        {
            Console.WriteLine($"Character weapon type: {weaponType}" + string Name , int Strength , int Intelligence );
        base.Play(string Name, int Strength, int Intelligence);
        }

    }

    public class MagicUsingCharacter : GameCharacter
    {
    public MagicUsingCharacter()
    {
    }

    public magicUsingCharacter(string name, int strength, int intelligence, string magicalEnergy)
        {

        }
        public int magicalEnergy { get; set; }
    
        public override void Play()
        {
            Console.WriteLine($"Character magical energy: {magicalEnergy} ");
        }

    }

    public class Wizard : MagicUsingCharacter
    {
        public Wizard(string name, int strength, int intelligence, string magicalEnergy, string spellNumber)
        {

        }
       public int spellNumber { get; set; }
        public override void Play()
        {
            Console.WriteLine($"Character spell number: {spellNumber} ");
        }

    }

}


