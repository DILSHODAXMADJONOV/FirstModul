namespace src;

public class Animal
{
    public string Type { get; set; }
    public string Length { get; set; }
    public string Weight { get; set; }
    public string Color { get; set; }
    public string Vomeland { get; set; }
    public string Family { get; set; }
    public string Class { get; set; }
    public string Category { get; set; }
    public string BreedingSeason { get; set; }
    public string LengthOfStay { get; set; }

public void DisplayInfo()
{
    string res = $"Type : {Type} \nLength : {Length} \nWeight : {Weight} \nColor : {Color} \nVomeland : {Vomeland} " +
            $"\nFamily : {Family}  \nClass : {Class} \nCategory : {Category} \nBreedingSeason : {BreedingSeason} \nLengthOfStay : {LengthOfStay}";
    Console.WriteLine(res);
}
}