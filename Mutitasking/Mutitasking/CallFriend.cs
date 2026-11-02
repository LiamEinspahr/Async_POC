namespace Mutitasking
{
    public class CallFriend
    {

        public CallFriend()
        {

        }

        public void AwaitingCall()
        {
            Console.WriteLine("Waiting on  call from my friend...\n");
        }

        public void PickingUpCall()
        {
            Console.WriteLine("I need to pick up the phone...\n");
        }

        public void Calling()
        {
            Console.WriteLine("On a call with my friend...\n");
        }

        public void HangUpCall()
        {
            Console.WriteLine("Hanging up the call...\n");
        }
        public void Done()
        {
            Console.WriteLine("Done calling my friend!\n");
        }

    }
}
