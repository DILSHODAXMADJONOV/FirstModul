namespace src
{
    public class Restaurant
    {
        public string Name { get; set; }  
        public string Location { get; set; }  
        public string CuisineType { get; set; }  
        public double Rating { get; set; } 
        public string OpeningHours { get; set; }  
        public string ContactInfo { get; set; }  
        public string PriceRange { get; set; }  
        public bool ReservationsAvailable { get; set; } 
        public bool WiFiAvailable { get; set; } 
        public bool ParkingAvailable { get; set; }  
        public string SpecialOffers { get; set; }  
        public void DisplayInfo()
        {
            string info = $"Restoran Nomi: {Name} \nJoylashuvi: {Location} \nTaom Turi: {CuisineType} " +
                          $"\nBaholash: {Rating} \nIsh Vaqtlari: {OpeningHours} \nAloqa Ma'lumotlari: {ContactInfo}" +
                          $"\nNarx Diapazoni: {PriceRange} \nBron Qilish: {(ReservationsAvailable ? "Mavjud" : "Mavjud emas")}" +
                          $"\nWi-Fi: {(WiFiAvailable ? "Mavjud" : "Mavjud emas")}" +
                          $"\nAvtomobil Parkovkasi: {(ParkingAvailable ? "Mavjud" : "Mavjud emas")}" +
                          $"\nMaxsus Takliflar: {SpecialOffers}";
            Console.WriteLine(info);
        }
    }
}
