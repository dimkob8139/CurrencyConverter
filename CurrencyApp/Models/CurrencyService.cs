using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;

namespace CurrencyApp.Models
{
    public class CurrencyService : BackgroundService
    {
        private readonly IMemoryCache memoryCache;

        public CurrencyService(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    //так как эта задача выполняется в другом потоке, то велика вероятность, что
                    //культура по умолчанию может отличаться от той, которая установлена в нашем приложении,
                    //поэтому явно укажем нужную нам, чтобы не было проблем с разделителями, названиями и т.д.
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ua-UA"); // <== нужная вам культура

                    //кодировка файла xml с сайта НБУ == windows-1251
                    //по умолчанию она недоступна в .NET Core, поэтому регистрируем нужный провайдер 
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    //т.к. мы знаем что данные к нам приходят именно в файле, именно в формате XML,
                    //поэтому нет необходимости использовать WebRequest,
                    //используем в работе класс XDocument и сразу забираем файл с удаленного сервера
                    XDocument xml = XDocument.Load("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");

                    //далее парсим файл и находим нужные нам валюты по их коду ID, и заполняем класс-модель
                    CurrencyConverter curencyConverter = new CurrencyConverter();
                    curencyConverter.USD = Convert.ToDecimal
                        (
                        xml.Elements("exchange")
                        .Elements("currency")
                        .FirstOrDefault(x => x.Element("r030").Value == "840")
                        .Elements("rate").FirstOrDefault().Value);


                    curencyConverter.EUR = Convert.ToDecimal
                       (
                             xml.Elements("exchange")
                                    .Elements("currency")
                                    .FirstOrDefault(x => x.Element("r030").Value == "978")
                                      .Elements("rate")
                                       .FirstOrDefault().Value
                       );

                    curencyConverter.AUD = Convert.ToDecimal
                      (
                            xml.Elements("exchange")
                                   .Elements("currency")
                                   .FirstOrDefault(x => x.Element("r030")
                                    .Value == "36")
                                     .Elements("rate")
                                      .FirstOrDefault().Value
                      );

                    curencyConverter.CNY = Convert.ToDecimal
                      (
                            xml.Elements("exchange")
                                   .Elements("currency")
                                   .FirstOrDefault(x => x.Element("r030")
                                    .Value == "156")
                                     .Elements("rate")
                                      .FirstOrDefault().Value
                      );

                    curencyConverter.SEK = Convert.ToDecimal
                      (
                            xml.Elements("exchange")
                                   .Elements("currency")
                                   .FirstOrDefault(x => x.Element("r030")
                                    .Value == "752")
                                     .Elements("rate")
                                      .FirstOrDefault().Value
                      );

                    memoryCache.Set("key_currency", curencyConverter, TimeSpan.FromMinutes(1440));
                }
                catch (Exception e)
                {
                    //logger.LogError(e.InnerException.Message);
                }

                //если указаний о завершении данной задачи не поступало,
                //то запрашиваем обновление данных каждый час
                await Task.Delay(3600000, stoppingToken);
            }
        }
    }
}
