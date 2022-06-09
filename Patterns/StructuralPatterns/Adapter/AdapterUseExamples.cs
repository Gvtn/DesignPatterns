namespace StructuralPatterns.Adapter
{
    public static class AdapterUseExamples
    {
        public static void AdapterOfObjectRun()
        {
            var bassPlayer = new Bass(new Guitar());
            bassPlayer.PlayGuitar();
        }
    }
}
