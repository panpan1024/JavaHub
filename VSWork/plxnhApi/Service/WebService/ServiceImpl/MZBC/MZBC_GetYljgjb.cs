using Service.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.WebService.ServiceImpl.MZBC
{
    public class MZBC_GetYljgjb : ServiceBase
    {
        public MZBC_GetYljgjb()
        {
            this.sqlStr = "GetYljgjb";
        }
        /// <summary>
        /// 取出医院级别：(此方法可以不做)
        /// </summary>
        /// <param name="SqlStr">GetYljgjb</param>
        /// <param name="parames">AREA_NO&DEP_ID</param>
        /// <param name="split">分割符&</param>
        /// <returns></returns>
        
		
//AREA_NO	VARCHAR2(6)	    病人地区编码(取前台选择的地区编码)
//DEP_ID    VARCHAR2(22)	用户所在医院编码


        //成功返回
		//S_Returns=0;ITEM_CODE
		//ITEM_CODE：CHAR(1)  医疗机构级别



    }
}
