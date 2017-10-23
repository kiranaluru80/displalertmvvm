using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReadDataFromJson
{
	public partial class SecondPage : ContentPage
	{
		public SecondPage(MyJsseResponse.RootObjectJSSE selecteJSSEObject)
		{
			InitializeComponent();
			MessagingCenter.Subscribe<SecondPageViewModel>(this, "Hi", (sender) =>
			{
				// do something whenever the "Hi" message is sent
				DisplayAlert("hiii", "data stored", "ok");
			});
			this.BindingContext = new SecondPageViewModel(selecteJSSEObject);
		}
	}
}
