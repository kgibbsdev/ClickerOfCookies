using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ClickerOfCookies.Classes;

namespace ClickerOfCookies
{
    class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        public static void BuyUnit(int x, int y, int clicks = 1)
        {
            for (int i = 0; i < clicks; i++)
            {
                LeftMouseClick(x, y);
            }
            Console.WriteLine("Clicked Unit");
        }

        public static void BuyUpgrade()
        {
            LeftMouseClick(4200, 250);
            Console.WriteLine("Clicked Upgrade");
        }

        void Console_CancelKeyPress(object sernder, ConsoleCancelEventArgs e)
        {
            //Console.Log("Cancelling");
        }

        static void Main()
        {
            Cookie cookie = new Cookie(2800, 500);
            UpgradeSlot upgradeSlot = new UpgradeSlot(4200, 250);
            Cursor cursor = new Cursor(4200, 350);
            Grandma grandma = new Grandma(4200, 450);
            Farm farm = new Farm(4200, 500);
            Mine mine = new Mine(4200, 550);
            Factory factory = new Factory(4200, 600);
            Bank bank = new Bank(4200, 700);
            Temple temple = new Temple(4200, 750);
            WizardTower wizardTower = new WizardTower(4200, 800);
            Shipment shipment = new Shipment(4200, 900);
            AlchemyLab alchemyLab = new AlchemyLab(4200, 950);
            Portal portal = new Portal(4200, 1000);
            TimeMachine timeMachine = new TimeMachine(4200, 1050);
            Prism prism = new Prism(4200, 1100);
            
            Console.WriteLine("Clicking!");

            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    LeftMouseClick(2800, 500);
                    BuyUnit(alchemyLab.x, alchemyLab.y);
                }

                BuyUpgrade();
                BuyUnit(shipment.x, shipment.y, 10);
                BuyUnit(wizardTower.x, wizardTower.y);
                BuyUnit(temple.x, temple.y);
                BuyUnit(bank.x, bank.y);
                BuyUnit(factory.x, factory.y);
                BuyUnit(mine.x, mine.y);
                BuyUnit(farm.x, farm.y);
                BuyUnit(grandma.x, grandma.y);
                BuyUnit(cursor.x, cursor.y);
                BuyUnit(alchemyLab.x, alchemyLab.y);
                BuyUnit(portal.x, portal.y);
                BuyUnit(timeMachine.x, timeMachine.y);
                BuyUnit(prism.x, prism.y);
            }

            Console.ReadKey();
        }
    }
}
