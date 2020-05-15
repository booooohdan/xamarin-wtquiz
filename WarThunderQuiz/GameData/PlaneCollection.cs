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
            Context context = Application.Context;
            List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehicle;
            vehicles.Clear();

            ///////////////////////////////////////////   США   ///////////////////////////////////////////
            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p_61;
            vehicle.Name = "P-61C-1"; 
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p_47;
            vehicle.Name = "P-47D-28";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f_80;
            vehicle.Name = "F-80A-5";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f_86;
            vehicle.Name = "F-86F-25";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f89d;
            vehicle.Name = "F-89D";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f4c;
            vehicle.Name = "F-4C Phantom II";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f_100;
            vehicle.Name = "F-100D";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f2h;
            vehicle.Name = "F2H-2";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f9f;
            vehicle.Name = "F9F-5";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f9f8;
            vehicle.Name = "F9F-8";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.d3d;
            vehicle.Name = "F3D-1";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b57;
            vehicle.Name = "B-57B";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fj4;
            vehicle.Name = "FJ-4B";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p59a;
            vehicle.Name = "P-59A";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p_38;
            vehicle.Name = "P-38L-5";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f7f;
            vehicle.Name = "F7F-1";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f8f1b;
            vehicle.Name = "F8F-1B";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f4u;
            vehicle.Name = "F4U-4";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.a26b;
            vehicle.Name = "A-26B-50";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ad4;
            vehicle.Name = "AD-4";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.a2d;
            vehicle.Name = "A2D-1";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b29;
            vehicle.Name = "B-29A";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b24;
            vehicle.Name = "B-24D-25";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b17;
            vehicle.Name = "B-17E";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pb4y;
            vehicle.Name = "PB4Y-2";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.btd;
            vehicle.Name = "BTD-1";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle); 


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p36;
            vehicle.Name = "P-36A";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f2a3;
            vehicle.Name = "F2A-3";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.os2u;
            vehicle.Name = "OS2U-1";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sbd3;
            vehicle.Name = "SBD-3";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pby5;
            vehicle.Name = "PBY-5";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b18;
            vehicle.Name = "B-18A";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b25;
            vehicle.Name = "B-25J-1";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p40;
            vehicle.Name = "P-40F-10";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p39;
            vehicle.Name = "P-39Q-5";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f4f3;
            vehicle.Name = "F4F-3";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.xp55;
            vehicle.Name = "XP-55";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pv2d;
            vehicle.Name = "PV-2D";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p51h5;
            vehicle.Name = "P-51H-5";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f82;
            vehicle.Name = "F-82E";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p26;
            vehicle.Name = "P-26A-34";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f3f2;
            vehicle.Name = "F3F-2";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ah1f;
            vehicle.Name = "AH-1F";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ah1z;
            vehicle.Name = "AH-1Z";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.uh1c;
            vehicle.Name = "UH-1C";
            vehicle.Nation = "USA";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            ///////////////////////////////////////////   НІМЕЧЧИНА   ///////////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he51a1;
            vehicle.Name = "He 51 A-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he112a0;
            vehicle.Name = "He 112 A-0";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.do17z7;
            vehicle.Name = "Do 17 Z-7";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ju87r2;
            vehicle.Name = "Ju 87 R-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hs123;
            vehicle.Name = "Hs 123 A-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he51b2h;
            vehicle.Name = "He 51 B-2/H";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fw189;
            vehicle.Name = "Fw 189 A-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bf109e7;
            vehicle.Name = "Bf 109 E-7/U2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he100d1;
            vehicle.Name = "He 100 D-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bf110f2;
            vehicle.Name = "Bf 110 F-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ju87d5;
            vehicle.Name = "Ju 87 D-5";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ju87g2;
            vehicle.Name = "Ju 87 G-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he111;
            vehicle.Name = "He 111 H-6";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fw200;
            vehicle.Name = "Fw 200 C-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bv238;
            vehicle.Name = "BV 238";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fw190a5;
            vehicle.Name = "Fw 190 A-5";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.do217n;
            vehicle.Name = "Do 217 N-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hs129b3;
            vehicle.Name = "Hs 129 B-3";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hs129b2;
            vehicle.Name = "Hs 129 B-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he162;
            vehicle.Name = "He 162 A-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ho229;
            vehicle.Name = "Ho 229 V3";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.me262a4;
            vehicle.Name = "Me 262 A-1a/U4";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ar234b2;
            vehicle.Name = "Ar 234 B-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ar234b3;
            vehicle.Name = "Ar 234 C-3";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.cl13;
            vehicle.Name = "CL-13B Mk.6";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mig19s;
            vehicle.Name = "MiG-19S";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.me264;
            vehicle.Name = "Me 264";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.do217e2;
            vehicle.Name = "Do 217 E-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ta154;
            vehicle.Name = "Ta 154 A-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bf109k4;
            vehicle.Name = "Bf 109 K-4";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fw190d12;
            vehicle.Name = "Fw 190 D-12";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ta152h1;
            vehicle.Name = "Ta 152 H-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ta152c3;
            vehicle.Name = "Ta 152 C-3";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.me410b6r3;
            vehicle.Name = "Me 410 B-6/R3";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.me262a1;
            vehicle.Name = "Me 262 A-1a";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.me163;
            vehicle.Name = "Me 163 B";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bf109z;
            vehicle.Name = "Bf 109 Z";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ju388;
            vehicle.Name = "Ju 388 J";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ju288;
            vehicle.Name = "Ju 288 C";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he219a7;
            vehicle.Name = "He 219 A-7";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.he177;
            vehicle.Name = "He 177 A-5";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.do335;
            vehicle.Name = "Do 335 B-2";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.me410b2u4;
            vehicle.Name = "Me 410 B-2/U4";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.bo105rah1;
            vehicle.Name = "BO 105 PAH-1";
            vehicle.Nation = "Germany";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            ///////////////////////////////////////////   СРСР   ///////////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mi28;
            vehicle.Name = "Mi-28N";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ka50;
            vehicle.Name = "Ka-50";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mi24a;
            vehicle.Name = "Mi-24A";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mi35;
            vehicle.Name = "Mi-35M";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mi4av;
            vehicle.Name = "Mi-4AV";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.i153;
            vehicle.Name = "I-153 M-62";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.i16;
            vehicle.Name = "I-16 type 18";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.po2;
            vehicle.Name = "Po-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sb2;
            vehicle.Name = "SB 2M";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mbr;
            vehicle.Name = "MBR-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tb3;
            vehicle.Name = "TB-3M";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tandemmai;
            vehicle.Name = "Tandem MAI";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.i29;
            vehicle.Name = "I-29";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.yak4;
            vehicle.Name = "Yak-4";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su2;
            vehicle.Name = "Su-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mig3;
            vehicle.Name = "MiG-3-15";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.lagg3;
            vehicle.Name = "LaGG-3-35";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.Il2;
            vehicle.Name = "IL-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.il4;
            vehicle.Name = "IL-4";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pe2;
            vehicle.Name = "Pe-2-1";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.yak9t;
            vehicle.Name = "Yak-9T";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.pe8;
            vehicle.Name = "Pe-8";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.su6;
            vehicle.Name = "Su-6 (AM-42)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.il10;
            vehicle.Name = "IL-10";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.yer2;
            vehicle.Name = "Yer-2 (ACh-30B)";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tu2;
            vehicle.Name = "Tu-2";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.be6;
            vehicle.Name = "Be-6";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.la174;
            vehicle.Name = "La-174";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mig21;
            vehicle.Name = "MiG-21";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.yak15;
            vehicle.Name = "Yak-15";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.yak23;
            vehicle.Name = "Yak-23";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mig9;
            vehicle.Name = "MiG-9";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mig15;
            vehicle.Name = "MiG-15bis";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.la200;
            vehicle.Name = "La-200";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.il28;
            vehicle.Name = "IL-28";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mig19;
            vehicle.Name = "MiG-19PT";
            vehicle.Nation = "USSR";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            //////////////////////////////////////////ВЕЛИКОБРИТАНІЯ///////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.meteor3;
            vehicle.Name = "Meteor F 3";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.swift_f1;
            vehicle.Name = "Swift F.1";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.scout_ah_mk1;
            vehicle.Name = "Scout AH.Mk.1";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.lynx_ah_mk1;
            vehicle.Name = "Lynx AH.Mk.1";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.meteor4;
            vehicle.Name = "Meteor F 4";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.attacker1;
            vehicle.Name = "Attacker FB 1";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hunterf6;
            vehicle.Name = "Hunter F.6";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.javelin;
            vehicle.Name = "Javelin F.(A.W.) Mk.9";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.venom;
            vehicle.Name = "Sea Venom FAW 20";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.wyvern;
            vehicle.Name = "Wyvern S 4";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.seafirefr47;
            vehicle.Name = "Seafire FR 47";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mosquito;
            vehicle.Name = "Mosquito FB Mk XVIII";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hornet_mk3;
            vehicle.Name = "Hornet F 3";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.lancaster_mk1;
            vehicle.Name = "Lancaster B Mk I";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.whirlwind_p9;
            vehicle.Name = "Whirlwind P.9";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b_48_firecrest;
            vehicle.Name = "Firecrest";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.spitfire_f24;
            vehicle.Name = "Spitfire F 24";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.spitfire_ix;
            vehicle.Name = "Spitfire LF Mk IX";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tempest_mk2;
            vehicle.Name = "Tempest Mk II";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tempest_mkv_vikkers;
            vehicle.Name = "Tempest Mk V (47mm Vickers)";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.spitfire_mk5c;
            vehicle.Name = "Spitfire Mk VC Trop";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fury_mk1;
            vehicle.Name = "Fury Mk I";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hurricane_mk4;
            vehicle.Name = "Hurricane Mk IV";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.typhoon_mk1b_late;
            vehicle.Name = "Typhoon Mk 1B";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.gladiator_mk2_france;
            vehicle.Name = "Gladiator Mk II";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.v_156_b1;
            vehicle.Name = "V-156B-1";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.beaufort_mkviii;
            vehicle.Name = "Beaufort Mk VIII";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.swordfish_mk1;
            vehicle.Name = "Swordfish Mk I";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.hp52_hampden_mk1_late;
            vehicle.Name = "Hampden B Mk I";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sunderland_mk3a;
            vehicle.Name = "Sunderland Mk IIIA";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.wirraway;
            vehicle.Name = "CA-3 Wirraway";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.wellington_mk1c;
            vehicle.Name = "Wellington B Mk IC";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.beaufighter_mk6c;
            vehicle.Name = "Beaufighter Mk VIC";
            vehicle.Nation = "GB";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            ///////////////////////////////////ЯПОНІЯ/////////////////////////////////////

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.n1k2_jko;
            vehicle.Name = "N1K2-J Ko Shiden-Kai";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.a6m2_zero;
            vehicle.Name = "A6M2 Reisen";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.d4y3;
            vehicle.Name = "D4Y3 Ko Suisei";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_109;
            vehicle.Name = "Ki-109";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.a7m2;
            vehicle.Name = "A7M2 Reppū";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_67_1_otsu;
            vehicle.Name = "Ki-67-I Otsu Hiryū";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.j7w1;
            vehicle.Name = "J7W1 Shinden";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_84_hei;
            vehicle.Name = "Ki-84 Hei Hayate";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.kitsuka;
            vehicle.Name = "Kikka";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.r2y2_kai;
            vehicle.Name = "R2Y2 Keiun-Kai V3";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_94_2;
            vehicle.Name = "Ki-94-II";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.j2m4_kai;
            vehicle.Name = "J2M4 Raiden";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.t2;
            vehicle.Name = "Mitsubishi T-2";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.h6k4;
            vehicle.Name = "H6K4";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);



            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.g8n1;
            vehicle.Name = "G8N1 Renzan";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.g5n1;
            vehicle.Name = "G5N1 Shinzan";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.b7a2;
            vehicle.Name = "B7A2 Ryusei";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.g4m1;
            vehicle.Name = "G4M1";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_43_2;
            vehicle.Name = "Ki-43-II Otsu Hayabusa";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_61_1a_ko;
            vehicle.Name = "Ki-61-I Ko Hien";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki49_2b;
            vehicle.Name = "Ki-49-II Otsu Donryu";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.a5m4;
            vehicle.Name = "A5M4";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_10_1;
            vehicle.Name = "Ki-10-I";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f1m2;
            vehicle.Name = "F1M2";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.a6m2_n_zero;
            vehicle.Name = "A6M2-N";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ki_32;
            vehicle.Name = "Ki-32";
            vehicle.Nation = "Japan";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            /////////////////////////////////////////////ІТАЛІЯ//////////////////////////////////////////////
            
            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.a129;
            vehicle.Name = "A-129";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.re_2000_ga;
            vehicle.Name = "Re.2000 Serie II Falco";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.re_2001_cb;
            vehicle.Name = "Re.2001 CB";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fiat_g50_seria2_italy;
            vehicle.Name = "G.50 Freccia";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fiat_cr42_italy;
            vehicle.Name = "CR.42 Falco";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ba_65_k14_l;
            vehicle.Name = "Ba.65bis";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.s_81_ar125;
            vehicle.Name = "SM.81 Pipistrello";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.br_20_dr;
            vehicle.Name = "BR.20DR Cicogna";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mc202_italy;
            vehicle.Name = "C.202 Folgore";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mc205_serie3;
            vehicle.Name = "C.205 Veltro";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sm_79_1943_italy;
            vehicle.Name = "SM.79bis Sparviero";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.iar_81c;
            vehicle.Name = "IAR 81C";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.z_1007_bis_serie3;
            vehicle.Name = "Z.1007bis Alcione";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.p_108b_serie1;
            vehicle.Name = "P.108B";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.g_55_serie1;
            vehicle.Name = "G.55 Centauro";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sm_91;
            vehicle.Name = "SM.91";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sm_92;
            vehicle.Name = "SM.92";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.fiat_g91_r1;
            vehicle.Name = "G.91R/1";
            vehicle.Nation = "Italy";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            
            ///////////////////////////////////////////ФРАНЦІЯ///////////////////////////////////////////////////


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.h_34_france;
            vehicle.Name = "H-34";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.sa_342m;
            vehicle.Name = "SA.342M Gazelle";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.iar_316b;
            vehicle.Name = "IAR 316B";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.so_4050_vautour_2a;
            vehicle.Name = "SO 4050 Vautour IIA";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.md_460;
            vehicle.Name = "Super Mystere B2";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.md_450b_ouragan;
            vehicle.Name = "MD 450B Ouragan";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 3;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.so_8000_narval;
            vehicle.Name = "SO 8000 Narval";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.vb_10_02;
            vehicle.Name = "VB 10-02";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.mb_175t;
            vehicle.Name = "MB 175 T";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.leo_451_late;
            vehicle.Name = "LeO 451";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.f_222_2;
            vehicle.Name = "Farman F 222.2";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.potez_630;
            vehicle.Name = "Potez 630";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.d_501;
            vehicle.Name = "D 501";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.d_520_france;
            vehicle.Name = "D 520";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.ms_410c1;
            vehicle.Name = "MS 410";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 2;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.caudron_cr714;
            vehicle.Name = "CR 714";
            vehicle.Nation = "France";
            vehicle.Character = "Plane";
            vehicle.PeriodOfTime = 1;
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.d_371;
            vehicle.Name = "D 371";
            vehicle.Nation = "France";
            vehicle.PeriodOfTime = 1;
            vehicle.Character = "Plane";
            vehicles.Add(vehicle);

            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.tiger_had_france;
            vehicle.Name = "EC-665 Tiger HAD";
            vehicle.Nation = "France";
            vehicle.PeriodOfTime = 3;
            vehicle.Character = "Plane";
            vehicles.Add(vehicle);


            vehicle = new Vehicle();
            vehicle.Image = Resource.Drawable.Etendardivm;
            vehicle.Name = "Etendard IVM";
            vehicle.Nation = "France";
            vehicle.PeriodOfTime = 3;
            vehicle.Character = "Plane";
            vehicles.Add(vehicle);

            return vehicles;
        }
    }
}