using System;

namespace SchoolerClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Schooler schooler = new Schooler("Oleg Golenischev",15,8,new int[]{5,4,4,5,4});
            schooler.PrintInfo();
            Console.WriteLine($"Average mark: {schooler.AverageMark()}");
        }
    }
}
