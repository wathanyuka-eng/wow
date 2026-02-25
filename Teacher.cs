using System;

namespace LAB5
{
    public class Teacher : User, Member, StarterMember
    {
        private string major;
        private string position;

        public void SetTeacher(string majorName, string pos)
        {
            major = majorName;
            position = pos;
        }

        public void JoinTraining()
        {
            Console.WriteLine("Teacher registered for training.");
        }

        public void Teach()
        {
            Console.WriteLine("Teacher is teaching.");
        }

        public void Approve()
        {
            Console.WriteLine("Teacher approved training result.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Major: {major}");
            Console.WriteLine($"Position: {position}");
        }
    }
}