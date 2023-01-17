using System;

public class HelloWorld
{
    public class Task{
        private string name;
        private string project;
        private int no;
        private List<Task> subordinates;

        public Task(string name,string project,int no){
            this.name = name;
            this.project = project;
            this.no = no;
            subordinates = new List<Task>();
        }
        public void Add(Task t){
            subordinates.Add(t);
        }
        public void Remove(Task t){
            subordinates.Remove(t);
        }

        public List<Task> Display(){
            return subordinates;
        }
    }

    public static void Main(string[] args)
    {
        Task one = new Task("mobile","podz",1);
        Task subone = new Task("web","podz",2);
        Task two = new Task("design1","desing",2);
        Task subtwo = new Task("design2","design",2);
        Task isubtwo = new Task("desing3","design",2);
        one.Add(subone);
        two.Add(subtwo);
        subtwo.Add(isubtwo);

        // foreach (Task first in one.Display())
        // {
        //     System.Console.WriteLine(first);
            
        // }
        System.Console.WriteLine(two);
    }
}