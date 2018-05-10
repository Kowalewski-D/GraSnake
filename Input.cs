using System.Collections;
using System.Windows.Forms;

namespace Snake
{
    internal class Input
    {
        //Importuje liste dostepnych przycisków na klawiaturze
        private static Hashtable keyTable = new Hashtable();

        //Sprawdzanie czy prawidłowy przycisk został nacisniety.
        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool) keyTable[key];
        }

        //Wykrywanie nacisnietego przcisku na klawiaturze
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
