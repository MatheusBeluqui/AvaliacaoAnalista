using System;
using System.Collections.Generic;

namespace Teste2
{
    /*
      * TODO
      * Implementar CanBeConnect para identificar se o Friend A pode se Conectar com o Friend C. Para isso, é necessário ter um friend em comum.
         - Caso sim, o método deverá retornar True
         - Caso não, o método deverá retornar False
      */
    class Friend
    {
        public string Email { get; private set; }

        public ICollection<Friend> Friends { get; private set; }

        public Friend(string email)
        {
            this.Email = email;
            this.Friends = new List<Friend>();
        }

        public void AddFriendship(Friend friend)
        {
            this.Friends.Add(friend);
        }

        public bool CanBeConnect(Friend friendC)
        {
            foreach (Friend friend in this.Friends)
            {
                if (friendC.Friends.Contains(friend)) return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Friend friendA = new Friend("friendA@gmail.com");
            Friend friendB = new Friend("friendB@gmail.com");
            Friend friendC = new Friend("friendC@gmail.com");
            Friend friendD = new Friend("friendD@gmail.com");

            friendA.AddFriendship(friendB);
            friendC.AddFriendship(friendB);

            Console.WriteLine(friendA.CanBeConnect(friendC));
            Console.WriteLine(friendD.CanBeConnect(friendC));
        }
    }
}
