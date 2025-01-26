namespace NewApp.Models{
    public class Fruit{
        public string name{get;set;}
        public string NSX{get;set;}
        public int namSX{get;set;}
        public void Infor(){
            namSX = Convert.ToInt16(Console.ReadLine());
            name = Console.ReadLine();
            NSX = Console.ReadLine();
        }
        public void DisplayFruit(){
            Console.WriteLine(" qua {0} - nha san xuat {1} - nam {2}",name,NSX,namSX);
        }
    }
}