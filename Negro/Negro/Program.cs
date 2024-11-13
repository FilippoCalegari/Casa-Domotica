using System;
using System.Runtime.InteropServices;

namespace ApriLettoreCD
{
    class Program
    {
        // Importiamo la funzione mciSendString dalla libreria winmm.dll
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string command, string returnValue, int returnLength, IntPtr winHandle);

        static void Main(string[] args)
        {
            // Comando per aprire il lettore CD/DVD
            ApriLettoreCD();

            Console.WriteLine("Il lettore CD/DVD è stato aperto.");
            Console.ReadLine();
        }

        static void ApriLettoreCD()
        {
            // Usa il comando "set cdaudio door open" per aprire il lettore CD/DVD
            mciSendString("set cdaudio door open", null, 0, IntPtr.Zero);
        }

        static void ChiudiLettoreCD()
        {
            // Usa il comando "set cdaudio door closed" per chiudere il lettore CD/DVD
            mciSendString("set cdaudio door closed", null, 0, IntPtr.Zero);
        }
    }
}
