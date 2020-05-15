using System.Collections.Generic;

using Android.App;
using Android.Content;

namespace WarThunderQuiz.GameData
{

    class TankCollection
    {
        public static List<Vehicle> GetTanks()
        {
            var context = Application.Context;
            var vehicles = new List<Vehicle>();
            Vehicle vehicle;
            vehicles.Clear();

            ///////////////////////////////////////////   США   ///////////////////////////////////////////

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m1a1,
                Name = "M1A1 Abrams",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m8,
                Name = "M8 HMC",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.us_m901_itv,
                Name = "M901",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.adats,
                Name = "ADATS",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t95e1,
                Name = "T95E1",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m163,
                Name = "M163",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m247,
                Name = "M247",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.merkava,
                Name = "Merkava Mk.1",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bradley,
                Name = "M3 Bradley",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m551,
                Name = "M551 Sheridan",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m60,
                Name = "M60",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m46,
                Name = "M46 Patton",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m47,
                Name = "M47 Patton II",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m50,
                Name = "M50 Ontos",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m42,
                Name = "M42 Duster",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t95,
                Name = "T95",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t114,
                Name = "T114",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ti34,
                Name = "T34",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m26t99,
                Name = "M26 T99",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m41a1,
                Name = "M41A1",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m56,
                Name = "M56 Scorpion",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t92,
                Name = "T92",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m4a2,
                Name = "M4A2(76)W",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m6a1,
                Name = "M6A1",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m15a1,
                Name = "M15A1 CGMC",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m18,
                Name = "M18 GMC",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.calliope,
                Name = "Calliope",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m24,
                Name = "M24 Chaffee",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m3,
                Name = "M3 Lee",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m4a3_105,
                Name = "M4A3(105)",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m10,
                Name = "M10 GMC",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.lvt_zis,
                Name = "LVT(A)-4 ZiS-2",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t18e2,
                Name = "T18E2 Boarhound",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.lvta1,
                Name = "LVT(A)-1",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m3stuart,
                Name = "M3 Stuart",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m2a2,
                Name = "M2A2",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.m3gmc,
                Name = "M3 GMC",
                Nation = "USA",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            ///////////////////////////////////////////   НІМЕЧЧИНА   ///////////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.panzerjager1,
                Name = "Panzerjager I",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sturmpanzer2,
                Name = "Sturmpanzer II",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pz2c,
                Name = "Pz.II C",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.flakpanzer1,
                Name = "Flakpanzer I",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pz35t,
                Name = "Pz.35(t)",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.aufklarungspanzer,
                Name = "Aufklärungspanzer 38(t)",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.nbfz,
                Name = "Neubaufahrzeug",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pz4e,
                Name = "Pz.IV E",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sdkfz234,
                Name = "Sd.Kfz.234/2",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.marder3,
                Name = "Marder III H",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.flak88,
                Name = "8,8 cm Flak 37 Sfl.",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pz3m,
                Name = "Pz.III M",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pz4f2,
                Name = "Pz.IV F2",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sdkfzaaa,
                Name = "Sd.Kfz. 6/2",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.stug42,
                Name = "StuH 42 G",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.panzerwerfer,
                Name = "15 cm Pz.W.42",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.dickermax,
                Name = "Dicker Max",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.nashorn,
                Name = "Nashorn",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.stureremil,
                Name = "Sturer Emil",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tigerh1,
                Name = "Tiger H1",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pz4h,
                Name = "Pz.IV H",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.wirbelwind,
                Name = "Wirbelwind",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ostwind,
                Name = "Ostwind",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ostwind2,
                Name = "Ostwind II",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hetzer,
                Name = "Jagdpanzer 38(t)",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.vfw,
                Name = "VFW",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.brummbar,
                Name = "Brummbär",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.vk4501,
                Name = "VK 45.01 (P)",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.waffentrager,
                Name = "Waffentrager",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tiger2p,
                Name = "Tiger II (P)",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tiger2h,
                Name = "Tiger II (H)",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pantherg,
                Name = "Panther G",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.panther2,
                Name = "Panther II",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.flakpanzer341,
                Name = "Flakpanzer 341",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jagdpanther,
                Name = "Bfw. Jagdpanther",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ferdinand,
                Name = "Ferdinand",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ru251,
                Name = "Ru 251",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jpz45,
                Name = "JPz 4-5",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.raketenjagdpanzer2,
                Name = "RakJPz 2",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.maus,
                Name = "Maus",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.leopard1,
                Name = "Leopard I",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kugelblitz,
                Name = "Kugelblitz",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jagdtiger,
                Name = "Jagdtiger",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.e100,
                Name = "E-100",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.raketenjagdpanzer2hot,
                Name = "RakJPz 2 (HOT)",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kpz70,
                Name = "KPz-70",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.leopard2k,
                Name = "Leopard 2K",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.leopard2a4,
                Name = "Leopard 2A4",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.leopard2a5,
                Name = "Leopard 2A5",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.flarakpz1,
                Name = "FlaRakPz 1",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.gepard,
                Name = "Gepard",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.begleitpanzer57,
                Name = "Begleitpanzer 57",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tam,
                Name = "TAM",
                Nation = "Germany",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            ///////////////////////////////////////////   СРСР   ///////////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bt5,
                Name = "BT-5",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t26,
                Name = "T-26",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t264,
                Name = "T-26-4",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t50,
                Name = "T-50",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su5,
                Name = "SU-5-1",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.gazaaa,
                Name = "GAZ-AAA (4M)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t35,
                Name = "T-35",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su57,
                Name = "SU-57",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bm824,
                Name = "BM-8-24",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.rbt5,
                Name = "RBT-5",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t341942,
                Name = "T-34 (1942)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.zis30,
                Name = "ZiS-30",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su122,
                Name = "SU-122",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.zis12,
                Name = "ZiS-12 (94-KM)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.btr152,
                Name = "BTR-152A",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.gazmm,
                Name = "GAZ-MM (72-K)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bm13n,
                Name = "BM-13N Katyusha",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.zut37,
                Name = "ZUT-37",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.smk,
                Name = "SMK",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kv239,
                Name = "KV-2 (1939)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kv1zis5,
                Name = "KV-1 (ZiS-5)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.asu57,
                Name = "ASU-57",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su57b,
                Name = "SU-57B",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su85,
                Name = "SU-85",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su152,
                Name = "SU-152",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.yag10k,
                Name = "YaG-10 (29-K)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su100y,
                Name = "SU-100Y",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kv2zis6,
                Name = "KV-2 (ZiS-6)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.typ65,
                Name = "Type 65",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kv220,
                Name = "KV-220",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t3485,
                Name = "T-34-85 (D-5T)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t44,
                Name = "T-44",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.is2,
                Name = "IS-2",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pt76,
                Name = "PT-76B",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.asu85,
                Name = "ASU-85",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su100p,
                Name = "SU-100P",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.zsu37,
                Name = "ZSU-37",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.isu122s,
                Name = "ISU-122S",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.obj120,
                Name = "Object 120",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.is6,
                Name = "IS-6",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.is7,
                Name = "IS-7",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.zsu57,
                Name = "ZSU-57-2",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.obj268,
                Name = "Object 268",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su12254,
                Name = "SU-122-54",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bmp1,
                Name = "BMP-1",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.is3,
                Name = "IS-3",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t54,
                Name = "T-54 (1951)",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t62m1,
                Name = "T-62M-1",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t72,
                Name = "T-72A",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t64b,
                Name = "T-64B",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t80u,
                Name = "T-80U",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bmp2,
                Name = "BMP-2",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.obj906,
                Name = "Object 906",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it1,
                Name = "IT-1",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.shturms,
                Name = "Shturm-S",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.shilka,
                Name = "ZSU-23-4",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.zprk2s6,
                Name = "ZPRK 2S6",
                Nation = "USSR",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            //////////////////////////////////////ВЕЛИКОБРИТАНІЯ///////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a_13_mk1,
                Name = "A13",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_crusader_mk_3,
                Name = "Crusader III",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a17_mk_1_tetrarch,
                Name = "Tetrarch I",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_daimler_mk_2,
                Name = "Daimler AC Mk II",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_valentine_mk_1,
                Name = "Valentine I",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_valentine_mk_11,
                Name = "Valentine XI",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_vickers_mk_6_aa_mk_1,
                Name = "Light AA Mk I",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_t17e2,
                Name = "T17E2",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a1e1_independent,
                Name = "A1 Independent",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a27m_cromwell_1,
                Name = "Cromwell I",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a_12_mk_2_matilda_2,
                Name = "Matilda III",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_3_inch_gun_carrier,
                Name = "3 inch Gun Carrier",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a_22b_mk_3_churchill_1942,
                Name = "Churchill III",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_sp_17_pdr_valentine,
                Name = "Archer I",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_armored_car_mk_2_aa,
                Name = "Armoured Car AA",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a27m_cromwell_5_rp3,
                Name = "Cromwell V with RP-3 missiles",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_ac4_thunderbolt,
                Name = "AC IV Thunderbolt",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a_43_black_prince,
                Name = "Black Prince",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_centurion_mk_3_ss11,
                Name = "Strv 81 Rb.52",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_centurion_mk_3,
                Name = "Centurion Mk 3",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_vickers_mbt_mk_1,
                Name = "Vickers MBT",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_conqueror_mk_2,
                Name = "Conqueror Mk 2",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_fv4202,
                Name = "FV4202",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_fv4005,
                Name = "FV4005",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_a39_tortoise,
                Name = "Tortoise",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_fv4004_conway,
                Name = "FV4004 Conway",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_falcon,
                Name = "Falcon",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_chieftain_mk_5,
                Name = "Chieftain Mk 5",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_challenger_ii,
                Name = "Challenger 2",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_fv510_isv,
                Name = "FV510 Warrior",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_fv102_striker,
                Name = "FV102 Striker",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_chieftain_marksman,
                Name = "Chieftain Marksman",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uk_stormer_hvm,
                Name = "Stormer HVM",
                Nation = "GB",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            /////////////////////////////////////ЯПОНІЯ//////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_98_ke_ni,
                Name = "Type 98 Ke-Ni",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_2_ka_mi,
                Name = "Type 2 Ka-Mi",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_89b_i_go_otsu,
                Name = "Type 89 I-Go Ko",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_97_kai,
                Name = "Type 97 Chi-Ha Kai",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_4_ho_ro,
                Name = "Type 4 Ho-Ro",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_94,
                Name = "Isuzu Type 94 AA",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_95_ha_go_commander,
                Name = "Type 95 Ha-Go",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_3_chi_nu,
                Name = "Type 3 Chi-Nu",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_98_ta_se,
                Name = "Ta-Se",
                Nation = "Japan",
                PeriodOfTime = 2,
                Character = "Tank"
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_97_chi_ha_12cm,
                Name = "Chi-Ha Naval Short  ",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_5_na_to,
                Name = "Na-To",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_95_so_ki,
                Name = "So-Ki",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_st_a1,
                Name = "ST-A1",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_61,
                Name = "Type 61",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_5_ho_ri_prototype,
                Name = "Ho-Ri Prototype",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_75_mlrs,
                Name = "Type 75 MLRS",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_60_sprg,
                Name = "Type 60 SPRG",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_60_atm,
                Name = "Type 60 ATM ",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_89,
                Name = "Type 89",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_st_b1,
                Name = "STB-1",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_74,
                Name = "Type 74",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_90,
                Name = "Type 90",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_75,
                Name = "Type 75 SPH",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jp_type_16,
                Name = "Type 16",
                Nation = "Japan",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            ///////////////////////////////////////ІТАЛІЯ///////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_ab_41,
                Name = "AB 41",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sidam25mistral,
                Name = "SIDAM 25 (Mistral)",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_as_42_metropolitana,
                Name = "AS 42",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_m13_40_serie_1,
                Name = "M13/40 (I)",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_l3_cc,
                Name = "L3/33 CC",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_semovente_l40,
                Name = "47/32 L40",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_semovente_m41m_90,
                Name = "90/53 M41M",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_m15_42_contraereo,
                Name = "M42 Contraereo",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_semovente_breda_501,
                Name = "Breda 501",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_oto_r3_t20_fa,
                Name = "R3 T20 FA-HS",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_semovente_m43_105,
                Name = "Semovente 105/25 M43",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_fiat_6614_106sr,
                Name = "FIAT 6614",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_oto_r3_106sr,
                Name = "R3 T106 FA",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_aubl_74_60_70m,
                Name = "AUBL/74 HVG",
                Nation = "Italy",
                Character = "Tank"
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_b1_centauro,
                Name = "Centauro",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_of_40_mk_2a,
                Name = "OF-40 Mk.2A",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_otobreda_sidam_25,
                Name = "SIDAM 25",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_m113a1_tow,
                Name = "M113A1 (TOW)",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_otomatic,
                Name = "OTOMATIC",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.it_c1_ariete,
                Name = "C1 Ariete",
                Nation = "Italy",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_hotchkiss_h35,
                Name = "Hotchkiss H 35",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_fcm_36,
                Name = "FCM 36",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_citroen_kegresse_p4t,
                Name = "P7T Antiaérien",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amr_35_zt3,
                Name = "AMR 35 ZT 3",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_b1_bis,
                Name = "Char B1 bis",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_somua_sau40,
                Name = "SOMUA SAu 40",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_b1_ter,
                Name = "Char B1 ter",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_13_fl_11,
                Name = "AMX 13 FL 11",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_arl_44_acl1,
                Name = "ARL 44",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_cckw_353_bofors,
                Name = "CCKW 353",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_lorraine_155,
                Name = "Lorraine 155 mle. 50",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_13_75,
                Name = "AMX 13",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_bat_chat_25t,
                Name = "Char 25t",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_lorraine_40t,
                Name = "Lorraine 40 t",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_13_dca_40,
                Name = "AMX 13 DCA 40",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_13_75_ss11,
                Name = "AMX 13 SS.11",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_30_1972,
                Name = "AMX 30 mle. 1972",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_50_surbaisse,
                Name = "AMX 50 Surbaissé",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_50_foch,
                Name = "AMX 50 Foch",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_13_hot,
                Name = "AMX 13 HOT",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_30_b2_brenus,
                Name = "AMX 30 B2 BRENUS",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_40,
                Name = "AMX 40",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_10rc,
                Name = "AMX-10RC",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_amx_30_roland,
                Name = "Roland 1",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fr_leclerc_s1,
                Name = "Leclerc",
                Nation = "France",
                Character = "Tank",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);




            return vehicles;
        }
    }
}