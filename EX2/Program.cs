namespace Test_cours
{
    /// <summary>
    /// demo class.
    /// </summary>
    public class Program2
    {
        public static int is_leap_year_v1(int year)
        {
            return 2;
        }

        public static int is_leap_year_v2(int year)
        {
            int result = year % 400;
            if (result == 0)
            {
                return 0; // 0 is bisextile
            }
            else
            {
                return 1; // 1 is not bisextile
            }
        }

        public static int is_leap_year_v3(int year)
        {
            int result = year % 400; //100
            int result2 = year % 100; //0
            if (result == 0)
            {
                return 0; // 0 is bisextile
            }
            else
            {
                if (result2 == 0)
                {
                    return 1; // 1 is not bisextile
                }
                return 1; // 1 is not bisextile
            }
        }

        public static int is_leap_year_v4(int year)
        {
            int result = year % 400; //100
            int result2 = year % 100; //20
            int result3 = year % 4; //0

            if (result3 == 0 && result != 0)
            {
                return 0; // 0 is bisextile
            }
            else if (result == 0)
            {
                return 0; // 0 is bisextile
            }
            else
            {
                if (result2 == 0)
                {
                    return 1; // 1 is not bisextile
                }
                return 1; // 1 is not bisextile
            }
        }

        public static int is_leap_year_v5(int year)
        {
            int result = year % 400; //100
            int result2 = year % 100; //20
            int result3 = year % 4; //0

            if (result3 != 0)
            {
                return 1; // 1 is not bisextile
            }
            else if (result3 == 0 && result != 0)
            {
                return 0; // 0 is bisextile
            }
            else if (result == 0)
            {
                return 0; // 0 is bisextile
            }
            else
            {
                if (result2 == 0)
                {
                    return 1; // 1 is not bisextile
                }
                return 1; // 1 is not bisextile
            }
        }
    }
}