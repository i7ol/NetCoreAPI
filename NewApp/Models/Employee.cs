namespace NewApp.Models{
    public class Employee{
        public int id{get;set;}
        public string name{get;set;}
        public int age {get;set;}
        public double salary{get;set;}
        public void EnterData(){
            System.Console.Write("Ma nhan vien: ");
            id = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Ten: ");
            name = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            age = Convert.ToInt16(Console.ReadLine());
            System.Console.Write("Luong: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmployee(){
            System.Console.WriteLine("{0} - {1} - {2} tuoi - {3} luong",id,name,age,salary);
        }
    }
}