using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using Students.Entities;
using Students.Tools;
try
{
    List<Student> students = new();
    List<Professor> professors = new();

    Menu mainMenu = new();
    Menu studentMenu = new();
    Menu professorMenu = new();
    Menu adminMenu = new();
    Menu sittingMenu = new();

    #region StudentMenu
    studentMenu.Items =
    [
        new MenuItem
        {
            Tittel = "StudentList",
            TaskToDo = ()=>
            {
                TColor.Blue("============== StudentList ==============\n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                students.ForEach((p)=>Console.WriteLine($"<Id : {p.Id}> <FullName : {p.FullName}> <Age : {p.Age}> <Average : {p.Avg}>"));
                TColor.Blue("============== EndList ==============\n");
            }
        },
        new MenuItem
        {
            Tittel = "Add",
            TaskToDo = ()=>
            {
                students.Add(Operation.GetingStudentData());
                Console.Beep();
            }
        },
        new MenuItem
        {
            Tittel = "Edit",
            TaskToDo = ()=>
            {
                TColor.Yellow("Enter id(for edit) : ");
                int id = int.Parse(Console.ReadLine()?? "");
                var result = students.LastOrDefault((p) => p.Id == id);

                if (result == null)
                {
                    TColor.Red("Not Found!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("<<Student is Founded!>>");
                    Console.WriteLine($"<<Id:{id} FullName:{result.FullName} Avg:{result.Avg}>>");
                    Console.ResetColor();
                    result.Edit();
                    TColor.Green("<Successfully Edited !> \n");
                }
            }
        },
        new MenuItem
        {
            Tittel = "Search",
            TaskToDo = ()=>
            {
                TColor.Yellow("Enter id(for search) : ");
                int id = int.Parse(Console.ReadLine()?? "");
                var result = students.Where((p) => {return p.Id==id ;}).ToList();

                if (result.Count == 0)
                {
                    TColor.Red("Not Found!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    result.ForEach((p) => {Console.WriteLine($"<Id : [{p.Id}]  Fullname : [{p.FullName}]  Age : [{p.Age}]  Avg : [{p.Avg}]>");});
                    Console.ResetColor();
                }
            }
        },
        new MenuItem
        {
            Tittel = "Order By Average",
            TaskToDo = ()=>
            {
                TColor.Red("============== OrderByAvrageList ==============\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                students
                    .OrderByDescending(o => o.Avg)
                    .ToList()
                    .ForEach(p => Console.WriteLine($"<Id : [{p.Id}]  Fullname : [{p.FullName}]  Age : [{p.Age}]  Avg : [{p.Avg}]>"));
                TColor.Red("=================== EndList ===================\n");
            }
        },
        new MenuItem
        {
            Tittel = "Exit"
        }
    ];
    #endregion

    #region ProfessorsMenu
    professorMenu.Items =
    [
        new MenuItem
        {
            Tittel = "Professors List",
            TaskToDo = ()=>
            {
                TColor.Blue("============== ProfessorList ==============\n");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                professors.ForEach((p)=>Console.WriteLine($"<Id:{p.Id}> < FullName:{p.FullName}> <Age:{p.Age}> <Lesson:{p.Lesson}>"));
                TColor.Blue("============== EndList ==============\n");
            }
        },
        new MenuItem
        {
            Tittel = "Add",
            TaskToDo = ()=>
            {
                professors.Add(Operation.GetingProfessorData());
                Console.Beep();
            }
        },
        new MenuItem
        {
            Tittel = "Edit",
            TaskToDo = ()=>
            {
                TColor.Yellow("Enter id(for edit) : ");
                int id = int.Parse(Console.ReadLine()?? "");
                var result = professors.LastOrDefault((p) => p.Id == id);

                if (result == null)
                {
                    TColor.Red("Not Found!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("<<Professor is Founded!>>");
                    Console.WriteLine($"<<Id:{id} FullName:{result.FullName} Lesson:{result.Lesson}>>");
                    Console.ResetColor();
                    result.Edit();
                    TColor.Green("<Successfully Edited !> \n");
                }
            }
        },
        new MenuItem
        {
            Tittel = "Search",
            TaskToDo = ()=>
            {
                TColor.Yellow("Enter id(for search) : ");
                int id = int.Parse(Console.ReadLine()?? "");
                var result = professors.Where((p) => {return p.Id==id ;}).ToList();

                if (result.Count == 0)
                {
                    TColor.Red("Not Found!\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    result.ForEach((p) => {Console.WriteLine($"<Id : [{p.Id}]  Fullname : [{p.FullName}]  Age : [{p.Age}]  Lesson : [{p.Lesson}]>");});
                    Console.ResetColor();
                }
            }
        },
        new MenuItem
        {
            Tittel = "Exit"
        }
    ];
    #endregion

    #region AdminMenu
    adminMenu.Items =
    [
        new MenuItem
        {
            Tittel = "Remove Professors",
            TaskToDo = ()=>
            {
                TColor.Yellow("Enter Id(for remove) : ");
                int id = int.Parse(Console.ReadLine()??"");
                var result = professors.FirstOrDefault(p => p.Id==id);

                if (result == null)
                {
                    TColor.Red("Not Found!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"<<Professor with id[{result.Id}] and name[{result.FullName}] is Deleted!>>");
                    professors.Remove(result);
                }
            }
        },
        new MenuItem
        {
            Tittel = "Remove Students",
            TaskToDo = ()=>
            {
                TColor.Yellow("Enter Id(for remove) : ");
                int id = int.Parse(Console.ReadLine()??"");
                var result = students.FirstOrDefault(s => s.Id==id);

                if (result == null)
                {
                    TColor.Red("Not Found!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"<<Student with id[{result.Id}] and name[{result.FullName}] is Deleted!>>");
                    students.Remove(result);
                }
            }
        },
        new MenuItem
        {
            Tittel = "Change Password",
            TaskToDo = ()=>
            {
                TColor.Yellow("Enter new password : ");
                string password = Console.ReadLine()??"";
                Admin.ChangePassWord(password);
                TColor.Green("Your Password id changed! \n");
            }
        },
        new MenuItem
        {
            Tittel = "Deleted All Students",
            TaskToDo = ()=>
            {
                students.Clear();
                Student._studentIdCounter = 1001;
                TColor.Green("All Students is deleted!");
            }
        },
        new MenuItem
        {
            Tittel = "Deleted All Professors",
            TaskToDo = ()=>
            {
                professors.Clear();
                Professor._professorIdCounter = 1001;
                TColor.Green("All professors is deleted!");
            }
        },
        new MenuItem
        {
            Tittel = "Exit"
        }
    ];
    #endregion

    // #region SittingMenu
    // sittingMenu.Items =
    // [
    //     new MenuItem
    //     {
    //         Tittel = "Change The Color",
    //         TaskToDo = ()=>
    //         {

    //         }
    //     },
    //     new MenuItem
    //     {
    //         Tittel = "Change The Backgrand Color",
    //         TaskToDo = ()=>
    //         {

    //         }
    //     },
    //     new MenuItem
    //     {
    //         Tittel = "Exit"
    //     }
    // ];
    // #endregion

    #region MainMenu
    mainMenu.Items = [
    new MenuItem
    {
        Tittel = "Students",
        TaskToDo = () =>
        {
            studentMenu.Show();
        }
    },
    new MenuItem
    {
        Tittel = "Professors",
        TaskToDo = () =>
        {
            professorMenu.Show();
        }
    },
    new MenuItem
    {
        Tittel = "Admin",
        TaskToDo = () =>
        {
            while (true)
            {
                TColor.Yellow("Enter username : ");
                string username = Console.ReadLine()??"";
                TColor.Yellow("Enter password : ");
                string password = Console.ReadLine()??"";
                bool isValid = Admin.Login(username, password);

                if (isValid == true)
                {
                    TColor.Green("You are logged in !");
                    Thread.Sleep(1400);
                    adminMenu.Show();
                    break;
                }
                else
                {
                    TColor.Red("Error! the username or password is wrong!\n");
                    Console.Beep();
                    Thread.Sleep(1700);
                }
            }
        }
    },
    // new MenuItem
    // {
    //     Tittel = "Sitting",
    //     TaskToDo = () =>
    //     {
    //         sittingMenu.Show();
    //     }
    // },
    new MenuItem
    {
        Tittel = "Exit"
    }];
    mainMenu.Show();
    #endregion
}
catch (Exception ex)
{
    TColor.Red(ex.Message);
}