namespace WestsideRPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Wizard()
        {
        }

        public override string Attack()
        {
            return this.Name + " throws a magic spell. Pftt!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " throws a super effective magic spell with a bonus of " + Bonus;
            }
            return this.Name + " throws a simple spell plus a bonus of " + Bonus;
        }
    }
}