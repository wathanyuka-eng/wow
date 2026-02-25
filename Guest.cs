using System;

namespace LAB5
{
    public class Guest : User, Member, StarterMember
    {
        private string workplace;
        private string position;

        public void SetGuest(string work, string pos)
        {
            workplace = work;
            position = pos;
        }

        public void JoinTraining()
        {
            Console.WriteLine("Guest registered for training.");
        }

        public void Teach()
        {
            Console.WriteLine("Guest is teaching.");
        }

        public void Approve()
        {
            Console.WriteLine("Guest approved training result.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Workplace: {workplace}");
            Console.WriteLine($"Position: {position}");
        }
    }
}
