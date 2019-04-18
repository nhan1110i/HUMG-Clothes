using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class SizeDTO
    {
        string _SizeName;

        public string SizeName
        {
            get { return _SizeName; }
            set { _SizeName = value; }
        }
        int _SizeID;

        public int SizeID
        {
            get { return _SizeID; }
            set { _SizeID = value; }
        }
        string _Height;

        public string Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        private string _Weight;

        public string Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }


        public SizeDTO()
        {
            this.SizeName = "";
            this.SizeID = 0;
            this.Height = "";
            this.Weight = "";
        }

        public SizeDTO(int SizeID, string SizeName, string Height, string Weight) {
            this.SizeName = SizeName;
            this.SizeID = SizeID;
            this.Height = Height;
            this.Weight = Weight;
        }

    }
}
