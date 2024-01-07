using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IVehicle
    {

        // bujndan türüyen sınıf bu metodların tamamını doldurmalı
        void Run();
        void Stop();
        void Move(int speed);
        void Brake();
        int GasLevel();
    }
}
