using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public class Banka
    {
        public string jmeno;
        public int stavKonta;
        public int max = 200000;
        public string cisloUctu;
    
    public Banka(int stavKonta, string cisloUctu)
    {
        this.stavKonta = stavKonta;
        this.cisloUctu = cisloUctu;
    }
    public void Vklad(int vklad)
    {
        if (vklad + stavKonta <= max)
        {
            stavKonta += vklad;
            MessageBox.Show("Bylo vloženo: " + vklad.ToString());
        }
        else if (vklad + stavKonta >= max)
        {
            MessageBox.Show("Nepodařilo se vložit částku z důvodu překročení limitu.");
            MessageBox.Show("Můžete vložit maximálně: " + max);
        }
    }
    public void Vyber(int vyber)
    {

        if (vyber - stavKonta <= 0)
        {
            stavKonta -= vyber;
            MessageBox.Show("Bylo vybráno: " + vyber.ToString());
        }
        else if (vyber - stavKonta > 0)
        {
            MessageBox.Show("Nemáte dostatek peněz na výběr z účtu:)");
        }
        else
        {
            MessageBox.Show("Nepodařilo se vybrat, došlo k překročení limitu.");
        }
        }

    }

}
