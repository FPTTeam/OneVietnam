using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 使用者が住んでいる国のオブジェクト
/// </summary>
/// <created>
/// ThamDTH - 2016/05/09
/// </created>
namespace Entities
{
    public class Country : BaseEntity
    {
        private string mStrCountryName;         //国名

        /// <summary>
        /// 国名を取得又は国名をセット
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created> 
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

        private byte[] mByteCountryFlag;        //国旗

        /// <summary>
        /// 国旗を取得又は国旗をセット
        /// </summary>
        /// <created>
        /// ThamDTH - 2016/05/09
        /// </created>
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
        /// 新国を追加する時のデフォルトオブジェクト
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
        /// 新国を追加する時、国名と国旗があるオブジェクト
        /// </summary>
        /// <param name="pStrCountryName">国名</param>
        /// <param name="pByteCountryFlag">国旗</param>
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
