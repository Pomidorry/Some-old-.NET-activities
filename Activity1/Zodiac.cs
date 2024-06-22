namespace CSharp.Activity.Profile
{
    /// <summary>
    ///	Definition of Zodiac sign class.
    /// </summary>
    public class Zodiac
    {
        // Static instances of zodiacs signs
        public static Zodiac ARIES = new(3, 21, 4, 19, "Aries");
        public static Zodiac TAURUS = new(4, 20, 5, 20, "Taurus");
        public static Zodiac GEMINI = new(5, 21, 6, 20, "Gemini");
        public static Zodiac CANCER = new(6, 21, 7, 22, "Cancer");
        public static Zodiac LEO = new(7, 23, 8, 22, "Leo");
        public static Zodiac VIRGO = new(8, 23, 9, 22, "Virgo");
        public static Zodiac LIBRA = new(9, 23, 10, 22, "Libra");
        public static Zodiac SCORPIO = new(10, 23, 11, 21, "Scorpio");
        public static Zodiac SAGITTARIUS = new(11, 22, 12, 21, "Sagittarius");
        public static Zodiac CAPRICORN = new(12, 22, 1, 19, "Capricorn");
        public static Zodiac AQUARIUS = new(1, 20, 2, 18, "Aquarius");
        public static Zodiac PISCES = new(2, 19, 3, 20, "Pisces");

        /// <summary>
        /// Property to return the Start Date
        /// </summary>
        public int StartDate { get; private set; }

        /// <summary>
        /// Property to return the End Date
        /// </summary>
        public int EndDate { get; private set; }

        /// <summary>
        /// Property to return the Start Month
        /// </summary>
        public int StartMonth { get; private set; }

        /// <summary>
        /// Property to return the End Month
        /// </summary>
        public int EndMonth { get; private set; }

        /// <summary>
        /// Property to return the zodiac Star Sign name
        /// </summary>
        public string StarSign { get; private set; }

        /// <summary>
        /// Constructor to initialize the zodiac objects.
        /// </summary>
        /// <param name="startMonth">start month</param>
        /// <param name="startDate">start date</param>
        /// <param name="endMonth">end month</param>
        /// <param name="endDate">end date</param>
        /// <param name="starSign">zodiac star sign</param>
        private Zodiac(int startMonth, int startDate, int endMonth, int endDate, string starSign)
        {
            this.StartMonth = startMonth;
            this.StartDate = startDate;
            this.EndMonth = endMonth;
            this.EndDate = endDate;
            this.StarSign = starSign;
        }

        /// <summary>
        /// Method to accept the birth date and return the corresponding Zodiac sign
        /// </summary>
        /// <param name="birthDate">Birth Date</param>
        /// <returns></returns>
        public static Zodiac GetZodiacSign(DateTime birthDate)
        {
            #region Activity 1.1
            // TODO: Given the birth date, return the corresponding
            // zodiac sign or null if the date does not have a corresponding zodiac sign.
            // Refer to the constants above for the zodiac sign values.
            // You may declare additional local variables if necessary to accomplish this activity.
            // HINT: Make use of the 'return' keyword

            int month = birthDate.Month;  // month of birth
            int day = birthDate.Day;      // date of birth
            Zodiac zodiacSign = null;
            if ((month == AQUARIUS.StartMonth && day >= AQUARIUS.StartDate) || (month == AQUARIUS.EndMonth && day <= AQUARIUS.EndDate))
                zodiacSign = Zodiac.AQUARIUS;
            else if ((month == PISCES.StartMonth && day >= PISCES.StartDate) || (month == PISCES.EndMonth && day <= PISCES.EndDate))
                zodiacSign = Zodiac.PISCES;
            else if ((month == ARIES.StartMonth && day >= ARIES.StartDate) || (month == ARIES.EndMonth && day <= ARIES.EndDate))
                zodiacSign = Zodiac.ARIES;
            else if ((month == TAURUS.StartMonth && day >= TAURUS.StartDate) || (month == TAURUS.EndMonth && day <= TAURUS.EndDate))
                zodiacSign = Zodiac.TAURUS;
            else if ((month == GEMINI.StartMonth && day >= GEMINI.StartDate) || (month == GEMINI.EndMonth && day <= GEMINI.EndDate))
                zodiacSign = Zodiac.GEMINI;
            else if ((month == CANCER.StartMonth && day >= CANCER.StartDate) || (month == CANCER.EndMonth && day <= CANCER.EndDate))
                zodiacSign = Zodiac.CANCER;
            else if ((month == LEO.StartMonth && day >= LEO.StartDate) || (month == LEO.EndMonth && day <= LEO.EndDate))
                zodiacSign = Zodiac.LEO;
            else if ((month == VIRGO.StartMonth && day >= VIRGO.StartDate) || (month == VIRGO.EndMonth && day <= VIRGO.EndDate))
                zodiacSign = Zodiac.VIRGO;
            else if ((month == LIBRA.StartMonth && day >= LIBRA.StartDate) || (month == LIBRA.EndMonth && day <= LIBRA.EndDate))
                zodiacSign = Zodiac.LIBRA;
            else if ((month == SCORPIO.StartMonth && day >= SCORPIO.StartDate) || (month == SCORPIO.EndMonth && day <= SCORPIO.EndDate))
                zodiacSign = Zodiac.SCORPIO;
            else if ((month == SAGITTARIUS.StartMonth && day >= SAGITTARIUS.StartDate) || (month == SAGITTARIUS.EndMonth && day <= SAGITTARIUS.EndDate))
                zodiacSign = Zodiac.SAGITTARIUS;
            else if ((month == CAPRICORN.StartMonth && day >= CAPRICORN.StartDate) || (month == CAPRICORN.EndMonth && day <= CAPRICORN.EndDate))
                zodiacSign = Zodiac.CAPRICORN;
            // Add any other zodiac signs or adjust the existing ones based on your region/culture.


            #endregion

            return zodiacSign; // default behaviour
        }
    }
}