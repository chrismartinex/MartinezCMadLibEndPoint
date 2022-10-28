//Chris Martinez
//10/26/22 MadLib Endpoint
//https://localhost:****/MadLib/MadLibStory/{weather}/{day}/{time}/{natPark}/{celeb}/{name}/{superHero}/{dessert}/{country}/{beer}
//Peer Review Dan Decoito: The code works well and the api is intergreted well. i like the story, you added some humor which is always good to make these projectes more enjoyable. 

using Microsoft.AspNetCore.Mvc;

namespace MartinezCMadLibEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{

[HttpGet]
[Route("MadLibStory/{weather}/{day}/{time}/{natPark}/{celeb}/{name}/{superHero}/{dessert}/{country}/{beer}")]

public string storyTelling (string weather,string day, string time,string natPark,string celeb,string name, string superHero,string country, string dessert,string beer)
{
return $"Once upon a time, on a {weather} {day} {time}.I was goofing off, on the {natPark} National Park. When I ran into {celeb}.He asked what my name was?. I said my name was: {name}, and who my favorite superhero was, {superHero}. {celeb} look at me?!!, and laughed in my face. I started to cry. I soon realize the 5 hours of traveling to {country}, had affected my rationale, and I was Dreaming! So instead I asked the flight attended for more {dessert} and took another hard sip of my good old {beer}.";

}


}
