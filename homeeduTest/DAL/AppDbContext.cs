using homeeduTest.Models;
using Microsoft.EntityFrameworkCore;

namespace homeeduTest.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<PageIntro> PageIntros { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CoursesCard> CourseCards { get; set; }
    }
}
