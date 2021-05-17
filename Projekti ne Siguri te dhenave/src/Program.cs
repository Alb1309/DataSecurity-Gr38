using System;   //librari per c#
using System.Collections.Generic;   //e siguron mos-keqinterpretimin e komandave me pjese te tjera te kodit. P.sh. nese perdorim read, write etj.
using System.Linq;  //Kjo e mundeson ekzekutimin e nje pjese te programit pas rewrite-rishkrimit
using System.Threading.Tasks;   //Lejon ekzekutimin e pjeseve programore per te kryer tasks ne menyra te vecanta ne menyre paralele
using System.Windows.Forms;    //Permban klasat per me kriju aplikacione Windows-based

namespace ProductionProject//ProjektiProd?
{
    static class Program
    {
        
        //->Pjesa kryesore (main) e aplikacionit
        
        [STAThread] //Atribut i cili specifikon mekanizmin e komunikimit ndermjet threadave te cilet kom. me COM
        static void Main()
        {
            Application.EnableVisualStyles(); //Kjo nevojitet per me e bo themed dritaren e pare te programit
            Application.SetCompatibleTextRenderingDefault(false); //Kjo perdoret atehere kur programit tone i bojme upgrade dhe deshirojme me e mbajt versionin e vjeter pa ndryshime, dmth te vlefshem
            Application.Run(new WelcomeForm()); //Per formen tone brenda kllapave, e mundeson me qene e pashme-visibile
        }
    }
}
