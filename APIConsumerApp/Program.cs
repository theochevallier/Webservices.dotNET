using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using APIWebServices.Model;

namespace APIConsumerApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await getUser(2);
            await getAllUsers();
        }

        public static async Task getUser(int id){
            string url = "http://localhost:5075/api/users/" + id;

            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if(response.IsSuccessStatusCode){
                    string responseString = await response.Content.ReadAsStringAsync();
                    User? user = JsonConvert.DeserializeObject<User>(responseString);

                    Console.WriteLine(user?.toString());
                } else {
                    Console.WriteLine("Error fetching API Data : " + response.StatusCode);
                }
            }
        }

        public static async Task getAllUsers(){
            string url = "http://localhost:5075/api/users/getAllUsers";

            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                if(response.IsSuccessStatusCode){
                    string responseString = await response.Content.ReadAsStringAsync();
                    User[]? users = JsonConvert.DeserializeObject<User[]>(responseString);
                    if(users != null){
                        foreach(User user in users){
                            Console.WriteLine(user.toString());
                        }
                    }
                } else {
                    Console.WriteLine("Error fetching API Data : " + response.StatusCode);
                }
            }
        }
    }
}