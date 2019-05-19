using System;
using System.Collections.Generic;
using System.Linq;
using Application.Entities;
using Application.Repositories;
using ChillMapWeb.Entities;
using ChillMapWeb.Repositories;
using ChillMapWeb.Repository;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Application.API
{
    public class Application
    {
        private readonly EventRepository eventRep;
        private readonly DistrictRepository districtRep;
        private readonly PlaceRepository placeRep;

        public Application(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("HackathonDb"));
            var database = client.GetDatabase("HackathonDb");

            eventRep = new EventRepository(database);
            districtRep = new DistrictRepository(database);
            placeRep = new PlaceRepository(database);
        }

        public District GetDistrict(Guid districtId) => districtRep.GetById(districtId);

        public Place GetPlace(Guid placeId) => placeRep.GetById(placeId);

        public Event GetEvent(Guid eventId)
        {
            return eventRep.GetById(eventId);
        }

        public List<Event> GetEvents() => eventRep.Get();

        public void Fill()
        {
            var names = new List<string>
            {
                "Концерт Егора Крида. 16+",
                "Хакатон 2019",
                "ДММ Концерт",
                "День открытых дверей в колледж имени Ползунова",
                "Митинг в поддержку Сергея Зверева",
                "Вечеринка у Скриптонита",
                "Дегустация чешского пива",
                "Парад воздушных шаров",
                "Акция \"Зелёная планета\"",
                "Распродажа коллекции летней румынской обуви. Сезон 2016"
            };
            var descriptions = new List<string>
            {
                "Приезжает лучший певец современности",
                "Обязательно для посещения. Там кормят :)",
                "Нету места лучше в мире, чем Тургенева 4. Пиво, в...",
                "Успех обеспечен",
                "За мужика!",
                "МЫныынвынлилыы",
                "Из Рязани",
                "Разноцветные",
                "Вырубаем деревья",
                "Дешово, беры"
            };
            var events = Enumerable
                .Range(0, 10)
                .Select(i => new Event()
                {
                    Name = $"{names[i]}", Description = $"{descriptions[i]}", Date = DateTime.Now
                })
                .ToList();
            foreach (var event_ in events)
            {
                eventRep.Create(event_);
            }

            var addreses = new List<string>
            {
                "Мичурина, 28",
                "Ленина, 54",
                "Мира, 8",
                "Бажова, 17",
                "Ватутина, 5",
            };
            var placeNames = new List<string>()
            {
                "Дом культуры им. Сергея Зайцева",
                "Консульство им. Ратбек Нурланова",
                "Дом ветеранов им. маршала-генералисимуса Василия Пахомова",
                "Центр современного искусства им. Леры Усольцевой",
                "Штаб-квартира организаций ChillHack им. Полины Дубровиной"
            };
            var paths = new List<string>
            {
                "https://b1.culture.ru/c/792421.jpg",
                "http://dalniestrany.ru/images/stories/Countries/SNG/Kirgiziya/%D0%9F%D0%BE%D1%81%D0%BE%D0%BB%D1%8C%D1%81%D1%82%D0%B2%D0%BE%20%D0%9A%D0%B8%D1%80%D0%B3%D0%B8%D0%B7%D0%B8%D0%B8%20%D0%B2%20%D0%9C%D0%BE%D1%81%D0%BA%D0%B2%D0%B5%20(%D1%83%D0%BB.%20%D0%91%D0%BE%D0%BB%D1%8C%D1%88%D0%B0%D1%8F%20%D0%9E%D1%80%D0%B4%D1%8B%D0%BD%D0%BA%D0%B0,%20%D0%B4.64).jpg",
                "https://360tv.ru/media/article_media/20141203/b2b37cd7.jpg",
                "http://www.historie.ru/uploads/posts/2066/galisiyskiy-centr-sovremennogo-iskusstva-foto-opisanie-centro-galego-de-arte-contemporanea-132847.jpg",
                "https://4.bp.blogspot.com/-xWpCvIFcXwE/XAtum6tuq-I/AAAAAAAAtbM/PwzWA3Eqfpkd8Cl3GapQ1wITv9lXaJ0agCLcBGAs/s1600/Avengers-Endgame-10.jpg"
            };
            var places = Enumerable
                .Range(0, 5)
                .Select(i => new Place()
                {
                    Name = placeNames[i],
                    Address = addreses[i],
                    Description = "",
                    Events = new List<Event>() { events[i], events[i + 5] },
                    Id = Guid.NewGuid(),
                    Path = paths[i]
                }).ToList();
            foreach (var place in places)
            {
                placeRep.Create(place);
            }

            districtRep.Create(new District(new Guid(), places, "Центр"));
        }
    }
}