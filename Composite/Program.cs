using Composite.Basic;
using Composite.Company;
using System;
using System.Linq;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSoftwareTesting();
        }

        public static void BasicComposite()
        {
            Client client = new Client();
            client.BasicComposite();
        }

        public static void Company()
        {
            CompanyClient.Run();
        }

        public static void CarSoftwareTesting()
        {
            Component entirePackage = new Component("Complete Car","v1",SwType.Complete);
            
            Component infotainmentFunctional = new Component("Infotaintmnet", "v1", SwType.Functional);
            Component mediaDomain = new Component("Media", "v1", SwType.Domain);
            Component bluetoothDomain = new Component("Bluetooth", "v1", SwType.Domain);
            Component radioDomain = new Component("Radio", "v1", SwType.Domain);
            infotainmentFunctional.Add(mediaDomain, bluetoothDomain, radioDomain);

            Component safetyFunctional = new Component("Safety", "v1", SwType.Functional);
            Component frontSafetyDomain = new Component("Front Safety", "v1", SwType.Domain);
            Component backSafetyDomain = new Component("Back Safety", "v1", SwType.Domain);
            safetyFunctional.Add(frontSafetyDomain, backSafetyDomain);

            Component coreFunctional = new Component("Core", "v1", SwType.Functional);
            Component engineDomain = new Component("Engine", "v1", SwType.Domain);
            Component gearBoxDomain = new Component("Gear Box", "v1", SwType.Domain);
            coreFunctional.Add(engineDomain, gearBoxDomain);

            entirePackage.Add(infotainmentFunctional, safetyFunctional, coreFunctional);

            Component mediaSection1 = new Component("media Section1","v1",SwType.Section);
            Component mediaSection2 = new Component("media Section2", "v1", SwType.Section);
            mediaDomain.Add(mediaSection1, mediaSection2);

            Component bluetoothSection1 = new Component("bluetooth Section1", "v1", SwType.Section);
            Component bluetoothSection2 = new Component("bluetooth Section2", "v1", SwType.Section);
            bluetoothDomain.Add(bluetoothSection1, bluetoothSection2);

            Component radioSection1 = new Component("radio Section1", "v1", SwType.Section);
            Component radioSection2 = new Component("radio Section2", "v1", SwType.Section);
            radioDomain.Add(radioSection1, radioSection2);

            Component frontSafetySection1 = new Component("front safety Section1", "v1", SwType.Section);
            Component frontSafetySection2 = new Component("front safety Section2", "v1", SwType.Section);
            frontSafetyDomain.Add(frontSafetySection1, frontSafetySection2);

            Component backSafetySection1 = new Component("back safety Section1", "v1", SwType.Section);
            Component backSafetySection2 = new Component("back safety Section2", "v1", SwType.Section);
            backSafetyDomain.Add(backSafetySection1, backSafetySection2);

            Component engineSection1 = new Component("engine Section1", "v1", SwType.Section);
            Component engineSection2 = new Component("engine Section2", "v1", SwType.Section);
            engineDomain.Add(engineSection1, engineSection2);

            Component gearBoxSection1 = new Component("radio Section1", "v1", SwType.Section);
            Component gearBoxSection2 = new Component("radio Section2", "v1", SwType.Section);
            gearBoxDomain.Add(gearBoxSection1, gearBoxSection2);

            Unit mediaUnit1 = new Unit("media unit 1", "v1", SwType.Unit);
            Unit mediaUnit2 = new Unit("media unit 2", "v1", SwType.Unit);
            Unit mediaUnit3 = new Unit("media unit 3", "v1", SwType.Unit);
            Unit mediaUnit4 = new Unit("media unit 4", "v1", SwType.Unit);

            mediaSection1.Add(mediaUnit1, mediaUnit2);
            mediaSection2.Add(mediaUnit3, mediaUnit4);

            Unit bluetoothUnit1 = new Unit("bluetooth unit 1", "v1", SwType.Unit);
            Unit bluetoothUnit2 = new Unit("bluetooth unit 2", "v1", SwType.Unit);
            Unit bluetoothUnit3 = new Unit("bluetooth unit 3", "v1", SwType.Unit);
            Unit bluetoothUnit4 = new Unit("bluetooth unit 4", "v1", SwType.Unit);

            bluetoothSection1.Add(bluetoothUnit1, bluetoothUnit2);
            bluetoothSection2.Add(bluetoothUnit3, bluetoothUnit4);

            Unit radioUnit1 = new Unit("radio unit 1", "v1", SwType.Unit);
            Unit radioUnit2 = new Unit("radio unit 2", "v1", SwType.Unit);
            Unit radioUnit3 = new Unit("radio unit 3", "v1", SwType.Unit);
            Unit radioUnit4 = new Unit("radio unit 4", "v1", SwType.Unit);

            radioSection1.Add(radioUnit1, radioUnit2);
            radioSection2.Add(radioUnit3, radioUnit4);

            Unit frontSafetyUnit1 = new Unit("frontSafety unit 1", "v1", SwType.Unit);
            Unit frontSafetyUnit2 = new Unit("frontSafety unit 2", "v1", SwType.Unit);
            Unit frontSafetyUnit3 = new Unit("frontSafety unit 3", "v1", SwType.Unit);
            Unit frontSafetyUnit4 = new Unit("frontSafety unit 4", "v1", SwType.Unit);

            frontSafetySection1.Add(frontSafetyUnit1, frontSafetyUnit2);
            frontSafetySection2.Add(frontSafetyUnit3, frontSafetyUnit4);

            Unit backSafetyUnit1 = new Unit("backSafety unit 1", "v1", SwType.Unit);
            Unit backSafetyUnit2 = new Unit("backSafety unit 2", "v1", SwType.Unit);
            Unit backSafetyUnit3 = new Unit("backSafety unit 3", "v1", SwType.Unit);
            Unit backSafetyUnit4 = new Unit("backSafety unit 4", "v1", SwType.Unit);

            backSafetySection1.Add(backSafetyUnit1, backSafetyUnit2);
            backSafetySection2.Add(backSafetyUnit3, backSafetyUnit4);

            Unit engineUnit1 = new Unit("engine unit 1", "v1", SwType.Unit);
            Unit engineUnit2 = new Unit("engine unit 2", "v1", SwType.Unit);
            Unit engineUnit3 = new Unit("engine unit 3", "v1", SwType.Unit);
            Unit engineUnit4 = new Unit("engine unit 4", "v1", SwType.Unit);

            engineSection1.Add(engineUnit1, engineUnit2);
            engineSection2.Add(engineUnit3, engineUnit4);

            Unit gearBoxUnit1 = new Unit("gearBox unit 1", "v1", SwType.Unit);
            Unit gearBoxUnit2 = new Unit("gearBox unit 2", "v1", SwType.Unit);
            Unit gearBoxUnit3 = new Unit("gearBox unit 3", "v1", SwType.Unit);
            Unit gearBoxUnit4 = new Unit("gearBox unit 4", "v1", SwType.Unit);

            gearBoxSection1.Add(gearBoxUnit1, gearBoxUnit2);
            gearBoxSection2.Add(gearBoxUnit3, gearBoxUnit4);

            //var software = entirePackage.Search("Back Safety");
            //Console.WriteLine(software.ToString());

            entirePackage.GetTestingStatus();
            entirePackage.RunTests();
            entirePackage.GetTestingStatus();

            Console.ReadLine();



        }


    }

}
