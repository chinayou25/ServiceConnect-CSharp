﻿using System;
using PointToPoint.Messages;
using R.MessageBus;

namespace PointToPoint.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Producer ***********");
            var bus = Bus.Initialize(config => config.AddEndPointMapping(typeof(PointToPointMessage), "PointToPoint"));

            while (true)
            {
                Console.WriteLine("Press enter to send message");
                Console.ReadLine();

                var id = Guid.NewGuid();
                bus.Send(new PointToPointMessage(id));

                Console.WriteLine("Sent message - {0}", id);
                Console.WriteLine("");
            }
        }
    }
}