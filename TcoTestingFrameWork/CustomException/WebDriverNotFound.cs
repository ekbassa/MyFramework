using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcoTestingFrameWork.CustomException
{
    public class WebDriverNotFound:Exception
    {
        /* this class is going to throw an exception if the user had specified unknown browser */
        
        public WebDriverNotFound(string msg) : base(msg)
        {

        }
    }
}
