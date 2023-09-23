using MentorDinamik.Entities;

namespace MentorDinamik.ModelViews
{
	public class HomeVM
	{
		public List<Course> Courses { get; set; }
		public List<Feature> Features { get; set; }
		public List<Trainer> Trainers { get; set; }
		public List<WhyUs> WhyUss { get; set; }
		public List<About> Abouts { get; set; }
		public AboutImage AboutImages { get; set; }

	}
}
