using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGenerator
{
    public partial class Form1 : Form
    {
        // Will shows what character is in each slot
        string supportSlot1 = "";
        string supportSlot2 = "";

        //
        int compInt = 0;

        // Visibility fields will be used so no method pointers fall on individual button controls.
        bool tankScreen = false;
        bool dpsScreen = false;
        bool suppScreen = false;


        //Fields that show whether one of the role slots has a character in it or not.
        bool tank1 = false;
        bool tank2 = false;
        bool dps1 = false;
        bool dps2 = false;
        bool supp1 = false;
        bool supp2 = false;

        /*
         * initiates field showing that a character is still in first position.
         * very inefficient. Find way to create new button property.
         * v
         */

        bool asheFirstPos = true;
        bool bastionFirstPos = true;
        bool creeFirstPos = true;
        bool doomFirstPos = true;
        bool echoFirstPos = true;
        bool genjiFirstPos = true;
        bool hanzoFirstPos = true;
        bool junkFirstPos = true;
        bool meiFirstPos = true;
        bool pharahFirstPos = true;
        bool reaperFirstPos = true;
        bool soldierFirstPos = true;
        bool sombraFirstPos = true;
        bool symFirstPos = true;
        bool torbFirstPos = true;
        bool tracerFirstPos = true;
        bool widowFirstPos = true;
        // -------------First position of tank bool--------------
        bool winstonFirstPos = true;
        bool zaryaFirstPos = true;
        bool dvaFirstPos = true;
        bool sigFirstPos = true;
        bool ballFirstPos = true;
        bool orisaFirstPos = true;
        bool hogFirstPos = true;
        bool reinFirstPos = true;
        // ------------First Position of support bool-------------
        bool moiraFirstPos = true;
        bool anaFirstPos = true;
        bool bapFirstPos = true;
        bool brigFirstPos = true;
        bool zenFirstPos = true;
        bool mercyFirstPos = true;
        bool lucioFirstPos = true;


        // Initial position of dps characters
        Point asheInitial = new Point(133, 150);
        Point bastionInitial = new Point(254, 150);
        Point creeInitial = new Point(375, 150);
        Point doomInitial = new Point(496, 150);
        Point echoInitial = new Point(617, 150);
        Point genjiInitial = new Point(133, 245);
        Point hanzoInitial = new Point(254, 245);
        Point junkInitial = new Point(375, 245);
        Point meiInitial = new Point(496, 245);
        Point pharahInitial = new Point(617, 245);
        Point reaperInitial = new Point(738, 204);
        Point soldierInitial = new Point(133, 344);
        Point sombraInitial = new Point(254, 344);
        Point symInitial = new Point(375, 344);
        Point torbInitial = new Point(496, 344);
        Point tracerInitial = new Point(617, 344);
        Point widowInitial = new Point(738, 298);
        //-------------Tanks-----------------------
        Point winstionInitial = new Point(183, 150);
        Point zaryaInitial = new Point(305, 298);
        Point dvaInitial = new Point(183, 298);
        Point reinInitial = new Point(305, 150);
        Point orisaInitial = new Point(427, 150);
        Point hogInitial = new Point(427, 298);
        Point sigInitial = new Point(549, 150);
        Point ballInitial = new Point(549, 298);
        //------------Supports---------------------
        Point anaInitial = new Point(244, 150);
        Point bapInitial = new Point(366, 150);
        Point moiraInitial = new Point(487, 150);
        Point mercyInitial = new Point(549, 298);
        Point zenInitial = new Point(427, 298);
        Point brigInitial = new Point(305, 298);
        Point lucioInitial = new Point(183, 298);

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * returns the location of role slots.
         */
        private Point Tank1()
        {
            Point newTank1 = picTank1.Location;
            return newTank1;
        }
        private Point Tank2()
        {
            Point newTank2 = picTank2.Location;
            return newTank2;
        }
        private Point DPS1()
        {
            Point newDPS1 = picDPS1.Location;
            return newDPS1;
        }
        private Point DPS2()
        {
            Point newDPS2 = picDPS2.Location;
            return newDPS2;
        }
        private Point Support1()
        {
            Point newSupp1 = picSupport1.Location;
            return newSupp1;
        }
        private Point Support2()
        {
            Point newSupp2 = picSupport2.Location;
            return newSupp2;
        }

        /*
         * When the support button is pressed, all other roles are hidden, showing only characters of the support role.
         */
        private void btnSupport_Click(object sender, EventArgs e)
        {
            roleHide(false, false, true);
            suppScreen = true;
        }

        /*
         * When pressing the tank button, all other roles are hidden, showing only tank characters.
         */
        private void btnTank_Click(object sender, EventArgs e)
        {
            roleHide(true, false, false);
            tankScreen = true;
        }

        /*
         * When pressing the DPS button, all character outside the role will be hidden, showing only dps characters.
         */
        private void btnDPS_Click(object sender, EventArgs e)
        {
            roleHide(false, true, false);
            dpsScreen = true;
        }

        
        /*
         * Allows swapping between role screens to reduce app clutter
         */
        private void roleHide(bool tank, bool dps, bool supp)
        {
            tankScreen = tank;
            dpsScreen = dps;
            suppScreen = supp;

            btnAshe.Visible = dps;
            btnBastion.Visible = dps;
            btnCree.Visible = dps;
            btnDoom.Visible = dps;
            btnEcho.Visible = dps;
            btnGenji.Visible = dps;
            btnHanzo.Visible = dps;
            btnJunk.Visible = dps;
            btnMei.Visible = dps;
            btnPharah.Visible = dps;
            btnReaper.Visible = dps;
            btnSoldier.Visible = dps;
            btnSombra.Visible = dps;
            btnSym.Visible = dps;
            btnTorb.Visible = dps;
            btnTracer.Visible = dps;
            btnWidow.Visible = dps;

            btnAna.Visible = supp;
            btnBap.Visible = supp;
            btnBrig.Visible = supp;
            btnLucio.Visible = supp;
            btnMercy.Visible = supp;
            btnMoira.Visible = supp;
            btnZen.Visible = supp;

            btnBall.Visible = tank;
            btnDva.Visible = tank;
            btnWinston.Visible = tank;
            btnRein.Visible = tank;
            btnOrisa.Visible = tank;
            btnSig.Visible = tank;
            btnZarya.Visible = tank;
            btnHog.Visible = tank;
            checkTop();
        }


        /*
         * When changing between role screens, checks to see if buttons are taking role slots. If they are, they retain visibility as the role screens are changed.
         */
        private void checkTop()
        {
            if (!asheFirstPos)
            {
                btnAshe.Visible = true;
            }

            if (!bastionFirstPos)
            {
                btnBastion.Visible = true;
            }

            if (!creeFirstPos)
            {
                btnCree.Visible = true;
            }

            if (!doomFirstPos)
            {
                btnDoom.Visible = true;
            }

            if (!echoFirstPos)
            {
                btnEcho.Visible = true;
            }

            if (!genjiFirstPos)
            {
                btnGenji.Visible = true;
            }

            if (!hanzoFirstPos)
            {
                btnHanzo.Visible = true;
            }

            if (!junkFirstPos)
            {
                btnJunk.Visible = true;
            }

            if (!meiFirstPos)
            {
                btnMei.Visible = true;
            }

            if (!pharahFirstPos)
            {
                btnPharah.Visible = true;
            }

            if (!reaperFirstPos)
            {
                btnReaper.Visible = true;
            }

            if (!soldierFirstPos)
            {
                btnSoldier.Visible = true;
            }

            if (!sombraFirstPos)
            {
                btnSombra.Visible = true;
            }

            if (!symFirstPos)
            {
                btnSym.Visible = true;
            }

            if (!torbFirstPos)
            {
                btnTorb.Visible = true;
            }

            if (!tracerFirstPos)
            {
                btnTracer.Visible = true;
            }

            if (!widowFirstPos)
            {
                btnWidow.Visible = true;
            }

            if (!winstonFirstPos)
            {
                btnWinston.Visible = true;
            }

            if (!dvaFirstPos)
            {
                btnDva.Visible = true;
            }

            if (!reinFirstPos)
            {
                btnRein.Visible = true;
            }

            if (!zaryaFirstPos)
            {
                btnZarya.Visible = true;
            }

            if (!orisaFirstPos)
            {
                btnOrisa.Visible = true;
            }    

            if (!hogFirstPos)
            {
                btnHog.Visible = true;
            }

            if (!sigFirstPos)
            {
                btnSig.Visible = true;
            }

            if (!ballFirstPos)
            {
                btnBall.Visible = true;
            }

            if (!moiraFirstPos)
            {
                btnMoira.Visible = true;
            }

            if (!anaFirstPos)
            {
                btnAna.Visible = true;
            }

            if (!bapFirstPos)
            {
                btnBap.Visible = true;
            }

            if (!brigFirstPos)
            {
                btnBrig.Visible = true;
            }

            if (!zenFirstPos)
            {
                btnZen.Visible = true;
            }

            if (!mercyFirstPos)
            {
                btnMercy.Visible = true;
            }

            if (!lucioFirstPos)
            {
                btnLucio.Visible = true;
            }
        }

        /*
         * Returns the initial position of a given character.
         */
        private Point GetLoc(string me)
        {
            Point position = new Point(0, 0);

            switch (me)
            {
                case "ashe":
                    position = asheInitial;
                    break;

                case "bastion":
                    position = bastionInitial;
                    break;

                case "cree":
                    position = creeInitial;
                    break;

                case "doom":
                    position = doomInitial;
                    break;

                case "echo":
                    position = echoInitial;
                    break;

                case "genji":
                    position = genjiInitial;
                    break;

                case "hanzo":
                    position = hanzoInitial;
                    break;

                case "junk":
                    position = junkInitial;
                    break;

                case "mei":
                    position = meiInitial;
                    break;

                case "pharah":
                    position = pharahInitial;
                    break;

                case "reaper":
                    position = reaperInitial;
                    break;

                case "soldier":
                    position = soldierInitial;
                    break;

                case "sombra":
                    position = sombraInitial;
                    break;

                case "sym":
                    position = symInitial;
                    break;

                case "torb":
                    position = torbInitial;
                    break;

                case "tracer":
                    position = tracerInitial;
                    break;

                case "widow":
                    position = widowInitial;
                    break;

                case "winston":
                    position = winstionInitial;
                    break;

                case "zarya":
                    position = zaryaInitial;
                    break;

                case "dva":
                    position = dvaInitial;
                    break;

                case "rein":
                    position = reinInitial;
                    break;

                case "orisa":
                    position = orisaInitial;
                    break;

                case "hog":
                    position = hogInitial;
                    break;

                case "sigma":
                    position = sigInitial;
                    break;

                case "ball":
                    position = ballInitial;
                    break;

                case "moira":
                    position = moiraInitial;
                    break;

                case "ana":
                    position = anaInitial;
                    break;

                case "lucio":
                    position = lucioInitial;
                    break;

                case "zen":
                    position = zenInitial;
                    break;

                case "bap":
                    position = bapInitial;
                    break;

                case "brig":
                    position = brigInitial;
                    break;

                case "mercy":
                    position = mercyInitial;
                    break;
            }
            return position;
        }

        /*
         * Returns a character's first position value.
         */
        private bool GetMe(string me)
        {
            bool name = false;
            

            switch (me)
            {
                case "ashe":
                    name = asheFirstPos;
                    break;

                case "bastion":
                    name = bastionFirstPos;
                    break;

                case "cree":
                    name = creeFirstPos;
                    break;

                case "doom":
                    name = doomFirstPos;
                    break;

                case "echo":
                    name = echoFirstPos;
                    break;

                case "genji":
                    name = genjiFirstPos;
                    break;

                case "hanzo":
                    name = hanzoFirstPos;
                    break;

                case "junk":
                    name = junkFirstPos;
                    break;

                case "mei":
                    name = meiFirstPos;
                    break;

                case "pharah":
                    name = pharahFirstPos;
                    break;

                case "reaper":
                    name = reaperFirstPos;
                    break;

                case "soldier":
                    name = soldierFirstPos;
                    break;

                case "sombra":
                    name = sombraFirstPos;
                    break;

                case "sym":
                    name = symFirstPos;
                    break;

                case "torb":
                    name = torbFirstPos;
                    break;

                case "tracer":
                    name = tracerFirstPos;
                    break;

                case "widow":
                    name = widowFirstPos;
                    break;

                case "winston":
                    name = winstonFirstPos;
                    break;

                case "zarya":
                    name = zaryaFirstPos;
                    break;

                case "dva":
                    name = dvaFirstPos;
                    break;

                case "rein":
                    name = reinFirstPos;
                    break;

                case "orisa":
                    name = orisaFirstPos;
                    break;

                case "hog":
                    name = hogFirstPos;
                    break;

                case "sigma":
                    name = sigFirstPos;
                    break;

                case "ball":
                    name = ballFirstPos;
                    break;

                case "ana":
                    name = anaFirstPos;
                    break;

                case "moira":
                    name = moiraFirstPos;
                    break;

                case "bap":
                    name = bapFirstPos;
                    break;

                case "zen":
                    name = zenFirstPos;
                    break;

                case "brig":
                    name = brigFirstPos;
                    break;

                case "lucio":
                    name = lucioFirstPos;
                    break;

                case "mercy":
                    name = mercyFirstPos;
                    break;
            }
            return name;
            
        }

        /*
         * Changes the character's first positional value.
         */
        private void SetMe(string me, bool value)
        {
            switch (me)
            {
                case "ashe":
                    asheFirstPos = value;
                    break;

                case "bastion":
                    bastionFirstPos = value;
                    break;

                case "cree":
                    creeFirstPos = value;
                    break;

                case "doom":
                    doomFirstPos = value;
                    break;

                case "echo":
                    echoFirstPos = value;
                    break;

                case "genji":
                    genjiFirstPos = value;
                    break;

                case "hanzo":
                    hanzoFirstPos = value;
                    break;

                case "junk":
                    junkFirstPos = value;
                    break;

                case "mei":
                    meiFirstPos = value;
                    break;

                case "pharah":
                    pharahFirstPos = value;
                    break;

                case "reaper":
                    reaperFirstPos = value;
                    break;

                case "soldier":
                    soldierFirstPos = value;
                    break;

                case "sombra":
                    sombraFirstPos = value;
                    break;

                case "sym":
                    symFirstPos = value;
                    break;

                case "torb":
                    torbFirstPos = value;
                    break;

                case "tracer":
                    tracerFirstPos = value;
                    break;

                case "widow":
                    widowFirstPos = value;
                    break;

                case "winston":
                    winstonFirstPos = value;
                    break;

                case "zarya":
                    zaryaFirstPos = value;
                    break;

                case "dva":
                    dvaFirstPos = value;
                    break;

                case "rein":
                    reinFirstPos = value;
                    break;

                case "orisa":
                    orisaFirstPos = value;
                    break;

                case "hog":
                    hogFirstPos = value;
                    break;

                case "sigma":
                    sigFirstPos = value;
                    break;

                case "ball":
                    ballFirstPos = value;
                    break;

                case "ana":
                    anaFirstPos = value;
                    break;

                case "moira":
                    moiraFirstPos = value;
                    break;

                case "bap":
                    bapFirstPos = value;
                    break;

                case "zen":
                    zenFirstPos = value;
                    break;

                case "brig":
                    brigFirstPos = value;
                    break;

                case "lucio":
                    lucioFirstPos = value;
                    break;

                case "mercy":
                    mercyFirstPos = value;
                    break;
            }
        }

        // Checks the tanks to define the composition.
        private string defineComp()
        {
            string comp = "";

            if (!reinFirstPos)
            {
                if (!zaryaFirstPos || !dvaFirstPos)
                {
                    comp = "Brawl";
                }

                else if(!sigFirstPos || !orisaFirstPos)
                {
                    comp = "Double Shield";
                }

            }

            else if(!winstonFirstPos)
            {
                if (!dvaFirstPos || !ballFirstPos)
                {
                    comp = "Dive";
                }

                else if (!zaryaFirstPos)
                {
                    comp = "Double Bubble";
                }
            }

            else if(!hogFirstPos)
            {
                if (!orisaFirstPos)
                {
                    comp = "bunker";
                }

                else if (!zaryaFirstPos)
                {
                    comp = "zarya hog";
                }

                else if (!sigFirstPos)
                {
                    comp = "poke";
                }
            }

            return comp;
        }


        //Gives a rating based on how well a support composition fits into the team comp.
        private int checkSupp(string comp)
        {
            string suppVar = supportSlot1;
            string suppVar2 = supportSlot2;
            int suppCheck = 0;

            switch (comp)
            {
                case "Brawl":
                    if (!anaFirstPos)
                    {
                        if (!lucioFirstPos)
                        {
                            suppCheck = 0;
                        }

                        else if(!brigFirstPos)
                        {
                            suppCheck = 5;
                        }

                        else if(!zenFirstPos)
                        {
                            suppCheck = 5;
                        }

                        else if(!bapFirstPos)
                        {
                            suppCheck = 5;
                        }

                        else if(!mercyFirstPos)
                        {
                            suppCheck = 10;
                        }

                        else if (!moiraFirstPos)
                        {
                            suppCheck = 15;
                        }
                    }

                    else if (!lucioFirstPos)
                    {
                        if (!brigFirstPos)
                        {
                            suppCheck = 20;
                        }

                        else if(!zenFirstPos)
                        {
                            suppCheck = 20;
                        }

                        else if(!bapFirstPos)
                        {
                            suppCheck = 10;
                        }

                        else if(!moiraFirstPos)
                        {
                            suppCheck = 5;
                        }

                        else if(!mercyFirstPos)
                        {
                            suppCheck = 20;
                        }
                    }

                    else if(!brigFirstPos)
                    {
                        if (!zenFirstPos)
                        {
                            suppCheck = 20;
                        }

                        else if(!bapFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if(!moiraFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if(!mercyFirstPos)
                        {
                            suppCheck = 20;
                        }
                    }

                    else if(!zenFirstPos)
                    {
                        if (!bapFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if(!moiraFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if(!mercyFirstPos)
                        {
                            suppCheck = 20;
                        }
                    }

                    else if(!bapFirstPos)
                    {
                        if (!moiraFirstPos)
                        {
                            suppCheck = 20;
                        }

                        else if (!mercyFirstPos)
                        {   
                            suppCheck = 15;
                        }
                    }

                    else if(!moiraFirstPos)
                    {
                        if (!mercyFirstPos)
                        {
                            suppCheck = 15;
                        }
                    }
                    break;

                case "Dive":
                    if (!anaFirstPos)
                    {
                        if (!lucioFirstPos)
                        {
                            suppCheck = 0;
                        }

                        else if (!brigFirstPos)
                        {
                            suppCheck = 0;
                        }

                        else if (!zenFirstPos)
                        {
                            suppCheck = 5;
                        }

                        else if (!bapFirstPos)
                        {
                            suppCheck = 10;
                        }

                        else if (!mercyFirstPos)
                        {
                            suppCheck = 0;
                        }

                        else if (!moiraFirstPos)
                        {
                            suppCheck = 15;
                        }
                    }

                    else if (!lucioFirstPos)
                    {
                        if (!brigFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if (!zenFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if (!bapFirstPos)
                        {
                            suppCheck = 10;
                        }

                        else if (!moiraFirstPos)
                        {
                            suppCheck = 20;
                        }

                        else if (!mercyFirstPos)
                        {
                            suppCheck = 10;
                        }
                    }

                    else if (!brigFirstPos)
                    {
                        if (!zenFirstPos)
                        {
                            suppCheck = 10;
                        }

                        else if (!bapFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if (!moiraFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if (!mercyFirstPos)
                        {
                            suppCheck = 5;
                        }
                    }

                    else if (!zenFirstPos)
                    {
                        if (!bapFirstPos)
                        {
                            suppCheck = 15;
                        }

                        else if (!moiraFirstPos)
                        {
                            suppCheck = 20;
                        }

                        else if (!mercyFirstPos)
                        {
                            suppCheck = 5;
                        }
                    }

                    else if (!bapFirstPos)
                    {
                        if (!moiraFirstPos)
                        {
                            suppCheck = 25;
                        }

                        else if (!mercyFirstPos)
                        {
                            suppCheck = 15;
                        }
                    }

                    else if (!moiraFirstPos)
                    {
                        if (!mercyFirstPos)
                        {
                            suppCheck = 15;
                        }
                    }
                    break;
            }

            return suppCheck;
        }

        // Calculates a score for the usefulness of the comp
        private int checkComp()
        {
            
            int supportCheck = checkSupp(defineComp());

            
            compInt = (100 - supportCheck);


            return compInt;
        }

        // Defines the comp in the label under the role slots.
        private void changeComp()
        {
            string comp = defineComp();
            int integrity = checkComp();

            lblMapInt.Text = integrity.ToString();
            lblCompInt.Text = comp;
        }

        /*
         * Method controlling movement of character icon into and out of role slots.
         */
        private void move(String use, Button self, String role)
        {
            {
                

                if (role == "dps")
                {
                    if (GetMe(use) && dps1 == false) // Checks if character is in it's initial position and if the first dps slot is occupied
                    {
                        self.Location = DPS1(); // Moves the character into the first dps slot.
                        SetMe(use, false); // Sets the character's first position field to false.
                        dps1 = true;
                        picDPS1.Visible = false;
                    }

                    else if (GetMe(use) && dps1 == true && dps2 == false)
                    {
                        self.Location = DPS2();
                        SetMe(use, false);
                        dps2 = true;
                        picDPS2.Visible = false;
                    }

                    else if (!GetMe(use) && self.Location == DPS1()) // Checks if character is not in it's initial position and if the character is in the first dps slot
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        dps1 = false;
                        picDPS1.Visible = true;
                        if (!dpsScreen) // Screen bug fix
                        {
                            self.Visible = false;
                        }
                    }

                    else if (!GetMe(use) && self.Location == DPS2())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        dps2 = false;
                        picDPS2.Visible = true;
                        if (!dpsScreen)
                        {
                            self.Visible = false;
                        }
                    }
                }
                // -----------------Same as above but for tank-----------------------------
                else if (role == "tank")
                {
                    if (GetMe(use) && tank1 == false)
                    {
                        self.Location = Tank1();
                        SetMe(use, false);
                        tank1 = true;
                        picTank1.Visible = false;
                    }

                    else if (GetMe(use) && tank1 == true && tank2 == false)
                    {
                        self.Location = Tank2();
                        SetMe(use, false);
                        tank2 = true;
                        picTank2.Visible = false;
                    }

                    else if (!GetMe(use) && self.Location == Tank1())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        tank1 = false;
                        picTank1.Visible = true;
                        if (!tankScreen)
                        {
                            self.Visible = false;
                        }
                    }

                    else if (!GetMe(use) && self.Location == Tank2())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        tank2 = false;
                        picTank2.Visible = true;
                        if (!tankScreen)
                        {
                            self.Visible = false;
                        }
                    }
                }
                // Same as above but for support.
                else if (role == "support")
                {
                    if (GetMe(use) && supp1 == false)
                    {
                        self.Location = Support1();
                        SetMe(use, false);
                        supp1 = true;
                        picSupport1.Visible = false;
                        supportSlot1 = use;
                    }

                    else if (GetMe(use) && supp1 == true && supp2 == false)
                    {
                        self.Location = Support2();
                        SetMe(use, false);
                        supp2 = true;
                        picSupport2.Visible = false;
                        supportSlot2 = use;
                    }

                    else if (!GetMe(use) && self.Location == Support1())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        supp1 = false;
                        picSupport1.Visible = true;
                        supportSlot1 = "";
                        if (!suppScreen)
                        {
                            self.Visible = false;
                        }
                    }

                    else if (!GetMe(use) && self.Location == Support2())
                    {
                        self.Location = GetLoc(use);
                        SetMe(use, true);
                        supp2 = false;
                        picSupport2.Visible = true;
                        supportSlot2 = "";
                        if (!suppScreen)
                        {
                            self.Visible = false;
                        }
                    }
                }

                changeComp();
            }
        }
       

        /*
         * *All of the below*
         * used to move around characters on press
         */
        private void btnAshe_Click(object sender, EventArgs e)
        {
            move("ashe", btnAshe, "dps");

        }

        private void btnBastion_Click(object sender, EventArgs e)
        {
            move("bastion", btnBastion, "dps");
        }

        private void btnCree_Click(object sender, EventArgs e)
        {
            move("cree", btnCree, "dps");
        }

        private void btnDoom_Click(object sender, EventArgs e)
        {
            move("doom", btnDoom, "dps");
        }

        private void btnEcho_Click(object sender, EventArgs e)
        {
            move("echo", btnEcho, "dps");
        }

        private void btnGenji_Click(object sender, EventArgs e)
        {
            move("genji", btnGenji, "dps");
        }

        private void btnHanzo_Click(object sender, EventArgs e)
        {
            move("hanzo", btnHanzo, "dps");
        }

        private void btnJunk_Click(object sender, EventArgs e)
        {
            move("junk", btnJunk, "dps");
        }

        private void btnMei_Click(object sender, EventArgs e)
        {
            move("mei", btnMei, "dps");
        }

        private void btnPharah_Click(object sender, EventArgs e)
        {
            move("pharah", btnPharah, "dps");
        }

        private void btnReaper_Click(object sender, EventArgs e)
        {
            move("reaper", btnReaper, "dps");
        }

        private void btnSoldier_Click(object sender, EventArgs e)
        {
            move("soldier", btnSoldier, "dps");
        }

        private void btnSombra_Click(object sender, EventArgs e)
        {
            move("sombra", btnSombra, "dps");
        }

        private void btnSym_Click(object sender, EventArgs e)
        {
            move("sym", btnSym, "dps");
        }

        private void btnTorb_Click(object sender, EventArgs e)
        {
            move("torb", btnTorb, "dps");
        }

        private void btnTracer_Click(object sender, EventArgs e)
        {
            move("tracer", btnTracer, "dps");
        }

        private void btnWidow_Click(object sender, EventArgs e)
        {
            move("widow", btnWidow, "dps");
        }

        // Tank Break

        private void btnWinston_Click(object sender, EventArgs e)
        {
            move("winston", btnWinston, "tank");
        }

        private void btnZarya_Click(object sender, EventArgs e)
        {
            move("zarya", btnZarya, "tank");
        }

        private void btnDva_Click(object sender, EventArgs e)
        {
            move("dva", btnDva, "tank");
        }

        private void btnRein_Click(object sender, EventArgs e)
        {
            move("rein", btnRein, "tank");
        }

        private void btnOrisa_Click(object sender, EventArgs e)
        {
            move("orisa", btnOrisa, "tank");
        }

        private void btnHog_Click(object sender, EventArgs e)
        {
            move("hog", btnHog, "tank");
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            move("sigma", btnSig, "tank");
        }

        private void btnBall_Click(object sender, EventArgs e)
        {
            move("ball", btnBall, "tank");
        }

        // Support Break

        private void btnAna_Click_1(object sender, EventArgs e)
        {
            move("ana", btnAna, "support");
        }

        private void btnBap_Click(object sender, EventArgs e)
        {
            move("bap", btnBap, "support");
        }

        private void btnMoira_Click(object sender, EventArgs e)
        {
            move("moira", btnMoira, "support");
        }

        private void btnLucio_Click(object sender, EventArgs e)
        {
            move("lucio", btnLucio, "support");
        }

        private void btnBrig_Click(object sender, EventArgs e)
        {
            move("brig", btnBrig, "support");
        }

        private void btnZen_Click(object sender, EventArgs e)
        {
            move("zen", btnZen, "support");
        }

        private void btnMercy_Click(object sender, EventArgs e)
        {
            move("mercy", btnMercy, "support");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
