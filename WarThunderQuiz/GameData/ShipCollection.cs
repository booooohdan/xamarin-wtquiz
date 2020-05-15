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
    class ShipCollection
    {
        public static List<Vehicle> GetShips()
        {
            Context context = Application.Context;
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehicle;
            vehicles.Clear();

            ///////////////////////////////////////////   США   ///////////////////////////////////////////

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.higgins81;
            vehicle.Name = "Higgins 81 ft PT-6";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.nasty80;
            vehicle.Name = "80 ft Nasty";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

               
            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sc497;
            vehicle.Name = "110 ft SC-497";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pc451;
            vehicle.Name = "165 ft PC-451";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pt3;
            vehicle.Name = "58 ft PT-3";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.eclo77pt59;
            vehicle.Name = "Elco 77 ft PT-59";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.higgins78pt200;
            vehicle.Name = "Higgins 78 ft PT-200";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pgh2;
            vehicle.Name = "PGH-2";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pt810;
            vehicle.Name = "89 ft PT-810";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.lcs3;
            vehicle.Name = "LCS(L)(3)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pgm84;
            vehicle.Name = "Asheville (PGM-84)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            
            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.clemson;
            vehicle.Name = "Clemson (DD-336)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.farragut;
            vehicle.Name = "Farragut (DD-355)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fletcher;
            vehicle.Name = "Fletcher (DD-445)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sumner;
            vehicle.Name = "Sumner (DD-692)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.somers;
            vehicle.Name = "Somers (DD-381)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.trenton;
            vehicle.Name = "USS Trenton (CL-11)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.brooklyn;
            vehicle.Name = "USS Brooklyn (CL-40)";
            vehicle.Nation = "USA";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            ///////////////////////////////////////////   НІМЕЧЧИНА   ///////////////////////////////////////////
            

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ls3;
            vehicle.Name = "LS 3";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.s38;
            vehicle.Name = "S-38";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.rbootr41;
            vehicle.Name = "R-boot R-41";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.s100;
            vehicle.Name = "S-100 (1944)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sf40l;
            vehicle.Name = "SF40 Leichte";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sf40s;
            vehicle.Name = "SF40 Schwere";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.adf3;
            vehicle.Name = "AF D3";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.vs8;
            vehicle.Name = "VS-8 Schell";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.vs10;
            vehicle.Name = "VS-10";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.jaguar;
            vehicle.Name = "Type 140/141 Jaguar";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mz1;
            vehicle.Name = "MZ1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.albatroz;
            vehicle.Name = "Type 143 Albatros";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.typem1943;
            vehicle.Name = "Type M 1943";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.type1924leopard;
            vehicle.Name = "Type 1924 Leopard";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.type1939t22;
            vehicle.Name = "Type 1939 (T22)";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.k2;
            vehicle.Name = "Kanonenboot K-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.z20;
            vehicle.Name = "Z20 Karl Galster";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.emden;
            vehicle.Name = "Emden";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.koln;
            vehicle.Name = "Köln";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.nurnberg;
            vehicle.Name = "Nurnberg";
            vehicle.Nation = "Germany";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            
            ///////////////////////////////////////////   СССР   ///////////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.g5;
            vehicle.Name = "G-5";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.komsomolets;
            vehicle.Name = "Pr. 123K Komsomolets";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ya5m;
            vehicle.Name = "Ya-5M";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mo4;
            vehicle.Name = "MO-4";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bmo;
            vehicle.Name = "BMO";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mpk122;
            vehicle.Name = "MPK pr. 122A";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pr191;
            vehicle.Name = "Pr.191";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pr1124;
            vehicle.Name = "Pr.1124 MLRS";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mbk186;
            vehicle.Name = "MBK pr.186 (MK 85)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pr1204;
            vehicle.Name = "Pr. 1204 late";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pr206;
            vehicle.Name = "Pr. 206M Shtorm";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pr159;
            vehicle.Name = "Pr. 159";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.frunze;
            vehicle.Name = "Frunze";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.moskva;
            vehicle.Name = "Moskva";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.taskent;
            vehicle.Name = "Tashkent";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.stroyniy;
            vehicle.Name = "Pr. 7U Stroyny";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kavkaz;
            vehicle.Name = "Krasny Kavkaz";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.krym;
            vehicle.Name = "Krasny Krym";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kirov;
            vehicle.Name = "Kirov";
            vehicle.Nation = "USSR";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.g89;
            vehicle.Name = "G-class (H89)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.battled14;
            vehicle.Name = "Battle (D14)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.g63;
            vehicle.Name = "Haida (G63)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.k246;
            vehicle.Name = "River class (K-246)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hms_enterprize;
            vehicle.Name = "HMS Enterprise";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hms_dido;
            vehicle.Name = "HMS Dido";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hms_tiger;
            vehicle.Name = "HMS Tiger";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fpb1102;
            vehicle.Name = "Dark class (FPB 1102)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.greyfox;
            vehicle.Name = "SGB Grey Fox (S304)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mbt1series;
            vehicle.Name = "MTB-1 1 series";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.vosper;
            vehicle.Name = "Vosper 2 series";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fairmile;
            vehicle.Name = "Fairmile A (ML100)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mgb61;
            vehicle.Name = "MGB-61";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.flowerclass;
            vehicle.Name = "Flower class (K-218)";
            vehicle.Nation = "GB";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            /////////////////////////////////////////////////////JAPAN/////////////////////////////////////////////////////////////

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.typet14;
            vehicle.Name = "Type T-14";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.karotype;
            vehicle.Name = "Type 4 Model 2";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sehatei;
            vehicle.Name = "Ha-Go";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.type5;
            vehicle.Name = "Type 5";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.abtei;
            vehicle.Name = "Soukou-Tei (1927)";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.abteiserial;
            vehicle.Name = "Soukou-Tei (1940)";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ch8;
            vehicle.Name = "Type K-7";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t51b;
            vehicle.Name = "T-51b";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.chikugo;
            vehicle.Name = "Chikugo";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pg02;
            vehicle.Name = "PG 02";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fubuki;
            vehicle.Name = "IJN Ayanami";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.akizuki;
            vehicle.Name = "IJN Akizuki";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kuma;
            vehicle.Name = "IJN Kuma";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kako;
            vehicle.Name = "IJN Kako";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.furutaka;
            vehicle.Name = "IJN Furutaka";
            vehicle.Nation = "Japan";
            vehicle.Character = "Ship";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

                       
            return vehicles;
        }

    }
}