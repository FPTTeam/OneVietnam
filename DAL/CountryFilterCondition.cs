using MongoDB.Bson;
using MongoDB.Driver;
using Entities;
namespace DAL
{
    /// <summary>
    /// Object to create querry string in Country document (DB)
    /// </summary>
    /// <created>
    /// ThamDTH - 2016/05/09
    /// </created>
    public class CountryFilterCondition
    {
        private string mStrName;        //Country Name
        private byte[] mByteFlag;       //Country Flag

        public string MStrName
        {
            get
            {
                return mStrName;
            }

            set
            {
                mStrName = value;
            }
        }

        public byte[] MByteFlag
        {
            get
            {
                return mByteFlag;
            }

            set
            {
                mByteFlag = value;
            }
        }

        /// <summary>
        /// Default Constructor when create a new CountrySelectCondition object
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created>
        public CountryFilterCondition()
        {
            mStrName = "";
            mByteFlag = null;
        }

        /// <summary>
        /// Create filter string to search
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created>
        /// <returns>Filter String of Country object</returns>
        public FilterDefinition<Country> ToFilterString()
        {
            var builder = Builders<Country>.Filter;
            FilterDefinition<Country> filter = null;

            if (! string.IsNullOrEmpty(mStrName))
            {
                filter = builder.Eq("CountryName", mStrName);
            }
            if (mByteFlag != null && mByteFlag.Length > 0)
            {
                if (filter != null)
                {
                    filter = filter & builder.Eq("CountryFlag", mByteFlag);
                }
                else
                {
                    filter = builder.Eq("CountryFlag", mByteFlag);
                }
            }            
            return filter;
        }


    }
}
