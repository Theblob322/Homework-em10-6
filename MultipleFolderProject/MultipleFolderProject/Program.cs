using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MultipleFolderProject
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            Chooser();   
        }
        public static void Chooser()
        {
            User user = new User("", "","");
            Blog blog = new Blog();
            Post post = new Post("", "", "");
            Comment comment = new Comment("", 0, "");
            for (int i = 0; i < int.MaxValue; i++) 
            {
                Console.WriteLine("Оберіть дію: \n[1] - Маніпуляція блогами (тільки коли є пост)\n[2] - Маніпуляція постами \n[3] - Створення користувача\n[4] - Написати коментар");
                short choice = Convert.ToInt16(Console.ReadLine());
                if (choice == 1) 
                {                    
                    Console.WriteLine("Оберіть дію: \n[1] - Створити блог\n[2] - Виадлити всі блоги \n[3] - Видалити конкретний блог \n[4] - Показати всі блоги\n[5] - Показати конкретний блог'");
                    short action = Convert.ToInt16(Console.ReadLine());
                    if (action == 1)
                    {
                        Blog.addPost(post);
                    }
                    else if (action == 2)
                    {
                        blog.removeallPosts();
                    }
                    else if (action == 3)
                    {
                        blog.removePost();
                    }
                    else if (action == 4)
                    {
                        blog.showallpost();
                    }
                    else if (action == 5) 
                    {
                        blog.showonepost();
                    }
                }
                else if (choice == 2) 
                {
                    Console.WriteLine("Оберіть дію: \n[1] - Створити пост\n[2] - Показати пост");
                    short action = Convert.ToInt16(Console.ReadLine());
                    if (action == 1)
                    {
                        Console.WriteLine("Ім'я автора сюди...");
                        post.setauthor(Console.ReadLine());
                        Console.WriteLine("Назва посту сюди...");
                        post.settitle(Console.ReadLine());
                        Console.WriteLine("Текст сюди...");
                        post.settext(Console.ReadLine());                       
                    }
                    else if (action == 2)
                    {
                       Console.WriteLine(post.getauthor());
                       Console.WriteLine(post.getTitle());
                       Console.WriteLine(post.getText());
                       Console.WriteLine(comment.gettext() + " ֍ " + comment.getrating());
                    }                   
                }
                else if (choice == 3) 
                {
                    Console.WriteLine("Ім'я");
                    user.setname(Console.ReadLine());
                    Console.WriteLine("Пароль");
                    user.setpassword(Console.ReadLine());
                    Console.WriteLine("Ел. пошта");
                    user.setemail(Console.ReadLine());
                }
                else if(choice == 4) 
                {
                    Console.WriteLine("Коментар сюди...");
                    comment.settext(Console.ReadLine());
                    Console.WriteLine("Рейтинг сюди...");
                    comment.setrating(Convert.ToInt16(Console.ReadLine()));                   
                }
            }
        }
    }
}
