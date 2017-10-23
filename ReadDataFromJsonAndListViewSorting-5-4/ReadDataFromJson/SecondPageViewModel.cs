using System;
using Xamarin.Forms;

namespace ReadDataFromJson
{
	public class SecondPageViewModel : ViewModelBase
	{
		public MyJsseResponse.RootObjectJSSE _selecteJSSEObject;

		Command _savecommand;
		public Command SaveChanges => _savecommand ?? (_savecommand = new Command(ExecuteSaveCommand));

        private  void ExecuteSaveCommand()
		{
			//await this._messageservice.ShowAsync("you saved data");

			 MessagingCenter.Send<SecondPageViewModel>(this, "Hi");
            App.Current.MainPage.Navigation.PushAsync(new ReadDataFromJsonPage());
			//inobj.FirstLabel = firstLabel;
			//inobj.SecondLabel = secondLabel;
			//inobj.SelectedDate = selectedDate;
			//inobj.SelectedPickerTitle = selectedPickerTitle;
		}
		public SecondPageViewModel(MyJsseResponse.RootObjectJSSE selecteJSSEObject)
		{
			_selecteJSSEObject = selecteJSSEObject;
			firstLabel = selecteJSSEObject.Observer.FullName;
			SecondLabel = selecteJSSEObject.JSSEEnteredBy;
		}

		string firstLabel;
		public string FirstLabel
		{
			get { return firstLabel; }
			set
			{
				if (firstLabel != value)
				{
					firstLabel = value;
					OnPropertyChanged("FirstLabel");
				}
			}
		}

		string secondLabel;
		public string SecondLabel
		{
			get { return secondLabel; }
			set
			{
				if (secondLabel != value)
				{
					secondLabel = value;
					OnPropertyChanged("SecondLabel");
				}
			}
		}
	}
}
