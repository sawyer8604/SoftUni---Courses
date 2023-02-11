namespace _3.Telephony.Core
{
    using Core.Interfaces;
    using IO.Interfaces;
    using Models;
    using Models.Interfaces;
    using System;
   
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IStationaryPhone stationaryPhone;
        private readonly ISmartphone smartphone;

        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartphone = new Smartphone();
        }
        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        

        public void Run()
        {
            string[] phoneNumbers = this.reader.ReadLine().Split(" ");

            string[] urls = this.reader.ReadLine().Split(" ");

            foreach (var number in phoneNumbers)
            {
                try
                {
                    if (number.Length <= 7)
                    {
                        writer.WriteLn(stationaryPhone.Calling(number));
                    }
                    else
                    {
                        writer.WriteLn(smartphone.Calling(number));
                    }
                }
                catch (Exception ex)
                {

                    writer.WriteLn(ex.Message);
                }
               
            }

            foreach (var url in urls)
            {
                try
                {
                    writer.WriteLn(smartphone.Browsing(url));
                }
                catch (Exception ex)
                {

                    writer.WriteLn(ex.Message);
                }
               
            }
        }
    }
}
