namespace Mutitasking
{
    public class Laundry
    {

        public Laundry() { }

        public async Task WashClothes(int seconds)
        {
            Log.Write("Washing clothes...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task DryingClothes(int seconds)
        {
            Log.Write("Drying clothes...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task FoldClothes(int seconds)
        {
            Log.Write("Folding clothes...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public void Done() => Log.Write("Done with laundry!");
    }
}
