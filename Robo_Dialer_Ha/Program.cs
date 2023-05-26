// Kai
// IT112
// Initialized all data here
// Loop to show Dial()
// We didn't really do anything with the constructor
// I'm thinking this assignment is for us to understand
// the inherating and the overiding aspect? I wonder if you want us to play with abstract aswell.

namespace Robo_Dialer_Ha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone[] DialList = new Phone[10];

            DialList[0] = new CellPhone("(800) 969-4374", "ErgoSource", "1");
            DialList[1] = new CellPhone("(800) 874-8527", "Fox Bay Industries", "2");
            DialList[2] = new HomePhone("(303) 985-5060", "CompuTest", "1");
            DialList[3] = new HomePhone("(603) 532-4123", "Curtis Manufacturing", "2");
            DialList[4] = new CellPhone("(800) 876-2524", "Data Functions", "1");
            DialList[5] = new CellPhone("(708) 397-3330", "Donnay Repair", "1");
            DialList[6] = new CellPhone("(360) 434-3894", "ErgoNomic Inc", "1");
            DialList[7] = new CellPhone("(800) 545-6254", "Glare-Guard", "2");
            DialList[8] = new CellPhone("(407) 783-6641", "Hazard Comm Specialists", "2");
            DialList[9] = new CellPhone("(714) 472-4409", "Komfort Support", "2");


            foreach (Phone phone in DialList)
            {
                Console.WriteLine(phone.Dial());
            }
        }
    }

}