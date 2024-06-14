using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MultipleFolderProject
{
    internal class Blog
    {
        static List<string> blogs;

        public Blog() 
        {
           List<string> blogs = new List<string>();
        }
        public static void addPost(Post post) 
        {          
            blogs.Add(post.ToString());
        }
        public void removePost() 
        {
            Console.WriteLine("Номер блогу сюди...");
            int number = Convert.ToInt32(Console.ReadLine());
            blogs.RemoveAt(number);
        }
        public void removeallPosts() 
        {
            blogs.Clear();
        }
        public void showonepost() 
        {
            Console.WriteLine("Номер блогу сюди...");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(blogs[number]);
        }
        public void showallpost() 
        {
            for (int i = 0; i < blogs.Count; i++) 
            {
                Console.WriteLine(blogs[i]);
            }
        }
    }
}
