using System.Reflection.Metadata.Ecma335;

namespace AdapterPattern
{
    public class Adapter : IAdapter
    {
        private StockMarketService _stockMarketService;

        public Adapter(StockMarketService stockMarketService)
        {
            _stockMarketService = stockMarketService;
        }
        public string GetJsonData()
        {
            var data = _stockMarketService.GetXmlData();

            return ConvertXmlToJson(data);
        }

        public string ConvertXmlToJson(string data)
        {
            return "returning JSON data...";
        }
    }
}