namespace src;

    public class Game
    {
        public string Title { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }  
        public int ReleaseYear { get; set; }  
        public double Price { get; set; }
        public string Platform { get; set; }  
        public bool IsMultiplayer { get; set; } 
        public string Rating { get; set; }  
        public bool IsAvailable { get; set; }  

        public void DisplayInfo()
        {
            string info = $"O'yin Nomi: {Title} \nIshlab Chiqaruvchi: {Developer} \nNashriyotchi: {Publisher}" +
                          $"\nJanr: {Genre} \nChiqarilgan Yil: {ReleaseYear} \nNarxi: {Price} so'm" +
                          $"\nPlatformalar: {Platform} \nKo'p O'yinchi: {(IsMultiplayer ? "Mavjud" : "Mavjud emas")}" +
                          $"\nReyting: {Rating} \nMavjudligi: {(IsAvailable ? "Mavjud" : "Mavjud emas")}";
            Console.WriteLine(info);
        }
    }
