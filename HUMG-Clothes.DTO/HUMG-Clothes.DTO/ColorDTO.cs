using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUMG_Clothes.DTO
{
    public class ColorDTO
    {
        int _ColorID;

        public int ColorID
        {
            get { return _ColorID; }
            set { _ColorID = value; }
        }

        string _ColorName;

        public string ColorName
        {
            get { return _ColorName; }
            set { _ColorName = value; }
        }
        string _ColorCode;

        public string ColorCode
        {
            get { return _ColorCode; }
            set { _ColorCode = value; }
        }
        public ColorDTO()
        {
            this.ColorID = 0;
            this.ColorCode = this.ColorName = "";
        }
        public ColorDTO(int ColorID, string ColorName, string ColorCode)
        {
            this.ColorID = ColorID;
            this.ColorCode = ColorCode;
            this.ColorName = ColorName;
        }
    }
}
