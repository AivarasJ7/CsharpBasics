
using System;
using static System.Net.Mime.MediaTypeNames;

namespace shoppingCartExample
{
    public class ShoppingCart
    {
        // Užduoties komentaruose, parašykite punktais paaiškinimą kaip jūsų metodas veikia.
        // Pradėkite nuo testo.
        // Sukurkite metodą, kuris į prekių krepšelį įdeda nurodytas prekes.Prekę sudaro kodas ir pavadinimas.
        //Sukurkite metodą, kuris prekių krepšelyje patikrina ar prekė yra pagal kodą.
        // Sukurkite metodą, kuris patikrina pašaliną prekę iš prekių krepšelio.

        /// <summary>
        /// 1. Patikrinti ar prekiu krepselyje nera tokios prekes
        /// 1.1 Jeigu tokia preke jau yra su tokiu kodu tada graziname false
        /// 1.2 Jeigu tokios prekes nera tada pridedame preke ir graziname true
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="code"></param>
        /// <param name="item"></param>
        /// <returns></returns>

        public static bool AddItem(
            Dictionary<string, string> shoppingCart,
            string code,
            string item)
        {
            if(shoppingCart.ContainsKey(code)) 
            {
                return false;
            }

            shoppingCart.Add(code, item);

            return true;
        }

        /// <summary>
        /// 1. Patikriname ar preke egzsistuoja pagal koda.
        /// 1.2 Jeigu egzistuoja graziname true
        /// 1.3 Jeigu neegzistuoja graziname false
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="code"></param>
        /// <returns></returns>
       
        public static bool DoesItemByCodeExist(
            Dictionary<string, string> shoppingCart, 
            string code)
        {
            if(code is null)
            {
                return false;
            }
            
            return shoppingCart.ContainsKey(code);
        }

        /// <summary>
        /// 1. Patikrinam ar preke yra krepselyje
        /// 1.1. Jeigu preke yra ja pasaliname ir graziname true
        /// 1.2 Jeigu prekes nera graziname false
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="code"></param>
        /// <returns></returns>
       
        public static bool RemoveItem(
            Dictionary<string, string> shoppingCart, 
            string code)
        {
            if (shoppingCart.ContainsKey(code))
            {
                return shoppingCart.Remove(code);
            }

            return false;
        }
    }
}