using System;

namespace Chain_Of_Responsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Car first = new PrimaryCheck();
            Car second = new VehicleAssemblyCheck();
            Car third = new ElecticityCheck();
            Car fourth = new ExpertDiagnostic();

            first.SetNext(second);
            second.SetNext(third);
            third.SetNext(fourth);
            fourth.SetNext(null);

            first.HandleRequest();
        }
    }
}
