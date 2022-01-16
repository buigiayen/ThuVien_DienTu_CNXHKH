using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien_DienTu_CNXHKH.common.FunctionPattent
{
    public class BaseFunction<T> where T : BaseFunction<T>, new()
    {
        private static T instance = default(T);
        public static T GetInstance()
        {
            if (instance == null)
            {
                instance = new T();
            }
            return instance;
        }
    }
}
