using System;
using System.Collections.Generic;

namespace Microsoft;
//@MejbanKadir
public static class Program
{
    public static List<String> Task = new List<String>();
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("What Do You Want?\n1/Add task\n2/Remove Task\n3/Show Tasks\n4/Edit Task\n5/Exit");
            string option = Console.ReadLine();

            Console.WriteLine("");//To Give A space (not so Important);

            if (option == "1")
            {
                Console.Write("Enter What Task You Wanna Add :");
                String TaskName = Console.ReadLine();

                AddItem(TaskName);
                Console.WriteLine("");
                ShowTask();


            }
            else if (option == "2")
            {
                Console.WriteLine("Which Task You Wanna Delete? : ");
                String task = Console.ReadLine();
                TaskRemover(task);
            }
            else if (option == "3")
            {
                Console.WriteLine("______Tasks_______");
                ShowTask();
                Console.WriteLine("");
            }
            else if (option == "4")
            {
                ShowTask();
                Console.WriteLine("Select Which one to Remove(with the index number in the Left)");
                String num = Console.ReadLine();
                int num2 = int.Parse(num);
                Console.WriteLine("Write Your Task: ");
                String newTask = Console.ReadLine();


                try
                {
                    Task[num2] = newTask;
                }
                catch
                {
                    Console.WriteLine("An Error Occured");
                }
            }
            else if (option == "5")
            {
                return;
            }
        }
    }

    public static void AddItem(String name)
    {
        Task.Add(name);

    }

    public static void TaskRemover(string task)
    {
        if (Task.Contains(task))
        {
            Task.Remove(task);
        }
        else
        {
            Console.WriteLine("Cannot Find The Task or Task Does not Exists");
        }
    }
    public static void ShowTask()
    {

        for (int i = 0; i < Task.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Task[i]}");
        }
    }
}

