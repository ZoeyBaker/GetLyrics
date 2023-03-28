using System;
using System.Text.Json.Nodes;




var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://spotify23.p.rapidapi.com/search/?q=%3CREQUIRED%3E&type=multi&offset=0&limit=10&numberOfTopResults=5"),
    Headers =
    {
        { "X-RapidAPI-Key", "d37724f31amsh5b7b473995b9699p1dd08djsn1424a0334a39" },
        { "X-RapidAPI-Host", "spotify23.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}