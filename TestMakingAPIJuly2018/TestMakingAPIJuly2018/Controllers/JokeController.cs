using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestMakingAPIJuly2018.Controllers
{
    public class JokeController : ApiController
    {
        [HttpGet] // attribute 
        public string DadJokes()
        {
            string[] dadJokes = { "Dad, did you get a haircut? No I got them all cut.",
            "Can I watch the TV? Dad: Yes, but don’t turn it on.",
            "What do you call a fake noodle? An Impasta.",
            "What’s brown and sticky? A stick."};
            // use a random number to select a joke
            Random r = new Random();
            int selected = r.Next(0,dadJokes.Length);

            // return the selected joke 

            return dadJokes[selected];
        }
    }
}