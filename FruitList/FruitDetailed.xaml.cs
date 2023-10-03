namespace FruitList;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string FruitName,string fruitImage,string fruitDescription)
	{
		InitializeComponent();
		ShowName.Text = FruitName;
		ShowDescription.Text = fruitDescription;
		ShowImage.Source = fruitImage;
	}
}