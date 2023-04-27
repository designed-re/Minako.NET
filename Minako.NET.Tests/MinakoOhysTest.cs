using Newtonsoft.Json;

namespace Minako.NET.Tests
{
    [TestClass]
    public class MinakoOhysTest
    {
        private readonly Minako _minako;
        public MinakoOhysTest()
        {
            _minako = new Minako();
        }

        [TestMethod]
        public async Task OhysIndex()
        {
            var res = await _minako.Ohys.GetOhysIndexAsync();
            Console.WriteLine(JsonConvert.SerializeObject(res));
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task OhysDetail()
        {
            var res = await _minako.Ohys.GetOhysIndexAsync();
            var res2 = await _minako.Ohys.GetOhysDetailAsync(res.Items.SingleOrDefault(x=> x.Title == "Oshi no Ko"));
            Console.WriteLine(JsonConvert.SerializeObject(res2));
            Assert.IsNotNull(res2);
        }
    }
}