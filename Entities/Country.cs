using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Country where user is living
/// </summary>
/// <created>
/// ThamDTH - 2016/05/09
/// </created>
namespace Entities
{
    public class Country : BaseEntity
    {
        private string mStrCountryName;         //Country name

        public string MStrCountryName
        {
            get
            {
                return mStrCountryName;
            }

            set
            {
                mStrCountryName = value;
            }
        }

        private byte[] mByteCountryFlag;        //Flag of this country

        public byte[] MByteCountryFlag
        {
            get
            {
                return mByteCountryFlag;
            }

            set
            {
                mByteCountryFlag = value;
            }
        }

        /// <summary>
        /// Default Constructor when create a new Country object
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created>
        public Country()                    
        {
            mStrCountryName = "";
            mByteCountryFlag = null;
        }

        /// <summary>
        /// Constructor when create a new Country object with name and flag were added
        /// </summary>
        /// <param name="pStrCountryName">Country name</param>
        /// <param name="pByteCountryFlag">Flag of country</param>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created>
        public Country(string pStrCountryName, byte[] pByteCountryFlag)
        {
            mStrCountryName = pStrCountryName;
            mByteCountryFlag = pByteCountryFlag;
        }

    }
}
