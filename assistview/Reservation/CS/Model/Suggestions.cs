using Syncfusion.WinForms.AIAssistView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace AssistViewDemo
{
    public class GetInput
    {
        public string Question { get; set; }
        public List<string> Suggestions { get; set; }
    }
    public enum SuggestionAction { 
        SendMessage,
        ShowDatePicker,
        ShowNumberPicker,
        ShowCountryPicker,
        ShowComboSelector,
        ShowListBox,
        ShowButton
    }

    public class ReservationSuggestion
    {
        public string DisplayText { get; set; }
        public SuggestionAction Action { get; set; }

        public override string ToString()
        {
            return DisplayText;
        }
    }

    public class ChatResponseBundle
    {
        public string BotResponse { get; set; }
        public List<ReservationSuggestion> Suggestions { get; set; }
    }

    public enum Class
    {
        Economy,
        Business,
        First
    }

    public enum Airline
    {
        Emirates,
        Qatar,
        Singapore,
        Lufthansa,
        BritishAirways,
        AirFrance,
        AmericanAirlines,
        Delta,
        UnitedAirlines,
        CathayPacific
    }

    public class CountryName
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }

    public class City
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public List<Hotel> Hotels { get; set; }
    }

    public class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Rating { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }

    public class ResponseManager
    {
        private static string CurrentStep = "None";
        private static ResponseManager _instance;

        // Ensure data is initialized
        internal static ResponseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ResponseManager();
                    _instance.Booking(); // Initialize all lists
                }
                return _instance;
            }
        }
        // Allow external callers to begin the booking flow (start at CountryName)
        public void BeginBooking()
        {
            CurrentStep = this.NextQuestion();
        }
       

        public static ChatResponseBundle GetResponseForQuery(string query)
        {
            string normalized = query.ToLower();
            var bundle = new ChatResponseBundle();
            var data = Instance;

            if (CurrentStep != "None")
            {
                // Helper logic moved to a class-level method for compatibility with older C# compilers.

                // If we're mid-booking, attempt to set the current value and advance
                if (CurrentStep != "None")
                {
                    string error;
                    if (data.TrySetValue(CurrentStep, query, out error))
                    {
                        // Advance to next question
                        CurrentStep = data.NextQuestion();
                        bundle.BotResponse = data.Question;
                        bundle.Suggestions = data.MapOptions(data.Options);
                        // If finished, reset step
                        if (CurrentStep == null)
                        {
                            CurrentStep = "None";
                        }
                    }
                    else
                    {
                        // Validation error — return the error as bot response and repeat same suggestions
                        bundle.BotResponse = error;
                        bundle.Suggestions = data.MapOptions(data.Options);
                    }
                    return bundle;
                }
            }

            // Default fallback: keep a neutral prompt and no action suggestions (initial launch uses country suggestions)
            bundle.BotResponse = "I'm your AI Assistant. How can I help you today?";
            bundle.Suggestions = new List<ReservationSuggestion>();

            return bundle;
        }


        CountryName selectedCountry;
        City selectedCity;
        Hotel selectedHotel;

        public List<CountryName> Countries { get; set; }
        public List<City> Cities { get; set; }
        public List<Hotel> Hotels { get; set; }

        public string Name { get; set; }
        public DateTime Departure { get; set; }
        public int? NumberOfDays { get; set; }
        public bool? Return { get; set; }
        public int? Adults { get; set; }
        public int? Children { get; set; }
        public Class? Class { get; set; }
        public Airline? Airline { get; set; }

        public string Question { get; set; }
        public List<string> Options { get; set; }

        public CountryName CountryName
        {
            get
            {
                return selectedCountry;
            }
            set
            {
                selectedCountry = value;
                OnSelectedCountryChanged();
            }
        }

        public City City
        {
            get { return selectedCity; }
            set
            {
                selectedCity = value;
                OnSelectedCityChanged();
            }
        }

        public Hotel Hotel
        {
            get { return selectedHotel; }
            set
            {
                selectedHotel = value;
            }
        }
        private Dictionary<string, GetInput> Questions { get; set; }

        public void Booking()
        {
            Countries = new List<CountryName>()
            {
                new CountryName() {
                    Name = "Australia",
                    Cities = new List<City>
                    {
                        new City{
                            Name = "Sydney",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Langham", Address = "89-113 Kent St, Sydney NSW 2000", Phone = "+61 2 9256 2222", Rating = "5", Price = "$200", Description = "The Langham, Sydney is a luxurious 5-star hotel that offers an indoor pool, a day spa and award-winning dining options. All rooms offer a flat-screen TV and free WiFi. The Langham Sydney is located in the historic Rocks district. The Sydney Opera House and the Sydney Harbor Bridge are within a 15-minute walk." },
                                new Hotel{ Name = "Four Seasons Hotel", Address = "199 George St, Sydney NSW 2000", Phone = "+61 2 9250 3100", Rating = "5", Price = "$250", Description = "Overlooking Sydney's historic Rocks area, Four Seasons Hotel offers free WiFi, a bar, restaurant, fitness center and swimming pool. Situated in Sydney CBD (Central Business District), it features luxurious rooms with panoramic views over the iconic Sydney Opera House and Circular Quay." },
                                new Hotel{ Name = "Shangri-La Hotel", Address = "176 Cumberland St, The Rocks NSW 2000", Phone = "+61 2 9250 6000", Rating = "5", Price = "$220", Description = "Wake up to breathtaking views of the iconic Sydney Opera House, the Harbor Bridge or Darling Harbor each morning. You will be spoiled for choice at the Shangri-La Hotel, with a day spa, fitness center and indoor pool at your disposal." }
                            }
                        },
                        new City{
                            Name = "Melbourne",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Crown Towers", Address = "8 Whiteman St, Southbank VIC 3006", Phone = "+61 3 9292 6868", Rating = "5", Price = "$180", Description = "Rising above Melbourne’s vibrant Southbank precinct, Crown Towers offers spacious luxury rooms with views of the city or Port Phillip Bay. Each room features original artworks and marble bathrooms." },
                                new Hotel{ Name = "The Langham", Address = "1 Southgate Ave, Southbank VIC 3006", Phone = "+61 3 8696 8888", Rating = "5", Price = "$200", Description = "Situated on the banks of the Yarra River, The Langham, Melbourne features an indoor swimming pool with views across the city. The elegant interior includes a grand marble staircase, cascading fountains and magnificent chandeliers." },
                                new Hotel{ Name = "Grand Hyatt", Address = "123 Collins St, Melbourne VIC 3000", Phone = "+61 3 9657 1234", Rating = "5", Price = "$190", Description = "Located on Collins Street, perfectly positioned in the heart of Melbourne's shopping, dining and theater center, Grand Hyatt Melbourne comprises of luxurious guest rooms, and premium suites, all boasting contemporary living and spectacular Melbourne city skyline or picturesque Yarra River views." }
                            }
                        },
                        new City{
                            Name = "Perth",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Crown Metropol", Address = "Great Eastern Hwy, Burswood WA 6100", Phone = "+61 8 9362 8888", Rating = "5", Price = "$150", Description = "Crown Metropol Perth offers modern and stylish accommodations within a 15 minutes’ drive from Perth’s International and Domestic Airports. Perth city center is a 5-minute drive away." },
                                new Hotel{ Name = "Pan Pacific", Address = "207 Adelaide Terrace, Perth WA 6000", Phone = "+61 8 9224 7777", Rating = "5", Price = "$160", Description = "Overlooking the Swan River and riverfront parklands, Pan Pacific Perth features a state-of-the-art fitness center, a choice of 2 restaurants and 2 bars." },
                                new Hotel{ Name = "Hyatt Regency", Address = "99 Adelaide Terrace, Perth WA 6000", Phone = "+61 8 9225 1234", Rating = "5", Price = "$140", Description = "Located in Perth CBD (Central Business District), the 5-star Duxton Hotel Perth offers luxury rooms in a great location. Facilities include a restaurant, bar, fitness center and outdoor swimming pool." }
                            }
                        },
                        new City{
                            Name = "Brisbane",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "W Brisbane", Address = "81 North Quay, Brisbane QLD 4000", Phone = "+61 7 3556 8888", Rating = "5", Price = "$170", Description = "W Brisbane is located on North Quay with views of the Brisbane River. Offering 312 spacious guest rooms, W Brisbane boasts three restaurants and bars, a spa and fitness center." },
                                new Hotel{ Name = "Emporium Hotel", Address = "1000 Ann St, Fortitude Valley QLD 4006", Phone = "+61 7 3253 6999", Rating = "5", Price = "$180", Description = "Emporium Hotel South Bank is located in the heart of South Bank, adjacent to Brisbane Convention & Exhibition Center. The hotel features 143 luxuriously appointed​ ​suites with all the comforts you could ask for." },
                                new Hotel{ Name = "Hilton Brisbane", Address = "190 Elizabeth St, Brisbane City QLD 4000", Phone = "+61 7 3234 2000", Rating = "5", Price = "$160", Description = "Located in the heart of Brisbane city, Hilton Brisbane is a 30-minute drive from the Gold Coast's theme parks. The hotel features stunning city views, an indoor pool, a fitness center and a tennis court." }
                            }
                        }
                    }
                },
                new CountryName() { Name = "Canada",
                Cities = new List<City>
                    {
                        new City{
                            Name = "Toronto",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Ritz-Carlton", Address = "181 Wellington St W, Toronto, ON M5V 3G7", Phone = "+1 416-585-2500", Rating = "5", Price = "$250", Description = "Located in the center of downtown Toronto, this 5-star hotel is across the street from the CN Tower and steps away from the Air Canada Center and other attractions." },
                                new Hotel{ Name = "Four Seasons Hotel", Address = "60 Yorkville Ave, Toronto, ON M4W 0A4", Phone = "+1 416-964-0411", Rating = "5", Price = "$230", Description = "Located in the Yorkville, in the heart of Toronto's most fashionable shopping, dining and entertainment district, the new Four Seasons Hotel Toronto offers 259 spacious guest rooms." },
                                new Hotel{ Name = "The Hazelton Hotel", Address = "118 Yorkville Ave, Toronto, ON M5R 1C2", Phone = "+1 416-963-6300", Rating = "5", Price = "$220", Description = "This hotel is located in the upscale district of Yorkville and is near a number of Toronto's finest restaurants. A full service spa, boasting world class spa treatments is available." }
                            }
                        },
                        new City{
                            Name = "Vancouver",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Fairmont Pacific Rim", Address = "1038 Canada Pl, Vancouver, BC V6C 0B9", Phone = "+1 604-695-5300", Rating = "5", Price = "$240", Description = "This hotel is located in the financial district of Vancouver city center and offers on-site dining and a bar. A spa and fitness center are available. Stanley Park is 1.5 mi away." },
                                new Hotel{ Name = "Shangri-La Hotel", Address = "1128 W Georgia St, Vancouver, BC V6E 0A8", Phone = "+1 604-689-1120", Rating = "5", Price = "$230", Description = "Featuring a full service spa, Shangri-La Hotel offers easy access to luxury shopping, art installations and trendy restaurants and bars. Guests can enjoy views of Vancouver city center." },
                                new Hotel{ Name = "The Sutton Place Hotel", Address = "845 Burrard St, Vancouver, BC V6Z 2K6", Phone = "+1 604-682-5511", Rating = "5", Price = "$220", Description = "This hotel is located in the heart of downtown Vancouver and is 5 minutes’ walk from Coal Harbor and Vancouver Convention Center. An indoor pool and hot tub are featured." }
                            }
                        },
                        new City{
                            Name = "Montreal",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Ritz-Carlton Montreal", Address = "1228 Sherbrooke St W, Montreal, QC H3G 1H6", Phone = "+1 514-842-4212", Rating = "5", Price = "$220", Description = "Located in the Golden Square Mile, this luxury hotel is 2 minutes' walk from the Montreal Museum of Fine Arts. The hotel offers a full-service spa, a gourmet restaurant and a modern gym." },
                                new Hotel{ Name = "Hotel Birks Montreal", Address = "1240 Phillips Square, Montreal, QC H3B 3H4", Phone = "+1 514-954-1111", Rating = "5", Price = "$210", Description = "Located in Downtown Montreal, this elegant hotel and spa is 5 minutes' walk from the Bell Center. It features a saltwater pool and free WiFi." },
                                new Hotel{ Name = "Hotel Le St-James", Address = "355 Saint-Jacques St, Montreal, QC H2Y 1N9", Phone = "+1 514-841-3111", Rating = "5", Price = "$200", Description = "Located in Old Montreal, only steps from many attractions, this historic hotel offers European elegance, along with first-class services and an extensive selection of on-site dining options." }
                            }
                        },
                        new City{
                            Name = "Calgary",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Fairmont Palliser", Address = "133 9 Ave SW, Calgary, AB T2P 2M3", Phone = "+1 403-262-1234", Rating = "5", Price = "$200", Description = "Featuring a large indoor pool and hot tub, this luxurious hotel is connected to the Calgary Telus Convention Center by skywalk. Several on-site dining options are available. Guest rooms feature cable TV with pay per view and a work desk." },
                                new Hotel{ Name = "Hyatt Regency", Address = "700 Centre St S, Calgary, AB T2G 5P6", Phone = "+1 403-717-1234", Rating = "5", Price = "$190", Description = "Featuring an outdoor seasonal pool and on-site restaurant, Hyatt Regency Calgary is located in the city center of Calgary. A fitness center and sauna are available for guest use. Free WiFi is provided." },
                                new Hotel{ Name = "Hotel Arts", Address = "119 12 Ave SW, Calgary, AB T2R 0G8", Phone = "+1 403-266-4611", Rating = "5", Price = "$180", Description = "Offering an outdoor pool and bar with city views, Hotel Arts is located in Calgary city center. Free WiFi is provided throughout the property. A flat-screen TV features in each room. " }
                            }
                        }
                    }
                },
                new CountryName() {
                    Name = "France",
                    Cities = new List<City>
                    {
                        new City{
                            Name = "Paris",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Four Seasons Hotel", Address = "3 Rue du Faubourg Saint-Honoré, 75008 Paris", Phone = "+33 1 49 52 70 00", Rating = "5", Price = "$250", Description = "Le Meurice is a hotel palace located in central Paris. It offers a 2-star Michelin restaurant as well as a spa and a fitness center with massage treatments. Decorated in a 18th century style, with Louis XVI furniture, a flat-screen TV with international channels and DVD player are provided in the air-conditioned rooms." },
                                new Hotel{ Name = "Shangri-La Hotel", Address = "10 Avenue d'Iéna, 75116 Paris", Phone = "+33 1 53 67 19 98", Rating = "5", Price = "$230", Description = "A former residence of Prince Roland Bonaparte and listed in the French “Monuments Historiques”, Shangri-La Hotel, Paris is a hotel palace located across the Seine and facing the Eiffel Tower. It reflects both Asian hospitality and French art de vivre." },
                                new Hotel{ Name = "The Peninsula", Address = "19 Avenue Kléber, 75116 Paris", Phone = "+33 1 58 12 28 88", Rating = "5", Price = "$220", Description = "The Peninsula sits in the heart of Paris and is within walking distance of famous monuments, museums, and luxury shopping. The hotel features a rooftop restaurant, a bar, a spa, and a 50-foot indoor pool." }
                            }
                        },
                        new City{
                            Name = "Nice",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Hyatt Regency", Address = "13 Promenade des Anglais, 06000 Nice", Phone = "+33 4 93 27 12 34", Rating = "5", Price = "$180", Description = "Located on the Promenade des Anglais, Hyatt Regency Nice Palais de la Méditerranée is an art-deco style hotel featuring an on-site casino, an indoor and outdoor swimming pool, a hammam, a sauna, a fitness center and a private beach." },
                                new Hotel{ Name = "Le Negresco", Address = "37 Prom. des Anglais, 06000 Nice", Phone = "+33 4 93 16 64 00", Rating = "5", Price = "$170", Description = "The famous Hotel Negresco, dating from the beginning of the 20th century, overlooks the beach and the Promenade des Anglais in Nice. From Louis XIII style to modern art, 5 centuries of history are exhibited throughout the hotel." },
                                new Hotel{ Name = "Hotel Le Royal", Address = "23 Prom. des Anglais, 06000 Nice", Phone = "+33 4 97 03 44 44", Rating = "5", Price = "$160", Description = "Located on the Promenade des Anglais, Radisson Blu Hotel Nice features a private beach and a rooftop swimming pool offering panoramic views of the Mediterranean Sea. Free WiFi is available throughout the entire property." }
                            }
                        },
                        new City{
                            Name = "Lyon",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Villa Maïa", Address = "8 Rue du Professeur Pierre Marion, 69005 Lyon", Phone = "+33 4 78 16 01 01", Rating = "5", Price = "$160", Description = "Located in Lyon, 1.1 mi from the Museum of Fine Arts of Lyon, Villa Maïa features a fitness center and sauna. Free WiFi is available." },
                                new Hotel{ Name = "Cour des Loges", Address = "6 Rue du Bœuf, 69005 Lyon", Phone = "+33 4 72 77 44 44", Rating = "5", Price = "$150", Description = "Located in Old Lyon, Cour des Loges comprises 4 restored Renaissance buildings set around a glass-roofed courtyard. It features 2 restaurants and a wine cellar. Free WiFi is available throughout the hotel." },
                                new Hotel{ Name = "Sofitel Lyon Bellecour", Address = "20 Quai Gailleton, 69002 Lyon", Phone = "+33 4 72 41 20 20", Rating = "5", Price = "$140", Description = "Located in the heart of Lyon, this 5-star hotel is located a 6-minute walk from Place Bellecour. Free WiFi is available throughout the property." }
                            }
                        },
                        new City{
                            Name = "Marseille",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "InterContinental", Address = "1 Place Daviel, 13002 Marseille", Phone = "+33 4 13 42 42 42", Rating = "5", Price = "$150", Description = "Located in Marseille overlooking the Vieux Port, Radisson Blu Hotel Marseille Vieux Port is a 4-star hotel. It offers an outdoor swimming pool overlooking Fort Saint-Nicholas and a fitness room with a panoramic view of the main monuments of the city." },
                                new Hotel{ Name = "Sofitel Marseille", Address = "36 Boulevard Charles Livon, 13007 Marseille", Phone = "+33 4 91 15 59 00", Rating = "5", Price = "$140", Description = "Sofitel Marseille Vieux-Port offers a fitness center, a spa with a hot tub, and a terrace overlooking the Marseille Old Port. Some air-conditioned guest rooms have a terrace with harbor views." },
                                new Hotel{ Name = "Hotel C2", Address = "48 Rue Roux de Brignoles, 13006 Marseille", Phone = "+33 4 95 05 13 13", Rating = "5", Price = "$130", Description = "Featuring a grand piano, HOTEL C2, located in the Pierre Puget courtyard in Marseille, is a 19th-century private mansion converted into a hotel. It features the original marble and parquet floors, columns, bas-relief sculptures, frescoes and bronze banisters, whilst offering a minimalist, contemporary twist." }
                            }
                        }
                    }
                },
                new CountryName() {
                    Name = "Germany",
                    Cities = new List<City>
                    {
                        new City{
                            Name = "Berlin",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Hotel Adlon Kempinski", Address = "Unter den Linden 77, 10117 Berlin", Phone = "+49 30 22610", Rating = "5", Price = "$200", Description = "The quintessence of luxury lodging, the Adlon is a legendary 5-star hotel situated in Berlin’s Mitte, beside the Brandenburg Gate. State-of-the-art facilities include a double Michelin-star restaurant and a shopping arcade." },
                                new Hotel{ Name = "The Ritz-Carlton", Address = "Potsdamer Platz 3, 10785 Berlin", Phone = "+49 30 337777", Rating = "5", Price = "$190", Description = "This 5-star hotel at Berlin’s Potsdamer Platz Square features a luxury spa with pool. Its elegant rooms have touch-screen controls and marble bathrooms. The Ritz-Carlton, Berlin offers a grill restaurant and a sushi restaurant." },
                                new Hotel{ Name = "Regent Berlin", Address = "Charlottenstraße 49, 10117 Berlin", Phone = "+49 30 2033630", Rating = "5", Price = "$180", Description = "Ideally located on Berlin's Gendarmenmarkt Square, this classic-style, 5-star hotel offers a casual dining at the Charlotte & Fritz restaurant, exclusive spa facilities, and free WiFi." }
                            }
                        },
                        new City{
                            Name = "Munich",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Hotel Bayerischer Hof", Address = "Promenadeplatz 2-6, 80333 Munich", Phone = "+49 89 21200", Rating = "5", Price = "$180", Description = "Offering 5 gourmet restaurants, 6 bars, and an exclusive spa with rooftop pool, this historic 5-star hotel is located directly in Munich’s fashionable shopping district." },
                                new Hotel{ Name = "Sofitel Munich Bayerpost", Address = "Bayerstraße 12, 80335 Munich", Phone = "+49 89 599480", Rating = "5", Price = "$170", Description = "This 5-star hotel with free Wi-Fi and design interiors is just 328 feet from Munich Main Station. Spa facilities at the Sofitel Munich include an indoor swimming pool, sauna and modern fitness studio." },
                                new Hotel{ Name = "Mandarin Oriental", Address = "Neuturmstraße 1, 80331 Munich", Phone = "+49 89 290980", Rating = "5", Price = "$160", Description = "Luxurious rooms, and the famous Matsuhisa, Munich restaurant are featured at this 5-star hotel in the heart of Munich's Old Town. It is located in a historic building offers a stylish spa with indoor pool, and free Wi-Fi." }
                            }
                        },
                        new City{
                            Name = "Hamburg",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Fairmont Hotel Vier Jahreszeiten", Address = "Neuer Jungfernstieg 9-14, 20354 Hamburg", Phone = "+49 40 34940", Rating = "5", Price = "$170", Description = "Overlooking Außenalster Lake, this classic 5-star hotel offers free Wi-Fi, an elegant spa with indoor pool, a private cinema, and a gourmet restaurant. Hamburg Central Station is 500 meters away." },
                                new Hotel{ Name = "Park Hyatt", Address = "Bugenhagenstraße 8, 20095 Hamburg", Phone = "+49 40 33321234", Rating = "5", Price = "$160", Description = "Spacious rooms with Bang & Olufsen flat-screen TVs and a free spa with indoor pool are featured at this hotel in the Mönckebergstraße shopping street. The hotel has a private underground car park." },
                                new Hotel{ Name = "The Westin", Address = "Elbchaussee 401-403, 22609 Hamburg", Phone = "+49 40 897280", Rating = "5", Price = "$150", Description = "This hotel in Hamburg’s St. Georg district offers free Wi-Fi, a sauna, gym, and a private garden. The Alster Lake and Jungfernstieg shopping street are a 7-minute walk away." }
                            }
                        },
                    }
                },
                new CountryName() {
                    Name = "India",
                    Cities = new List<City>
                    {
                        new City{
                            Name = "Delhi",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Leela Palace", Address = "Diplomatic Enclave, Chanakyapuri, New Delhi, Delhi 110023", Phone = "+91 11 3933 1234", Rating = "5", Price = "$200", Description = "Located in New Delhi's Diplomatic Enclave, The Leela Palace New Delhi is a blend of Lutyen's architecture and the royal Indian culture. A pampering spa, 4 dining options and free parking are available." },
                                new Hotel{ Name = "The Oberoi", Address = "Dr Zakir Hussain Marg, New Delhi, Delhi 110003", Phone = "+91 11 2436 3030", Rating = "5", Price = "$190", Description = "The Lodhi – A member of The Leading Hotels Of The World is located in New Delhi. The property is centered around a courtyard with a large swimming pool." },
                                new Hotel{ Name = "The Taj Mahal", Address = "Number One Mansingh Road, New Delhi, Delhi 110011", Phone = "+91 11 6656 6162", Rating = "5", Price = "$180", Description = "Located in the heart of Lutyen’s Delhi, Taj Mahal Hotel New Delhi offers luxurious accommodations located amid 6 acres of landscaped grounds. Featuring 7 dining options, 5-star facilities include a state-of-the-art fitness center, an outdoor pool and spa." }
                            }
                        },
                        new City{
                            Name = "Mumbai",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Oberoi", Address = "Nariman Point, Mumbai, Maharashtra 400021", Phone = "+91 22 6632 5757", Rating = "5", Price = "$190", Description = "Centrally located in Mumbai's business district, close to South Mumbai's shopping and entertainment areas, The Oberoi offers luxury and convenience with its outdoor heated pool, 24-hour spa, fitness and concierge service." },
                                new Hotel{ Name = "The Taj Mahal Palace", Address = "Apollo Bunder, Mumbai, Maharashtra 400001", Phone = "+91 22 6665 3366", Rating = "5", Price = "$180", Description = "Built in 1973, the iconic The Taj Mahal Tower Mumbai stands majestically across from the Gateway of India, overlooking the Arabian Sea. The Tower stands in harmonious contrast to The Taj Mahal Palace." },
                                new Hotel{ Name = "The St. Regis", Address = "462, Senapati Bapat Marg, Lower Parel, Mumbai, Maharashtra 400013", Phone = "+91 22 6162 8000", Rating = "5", Price = "$170", Description = "Situated in Mumbai's Worli area, The St. Regis Mumbai is a 5-minute drive away from Lower Parel, the city's premier commercial and entertainment hub. It is 8 km from the famous Siddhivinayak Temple and 15 km from Shivaji Park." }
                            }
                        },
                        new City{
                            Name = "Chennai",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Leela Palace", Address = "Adyar Seaface, MRC Nagar, Chennai, Tamil Nadu 600028", Phone = "+91 44 3366 1234", Rating = "5", Price = "$180", Description = "The luxurious Leela Palace Chennai is located on the Adyar Seaface and offers a sea-facing city retreat. It has an outdoor pool, a spa, and 4 dining options. Adyar Seaface is 1.2 mi and Ramee Mall is 2.7 mi." },
                                new Hotel{ Name = "ITC Grand Chola", Address = "63, Mount Road, Guindy, Chennai, Tamil Nadu 600032", Phone = "+91 44 2220 0000", Rating = "5", Price = "$170", Description = "ITC Grand Chola is a 10-minute drive from the Chennai International Airport and the Tidel Park. It features 10 dining options and an outdoor swimming pool and a fitness center." },
                                new Hotel{ Name = "The Park", Address = "601, Anna Salai, Near US Embassy, Chennai, Tamil Nadu 600006", Phone = "+91 44 4267 6000", Rating = "5", Price = "$160", Description = "The luxurious Raintree Anna Salai Hotel is located a 20-minute drive from Chennai International Airport. It provides well-appointed rooms and 5-star facilities like a pool, a spa and a sauna." }
                            }
                        },
                    }
                },
                new CountryName() {
                    Name = "Italy",
                    Cities = new List<City>
                    {
                        new City{
                            Name = "Rome",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Hotel Hassler", Address = "Piazza Trinità dei Monti, 6, 00187 Roma RM, Italy", Phone = "+39 06 699340", Rating = "5", Price = "$250", Description = "Set at the top of the Spanish Steps, Hassler Roma is one of the city's most famous hotels. It offers elegant rooms and suites with high-speed free WiFi, and free wellness facilities including a sauna, Turkish bath and gym." },
                                new Hotel{ Name = "The St. Regis", Address = "Via Vittorio E. Orlando, 3, 00185 Roma RM, Italy", Phone = "+39 06 47091", Rating = "5", Price = "$240", Description = "Boasting a stunning location just above the Spanish Steps, Rocco Forte Hotel De La Ville offers 3 restaurants, a spa, and elegant rooms with free WiFi and city views. The Trevi Fountain is a 5-minute walk away." },
                                new Hotel{ Name = "The Westin", Address = "Via Giuseppe Zanardelli, 14, 00186 Roma RM, Italy", Phone = "+39 06 6889 1", Rating = "5", Price = "$230", Description = "Set in a 19th-century building, The Westin Excelsior is located in Rome’s fashionable Via Veneto. It features a wellness center with a large indoor pool and a well-equipped gym." }
                            }
                        },
                        new City{
                            Name = "Venice",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Gritti Palace", Address = "Campo Santa Maria del Giglio, 2467, 30124 Venezia VE, Italy", Phone = "+39 041 794611", Rating = "5", Price = "$240", Description = "The Gritti Palace is an exclusive hotel where history and culture meet with renewed Venetian style. A place of exceptional art and elegance, the restored Gritti Palace retains its reassuringly intimate and familiar feel." },
                                new Hotel{ Name = "Hotel Danieli", Address = "Riva degli Schiavoni, 4196, 30122 Venezia VE, Italy", Phone = "+39 041 5226480", Rating = "5", Price = "$230", Description = "Overlooking Venice Lagoon, Hotel Danieli is a legendary hotel 200 yards from St. Mark's Square. Each room is spacious and finely furnished. The staff provides an unmatchable service." },
                                new Hotel{ Name = "The St. Regis", Address = "San Marco 2159, 30124 Venezia VE, Italy", Phone = "+39 041 2400001", Rating = "5", Price = "$220", Description = "The St. Regis Venice features wonderful views of the Grand Canal. It features a panoramic restaurant and bar, and Venetian-style decor. The hotel has marble interiors with lavish and design furniture." }
                            }
                        },
                        new City{
                            Name = "Milan",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "Park Hyatt", Address = "Via Tommaso Grossi, 1, 20121 Milano MI, Italy", Phone = "+39 02 8821 1234", Rating = "5", Price = "$230", Description = "Facing the entrance of the Galleria Vittorio Emanuele, Park Hyatt Milano is set in the heart of the fashion district, 200 yards from the Cathedral and La Scala Theater. The hotel features free WiFi, a spa and gym." },
                                new Hotel{ Name = "Bulgari Hotel", Address = "Via Privata Fratelli Gabba, 7b, 20121 Milano MI, Italy", Phone = "+39 02 805 8051", Rating = "5", Price = "$220", Description = "Bulgari Hotel Milano is probably the most refined and exclusive establishment in Milan, a boutique property adjacent to the most important shopping street, Via Montenapoleone." },
                                new Hotel{ Name = "Armani Hotel", Address = "Via Alessandro Manzoni, 31, 20121 Milano MI, Italy", Phone = "+39 02 8883 8888", Rating = "5", Price = "$210", Description = "Just 150 yards from Montenapoleone Metro Station, Four Seasons Hotel Milano offers luxurious rooms in Milan’s shopping district. The Cathedral is a 10-minute walk away and Wi-Fi is free throughout." }
                            }
                        }
                    }
                },
                new CountryName() {
                    Name = "Japan",
                    Cities = new List<City>
                    {
                        new City{
                            Name = "Tokyo",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Peninsula", Address = "1-8-1 Yurakucho, Chiyoda-ku, Tokyo 100-0006", Phone = "+81 3 6270 2888", Rating = "5", Price = "$250", Description = "Offering high-floor views of the city and Tokyo Bay, 5-star room at The Peninsula Tokyo feature a large plasma-screen TV. A dressing room, mood lighting and a large private bathroom with a bathtub are included." },
                                new Hotel{ Name = "The Ritz-Carlton", Address = "9-7-1 Akasaka, Minato-ku, Tokyo 107-6245", Phone = "+81 3 3423 8000", Rating = "5", Price = "$240", Description = "Located at the heart of the downtown Roppongi area in Tokyo's tallest building, the 53rd-story Ritz-Carlton offers elegant luxury high above Tokyo’s busy streets. It features an indoor pool and 8 dining options." },
                                new Hotel{ Name = "Mandarin Oriental", Address = "2-1-1 Nihonbashi Muromachi, Chuo-ku, Tokyo 103-8328", Phone = "+81 3 3270 8800", Rating = "5", Price = "$230", Description = "Mandarin Oriental Tokyo offers an award-winning luxury experience with 3 Michelin-star dining, a spa and wellness center and the spacious guest rooms and suites offer the chic décor and modern conveniences." }
                            }
                        },
                        new City{
                            Name = "Kyoto",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Ritz-Carlton", Address = "Kamogawa Nijo-Ohashi Hotori, Nakagyo-ku, Kyoto 604-0902", Phone = "+81 75 746 5555", Rating = "5", Price = "$240", Description = "The Ritz-Carlton, Kyoto features a peaceful setting within the Kamogawa River facing the Higashiyama Mountains. The hotel includes a spa, indoor pool, fitness center, and various dining options." },
                                new Hotel{ Name = "Four Seasons Hotel", Address = "445-3 Myohoin Maekawacho, Higashiyama-ku, Kyoto 605-0932", Phone = "+81 75 541 8288", Rating = "5", Price = "$230", Description = "Awarded the TripAdvisor Certificate of Excellence in 2013, 2014, 2015, 2016, 2017, 2018 and 2019, Four Seasons Hotel Kyoto features a modern embodiment of the traditional Japanese garden." },
                                new Hotel{ Name = "Hyatt Regency", Address = "644-2 Sanjusangendo-mawari, Higashiyama-ku, Kyoto 605-0941", Phone = "+81 75 541 1234", Rating = "5", Price = "$220", Description = "Located just a 5-minute walk from the iconic Sanjusangendo Temple, Hyatt Regency Kyoto offers a spa, 3 restaurants and a bar. The elegant rooms are spacious and come with a flat-screen TV, DVD player and an en suite bathroom." }
                            }
                        },
                        new City{
                            Name = "Osaka",
                            Image = "ms-appx:///ChatDemos/Assets/Osaka.png",
                            Hotels = new List<Hotel>
                            {
                                new Hotel{ Name = "The Ritz-Carlton", Address = "2-5-25 Umeda, Kita-ku, Osaka 530-0001", Phone = "+81 6 6343 7000", Rating = "5", Price = "$230", Description = "Located in the heart of Osaka city, the Ritz-Carlton Osaka offers luxurious rooms with panoramic city views, a 24-hour fitness center, and a spa with a sauna, a hot tub and a plunge pool." },
                                new Hotel{ Name = "InterContinental", Address = "3-60 Ofuka-cho, Kita-ku, Osaka 530-0011", Phone = "+81 6 6374 5700", Rating = "5", Price = "$220", Description = "Located in the heart of Osaka, InterContinental Osaka offers rooms with city views and free WiFi. The hotel features 5 dining options, a 24-hour fitness center and a spa with massage services." },
                                new Hotel{ Name = "The St. Regis", Address = "3-6-12 Honmachi, Chuo-ku, Osaka 541-0053", Phone = "+81 6 6258 3333", Rating = "5", Price = "$210", Description = "The St. Regis Osaka is located on the Honmachi street, a 5-minute walk from Shinsaibashi Station. The hotel features a 24-hour fitness center, 3 dining options and rooms with 24-hour room service." }
                            }
                        }
                    }
                },
            };
            Cities = new List<City>();
            Hotels = new List<Hotel>();
            Questions = new Dictionary<string, GetInput>()
            {
                { nameof(Name), new GetInput
                    {
                        Question = "What's your name?",
                        Suggestions = new List<string> { "A", "B" }
                    }
                },
                {
                    nameof(Departure), new GetInput {
                        Question = "When are you planning to depart?",
                        Suggestions = new List<string> {typeof(DateTime).ToString()}
                    }
                },
                { nameof(NumberOfDays), new GetInput
                    {
                        Question = "How many days would you like to stay?",
                        Suggestions = new List<string> {"2", "4", "8", "16", typeof(int).ToString() }
                    }
                },
                { nameof(Adults), new GetInput
                    {
                        Question = "How many adults are traveling?",
                        Suggestions = new List<string> {"1", "2", "3", typeof(int).ToString() }
                    }
                },
                { nameof(Children), new GetInput
                    {
                        Question = "How many children are traveling?",
                        Suggestions = new List<string> {"1", "2", "3", typeof(int).ToString() }
                    }
                },
                { nameof(Class), new GetInput
                    {
                        Question = "What class would you like to travel in?",
                        Suggestions = new List<string> {typeof(Class).ToString()}
                    }
                },
                { nameof(Airline), new GetInput
                    {
                        Question = "Do you have a preferred airline?",
                        Suggestions = new List<string> { typeof(Airline).ToString() }
                    }
                },
                { nameof(Return), new GetInput
                    {
                        Question = "Will this be a round-trip booking?",
                        Suggestions = new List<string> { "Yes", "No" }
                    }
                },
                { nameof(CountryName), new GetInput
                    {
                        Question = "Welcome " + Name + "! Where would you like to go?",
                        Suggestions = Countries
                .Where(country => country != null)  // Ensure the country is not null (optional check)
                .Select(country => country.Name)    // Select the Name property of each CountryName
                .ToList()
                    }
                },
                { nameof(City), new GetInput
                    {
                        Question = "Which city would you like to visit?",
                        Suggestions = new List<string>()
                    }
                },
                { nameof(Hotel), new GetInput
                    {
                        Question = "Please select a hotel.",
                        Suggestions = new List<string>()
                    }
                },
            };
            // Initialize defaults in Booking to remain compatible with older C# language versions
            Name = "John";
        }

        private void OnSelectedCountryChanged()
        {
            if (CountryName != null)
            {
                Cities = CountryName.Cities;
                Questions[nameof(City)].Suggestions = Cities
                    .Where(country => country != null)
                    .Select(country => country.Name)
                    .ToList();
            }
            else
            {
                Cities = new List<City>();
                Questions[nameof(City)].Suggestions = new List<string>();
                City = null;
            }
        }

        private void OnSelectedCityChanged()
        {
            if (City != null)
            {
                Hotels = City.Hotels;
                Questions[nameof(Hotel)].Suggestions = Hotels
                    .Where(hotel => hotel != null)
                    .Select(hotel => hotel.Name)
                    .ToList();
            }
            else
            {
                Hotels = new List<Hotel>();
                Questions[nameof(Hotel)].Suggestions = new List<string>();
                Hotel = null;
            }
        }

        // Helper to map Options list to ReservationSuggestion list (moved out of method for older compilers)
        private List<ReservationSuggestion> MapOptions(List<string> opts)
        {
            var list = new List<ReservationSuggestion>();
            if (opts == null) return list;
            foreach (var opt in opts)
            {
                if (opt == typeof(DateTime).ToString())
                {
                    list.Add(new ReservationSuggestion { DisplayText = "Select Date", Action = SuggestionAction.ShowDatePicker });
                }
                else if (opt == typeof(int).ToString())
                {
                    list.Add(new ReservationSuggestion { DisplayText = "Enter Number", Action = SuggestionAction.ShowNumberPicker });
                }
                else if (opt == typeof(Class).ToString())
                {
                    list.Add(new ReservationSuggestion { DisplayText = "Choose Class", Action = SuggestionAction.ShowComboSelector });
                }
                else if (opt == typeof(Airline).ToString())
                {
                    list.Add(new ReservationSuggestion { DisplayText = "Choose Airline", Action = SuggestionAction.ShowComboSelector });
                }
                else
                {
                    // Plain string option (countries, numbers, yes/no, etc.)
                    list.Add(new ReservationSuggestion { DisplayText = opt, Action = SuggestionAction.SendMessage });
                }
            }
            return list;
        }

        public string NextQuestion()
        {
            string nextInput = Name == null ?
                nameof(Name) :
                CountryName == null ?
                nameof(CountryName) :
                City == null ?
                nameof(City) :
                Hotel == null ?
                nameof(Hotel) :
                Departure == default(DateTime) ?
                nameof(Departure) :
                NumberOfDays == null ?
                nameof(NumberOfDays) :
                Return == null ?
                nameof(Return) :
                Adults == null ?
                nameof(Adults) :
                Children == null ?
                nameof(Children) :
                Class == null ?
                nameof(Class) :
                Airline == null ?
                nameof(Airline) :
                null;

            if (nextInput == null)
            {
                Question = "Thank you for providing the information. Your trip details are as follows: \n\n" +
                    "NAME: " + (Name ?? string.Empty) + "\n\n" +
                    "DEPARTURE: " + Departure.ToString("MM/dd/yyyy") + "\n\n" +
                    "NUMBER OF DAYS: " + (NumberOfDays?.ToString() ?? string.Empty) + "\n\n" +
                    "ADULTS: " + (Adults?.ToString() ?? string.Empty) + "\n\n" +
                    "CHILDREN: " + (Children?.ToString() ?? string.Empty) + "\n\n" +
                    "CLASS: " + (Class?.ToString() ?? string.Empty) + "\n\n";
                Options = new List<string>();
            }
            else
            {
                var q = Questions[nextInput];
                Question = q.Question;
                Options = q.Suggestions;
            }
            return nextInput;
        }

        public bool TrySetValue(string prop, string value, out string error)
        {
            DateTime departure;
            int days;
            int adults;
            int children;
            Class travelClass;
            Airline airline;

            switch (prop)
            {
                case nameof(Name):
                    Name = value;
                    break;
                case nameof(Departure):
                    string raw = (value ?? string.Empty).Trim();

                    // If input contains a date anywhere like 02/21/2026 or 2/1/2026, extract it
                    var m = System.Text.RegularExpressions.Regex.Match(raw, "\\b(\\d{1,2}/\\d{1,2}/\\d{2,4})\\b");
                    if (m.Success)
                    {
                        raw = m.Groups[1].Value;
                    }

                    // Accept MM/dd/yyyy or M/d/yyyy formats
                    string[] accepted = new[] { "MM/dd/yyyy", "M/d/yyyy" };
                    bool ok = DateTime.TryParseExact(raw, accepted, CultureInfo.InvariantCulture, DateTimeStyles.None, out departure);
                    if (!ok)
                    {
                        // As a last resort try a general parse (still will fail for clearly invalid formats)
                        if (!DateTime.TryParse(raw, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out departure))
                        {
                            error = "Invalid date format. Please enter date as MM/DD/YYYY (e.g. 02/21/2026).";
                            return false;
                        }
                    }

                    if (departure < DateTime.Now.Date)
                    {
                        error = "Invalid date. Please enter a future date.";
                        return false;
                    }
                    Departure = departure;
                    break;
                case nameof(NumberOfDays):
                    if (!int.TryParse(value, out days))
                    {
                        var mDays = System.Text.RegularExpressions.Regex.Match(value ?? string.Empty, "\\d+");
                        if (mDays.Success && int.TryParse(mDays.Value, out days))
                        {
                            // parsed from text like "3 Days"
                        }
                        else
                        {
                            error = "Invalid number of days. Please enter a valid number.";
                            return false;
                        }
                    }

                    if (days < 1)
                    {
                        error = "Invalid number of days. Please enter a valid number.";
                        return false;
                    }
                    NumberOfDays = days;
                    break;
                case nameof(Adults):
                    if ((int.TryParse(value, out adults)))
                    {
                        if (adults < 1)
                        {
                            error = "Invalid number of adults. Please enter a valid number.";
                            return false;
                        }
                        Adults = adults;
                    }
                    else
                    {
                        error = "Invalid number of adults. Please enter a valid number.";
                        return false;
                    }
                    break;
                case nameof(Children):
                    if ((int.TryParse(value, out children)))
                    {
                        if (children < 0)
                        {
                            error = "Invalid number of children. Please enter a valid number.";
                            return false;
                        }
                        Children = children;
                    }
                    else
                    {
                        error = "Invalid number of children. Please enter a valid number.";
                        return false;
                    }
                    break;
                case nameof(Class):
                    // Try parse with case-insensitive match first, then normalize input
                    if (!Enum.TryParse<Class>(value?.Trim(), true, out travelClass))
                    {
                        var norm = new string((value ?? string.Empty).Where(char.IsLetterOrDigit).ToArray());
                        if (!Enum.TryParse<Class>(norm, true, out travelClass))
                        {
                            error = "Invalid travel class. Please select a valid travel class.";
                            return false;
                        }
                    }
                    Class = travelClass;
                    break;
                case nameof(Airline):
                    // Accept exact, case-insensitive, or normalized matches (spaces/punctuation)
                    if (!Enum.TryParse<Airline>(value?.Trim(), true, out airline))
                    {
                        var norm = new string((value ?? string.Empty).Where(char.IsLetterOrDigit).ToArray());
                        if (!Enum.TryParse<Airline>(norm, true, out airline))
                        {
                            error = "Invalid airline. Please select a valid airline.";
                            return false;
                        }
                    }
                    Airline = airline;
                    break;
                case nameof(Return):
                    Return = value == "Yes";
                    break;
                case nameof(CountryName):
                    CountryName = Countries.FirstOrDefault(c => c.Name.ToLower() == value.ToLower());
                    break;
                case nameof(City):
                    City = Cities.FirstOrDefault(c => c.Name.ToLower() == value.ToLower());
                    break;
                case nameof(Hotel):
                    Hotel = Hotels.FirstOrDefault(h => h.Name.ToLower() == value.ToLower());
                    break;
            }
            error = null;
            return true;
        }
        
    }
}
