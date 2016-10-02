namespace EntityFramework_Lab
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogDB : DbContext
    {
        public BlogDB()
            : base("name=BlogDB")
        {
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Posts>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Posts)
                .HasForeignKey(e => e.PostID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Posts>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Posts)
                .Map(m => m.ToTable("Posts_Tags").MapLeftKey("PostID").MapRightKey("TagID"));

            modelBuilder.Entity<Users>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Comments)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.AuthorID);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Posts)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.AuthorID);
        }
    }
}
