namespace AppMaui_NumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnGeraNumeroSorte_Clicked(object sender, EventArgs e)
    {
		lblNumeroSorte01.IsVisible = false;
		lblNumeroSorte02.IsVisible = true;
        hslNumero.IsVisible = true;
		lblBoaSorte.IsVisible = true;

		var set = GenerateLukeNumbere();

        Numero01.Text = set.ElementAt(0).ToString("D2");
        Numero02.Text = set.ElementAt(1).ToString("D2");
        Numero03.Text = set.ElementAt(2).ToString("D2");
        Numero04.Text = set.ElementAt(3).ToString("D2");
        Numero05.Text = set.ElementAt(4).ToString("D2");
        Numero06.Text = set.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> GenerateLukeNumbere()
	{
		var set = new SortedSet<int>();
		while (set.Count < 6)
		{
            var random = new Random();
            var luckNumber = random.Next(1, 60);
			set.Add(luckNumber);
        }

		return set;
	}
}