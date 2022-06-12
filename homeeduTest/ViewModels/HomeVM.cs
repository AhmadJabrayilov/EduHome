using homeeduTest.Models;
using System.Collections.Generic;

namespace homeeduTest.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> sliders { get; set; }
        public PageIntro pageIntro { get; set; }
        public IEnumerable<NoticeBoard> noticeBoards { get; set; }
        public IEnumerable<CourseDetail> courseDetails { get; set; }
        public IEnumerable<CoursesCard> courseCards { get; set; }
    }
}
