using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFramework_Lab
{
    class EFLab
    {
        static void Main()
        {
            //TestGeneratedDbContext();
            //QueryData();
            //CreateNewEntryInDB();
            //CascadingInsert();
            //UpdateExistingData();
            //DeleteExistingData();
            //ExecuteNativeSQL();
        }

        private static void ExecuteNativeSQL()
        {
            var db = new BlogDB();
            var startDate = new DateTime(2016, 05, 19);
            var endDate = new DateTime(2016, 06, 14);
            var posts = db.Database.SqlQuery<PostData>(
              @"SELECT ID, Title, Date FROM Posts
                WHERE CONVERT(date, Date)
                BETWEEN {0} AND {1}
                ORDER BY Date",
              startDate, endDate);

            foreach (var p in posts)
            {
                Console.WriteLine(
                  $"#{p.ID}: {p.Title} ({p.Date})");
            }
        }

        private static void DeleteExistingData()
        {
            var db = new BlogDB();
            var lastPost = db.Posts.OrderByDescending(p => p.ID).First();

            db.Comments.RemoveRange(lastPost.Comments);
            lastPost.Tags.Clear();
            db.Posts.Remove(lastPost);
            db.SaveChanges();

            Console.WriteLine($"Deleted post #{lastPost.ID}");
        }

        private static void UpdateExistingData()
        {
            var db = new BlogDB();
            var user = db.Users.Where(u => u.Username == "maria").FirstOrDefault();

            user.PasswordHash = Guid.NewGuid().ToByteArray();
            db.SaveChanges();

            Console.WriteLine("User #{0} ({1}) has a new random password.", user.ID, user.Username);
        }

        private static void CascadingInsert()
        {
            var db = new BlogDB();
            var post = new Posts()
            {
                Title = "New Post Title",
                Date = DateTime.Now,
                Body = "This post have comments and tags",
                Users = db.Users.First(),
                Comments = new Comments[]
                {
                    new Comments() { Text = "Comment 1", Date=DateTime.Now },
                    new Comments() { Text = "Comment 2", Date=DateTime.Now,
                    Users = db.Users.First()} },
                Tags = db.Tags.Take(3).ToList()
            };
            db.Posts.Add(post);
            db.SaveChanges();
        }

        private static void CreateNewEntryInDB()
        {
            var db = new BlogDB();
            var post = new Posts()
            {
                Title = "New Title",
                Body = "New Post Body",
                Date = DateTime.Now
            };
            db.Posts.Add(post);
            db.SaveChanges();
        }

        private static void QueryData()
        {
            var db = new BlogDB();

            var postsQuery = db.Posts.Select(p => new
            {
                p.ID,
                p.Title,
                Comments = p.Comments.Count(),
                Tags = p.Tags.Count()
            });

            Console.WriteLine("SQL query:\n{0}\n", postsQuery);

            foreach (var p in postsQuery)
            {
                Console.WriteLine($"{p.ID} {p.Title} ({p.Comments} comments, {p.Tags} tags)");
            }
        }

        private static void TestGeneratedDbContext()
        {
            var db = new BlogDB();
            foreach (var user in db.Users)
            {
                Console.WriteLine(user.Username);
            }
        }
    }
}
