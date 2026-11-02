namespace Mutitasking
{
    public class TidyUp
    {
        public TidyUp() { }

        public async Task PutThingsBack(int seconds) 
        { 
            Log.Write("Putting things back where they belong...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task Vaccuum(int seconds) 
        {
            Log.Write("Vaccuuming everything...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task MakeBed(int seconds) 
        {
            Log.Write("Making my bed....");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public void Done() => Log.Write("Done tidying up!");
    }
}
