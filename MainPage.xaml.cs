namespace Jijon_ExamenP3;

{
    public partial class MainPage : ContentPage
{
    private readonly DogApiService _dogApiService = new DogApiService();

    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            List<string> breeds = await _dogApiService.GetRandomDogBreeds();

            if (breeds != null && breeds.Any())
            {
                string randomBreed = breeds[new Random().Next(0, breeds.Count)];
                string imageUrl = await _dogApiService.GetRandomDogImageUrl(randomBreed);

                BreedsLabel.Text = randomBreed;
                DisplayDogImage(imageUrl);
            }
            else
            {
                BreedsLabel.Text = "Failed to fetch dog breeds";
            }
        }
        catch (Exception ex)
        {
            BreedsLabel.Text = $"Error: {ex.Message}";
        }
    }

    private async void SearchButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            string breedName = BreedNameEntry.Text.Trim();

            if (!string.IsNullOrEmpty(breedName))
            {
                string imageUrl = await _dogApiService.GetRandomDogImageUrl(breedName);

                if (!string.IsNullOrEmpty(imageUrl))
                {
                    BreedsLabel.Text = breedName;
                    DisplayDogImage(imageUrl);
                }
                else
                {
                    BreedsLabel.Text = $"Breed '{breedName}' not found";
                    Layout.Children.Clear();
                }
            }
        }
        catch (Exception ex)
        {
            BreedsLabel.Text = $"Error: {ex.Message}";
        }
    }

    private void DisplayDogImage(string imageUrl)
    {
        Layout.Children.Clear();
        Image dogImage = new Image { Source = imageUrl };
        Layout.Children.Add(dogImage);
    }

}



