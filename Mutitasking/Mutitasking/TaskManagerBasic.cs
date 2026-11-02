using System;

namespace Mutitasking
{
    public class TaskManagerBasic
    {
        private Random rand = new Random();
        private CallFriend CallFriend { get; set; }
        private Dishes Dishes { get; set; }
        private DoHomework DoHomework { get; set; }
        private Laundry Laundry { get; set; }
        private PrepareFood PrepareFood { get; set; }
        private TidyUp TidyUp { get; set; }

        private int GenerateNumberConstraints(int lower, int upper)
        {
            int upperInclusive = upper + 1;
            return (rand.Next(lower, upperInclusive));
        }

        public TaskManagerBasic() { }


  
    }
}
