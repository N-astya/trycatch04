namespace trycatch04
{
    internal class Program
    {
        public static bool PasswordCheck(string login, string password, string confirmPassword)
        {
            try
            {
                string correct = "";
                string symbols = "V3_wh_nyCTW12K_gfesvI641Ckeoi";
                if (login.Length >= 20)
                {
                    throw new WrongLoginException("Логин: больше 20 символов");
                }
                if (password.Length >= 20)
                {
                    throw new WrongPassowrdException("Пароль: больше 20 символов");
                }
                foreach (char a in login)
                {
                    foreach (char b in symbols)
                    {
                        if (a == b)
                        {
                            correct += a;
                        }
                    }
                }
                if (correct != login)
                {
                    throw new WrongLoginException("Логин неправильный");
                }
                correct = "";
                foreach (char a in password)
                {
                    foreach (char b in symbols)
                    {
                        if (a == b)
                        {
                            correct += a;
                        }
                    }
                }
                if (correct != password)
                {
                    throw new WrongPassowrdException("Пароль неправильный");
                }
                if (password != confirmPassword)
                {
                    throw new WrongPassowrdException("Подтверждение пароля отличается от пароля");
                }
            }
            catch (WrongLoginException x)
            {
                return false;
            }
            catch (WrongPassowrdException x)
            {
                return false;
            }
            return true;
        }
        public class WrongLoginException : Exception
        {
            public WrongLoginException()
            {

            }
            public WrongLoginException(string message) : base(message)
            {

            }
        }
        public class WrongPassowrdException : Exception
        {
            public WrongPassowrdException()
            {

            }
            public WrongPassowrdException(string message) : base(message)
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PasswordCheck("Xpdsy", "12345", "12345"));
        }

    }
}
