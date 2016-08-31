using System;
using System.Collections;

namespace CSharpKnowledgeBaseAndTests
{
    class HashtableTests
    {
        static void Main(string[] args)
        {
            HashtableTests1_Init();
            HashtableTests2_Indexer();
            HashtableTests3_ContainsKey();
            HashtableTests4_ValuesAndKeys();
            HashtableTests5_Remove();
            
            Console.ReadLine();
        }

        /// <summary>
        /// Dodanie kolejnej pary klucz-wartość do kolekcji w której istnieje już zadany klucz
        /// </summary>
        static void HashtableTests1_Init()
        {
            Console.WriteLine("HashtableTests1_Init():");

            Hashtable hashTable = new Hashtable();

            Console.WriteLine("Dodanie pary: \"key1\", \"value1\"");
            hashTable.Add("key1", "value1");
            Console.WriteLine("Dodanie pary: \"key2\", \"value2\"");
            hashTable.Add("key2", "value2");
            Console.WriteLine("Dodanie pary: \"key3\", \"value3\"");
            hashTable.Add("key3", "value3");
            Console.WriteLine("Dodanie pary: \"key4\", \"value4\"");
            hashTable.Add("key4", "value4");

            string newKey = "key1";
            string newValue = "value1";

            // Próba dodania kolejnego elementu do kolekcji w której znajduje się już para posiadające taki sam klucz
            try
            {
                Console.WriteLine("Próba ponowengo dodania pary: \"key1\", \"value1\"");
                hashTable.Add(newKey, newValue);
            }
            catch
            {
                Console.WriteLine("Element o kluczu = {0} znajduje się już w kolekcji.", newKey);
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        /// <summary>
        /// Dodawanie nowych par i zmienianie wartości poprzez metodę indeksera this[object obj]
        /// </summary>
        static void HashtableTests2_Indexer()
        {
            Console.WriteLine("HashtableTests2_Indexer():");

            Hashtable hashTable = new Hashtable();

            Console.WriteLine("Dodanie pary: \"key1\", \"value1\"");
            hashTable.Add("key1", "value1");
            Console.WriteLine("Dodanie pary: \"key2\", \"value2\"");
            hashTable.Add("key2", "value2");
            Console.WriteLine("Dodanie pary: \"key3\", \"value3\"");
            hashTable.Add("key3", "value3");

            Console.WriteLine("klucz = {0}, wartość = {1}.", "key3", hashTable["key3"]);

            // Pomiana wartości dla istniejącego klucza
            hashTable["key3"] = "value3";
            Console.WriteLine("klucz = {0}, wartość = {1}.", "key3", hashTable["key3"]);

            // Dodanie nowej pary klucz-wartość 
            hashTable["key4"] = "value4";
            Console.WriteLine("klucz = {0}, wartość = {1}.", "key4", hashTable["key4"]);

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        /// <summary>
        /// Metoda sprawdzenia czy zadany klucz już się znajduje w kolekcji
        /// </summary>
        public static void HashtableTests3_ContainsKey()
        {
            Console.WriteLine("HashtableTests3_ContainsKey():");

            Hashtable hashTable = new Hashtable();

            Console.WriteLine("Dodanie pary: \"key1\", \"value1\"");
            hashTable.Add("key1", "value1");
            Console.WriteLine("Dodanie pary: \"key2\", \"value2\"");
            hashTable.Add("key2", "value2");
            Console.WriteLine("Dodanie pary: \"key3\", \"value3\"");
            hashTable.Add("key3", "value3");

            // Sprawdzenie czy klucz znajduje się w kolekcji
            Console.WriteLine("Sprawdzenie czy klucz znajduje się w kolekcji");
            if (!hashTable.ContainsKey("key4"))
            {
                hashTable.Add("key4", "value4");
                Console.WriteLine("klucz = {0}, wartość = {1}.", "key4", hashTable["key4"]);
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        /// <summary>
        /// Wyciągnięcie z Hashtable wszystkich kluczy i wszystkich wartości
        /// </summary>
        static void HashtableTests4_ValuesAndKeys()
        {
            Console.WriteLine("HashtableTests4_ValuesAndKeys():");

            Hashtable hashTable = new Hashtable();

            Console.WriteLine("Dodanie pary: \"key1\", \"value1\"");
            hashTable.Add("key1", "value1");
            Console.WriteLine("Dodanie pary: \"key2\", \"value2\"");
            hashTable.Add("key2", "value2");
            Console.WriteLine("Dodanie pary: \"key3\", \"value3\"");
            hashTable.Add("key3", "value3");
            Console.WriteLine("Dodanie pary: \"key4\", \"value4\"");
            hashTable.Add("key4", "value4");
            
            Console.WriteLine("Wartości w kolekcji: ");
            ICollection valueCollection = hashTable.Values;

            foreach (string value in valueCollection)
            {
                Console.WriteLine("wartość = {0}", value);
            }

            Console.WriteLine("Klucze w kolekcji: ");
            ICollection keyCollection = hashTable.Keys;

            foreach (string key in keyCollection)
            {
                Console.WriteLine("klucz = {0}", key);
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        /// <summary>
        /// Usuwanie par klucz-wartość z kolekcji
        /// </summary>
        public static void HashtableTests5_Remove()
        {
            Console.WriteLine("HashtableTests5_Remove():");

            Hashtable hashTable = new Hashtable();

            Console.WriteLine("Dodanie pary: \"key1\", \"value1\"");
            hashTable.Add("key1", "value1");
            Console.WriteLine("Dodanie pary: \"key2\", \"value2\"");
            hashTable.Add("key2", "value2");
            Console.WriteLine("Dodanie pary: \"key3\", \"value3\"");
            hashTable.Add("key3", "value3");
            Console.WriteLine("Dodanie pary: \"key4\", \"value4\"");
            hashTable.Add("key4", "value4");

            Console.WriteLine("Kolekcja startowa:");
            foreach (DictionaryEntry pair in hashTable)
            {
                Console.WriteLine("klucz = {0}, wartość = {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("Kolekcja po usunięciu pary o kluczu \"key3\":");
            hashTable.Remove("key3");

            foreach (DictionaryEntry pair in hashTable)
            {
                Console.WriteLine("klucz = {0}, wartość = {1}", pair.Key, pair.Value);
            }

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

    }
}
