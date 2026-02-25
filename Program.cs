using System;
using System.Collections.Generic;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> participants = new List<Member>();
            List<StarterMember> speakers = new List<StarterMember>();

            while (true)
            {
                Console.WriteLine("\n=== Training Registration ===");
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Teacher");
                Console.WriteLine("3. Guest");
                Console.WriteLine("4. Show Participants");
                Console.WriteLine("5. Show Speakers");
                Console.WriteLine("0. Exit");

                Console.Write("Select: ");
                string choice = Console.ReadLine();

                if (choice == "0") break;

                switch (choice)
                {
                    case "1":
                        Student s = new Student();
                        Console.Write("First name: ");
                        string sf = Console.ReadLine();
                        Console.Write("Last name: ");
                        string sl = Console.ReadLine();
                        Console.Write("Email: ");
                        string se = Console.ReadLine();
                        Console.Write("Phone: ");
                        string sp = Console.ReadLine();
                        Console.Write("Student ID: ");
                        string sid = Console.ReadLine();
                        Console.Write("Major: ");
                        string sm = Console.ReadLine();

                        s.Register(sf, sl, se, sp);
                        s.SetStudent(sid, sm);
                        participants.Add(s);
                        break;

                    case "2":
                        Teacher t = new Teacher();
                        Console.Write("First name: ");
                        string tf = Console.ReadLine();
                        Console.Write("Last name: ");
                        string tl = Console.ReadLine();
                        Console.Write("Email: ");
                        string te = Console.ReadLine();
                        Console.Write("Phone: ");
                        string tp = Console.ReadLine();
                        Console.Write("Major: ");
                        string tm = Console.ReadLine();
                        Console.Write("Position (อ., ผศ., รศ., ศ): ");
                        string tpos = Console.ReadLine();

                        t.Register(tf, tl, te, tp);
                        t.SetTeacher(tm, tpos);

                        participants.Add(t);
                        speakers.Add(t); // Teacher เป็นวิทยากรได้
                        break;

                    case "3":
                        Guest g = new Guest();
                        Console.Write("First name: ");
                        string gf = Console.ReadLine();
                        Console.Write("Last name: ");
                        string gl = Console.ReadLine();
                        Console.Write("Email: ");
                        string ge = Console.ReadLine();
                        Console.Write("Phone: ");
                        string gp = Console.ReadLine();
                        Console.Write("Workplace: ");
                        string gw = Console.ReadLine();
                        Console.Write("Position: ");
                        string gpos = Console.ReadLine();

                        g.Register(gf, gl, ge, gp);
                        g.SetGuest(gw, gpos);

                        participants.Add(g);
                        speakers.Add(g); // Guest เป็นวิทยากรได้
                        break;

                    case "4":
                        Console.WriteLine("\n--- Participants ---");
                        foreach (Member m in participants)
                        {
                            ((User)m).ShowInfo();
                            Console.WriteLine("------------------");
                        }
                        break;

                    case "5":
                        Console.WriteLine("\n--- Speakers ---");
                        foreach (StarterMember spk in speakers)
                        {
                            ((User)spk).ShowInfo();
                            Console.WriteLine("------------------");
                        }
                        break;
                }
            }
        }
    }
}