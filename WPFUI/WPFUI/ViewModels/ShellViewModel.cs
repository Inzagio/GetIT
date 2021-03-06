﻿using System.Diagnostics.CodeAnalysis;
using Caliburn.Micro;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
   [SuppressMessage("ReSharper", "UnusedMember.Global")]
   public class ShellViewModel : Conductor<object>
    { 
        private string _firstName = "Trym";
        private string _lastName;
        private PersonModel _selectedPerson;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();

        public ShellViewModel()
        {
            People.Add( new PersonModel {FirstName = "Trym", LastName = "Test"});
            People.Add( new PersonModel {FirstName = "test", LastName = "Testesen"});
            People.Add( new PersonModel {FirstName = "Virkelig", LastName = "TEst"});
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName => $"{ FirstName } { LastName }";

        public BindableCollection<PersonModel> People
        {
            get => _people;
            set => _people = value;
        }
       
        public PersonModel SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(()=> SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName) => !string.IsNullOrWhiteSpace(firstName) || !string.IsNullOrWhiteSpace(lastName);

        public void ClearText(string firstName, string lastName)
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public void LoadPageOne()
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }
    }
}
    