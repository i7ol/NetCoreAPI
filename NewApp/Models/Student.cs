using System.Security.AccessControl;

namespace NewApp.Models{
    public class Student{
        public int MSSV{get;set;}
        public string name{get; set;}
        public int age{get;set;}
        public string lop{get;set;}
        public void Infor(){
            System.Console.Write("MSSV: ");
            MSSV = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Ten sinh vien: ");
            name = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            age = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Lop: ");
            lop = Console.ReadLine();
        }
        public void DisplayStudent(){
            Console.WriteLine("MSSV: {0} - Ten: {1} - Tuoi: {2} - Lop: {3}",MSSV,name,age,lop);
        }
    }
}