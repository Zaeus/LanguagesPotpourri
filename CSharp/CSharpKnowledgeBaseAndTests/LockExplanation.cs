using System.Threading;

namespace CSharpKnowledgeBaseAndTests
{
    /// <summary>
    /// Ekwiwalent kodu na który tłumaczona jest instrukcja lock w C#3.0 i C#4.0
    /// </summary>
    class LockExplanation
    {
        private static readonly object obj = new object();

        public void DoSomeThreadUnsafeWorkOnObj() { }

        static void Main (string[] args)
        {
            LockExplanation lockExplanation = new LockExplanation();

            lock (obj)
            {
                // Operacja bezpieczna, na zablokowanej zmiennej
                lockExplanation.DoSomeThreadUnsafeWorkOnObj();
            }

            #region C# 3.0 - To samo co:
            var temp = obj;

            Monitor.Enter(temp);

            try
            {
                // Operacja bezpieczna, na zablokowanej zmiennej
                lockExplanation.DoSomeThreadUnsafeWorkOnObj();
            }
            finally
            {
                Monitor.Exit(temp);
            }
            #endregion

            #region C# 4.0 - To samo co:
            bool lockWasTaken = false;
            var temp2 = obj;

            try
            {
                Monitor.Enter(temp2, ref lockWasTaken);
                // Operacja bezpieczna, na zablokowanej zmiennej
                lockExplanation.DoSomeThreadUnsafeWorkOnObj();
            }
            finally
            {
                if (lockWasTaken)
                {
                    Monitor.Exit(temp2);
                }
            }
            #endregion
        }
    }
}
