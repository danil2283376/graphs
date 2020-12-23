using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static Hashtable hashtable = new Hashtable();
        public static Hashtable provenFriend = new Hashtable();


        public static Queue queueFriend = new Queue();

        public static void InputFriend(string key, List<string> friendsValue)
        {
            hashtable.Add(key, friendsValue);
        }

        static void Main(string[] args)
        {
            List<string> myFriend = new List<string>() { "alice", "bob", "claire" };
            InputFriend("you", myFriend);

            List<string> bobFriend = new List<string>() { "anuj", "peggy" };
            InputFriend("bob", bobFriend);

            List<string> aliceFriend = new List<string>() { "peggy" };
            InputFriend("alice", aliceFriend);

            List<string> claireFriend = new List<string>() { "thom", "jonny" };
            InputFriend("claire", claireFriend);

            List<string> anujFriend = new List<string>() { "you" };
            InputFriend("anuj", anujFriend);

            List<string> peggyFriend = new List<string>() { "you" };
            InputFriend("peggy", peggyFriend);

            List<string> thomFriend = new List<string>();
            InputFriend("thom", thomFriend);

            List<string> jonnyFriend = new List<string>();
            InputFriend("jonny", jonnyFriend);

            List<string> friend = hashtable["you"] as List<string>;
            AddFriendInQueue(friend); // добавил своих друзей для проверки есть ли продавец

            string sellerMango = "Нету продавца в друзьях";

            while (queueFriend.Count > 0)
            {
                string str = queueFriend.Dequeue() as string;
                //Console.WriteLine(str);
                char[] arraySymbol = str.ToCharArray();

                if (arraySymbol[0] == 'j')
                {
                    sellerMango = str;
                    break;
                }
                else
                {
                    friend = hashtable[str] as List<string>;
                    AddFriendInQueue(friend);
                }
            }

            // узнаю уже проверенных людей
            foreach (DictionaryEntry de in provenFriend) 
            {
                Console.WriteLine("Провереные люди: " + de.Key);
            }

            Console.WriteLine(sellerMango);

            Console.ReadKey();
        }

        // добавить друзей в очередь
        public static void AddFriendInQueue(List<string> friend) 
        {
            for (int i = 0; i < friend.Count; i++)
            {
                // проверяю не повторяется ли человек в списке
                if (!provenFriend.ContainsKey(friend[i]))
                {
                    provenFriend.Add(friend[i], null);
                    queueFriend.Enqueue(friend[i]);
                }
                else 
                {
                    Console.WriteLine("{0} уже был проверен", friend[i]);
                }
            }
        }
    }
}
