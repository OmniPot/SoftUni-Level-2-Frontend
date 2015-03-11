namespace MultimediaShopSystem
{
    using System;
    using MultimediaShopSystem.CoreLogic;
    using MultimediaShopSystem.Exceptions;

    public class Test
    {
        public static void Main()
        {           
            Engine e = new Engine();
            try
            {
                e.Run();
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore.Message);
            }
            catch (InsufficientSuppliesException ise)
            {
                Console.WriteLine(ise.Message);
            }
        }
    }
}
