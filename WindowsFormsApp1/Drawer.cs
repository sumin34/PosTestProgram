using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OposCashDrawer_CCO;
namespace Drawer
{

    public class Drawer
    {
        OPOSCashDrawer cashDrawer = new OPOSCashDrawer();

        public string drawerOpen(string deviceName)
        {
            try
            {
                cashDrawer.Open(deviceName);
                return "DeviceOpen Success";
            }catch(Exception ex)
            {
                return "DrawerOpen failed";
            }
        }

        public string drawerDE()
        {
            try
            {
                cashDrawer.DeviceEnabled = true;
                return "cashDrawer DeviceEnabled set true";
            }
            catch (Exception ex)
            {
                return "cashDrawer deviceEnabled Failed";
            }
        }

        public string drawerClose(OPOSCashDrawer drawer)
        {
            try
            {
                cashDrawer.Close();
                cashDrawer.DeviceEnabled = false;
                return "cashDrawer Closed";
            }
            catch (Exception ex)
            {
                return "cashDrawer Close Failed";
            }
        }
    }
}
