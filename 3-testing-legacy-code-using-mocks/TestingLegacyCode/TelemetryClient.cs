﻿
using System;

namespace Telemetry.Services
{


    public class TelemetryClient
    {
        private readonly ITelemetryCollector _telemetryCollector;
        private readonly Func<string, ITelemetryProcessor> _processorFactory;
        private readonly IScheduler _scheduler;

        public TelemetryClient(ITelemetryCollector telemetryCollector, IScheduler scheduler, Func<string, ITelemetryProcessor> processorFactory)
        {
            _telemetryCollector = telemetryCollector;
            _processorFactory = processorFactory;
            _scheduler = scheduler;
        }
        
        public event EventHandler<EventArgs> ErrorDetected;
        
        private void GetDataFromCollector()
        {
            var telemetries = _telemetryCollector.Collect();

            foreach (var item in telemetries)
            {
                _processorFactory(item.Kind).Process(item);
                
            }
                

        }

        public void Start()
        {
            _scheduler.Elapsed += _scheduler_Elapsed;
            _scheduler.Start();
        }

        private void _scheduler_Elapsed(object sender, EventArgs e)
        {
            GetDataFromCollector();
        }
        

        public void Stop()
        {
            _scheduler.Stop();
        }
    }
}
