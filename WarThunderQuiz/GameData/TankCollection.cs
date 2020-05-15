using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WarThunderQuiz.GameData
{

    class TankCollection
    {
        public static List<Vehicle> GetTanks()
        {
            Context context = Application.Context;
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehicle;
            vehicles.Clear();

            ///////////////////////////////////////////   США   ///////////////////////////////////////////

            vehicle = new Vehicle();
            vehicle.Image= Resource.Drawable.m1a1;
            vehicle.Name = "M1A1 Abrams";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m8;
            vehicle.Name = "M8 HMC";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.us_m901_itv;
            vehicle.Name = "M901";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);
            

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.adats;
            vehicle.Name = "ADATS";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t95e1;
            vehicle.Name = "T95E1";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m163;
            vehicle.Name = "M163";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m247;
            vehicle.Name = "M247";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.merkava;
            vehicle.Name = "Merkava Mk.1";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bradley;
            vehicle.Name = "M3 Bradley";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m551;
            vehicle.Name = "M551 Sheridan";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m60;
            vehicle.Name = "M60";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m46;
            vehicle.Name = "M46 Patton";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m47;
            vehicle.Name = "M47 Patton II";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m50;
            vehicle.Name = "M50 Ontos";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m42;
            vehicle.Name = "M42 Duster";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t95;
            vehicle.Name = "T95";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t114;
            vehicle.Name = "T114";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ti34;
            vehicle.Name = "T34";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m26t99;
            vehicle.Name = "M26 T99";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m41a1;
            vehicle.Name = "M41A1";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m56;
            vehicle.Name = "M56 Scorpion";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t92;
            vehicle.Name = "T92";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m4a2;
            vehicle.Name = "M4A2(76)W";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m6a1;
            vehicle.Name = "M6A1";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m15a1;
            vehicle.Name = "M15A1 CGMC";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m18;
            vehicle.Name = "M18 GMC";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.calliope;
            vehicle.Name = "Calliope";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m24;
            vehicle.Name = "M24 Chaffee";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m3;
            vehicle.Name = "M3 Lee";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m4a3_105;
            vehicle.Name = "M4A3(105)";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m10;
            vehicle.Name = "M10 GMC";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.lvt_zis;
            vehicle.Name = "LVT(A)-4 ZiS-2";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t18e2;
            vehicle.Name = "T18E2 Boarhound";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.lvta1;
            vehicle.Name = "LVT(A)-1";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m3stuart;
            vehicle.Name = "M3 Stuart";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m2a2;
            vehicle.Name = "M2A2";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.m3gmc;
            vehicle.Name = "M3 GMC";
            vehicle.Nation = "USA";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            ///////////////////////////////////////////   НІМЕЧЧИНА   ///////////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.panzerjager1;
            vehicle.Name = "Panzerjager I";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sturmpanzer2;
            vehicle.Name = "Sturmpanzer II";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pz2c;
            vehicle.Name = "Pz.II C";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.flakpanzer1;
            vehicle.Name = "Flakpanzer I";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pz35t;
            vehicle.Name = "Pz.35(t)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.aufklarungspanzer;
            vehicle.Name = "Aufklärungspanzer 38(t)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.nbfz;
            vehicle.Name = "Neubaufahrzeug";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pz4e;
            vehicle.Name = "Pz.IV E";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sdkfz234;
            vehicle.Name = "Sd.Kfz.234/2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.marder3;
            vehicle.Name = "Marder III H";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.flak88;
            vehicle.Name = "8,8 cm Flak 37 Sfl.";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pz3m;
            vehicle.Name = "Pz.III M";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pz4f2;
            vehicle.Name = "Pz.IV F2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sdkfzaaa;
            vehicle.Name = "Sd.Kfz. 6/2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.stug42;
            vehicle.Name = "StuH 42 G";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.panzerwerfer;
            vehicle.Name = "15 cm Pz.W.42";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.dickermax;
            vehicle.Name = "Dicker Max";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.nashorn;
            vehicle.Name = "Nashorn";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.stureremil;
            vehicle.Name = "Sturer Emil";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tigerh1;
            vehicle.Name = "Tiger H1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pz4h;
            vehicle.Name = "Pz.IV H";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.wirbelwind;
            vehicle.Name = "Wirbelwind";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ostwind;
            vehicle.Name = "Ostwind";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ostwind2;
            vehicle.Name = "Ostwind II";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hetzer;
            vehicle.Name = "Jagdpanzer 38(t)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.vfw;
            vehicle.Name = "VFW";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.brummbar;
            vehicle.Name = "Brummbär";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.vk4501;
            vehicle.Name = "VK 45.01 (P)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.waffentrager;
            vehicle.Name = "Waffentrager";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tiger2p;
            vehicle.Name = "Tiger II (P)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tiger2h;
            vehicle.Name = "Tiger II (H)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pantherg;
            vehicle.Name = "Panther G";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.panther2;
            vehicle.Name = "Panther II";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.flakpanzer341;
            vehicle.Name = "Flakpanzer 341";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jagdpanther;
            vehicle.Name = "Bfw. Jagdpanther";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ferdinand;
            vehicle.Name = "Ferdinand";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ru251;
            vehicle.Name = "Ru 251";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jpz45;
            vehicle.Name = "JPz 4-5";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.raketenjagdpanzer2;
            vehicle.Name = "RakJPz 2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.maus;
            vehicle.Name = "Maus";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.leopard1;
            vehicle.Name = "Leopard I";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kugelblitz;
            vehicle.Name = "Kugelblitz";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jagdtiger;
            vehicle.Name = "Jagdtiger";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.e100;
            vehicle.Name = "E-100";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.raketenjagdpanzer2hot;
            vehicle.Name = "RakJPz 2 (HOT)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kpz70;
            vehicle.Name = "KPz-70";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.leopard2k;
            vehicle.Name = "Leopard 2K";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.leopard2a4;
            vehicle.Name = "Leopard 2A4";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.leopard2a5;
            vehicle.Name = "Leopard 2A5";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.flarakpz1;
            vehicle.Name = "FlaRakPz 1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.gepard;
            vehicle.Name = "Gepard";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.begleitpanzer57;
            vehicle.Name = "Begleitpanzer 57";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tam;
            vehicle.Name = "TAM";
            vehicle.Nation = "Germany";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            ///////////////////////////////////////////   СРСР   ///////////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bt5;
            vehicle.Name = "BT-5";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t26;
            vehicle.Name = "T-26";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t264;
            vehicle.Name = "T-26-4";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t50;
            vehicle.Name = "T-50";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su5;
            vehicle.Name = "SU-5-1";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.gazaaa;
            vehicle.Name = "GAZ-AAA (4M)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t35;
            vehicle.Name = "T-35";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su57;
            vehicle.Name = "SU-57";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bm824;
            vehicle.Name = "BM-8-24";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.rbt5;
            vehicle.Name = "RBT-5";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t341942;
            vehicle.Name = "T-34 (1942)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.zis30;
            vehicle.Name = "ZiS-30";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su122;
            vehicle.Name = "SU-122";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.zis12;
            vehicle.Name = "ZiS-12 (94-KM)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.btr152;
            vehicle.Name = "BTR-152A";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.gazmm;
            vehicle.Name = "GAZ-MM (72-K)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bm13n;
            vehicle.Name = "BM-13N Katyusha";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.zut37;
            vehicle.Name = "ZUT-37";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.smk;
            vehicle.Name = "SMK";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kv239;
            vehicle.Name = "KV-2 (1939)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kv1zis5;
            vehicle.Name = "KV-1 (ZiS-5)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.asu57;
            vehicle.Name = "ASU-57";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su57b;
            vehicle.Name = "SU-57B";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su85;
            vehicle.Name = "SU-85";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su152;
            vehicle.Name = "SU-152";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.yag10k;
            vehicle.Name = "YaG-10 (29-K)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su100y;
            vehicle.Name = "SU-100Y";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kv2zis6;
            vehicle.Name = "KV-2 (ZiS-6)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.typ65;
            vehicle.Name = "Type 65";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kv220;
            vehicle.Name = "KV-220";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t3485;
            vehicle.Name = "T-34-85 (D-5T)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t44;
            vehicle.Name = "T-44";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.is2;
            vehicle.Name = "IS-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pt76;
            vehicle.Name = "PT-76B";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.asu85;
            vehicle.Name = "ASU-85";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su100p;
            vehicle.Name = "SU-100P";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.zsu37;
            vehicle.Name = "ZSU-37";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.isu122s;
            vehicle.Name = "ISU-122S";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.obj120;
            vehicle.Name = "Object 120";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.is6;
            vehicle.Name = "IS-6";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.is7;
            vehicle.Name = "IS-7";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.zsu57;
            vehicle.Name = "ZSU-57-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.obj268;
            vehicle.Name = "Object 268";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su12254;
            vehicle.Name = "SU-122-54";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bmp1;
            vehicle.Name = "BMP-1";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.is3;
            vehicle.Name = "IS-3";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t54;
            vehicle.Name = "T-54 (1951)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t62m1;
            vehicle.Name = "T-62M-1";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t72;
            vehicle.Name = "T-72A";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t64b;
            vehicle.Name = "T-64B";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t80u;
            vehicle.Name = "T-80U";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bmp2;
            vehicle.Name = "BMP-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.obj906;
            vehicle.Name = "Object 906";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it1;
            vehicle.Name = "IT-1";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.shturms;
            vehicle.Name = "Shturm-S";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.shilka;
            vehicle.Name = "ZSU-23-4";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.zprk2s6;
            vehicle.Name = "ZPRK 2S6";
            vehicle.Nation = "USSR";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            //////////////////////////////////////ВЕЛИКОБРИТАНІЯ///////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a_13_mk1;
            vehicle.Name = "A13";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_crusader_mk_3;
            vehicle.Name = "Crusader III";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a17_mk_1_tetrarch;
            vehicle.Name = "Tetrarch I";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_daimler_mk_2;
            vehicle.Name = "Daimler AC Mk II";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_valentine_mk_1;
            vehicle.Name = "Valentine I";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_valentine_mk_11;
            vehicle.Name = "Valentine XI";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_vickers_mk_6_aa_mk_1;
            vehicle.Name = "Light AA Mk I";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_t17e2;
            vehicle.Name = "T17E2";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a1e1_independent;
            vehicle.Name = "A1 Independent";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a27m_cromwell_1;
            vehicle.Name = "Cromwell I";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a_12_mk_2_matilda_2;
            vehicle.Name = "Matilda III";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_3_inch_gun_carrier;
            vehicle.Name = "3 inch Gun Carrier";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a_22b_mk_3_churchill_1942;
            vehicle.Name = "Churchill III";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_sp_17_pdr_valentine;
            vehicle.Name = "Archer I";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_armored_car_mk_2_aa;
            vehicle.Name = "Armoured Car AA";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a27m_cromwell_5_rp3;
            vehicle.Name = "Cromwell V with RP-3 missiles";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_ac4_thunderbolt;
            vehicle.Name = "AC IV Thunderbolt";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a_43_black_prince;
            vehicle.Name = "Black Prince";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_centurion_mk_3_ss11;
            vehicle.Name = "Strv 81 Rb.52";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_centurion_mk_3;
            vehicle.Name = "Centurion Mk 3";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_vickers_mbt_mk_1;
            vehicle.Name = "Vickers MBT";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_conqueror_mk_2;
            vehicle.Name = "Conqueror Mk 2";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_fv4202;
            vehicle.Name = "FV4202";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_fv4005;
            vehicle.Name = "FV4005";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_a39_tortoise;
            vehicle.Name = "Tortoise";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_fv4004_conway;
            vehicle.Name = "FV4004 Conway";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_falcon;
            vehicle.Name = "Falcon";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_chieftain_mk_5;
            vehicle.Name = "Chieftain Mk 5";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_challenger_ii;
            vehicle.Name = "Challenger 2";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_fv510_isv;
            vehicle.Name = "FV510 Warrior";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_fv102_striker;
            vehicle.Name = "FV102 Striker";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_chieftain_marksman;
            vehicle.Name = "Chieftain Marksman";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uk_stormer_hvm;
            vehicle.Name = "Stormer HVM";
            vehicle.Nation = "GB";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            /////////////////////////////////////ЯПОНІЯ//////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_98_ke_ni;
            vehicle.Name = "Type 98 Ke-Ni";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_2_ka_mi;
            vehicle.Name = "Type 2 Ka-Mi";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_89b_i_go_otsu;
            vehicle.Name = "Type 89 I-Go Ko";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_97_kai;
            vehicle.Name = "Type 97 Chi-Ha Kai";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_4_ho_ro;
            vehicle.Name = "Type 4 Ho-Ro";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_94;
            vehicle.Name = "Isuzu Type 94 AA";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_95_ha_go_commander;
            vehicle.Name = "Type 95 Ha-Go";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_3_chi_nu;
            vehicle.Name = "Type 3 Chi-Nu";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_98_ta_se;
            vehicle.Name = "Ta-Se";
            vehicle.Nation = "Japan";
            vehicle.PeriodOfTime = 2;
            vehicle.Character = "Tank";
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_97_chi_ha_12cm;
            vehicle.Name = "Chi-Ha Naval Short  ";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_5_na_to;
            vehicle.Name = "Na-To";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_95_so_ki;
            vehicle.Name = "So-Ki";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_st_a1;
            vehicle.Name = "ST-A1";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_61;
            vehicle.Name = "Type 61";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_5_ho_ri_prototype;
            vehicle.Name = "Ho-Ri Prototype";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_75_mlrs;
            vehicle.Name = "Type 75 MLRS";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_60_sprg;
            vehicle.Name = "Type 60 SPRG";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_60_atm;
            vehicle.Name = "Type 60 ATM ";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_89;
            vehicle.Name = "Type 89";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_st_b1;
            vehicle.Name = "STB-1";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_74;
            vehicle.Name = "Type 74";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_90;
            vehicle.Name = "Type 90";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_75;
            vehicle.Name = "Type 75 SPH";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jp_type_16;
            vehicle.Name = "Type 16";
            vehicle.Nation = "Japan";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            ///////////////////////////////////////ІТАЛІЯ///////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_ab_41;
            vehicle.Name = "AB 41";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sidam25mistral;
            vehicle.Name = "SIDAM 25 (Mistral)";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_as_42_metropolitana;
            vehicle.Name = "AS 42";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_m13_40_serie_1;
            vehicle.Name = "M13/40 (I)";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_l3_cc;
            vehicle.Name = "L3/33 CC";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_semovente_l40;
            vehicle.Name = "47/32 L40";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_semovente_m41m_90;
            vehicle.Name = "90/53 M41M";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_m15_42_contraereo;
            vehicle.Name = "M42 Contraereo";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_semovente_breda_501;
            vehicle.Name = "Breda 501";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_oto_r3_t20_fa;
            vehicle.Name = "R3 T20 FA-HS";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_semovente_m43_105;
            vehicle.Name = "Semovente 105/25 M43";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_fiat_6614_106sr;
            vehicle.Name = "FIAT 6614";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_oto_r3_106sr;
            vehicle.Name = "R3 T106 FA";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_aubl_74_60_70m;
            vehicle.Name = "AUBL/74 HVG";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_b1_centauro;
            vehicle.Name = "Centauro";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_of_40_mk_2a;
            vehicle.Name = "OF-40 Mk.2A";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_otobreda_sidam_25;
            vehicle.Name = "SIDAM 25";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_m113a1_tow;
            vehicle.Name = "M113A1 (TOW)";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_otomatic;
            vehicle.Name = "OTOMATIC";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.it_c1_ariete;
            vehicle.Name = "C1 Ariete";
            vehicle.Nation = "Italy";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_hotchkiss_h35;
            vehicle.Name = "Hotchkiss H 35";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_fcm_36;
            vehicle.Name = "FCM 36";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_citroen_kegresse_p4t;
            vehicle.Name = "P7T Antiaérien";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amr_35_zt3;
            vehicle.Name = "AMR 35 ZT 3";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_b1_bis;
            vehicle.Name = "Char B1 bis";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_somua_sau40;
            vehicle.Name = "SOMUA SAu 40";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_b1_ter;
            vehicle.Name = "Char B1 ter";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_13_fl_11;
            vehicle.Name = "AMX 13 FL 11";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_arl_44_acl1;
            vehicle.Name = "ARL 44";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_cckw_353_bofors;
            vehicle.Name = "CCKW 353";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_lorraine_155;
            vehicle.Name = "Lorraine 155 mle. 50";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_13_75;
            vehicle.Name = "AMX 13";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_bat_chat_25t;
            vehicle.Name = "Char 25t";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_lorraine_40t;
            vehicle.Name = "Lorraine 40 t";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_13_dca_40;
            vehicle.Name = "AMX 13 DCA 40";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_13_75_ss11;
            vehicle.Name = "AMX 13 SS.11";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_30_1972;
            vehicle.Name = "AMX 30 mle. 1972";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_50_surbaisse;
            vehicle.Name = "AMX 50 Surbaissé";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_50_foch;
            vehicle.Name = "AMX 50 Foch";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_13_hot;
            vehicle.Name = "AMX 13 HOT";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_30_b2_brenus;
            vehicle.Name = "AMX 30 B2 BRENUS";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_40;
            vehicle.Name = "AMX 40";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_10rc;
            vehicle.Name = "AMX-10RC";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_amx_30_roland;
            vehicle.Name = "Roland 1";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fr_leclerc_s1;
            vehicle.Name = "Leclerc";
            vehicle.Nation = "France";
            vehicle.Character = "Tank";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);




            return vehicles;
        }
    }
}