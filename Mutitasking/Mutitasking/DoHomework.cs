namespace Mutitasking
{
    public class DoHomework
    {
        public DoHomework() { }

        public async Task StartHomework(int seconds)
        {
            Log.Write("Starting my homework...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task QuickBreak(int seconds)
        {
            Log.Write("Taking a quick break from my homework...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task TurnInHomework(int seconds)
        {
            Log.Write("Now I need to turn in my assignment...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public void Done() => Log.Write("Done with my homework!...");
    }
}
