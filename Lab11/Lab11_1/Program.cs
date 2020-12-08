using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    delegate void Service(Computer Obj);

    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();

            Service serv = ServiceCenter.ReinstallWin;
            serv(comp);
            Service serv1 = ServiceCenter.ChangeMotherboard;
            serv1(comp); 
            Service serv2 = ServiceCenter.ChangePowerSupply;
            serv2(comp); 
            Service serv3 = ServiceCenter.AddRAM;
            serv3(comp); 
            Service serv4 = ServiceCenter.ChangeGraphicCard;
            serv4(comp); 
            Service serv5 = ServiceCenter.SetUpProgrammes;
            serv5(comp);

            comp.Info();

            Console.ReadLine();
        }
    }
}
