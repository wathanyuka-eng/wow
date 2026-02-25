using System;

namespace LAB5
{
    public class Student : User, Member
    {
        private string studentId;
        private string major;

        public void SetStudent(string id, string majorName)
        {
            studentId = id;
            major = majorName;
        }

        public void JoinTraining()
        {
            Console.WriteLine("Student registered for training.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Major: {major}");
        }
    }
}