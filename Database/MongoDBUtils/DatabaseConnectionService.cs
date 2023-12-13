namespace ControleDeFaltasNCD.Database;

using MongoDB.Driver;
using MongoDB.Bson;

public class DatabaseConnectionService
{

    public static IMongoDatabase GetDatabase(string databaseName, string connectionUri)
    {
        var settings = MongoClientSettings.FromConnectionString(connectionUri);

        // Set the ServerApi field of the settings object to Stable API version 1
        settings.ServerApi = new ServerApi(ServerApiVersion.V1);

        // Create a new client and connect to the server
        var client = new MongoClient(connectionUri);
        return client.GetDatabase(databaseName);
    }

    // Refatorar essa classe
    public static void CheckConnection()
    {

        const string connectionUri = "mongodb+srv://alexskntks1331:b3x4w1l3eq0kQXvj@cluster0.ohilolr.mongodb.net/?retryWrites=true&w=majority";

        var settings = MongoClientSettings.FromConnectionString(connectionUri);

        // Set the ServerApi field of the settings object to Stable API version 1
        settings.ServerApi = new ServerApi(ServerApiVersion.V1);

        // Create a new client and connect to the server
        var client = new MongoClient(settings);
        try
        {
            var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
