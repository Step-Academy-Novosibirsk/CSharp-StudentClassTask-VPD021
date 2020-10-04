using System;

namespace SchoolerClassTask
{
    class Schooler
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Class { get; private set; }
        private int[] _marks;

        public Schooler(string name, int age, int classNumber, int[] marks)
        {
            Name = name;
            Age = age;
            Class = classNumber;
            _marks = new int[marks.Length];
            for (int i = 0; i < marks.Length; i++)
                _marks[i] = marks[i];
        }

        public int AverageMark()
        {
            int sum = 0;
            foreach (var mark in _marks)
                sum += mark;
            return sum /_marks.Length;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Class: {Class}");
            Console.Write("Marks: ");
            foreach (var mark in _marks)
                Console.Write($"{mark} ");
            Console.WriteLine();
        }


    }
}
