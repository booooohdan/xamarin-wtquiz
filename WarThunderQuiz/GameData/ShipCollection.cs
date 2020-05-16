using System.Collections.Generic;
using Android.App;

namespace WarThunderQuiz.GameData
{
    class ShipCollection
    {
        public static List<Vehicle> GetShips()
        {
            var context = Application.Context;
            var vehicles = new List<Vehicle>();
            Vehicle vehicle;

            ///////////////////////////////////////////   USA   ///////////////////////////////////////////

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.higgins81,
                Name = "Higgins 81 ft PT-6",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.nasty80,
                Name = "80 ft Nasty",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sc497,
                Name = "110 ft SC-497",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pc451,
                Name = "165 ft PC-451",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pt3,
                Name = "58 ft PT-3",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.eclo77pt59,
                Name = "Elco 77 ft PT-59",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.higgins78pt200,
                Name = "Higgins 78 ft PT-200",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pgh2,
                Name = "PGH-2",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pt810,
                Name = "89 ft PT-810",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.lcs3,
                Name = "LCS(L)(3)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pgm84,
                Name = "Asheville (PGM-84)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.clemson,
                Name = "Clemson (DD-336)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.farragut,
                Name = "Farragut (DD-355)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fletcher,
                Name = "Fletcher (DD-445)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sumner,
                Name = "Sumner (DD-692)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.somers,
                Name = "Somers (DD-381)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.trenton,
                Name = "USS Trenton (CL-11)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.brooklyn,
                Name = "USS Brooklyn (CL-40)",
                Nation = "USA",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            ///////////////////////////////////////////   GERMANY   ///////////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ls3,
                Name = "LS 3",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.s38,
                Name = "S-38",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.rbootr41,
                Name = "R-boot R-41",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.s100,
                Name = "S-100 (1944)",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sf40l,
                Name = "SF40 Leichte",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sf40s,
                Name = "SF40 Schwere",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.adf3,
                Name = "AF D3",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.vs8,
                Name = "VS-8 Schell",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.vs10,
                Name = "VS-10",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.jaguar,
                Name = "Type 140/141 Jaguar",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mz1,
                Name = "MZ1",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.albatroz,
                Name = "Type 143 Albatros",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.typem1943,
                Name = "Type M 1943",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.type1924leopard,
                Name = "Type 1924 Leopard",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.type1939t22,
                Name = "Type 1939 (T22)",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.k2,
                Name = "Kanonenboot K-2",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.z20,
                Name = "Z20 Karl Galster",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.emden,
                Name = "Emden",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.koln,
                Name = "Köln",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.nurnberg,
                Name = "Nurnberg",
                Nation = "Germany",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            ///////////////////////////////////////////   USSR   ///////////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.g5,
                Name = "G-5",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.komsomolets,
                Name = "Pr. 123K Komsomolets",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ya5m,
                Name = "Ya-5M",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mo4,
                Name = "MO-4",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bmo,
                Name = "BMO",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mpk122,
                Name = "MPK pr. 122A",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pr191,
                Name = "Pr.191",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pr1124,
                Name = "Pr.1124 MLRS",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mbk186,
                Name = "MBK pr.186 (MK 85)",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pr1204,
                Name = "Pr. 1204 late",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pr206,
                Name = "Pr. 206M Shtorm",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pr159,
                Name = "Pr. 159",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.frunze,
                Name = "Frunze",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.moskva,
                Name = "Moskva",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.taskent,
                Name = "Tashkent",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.stroyniy,
                Name = "Pr. 7U Stroyny",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kavkaz,
                Name = "Krasny Kavkaz",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.krym,
                Name = "Krasny Krym",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kirov,
                Name = "Kirov",
                Nation = "USSR",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.g89,
                Name = "G-class (H89)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.battled14,
                Name = "Battle (D14)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.g63,
                Name = "Haida (G63)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.k246,
                Name = "River class (K-246)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hms_enterprize,
                Name = "HMS Enterprise",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hms_dido,
                Name = "HMS Dido",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hms_tiger,
                Name = "HMS Tiger",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fpb1102,
                Name = "Dark class (FPB 1102)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.greyfox,
                Name = "SGB Grey Fox (S304)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mbt1series,
                Name = "MTB-1 1 series",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.vosper,
                Name = "Vosper 2 series",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fairmile,
                Name = "Fairmile A (ML100)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mgb61,
                Name = "MGB-61",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.flowerclass,
                Name = "Flower class (K-218)",
                Nation = "GB",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            ///////////////////////////////////////////////////// JAPAN /////////////////////////////////////////////////////////////

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.typet14,
                Name = "Type T-14",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.karotype,
                Name = "Type 4 Model 2",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sehatei,
                Name = "Ha-Go",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.type5,
                Name = "Type 5",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.abtei,
                Name = "Soukou-Tei (1927)",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.abteiserial,
                Name = "Soukou-Tei (1940)",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ch8,
                Name = "Type K-7",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t51b,
                Name = "T-51b",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.chikugo,
                Name = "Chikugo",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pg02,
                Name = "PG 02",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fubuki,
                Name = "IJN Ayanami",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.akizuki,
                Name = "IJN Akizuki",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kuma,
                Name = "IJN Kuma",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kako,
                Name = "IJN Kako",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.furutaka,
                Name = "IJN Furutaka",
                Nation = "Japan",
                Character = "Ship",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

                       
            return vehicles;
        }

    }
}