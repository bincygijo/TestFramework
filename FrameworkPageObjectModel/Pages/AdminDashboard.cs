using FrameworkPageObjectModel.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FrameworkPageObjectModel.Global.CommonMethods;

namespace FrameworkPageObjectModel.Pages
{
   public class AdminDashboard
    {
        public void ValidateAdmin()
        {
            //Populate in collection
            CommonMethods.ExcelLib.PopulateInCollection(Base.ExcelPath, "admindashboard");

            //Clicking on Owner dropdown
            GlobalDefinitions.ActionButton(GlobalDefinitions.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "LocatorValue"));
            Thread.Sleep(2000);
        }
    }
}
