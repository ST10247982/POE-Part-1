namespace KhumaloCraft.Models
{
	public class ArtisanWork
	{
		public ArtisanWork(string artisanName, string artisanSurname, string description, double rating, double price, string imgSource)
		{
			ArtisanName = artisanName;
			ArtisanSurname = artisanSurname;
			Desciption = description;
			Price = price;
			ImgSource = imgSource;
			Rating = rating;

		}
		//  public string? ArtisanID { get; private set; }
		public string? ArtisanName { get; set; }
		public string? ArtisanSurname { get; set; }
		public string? Desciption { get; set; }
		public double Price { get; set; } = 0;
		public string? ImgSource { get; set; }
		public double? Rating { get; set; }
		public List<ArtisanWork>? artisanWorks { get; set; }
		/*     public void GenerateArtisanID()
        {
               Random random = new Random();
               int randomNum = random.Next(100, 1000);
               ArtisanID = ArtisanName.Substring(0, 1) + ArtisanName.Substring(ArtisanName.Length - 1, 1) + randomNum.ToString();
           } */
		// this will be coming into play in part 2


	}
}
