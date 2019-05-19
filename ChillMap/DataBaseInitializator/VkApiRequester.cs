using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Newtonsoft.Json;

namespace ASP.NETCoreWebApplication
{
    public class VkApiRequester
    {
        public static IEnumerable<Item> GetAllEvents(string url)
        {
            var request = (HttpWebRequest) WebRequest.Create(url);
            var response = (HttpWebResponse) request.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                return ParseJson(reader.ReadToEnd());
            }
        }

        private static IEnumerable<Item> ParseJson(string json)
        {
            //Console.WriteLine(json);
            var values = JsonConvert.DeserializeObject<Wtf>(json);
            return values.Response.Items;
        }

        private static IEnumerable<Item> ParseJson2(string json)
        {
            Console.WriteLine(json);
            var values = JsonConvert.DeserializeObject<ResponseGovna>(json);
            return values.Response;
        }

        public static IEnumerable<Item> GetEventsDetails(string url)
        {
            var request = (HttpWebRequest) WebRequest.Create(url);
            var response = (HttpWebResponse) request.GetResponse();

            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = ParseJson2(reader.ReadToEnd());
                foreach (var item in result)
                {
                    Console.WriteLine(item.Place);
                    Console.WriteLine(item.Name);
                }

                return result;
            }
        }
    }

    class ResponseGovna
    {
        public List<Item> Response;
    }

    class Wtf
    {
        public Response Response;
    }

    class Response
    {
        public int Count;
        public List<Item> Items;
    }

    public class Item
    {
        public string Name;
        public int Id;
        public string Description;
        public int FinishDate;
        public Place Place;

        public override string ToString()
        {
            return $"NAME: {Name}\n{string.Join("", Description.Split('\n').Select(l => $"\t{l}\n").ToArray())}";
        }
    }

    public class Place
    {
        public int Id;
        public string Title;
//        public int Latitude;
//        public int Longitude;
        public string Address;
    }
}