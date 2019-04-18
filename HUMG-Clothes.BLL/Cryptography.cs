using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.BLL
{
    public class Cryptography
    {
        public string CryptographyString(string s)
        {
            string value = "";
            for (int i = 0; i < s.Length; i++)
            {
                value = value + CryptograhyCharacter(s[i].ToString());
            }
            return value;
        }
        public string CryptograhyCharacter(string s)
        {
            s = s.Trim();
            switch (s)
            {
                case "a":
                case "A":
                    return "BienVoTran";
                case "b":
                case "B":
                    return "NgheTungNhip";
                case "c":
                case "C":
                    return "SongBay";
                case "d":
                case "D":
                    return "HangNgheCu";
                case "e":
                case "E":
                    return "ThuMinhDuoiBongCay";
                case "f":
                case "F":
                    return "ChuyenHoaQua";
                case "g":
                case "G":
                    return "AnhConKeDo";
                case "h":
                case "H":
                    return "GioEmOi";
                case "i":
                case "I":
                    return "ConChutGi";
                case "k":
                case "K":
                    return "DeNho";
                case "l":
                case "L":
                    return "VaAnhBiet";
                case "m":
                case "M":
                    return "SeTronVen";
                case "o":
                case "O":
                    return "Hon";
                case "p":
                case "P":
                    return "NeuDieuDo";
                case "q":
                case "Q":
                    return "MaiLa";
                case "r":
                case "R":
                    return "KhatVong";
                case "s":
                case "S":
                    return "AnhTrao";
                case "t":
                case "T":
                    return "MotDaiDuong";
                case "u":
                case "U":
                    return "GioConDau";
                case "v":
                case "V":
                    return "ChiConCatDong";
                case "x":
                case "Y":
                    return "AnhCo";
                case "z":
                case "Z":
                    return "MotThoi";
                case "1":
                    return "PhieuDang";
                case "2":
                    return "ChoNangGio";
                case "3":
                    return "PhongBa";
                case "4":
                    return "TayTran";
                case "5":
                    return "RoiCung";
                case "6":
                    return "DuongTinh";
                case "7":
                    return "Em";
                case "8":
                    return "ChetMotConTim";
                case "9":
                    return "VuaMoiNayMam";
                case "0":
                    return "Tea-BienTinh";
                default:
                    return "Tea";
            }
        }
    }
}
