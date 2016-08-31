using System;

namespace Basis
{
    class ExceptionBasics
    {
        static void Main(string[] args)
        {
            ArgumentNullException argumentNullException = new ArgumentNullException("ArgumentNullException");
            FormatException formatException = new FormatException("FormatException");
            Exception exception = new Exception("Exception");
            Exception complexException = new Exception("Complex Exception", argumentNullException);

            ExceptionTest1_ExceptionCases(argumentNullException);
            ExceptionTest1_ExceptionCases(formatException);
            ExceptionTest1_ExceptionCases(exception);
            
            Console.WriteLine("ExceptionTest2_ThrowVsThrowEx - Throw:");
            try
            {
                ExceptionTest2_ThrowVsThrowEx(complexException, false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException != null ? ex.InnerException.Message : "InnerException = null");
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("ExceptionTest2_ThrowVsThrowEx - Throw ex:");
            try
            {
                ExceptionTest2_ThrowVsThrowEx(complexException, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException != null ? ex.InnerException.Message : "InnerException = null");
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Przechwytywanie wyjątków od najmniej ogólnych do najbardziej ogólnych
        /// </summary>
        /// <param name="exception"></param>
        public static void ExceptionTest1_ExceptionCases(Exception exception)
        {
            try
            {
                throw exception;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException catched");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException catched");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception catched");
            }
        }

        /// <summary>
        /// Różnica w przerzuceniu złapanego wyjątku z użyciem złapanego wyjątku oraz bez użycia złapanego wyjątku
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="rethrowWithParameter"></param>
        public static void ExceptionTest2_ThrowVsThrowEx(Exception exception, bool rethrowWithParameter)
        {
            if (rethrowWithParameter)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else {
                try
                {
                    throw exception;
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
