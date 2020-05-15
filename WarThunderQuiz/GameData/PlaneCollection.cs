using System.Collections.Generic;

using Android.App;
using Android.Content;

namespace WarThunderQuiz.GameData
{
    public class Vehicle
    {
        public int Image { get; set; }
        public string Name { get; set; }
        public string Nation { get; set; }
        public string Character { get; set; }
        public int PeriodOfTime { get; set; }
    }

    class PlaneCollection
    {
        public static List<Vehicle> GetPlanes()
        {
            var context = Application.Context;
            var vehicles = new List<Vehicle>();
            Vehicle vehicle;

            ///////////////////////////////////////////   США   ///////////////////////////////////////////
            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p_61,
                Name = "P-61C-1",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p_47,
                Name = "P-47D-28",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f_80,
                Name = "F-80A-5",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f_86,
                Name = "F-86F-25",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f89d,
                Name = "F-89D",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f4c,
                Name = "F-4C Phantom II",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f_100,
                Name = "F-100D",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f2h,
                Name = "F2H-2",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f9f,
                Name = "F9F-5",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f9f8,
                Name = "F9F-8",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.d3d,
                Name = "F3D-1",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b57,
                Name = "B-57B",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fj4,
                Name = "FJ-4B",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p59a,
                Name = "P-59A",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p_38,
                Name = "P-38L-5",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f7f,
                Name = "F7F-1",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f8f1b,
                Name = "F8F-1B",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f4u,
                Name = "F4U-4",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.a26b,
                Name = "A-26B-50",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ad4,
                Name = "AD-4",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.a2d,
                Name = "A2D-1",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b29,
                Name = "B-29A",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b24,
                Name = "B-24D-25",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b17,
                Name = "B-17E",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pb4y,
                Name = "PB4Y-2",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.btd,
                Name = "BTD-1",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p36,
                Name = "P-36A",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f2a3,
                Name = "F2A-3",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.os2u,
                Name = "OS2U-1",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sbd3,
                Name = "SBD-3",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pby5,
                Name = "PBY-5",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b18,
                Name = "B-18A",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b25,
                Name = "B-25J-1",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p40,
                Name = "P-40F-10",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p39,
                Name = "P-39Q-5",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f4f3,
                Name = "F4F-3",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.xp55,
                Name = "XP-55",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pv2d,
                Name = "PV-2D",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p51h5,
                Name = "P-51H-5",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f82,
                Name = "F-82E",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p26,
                Name = "P-26A-34",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f3f2,
                Name = "F3F-2",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ah1f,
                Name = "AH-1F",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ah1z,
                Name = "AH-1Z",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.uh1c,
                Name = "UH-1C",
                Nation = "USA",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            ///////////////////////////////////////////   НІМЕЧЧИНА   ///////////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he51a1,
                Name = "He 51 A-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he112a0,
                Name = "He 112 A-0",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.do17z7,
                Name = "Do 17 Z-7",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ju87r2,
                Name = "Ju 87 R-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hs123,
                Name = "Hs 123 A-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he51b2h,
                Name = "He 51 B-2/H",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fw189,
                Name = "Fw 189 A-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bf109e7,
                Name = "Bf 109 E-7/U2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he100d1,
                Name = "He 100 D-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bf110f2,
                Name = "Bf 110 F-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ju87d5,
                Name = "Ju 87 D-5",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ju87g2,
                Name = "Ju 87 G-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he111,
                Name = "He 111 H-6",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fw200,
                Name = "Fw 200 C-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bv238,
                Name = "BV 238",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fw190a5,
                Name = "Fw 190 A-5",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.do217n,
                Name = "Do 217 N-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hs129b3,
                Name = "Hs 129 B-3",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hs129b2,
                Name = "Hs 129 B-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he162,
                Name = "He 162 A-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ho229,
                Name = "Ho 229 V3",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.me262a4,
                Name = "Me 262 A-1a/U4",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ar234b2,
                Name = "Ar 234 B-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ar234b3,
                Name = "Ar 234 C-3",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.cl13,
                Name = "CL-13B Mk.6",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mig19s,
                Name = "MiG-19S",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.me264,
                Name = "Me 264",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.do217e2,
                Name = "Do 217 E-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ta154,
                Name = "Ta 154 A-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bf109k4,
                Name = "Bf 109 K-4",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fw190d12,
                Name = "Fw 190 D-12",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ta152h1,
                Name = "Ta 152 H-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ta152c3,
                Name = "Ta 152 C-3",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.me410b6r3,
                Name = "Me 410 B-6/R3",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.me262a1,
                Name = "Me 262 A-1a",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.me163,
                Name = "Me 163 B",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bf109z,
                Name = "Bf 109 Z",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ju388,
                Name = "Ju 388 J",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ju288,
                Name = "Ju 288 C",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he219a7,
                Name = "He 219 A-7",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.he177,
                Name = "He 177 A-5",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.do335,
                Name = "Do 335 B-2",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.me410b2u4,
                Name = "Me 410 B-2/U4",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.bo105rah1,
                Name = "BO 105 PAH-1",
                Nation = "Germany",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            ///////////////////////////////////////////   СРСР   ///////////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mi28,
                Name = "Mi-28N",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ka50,
                Name = "Ka-50",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mi24a,
                Name = "Mi-24A",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mi35,
                Name = "Mi-35M",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mi4av,
                Name = "Mi-4AV",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.i153,
                Name = "I-153 M-62",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.i16,
                Name = "I-16 type 18",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.po2,
                Name = "Po-2",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sb2,
                Name = "SB 2M",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mbr,
                Name = "MBR-2",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tb3,
                Name = "TB-3M",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tandemmai,
                Name = "Tandem MAI",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.i29,
                Name = "I-29",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.yak4,
                Name = "Yak-4",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su2,
                Name = "Su-2",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mig3,
                Name = "MiG-3-15",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.lagg3,
                Name = "LaGG-3-35",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.Il2,
                Name = "IL-2",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.il4,
                Name = "IL-4",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pe2,
                Name = "Pe-2-1",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.yak9t,
                Name = "Yak-9T",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.pe8,
                Name = "Pe-8",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.su6,
                Name = "Su-6 (AM-42)",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.il10,
                Name = "IL-10",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.yer2,
                Name = "Yer-2 (ACh-30B)",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tu2,
                Name = "Tu-2",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.be6,
                Name = "Be-6",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.la174,
                Name = "La-174",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mig21,
                Name = "MiG-21",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.yak15,
                Name = "Yak-15",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.yak23,
                Name = "Yak-23",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mig9,
                Name = "MiG-9",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mig15,
                Name = "MiG-15bis",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.la200,
                Name = "La-200",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.il28,
                Name = "IL-28",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mig19,
                Name = "MiG-19PT",
                Nation = "USSR",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            //////////////////////////////////////////ВЕЛИКОБРИТАНІЯ///////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.meteor3,
                Name = "Meteor F 3",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.swift_f1,
                Name = "Swift F.1",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.scout_ah_mk1,
                Name = "Scout AH.Mk.1",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.lynx_ah_mk1,
                Name = "Lynx AH.Mk.1",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.meteor4,
                Name = "Meteor F 4",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.attacker1,
                Name = "Attacker FB 1",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hunterf6,
                Name = "Hunter F.6",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.javelin,
                Name = "Javelin F.(A.W.) Mk.9",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.venom,
                Name = "Sea Venom FAW 20",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.wyvern,
                Name = "Wyvern S 4",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.seafirefr47,
                Name = "Seafire FR 47",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mosquito,
                Name = "Mosquito FB Mk XVIII",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hornet_mk3,
                Name = "Hornet F 3",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.lancaster_mk1,
                Name = "Lancaster B Mk I",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.whirlwind_p9,
                Name = "Whirlwind P.9",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b_48_firecrest,
                Name = "Firecrest",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.spitfire_f24,
                Name = "Spitfire F 24",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.spitfire_ix,
                Name = "Spitfire LF Mk IX",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tempest_mk2,
                Name = "Tempest Mk II",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tempest_mkv_vikkers,
                Name = "Tempest Mk V (47mm Vickers)",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.spitfire_mk5c,
                Name = "Spitfire Mk VC Trop",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fury_mk1,
                Name = "Fury Mk I",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hurricane_mk4,
                Name = "Hurricane Mk IV",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.typhoon_mk1b_late,
                Name = "Typhoon Mk 1B",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.gladiator_mk2_france,
                Name = "Gladiator Mk II",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.v_156_b1,
                Name = "V-156B-1",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.beaufort_mkviii,
                Name = "Beaufort Mk VIII",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.swordfish_mk1,
                Name = "Swordfish Mk I",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.hp52_hampden_mk1_late,
                Name = "Hampden B Mk I",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sunderland_mk3a,
                Name = "Sunderland Mk IIIA",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.wirraway,
                Name = "CA-3 Wirraway",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.wellington_mk1c,
                Name = "Wellington B Mk IC",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.beaufighter_mk6c,
                Name = "Beaufighter Mk VIC",
                Nation = "GB",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            ///////////////////////////////////ЯПОНІЯ/////////////////////////////////////

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.n1k2_jko,
                Name = "N1K2-J Ko Shiden-Kai",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.a6m2_zero,
                Name = "A6M2 Reisen",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.d4y3,
                Name = "D4Y3 Ko Suisei",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_109,
                Name = "Ki-109",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.a7m2,
                Name = "A7M2 Reppū",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_67_1_otsu,
                Name = "Ki-67-I Otsu Hiryū",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.j7w1,
                Name = "J7W1 Shinden",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_84_hei,
                Name = "Ki-84 Hei Hayate",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.kitsuka,
                Name = "Kikka",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.r2y2_kai,
                Name = "R2Y2 Keiun-Kai V3",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_94_2,
                Name = "Ki-94-II",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.j2m4_kai,
                Name = "J2M4 Raiden",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.t2,
                Name = "Mitsubishi T-2",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.h6k4,
                Name = "H6K4",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);



            vehicle = new Vehicle
            {
                Image = Resource.Drawable.g8n1,
                Name = "G8N1 Renzan",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.g5n1,
                Name = "G5N1 Shinzan",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.b7a2,
                Name = "B7A2 Ryusei",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.g4m1,
                Name = "G4M1",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_43_2,
                Name = "Ki-43-II Otsu Hayabusa",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_61_1a_ko,
                Name = "Ki-61-I Ko Hien",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki49_2b,
                Name = "Ki-49-II Otsu Donryu",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.a5m4,
                Name = "A5M4",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_10_1,
                Name = "Ki-10-I",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f1m2,
                Name = "F1M2",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.a6m2_n_zero,
                Name = "A6M2-N",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ki_32,
                Name = "Ki-32",
                Nation = "Japan",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            /////////////////////////////////////////////ІТАЛІЯ//////////////////////////////////////////////

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.a129,
                Name = "A-129",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.re_2000_ga,
                Name = "Re.2000 Serie II Falco",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.re_2001_cb,
                Name = "Re.2001 CB",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fiat_g50_seria2_italy,
                Name = "G.50 Freccia",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fiat_cr42_italy,
                Name = "CR.42 Falco",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ba_65_k14_l,
                Name = "Ba.65bis",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.s_81_ar125,
                Name = "SM.81 Pipistrello",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.br_20_dr,
                Name = "BR.20DR Cicogna",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mc202_italy,
                Name = "C.202 Folgore",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mc205_serie3,
                Name = "C.205 Veltro",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sm_79_1943_italy,
                Name = "SM.79bis Sparviero",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.iar_81c,
                Name = "IAR 81C",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.z_1007_bis_serie3,
                Name = "Z.1007bis Alcione",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.p_108b_serie1,
                Name = "P.108B",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.g_55_serie1,
                Name = "G.55 Centauro",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sm_91,
                Name = "SM.91",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sm_92,
                Name = "SM.92",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.fiat_g91_r1,
                Name = "G.91R/1",
                Nation = "Italy",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            ///////////////////////////////////////////ФРАНЦІЯ///////////////////////////////////////////////////


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.h_34_france,
                Name = "H-34",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.sa_342m,
                Name = "SA.342M Gazelle",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.iar_316b,
                Name = "IAR 316B",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.so_4050_vautour_2a,
                Name = "SO 4050 Vautour IIA",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.md_460,
                Name = "Super Mystere B2",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.md_450b_ouragan,
                Name = "MD 450B Ouragan",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 3
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.so_8000_narval,
                Name = "SO 8000 Narval",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.vb_10_02,
                Name = "VB 10-02",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.mb_175t,
                Name = "MB 175 T",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.leo_451_late,
                Name = "LeO 451",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.f_222_2,
                Name = "Farman F 222.2",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.potez_630,
                Name = "Potez 630",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.d_501,
                Name = "D 501",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.d_520_france,
                Name = "D 520",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.ms_410c1,
                Name = "MS 410",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 2
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.caudron_cr714,
                Name = "CR 714",
                Nation = "France",
                Character = "Plane",
                PeriodOfTime = 1
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.d_371,
                Name = "D 371",
                Nation = "France",
                PeriodOfTime = 1,
                Character = "Plane"
            };
            vehicles.Add(vehicle);

            vehicle = new Vehicle
            {
                Image = Resource.Drawable.tiger_had_france,
                Name = "EC-665 Tiger HAD",
                Nation = "France",
                PeriodOfTime = 3,
                Character = "Plane"
            };
            vehicles.Add(vehicle);


            vehicle = new Vehicle
            {
                Image = Resource.Drawable.Etendardivm,
                Name = "Etendard IVM",
                Nation = "France",
                PeriodOfTime = 3,
                Character = "Plane"
            };
            vehicles.Add(vehicle);

            return vehicles;
        }
    }
}