using System.Text.RegularExpressions;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            student1.FullName = "Eli Memmedov";
            student1.GroupNo = "AB204";
            student1.AvgPoint = 81;

            Student student2 = new Student();
            student2.FullName = "Cavid Suleymanli";
            student2.GroupNo = "AB204";
            student2.AvgPoint = 95;

            Student student3 = new Student();
            student3.FullName = "Ehmed Osmanov";
            student3.GroupNo = "AF205";
            student3.AvgPoint = 100;

            Student student4 = new Student();
            student4.FullName = "Leyla Rustemli";
            student4.GroupNo = "AF205";
            student4.AvgPoint = 85;

            Student newStudent = new Student();
            Group group = new Group();


            do
            {
                Console.WriteLine("Studentlimit deyerini daxil edin:");
                group.StudentLimit = Convert.ToByte(Console.ReadLine());

                if (group.StudentLimit < 0 || group.StudentLimit > 20)
                {
                    Console.WriteLine("Limit asilmisdir");
                }
            }
            while (group.StudentLimit<0 || group.StudentLimit>20);

            do
            {
                Console.WriteLine("Qrup nomresi daxil edin:");
                group.GroupNo = Console.ReadLine();
                if (group.GroupNo.Length != 5 || !char.IsUpper(group.GroupNo[0]) || !char.IsUpper(group.GroupNo[1]))
                {
                    Console.WriteLine("Qrup nomresi duzgun deyil!");
                }
            }
            while (group.GroupNo.Length != 5 || !char.IsUpper(group.GroupNo[0]) || !char.IsUpper(group.GroupNo[1]));
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);

            


            int choice;
            do
            {
                Console.WriteLine("Menu:\n1.Telebe elave et.\n2.Butun telebelere bax.\n3.Telebeler uzre axtaris et.\n0.Proqrami bitir.");
                choice=Convert.ToInt32(Console.ReadLine());


                if (choice == 1)
                {
                    Console.WriteLine("Fullname daxil edin:");
                    string fullname=Console.ReadLine();

                    string groupno;
                    do
                    {

                        Console.WriteLine("Qrup nomresini daxil edin:");
                         groupno = Console.ReadLine();

                        if (groupno.Length != 5 || !char.IsUpper(groupno[0]) || !char.IsUpper(groupno[1]))
                        {
                            Console.WriteLine("Qrup nomresi duzgun daxil edilmeyib!");
                        }
                    }
                    while (groupno.Length != 5 || !char.IsUpper(groupno[0]) || !char.IsUpper(groupno[1]));


                    Console.WriteLine(" ");
                    string avgpointStr = " ";
                    byte avgpoint;

                    do
                    {
                        Console.WriteLine("Ortalama balini daxil edin:");
                        avgpointStr = Console.ReadLine();
                    }
                    while(!byte.TryParse(avgpointStr, out avgpoint));

                    Console.WriteLine("");
                    Console.WriteLine("Telebe elave edildi.");

                    newStudent= new Student(fullname,groupno,avgpoint);

                    group.AddStudent(newStudent);
                }
                else if(choice == 2)
                {
                    group.ShowAllStudent();
                }
                else if(choice == 3)
                {
                    Console.WriteLine("Axtaris etmek istediyiniz  deyeri daxil edin");
                    string value = Console.ReadLine();
                    Console.WriteLine("");

                    group.SearchStudent(value);
                }
            }
            while(choice!=0);

            Console.WriteLine("Proqram bitdi!");



        }
    }
}
