using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Computer
    {
        public bool reinstallWin;
        public bool changeMotherboard;
        public bool changePowerSupply;
        public bool addRAM;
        public bool changeGraphicCard;
        public bool setUpProgrammes;

        public Computer()
        {
            reinstallWin = false;
            changeMotherboard = false;
            changePowerSupply = false;
            addRAM = false;
            changeGraphicCard = false;
            setUpProgrammes = false;
        }


        public void Info()
        {
            Console.WriteLine(
                $"Reinstalled Windows \t-- {reinstallWin}\n"+
                $"Motherboard changed \t-- {changeMotherboard}\n" +
                $"Power Supply changed \t-- {changePowerSupply}\n" +
                $"RAM added \t\t-- {addRAM}\n" +
                $"Graphic card changed \t-- {changeGraphicCard}" +
                $"\nProgrammes set up \t-- {setUpProgrammes}\n");
        }
    }
}
