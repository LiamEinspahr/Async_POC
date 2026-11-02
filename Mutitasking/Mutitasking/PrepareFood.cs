namespace Mutitasking
{
    public class PrepareFood
    {
        public PrepareFood() { }

        public async Task PrepareIngredients(int seconds) 
        {
            Log.Write("Preparing meal ingredients...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task CookFood(int seconds) 
        { 
            Log.Write("Cooking meal");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task EatFood(int seconds)
        {
            Log.Write("Eating food nom nom....");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public void Done() => Log.Write("Done preparing a meal!");
    }
}
