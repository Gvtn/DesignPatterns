namespace BehavioralPatterns.Strategy
{
    internal static class StrategyUseExample
    {
        public static void SimpleStrategyExampleRun()
        {
            Hero hero = new("Squidward");

            hero.Attack();

            hero.SetWeapon(new Broom());
            hero.Attack();

            hero.SetWeapon(new Plunger());
            hero.Attack();
        }
    }
}
