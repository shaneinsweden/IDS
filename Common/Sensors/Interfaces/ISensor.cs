using System;
namespace Ids.Common.Sensors
{
    interface ISensor
    {
        void StartCapturing();
        void StopCapturing();

        string GetSensorId();
    }
}
