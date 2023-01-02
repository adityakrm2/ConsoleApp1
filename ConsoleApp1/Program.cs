using Newtonsoft.Json;

public class MovieStats
{
    public static string inputJSON => @"{""Name1"":""adityakumar1"",
    ""EmployeeEmail"": ""adityakumar11@gmail.com"",
    ""EmployeeAddress1"":""phase 11""
    }";
    public static void Main()
    {
        GenreRatingFinder.UsingDynamic(inputJSON);
    }
}

// Newtonsoft/GenreRatingFinder.cs
public static class GenreRatingFinder
{
    public static dynamic UsingDynamic(string jsonString)
    {
        var dynamicObject = JsonConvert.DeserializeObject<dynamic>(jsonString)!;   

        
        Dictionary<string, dynamic[]> configDict = new Dictionary<string, dynamic[]>();

        configDict.Add("EmployeeName", new dynamic[] { dynamicObject.Name, dynamicObject.Name1, dynamicObject.EmployeeName, dynamicObject.EmployeeName1});
        //configDict.Add("EmployeeEmail", new dynamic[] { dynamicObject.Email, dynamicObject.EmployeeEmail, dynamicObject.EmployeeEmail1 });
        //configDict.Add("EmployeeAddress", new dynamic[] { dynamicObject.Address, dynamicObject.EmployeeAddress, dynamicObject.EmployeeAddress1 });
        
        dynamic configName = ""; dynamic configEmail = ""; dynamic configAddress = "";

        foreach (dynamic field in configDict["EmployeeName"]) if (field != null) configName = field;
        //foreach (dynamic field in configDict["EmployeeEmail"]) if (field != null) configEmail = field;
        //foreach (dynamic field in configDict["EmployeeAddress"]) if (field != null) configAddress = field;

        Console.WriteLine(configName);
        //Console.WriteLine(configEmail);
        //Console.WriteLine(configAddress);

        return (configName, configEmail, configAddress);
    }
}
