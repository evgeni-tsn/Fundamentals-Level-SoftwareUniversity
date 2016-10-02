using System;
using System.Linq;

namespace EntityFramework_Exercises
{
    class EFExercises
    {
        static BlogDBContext db = new BlogDBContext();
        static void Main()
        {
            //ListAllPosts();
            //ListAllUsers();
            //ListTitleAndBodyFromPosts();
            //OrderData();
            //OrderByTwoColumns();
            //SelectAuthors();
            //JoinsAuthorWithTitles(); 
            //SelectAuthorOfSpecificPost();

            //CreateData();

            //UpdateData();

            //DeleteData();

            //NestedDeleteData();

        }

        private static void NestedDeleteData()
        {
            var postInfo = db.Posts.Single(post => post.ID == 5);
            db.Comments.RemoveRange(postInfo.Comments);
            postInfo.Tags.Clear();
            db.Posts.Remove(postInfo);
            db.SaveChanges();
            Console.WriteLine("Post #{0} deleted successfully", postInfo.ID);
        }

        private static void DeleteData()
        {
            var commentInfo = db.Comments.Single(c => c.ID == 3);
            db.Comments.Remove(commentInfo);
            db.SaveChanges();
            Console.WriteLine(@"Comment #{0} deleted", commentInfo.ID);
        }

        private static void UpdateData()
        {
            Users userInfo = db.Users.Single(u => u.Username == "admin");

            string oldName = userInfo.FullName;

            userInfo.FullName = "Georgi Botev";

            db.SaveChanges();

            Console.WriteLine(@"User '{0}' has renamed to '{1}'", oldName, userInfo.FullName);
        }

        private static void CreateData()
        {
            Posts post = new Posts()
            {
                AuthorID = 2,
                Title = "Random Title",
                Body = "Random Content",
                Date = DateTime.Now
            };

            db.Posts.Add(post);
            db.SaveChanges();

            Console.WriteLine("Post #{0} Created!", post.ID);
        }

        private static void SelectAuthorOfSpecificPost()
        {
            var author = db.Users.SelectMany(user => user.Posts, (user, post) => new
            {
                user.Username,
                user.FullName,
                post.ID
            })
                        .Single(post => post.ID == 4);

            Console.WriteLine("Username: {0}", author.Username);
            Console.WriteLine("Full name: {0}", author.FullName);
            Console.WriteLine();
        }

        private static void JoinsAuthorWithTitles()
        {
            var users = db.Users.SelectMany(u => u.Posts, (user, post) => new
            {
                user.Username,
                post.Title
            });

            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.Username);
                Console.WriteLine("Post Title: {0}", user.Title);
                Console.WriteLine();
            }
        }

        private static void SelectAuthors()
        {
            var users = db.Users.Select(u => u)
                            .Where(u => u.Posts.Count > 0)
                            .ToList();

            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.Username);
                Console.WriteLine("Full Name: {0}", user.FullName);
                Console.WriteLine("Posts Count: {0}", user.Posts.Count);
                Console.WriteLine();
            }
        }

        private static void OrderByTwoColumns()
        {
            var users = db.Users.Select(u => new
            {
                u.Username,
                u.FullName
            })
                            .OrderByDescending(user => user.FullName)
                            .ThenByDescending(user => user.FullName)
                            .ToList();

            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.Username);
                Console.WriteLine("Full Name: {0}", user.FullName);
                Console.WriteLine();
            }
        }

        private static void OrderData()
        {
            var users = db.Users.Select(u => new
            {
                u.Username,
                u.FullName
            })
                            .OrderBy(u => u.Username)
                            .ToList();

            foreach (var user in users)
            {
                Console.WriteLine("Username: {0}", user.Username);
                Console.WriteLine("Full Name: {0}", user.FullName);
                Console.WriteLine();
            }
        }

        private static void ListTitleAndBodyFromPosts()
        {
            var posts = db.Posts.Select(p => new
            {
                p.Title,
                p.Body
            }
                        ).ToList();

            foreach (var post in posts)
            {
                Console.WriteLine("Title: {0}", post.Title);
                Console.WriteLine("Content: {0}", post.Body);
                Console.WriteLine();
            }
        }

        private static void ListAllUsers()
        {
            var users = db.Users.Select(u => u).ToList();

            foreach (var user in users)
            {
                Console.WriteLine("ID: {0}", user.ID);
                Console.WriteLine("Name: {0}", user.FullName);
                Console.WriteLine("Comments Count: {0}", user.Comments.Count);
                Console.WriteLine("Posts Count: {0}", user.Posts.Count);
                Console.WriteLine();
            }
        }

        private static void ListAllPosts()
        {
            var posts = db.Posts.Select(p => p).ToList();

            foreach (var post in posts)
            {
                Console.WriteLine("Title: {0}", post.Title);
                Console.WriteLine("AuthorID: {0}", post.AuthorID);
                Console.WriteLine("Comments Count: {0}", post.Comments.Count);
                Console.WriteLine("Tags Count: {0}", post.Tags.Count);
                Console.WriteLine();
            }
        }
    }
}
