using System;

namespace Karātavas
{
    public class Game
    {
        // saraksts ar vārdiem
        string[] words = { "ola, muca, usb, kartupelis, snus" };
        // izvēlētais vards kas lietotajam ir jatmin
        char[] word;
        // burti, kurus lietotaks ir atminejis
        public char[] userInput;

        public void Start()
        {
            //1. ar random izvēlas 1 vārdu no saraksta'words'
            int pozicija = new Random().Next(0, words.Length);
            string randomword = words[pozicija];

            //2.aizpilda masīvu 'word' ar izvēlētā vārda burtiem
            word = new char[randomword.Length];
            for(int i = 0; i < word.Length; i++)
            {
                word[i] = randomword[i];
            }
            //3. Aizpilda masīvu ar'userinput' ar tik'_', cik vārdā burti
            userInput = new char[randomword.Length];
            for (int i = 0; i < userInput.Length; i++)
            {
                userInput[i] = '_';
            }
        }
        public bool IsOver()
        {
            //1 Ja 'userinput' satur kādu '_'tad atgriež FALSE, citādi TRUE
            // return !userInput.Contains('_');         īsais variants
            bool isFound = false;
            foreach(char c in userInput)
            {
                if (c == '_')
                {
                    isFound = true;
                    break;
                }
            }
            return !isFound;
            // return isFound ? false : true;
        }
        public bool Guess(char letter)
        {
            bool isFound = false;
            //1. ar ciklu atrod pozīcijas kur masīvā 'word' atrodas burts'letter'
            for(int i = 0; i < word.Length; i++)
            {
                //1.1 Tajās pašās pozīcijas masīvā 'userInput' ievieto burtu 'letter'
                if(Char.ToLower(word[i]) == Char.ToLower(letter)
                {
                    // aizstāj '_' ar burtu
                    userInput[i] = letter;

                    //1.2 Atgriež TRUE
                    isFound = true;
                }
            }
            //2. Ja burts netika atrasts tad atgriež FALSE
            return isFound;
        }

    }
}
