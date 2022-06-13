﻿using Backend.Models.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class SeedModel
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DatabaseContext(serviceProvider.GetRequiredService<DbContextOptions<DatabaseContext>>()))
            {
                // Look for any movies.
                if (context.Country.Any())
                {
                    return;   // DB has been seeded
                }

                var Spain = new Country("Spain");
                var France = new Country("France");
                var Italy = new Country("Italy");
                var Portugal = new Country("Portugal");
                var Poland = new Country("Poland");
                var Germany = new Country("Germany");
                var Austria = new Country("Austria");
                var Belgium = new Country("Belgium");
                var Turkey = new Country("Turkey");
                var England = new Country("England");
                var Ireland = new Country("Ireland");

                var Countries = new List<Country>()
                {
<<<<<<< HEAD
                    Spain, France, Italy, Portugal, Germany, Poland, Austria, Belgium, Turkey,  England, Ireland
=======
<<<<<<< HEAD
                    Spain, France, Italy, Portugal, Germany, Poland, Austria, Belgium, Turkey,  England, Ireland  
=======
                    Spain, France, Italy, Portugal, Germany, Poland, Austria, Belgium, Turkey, England, Ireland  
>>>>>>> 0a7a7324b22f6bc35adea95e3a1dba042d2ae9ab
>>>>>>> a58abe99516650f500b9b364bb306d3811dea156
                };

                var Cities = new List<City>()
                {
                    new City("Barcelona", Spain),
                    new City("Valencia", Spain),
                    new City("Madryt", Spain),
                    new City("Bilbao", Spain),
                    new City("Malaga", Spain),
                    new City("Cracow", Poland),
                    new City("Warsaw", Poland),
<<<<<<< HEAD
                    new City("Sopot", Poland),
                    new City("Milan", Italy ),
                    new City("Rome", Italy ),
                    new City("Venice", Italy),
=======
                    new City("Gdansk", Poland),
                    new City("Kielce", Poland),
                    new City("Sopot", Poland),
                    new City("Milan", Italy ),
                    new City("Rome", Italy ),
                    new City("Palermo", Italy ),
                    new City("Piza", Italy ),
                    new City("Venice", Italy),
                    new City("Coimbra", Portugal),
>>>>>>> a58abe99516650f500b9b364bb306d3811dea156
                    new City("Aveiro", Portugal),
                    new City("Porto", Portugal),
                    new City("Lisboa", Portugal),
                    new City("Paris", France),
                    new City("Lyon", France),
                    new City("Nicea", France),
<<<<<<< HEAD
                    new City("Berlin", Germany),
                    new City("Munich", Germany),
=======
                    new City("Lille", France),
                    new City("Nantes", France),
                    new City("Berlin", Germany),
                    new City("Munich", Germany),
                    new City("Bonn", Germany),
                    new City("Frankfurt", Germany),
>>>>>>> a58abe99516650f500b9b364bb306d3811dea156
                    new City("Hambur", Germany),
                    new City("Vienna", Austria),
                    new City("Graz", Austria),
                    new City("Salzburg", Austria),
<<<<<<< HEAD
                    new City("Antwerp", Belgium),
                    new City("Ghent", Belgium),
                    new City("Antalya", Turkey),
                    new City("Istanbul", Turkey),
                    new City("Ankara", Turkey),
                    new City("London", England),
                    new City("Nottingham", England),
                    new City("Southampton", England),
                    new City("Dublin", Ireland),
                    new City("Galway", Ireland),
                    new City("Cork", Ireland),
=======
                    new City("Innsbruck", Austria),
                    new City("Linz", Austria),
                    new City("Brussels", Belgium),
                    new City("Charleroi", Belgium),
                    new City("Antwerp", Belgium),
                    new City("Ghent", Belgium),
                    new City("Liege", Belgium),
                    new City("Antalya", Turkey),
                    new City("Istanbul", Turkey),
                    new City("Ankara", Turkey),
                    new City("Izmir", Turkey),
                    new City("Bursa", Turkey),
                    new City("London", England),
                    new City("Bristol", England),
                    new City("Nottingham", England),
                    new City("Southampton", England),
                    new City("Leicester", England),
                    new City("Dublin", Ireland),
                    new City("Galway", Ireland),
                    new City("Kinsale", Ireland),
                    new City("Cork", Ireland),
                    new City("Clifden", Ireland),
>>>>>>> a58abe99516650f500b9b364bb306d3811dea156
            };

                var Hotels = new List<Hotel>();

                using (StreamReader sr = File.OpenText("Data/hotel_names.txt"))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Random random = new Random();
                        var index = random.Next(Cities.Count);
                        var hotel = new Hotel(s, random.Next(1, 6), Cities[index],
                            random.Next(0, 2) == 1 ? true : false,
                            random.Next(0, 2) == 1 ? true : false);
                        Hotels.Add(hotel);
                    }
                }

                for (int i = 0; i < 500; i++)
                {
                    Random random = new Random();
                    // To
                    var indexHotel = random.Next(Hotels.Count);
                    // From
                    var indexCity = random.Next(Cities.Count);

                    var offer = new Offer(Hotels[indexHotel], random.Next(1000, 3000), DateTime.Now.AddDays(10), DateTime.Now.AddDays(17),
                                                Cities[indexCity], true);
                    context.Offer.Add(offer);
                }



                context.SaveChanges();
            }
        }
    }
}

