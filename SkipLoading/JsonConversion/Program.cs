using JsonConversion.Objects;
using System.Text.Json;
using System.Text.Json.Serialization;

TestObject1 obj1 = new TestObject1("dsad", 12, 123.3213, "dsadas");

string json1 = JsonSerializer.Serialize(obj1);

var options = new JsonSerializerOptions { WriteIndented = true };
string json2 = JsonSerializer.Serialize(obj1, options);

Console.WriteLine(json2);