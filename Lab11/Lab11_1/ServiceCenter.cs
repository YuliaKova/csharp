using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class ServiceCenter
    {
        public static void ReinstallWin(Computer Obj)
        {
            Obj.reinstallWin = true;
        }
        public static void ChangeMotherboard(Computer Obj)
        {
            Obj.changeMotherboard = true;
        }
        public static void ChangePowerSupply(Computer Obj)
        {
            Obj.changePowerSupply = true;
        }
        public static void AddRAM(Computer Obj)
        {
            Obj.addRAM = true;
        }
        public static void ChangeGraphicCard(Computer Obj)
        {
            Obj.changeGraphicCard = true;
        }
        public static void SetUpProgrammes(Computer Obj)
        {
            Obj.setUpProgrammes = true;
        }
    }
}
