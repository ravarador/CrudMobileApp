using CrudMobileApp.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudMobileApp.Helpers
{
    public class FirebaseHelper
    {
        FirebaseClient client;

        public FirebaseHelper()
        {
            client = new FirebaseClient("https://xamarinfire-2d37a-default-rtdb.firebaseio.com/");
        }
        
        public async Task AddPerson(int personId, string name)
        {
            await client
              .Child("Persons")
              .PostAsync(new Person() { PersonId = personId, Name = name });
        }

  
    }
}

