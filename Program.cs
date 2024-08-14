using System;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace SimpleWebEncodingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example string that needs to be encoded
            string input = "<script>alert('XSS');</script>";

            // Encode the input using JavaScriptEncoder
            string encodedInput = JavaScriptEncoder.Default.Encode(input);

            // Display the encoded result
            Console.WriteLine("Original: " + input);
            Console.WriteLine("Encoded: " + encodedInput);

            // Use the encoded string in a JSON object
            var jsonObject = new { content = encodedInput };
            string jsonString = JsonSerializer.Serialize(jsonObject);

            Console.WriteLine("JSON with encoded content: " + jsonString);
        }
    }
}
