using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


Console.WriteLine("Welcome to the track my food program");
Console.WriteLine("Do you want to register your food? Type \"yes\" to start");
string response = Console.ReadLine();


//before your loop
var csv = new StringBuilder();



while (response != "no")
{
    //in your loop
    //   var first = reader[0].ToString();
    //   var second = image.ToString();
    //Suggestion made by KyleMit


    Console.WriteLine("Enter the name of the food: ");
    string nameFood = Console.ReadLine();
    Console.WriteLine("Enter the calories of the food: ");
    float caloriesFood = float.Parse(Console.ReadLine());
    DateTime enteredTime = DateTime.Now;
    DateTime defaultDateTime; 
    DateTime date1;
    DateTime date2;
    

    defaultDateTime = new DateTime(2022, 1, 1, enteredTime.Hour, enteredTime.Minute, enteredTime.Second);
   
    date1 = new DateTime(2022, 1, 1, 11, 30, 0);

    date2 = new DateTime(2022, 1, 1, 17, 30, 0);


    Console.WriteLine(nameFood);
    Console.WriteLine(caloriesFood);
    Console.WriteLine(enteredTime.ToString("hh:mm:ss tt"));


    if (defaultDateTime < date1)
    {
        Console.WriteLine("Breakfast Time!");
    }
    else if (defaultDateTime > date1)
    {
        Console.WriteLine("Lunch Time!");
    }
    else if (defaultDateTime > date2)
    {
        Console.WriteLine("Dinner Time!");
    }
    else
    {
        Console.WriteLine("Not valid");
    }
    Console.WriteLine("Do you want to continue? Type \"no\" to exit the program");
    response = Console.ReadLine();
    

    var newLine = string.Format("{0},{1},{2},", nameFood, caloriesFood.ToString(), enteredTime.ToString());
    csv.AppendLine(newLine);

}
//after your loop
File.WriteAllText(@"C: eposC#TrackMyFoodTrackMyFoodAndresEguez ext.csv", csv.ToString());


static void Main(string[] args)
{
    string filepath = @"C: eposC#TrackMyFoodTrackMyFoodAndresEguez ext.csv";
    try
    {
        using (StreamReader reader = new StreamReader(filepath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Console.ReadKey();
}