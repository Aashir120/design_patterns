using System.Net.Sockets;
using System;

public class HelloWorld
{
    public interface File{
        void Read();
        void Write();
    }
    public class RealFile:File{
        private string name;
        public RealFile(string name){
            this.name = name;
        }
        public void Read(){
            System.Console.WriteLine("reading file"+name);
        }
        public void Write(){
            System.Console.WriteLine("writing file"+name);
        }
    }
    public class FileProxy:File{
        private File file;
        private string name;
        private string role;

        public FileProxy(string name,string role){
            this.name = name;
            this.role = role;
        }
        public void Read(){
            if(role == "admin"){
                if(file ==null){
                    file = new RealFile(name);
                }
                file.Read();
            } else{
                System.Console.WriteLine("access denied "+role);
            }
        }
        public void Write(){
            if(role == "admin"){
                if(file ==null){
                    file = new RealFile(name);
                }
                file.Write();
            } else{
                System.Console.WriteLine("access denied "+role);
            }
        }
    }

    public static void Main(string[] args)
    {
        File file = new FileProxy("file.txt","user");
        file.Read();
        file.Write();
        

    }
}