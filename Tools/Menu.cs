using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Tools
{
    public class Menu
    {
        public List<MenuItem>? Items { get; set; } = new();
        public void Show()
        {
            int selected = 0;
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                for (int i = 0; i < Items?.Count; i++)
                {
                    if (selected == i)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    Console.WriteLine($"<{i + 1} {Items[i].Tittel?.PadRight(25)}>>");
                    Console.ResetColor();
                }
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected > Items?.Count)
                    {
                        selected = 0;
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0)
                    {
                        selected = Items?.Count ?? -1;
                    }
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    var item = Items?[selected];
                    if (item?.TaskToDo != null)
                    {
                        item.TaskToDo();
                        Console.ReadKey();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}