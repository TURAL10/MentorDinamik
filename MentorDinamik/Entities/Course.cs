namespace MentorDinamik.Entities
{
	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public int Price { get; set; }
		public string Title { get; set; }
		public string TitleUrl { get; set; }
		public string Desc { get; set; }
		public Trainer Trainer { get;set; }

	}
}
