using MongoDB.Bson;
using MongoDB.Driver;
using Entities;
namespace DAL
{
    /// <summary>  
    /// データベースから取得する国のクエリストリングを作成
    /// </summary>
    /// <created>
    /// ThamDTH - 2016/05/09
    /// </created>
    public class CountryFilterCondition
    {
        private string mStrName;        //国名
        private byte[] mByteFlag;       //国旗

        /// <summary>
        /// 国名を取得又は国名をセット
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created> 
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

        /// <summary>
        /// 国旗を取得又は国旗をセット
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created>
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
        /// クエリストリングを追加する時のデフォルトオブジェクト
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
        /// クエリストリングを追加する時、フィルタ条件があるオブジェクト
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created>
        /// <returns>フィルタ条件に従うクエリストリング</returns>
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
