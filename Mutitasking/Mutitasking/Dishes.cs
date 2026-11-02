namespace Mutitasking
{
    public class Dishes
    {

        public Dishes() { }

        public async Task WashDishes(int seconds) 
        { 
            Log.Write("Washing the dishes...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task DryDishes(int seconds) 
        { 
            Log.Write("Drying the dishes...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task PuttingUpDishes(int seconds) 
        { 
            Log.Write("Putting up dishes...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public void Done() => Log.Write("Done with dishes!");
    }
}
