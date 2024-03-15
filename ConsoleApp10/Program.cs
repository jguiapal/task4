namespace ConsoleApp10
{
    internal class Program
    {

        static void enrollStudentMethod()
        {
            String studentName;
            bool studentExists = false;
            String addNew;

            Console.WriteLine("Enroll Student");
            Console.Write("Enter student name: ");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter Again? [Y/N]");
            addNew =Console.ReadLine();
            if (addNew == "y" || addNew == "Y")
            {
                enrollStudentMethod();
            }
            else
            {
                Console.Write("\nWelcome to Student Grades System\n[1] Enroll Students\n[2] Enter Student Grades\n[3] Show Student Grades\n[4] Show Top Student\n[5] Exit\nEnter Choice:");

            }
        }

        static void Main(string[] args)
         
        {
            int answer;
            int selectedMenu;
            Console.WriteLine("Enter total number of students.");
            answer = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nWelcome to Student Grades System\n[1] Enroll Students\n[2] Enter Student Grades\n[3] Show Student Grades\n[4] Show Top Student\n[5] Exit\nEnter Choice:");
            selectedMenu = Convert.ToInt32(Console.ReadLine());

            if(selectedMenu == 1)
            {
                enrollStudentMethod();
            }

        }
    }
}
