using DropdownIssue.picker;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DropdownIssue.ViewModels
{
    public class StudentViewModel : BaseViewModel
    {
        public StudentViewModel()
        {
            country = PickerService.GetCountries();
            state = PickerService.GetStates();
            city = PickerService.GetCities();
            itemVisibility = true;
            buttonText = "Item View Visible : " + itemVisibility.ToString();
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged();
            }
        }

        private List<string> city;
        public List<string> City
        {
            get { return city; }
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }

        private List<string> state;
        public List<string> State
        {
            get { return state; }
            set
            {
                state = value;
                OnPropertyChanged();
            }
        }

        private List<string> country;
        public List<string> Country
        {
            get { return country; }
            set
            {
                Console.WriteLine("Country value is : " + country);
                Console.WriteLine("Country value is : " + value);
                country = value;
                OnPropertyChanged();
            }
        }


        private List<string> selectedCountry;
        public List<string> SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                Console.WriteLine("selectedCountry value is : " + selectedCountry);
                Console.WriteLine("selectedCountry value is : " + value);
                selectedCountry = value;
                OnPropertyChanged();
            }
        }


        private List<string> selectedCity;
        public List<string> SelectedCity
        {
            get { return selectedCity; }
            set
            {
                Console.WriteLine("SelectedCity value is : " + selectedCity);
                Console.WriteLine("SelectedCity value is : " + value);
                selectedCity = value;
                OnPropertyChanged();
            }
        }

        private List<string> selectedState;
        public List<string> SelectedState
        {
            get { return selectedState; }
            set
            {
                Console.WriteLine("SelectedState value is : " + selectedState);
                Console.WriteLine("SelectedState value is : " + value);
                selectedState = value;
                OnPropertyChanged();
            }
        }


        private string buttonText;
        public string ButtonText
        {
            get { return buttonText; }
            set
            {
                buttonText = value;
                OnPropertyChanged();
            }
        }

        private bool itemVisibility;
        public bool ItemVisibility
        {
            get { return itemVisibility; }
            set
            {
                itemVisibility = value;
                OnPropertyChanged();
            }
        }

        public Command ControlVisibility
        {
            get
            {
                return new Command(ItemVisibilityControl);
            }
        }

        public void ItemVisibilityControl()
        {
            
            ItemVisibility = !ItemVisibility;
            ButtonText = "Item View Visible : " + itemVisibility.ToString();
        }

    }
}
