using System;

namespace RepetitionExercises
{
    public class Contact
    {

        #region Instance Fields


        private string _name;

        private int _yearOfBirth;

        private string _email;

        private bool _isFamily;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            
        }

        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool IsFamily
        {
            get { return _isFamily; }
            
        }

        #endregion


        #region Constructor

        public Contact(string name, int yearOfBirth, bool isFamily)
        {
            _name = name;
            _yearOfBirth = yearOfBirth;
            _isFamily = isFamily;
            _email = "unknown@unknown.dk";

        }

        #endregion

        #region Methods

        public void printsummary()
        {
            Console.WriteLine($"Name: {_name}, Year of Birth: {_yearOfBirth}, Is Family: {_isFamily}, Email: {_email}");
        }

        #endregion


    }
}