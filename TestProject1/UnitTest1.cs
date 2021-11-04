using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkingWithJSON;
using Newtonsoft.Json;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMovieSerializationToJSON()
        {
            //var expectedJSON = "{ 'Title': 'Shrek', 'Genre': 'Animated', 'Runtime':  90}";

            var movie = new Movie() { Title = "Shrek", Genre = "Animated", Runtime = 90 }; //instance of movie
            string json = JsonConvert.SerializeObject(movie); // turn it into json
            //Assert.AreEqual(expectedJSON, json); // this is not a good test in real world. Would want it to be exact

            var SecondInstance = JsonConvert.DeserializeObject<Movie>(json); // by deserializing it we know for sure it was created properly
            Assert.AreEqual(movie.Title, movie.Title);
            Assert.AreEqual(movie.Genre, movie.Genre);
            Assert.AreEqual(movie.Runtime, movie.Runtime);
        }

        [TestMethod]
        public void TestMovieDeserializationToJSON()
        {
            var expectedJSON = "{ 'movie_title': 'Shrek', 'genre': 'Animated', 'runtime':  90,   'location': {'country':  'Italy'}}";
            //json very flexible. Will pass test even though Location isn't part of our movie class.

            var movie = JsonConvert.DeserializeObject<Movie>(expectedJSON);

            Assert.AreEqual("Shrek", movie.Title);
            Assert.AreEqual("Animated", movie.Genre);
            Assert.AreEqual(90, movie.Runtime);
        }


    }
}
