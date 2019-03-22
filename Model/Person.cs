using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.Tools;
using lab2.Tools.Exeptions;

namespace lab2
{
    internal class Person
    {
        private static readonly int MaxPersonAge = 135;
        #region fields
        private string _name;
        private string _surname;
        private string _eMail;
         private DateTime _birthdayDate;
        #endregion
        private string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        private string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
            }
        }

        private string EMail
        {
            get { return _eMail; }
            set
            {
                _eMail = value;
            }
        }
        internal Person(string name, string surname, string eMail, DateTime birthdayDate)
        {
            ConstructAndValidate(name, surname, eMail, birthdayDate);
        }

        internal Person(string name, string surname, string eMail)
        {
            ConstructAndValidate(name, surname, eMail, default(DateTime));
        }

        internal Person(string name, string surname, DateTime birthdayDate)
        {
            ConstructAndValidate(name, surname, default(string), birthdayDate);
        }

        private DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
            }
        }

        private bool IsAdult
        {
            get { return IsOlderThan(18); }
        }

        private string SunSign
        {
            get { return WestYear(BirthDate); }
        }

        private string ChineaseSign
        {
            get { return ChineeseYear(BirthDate); }
        }

        internal bool IsBirthday
        {
            get { return IsBirthdayToday(); }
        }



        public DateTime _birthDate = DateTime.Today;

        private void ConstructAndValidate(string name, string surname, string eMail, DateTime birthdayDate)
        {
            _name = name;
            _surname = surname;
            _eMail = eMail;
            _birthdayDate = birthdayDate;
            CheckName(name);
            CheckName(surname);
            ValidateEmail(eMail);
            CheckBirthdayDate(birthdayDate);
        }

        private void ValidateEmail(string eMail)
        {
            if (eMail == default(string))
            {
                return;
            }
            if (!RegexUtilities.IsValidEmail(eMail))
            {
                throw new WrongEmailException($"Email is incorrect: {eMail}");
            }
        }

        private void CheckBirthdayDate(DateTime birthdayDate)
        {
            if (birthdayDate == default(DateTime))
            {
                return;
            }
            if (IsOlderThan(MaxPersonAge))
            {
                throw new TooOldException($"Person is too old, birthday date: {birthdayDate.ToShortDateString()}");
            }
            else if (!IsOlderThan(0))
            {
                throw new LateBirthdayException($"Person haven't born yet, birthday date: {birthdayDate.ToShortDateString()}");
            }
        }

        private void CheckName(string name)
        {
            if (!name.All(char.IsLetter))
            {
                throw new WrongNameException($"This name is bad {name}");
            }
        }

        private bool IsOlderThan(int age)
        {
            if (DateTime.Today.Year - BirthDate.Year < age) return false;
            else if (DateTime.Today.Year - BirthDate.Year == age)
            {
                if (DateTime.Today.Month < BirthDate.Month) return false;
                else if (DateTime.Today.Month == BirthDate.Month)
                {
                    if (DateTime.Today.Day < BirthDate.Day) return false;
                }

            }
            return true;
        }



        private string ChineeseYear(DateTime BirthDate)
        {

            string chineeseYearOfBirth = "default";

            if ((BirthDate.Year) % 12 == 0)
            {
                chineeseYearOfBirth = "monkey";
            }
            if ((BirthDate.Year) % 12 == 1)
            {
                chineeseYearOfBirth = "cock";
            }
            if ((BirthDate.Year) % 12 == 2)
            {
                chineeseYearOfBirth = "dog";

            }
            if ((BirthDate.Year) % 12 == 3)
            {
                chineeseYearOfBirth = "pig";
            }
            if ((BirthDate.Year) % 12 == 4)
            {
                chineeseYearOfBirth = "rat";
            }
            if ((BirthDate.Year) % 12 == 5)
            {
                chineeseYearOfBirth = "bull";
            }
            if ((BirthDate.Year) % 12 == 6)
            {
                chineeseYearOfBirth = "tiger";
            }
            if ((BirthDate.Year) % 12 == 7)
            {
                chineeseYearOfBirth = "rabbit";
            }
            if ((BirthDate.Year) % 12 == 8)
            {
                chineeseYearOfBirth = "dragon";
            }
            if ((BirthDate.Year) % 12 == 9)
            {
                chineeseYearOfBirth = "snake";
            }
            if ((BirthDate.Year) % 12 == 10)
            {
                chineeseYearOfBirth = "horse";
            }
            if ((BirthDate.Year) % 12 == 11)
            {
                chineeseYearOfBirth = "goat";
            }
            return " " + chineeseYearOfBirth;
        }
        private string WestYear(DateTime BirthDate)
        {

            string westSignOfBirth = null;
            if ((BirthDate.Day >= 22 && BirthDate.Month == 12) ||
                (BirthDate.Day <= 19 && BirthDate.Month == 1))
            {
                westSignOfBirth = "Capricorn";
            }
            if ((BirthDate.Day >= 20 && BirthDate.Month == 1) ||
               (BirthDate.Day <= 18 && BirthDate.Month == 2))
            {
                westSignOfBirth = "Aquarius";
            }
            if ((BirthDate.Day >= 19 && BirthDate.Month == 2) ||
            (BirthDate.Day <= 20 && BirthDate.Month == 3))
            {
                westSignOfBirth = "Fish";
            }
            if ((BirthDate.Day >= 21 && BirthDate.Month == 3) ||
          (BirthDate.Day <= 19 && BirthDate.Month == 4))
            {
                westSignOfBirth = "Aries";
            }
            if ((BirthDate.Day >= 20 && BirthDate.Month == 4) ||
        (BirthDate.Day <= 20 && BirthDate.Month == 5))
            {
                westSignOfBirth = "Taurus";
            }
            if ((BirthDate.Day >= 21 && BirthDate.Month == 5) ||
    (BirthDate.Day <= 20 && BirthDate.Month == 6))
            {
                westSignOfBirth = "Twins";
            }
            if ((BirthDate.Day >= 21 && BirthDate.Month == 6) ||
    (BirthDate.Day <= 22 && BirthDate.Month == 7))
            {
                westSignOfBirth = "Сancer";
            }
            if ((BirthDate.Day >= 23 && BirthDate.Month == 7) ||
    (BirthDate.Day <= 22 && BirthDate.Month == 8))
            {
                westSignOfBirth = "Lion";
            }
            if ((BirthDate.Day >= 23 && BirthDate.Month == 8) ||
    (BirthDate.Day <= 22 && BirthDate.Month == 9))
            {
                westSignOfBirth = "Virgo";
            }
            if ((BirthDate.Day >= 23 && BirthDate.Month == 9) ||
    (BirthDate.Day <= 22 && BirthDate.Month == 10))
            {
                westSignOfBirth = "Libra";
            }
            if ((BirthDate.Day >= 23 && BirthDate.Month == 10) ||
    (BirthDate.Day <= 21 && BirthDate.Month == 11))
            {
                westSignOfBirth = "Scorpion";
            }
            if ((BirthDate.Day >= 22 && BirthDate.Month == 11) ||
    (BirthDate.Day <= 21 && BirthDate.Month == 12))
            {
                westSignOfBirth = "Sagittarius";
            }
            return westSignOfBirth;
        }
        private bool IsBirthdayToday()
        {
            return BirthDate.Month == DateTime.Today.Month && BirthDate.Day == DateTime.Today.Day;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nEmail: {EMail}\nBirthday: {BirthDate.ToShortDateString()}\n" +
                   $"Is Adult: {IsAdult}\nIs Birthday: {IsBirthday}\nChinease Sign: {ChineaseSign}\nSun Sign: {SunSign}";
        }


    }
}
