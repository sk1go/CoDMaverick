using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace CoDGhostMaverick
{
    public partial class Form1 : Form
    {
        public struct memadr
        {
            
            public long check1; //2bytes
            //squad member's name string[19]
            public long sm01_name;
            public long sm02_name;
            public long sm03_name;
            public long sm04_name;
            public long sm05_name;
            public long sm06_name;
            public long sm07_name;
            public long sm08_name;
            public long sm09_name;
            public long sm10_name;
            //squad member's LoadOut name string[15]
            public long sm01_LOName1;
            public long sm01_LOName2;
            public long sm01_LOName3;
            public long sm01_LOName4;
            public long sm01_LOName5;
            public long sm01_LOName6;

            public long sm02_LOName1;
            public long sm02_LOName2;
            public long sm02_LOName3;
            public long sm02_LOName4;
            public long sm02_LOName5;
            public long sm02_LOName6;

            public long sm03_LOName1;
            public long sm03_LOName2;
            public long sm03_LOName3;
            public long sm03_LOName4;
            public long sm03_LOName5;
            public long sm03_LOName6;

            public long sm04_LOName1;
            public long sm04_LOName2;
            public long sm04_LOName3;
            public long sm04_LOName4;
            public long sm04_LOName5;
            public long sm04_LOName6;

            public long sm05_LOName1;
            public long sm05_LOName2;
            public long sm05_LOName3;
            public long sm05_LOName4;
            public long sm05_LOName5;
            public long sm05_LOName6;

            public long sm06_LOName1;
            public long sm06_LOName2;
            public long sm06_LOName3;
            public long sm06_LOName4;
            public long sm06_LOName5;
            public long sm06_LOName6;

            public long sm07_LOName1;
            public long sm07_LOName2;
            public long sm07_LOName3;
            public long sm07_LOName4;
            public long sm07_LOName5;
            public long sm07_LOName6;

            public long sm08_LOName1;
            public long sm08_LOName2;
            public long sm08_LOName3;
            public long sm08_LOName4;
            public long sm08_LOName5;
            public long sm08_LOName6;

            public long sm09_LOName1;
            public long sm09_LOName2;
            public long sm09_LOName3;
            public long sm09_LOName4;
            public long sm09_LOName5;
            public long sm09_LOName6;

            public long sm10_LOName1;
            public long sm10_LOName2;
            public long sm10_LOName3;
            public long sm10_LOName4;
            public long sm10_LOName5;
            public long sm10_LOName6;
            //weapons
            public long sm01_LO1_Weapon;
            public long sm01_LO2_Weapon;
            public long sm01_LO3_Weapon;
            public long sm01_LO4_Weapon;
            public long sm01_LO5_Weapon;
            public long sm01_LO6_Weapon;

            public long sm02_LO1_Weapon;
            public long sm02_LO2_Weapon;
            public long sm02_LO3_Weapon;
            public long sm02_LO4_Weapon;
            public long sm02_LO5_Weapon;
            public long sm02_LO6_Weapon;

            public long sm03_LO1_Weapon;
            public long sm03_LO2_Weapon;
            public long sm03_LO3_Weapon;
            public long sm03_LO4_Weapon;
            public long sm03_LO5_Weapon;
            public long sm03_LO6_Weapon;

            public long sm04_LO1_Weapon;
            public long sm04_LO2_Weapon;
            public long sm04_LO3_Weapon;
            public long sm04_LO4_Weapon;
            public long sm04_LO5_Weapon;
            public long sm04_LO6_Weapon;

            public long sm05_LO1_Weapon;
            public long sm05_LO2_Weapon;
            public long sm05_LO3_Weapon;
            public long sm05_LO4_Weapon;
            public long sm05_LO5_Weapon;
            public long sm05_LO6_Weapon;

            public long sm06_LO1_Weapon;
            public long sm06_LO2_Weapon;
            public long sm06_LO3_Weapon;
            public long sm06_LO4_Weapon;
            public long sm06_LO5_Weapon;
            public long sm06_LO6_Weapon;

            public long sm07_LO1_Weapon;
            public long sm07_LO2_Weapon;
            public long sm07_LO3_Weapon;
            public long sm07_LO4_Weapon;
            public long sm07_LO5_Weapon;
            public long sm07_LO6_Weapon;

            public long sm08_LO1_Weapon;
            public long sm08_LO2_Weapon;
            public long sm08_LO3_Weapon;
            public long sm08_LO4_Weapon;
            public long sm08_LO5_Weapon;
            public long sm08_LO6_Weapon;

            public long sm09_LO1_Weapon;
            public long sm09_LO2_Weapon;
            public long sm09_LO3_Weapon;
            public long sm09_LO4_Weapon;
            public long sm09_LO5_Weapon;
            public long sm09_LO6_Weapon;

            public long sm10_LO1_Weapon;
            public long sm10_LO2_Weapon;
            public long sm10_LO3_Weapon;
            public long sm10_LO4_Weapon;
            public long sm10_LO5_Weapon;
            public long sm10_LO6_Weapon;
            //2nd weapons
            public long sm01_LO1_2ndWeapon;
            public long sm01_LO2_2ndWeapon;
            public long sm01_LO3_2ndWeapon;
            public long sm01_LO4_2ndWeapon;
            public long sm01_LO5_2ndWeapon;
            public long sm01_LO6_2ndWeapon;

            public long sm02_LO1_2ndWeapon;
            public long sm02_LO2_2ndWeapon;
            public long sm02_LO3_2ndWeapon;
            public long sm02_LO4_2ndWeapon;
            public long sm02_LO5_2ndWeapon;
            public long sm02_LO6_2ndWeapon;

            public long sm03_LO1_2ndWeapon;
            public long sm03_LO2_2ndWeapon;
            public long sm03_LO3_2ndWeapon;
            public long sm03_LO4_2ndWeapon;
            public long sm03_LO5_2ndWeapon;
            public long sm03_LO6_2ndWeapon;

            public long sm04_LO1_2ndWeapon;
            public long sm04_LO2_2ndWeapon;
            public long sm04_LO3_2ndWeapon;
            public long sm04_LO4_2ndWeapon;
            public long sm04_LO5_2ndWeapon;
            public long sm04_LO6_2ndWeapon;

            public long sm05_LO1_2ndWeapon;
            public long sm05_LO2_2ndWeapon;
            public long sm05_LO3_2ndWeapon;
            public long sm05_LO4_2ndWeapon;
            public long sm05_LO5_2ndWeapon;
            public long sm05_LO6_2ndWeapon;

            public long sm06_LO1_2ndWeapon;
            public long sm06_LO2_2ndWeapon;
            public long sm06_LO3_2ndWeapon;
            public long sm06_LO4_2ndWeapon;
            public long sm06_LO5_2ndWeapon;
            public long sm06_LO6_2ndWeapon;

            public long sm07_LO1_2ndWeapon;
            public long sm07_LO2_2ndWeapon;
            public long sm07_LO3_2ndWeapon;
            public long sm07_LO4_2ndWeapon;
            public long sm07_LO5_2ndWeapon;
            public long sm07_LO6_2ndWeapon;

            public long sm08_LO1_2ndWeapon;
            public long sm08_LO2_2ndWeapon;
            public long sm08_LO3_2ndWeapon;
            public long sm08_LO4_2ndWeapon;
            public long sm08_LO5_2ndWeapon;
            public long sm08_LO6_2ndWeapon;

            public long sm09_LO1_2ndWeapon;
            public long sm09_LO2_2ndWeapon;
            public long sm09_LO3_2ndWeapon;
            public long sm09_LO4_2ndWeapon;
            public long sm09_LO5_2ndWeapon;
            public long sm09_LO6_2ndWeapon;

            public long sm10_LO1_2ndWeapon;
            public long sm10_LO2_2ndWeapon;
            public long sm10_LO3_2ndWeapon;
            public long sm10_LO4_2ndWeapon;
            public long sm10_LO5_2ndWeapon;
            public long sm10_LO6_2ndWeapon;

            //weapon 1st attachment
            public long sm01_LO1_Weapon_at1;
            public long sm01_LO2_Weapon_at1;
            public long sm01_LO3_Weapon_at1;
            public long sm01_LO4_Weapon_at1;
            public long sm01_LO5_Weapon_at1;
            public long sm01_LO6_Weapon_at1;

            public long sm02_LO1_Weapon_at1;
            public long sm02_LO2_Weapon_at1;
            public long sm02_LO3_Weapon_at1;
            public long sm02_LO4_Weapon_at1;
            public long sm02_LO5_Weapon_at1;
            public long sm02_LO6_Weapon_at1;

            public long sm03_LO1_Weapon_at1;
            public long sm03_LO2_Weapon_at1;
            public long sm03_LO3_Weapon_at1;
            public long sm03_LO4_Weapon_at1;
            public long sm03_LO5_Weapon_at1;
            public long sm03_LO6_Weapon_at1;

            public long sm04_LO1_Weapon_at1;
            public long sm04_LO2_Weapon_at1;
            public long sm04_LO3_Weapon_at1;
            public long sm04_LO4_Weapon_at1;
            public long sm04_LO5_Weapon_at1;
            public long sm04_LO6_Weapon_at1;

            public long sm05_LO1_Weapon_at1;
            public long sm05_LO2_Weapon_at1;
            public long sm05_LO3_Weapon_at1;
            public long sm05_LO4_Weapon_at1;
            public long sm05_LO5_Weapon_at1;
            public long sm05_LO6_Weapon_at1;

            public long sm06_LO1_Weapon_at1;
            public long sm06_LO2_Weapon_at1;
            public long sm06_LO3_Weapon_at1;
            public long sm06_LO4_Weapon_at1;
            public long sm06_LO5_Weapon_at1;
            public long sm06_LO6_Weapon_at1;

            public long sm07_LO1_Weapon_at1;
            public long sm07_LO2_Weapon_at1;
            public long sm07_LO3_Weapon_at1;
            public long sm07_LO4_Weapon_at1;
            public long sm07_LO5_Weapon_at1;
            public long sm07_LO6_Weapon_at1;

            public long sm08_LO1_Weapon_at1;
            public long sm08_LO2_Weapon_at1;
            public long sm08_LO3_Weapon_at1;
            public long sm08_LO4_Weapon_at1;
            public long sm08_LO5_Weapon_at1;
            public long sm08_LO6_Weapon_at1;

            public long sm09_LO1_Weapon_at1;
            public long sm09_LO2_Weapon_at1;
            public long sm09_LO3_Weapon_at1;
            public long sm09_LO4_Weapon_at1;
            public long sm09_LO5_Weapon_at1;
            public long sm09_LO6_Weapon_at1;

            public long sm10_LO1_Weapon_at1;
            public long sm10_LO2_Weapon_at1;
            public long sm10_LO3_Weapon_at1;
            public long sm10_LO4_Weapon_at1;
            public long sm10_LO5_Weapon_at1;
            public long sm10_LO6_Weapon_at1;
            //weapon 2nd attachment
            public long sm01_LO1_Weapon_at2;
            public long sm01_LO2_Weapon_at2;
            public long sm01_LO3_Weapon_at2;
            public long sm01_LO4_Weapon_at2;
            public long sm01_LO5_Weapon_at2;
            public long sm01_LO6_Weapon_at2;

            public long sm02_LO1_Weapon_at2;
            public long sm02_LO2_Weapon_at2;
            public long sm02_LO3_Weapon_at2;
            public long sm02_LO4_Weapon_at2;
            public long sm02_LO5_Weapon_at2;
            public long sm02_LO6_Weapon_at2;

            public long sm03_LO1_Weapon_at2;
            public long sm03_LO2_Weapon_at2;
            public long sm03_LO3_Weapon_at2;
            public long sm03_LO4_Weapon_at2;
            public long sm03_LO5_Weapon_at2;
            public long sm03_LO6_Weapon_at2;

            public long sm04_LO1_Weapon_at2;
            public long sm04_LO2_Weapon_at2;
            public long sm04_LO3_Weapon_at2;
            public long sm04_LO4_Weapon_at2;
            public long sm04_LO5_Weapon_at2;
            public long sm04_LO6_Weapon_at2;

            public long sm05_LO1_Weapon_at2;
            public long sm05_LO2_Weapon_at2;
            public long sm05_LO3_Weapon_at2;
            public long sm05_LO4_Weapon_at2;
            public long sm05_LO5_Weapon_at2;
            public long sm05_LO6_Weapon_at2;

            public long sm06_LO1_Weapon_at2;
            public long sm06_LO2_Weapon_at2;
            public long sm06_LO3_Weapon_at2;
            public long sm06_LO4_Weapon_at2;
            public long sm06_LO5_Weapon_at2;
            public long sm06_LO6_Weapon_at2;

            public long sm07_LO1_Weapon_at2;
            public long sm07_LO2_Weapon_at2;
            public long sm07_LO3_Weapon_at2;
            public long sm07_LO4_Weapon_at2;
            public long sm07_LO5_Weapon_at2;
            public long sm07_LO6_Weapon_at2;

            public long sm08_LO1_Weapon_at2;
            public long sm08_LO2_Weapon_at2;
            public long sm08_LO3_Weapon_at2;
            public long sm08_LO4_Weapon_at2;
            public long sm08_LO5_Weapon_at2;
            public long sm08_LO6_Weapon_at2;

            public long sm09_LO1_Weapon_at2;
            public long sm09_LO2_Weapon_at2;
            public long sm09_LO3_Weapon_at2;
            public long sm09_LO4_Weapon_at2;
            public long sm09_LO5_Weapon_at2;
            public long sm09_LO6_Weapon_at2;

            public long sm10_LO1_Weapon_at2;
            public long sm10_LO2_Weapon_at2;
            public long sm10_LO3_Weapon_at2;
            public long sm10_LO4_Weapon_at2;
            public long sm10_LO5_Weapon_at2;
            public long sm10_LO6_Weapon_at2;
            //weapon camos
            public long sm01_LO1_Weapon_camo;
            public long sm01_LO2_Weapon_camo;
            public long sm01_LO3_Weapon_camo;
            public long sm01_LO4_Weapon_camo;
            public long sm01_LO5_Weapon_camo;
            public long sm01_LO6_Weapon_camo;

            public long sm02_LO1_Weapon_camo;
            public long sm02_LO2_Weapon_camo;
            public long sm02_LO3_Weapon_camo;
            public long sm02_LO4_Weapon_camo;
            public long sm02_LO5_Weapon_camo;
            public long sm02_LO6_Weapon_camo;

            public long sm03_LO1_Weapon_camo;
            public long sm03_LO2_Weapon_camo;
            public long sm03_LO3_Weapon_camo;
            public long sm03_LO4_Weapon_camo;
            public long sm03_LO5_Weapon_camo;
            public long sm03_LO6_Weapon_camo;

            public long sm04_LO1_Weapon_camo;
            public long sm04_LO2_Weapon_camo;
            public long sm04_LO3_Weapon_camo;
            public long sm04_LO4_Weapon_camo;
            public long sm04_LO5_Weapon_camo;
            public long sm04_LO6_Weapon_camo;

            public long sm05_LO1_Weapon_camo;
            public long sm05_LO2_Weapon_camo;
            public long sm05_LO3_Weapon_camo;
            public long sm05_LO4_Weapon_camo;
            public long sm05_LO5_Weapon_camo;
            public long sm05_LO6_Weapon_camo;

            public long sm06_LO1_Weapon_camo;
            public long sm06_LO2_Weapon_camo;
            public long sm06_LO3_Weapon_camo;
            public long sm06_LO4_Weapon_camo;
            public long sm06_LO5_Weapon_camo;
            public long sm06_LO6_Weapon_camo;

            public long sm07_LO1_Weapon_camo;
            public long sm07_LO2_Weapon_camo;
            public long sm07_LO3_Weapon_camo;
            public long sm07_LO4_Weapon_camo;
            public long sm07_LO5_Weapon_camo;
            public long sm07_LO6_Weapon_camo;

            public long sm08_LO1_Weapon_camo;
            public long sm08_LO2_Weapon_camo;
            public long sm08_LO3_Weapon_camo;
            public long sm08_LO4_Weapon_camo;
            public long sm08_LO5_Weapon_camo;
            public long sm08_LO6_Weapon_camo;

            public long sm09_LO1_Weapon_camo;
            public long sm09_LO2_Weapon_camo;
            public long sm09_LO3_Weapon_camo;
            public long sm09_LO4_Weapon_camo;
            public long sm09_LO5_Weapon_camo;
            public long sm09_LO6_Weapon_camo;

            public long sm10_LO1_Weapon_camo;
            public long sm10_LO2_Weapon_camo;
            public long sm10_LO3_Weapon_camo;
            public long sm10_LO4_Weapon_camo;
            public long sm10_LO5_Weapon_camo;
            public long sm10_LO6_Weapon_camo;

            //2ndweapon camos
            public long sm01_LO1_2ndWeapon_camo;
            public long sm01_LO2_2ndWeapon_camo;
            public long sm01_LO3_2ndWeapon_camo;
            public long sm01_LO4_2ndWeapon_camo;
            public long sm01_LO5_2ndWeapon_camo;
            public long sm01_LO6_2ndWeapon_camo;

            public long sm02_LO1_2ndWeapon_camo;
            public long sm02_LO2_2ndWeapon_camo;
            public long sm02_LO3_2ndWeapon_camo;
            public long sm02_LO4_2ndWeapon_camo;
            public long sm02_LO5_2ndWeapon_camo;
            public long sm02_LO6_2ndWeapon_camo;

            public long sm03_LO1_2ndWeapon_camo;
            public long sm03_LO2_2ndWeapon_camo;
            public long sm03_LO3_2ndWeapon_camo;
            public long sm03_LO4_2ndWeapon_camo;
            public long sm03_LO5_2ndWeapon_camo;
            public long sm03_LO6_2ndWeapon_camo;

            public long sm04_LO1_2ndWeapon_camo;
            public long sm04_LO2_2ndWeapon_camo;
            public long sm04_LO3_2ndWeapon_camo;
            public long sm04_LO4_2ndWeapon_camo;
            public long sm04_LO5_2ndWeapon_camo;
            public long sm04_LO6_2ndWeapon_camo;

            public long sm05_LO1_2ndWeapon_camo;
            public long sm05_LO2_2ndWeapon_camo;
            public long sm05_LO3_2ndWeapon_camo;
            public long sm05_LO4_2ndWeapon_camo;
            public long sm05_LO5_2ndWeapon_camo;
            public long sm05_LO6_2ndWeapon_camo;

            public long sm06_LO1_2ndWeapon_camo;
            public long sm06_LO2_2ndWeapon_camo;
            public long sm06_LO3_2ndWeapon_camo;
            public long sm06_LO4_2ndWeapon_camo;
            public long sm06_LO5_2ndWeapon_camo;
            public long sm06_LO6_2ndWeapon_camo;

            public long sm07_LO1_2ndWeapon_camo;
            public long sm07_LO2_2ndWeapon_camo;
            public long sm07_LO3_2ndWeapon_camo;
            public long sm07_LO4_2ndWeapon_camo;
            public long sm07_LO5_2ndWeapon_camo;
            public long sm07_LO6_2ndWeapon_camo;

            public long sm08_LO1_2ndWeapon_camo;
            public long sm08_LO2_2ndWeapon_camo;
            public long sm08_LO3_2ndWeapon_camo;
            public long sm08_LO4_2ndWeapon_camo;
            public long sm08_LO5_2ndWeapon_camo;
            public long sm08_LO6_2ndWeapon_camo;

            public long sm09_LO1_2ndWeapon_camo;
            public long sm09_LO2_2ndWeapon_camo;
            public long sm09_LO3_2ndWeapon_camo;
            public long sm09_LO4_2ndWeapon_camo;
            public long sm09_LO5_2ndWeapon_camo;
            public long sm09_LO6_2ndWeapon_camo;

            public long sm10_LO1_2ndWeapon_camo;
            public long sm10_LO2_2ndWeapon_camo;
            public long sm10_LO3_2ndWeapon_camo;
            public long sm10_LO4_2ndWeapon_camo;
            public long sm10_LO5_2ndWeapon_camo;
            public long sm10_LO6_2ndWeapon_camo;
        }
        public struct loadout
        {
            public int sq_mem;
            public int ldout;
            public int weapon;
            public int fstat;
            public int scndat;
            public int camo;
            public int secondcamo;
        }

        public Form1()
        {
            InitializeComponent();          
        }

        mem ghost = new mem();
        memadr squadmember = new memadr();
        loadout ldt = new loadout();
        bool patched = false;
        bool fist_selected = false;
        bool scnd_selected = false;
        bool camo_selected = false;

        private void initial()
        {
            if (!(File.Exists("addresses.xml")))
            {
                try
                {
                    long first_name = 0x1444E82B5;
                    //first address of loadout for each sm = string[15]
                    long first_LOName1 = 0x1444E7FB7;
                    long first_LOName2 = 0x1444E851B;
                    long first_LOName3 = 0x1444E8A7F;
                    long first_LOName4 = 0x1444E8FE3;
                    long first_LOName5 = 0x1444E9547;
                    long first_LOName6 = 0x1444E9AAB;
                    long first_LOName7 = 0x1444EA00F;
                    long first_LOName8 = 0x1444EA573;
                    long first_LOName9 = 0x1444EAAD7;
                    long first_LOName10 = 0x1444EB03B;
                    //first address od weapon of 1st loadout for each sm = byte
                    long first_LOWeapon1 = 0x1444E7FD2;
                    long first_LOWeapon2 = 0x1444E8536;
                    long first_LOWeapon3 = 0x1444E8A9A;
                    long first_LOWeapon4 = 0x1444E8FFE;
                    long first_LOWeapon5 = 0x1444E9562;
                    long first_LOWeapon6 = 0x1444E9AC6;
                    long first_LOWeapon7 = 0x1444EA02A;
                    long first_LOWeapon8 = 0x1444EA58E;
                    long first_LOWeapon9 = 0x1444EAAF2;
                    long first_LOWeapon10 = 0x1444EB056;
                    //1st attachment = byte
                    long first_LOWeapon1AT1 = 0x1444E7FD4;
                    long first_LOWeapon1AT2 = 0x1444E8538;
                    long first_LOWeapon1AT3 = 0x1444E8A9C;
                    long first_LOWeapon1AT4 = 0x1444E9000;
                    long first_LOWeapon1AT5 = 0x1444E9564;
                    long first_LOWeapon1AT6 = 0x1444E9AC8;
                    long first_LOWeapon1AT7 = 0x1444EA02C;
                    long first_LOWeapon1AT8 = 0x1444EA590;
                    long first_LOWeapon1AT9 = 0x1444EAAF4;
                    long first_LOWeapon1AT10 = 0x1444EB058;
                    //2nd attachment = byte
                    long first_LOWeapon2AT1 = 0x1444E7FD6;
                    long first_LOWeapon2AT2 = 0x1444E853A;
                    long first_LOWeapon2AT3 = 0x1444E8A9E;
                    long first_LOWeapon2AT4 = 0x1444E9002;
                    long first_LOWeapon2AT5 = 0x1444E9566;
                    long first_LOWeapon2AT6 = 0x1444E9ACA;
                    long first_LOWeapon2AT7 = 0x1444EA02E;
                    long first_LOWeapon2AT8 = 0x1444EA592;
                    long first_LOWeapon2AT9 = 0x1444EAAF6;
                    long first_LOWeapon2AT10 = 0x1444EB05A;

                    long first_LO1camo1 = 0x1444E7FCC;
                    long first_LO1camo2 = 0x1444E8530;
                    long first_LO1camo3 = 0x1444E8A94;
                    long first_LO1camo4 = 0x1444E8FF8;
                    long first_LO1camo5 = 0x1444E955C;
                    long first_LO1camo6 = 0x1444E9AC0;
                    long first_LO1camo7 = 0x1444EA024;
                    long first_LO1camo8 = 0x1444EA588;
                    long first_LO1camo9 = 0x1444EAAEC;
                    long first_LO1camo10 = 0x1444EB050;

                    long first_LO1_2ndCamo = 0x1444E7FDA;
                    long first_LO1_2ndWeapon = 0x1444E7FE0;

                    long offset_out = 0x564; //offset between squadmembers
                    long offset_in_sm = 0x80; //offset inside of squadmember

                    squadmember.check1 = 0x1404D7FAA;
                    #region sm name
                    //squad member's name string[19]                    
                    squadmember.sm01_name = first_name;
                    squadmember.sm02_name = squadmember.sm01_name + offset_out;
                    squadmember.sm03_name = squadmember.sm02_name + offset_out;
                    squadmember.sm04_name = squadmember.sm03_name + offset_out;
                    squadmember.sm05_name = squadmember.sm04_name + offset_out;
                    squadmember.sm06_name = squadmember.sm05_name + offset_out;
                    squadmember.sm07_name = squadmember.sm06_name + offset_out;
                    squadmember.sm08_name = squadmember.sm07_name + offset_out;
                    squadmember.sm09_name = squadmember.sm08_name + offset_out;
                    squadmember.sm10_name = squadmember.sm09_name + offset_out;
                    #endregion
                    #region loadout name
                    //loadout name
                    squadmember.sm01_LOName1 = first_LOName1;
                    squadmember.sm01_LOName2 = squadmember.sm01_LOName1 + offset_in_sm;
                    squadmember.sm01_LOName3 = squadmember.sm01_LOName2 + offset_in_sm;
                    squadmember.sm01_LOName4 = squadmember.sm01_LOName3 + offset_in_sm;
                    squadmember.sm01_LOName5 = squadmember.sm01_LOName4 + offset_in_sm;
                    squadmember.sm01_LOName6 = squadmember.sm01_LOName5 + offset_in_sm;

                    squadmember.sm02_LOName1 = squadmember.sm01_LOName1 + offset_out;
                    squadmember.sm02_LOName2 = squadmember.sm02_LOName1 + offset_in_sm;
                    squadmember.sm02_LOName3 = squadmember.sm02_LOName2 + offset_in_sm;
                    squadmember.sm02_LOName4 = squadmember.sm02_LOName3 + offset_in_sm;
                    squadmember.sm02_LOName5 = squadmember.sm02_LOName4 + offset_in_sm;
                    squadmember.sm02_LOName6 = squadmember.sm02_LOName5 + offset_in_sm;

                    squadmember.sm03_LOName1 = squadmember.sm02_LOName1 + offset_out;
                    squadmember.sm03_LOName2 = squadmember.sm03_LOName1 + offset_in_sm;
                    squadmember.sm03_LOName3 = squadmember.sm03_LOName2 + offset_in_sm;
                    squadmember.sm03_LOName4 = squadmember.sm03_LOName3 + offset_in_sm;
                    squadmember.sm03_LOName5 = squadmember.sm03_LOName4 + offset_in_sm;
                    squadmember.sm03_LOName6 = squadmember.sm03_LOName5 + offset_in_sm;

                    squadmember.sm04_LOName1 = squadmember.sm03_LOName1 + offset_out;
                    squadmember.sm04_LOName2 = squadmember.sm04_LOName1 + offset_in_sm;
                    squadmember.sm04_LOName3 = squadmember.sm04_LOName2 + offset_in_sm;
                    squadmember.sm04_LOName4 = squadmember.sm04_LOName3 + offset_in_sm;
                    squadmember.sm04_LOName5 = squadmember.sm04_LOName4 + offset_in_sm;
                    squadmember.sm04_LOName6 = squadmember.sm04_LOName5 + offset_in_sm;

                    squadmember.sm05_LOName1 = squadmember.sm04_LOName1 + offset_out;
                    squadmember.sm05_LOName2 = squadmember.sm05_LOName1 + offset_in_sm;
                    squadmember.sm05_LOName3 = squadmember.sm05_LOName2 + offset_in_sm;
                    squadmember.sm05_LOName4 = squadmember.sm05_LOName3 + offset_in_sm;
                    squadmember.sm05_LOName5 = squadmember.sm05_LOName4 + offset_in_sm;
                    squadmember.sm05_LOName6 = squadmember.sm05_LOName5 + offset_in_sm;

                    squadmember.sm06_LOName1 = squadmember.sm05_LOName1 + offset_out;
                    squadmember.sm06_LOName2 = squadmember.sm06_LOName1 + offset_in_sm;
                    squadmember.sm06_LOName3 = squadmember.sm06_LOName2 + offset_in_sm;
                    squadmember.sm06_LOName4 = squadmember.sm06_LOName3 + offset_in_sm;
                    squadmember.sm06_LOName5 = squadmember.sm06_LOName4 + offset_in_sm;
                    squadmember.sm06_LOName6 = squadmember.sm06_LOName5 + offset_in_sm;

                    squadmember.sm07_LOName1 = squadmember.sm06_LOName1 + offset_out;
                    squadmember.sm07_LOName2 = squadmember.sm07_LOName1 + offset_in_sm;
                    squadmember.sm07_LOName3 = squadmember.sm07_LOName2 + offset_in_sm;
                    squadmember.sm07_LOName4 = squadmember.sm07_LOName3 + offset_in_sm;
                    squadmember.sm07_LOName5 = squadmember.sm07_LOName4 + offset_in_sm;
                    squadmember.sm07_LOName6 = squadmember.sm07_LOName5 + offset_in_sm;

                    squadmember.sm08_LOName1 = squadmember.sm07_LOName1 + offset_out;
                    squadmember.sm08_LOName2 = squadmember.sm08_LOName1 + offset_in_sm;
                    squadmember.sm08_LOName3 = squadmember.sm08_LOName2 + offset_in_sm;
                    squadmember.sm08_LOName4 = squadmember.sm08_LOName3 + offset_in_sm;
                    squadmember.sm08_LOName5 = squadmember.sm08_LOName4 + offset_in_sm;
                    squadmember.sm08_LOName6 = squadmember.sm08_LOName5 + offset_in_sm;

                    squadmember.sm09_LOName1 = squadmember.sm08_LOName1 + offset_out;
                    squadmember.sm09_LOName2 = squadmember.sm09_LOName1 + offset_in_sm;
                    squadmember.sm09_LOName3 = squadmember.sm09_LOName2 + offset_in_sm;
                    squadmember.sm09_LOName4 = squadmember.sm09_LOName3 + offset_in_sm;
                    squadmember.sm09_LOName5 = squadmember.sm09_LOName4 + offset_in_sm;
                    squadmember.sm09_LOName6 = squadmember.sm09_LOName5 + offset_in_sm;

                    squadmember.sm10_LOName1 = squadmember.sm09_LOName1 + offset_out;
                    squadmember.sm10_LOName2 = squadmember.sm10_LOName1 + offset_in_sm;
                    squadmember.sm10_LOName3 = squadmember.sm10_LOName2 + offset_in_sm;
                    squadmember.sm10_LOName4 = squadmember.sm10_LOName3 + offset_in_sm;
                    squadmember.sm10_LOName5 = squadmember.sm10_LOName4 + offset_in_sm;
                    squadmember.sm10_LOName6 = squadmember.sm10_LOName5 + offset_in_sm;
                    #endregion
                    #region weapon
                    //weapon
                    squadmember.sm01_LO1_Weapon = first_LOWeapon1;
                    squadmember.sm01_LO2_Weapon = squadmember.sm01_LO1_Weapon + offset_in_sm;
                    squadmember.sm01_LO3_Weapon = squadmember.sm01_LO2_Weapon + offset_in_sm;
                    squadmember.sm01_LO4_Weapon = squadmember.sm01_LO3_Weapon + offset_in_sm;
                    squadmember.sm01_LO5_Weapon = squadmember.sm01_LO4_Weapon + offset_in_sm;
                    squadmember.sm01_LO6_Weapon = squadmember.sm01_LO5_Weapon + offset_in_sm;

                    squadmember.sm02_LO1_Weapon = squadmember.sm01_LO1_Weapon + offset_out;
                    squadmember.sm02_LO2_Weapon = squadmember.sm02_LO1_Weapon + offset_in_sm;
                    squadmember.sm02_LO3_Weapon = squadmember.sm02_LO2_Weapon + offset_in_sm;
                    squadmember.sm02_LO4_Weapon = squadmember.sm02_LO3_Weapon + offset_in_sm;
                    squadmember.sm02_LO5_Weapon = squadmember.sm02_LO4_Weapon + offset_in_sm;
                    squadmember.sm02_LO6_Weapon = squadmember.sm02_LO5_Weapon + offset_in_sm;

                    squadmember.sm03_LO1_Weapon = squadmember.sm02_LO1_Weapon + offset_out;
                    squadmember.sm03_LO2_Weapon = squadmember.sm03_LO1_Weapon + offset_in_sm;
                    squadmember.sm03_LO3_Weapon = squadmember.sm03_LO2_Weapon + offset_in_sm;
                    squadmember.sm03_LO4_Weapon = squadmember.sm03_LO3_Weapon + offset_in_sm;
                    squadmember.sm03_LO5_Weapon = squadmember.sm03_LO4_Weapon + offset_in_sm;
                    squadmember.sm03_LO6_Weapon = squadmember.sm03_LO5_Weapon + offset_in_sm;

                    squadmember.sm04_LO1_Weapon = squadmember.sm03_LO1_Weapon + offset_out;
                    squadmember.sm04_LO2_Weapon = squadmember.sm04_LO1_Weapon + offset_in_sm;
                    squadmember.sm04_LO3_Weapon = squadmember.sm04_LO2_Weapon + offset_in_sm;
                    squadmember.sm04_LO4_Weapon = squadmember.sm04_LO3_Weapon + offset_in_sm;
                    squadmember.sm04_LO5_Weapon = squadmember.sm04_LO4_Weapon + offset_in_sm;
                    squadmember.sm04_LO6_Weapon = squadmember.sm04_LO5_Weapon + offset_in_sm;

                    squadmember.sm05_LO1_Weapon = squadmember.sm04_LO1_Weapon + offset_out;
                    squadmember.sm05_LO2_Weapon = squadmember.sm05_LO1_Weapon + offset_in_sm;
                    squadmember.sm05_LO3_Weapon = squadmember.sm05_LO2_Weapon + offset_in_sm;
                    squadmember.sm05_LO4_Weapon = squadmember.sm05_LO3_Weapon + offset_in_sm;
                    squadmember.sm05_LO5_Weapon = squadmember.sm05_LO4_Weapon + offset_in_sm;
                    squadmember.sm05_LO6_Weapon = squadmember.sm05_LO5_Weapon + offset_in_sm;

                    squadmember.sm06_LO1_Weapon = squadmember.sm05_LO1_Weapon + offset_out;
                    squadmember.sm06_LO2_Weapon = squadmember.sm06_LO1_Weapon + offset_in_sm;
                    squadmember.sm06_LO3_Weapon = squadmember.sm06_LO2_Weapon + offset_in_sm;
                    squadmember.sm06_LO4_Weapon = squadmember.sm06_LO3_Weapon + offset_in_sm;
                    squadmember.sm06_LO5_Weapon = squadmember.sm06_LO4_Weapon + offset_in_sm;
                    squadmember.sm06_LO6_Weapon = squadmember.sm06_LO5_Weapon + offset_in_sm;

                    squadmember.sm07_LO1_Weapon = squadmember.sm06_LO1_Weapon + offset_out;
                    squadmember.sm07_LO2_Weapon = squadmember.sm07_LO1_Weapon + offset_in_sm;
                    squadmember.sm07_LO3_Weapon = squadmember.sm07_LO2_Weapon + offset_in_sm;
                    squadmember.sm07_LO4_Weapon = squadmember.sm07_LO3_Weapon + offset_in_sm;
                    squadmember.sm07_LO5_Weapon = squadmember.sm07_LO4_Weapon + offset_in_sm;
                    squadmember.sm07_LO6_Weapon = squadmember.sm07_LO5_Weapon + offset_in_sm;

                    squadmember.sm08_LO1_Weapon = squadmember.sm07_LO1_Weapon + offset_out;
                    squadmember.sm08_LO2_Weapon = squadmember.sm08_LO1_Weapon + offset_in_sm;
                    squadmember.sm08_LO3_Weapon = squadmember.sm08_LO2_Weapon + offset_in_sm;
                    squadmember.sm08_LO4_Weapon = squadmember.sm08_LO3_Weapon + offset_in_sm;
                    squadmember.sm08_LO5_Weapon = squadmember.sm08_LO4_Weapon + offset_in_sm;
                    squadmember.sm08_LO6_Weapon = squadmember.sm08_LO5_Weapon + offset_in_sm;

                    squadmember.sm09_LO1_Weapon = squadmember.sm08_LO1_Weapon + offset_out;
                    squadmember.sm09_LO2_Weapon = squadmember.sm09_LO1_Weapon + offset_in_sm;
                    squadmember.sm09_LO3_Weapon = squadmember.sm09_LO2_Weapon + offset_in_sm;
                    squadmember.sm09_LO4_Weapon = squadmember.sm09_LO3_Weapon + offset_in_sm;
                    squadmember.sm09_LO5_Weapon = squadmember.sm09_LO4_Weapon + offset_in_sm;
                    squadmember.sm09_LO6_Weapon = squadmember.sm09_LO5_Weapon + offset_in_sm;

                    squadmember.sm10_LO1_Weapon = squadmember.sm09_LO1_Weapon + offset_out;
                    squadmember.sm10_LO2_Weapon = squadmember.sm10_LO1_Weapon + offset_in_sm;
                    squadmember.sm10_LO3_Weapon = squadmember.sm10_LO2_Weapon + offset_in_sm;
                    squadmember.sm10_LO4_Weapon = squadmember.sm10_LO3_Weapon + offset_in_sm;
                    squadmember.sm10_LO5_Weapon = squadmember.sm10_LO4_Weapon + offset_in_sm;
                    squadmember.sm10_LO6_Weapon = squadmember.sm10_LO5_Weapon + offset_in_sm;
                    #endregion
                    #region 2nd weapon
                    // 2nd weapon
                    squadmember.sm01_LO1_2ndWeapon = first_LO1_2ndWeapon;
                    squadmember.sm01_LO2_2ndWeapon = squadmember.sm01_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm01_LO3_2ndWeapon = squadmember.sm01_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm01_LO4_2ndWeapon = squadmember.sm01_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm01_LO5_2ndWeapon = squadmember.sm01_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm01_LO6_2ndWeapon = squadmember.sm01_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm02_LO1_2ndWeapon = squadmember.sm01_LO1_2ndWeapon + offset_out;
                    squadmember.sm02_LO2_2ndWeapon = squadmember.sm02_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm02_LO3_2ndWeapon = squadmember.sm02_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm02_LO4_2ndWeapon = squadmember.sm02_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm02_LO5_2ndWeapon = squadmember.sm02_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm02_LO6_2ndWeapon = squadmember.sm02_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm03_LO1_2ndWeapon = squadmember.sm02_LO1_2ndWeapon + offset_out;
                    squadmember.sm03_LO2_2ndWeapon = squadmember.sm03_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm03_LO3_2ndWeapon = squadmember.sm03_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm03_LO4_2ndWeapon = squadmember.sm03_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm03_LO5_2ndWeapon = squadmember.sm03_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm03_LO6_2ndWeapon = squadmember.sm03_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm04_LO1_2ndWeapon = squadmember.sm03_LO1_2ndWeapon + offset_out;
                    squadmember.sm04_LO2_2ndWeapon = squadmember.sm04_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm04_LO3_2ndWeapon = squadmember.sm04_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm04_LO4_2ndWeapon = squadmember.sm04_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm04_LO5_2ndWeapon = squadmember.sm04_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm04_LO6_2ndWeapon = squadmember.sm04_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm05_LO1_2ndWeapon = squadmember.sm04_LO1_2ndWeapon + offset_out;
                    squadmember.sm05_LO2_2ndWeapon = squadmember.sm05_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm05_LO3_2ndWeapon = squadmember.sm05_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm05_LO4_2ndWeapon = squadmember.sm05_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm05_LO5_2ndWeapon = squadmember.sm05_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm05_LO6_2ndWeapon = squadmember.sm05_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm06_LO1_2ndWeapon = squadmember.sm05_LO1_2ndWeapon + offset_out;
                    squadmember.sm06_LO2_2ndWeapon = squadmember.sm06_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm06_LO3_2ndWeapon = squadmember.sm06_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm06_LO4_2ndWeapon = squadmember.sm06_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm06_LO5_2ndWeapon = squadmember.sm06_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm06_LO6_2ndWeapon = squadmember.sm06_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm07_LO1_2ndWeapon = squadmember.sm06_LO1_2ndWeapon + offset_out;
                    squadmember.sm07_LO2_2ndWeapon = squadmember.sm07_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm07_LO3_2ndWeapon = squadmember.sm07_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm07_LO4_2ndWeapon = squadmember.sm07_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm07_LO5_2ndWeapon = squadmember.sm07_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm07_LO6_2ndWeapon = squadmember.sm07_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm08_LO1_2ndWeapon = squadmember.sm07_LO1_2ndWeapon + offset_out;
                    squadmember.sm08_LO2_2ndWeapon = squadmember.sm08_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm08_LO3_2ndWeapon = squadmember.sm08_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm08_LO4_2ndWeapon = squadmember.sm08_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm08_LO5_2ndWeapon = squadmember.sm08_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm08_LO6_2ndWeapon = squadmember.sm08_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm09_LO1_2ndWeapon = squadmember.sm08_LO1_2ndWeapon + offset_out;
                    squadmember.sm09_LO2_2ndWeapon = squadmember.sm09_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm09_LO3_2ndWeapon = squadmember.sm09_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm09_LO4_2ndWeapon = squadmember.sm09_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm09_LO5_2ndWeapon = squadmember.sm09_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm09_LO6_2ndWeapon = squadmember.sm09_LO5_2ndWeapon + offset_in_sm;

                    squadmember.sm10_LO1_2ndWeapon = squadmember.sm09_LO1_2ndWeapon + offset_out;
                    squadmember.sm10_LO2_2ndWeapon = squadmember.sm10_LO1_2ndWeapon + offset_in_sm;
                    squadmember.sm10_LO3_2ndWeapon = squadmember.sm10_LO2_2ndWeapon + offset_in_sm;
                    squadmember.sm10_LO4_2ndWeapon = squadmember.sm10_LO3_2ndWeapon + offset_in_sm;
                    squadmember.sm10_LO5_2ndWeapon = squadmember.sm10_LO4_2ndWeapon + offset_in_sm;
                    squadmember.sm10_LO6_2ndWeapon = squadmember.sm10_LO5_2ndWeapon + offset_in_sm;

                    #endregion
                    #region 1stattachment
                    //1st attachment
                    squadmember.sm01_LO1_Weapon_at1 = first_LOWeapon1AT1;
                    squadmember.sm01_LO2_Weapon_at1 = squadmember.sm01_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm01_LO3_Weapon_at1 = squadmember.sm01_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm01_LO4_Weapon_at1 = squadmember.sm01_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm01_LO5_Weapon_at1 = squadmember.sm01_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm01_LO6_Weapon_at1 = squadmember.sm01_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm02_LO1_Weapon_at1 = squadmember.sm01_LO1_Weapon_at1 + offset_out;
                    squadmember.sm02_LO2_Weapon_at1 = squadmember.sm02_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm02_LO3_Weapon_at1 = squadmember.sm02_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm02_LO4_Weapon_at1 = squadmember.sm02_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm02_LO5_Weapon_at1 = squadmember.sm02_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm02_LO6_Weapon_at1 = squadmember.sm02_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm03_LO1_Weapon_at1 = squadmember.sm02_LO1_Weapon_at1 + offset_out;
                    squadmember.sm03_LO2_Weapon_at1 = squadmember.sm03_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm03_LO3_Weapon_at1 = squadmember.sm03_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm03_LO4_Weapon_at1 = squadmember.sm03_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm03_LO5_Weapon_at1 = squadmember.sm03_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm03_LO6_Weapon_at1 = squadmember.sm03_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm04_LO1_Weapon_at1 = squadmember.sm03_LO1_Weapon_at1 + offset_out;
                    squadmember.sm04_LO2_Weapon_at1 = squadmember.sm04_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm04_LO3_Weapon_at1 = squadmember.sm04_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm04_LO4_Weapon_at1 = squadmember.sm04_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm04_LO5_Weapon_at1 = squadmember.sm04_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm04_LO6_Weapon_at1 = squadmember.sm04_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm04_LO1_Weapon_at1 = squadmember.sm04_LO1_Weapon_at1 + offset_out;
                    squadmember.sm05_LO2_Weapon_at1 = squadmember.sm05_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm05_LO3_Weapon_at1 = squadmember.sm05_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm05_LO4_Weapon_at1 = squadmember.sm05_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm05_LO5_Weapon_at1 = squadmember.sm05_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm05_LO6_Weapon_at1 = squadmember.sm05_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm06_LO1_Weapon_at1 = squadmember.sm05_LO1_Weapon_at1 + offset_out;
                    squadmember.sm06_LO2_Weapon_at1 = squadmember.sm06_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm06_LO3_Weapon_at1 = squadmember.sm06_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm06_LO4_Weapon_at1 = squadmember.sm06_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm06_LO5_Weapon_at1 = squadmember.sm06_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm06_LO6_Weapon_at1 = squadmember.sm06_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm07_LO1_Weapon_at1 = squadmember.sm06_LO1_Weapon_at1 + offset_out;
                    squadmember.sm07_LO2_Weapon_at1 = squadmember.sm07_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm07_LO3_Weapon_at1 = squadmember.sm07_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm07_LO4_Weapon_at1 = squadmember.sm07_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm07_LO5_Weapon_at1 = squadmember.sm07_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm07_LO6_Weapon_at1 = squadmember.sm07_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm08_LO1_Weapon_at1 = squadmember.sm07_LO1_Weapon_at1 + offset_out;
                    squadmember.sm08_LO2_Weapon_at1 = squadmember.sm08_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm08_LO3_Weapon_at1 = squadmember.sm08_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm08_LO4_Weapon_at1 = squadmember.sm08_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm08_LO5_Weapon_at1 = squadmember.sm08_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm08_LO6_Weapon_at1 = squadmember.sm08_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm09_LO1_Weapon_at1 = squadmember.sm08_LO1_Weapon_at1 + offset_out;
                    squadmember.sm09_LO2_Weapon_at1 = squadmember.sm09_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm09_LO3_Weapon_at1 = squadmember.sm09_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm09_LO4_Weapon_at1 = squadmember.sm09_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm09_LO5_Weapon_at1 = squadmember.sm09_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm09_LO6_Weapon_at1 = squadmember.sm09_LO5_Weapon_at1 + offset_in_sm;

                    squadmember.sm10_LO1_Weapon_at1 = squadmember.sm09_LO1_Weapon_at1 + offset_out;
                    squadmember.sm10_LO2_Weapon_at1 = squadmember.sm10_LO1_Weapon_at1 + offset_in_sm;
                    squadmember.sm10_LO3_Weapon_at1 = squadmember.sm10_LO2_Weapon_at1 + offset_in_sm;
                    squadmember.sm10_LO4_Weapon_at1 = squadmember.sm10_LO3_Weapon_at1 + offset_in_sm;
                    squadmember.sm10_LO5_Weapon_at1 = squadmember.sm10_LO4_Weapon_at1 + offset_in_sm;
                    squadmember.sm10_LO6_Weapon_at1 = squadmember.sm10_LO5_Weapon_at1 + offset_in_sm;
                    #endregion
                    #region 2nd attachment
                    //2nd attachment
                    squadmember.sm01_LO1_Weapon_at2 = first_LOWeapon2AT1;
                    squadmember.sm01_LO2_Weapon_at2 = squadmember.sm01_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm01_LO3_Weapon_at2 = squadmember.sm01_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm01_LO4_Weapon_at2 = squadmember.sm01_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm01_LO5_Weapon_at2 = squadmember.sm01_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm01_LO6_Weapon_at2 = squadmember.sm01_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm02_LO1_Weapon_at2 = squadmember.sm01_LO1_Weapon_at2 + offset_out;
                    squadmember.sm02_LO2_Weapon_at2 = squadmember.sm02_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm02_LO3_Weapon_at2 = squadmember.sm02_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm02_LO4_Weapon_at2 = squadmember.sm02_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm02_LO5_Weapon_at2 = squadmember.sm02_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm02_LO6_Weapon_at2 = squadmember.sm02_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm03_LO1_Weapon_at2 = squadmember.sm02_LO1_Weapon_at2 + offset_out;
                    squadmember.sm03_LO2_Weapon_at2 = squadmember.sm03_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm03_LO3_Weapon_at2 = squadmember.sm03_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm03_LO4_Weapon_at2 = squadmember.sm03_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm03_LO5_Weapon_at2 = squadmember.sm03_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm03_LO6_Weapon_at2 = squadmember.sm03_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm04_LO1_Weapon_at2 = squadmember.sm03_LO1_Weapon_at2 + offset_out;
                    squadmember.sm04_LO2_Weapon_at2 = squadmember.sm04_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm04_LO3_Weapon_at2 = squadmember.sm04_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm04_LO4_Weapon_at2 = squadmember.sm04_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm04_LO5_Weapon_at2 = squadmember.sm04_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm04_LO6_Weapon_at2 = squadmember.sm04_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm04_LO1_Weapon_at2 = squadmember.sm04_LO1_Weapon_at2 + offset_out;
                    squadmember.sm05_LO2_Weapon_at2 = squadmember.sm05_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm05_LO3_Weapon_at2 = squadmember.sm05_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm05_LO4_Weapon_at2 = squadmember.sm05_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm05_LO5_Weapon_at2 = squadmember.sm05_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm05_LO6_Weapon_at2 = squadmember.sm05_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm06_LO1_Weapon_at2 = squadmember.sm05_LO1_Weapon_at2 + offset_out;
                    squadmember.sm06_LO2_Weapon_at2 = squadmember.sm06_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm06_LO3_Weapon_at2 = squadmember.sm06_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm06_LO4_Weapon_at2 = squadmember.sm06_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm06_LO5_Weapon_at2 = squadmember.sm06_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm06_LO6_Weapon_at2 = squadmember.sm06_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm07_LO1_Weapon_at2 = squadmember.sm06_LO1_Weapon_at2 + offset_out;
                    squadmember.sm07_LO2_Weapon_at2 = squadmember.sm07_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm07_LO3_Weapon_at2 = squadmember.sm07_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm07_LO4_Weapon_at2 = squadmember.sm07_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm07_LO5_Weapon_at2 = squadmember.sm07_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm07_LO6_Weapon_at2 = squadmember.sm07_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm08_LO1_Weapon_at2 = squadmember.sm07_LO1_Weapon_at2 + offset_out;
                    squadmember.sm08_LO2_Weapon_at2 = squadmember.sm08_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm08_LO3_Weapon_at2 = squadmember.sm08_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm08_LO4_Weapon_at2 = squadmember.sm08_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm08_LO5_Weapon_at2 = squadmember.sm08_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm08_LO6_Weapon_at2 = squadmember.sm08_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm09_LO1_Weapon_at2 = squadmember.sm08_LO1_Weapon_at2 + offset_out;
                    squadmember.sm09_LO2_Weapon_at2 = squadmember.sm09_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm09_LO3_Weapon_at2 = squadmember.sm09_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm09_LO4_Weapon_at2 = squadmember.sm09_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm09_LO5_Weapon_at2 = squadmember.sm09_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm09_LO6_Weapon_at2 = squadmember.sm09_LO5_Weapon_at2 + offset_in_sm;

                    squadmember.sm10_LO1_Weapon_at2 = squadmember.sm09_LO1_Weapon_at2 + offset_out;
                    squadmember.sm10_LO2_Weapon_at2 = squadmember.sm10_LO1_Weapon_at2 + offset_in_sm;
                    squadmember.sm10_LO3_Weapon_at2 = squadmember.sm10_LO2_Weapon_at2 + offset_in_sm;
                    squadmember.sm10_LO4_Weapon_at2 = squadmember.sm10_LO3_Weapon_at2 + offset_in_sm;
                    squadmember.sm10_LO5_Weapon_at2 = squadmember.sm10_LO4_Weapon_at2 + offset_in_sm;
                    squadmember.sm10_LO6_Weapon_at2 = squadmember.sm10_LO5_Weapon_at2 + offset_in_sm;
                    #endregion
                    #region camos
                    //camos
                    squadmember.sm01_LO1_Weapon_camo = first_LO1camo1;
                    squadmember.sm01_LO2_Weapon_camo = squadmember.sm01_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm01_LO3_Weapon_camo = squadmember.sm01_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm01_LO4_Weapon_camo = squadmember.sm01_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm01_LO5_Weapon_camo = squadmember.sm01_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm01_LO6_Weapon_camo = squadmember.sm01_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm02_LO1_Weapon_camo = squadmember.sm01_LO1_Weapon_camo + offset_out;
                    squadmember.sm02_LO2_Weapon_camo = squadmember.sm02_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm02_LO3_Weapon_camo = squadmember.sm02_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm02_LO4_Weapon_camo = squadmember.sm02_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm02_LO5_Weapon_camo = squadmember.sm02_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm02_LO6_Weapon_camo = squadmember.sm02_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm03_LO1_Weapon_camo = squadmember.sm02_LO1_Weapon_camo + offset_out;
                    squadmember.sm03_LO2_Weapon_camo = squadmember.sm03_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm03_LO3_Weapon_camo = squadmember.sm03_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm03_LO4_Weapon_camo = squadmember.sm03_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm03_LO5_Weapon_camo = squadmember.sm03_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm03_LO6_Weapon_camo = squadmember.sm03_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm04_LO1_Weapon_camo = squadmember.sm03_LO1_Weapon_camo + offset_out;
                    squadmember.sm04_LO2_Weapon_camo = squadmember.sm04_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm04_LO3_Weapon_camo = squadmember.sm04_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm04_LO4_Weapon_camo = squadmember.sm04_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm04_LO5_Weapon_camo = squadmember.sm04_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm04_LO6_Weapon_camo = squadmember.sm04_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm05_LO1_Weapon_camo = squadmember.sm04_LO1_Weapon_camo + offset_out;
                    squadmember.sm05_LO2_Weapon_camo = squadmember.sm05_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm05_LO3_Weapon_camo = squadmember.sm05_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm05_LO4_Weapon_camo = squadmember.sm05_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm05_LO5_Weapon_camo = squadmember.sm05_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm05_LO6_Weapon_camo = squadmember.sm05_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm06_LO1_Weapon_camo = squadmember.sm05_LO1_Weapon_camo + offset_out;
                    squadmember.sm06_LO2_Weapon_camo = squadmember.sm06_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm06_LO3_Weapon_camo = squadmember.sm06_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm06_LO4_Weapon_camo = squadmember.sm06_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm06_LO5_Weapon_camo = squadmember.sm06_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm06_LO6_Weapon_camo = squadmember.sm06_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm07_LO1_Weapon_camo = squadmember.sm06_LO1_Weapon_camo + offset_out;
                    squadmember.sm07_LO2_Weapon_camo = squadmember.sm07_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm07_LO3_Weapon_camo = squadmember.sm07_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm07_LO4_Weapon_camo = squadmember.sm07_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm07_LO5_Weapon_camo = squadmember.sm07_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm07_LO6_Weapon_camo = squadmember.sm07_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm08_LO1_Weapon_camo = squadmember.sm07_LO1_Weapon_camo + offset_out;
                    squadmember.sm08_LO2_Weapon_camo = squadmember.sm08_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm08_LO3_Weapon_camo = squadmember.sm08_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm08_LO4_Weapon_camo = squadmember.sm08_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm08_LO5_Weapon_camo = squadmember.sm08_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm08_LO6_Weapon_camo = squadmember.sm08_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm09_LO1_Weapon_camo = squadmember.sm08_LO1_Weapon_camo + offset_out;
                    squadmember.sm09_LO2_Weapon_camo = squadmember.sm09_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm09_LO3_Weapon_camo = squadmember.sm09_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm09_LO4_Weapon_camo = squadmember.sm09_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm09_LO5_Weapon_camo = squadmember.sm09_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm09_LO6_Weapon_camo = squadmember.sm09_LO5_Weapon_camo + offset_in_sm;

                    squadmember.sm10_LO1_Weapon_camo = squadmember.sm09_LO1_Weapon_camo + offset_out;
                    squadmember.sm10_LO2_Weapon_camo = squadmember.sm10_LO1_Weapon_camo + offset_in_sm;
                    squadmember.sm10_LO3_Weapon_camo = squadmember.sm10_LO2_Weapon_camo + offset_in_sm;
                    squadmember.sm10_LO4_Weapon_camo = squadmember.sm10_LO3_Weapon_camo + offset_in_sm;
                    squadmember.sm10_LO5_Weapon_camo = squadmember.sm10_LO4_Weapon_camo + offset_in_sm;
                    squadmember.sm10_LO6_Weapon_camo = squadmember.sm10_LO5_Weapon_camo + offset_in_sm;
                    #endregion
                    #region 2nd camos
                    //2nd camos
                    squadmember.sm01_LO1_2ndWeapon_camo = first_LO1_2ndCamo;
                    squadmember.sm01_LO2_2ndWeapon_camo = squadmember.sm01_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm01_LO3_2ndWeapon_camo = squadmember.sm01_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm01_LO4_2ndWeapon_camo = squadmember.sm01_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm01_LO5_2ndWeapon_camo = squadmember.sm01_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm01_LO6_2ndWeapon_camo = squadmember.sm01_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm02_LO1_2ndWeapon_camo = squadmember.sm01_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm02_LO2_2ndWeapon_camo = squadmember.sm02_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm02_LO3_2ndWeapon_camo = squadmember.sm02_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm02_LO4_2ndWeapon_camo = squadmember.sm02_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm02_LO5_2ndWeapon_camo = squadmember.sm02_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm02_LO6_2ndWeapon_camo = squadmember.sm02_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm03_LO1_2ndWeapon_camo = squadmember.sm02_LO1_2ndWeapon_camo + offset_out; 
                    squadmember.sm03_LO2_2ndWeapon_camo = squadmember.sm03_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm03_LO3_2ndWeapon_camo = squadmember.sm03_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm03_LO4_2ndWeapon_camo = squadmember.sm03_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm03_LO5_2ndWeapon_camo = squadmember.sm03_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm03_LO6_2ndWeapon_camo = squadmember.sm03_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm04_LO1_2ndWeapon_camo = squadmember.sm03_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm04_LO2_2ndWeapon_camo = squadmember.sm04_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm04_LO3_2ndWeapon_camo = squadmember.sm04_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm04_LO4_2ndWeapon_camo = squadmember.sm04_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm04_LO5_2ndWeapon_camo = squadmember.sm04_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm04_LO6_2ndWeapon_camo = squadmember.sm04_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm05_LO1_2ndWeapon_camo = squadmember.sm04_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm05_LO2_2ndWeapon_camo = squadmember.sm05_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm05_LO3_2ndWeapon_camo = squadmember.sm05_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm05_LO4_2ndWeapon_camo = squadmember.sm05_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm05_LO5_2ndWeapon_camo = squadmember.sm05_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm05_LO6_2ndWeapon_camo = squadmember.sm05_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm06_LO1_2ndWeapon_camo = squadmember.sm05_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm06_LO2_2ndWeapon_camo = squadmember.sm06_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm06_LO3_2ndWeapon_camo = squadmember.sm06_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm06_LO4_2ndWeapon_camo = squadmember.sm06_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm06_LO5_2ndWeapon_camo = squadmember.sm06_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm06_LO6_2ndWeapon_camo = squadmember.sm06_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm07_LO1_2ndWeapon_camo = squadmember.sm06_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm07_LO2_2ndWeapon_camo = squadmember.sm07_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm07_LO3_2ndWeapon_camo = squadmember.sm07_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm07_LO4_2ndWeapon_camo = squadmember.sm07_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm07_LO5_2ndWeapon_camo = squadmember.sm07_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm07_LO6_2ndWeapon_camo = squadmember.sm07_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm08_LO1_2ndWeapon_camo = squadmember.sm07_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm08_LO2_2ndWeapon_camo = squadmember.sm08_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm08_LO3_2ndWeapon_camo = squadmember.sm08_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm08_LO4_2ndWeapon_camo = squadmember.sm08_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm08_LO5_2ndWeapon_camo = squadmember.sm08_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm08_LO6_2ndWeapon_camo = squadmember.sm08_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm09_LO1_2ndWeapon_camo = squadmember.sm08_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm09_LO2_2ndWeapon_camo = squadmember.sm09_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm09_LO3_2ndWeapon_camo = squadmember.sm09_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm09_LO4_2ndWeapon_camo = squadmember.sm09_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm09_LO5_2ndWeapon_camo = squadmember.sm09_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm09_LO6_2ndWeapon_camo = squadmember.sm09_LO5_2ndWeapon_camo + offset_in_sm;

                    squadmember.sm10_LO1_2ndWeapon_camo = squadmember.sm09_LO1_2ndWeapon_camo + offset_out;
                    squadmember.sm10_LO2_2ndWeapon_camo = squadmember.sm10_LO1_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm10_LO3_2ndWeapon_camo = squadmember.sm10_LO2_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm10_LO4_2ndWeapon_camo = squadmember.sm10_LO3_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm10_LO5_2ndWeapon_camo = squadmember.sm10_LO4_2ndWeapon_camo + offset_in_sm;
                    squadmember.sm10_LO6_2ndWeapon_camo = squadmember.sm10_LO5_2ndWeapon_camo + offset_in_sm;

                    #endregion
                    XmlSerializer x = new XmlSerializer(squadmember.GetType());
                    StreamWriter file = new StreamWriter("maverick_addresses.xml");
                    x.Serialize(file, squadmember);
                    file.Close();
                }
                catch { MessageBox.Show("Can not creat file maverick_addresses.sml "); }
            }
            else
            {
                try
                {
                    XmlSerializer x = new XmlSerializer(squadmember.GetType());
                    StreamReader file = new StreamReader("maverick_addresses.xml");
                    squadmember = (memadr)x.Deserialize(file);
                }
                catch { MessageBox.Show("Can not deserialise addresses.xml"); }
            }
        }

        private void fix_mem()
        {
            if (patched) { return; }
            else
            {
                if (ghost.ProcHandle("iw6mp64_ship"))
                {
                    ghost.WriteByte(squadmember.check1,BitConverter.GetBytes(0x75));
                    patched = true;
                }
            }
        }

        private void restore_mem()
        {
            if (ghost.ProcHandle("iw6mp64_ship"))
            {
                ghost.WriteByte(squadmember.check1, BitConverter.GetBytes(0x74));
                patched = false;
            }
        }
           
        private string get_name(byte[] buf)
        {

            string string_name = "";
            int i;
            for (i = 0; i < buf.Length; i++)
            {
                if (buf[i] == 0) { break; }
            }
            byte[] byte_name = new byte[i];
            for (int j = 0; j < i; j++)
            {
                byte_name[j] = buf[j];
            }
            string_name = new ASCIIEncoding().GetString(byte_name);
            return string_name;
        }

        private void change_cmbox2()
        {
            if (comboBox1.SelectedIndex == 0) { update_cmbox2(1); };
            if (comboBox1.SelectedIndex == 1) { update_cmbox2(2); };
            if (comboBox1.SelectedIndex == 2) { update_cmbox2(3); };
            if (comboBox1.SelectedIndex == 3) { update_cmbox2(4); };
            if (comboBox1.SelectedIndex == 4) { update_cmbox2(5); };
            if (comboBox1.SelectedIndex == 5) { update_cmbox2(6); };
            if (comboBox1.SelectedIndex == 6) { update_cmbox2(7); };
            if (comboBox1.SelectedIndex == 7) { update_cmbox2(8); };
            if (comboBox1.SelectedIndex == 8) { update_cmbox2(9); };
            if (comboBox1.SelectedIndex == 9) { update_cmbox2(10); };
        }

        private void update_cmbox2(int sm_num)
        {
            comboBox2.Items.Clear();
            if (ghost.ProcHandle("iw6mp64_ship"))
            {
                if (sm_num == 1)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm01_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm01_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm01_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm01_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm01_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm01_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 2)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm02_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm02_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm02_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm02_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm02_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm02_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 3)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm03_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm03_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm03_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm03_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm03_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm03_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 4)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm04_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm04_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm04_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm04_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm04_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm04_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 5)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm05_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm05_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm05_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm05_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm05_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm05_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 6)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm06_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm06_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm06_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm06_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm06_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm06_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 7)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm07_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm07_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm07_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm07_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm07_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm07_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 8)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm08_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm08_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm08_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm08_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm08_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm08_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 9)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm09_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm09_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm09_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm09_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm09_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm09_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
                if (sm_num == 10)
                {
                    byte[] buf = ghost.ReadBytes(squadmember.sm10_LOName1, 15);
                    comboBox2.Items.Add(get_name(buf));
                    comboBox2.Text = comboBox2.Items[0].ToString();
                    buf = ghost.ReadBytes(squadmember.sm10_LOName2, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm10_LOName3, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm10_LOName4, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm10_LOName5, 15);
                    comboBox2.Items.Add(get_name(buf));
                    buf = ghost.ReadBytes(squadmember.sm10_LOName6, 15);
                    comboBox2.Items.Add(get_name(buf));
                }
            }
        }
        private void memcheck()
        {
            byte[] buf1 = ghost.ReadBytes(squadmember.check1, 2);
            if (buf1[0] == 116) { label2.Text = "Weapon check is activated"; label2.ForeColor = Color.Red; }
            else { if (buf1[0] == 117) { label2.Text = "Weapon check is diactivated"; label2.ForeColor = Color.Green; }; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popupForm2 popup = new popupForm2();              // your popup form we just created
            DialogResult dialogresult = popup.ShowDialog();      // closing the popup form when we click the OK button
            if (dialogresult == DialogResult.OK)
            {
                popup.Dispose();
            }
            initial();
            if (ghost.ProcHandle("iw6mp64_ship"))
            {
                byte[] buf = ghost.ReadBytes(squadmember.sm01_name, 19);
                comboBox1.Items.Add(get_name(buf));
                comboBox1.Text = comboBox1.Items[0].ToString();
                buf = ghost.ReadBytes(squadmember.sm02_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm03_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm04_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm05_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm06_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm07_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm08_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm09_name, 19);
                comboBox1.Items.Add(get_name(buf));
                buf = ghost.ReadBytes(squadmember.sm10_name, 19);
                comboBox1.Items.Add(get_name(buf));

                change_cmbox2();
                
                ldt.sq_mem = 1;
                ldt.ldout = 1;
                ldt.weapon = 87;
                ldt.fstat = 15;
                ldt.scndat = 15;
                ldt.camo = 0;
                ldt.secondcamo = 0;
                memcheck();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_cmbox2();
            ldt.sq_mem = comboBox1.SelectedIndex+1;
            weapon_camo();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ldt.ldout = comboBox2.SelectedIndex+1;
            weapon_camo();
        }

        private void Attachments(int num, string type, Image img)
        {
            if (!fist_selected)
            {
                fist_selected = true;
                ldt.fstat = num;
                pictureBox2.Image = img;
                if (type == "s1") { groupBox6.Enabled = false; };
                if (type == "s2") { groupBox10.Enabled = false; };
                if (type == "b1") { groupBox7.Enabled = false; };
                if (type == "b2") { groupBox11.Enabled = false; };
                if (type == "u1") { groupBox8.Enabled = false; };
                if (type == "m1") { groupBox9.Enabled = false; };
                if (type == "m1") { groupBox12.Enabled = false; };
            }
            else 
            {
                if (!scnd_selected)
                {
                    scnd_selected = true;
                    ldt.scndat = num;
                    pictureBox3.Image = img;
                    if (type == "s1") { groupBox2.Enabled = false; };
                    if (type == "s2") { groupBox3.Enabled = false; };
                    if (type == "b1") { groupBox2.Enabled = false; };
                    if (type == "b2") { groupBox3.Enabled = false; };
                    if (type == "u1") { groupBox2.Enabled = false; };
                    if (type == "m1") { groupBox2.Enabled = false; };
                    if (type == "m2") { groupBox3.Enabled = false; };
                }
            }
        }

        private void reset_attachments()
        {
            ldt.camo = 0;
            ldt.fstat = 15;
            ldt.scndat = 15;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox6.Enabled = true;
            groupBox7.Enabled = true;
            groupBox8.Enabled = true;
            groupBox9.Enabled = true;
            groupBox10.Enabled = true;
            groupBox11.Enabled = true;
            groupBox12.Enabled = true;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            fist_selected = false;
            scnd_selected = false;
            camo_selected = false;
        }

        private void camos(int num, Image pic)
        {
            if (radioButton3.Checked)
            {
                if (radioButton4.Checked)
                {
                    pictureBox6.Image = pic;
                    ldt.camo = num;
                }
                else
                {
                    if (radioButton5.Checked)
                    {
                        pictureBox7.Image = pic;
                        ldt.secondcamo = num;
                    }
                }
            }
            else
            {
                if (!camo_selected)
                {
                    camo_selected = true;
                    ldt.camo = num;
                    pictureBox4.Image = pic;
                    groupBox4.Enabled = false;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)Properties.Resources.maverick_ar;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            ldt.weapon = 87;
            ldt.secondcamo = 0;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            reset_attachments();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = (Image)Properties.Resources.maverick_sr;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            ldt.weapon = 89;
            ldt.secondcamo = 0;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point(12,151);
            reset_attachments();
        }


        #region attachment buttons
        private void button1_Click(object sender, EventArgs e)
        {
            Attachments(16, "s1", button1.BackgroundImage);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Attachments(0, "s1", button2.BackgroundImage);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Attachments(5, "s1", button3.BackgroundImage);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Attachments(13, "s1", button4.BackgroundImage);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Attachments(24, "s1", button5.BackgroundImage);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Attachments(25, "s1", button6.BackgroundImage);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Attachments(9, "b1", button7.BackgroundImage);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Attachments(22, "b1", button8.BackgroundImage);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Attachments(4, "b1", button9.BackgroundImage);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Attachments(12, "u1", button10.BackgroundImage);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Attachments(21, "u1", button11.BackgroundImage);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Attachments(11, "u1", button12.BackgroundImage);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            Attachments(27, "m1", button13.BackgroundImage);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Attachments(10, "m1", button14.BackgroundImage);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Attachments(8, "m1", button15.BackgroundImage);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            Attachments(7, "m1", button16.BackgroundImage);
        }
        private void button17_Click(object sender, EventArgs e)
        {
            Attachments(0, "s2", button17.BackgroundImage);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Attachments(24, "s2", button18.BackgroundImage);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Attachments(26, "s2", button19.BackgroundImage);
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Attachments(22, "b2", button20.BackgroundImage);
        }
        private void button21_Click(object sender, EventArgs e)
        {
            Attachments(3, "b2", button21.BackgroundImage);
        }
        private void button22_Click(object sender, EventArgs e)
        {
            Attachments(27, "m2", button22.BackgroundImage);
        }
        private void button23_Click(object sender, EventArgs e)
        {
            Attachments(10, "m2", button23.BackgroundImage);
        }
        #endregion
        #region camo buttons
        private void button24_Click(object sender, EventArgs e)
        {
            camos(0, button24.BackgroundImage);
        }
        private void button25_Click(object sender, EventArgs e)
        {
            camos(1, button25.BackgroundImage);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            camos(2, button26.BackgroundImage);
        }
        private void button27_Click(object sender, EventArgs e)
        {
            camos(5, button27.BackgroundImage);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            camos(4, button28.BackgroundImage);
        }
        private void button29_Click(object sender, EventArgs e)
        {
            camos(3, button29.BackgroundImage);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            camos(8, button30.BackgroundImage);
        }
        private void button31_Click(object sender, EventArgs e)
        {
            camos(7, button31.BackgroundImage);
        }
        private void button32_Click(object sender, EventArgs e)
        {
            camos(6, button32.BackgroundImage);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            camos(11, button33.BackgroundImage);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            camos(10, button34.BackgroundImage);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            camos(9, button35.BackgroundImage);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            camos(14, button36.BackgroundImage);
        }
        private void button37_Click(object sender, EventArgs e)
        {
            camos(13, button37.BackgroundImage);
        }
        private void button38_Click(object sender, EventArgs e)
        {
            camos(12, button38.BackgroundImage);
        }
        private void button39_Click(object sender, EventArgs e)
        {
            camos(19, button39.BackgroundImage);
        }
        private void button40_Click(object sender, EventArgs e)
        {
            camos(18, button40.BackgroundImage);
        }
        private void button41_Click(object sender, EventArgs e)
        {
            camos(15, button41.BackgroundImage);
        }
        private void button42_Click(object sender, EventArgs e)
        {
            camos(23, button42.BackgroundImage);
        }
        private void button43_Click(object sender, EventArgs e)
        {
            camos(21, button43.BackgroundImage);
        }
        private void button44_Click(object sender, EventArgs e)
        {
            camos(20, button44.BackgroundImage);
        }
        private void button45_Click(object sender, EventArgs e)
        {
            camos(26, button45.BackgroundImage);
        }
        private void button46_Click(object sender, EventArgs e)
        {
            camos(25, button46.BackgroundImage);
        }
        private void button47_Click(object sender, EventArgs e)
        {
            camos(24, button47.BackgroundImage);
        }
        private void button48_Click(object sender, EventArgs e)
        {
            camos(29, button48.BackgroundImage);
        }
        private void button49_Click(object sender, EventArgs e)
        {
            camos(28, button49.BackgroundImage);
        }
        private void button50_Click(object sender, EventArgs e)
        {
            camos(27, button50.BackgroundImage);
        }
        private void button51_Click(object sender, EventArgs e)
        {
            camos(32, button51.BackgroundImage);
        }
        private void button52_Click(object sender, EventArgs e)
        {
            camos(31, button52.BackgroundImage);
        }
        private void button53_Click(object sender, EventArgs e)
        {
            camos(30, button53.BackgroundImage);
        }
        #endregion

        private void button56_Click(object sender, EventArgs e)
        {
            label1.Text = "sq_mem = " + ldt.sq_mem.ToString() + "\r\n ldout = " + ldt.ldout + "\r\n weapon = " + ldt.weapon + "\r\n 1st attachment = " + ldt.fstat + "\r\n 2nd attachment = " + ldt.scndat + "\r\n camo = " + ldt.camo+"\r\n 2nd camo"+ldt.secondcamo;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            reset_attachments();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            restore_mem();
            memcheck();

        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (ldt.sq_mem == 1)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm01_LO1_Weapon, squadmember.sm01_LO1_Weapon_at1, squadmember.sm01_LO1_Weapon_at2, squadmember.sm01_LO1_Weapon_camo, squadmember.sm01_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm01_LO2_Weapon, squadmember.sm01_LO2_Weapon_at1, squadmember.sm01_LO2_Weapon_at2, squadmember.sm01_LO2_Weapon_camo, squadmember.sm01_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm01_LO3_Weapon, squadmember.sm01_LO3_Weapon_at1, squadmember.sm01_LO3_Weapon_at2, squadmember.sm01_LO3_Weapon_camo, squadmember.sm01_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm01_LO4_Weapon, squadmember.sm01_LO4_Weapon_at1, squadmember.sm01_LO4_Weapon_at2, squadmember.sm01_LO4_Weapon_camo, squadmember.sm01_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm01_LO5_Weapon, squadmember.sm01_LO5_Weapon_at1, squadmember.sm01_LO5_Weapon_at2, squadmember.sm01_LO5_Weapon_camo, squadmember.sm01_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm01_LO6_Weapon, squadmember.sm01_LO6_Weapon_at1, squadmember.sm01_LO6_Weapon_at2, squadmember.sm01_LO6_Weapon_camo, squadmember.sm01_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 2)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm02_LO1_Weapon, squadmember.sm02_LO1_Weapon_at1, squadmember.sm02_LO1_Weapon_at2, squadmember.sm02_LO1_Weapon_camo, squadmember.sm02_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm02_LO2_Weapon, squadmember.sm02_LO2_Weapon_at1, squadmember.sm02_LO2_Weapon_at2, squadmember.sm02_LO2_Weapon_camo, squadmember.sm02_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm02_LO3_Weapon, squadmember.sm02_LO3_Weapon_at1, squadmember.sm02_LO3_Weapon_at2, squadmember.sm02_LO3_Weapon_camo, squadmember.sm02_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm02_LO4_Weapon, squadmember.sm02_LO4_Weapon_at1, squadmember.sm02_LO4_Weapon_at2, squadmember.sm02_LO4_Weapon_camo, squadmember.sm02_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm02_LO5_Weapon, squadmember.sm02_LO5_Weapon_at1, squadmember.sm02_LO5_Weapon_at2, squadmember.sm02_LO5_Weapon_camo, squadmember.sm02_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm02_LO6_Weapon, squadmember.sm02_LO6_Weapon_at1, squadmember.sm02_LO6_Weapon_at2, squadmember.sm02_LO6_Weapon_camo, squadmember.sm02_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 3)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm03_LO1_Weapon, squadmember.sm03_LO1_Weapon_at1, squadmember.sm03_LO1_Weapon_at2, squadmember.sm03_LO1_Weapon_camo, squadmember.sm03_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm03_LO2_Weapon, squadmember.sm03_LO2_Weapon_at1, squadmember.sm03_LO2_Weapon_at2, squadmember.sm03_LO2_Weapon_camo, squadmember.sm03_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm03_LO3_Weapon, squadmember.sm03_LO3_Weapon_at1, squadmember.sm03_LO3_Weapon_at2, squadmember.sm03_LO3_Weapon_camo, squadmember.sm03_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm03_LO4_Weapon, squadmember.sm03_LO4_Weapon_at1, squadmember.sm03_LO4_Weapon_at2, squadmember.sm03_LO4_Weapon_camo, squadmember.sm03_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm03_LO5_Weapon, squadmember.sm03_LO5_Weapon_at1, squadmember.sm03_LO5_Weapon_at2, squadmember.sm03_LO5_Weapon_camo, squadmember.sm03_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm03_LO6_Weapon, squadmember.sm03_LO6_Weapon_at1, squadmember.sm03_LO6_Weapon_at2, squadmember.sm03_LO6_Weapon_camo, squadmember.sm03_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 4)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm04_LO1_Weapon, squadmember.sm04_LO1_Weapon_at1, squadmember.sm04_LO1_Weapon_at2, squadmember.sm04_LO1_Weapon_camo, squadmember.sm04_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm04_LO2_Weapon, squadmember.sm04_LO2_Weapon_at1, squadmember.sm04_LO2_Weapon_at2, squadmember.sm04_LO2_Weapon_camo, squadmember.sm04_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm04_LO3_Weapon, squadmember.sm04_LO3_Weapon_at1, squadmember.sm04_LO3_Weapon_at2, squadmember.sm04_LO3_Weapon_camo, squadmember.sm04_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm04_LO4_Weapon, squadmember.sm04_LO4_Weapon_at1, squadmember.sm04_LO4_Weapon_at2, squadmember.sm04_LO4_Weapon_camo, squadmember.sm04_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm04_LO5_Weapon, squadmember.sm04_LO5_Weapon_at1, squadmember.sm04_LO5_Weapon_at2, squadmember.sm04_LO5_Weapon_camo, squadmember.sm04_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm04_LO6_Weapon, squadmember.sm04_LO6_Weapon_at1, squadmember.sm04_LO6_Weapon_at2, squadmember.sm04_LO6_Weapon_camo, squadmember.sm04_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 5)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm05_LO1_Weapon, squadmember.sm05_LO1_Weapon_at1, squadmember.sm05_LO1_Weapon_at2, squadmember.sm05_LO1_Weapon_camo, squadmember.sm05_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm05_LO2_Weapon, squadmember.sm05_LO2_Weapon_at1, squadmember.sm05_LO2_Weapon_at2, squadmember.sm05_LO2_Weapon_camo, squadmember.sm05_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm05_LO3_Weapon, squadmember.sm05_LO3_Weapon_at1, squadmember.sm05_LO3_Weapon_at2, squadmember.sm05_LO3_Weapon_camo, squadmember.sm05_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm05_LO4_Weapon, squadmember.sm05_LO4_Weapon_at1, squadmember.sm05_LO4_Weapon_at2, squadmember.sm05_LO4_Weapon_camo, squadmember.sm05_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm05_LO5_Weapon, squadmember.sm05_LO5_Weapon_at1, squadmember.sm05_LO5_Weapon_at2, squadmember.sm05_LO5_Weapon_camo, squadmember.sm05_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm05_LO6_Weapon, squadmember.sm05_LO6_Weapon_at1, squadmember.sm05_LO6_Weapon_at2, squadmember.sm05_LO6_Weapon_camo, squadmember.sm05_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 6)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm06_LO1_Weapon, squadmember.sm06_LO1_Weapon_at1, squadmember.sm06_LO1_Weapon_at2, squadmember.sm06_LO1_Weapon_camo, squadmember.sm06_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm06_LO2_Weapon, squadmember.sm06_LO2_Weapon_at1, squadmember.sm06_LO2_Weapon_at2, squadmember.sm06_LO2_Weapon_camo, squadmember.sm06_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm06_LO3_Weapon, squadmember.sm06_LO3_Weapon_at1, squadmember.sm06_LO3_Weapon_at2, squadmember.sm06_LO3_Weapon_camo, squadmember.sm06_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm06_LO4_Weapon, squadmember.sm06_LO4_Weapon_at1, squadmember.sm06_LO4_Weapon_at2, squadmember.sm06_LO4_Weapon_camo, squadmember.sm06_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm06_LO5_Weapon, squadmember.sm06_LO5_Weapon_at1, squadmember.sm06_LO5_Weapon_at2, squadmember.sm06_LO5_Weapon_camo, squadmember.sm06_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm06_LO6_Weapon, squadmember.sm06_LO6_Weapon_at1, squadmember.sm06_LO6_Weapon_at2, squadmember.sm06_LO6_Weapon_camo, squadmember.sm06_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 7)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm07_LO1_Weapon, squadmember.sm07_LO1_Weapon_at1, squadmember.sm07_LO1_Weapon_at2, squadmember.sm07_LO1_Weapon_camo, squadmember.sm07_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm07_LO2_Weapon, squadmember.sm07_LO2_Weapon_at1, squadmember.sm07_LO2_Weapon_at2, squadmember.sm07_LO2_Weapon_camo, squadmember.sm07_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm07_LO3_Weapon, squadmember.sm07_LO3_Weapon_at1, squadmember.sm07_LO3_Weapon_at2, squadmember.sm07_LO3_Weapon_camo, squadmember.sm07_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm07_LO4_Weapon, squadmember.sm07_LO4_Weapon_at1, squadmember.sm07_LO4_Weapon_at2, squadmember.sm07_LO4_Weapon_camo, squadmember.sm07_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm07_LO5_Weapon, squadmember.sm07_LO5_Weapon_at1, squadmember.sm07_LO5_Weapon_at2, squadmember.sm07_LO5_Weapon_camo, squadmember.sm07_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm07_LO6_Weapon, squadmember.sm07_LO6_Weapon_at1, squadmember.sm07_LO6_Weapon_at2, squadmember.sm07_LO6_Weapon_camo, squadmember.sm07_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 8)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm08_LO1_Weapon, squadmember.sm08_LO1_Weapon_at1, squadmember.sm08_LO1_Weapon_at2, squadmember.sm08_LO1_Weapon_camo, squadmember.sm08_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm08_LO2_Weapon, squadmember.sm08_LO2_Weapon_at1, squadmember.sm08_LO2_Weapon_at2, squadmember.sm08_LO2_Weapon_camo, squadmember.sm08_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm08_LO3_Weapon, squadmember.sm08_LO3_Weapon_at1, squadmember.sm08_LO3_Weapon_at2, squadmember.sm08_LO3_Weapon_camo, squadmember.sm08_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm08_LO4_Weapon, squadmember.sm08_LO4_Weapon_at1, squadmember.sm08_LO4_Weapon_at2, squadmember.sm08_LO4_Weapon_camo, squadmember.sm08_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm08_LO5_Weapon, squadmember.sm08_LO5_Weapon_at1, squadmember.sm08_LO5_Weapon_at2, squadmember.sm08_LO5_Weapon_camo, squadmember.sm08_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm08_LO6_Weapon, squadmember.sm08_LO6_Weapon_at1, squadmember.sm08_LO6_Weapon_at2, squadmember.sm08_LO6_Weapon_camo, squadmember.sm08_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 9)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm09_LO1_Weapon, squadmember.sm09_LO1_Weapon_at1, squadmember.sm09_LO1_Weapon_at2, squadmember.sm09_LO1_Weapon_camo, squadmember.sm09_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm09_LO2_Weapon, squadmember.sm09_LO2_Weapon_at1, squadmember.sm09_LO2_Weapon_at2, squadmember.sm09_LO2_Weapon_camo, squadmember.sm09_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm09_LO3_Weapon, squadmember.sm09_LO3_Weapon_at1, squadmember.sm09_LO3_Weapon_at2, squadmember.sm09_LO3_Weapon_camo, squadmember.sm09_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm09_LO4_Weapon, squadmember.sm09_LO4_Weapon_at1, squadmember.sm09_LO4_Weapon_at2, squadmember.sm09_LO4_Weapon_camo, squadmember.sm09_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm09_LO5_Weapon, squadmember.sm09_LO5_Weapon_at1, squadmember.sm09_LO5_Weapon_at2, squadmember.sm09_LO5_Weapon_camo, squadmember.sm09_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm09_LO6_Weapon, squadmember.sm09_LO6_Weapon_at1, squadmember.sm09_LO6_Weapon_at2, squadmember.sm09_LO6_Weapon_camo, squadmember.sm09_LO6_2ndWeapon_camo); }
            }
            if (ldt.sq_mem == 10)
            {
                if (ldt.ldout == 1)
                { set_weapon(squadmember.sm10_LO1_Weapon, squadmember.sm10_LO1_Weapon_at1, squadmember.sm10_LO1_Weapon_at2, squadmember.sm10_LO1_Weapon_camo, squadmember.sm10_LO1_2ndWeapon_camo); }
                if (ldt.ldout == 2)
                { set_weapon(squadmember.sm10_LO2_Weapon, squadmember.sm10_LO2_Weapon_at1, squadmember.sm10_LO2_Weapon_at2, squadmember.sm10_LO2_Weapon_camo, squadmember.sm10_LO2_2ndWeapon_camo); }
                if (ldt.ldout == 3)
                { set_weapon(squadmember.sm10_LO3_Weapon, squadmember.sm10_LO3_Weapon_at1, squadmember.sm10_LO3_Weapon_at2, squadmember.sm10_LO3_Weapon_camo, squadmember.sm10_LO3_2ndWeapon_camo); }
                if (ldt.ldout == 4)
                { set_weapon(squadmember.sm10_LO4_Weapon, squadmember.sm10_LO4_Weapon_at1, squadmember.sm10_LO4_Weapon_at2, squadmember.sm10_LO4_Weapon_camo, squadmember.sm10_LO4_2ndWeapon_camo); }
                if (ldt.ldout == 5)
                { set_weapon(squadmember.sm10_LO5_Weapon, squadmember.sm10_LO5_Weapon_at1, squadmember.sm10_LO5_Weapon_at2, squadmember.sm10_LO5_Weapon_camo, squadmember.sm10_LO5_2ndWeapon_camo); }
                if (ldt.ldout == 6)
                { set_weapon(squadmember.sm10_LO6_Weapon, squadmember.sm10_LO6_Weapon_at1, squadmember.sm10_LO6_Weapon_at2, squadmember.sm10_LO6_Weapon_camo, squadmember.sm10_LO6_2ndWeapon_camo); }
            }


        }

        private void set_weapon(long weapon, long fst_at, long scnd_at, long camo, long scndcamo)
        {
            restore_mem();
            if (ghost.ProcHandle("iw6mp64_ship"))
            {
                if (radioButton3.Checked)
                {
                    int val = Convert.ToInt16(ldt.camo);
                    byte[] buf = BitConverter.GetBytes(val);
                    ghost.WriteByte(camo, buf);

                    val = Convert.ToInt16(ldt.secondcamo);
                    buf = BitConverter.GetBytes(val);
                    ghost.WriteByte(scndcamo, buf);
                }
                else
                {
                    int val = Convert.ToInt16(ldt.weapon);
                    byte[] buf = new byte[1];
                    buf = BitConverter.GetBytes(val);
                    ghost.WriteByte(weapon, buf);

                    val = Convert.ToInt16(ldt.fstat);
                    buf = BitConverter.GetBytes(val);
                    ghost.WriteByte(fst_at, buf);

                    val = Convert.ToInt16(ldt.scndat);
                    buf = BitConverter.GetBytes(val);
                    ghost.WriteByte(scnd_at, buf);

                    val = Convert.ToInt16(ldt.camo);
                    buf = BitConverter.GetBytes(val);
                    ghost.WriteByte(camo, buf);
                }
            }
            fix_mem();
            memcheck();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            fix_mem();
            memcheck();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) 
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox13.Visible = true;
                groupBox13.Location = new Point(12, 151);
                button55.Enabled = false;
                button54.Text = "Set camo to weapon ";
                weapon_camo(); 
            }
            else 
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox13.Visible = false;
                button55.Enabled = true;
                button54.Text = "Give weapon to soldier";
            }
        }

        private void weapon_camo()
        {
            if (radioButton3.Checked)
            {
                if (comboBox1.SelectedIndex == 0) { set_weapon_camo(1); };
                if (comboBox1.SelectedIndex == 1) { set_weapon_camo(2); };
                if (comboBox1.SelectedIndex == 2) { set_weapon_camo(3); };
                if (comboBox1.SelectedIndex == 3) { set_weapon_camo(4); };
                if (comboBox1.SelectedIndex == 4) { set_weapon_camo(5); };
                if (comboBox1.SelectedIndex == 5) { set_weapon_camo(6); };
                if (comboBox1.SelectedIndex == 6) { set_weapon_camo(7); };
                if (comboBox1.SelectedIndex == 7) { set_weapon_camo(8); };
                if (comboBox1.SelectedIndex == 8) { set_weapon_camo(9); };
                if (comboBox1.SelectedIndex == 9) { set_weapon_camo(10); };
            }
            else { return; }
        }

        List<string> PrimaryWeapon = new List<string> { "35", "36", "37", "38", "39", "40", "42", "43", "44", "45", "46", "47",
        "48","49","53","54","55","56","58","57","59","60","61","62","63","64","65","66","67","68","70","87","89"};

        private void set_weapon_pic(byte[] buf1, byte[] buf2)
        {
            int id1 = BitConverter.ToInt16(buf1, 0);
            if (PrimaryWeapon.Contains(id1.ToString()))
            {
                groupBox14.Enabled = true;
                radioButton4.Enabled = true;
                pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject(id1.ToString());
            }
            else
            {
                groupBox14.Enabled = false;
                radioButton4.Enabled = false;
            }

            int id2 = BitConverter.ToInt16(buf2, 0);
            if(PrimaryWeapon.Contains(id2.ToString()))
            {
                groupBox15.Enabled = true;
                radioButton5.Enabled = true;
                pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject(id2.ToString());
            }
            else
            {
                groupBox15.Enabled = false;
                radioButton5.Enabled = false;
            }
        }

        private void set_weapon_camo(int sm_num)
        {
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            if (ghost.ProcHandle("iw6mp64_ship"))
            {
                if (sm_num == 1)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm01_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm01_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm01_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm01_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm01_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm01_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm01_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm01_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm01_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm01_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm01_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm01_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 2)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm02_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm02_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm02_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm02_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm02_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm02_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm02_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm02_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm02_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm02_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm02_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm02_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 3)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm03_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm03_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm03_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm03_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm03_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm03_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm03_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm03_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm03_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm03_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm03_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm03_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }

                if (sm_num == 4)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm04_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm04_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm04_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm04_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm04_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm04_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm04_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm04_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm04_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm04_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm04_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm04_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 5)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm05_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm05_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm05_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm05_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm05_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm05_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm05_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm05_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm05_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm05_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm05_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm05_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 6)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm06_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm06_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm06_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm06_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm06_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm06_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm06_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm06_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm06_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm06_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm06_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm06_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 7)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm07_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm07_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm07_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm07_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm07_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm07_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm07_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm07_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm07_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm07_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm07_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm07_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 8)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm08_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm08_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm08_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm08_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm08_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm08_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm08_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm08_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm08_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm08_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm08_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm08_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 9)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm09_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm09_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm09_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm09_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm09_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm09_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm09_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm09_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm09_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm09_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm09_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm09_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }
                if (sm_num == 10)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm10_LO1_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm10_LO1_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 1)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm10_LO2_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm10_LO2_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 2)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm10_LO3_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm10_LO3_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 3)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm10_LO4_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm10_LO4_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 4)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm10_LO5_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm10_LO5_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                    if (comboBox2.SelectedIndex == 5)
                    {
                        byte[] buf1 = ghost.ReadBytes(squadmember.sm10_LO6_Weapon, 2);
                        byte[] buf2 = ghost.ReadBytes(squadmember.sm10_LO6_2ndWeapon, 2);
                        set_weapon_pic(buf1, buf2);
                    }
                }

            }
        }
    }
}
