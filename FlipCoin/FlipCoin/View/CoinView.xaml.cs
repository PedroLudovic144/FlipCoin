using FlipCoin.ViewModels;

namespace FlipCoin.View;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		BindingContext = new CoinViewModel();
	}
}