namespace Mutitasking
{
    public class CallFriend
    {

        public CallFriend()
        {

        }

        public async Task AwaitingCall(int seconds)
        {
            Log.Write("Waiting on  call from my friend...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task PickingUpCall(int seconds)
        {
            Log.Write("I need to pick up the phone...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task Calling(int seconds)
        {
            Log.Write("On a call with my friend...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }

        public async Task HangUpCall(int seconds)
        {
            Log.Write("Hanging up the call...");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
        }
        public void Done() => Log.Write("Done calling my friend!");


    }
}
