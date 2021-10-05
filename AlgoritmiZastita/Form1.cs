using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmiZastita
{
    

    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
           
        }

       

        public int[] alg = new int[9];
        public int izab = 0;

        public string[] kljucevi = new string[9];
        public string poruka;
        public string sifra;

        public string copyS="", copyD="";

        public int mode = 0; //0 - sifrovanje, 1 - desifrovanje

        private void Form1_Load(object sender, EventArgs e)
        {
            //sif
            label6.SendToBack();
            groupBox2.Visible = false;
            tbAutokey.Visible = tbCaesar.Visible = tbGauss.Visible = tbHill.Visible = tbMono.Visible = tbPlayfair.Visible = tbRF.Visible = tbRT.Visible = tbVigenere.Visible = false;

            //desif
            //tbPor2.Enabled = false;
            pictureBox4.Visible = pictureBox5.Visible = false;
            label5.Visible = false;
            label7.Visible = label8.Visible = tbSif2.Visible = tbPor2.Visible = false;
            pictureBox6.Visible = false;
        }

        private void buttonIzab_Click(object sender, EventArgs e)
        {

            if (izab > 0)
            {
                groupBox2.Visible = true;
                tbAutokey.Visible = tbCaesar.Visible = tbGauss.Visible = tbHill.Visible = tbMono.Visible = tbPlayfair.Visible = tbRF.Visible = tbRT.Visible = tbVigenere.Visible = false;

                if (izab==1)
                    groupBox2.Text = "Popuni kljuc";
                else
                    groupBox2.Text = "Popuni kljuceve";

                buttonIzab.Enabled = false;
                buttonResetujIzb.Enabled = false;
                for (int i = 0; i < izab; i++)
                {
                    int s = alg[i];
                    switch (s)
                    {
                        case 0: tbCaesar.Visible = true; break;
                        case 1: tbMono.Visible = true; break;
                        case 2: tbGauss.Visible = true; break;
                        case 3: tbPlayfair.Visible = true; break;
                        case 4: tbVigenere.Visible = true; break;
                        case 5: tbAutokey.Visible = true; break;
                        case 6: tbHill.Visible = true; break;
                        case 7: tbRF.Visible = true; break;
                        case 8: tbRT.Visible = true; break;

                    }

                    if (s == 1) //napraviti random kljuc za Mono
                    {
                        string klj = "";
                        int[] niz = new int[26];
                        int find;
                        Random rand = new Random();
                        for (int p = 0;  p< 26;)
                        {
                            find = 0;
                            int r = (int)(rand.NextDouble() * 26);
                            for (int j = 0; j < p; j++)
                            {
                                if (niz[j] == r)
                                {
                                    find = 1; break;
                                }
                            }
                            if (find == 0)
                            {
                                niz[p] = r;
                                p++;
                            }
                        }
                        for (int p= 0; p < 26; p++)
                        {
                            klj += (char)(niz[p] + 65);
                        }
                        tbMono.Text = klj;
                    }

                    if (s == 2) //kljuc za Gausa
                    {
                        string klj = "";
                        int[] nizG = new int[39];
                        int findG;
                        int pom;
                        pom = 34;
                        Random rand = new Random();
                        for (int p = 0; p < 39;)
                        {
                            findG = 0;
                            int r = (int)(rand.NextDouble() * 26) + 65;
                            for (int j = 0; j < p; j++)
                            {
                                if (nizG[j] == r)
                                {
                                    findG = 1; break;
                                }
                            }
                            if (findG == 0)
                            {
                                nizG[p] = r;
                                if (p == 0 || p == 6 || p == 12 || p == 21)
                                { //dva dodatna
                                    nizG[++p] = pom++;
                                    nizG[++p] = pom++;
                                }
                                else if (p == 19 || p == 26 || p == 28 || p == 30 || p == 32)
                                { //jedno dodatno
                                    nizG[++p] = pom++;
                                }
                                p++;
                            }
                        }
                        for (int p = 0; p < 39; p++)
                        {
                            klj += (char)(nizG[p]);
                        }
                        tbGauss.Text = klj;
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati neki algoritam sifrovavanja!");
            }


        }

        private void buttonIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCaesar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCaesar.Checked == true)
            {
                alg[izab] = 0;
                izab++;
            }
            else
            {
                int index=-1;
                for(int i=0; i<izab; i++)
                {
                    if (alg[i] == 0)
                    {
                        index = i; break;
                    }
                }
                for(int i=index; i<izab-1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }

           
        }

        private void cbMono_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMono.Checked == true)
            {
                alg[izab] = 1;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 1)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void cbGauss_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGauss.Checked == true)
            {
                alg[izab] = 2;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 2)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void cbPlayfair_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPlayfair.Checked == true)
            {
                alg[izab] = 3;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 3)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void cbVigenere_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVigenere.Checked == true)
            {
                alg[izab] = 4;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 4)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void cbAutokey_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutokey.Checked == true)
            {
                alg[izab] = 5;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 5)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void cbHill_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHill.Checked == true)
            {
                alg[izab] = 6;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 6)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void cbRF_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRF.Checked == true)
            {
                alg[izab] = 7;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 7)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void cbRT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRT.Checked == true)
            {
                alg[izab] = 8;
                izab++;
            }
            else
            {
                int index = -1;
                for (int i = 0; i < izab; i++)
                {
                    if (alg[i] == 8)
                    {
                        index = i; break;
                    }
                }
                for (int i = index; i < izab - 1; i++)
                {
                    alg[i] = alg[i + 1];
                }
                izab--;
            }
        }

        private void buttonWorkSif_Click(object sender, EventArgs e)
        {
            //popuniti niz kljuceva
            for(int i=0; i<izab; i++)
            {
                int a = alg[i];
                switch (a)
                {
                    case 0: kljucevi[i]=tbCaesar.Text; break;
                    case 1: kljucevi[i] = tbMono.Text ; break;
                    case 2: kljucevi[i] = tbGauss.Text; break;
                    case 3: kljucevi[i] = tbPlayfair.Text; break;
                    case 4: kljucevi[i] = tbVigenere.Text; break;
                    case 5: kljucevi[i] = tbAutokey.Text ; break;
                    case 6: kljucevi[i] = tbHill.Text ; break;
                    case 7: kljucevi[i] = tbRF.Text ; break;
                    case 8: kljucevi[i] = tbRT.Text ; break;
                }
                if (kljucevi[i] == "")
                {
                    MessageBox.Show("Morate uneti ključeve!\nKlikom na dugme Izaberi, pojaviće Vam se polja za unos ključeva!" +
                        "\nNijedno polje za unos ključeva ne sme ostati prazno!", "GREŠKA");
                    return;
                }
            }

            if (mode == 0) //sifrovanje
            {
                poruka = tbPor1.Text;
                sifra = IzbaciRazmake(poruka);
                for (int i = 0; i < izab; i++)
                {
                    int a = alg[i];
                    switch (a)
                    {
                        case 0: sifra = Cezar(sifra, kljucevi[i]); break;
                        case 1: sifra = Mono(sifra, kljucevi[i]); break;
                        case 2: sifra = Gaus(sifra, kljucevi[i]); break;
                        case 3: sifra = Playfair(sifra, kljucevi[i]); break;
                        case 4: sifra = Vigenere(sifra, kljucevi[i]); break;
                        case 5: sifra = Autokey(sifra, kljucevi[i]); break;
                        case 6: sifra = Hill(sifra, kljucevi[i]); break;
                        case 7: sifra = RailFence(sifra, kljucevi[i]); break;
                        case 8: sifra = RowTransition(sifra, kljucevi[i]); break;
                    }
                }
                tbSif1.Text = sifra;
            }
            else //desifrovanje
            {
                sifra = tbSif2.Text;
                poruka = IzbaciRazmake(sifra);
                for (int i = 0; i < izab; i++)
                {
                    int a = alg[i];
                    switch (a)
                    {
                        case 0: poruka = Cezar(poruka, kljucevi[i]); break;
                        case 1: poruka = Mono(poruka, kljucevi[i]); break;
                        case 2: poruka = Gaus(poruka, kljucevi[i]); break;
                        case 3: poruka = Playfair(poruka, kljucevi[i]); break;
                        case 4: poruka = Vigenere(poruka, kljucevi[i]); break;
                        case 5: poruka = Autokey(poruka, kljucevi[i]); break;
                        case 6: poruka = Hill(poruka, kljucevi[i]); break;
                        case 7: poruka = RailFence(poruka, kljucevi[i]); break;
                        case 8: poruka = RowTransition(poruka, kljucevi[i]); break;
                    }
                }
                tbPor2.Text = poruka;
            }
           

        }

        public string IzbaciRazmake(string p)
        {
            string ret = "";
            for(int i=0; i<p.Length; i++)
            {
                if ((int)p[i] != 32)
                    ret += p[i];
            }

            return ret;
        }

        public string PretvoriUVelika(string k)
        {
            string ret = "";

            foreach (char c in k)
            {
                int cc = (int)c;
                if (cc >= 97 && cc <= 122)
                    cc -= 32;
                char p = (char)cc;
                ret += p;
            }

            return ret;
        }

        public string Cezar(string str, string k)
        {
            if (mode == 0)
            {
                string por = str;
                string sif = "";
                int kljuc = 0;
                try
                {
                    kljuc = Int32.Parse(k);
                }
                catch (Exception e)
                {
                    tbCaesar.Text = "";
                    MessageBox.Show("Kljuc Cezarove sifre mora biti broj!");
                    return sif;
                }
                while (kljuc < 0)
                {
                    kljuc += 26;
                }
                kljuc %= 26;

                foreach (char c in por)
                {
                    char cc;
                    if ((int)c >= 65 && (int)c <= 90)
                        cc = (char)(65 + ((int)c - 65 + kljuc) % 26);
                    else if ((int)c >= 97 && (int)c <= 122)
                        cc = (char)(97 + ((int)c - 97 + kljuc) % 26);
                    else
                        cc = c;
                    sif += cc;
                }

                return sif;
            }
            else
            {
                string sif = str;
                string por = "";
                int kljuc=0;
                try
                {
                    kljuc = Int32.Parse(k);
                }
                catch(Exception e)
                {
                    tbCaesar.Text = "";
                    MessageBox.Show("Kljuc Cezarove sifre mora biti broj!");
                    return por;
                }
               
                while (kljuc < 0)
                {
                    kljuc += 26;
                }
                kljuc %= 26;
                foreach ( char c in sif)
                {
                    char cc;
                    if ((int)c >= 65 && (int)c <= 90)
                    {
                        if ((int)c - 65 - kljuc >= 0)
                            cc = (char)(65 + ((int)c - 65 - kljuc) % 26);
                        else
                            cc = (char)(65 + ((int)c - 65 - kljuc + 26) % 26);
                    }
                    else if ((int)c >= 97 && (int)c <= 122)
                    {
                        if ((int)c - 97 - kljuc >= 0)
                            cc = (char)(97 + ((int)c - 97 - kljuc) % 26);
                        else
                            cc = (char)(97 + ((int)c - 97 - kljuc + 26) % 26);
                    }
                    else
                        cc = c;
                    por += cc;
                }

                return por;
            }
           
        }

        public string Mono(string str, string k)
        {
            if (mode == 0)
            {
                string por = str;
                string sif = "";
                
                foreach (char c in por)
                {
                    char cc;
                    if ((int)c >= 65 && (int)c <= 90)
                    {
                        cc = k[(int)c - 65];
                    }
                    else if ((int)c >= 97 && (int)c <= 122)
                    {
                        cc = k[(int)c - 97];
                    }
                    else
                    {
                        cc = c;
                    }
                    sif += cc;
                }

                return sif;
            }
            else
            {
                string sif = str;
                string por = "";
                sif = PretvoriUVelika(sif);
                foreach ( char c in sif)
                {
                    char cc='a';
                    int find = 0;
                    for (int i = 0; i < k.Length; i++)
                    {
                        if (c == k[i])
                        {
                            find = 1;
                            cc = (char)(i + 65);
                            break;
                        }
                    }
                    if (find == 0)
                    { //nije slovo
                        cc = c;
                    }

                    por += cc;
                }
                return por;
            }
           
        }
        public string Gaus(string str, string klj)
        {
            
            int[] a = new int[3]; int[] e = new int[3]; int[] i = new int[3]; int[] o = new int[3];
            int[] n = new int[2]; int[] r = new int[2]; int[] s = new int[2]; int[] t = new int[2]; int[] u = new int[2];

            a[0] = klj[0]; a[1] = klj[1]; a[2] = klj[2];
            e[0] = klj[6]; e[1] = klj[7];  e[2] = klj[8];
            i[0] = klj[12]; i[1] = klj[13];  i[2] = klj[14];
            o[0] = klj[21]; o[1] = klj[22]; o[2] = klj[23];
            n[0] = klj[19]; n[1] = klj[20];
            r[0] = klj[26]; r[1] = klj[27];
            s[0] = klj[28];  s[1] = klj[29];
            t[0] = klj[30]; t[1] = klj[31];
            u[0] = klj[32]; u[1] = klj[33];

            string k = "";
            for (int p = 0; p < 39; p++)
            {
                if (p != 1 && p != 2 && p != 7 && p != 8 && p != 13 && p != 14 && p != 22 && p != 23 && p != 20 && p != 27 && p != 29 && p != 31 && p != 33)
                {
                    k += klj[p];
                }
            }
            int ba, be, bo, bi, bn, br, bs, bt, bu;
            ba = be = bo = bi = bn = br = bs = bt = bu = 0;


            if (mode == 0)
            {
                string por = str;
                string sif = "";
                foreach (char c in por)
                {
                    char cc = 'a';
                    int bc = (int)c;

                    if (bc >= 65 && bc <= 90)
                    {

                        if (bc == 65 || bc == 69 || bc == 73 || bc == 79)
                        {
                            if (bc == 65)
                            {
                                cc = (char)a[ba];
                                ba = (ba + 1) % 3;
                            }
                            else if (bc == 69)
                            {
                                cc = (char)e[be];
                                be = (be + 1) % 3;
                            }
                            else if (bc == 73)
                            {
                                cc = (char)i[bi];
                                bi = (bi + 1) % 3;
                            }
                            else if (bc == 79)
                            {
                                cc = (char)o[bo];
                                bo = (bo + 1) % 3;
                            }
                        }
                        else if (bc == 78 || bc == 82 || bc == 83 || bc == 84 || bc == 85)
                        {
                            if (bc == 78)
                            {
                                cc = (char)n[bn];
                                bn = (bn + 1) % 2;
                            }
                            else if (bc == 82)
                            {
                                cc = (char)r[br];
                                br = (br + 1) % 2;
                            }
                            else if (bc == 83)
                            {
                                cc = (char)s[bs];
                                bs = (bs + 1) % 2;
                            }
                            else if (bc == 84)
                            {
                                cc = (char)t[bt];
                                bt = (bt + 1) % 2;
                            }
                            else if (bc == 85)
                            {
                                cc = (char)u[bu];
                                bu = (bu + 1) % 2;
                            }
                        }
                        else
                        {
                            cc = k[bc - 65];
                        }
                    }
                    else if ((int)c >= 97 && (int)c <= 122)
                    {
                        if (bc == 97 || bc == 101 || bc == 105 || bc == 111)
                        {
                            if (bc == 97)
                            {
                                cc = (char)a[ba];
                                ba = (ba + 1) % 3;
                            }
                            else if (bc == 101)
                            {
                                cc = (char)e[be];
                                be = (be + 1) % 3;
                            }
                            else if (bc == 105)
                            {
                                cc = (char)i[bi];
                                bi = (bi + 1) % 3;
                            }
                            else if (bc == 111)
                            {
                                cc = (char)o[bo];
                                bo = (bo + 1) % 3;
                            }
                        }
                        else if (bc == 110 || bc == 114 || bc == 115 || bc == 116 || bc == 117)
                        {
                            if (bc == 110)
                            {
                                cc = (char)n[bn];
                                bn = (bn + 1) % 2;
                            }
                            else if (bc == 114)
                            {
                                cc = (char)r[br];
                                br = (br + 1) % 2;
                            }
                            else if (bc == 115)
                            {
                                cc = (char)s[bs];
                                bs = (bs + 1) % 2;
                            }
                            else if (bc == 116)
                            {
                                cc = (char)t[bt];
                                bt = (bt + 1) % 2;
                            }
                            else if (bc == 117)
                            {
                                cc = (char)u[bu];
                                bu = (bu + 1) % 2;
                            }
                        }
                        else
                        {
                            cc = k[bc - 97];
                        }
                    }
                    else
                    {
                        cc = c;
                    }
                    sif += cc;
                }


                return sif;

            }
            else
            {
                string por= "";
                string sif = str;
                sif = PretvoriUVelika(sif);
                foreach ( char c in sif)
                {
                    char cc='a';
                    int find = 0;
                    for (int pi = 0; pi < k.Length; pi++)
                    {
                        if (c == k[pi])
                        {
                            find = 1;
                            cc = (char)(pi + 65);
                            break;
                        }
                    }
                    if (find == 0)
                    {
                        for (int j = 1; j < 3; j++)
                        {
                            if (c == a[j])
                            {
                                find = 1;
                                cc = 'A';
                                break;
                            }
                            else if (c == e[j])
                            {
                                find = 1;
                                cc = 'E';
                                break;
                            }
                            else if (c == i[j])
                            {
                                find = 1;
                                cc = 'I';
                                break;
                            }
                            else if (c == o[j])
                            {
                                find = 1;
                                cc = 'O';
                                break;
                            }
                        }
                    }
                    if (find == 0)
                    {
                        for (int j = 1; j < 2; j++)
                        {
                            if (c == n[j])
                            {
                                find = 1;
                                cc = 'N';
                                break;
                            }
                            else if (c == r[j])
                            {
                                find = 1;
                                cc = 'R';
                                break;
                            }
                            else if (c == s[j])
                            {
                                find = 1;
                                cc = 'S';
                                break;
                            }
                            else if (c == t[j])
                            {
                                find = 1;
                                cc = 'T';
                                break;
                            }
                            else if (c == u[j])
                            {
                                find = 1;
                                cc = 'U';
                                break;
                            }
                        }
                    }
                    if (find == 0)
                    { //nije slovo
                        cc = c;
                    }

                    por += cc;
                }


                return por;
            }
        }
        public string Playfair(string str, string k)
        {
            int brk= 0;
            int brm= 65;
            int keyNotEnd = 1;
            int put = 0;

            char[,] mat = new char[5,5];

            k = PretvoriUVelika(k);
            string kp = "";
            for (int p = 0; p < k.Length; p++)
            {
                if (k[p] == 'J')
                {
                    kp += 'I';
                }
                else
                {
                    kp += k[p];
                }
            }
            k = kp;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    put = 0;
                    if (keyNotEnd!=0)
                    {
                        while (brk < k.Length)
                        {
                            int find = 0;
                            for (int pb = 0; pb < brk; pb++)
                            {
                                if (k[pb] == k[brk])
                                {
                                    find = 1;
                                    brk++;
                                    break;
                                }
                            }
                            if (find == 0)
                            {
                                mat[i,j] = k[brk++];
                                put = 1;
                                break;
                            }
                        }
                        if (brk == k.Length)
                            keyNotEnd = 0;
                    }

                    if (keyNotEnd==0 && put == 0)
                    {
                        while (true)
                        {
                            char c = (char)brm;
                            if (c == 'J')
                            {
                                brm++;
                                c = (char)brm;
                            }
                            int find = 0;
                            for (int p = 0; p < k.Length; p++)
                            {
                                if (k[p] == c)
                                {
                                    find = 1;
                                    brm++;
                                    break;
                                }
                            }
                            if (find == 0)
                            {
                                mat[i,j] = c;
                                brm++;
                                break;
                            }
                        }
                    }

                }
            }

            if (mode == 0)
            {
                string sif = "";
                string por = str;
                por = PretvoriUVelika(por);

                int br = 0;
                char c1, c2;
                int r1 = 0, k1 = 0, r2 = 0, k2 = 0;

                while (br < por.Length)
                {


                    c1 = por[br++];
                    if (c1 == 'J')
                    {
                        c1 = 'I';
                    }
                    if (br == por.Length)
                    {
                        c2 = 'X';
                        br++;
                    }
                    else
                    {
                        c2 = por[br];
                        if (c2 == 'J')
                        {
                            c2 = 'I';
                        }
                        if (c1 == c2)
                        {
                            c2 = 'X';
                        }
                        else
                        {
                            br++;
                        }
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (mat[i, j] == c1)
                            {
                                r1 = i;
                                k1 = j;
                            }
                            if (mat[i, j] == c2)
                            {
                                r2 = i;
                                k2 = j;
                            }
                        }
                    }
                    if (r1 == r2)
                    {
                        sif += mat[r2, ((k1 + 1) % 5)];
                        sif += mat[r2, ((k2 + 1) % 5)];
                    }
                    else if (k1 == k2)
                    {
                        sif += mat[(r1 + 1) % 5, k2];
                        sif += mat[(r2 + 1) % 5, k2];
                    }
                    else
                    {
                        sif += mat[r1, k2];
                        sif += mat[r2, k1];
                    }

                }
                return sif;
            }
            else
            {
                string por = "";
                string sif = str;
                sif = PretvoriUVelika(sif);
                int br = 0;
                char c1, c2;
                int r1, k1, r2, k2;
                r1 = k1 = r2 = k2 = -1;
                char d1, d2;

                while (br < sif.Length)
                {
                    c1 = sif[br++];
                    c2 = sif[br++];
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (c1 == mat[i,j])
                            {
                                r1 = i; k1 = j;
                            }
                            if (mat[i,j] == c2)
                            {
                                r2 = i; k2 = j;
                            }
                        }
                    }
                    if (r1 == r2)
                    {
                        d1 = mat[r1,(k1 + 4) % 5];
                        d2 = mat[r1,(k2 + 4) % 5];
                    }
                    else if (k1 == k2)
                    {
                        d1 = mat[(r1 + 4) % 5,k1];
                        d2 = mat[(r2 + 4) % 5,k1];
                    }
                    else
                    {
                        d1 = mat[r1,k2];
                        d2 = mat[r2,k1];

                    }
                    por += d1;
                    if (d2 != 'X')
                        por += d2;


                }

                return por;
            }
        }
        public string Vigenere(string str, string k)
        {

            string key = "";
            int br = 0; int brk = 0;
            while (br < str.Length)
            {
                key += k[brk];
                brk = (brk + 1) % k.Length;
                br++;
            }

            if (mode == 0)
            {
                string sif = "";
                string por = str;

                int b;
                for (int i = 0; i < por.Length; i++)
                {
                    char c = por[i];
                    int bc = (int)c;
                    if (bc >= 65 && bc <= 90)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;
                        b = 65 + (bc - 65 + kp) % 26;
                    }
                    else if (bc >= 97 && bc <= 122)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;
                        b = 97 + (bc - 97 + kp) % 26;
                    }
                    else
                    {
                        b = bc;
                    }
                    sif += (char)b;
                }

                return sif;
            }
            else
            {
                string por = "";
                string sif = str;
                int b;
                int d;
                for (int i = 0; i < sif.Length; i++)
                {
                    char c = sif[i];
                    int bc = (int)c;
                    if (bc >= 65 && bc <= 90)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;

                        d = (bc - 65 - kp);
                        if (d < 0)
                            d += 26;
                        b = 65 + d % 26;
                    }
                    else if (bc >= 97 && bc <= 122)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;


                        d = (bc - 97 - kp);
                        if (d < 0)
                            d += 26;
                        b = 97 + d % 26;
                    }
                    else
                    {
                        b = bc;
                    }
                    por += (char)b;
                }
                return por;
            }

           
        }
        public string Autokey(string str, string k)
        {
            if (mode == 0)
            {
                string por = str;
                string sif = "";
                string key = "";
                int br = 0;

                while (br < k.Length)
                {
                    key += k[br++];
                }

                int b;
                for (int i = 0; i < por.Length; i++)
                {
                    char c = por[i];
                    int bc = (int)c;
                    if (bc >= 65 && bc <= 90)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;
                        b = 65 + (bc - 65 + kp) % 26;
                    }
                    else if (bc >= 97 && bc <= 122)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;
                        b = 97 + (bc - 97 + kp) % 26;
                    }
                    else
                    {
                        b = bc;
                    }
                    sif += (char)b;
                    if (br < por.Length)
                        key += c;
                }

                return sif;
            }
            else
            {
                string sif = str;
                string por = "";
                string key = "";
                int br = 0;

                while (br < k.Length)
                {
                    key += k[br++];
                }

                int b;
                int d;
                for (int i = 0; i < sif.Length; i++)
                {
                    char c = sif[i];
                    int bc = (int)c;
                    if (bc >= 65 && bc <= 90)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;

                        d = (bc - 65 - kp);
                        if (d < 0)
                            d += 26;
                        b = 65 + d % 26;
                    }
                    else if (bc >= 97 && bc <= 122)
                    {
                        int kp;
                        if ((int)key[i] >= 65 && (int)key[i] <= 90)
                            kp = (int)key[i] - 65;
                        else
                            kp = (int)key[i] - 97;


                        d = (bc - 97 - kp);
                        if (d < 0)
                            d += 26;
                        b = 97 + d % 26;
                    }
                    else
                    {
                        b = bc;
                    }
                    por += (char)b;
                    if (br < sif.Length)
                    {
                        key += (char)b;
                    }
                }

                return por;
            }


          
        }

        public string Hill(string str, string k)
        {

            if (k.Length !=1 && k.Length!=4 && k.Length!=9 && k.Length != 16 && k.Length != 25 && k.Length != 36 && k.Length != 49 && k.Length != 64 && k.Length != 81 && k.Length != 100)
            {
                tbHill.Text = "";
                MessageBox.Show("Kljuc za Hill-ov algoritam nije odgovarajuce duzine! Njegova duzina mora biti kvadrat nekog " +
                    "jednocifrenog broja!\nMolimo Vas, pokusajte ponovo.");
                
                return "";
            }

            k = PretvoriUVelika(k);
            int dimMK;
            
            dimMK = (int)Math.Sqrt(k.Length);

            int[,] matK = new int[dimMK, dimMK];

           

            int br = 0;
            for (int i = 0; i < dimMK; i++)
            {
                for (int j = 0; j < dimMK; j++)
                {
                    char c = k[br++];
                    matK[i,j] = (int)c - 65;
                }
            }

            if (mode == 0)
            {
                string sif = "";
                string por = str;
                por = PretvoriUVelika(por);
                br = 0;
                int[] deo = new int[dimMK];
                while (br + dimMK <= por.Length)
                {
                    for (int pom = 0; pom < dimMK; pom++)
                    {
                        int sl = (int)por[br++];
                        if (sl >= 65 && sl <= 90)
                            deo[pom] = sl - 65;
                        else if (sl >= 97 && sl <= 122)
                            deo[pom] = sl - 97;
                        else
                            deo[pom] = sl;
                    }

                    int obr = 0;
                    while (obr < dimMK)
                    {
                        int elem = 0;
                        for (int tmp = 0; tmp < dimMK; tmp++)
                        {
                            elem += matK[tmp, obr] * deo[tmp];
                        }
                        elem %= 26;
                        sif += (char)(elem + 65);
                        obr++;
                    }
                }
                int ost = por.Length - br;
                int n = 0;
                if (ost != 0)
                {
                    while (ost != 0)
                    {
                        int sl = (int)por[br++];
                        if (sl >= 65 && sl <= 90)
                            deo[n] = sl - 65;
                        else if (sl >= 97 && sl <= 122)
                            deo[n] = sl - 97;
                        else
                            deo[n] = sl;

                        n++;
                        ost--;
                    }
                    while (n < dimMK)
                    {
                        deo[n++] = (int)('X' - 65);
                    }

                    int obr = 0;
                    while (obr < dimMK)
                    {
                        int elem = 0;
                        for (int tmp = 0; tmp < dimMK; tmp++)
                        {
                            elem += matK[tmp, obr] * deo[tmp];
                        }
                        elem %= 26;
                        sif += (char)(elem + 65);
                        obr++;
                    }
                }


                return sif;
            }
            else
            {
                string sif = str;
                string por = "";
                sif = PretvoriUVelika(sif);

                //DET(K):
                int det = Determ(matK, dimMK);
                while (det < 0)
                {
                    det += 26;
                }

                //DET(K)^-1:
                int i;
                for (i = 0; i < 26; i++)
                {
                    if ((det * i) % 26 == 1)
                        break;
                }
                int b = 0;
                if (i != 26)
                {
                    b = i;
                }
                else
                {
                    MessageBox.Show("PORUKA SE NE MOZE DESIFROVATI SA OVIM KLJUCEM! ZAMOLITE POSILJAOCA DA POSALJE OPET PORUKU SA NEKIM DRUGIM KLJUCEM!");
                    return "";
                }

                //TRANSPONOVANA:
                matK = TransponujMat(matK,dimMK);

                //ADJUNGOVANA:
                matK = AdjungovanaMat(matK,dimMK);

                //INVERZNA: 
                for (i = 0; i < dimMK; i++)
                {
                    for (int j = 0; j < dimMK; j++)
                    {
                        matK[i,j] *= b;
                        matK[i,j] %= 26;
                    }
                }


                //MNOZENJE C*K^-1:
                br = 0;
                int[] deo = new int[dimMK];
                while (br < sif.Length)
                {
                    for (int pom = 0; pom < dimMK; pom++)
                    {
                        int sl = (int)sif[br++];
                        if (sl >= 65 && sl <= 90)
                            deo[pom] = sl - 65;
                        else
                            deo[pom] = sl;
                    }

                    int obr = 0;
                    while (obr < dimMK)
                    {
                        int elem = 0;
                        for (int tmp = 0; tmp < dimMK; tmp++)
                        {
                            elem += matK[tmp,obr] * deo[tmp];
                        }
                        elem %= 26;
                        por += (char)(elem + 65);
                        obr++;
                    }
                }
                //br=s.length()
                int duz = por.Length;
                int del = 0;
                br--;
                while (por[br] == 'X')
                {
                    br--;
                    del++;
                }
                por=por.Substring(0, duz - del);

                return por;
            }
           
        }
        public string RailFence(string str, string k)
        {
            int klj;
            try
            {
                klj = Int32.Parse(k);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ključ Rail Fence algoritma je broj.");
                tbRF.Text = "";
                return "";
            }

            char[,] mat = new char[klj, str.Length/2];

            if (mode == 0)
            {
                string sif = "";
                string por = str;
                int cnt = 0; //za poruku
                int row=0; //u kom sam redu
                int turn = 0; //smer: 0-na dole, 1-na gore

                int[] brKolone = new int[klj];
                for (int i = 0; i < klj; i++)
                    brKolone[i] = 0;

                
                while (cnt < por.Length)
                {
                    int col = brKolone[row];
                    mat[row, col] = por[cnt++];
                    brKolone[row]++;

                    if (turn==0 && row<klj-1)
                    {
                        row++;
                    }
                    else if(turn==0 && row == klj - 1)
                    {
                        turn = 1;
                        row--;
                    }
                    else if(turn==1 && row > 0)
                    {
                        row--;
                    }
                    else if(turn==1 && row == 0)
                    {
                        turn = 0;
                        row++;
                    }
                    
                }

                for(int i=0; i<klj; i++)
                {
                    int br = brKolone[i] ;
                    for(int j=0; j<br; j++)
                    {
                        sif += mat[i, j];
                    }
                }

                return sif;
            }
            else
            {
                string por = "";
                string sif = str;

                int[] granice = new int[klj];
                int cnt = 0;
                int turn = 0;
                int row = 0;
                while (cnt < sif.Length)
                {
                    granice[row]++;

                    if (turn == 0 && row < klj - 1)
                        row++;
                    else if (turn == 0 && row == klj - 1)
                    {
                        turn = 1;
                        row--;
                    }
                    else if (turn == 1 && row > 0)
                        row--;
                    else if(turn==1 && row == 0)
                    {
                        turn = 0;
                        row++;
                    }

                    cnt++;
                }

                char[][] nizovi = new char[klj][];

                cnt = 0;
                for(int i=0; i<klj; i++)
                {
                    int gr = granice[i];
                    nizovi[i] = new char[gr];
                    for(int j=0; j<gr; j++)
                    {
                        nizovi[i][j] = sif[cnt++];
                    }
                }

                int[] brKolone = new int[klj];
                for (int i = 0; i < klj; i++)
                    brKolone[i] = 0;

                cnt = 0;
                row = 0;
                turn = 0;
                while (cnt < sif.Length)
                {
                    int col = brKolone[row];
                    por+= nizovi[row][col];
                    brKolone[row]++;

                    if (turn == 0 && row < klj - 1)
                    {
                        row++;
                    }
                    else if (turn == 0 && row == klj - 1)
                    {
                        turn = 1;
                        row--;
                    }
                    else if (turn == 1 && row > 0)
                    {
                        row--;
                    }
                    else if (turn == 1 && row == 0)
                    {
                        turn = 0;
                        row++;
                    }
                    cnt++;
                }


                return por;
            }
           
        }
        public string RowTransition(string str, string k)
        {

            int times = 1;
            if (k[1] == 'x' && k[2]=='(')
            {
                try
                {
                    times = Int32.Parse(k[0].ToString());
                }
                catch(Exception e)
                {
                    MessageBox.Show("Ključ Row Transition algoritma nije u ispravnom formatu!\n\n" +
                       "Mogući formati:\n" +
                       "1. Samo permutacija brojeva od 1 do nekog broja N (npr. 3142, 6243571...)\n" +
                       "2. Uz permutaciju dodati i koliko puta da se ponovi algoritam (npr. 2x(3142), 3x(42513), ...)", "Greška");
                    tbRT.Text = "";
                    return "";
                }
                int zatvZagrada = k.LastIndexOf(')');
                if (zatvZagrada == -1)
                {
                    MessageBox.Show("Ključ Row Transition algoritma nije u ispravnom formatu!\n\n" +
                        "Mogući formati:\n" +
                        "1. Samo permutacija brojeva od 1 do nekog broja N (npr. 3142, 6243571...)\n" +
                        "2. Uz permutaciju dodati i koliko puta da se ponovi algoritam (npr. 2x(3142), 3x(42513), ...)", "Greška");
                    tbRT.Text = "";
                    return "";
                }
                int sekv = zatvZagrada - 3;
                k = k.Substring(3, sekv);
            }
            else if (k[2] == 'x' && k[3] == '(')
            {
                string pom = k.Substring(0, 2);
                try
                {
                    times = Int32.Parse(pom.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ključ Row Transition algoritma nije u ispravnom formatu!\n\n" +
                       "Mogući formati:\n" +
                       "1. Samo permutacija brojeva od 1 do nekog broja N (npr. 3142, 6243571...)\n" +
                       "2. Uz permutaciju dodati i koliko puta da se ponovi algoritam (npr. 2x(3142), 3x(42513), ...)", "Greška");
                    tbRT.Text = "";
                    return "";
                }
                int zatvZagrada = k.LastIndexOf(')');
                if (zatvZagrada == -1)
                {
                    MessageBox.Show("Ključ Row Transition algoritma nije u ispravnom formatu!\n\n" +
                        "Mogući formati:\n" +
                        "1. Samo permutacija brojeva od 1 do nekog broja N (npr. 3142, 6243571...)\n" +
                        "2. Uz permutaciju dodati i koliko puta da se ponovi algoritam (npr. 2x(3142), 3x(42513), ...)", "Greška");
                    tbRT.Text = "";
                    return "";
                }
                int sekv = zatvZagrada - 4;
                k = k.Substring(4, sekv);
            }



            int duz = k.Length;
            int[] niz = new int[duz];
            int findi = 0;
            int ind = 0;
            for (int i = 1; i <= duz; i++) //trazimo cifre od 1 do duz
            {
                findi = 0;
                for (int j = 0; j < duz; j++) //prolazimo kroz kljuc i trazimo cifru i
                {
                    int cif;
                    try
                    {
                        cif = Int32.Parse(k[j].ToString());
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Ključ Row Transition algoritma nije u ispravnom formatu!\n\n" +
                        "Mogući formati:\n" +
                        "1. Samo permutacija brojeva od 1 do nekog broja N (npr. 3142, 6243571...)\n" +
                        "2. Uz permutaciju dodati i koliko puta da se ponovi algoritam (npr. 2x(3142), 3x(42513), ...)", "Greška");
                        tbRT.Text = "";
                        return "";
                    }
                    
                    if (cif == i)
                    {
                        findi = 1;
                        niz[ind] = j;
                        break;
                    }
                }
                if (findi == 0)
                {
                    MessageBox.Show("Ključ Row Transition algoritma nije u ispravnom formatu!\n\n" +
                      "Mogući formati:\n" +
                      "1. Samo permutacija brojeva od 1 do nekog broja N (npr. 3142, 6243571...)\n" +
                      "2. Uz permutaciju dodati i koliko puta da se ponovi algoritam (npr. 2x(3142), 3x(42513), ...)", "Greška");
                    tbRT.Text = "";
                    return "";
                }
                else
                {
                    ind++;
                }

            }

            if (mode == 0)
            {
                string por = str;
                string sif = "";

                int brTimes = 0;
                while (brTimes < times)
                {
                    sif = "";
                    int duzPor = por.Length;
                    int ost = duzPor % duz;
                    int dopuna = k.Length - ost;
                    if (ost != 0)
                    {
                        for (int i = 0; i < dopuna; i++)
                        {
                            por += "X";
                        }
                    }

                    duzPor = por.Length;
                    int numK = duz, numR = duzPor / duz;
                    char[,] mat = new char[numR, numK];
                    int cnt = 0;
                    for (int i = 0; i < numR; i++) //upis u matricu
                    {
                        for (int j = 0; j < numK; j++)
                        {
                            mat[i, j] = por[cnt];
                            cnt++;
                        }
                    }


                    cnt = 0;
                    while (cnt < numK) //citanje matrice
                    {
                        int col = niz[cnt];
                        for (int i = 0; i < numR; i++)
                        {
                            sif += mat[i, col];
                        }
                        cnt++;
                    }

                    por = sif;
                    brTimes++;
                }

               

                return sif;
            }
            else
            {
                string por = "";
                string sif = str;

                int brTimes = 0;
                while (brTimes < times)
                {
                    por = "";
                    int duzK = k.Length;
                    int duzSif = sif.Length;
                    int numR = duzSif / duzK, numK = duzK;
                    char[,] mat = new char[numR, numK];
                    int pi = 0;
                    for (int i = 0; i < niz.Length; i++)
                    {
                        int col = niz[i];
                        for (int j = 0; j < numR; j++)
                        {
                            mat[j, col] = sif[pi];
                            pi++;
                        }
                    }

                    for (int i = 0; i < numR; i++)
                    {
                        for (int j = 0; j < numK; j++)
                        {
                            por += mat[i, j];
                        }
                    }

                    if (brTimes == times - 1)
                    {
                        int end = 0;
                        do
                        {
                            end = 0;
                            int last = por.Length;
                            if (por[last - 1] == 'X')
                            {
                                por = por.Substring(0, last - 1);
                                end = 1;
                            }
                        } while (end == 1);
                    }
                    

                    sif = por;
                    brTimes++;
                }

                

                return por;
            }
           
           
        }

        private void buttonPonovi_Click(object sender, EventArgs e)
        {
            cbAutokey.Checked = cbCaesar.Checked = cbGauss.Checked = cbHill.Checked = cbMono.Checked = cbPlayfair.Checked = cbRF.Checked = cbRT.Checked = cbVigenere.Checked = false;
            izab = 0;
            tbAutokey.Text = tbCaesar.Text = tbGauss.Text = tbHill.Text = tbMono.Text = tbPlayfair.Text = tbRF.Text = tbRT.Text = tbVigenere.Text = "";
            tbSif1.Text = tbPor1.Text =tbSif2.Text=tbPor2.Text="";
            groupBox2.Visible = false;
            buttonIzab.Enabled = true;
            buttonResetujIzb.Enabled = true;
        }

        private void tbCaesar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.tbCaesar, "Kljuć je broj od 1 do 25!");
        }

        private void tbMono_TextChanged(object sender, EventArgs e)
        {
            //SLUCAJNO, ALI NEMOJ BRISATI!
        }

        private void tbMono_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.tbMono, "Ovo je generisani ključ!\nMožete ga promeniti, ali pazite da to bude permutacija abecede!");
        }

        private void tbGauss_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip3.SetToolTip(this.tbGauss, "Ovo je generisani ključ!\nNije preporučljivo menjati ga jer je teško zadržati ispravan format!");
        }

        private void tbHill_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip4.SetToolTip(this.tbHill, "Dužina ključa mora biti kvadrat nekog jednocifrenog broja (1,4,9,16,25... karaktera)!");
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb == tbCaesar)
            {
                System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                ToolTip1.SetToolTip(this.tbCaesar, "Ključ je broj od 1 do 25!");
            }
            else if (tb == tbMono)
            {
                System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
                ToolTip2.SetToolTip(this.tbMono, "Ovo je generisani ključ!\nMožete ga promeniti, ali pazite da to bude permutacija abecede!");
            }
            else if (tb == tbGauss)
            {
                System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
                ToolTip3.SetToolTip(this.tbGauss, "Ovo je generisani ključ!\nNije preporučljivo menjati ga jer je teško zadržati ispravan format!");
            }
            else if (tb == tbPlayfair)
            {
                System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
                ToolTip6.SetToolTip(this.tbPlayfair, "Upišite ključ!");
            }
            else if(tb== tbAutokey)
            {
                System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
                ToolTip6.SetToolTip(this.tbAutokey, "Upišite ključ!");
            }
            else if (tb == tbVigenere)
            {
                System.Windows.Forms.ToolTip ToolTip6 = new System.Windows.Forms.ToolTip();
                ToolTip6.SetToolTip(this.tbVigenere, "Upišite ključ!");
            }
            else if (tb == tbHill)
            {
                System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
                ToolTip4.SetToolTip(this.tbHill, "Dužina ključa mora biti kvadrat nekog jednocifrenog broja (1,4,9,16,25... karaktera)!");
            }
        }

        private void buttonDesif_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1; //desifrovanje
            }
            else
            {
                mode = 0; //sifrovanje
            }

            if (mode == 1)
            {
                buttonDesif.Text = "Šifrovanje";

                tbSif1.Visible = tbPor1.Visible = pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = false;
                label3.Visible = label4.Visible = label6.Visible = false;
                buttonWorkSif.Text = "Dešifruj";

                pictureBox4.Visible = pictureBox5.Visible = true;
                label5.Visible = true; label5.SendToBack();
                label7.Visible = label8.Visible = tbSif2.Visible = tbPor2.Visible = true;
                pictureBox6.Visible = true ;

            }
            else
            {
                buttonDesif.Text = "Dešifrovanje";

                tbSif1.Visible = tbPor1.Visible = pictureBox1.Visible = pictureBox2.Visible = pictureBox3.Visible = true;
                label3.Visible = label4.Visible = label6.Visible = true;
                buttonWorkSif.Text = "Šifruj";

                pictureBox4.Visible = pictureBox5.Visible = false;
                label5.Visible = false; label5.SendToBack();
                label7.Visible = label8.Visible = tbSif2.Visible = tbPor2.Visible = false;
                pictureBox6.Visible = false;

            }
            groupBox2.Visible = false;
            tbAutokey.Visible = tbCaesar.Visible = tbGauss.Visible = tbHill.Visible = tbMono.Visible = tbPlayfair.Visible = tbRF.Visible = tbRT.Visible = tbVigenere.Visible = false;
            cbAutokey.Checked = cbCaesar.Checked = cbGauss.Checked = cbHill.Checked = cbMono.Checked = cbPlayfair.Checked = cbRF.Checked = cbRT.Checked = cbVigenere.Checked = false;
            izab = 0;
            tbAutokey.Text = tbCaesar.Text = tbGauss.Text = tbHill.Text = tbMono.Text = tbPlayfair.Text = tbRF.Text = tbRT.Text = tbVigenere.Text = "";
            tbSif1.Text = tbPor1.Text = tbSif2.Text = tbPor2.Text = "";
            groupBox2.Visible = false;
            buttonIzab.Enabled = true;
            buttonResetujIzb.Enabled = true;
        }

        private void buttonResetujIzb_Click(object sender, EventArgs e)
        {
            cbAutokey.Checked = cbCaesar.Checked = cbGauss.Checked = cbHill.Checked = cbMono.Checked = cbPlayfair.Checked = cbRF.Checked = cbRT.Checked = cbVigenere.Checked = false;
            izab = 0;

        }

        public int Determ(int[,] a, int n)
        {
            int det = 0, p, h, k, i, j;

            int[,] temp = new int[n, n];

            if (n == 1)
            {
                return a[0,0];
            }
            else if (n == 2)
            {
                det = (a[0,0] * a[1,1] - a[0,1] * a[1,0]);
                return det;
            }
            else
            {
                for (p = 0; p < n; p++)
                {
                    h = 0;
                    k = 0;
                    for (i = 1; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            if (j == p)
                            {
                                continue;
                            }
                            temp[h,k] = a[i,j];
                            k++;
                            if (k == n - 1)
                            {
                                h++;
                                k = 0;
                            }
                        }
                    }
                    det = det + a[0,p] * (int)Math.Pow(-1, p) * Determ(temp, n - 1);
                }
                return det;
            }
        }

        public int[,] TransponujMat(int[,] a, int n)
        {
            int[,] temp = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp[j,i] = a[i,j];
                }
            }

            return temp;
        }

        public int[,] AdjungovanaMat(int[,] a,int n)
        {
            int[,] temp = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    int[,] temp2 = new int[n - 1, n - 1];

                    int r = 0, s = 0;
                    for (int m = 0; m < n; m++)
                    {
                        for (int np = 0; np < n; np++)
                        {
                            if (i == m || j == np)
                                continue;
                            temp2[r,s] = a[m,np];
                            s++;
                            if (s == n - 1)
                            {
                                s = 0;
                                r++;
                            }
                        }
                    }


                    temp[i,j] = Determ(temp2, n - 1);

                   
                    if ((i + j) % 2 == 1)
                        temp[i,j] *= -1;

                    while (temp[i,j] < 0)
                    {
                        temp[i,j] += 26;
                    }
                    temp[i,j] %= 26;
                }
            }


            return temp;
        }

        private void ponudiTekst(object sender, MouseEventArgs e)
        {
            if((mode==0 && copyD != "" && tbPor1.Text=="") || (mode == 1 && copyS != "" && tbSif2.Text == ""))
            {
                Form2 frm = new Form2("Da li zelite da nalepite poruku\n koju ste kopirali?", "DA", "NE");
                frm.ShowDialog(this);
            }
        }

        private void ponudiTekst(object sender, EventArgs e)
        {
            //SLUCAJNO, NE BRISI
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (mode == 0) //sifrovanje
            {
                copyS = tbSif1.Text;
            }
            else //desifrovanje
            {
                copyD = tbPor2.Text;
            }
        }

        private void šifrovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                buttonDesif.PerformClick();
            }
        }

        private void dešifrovanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                buttonDesif.PerformClick();
            }
        }

        private void buttonCopy_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            string por = "";
            if (mode == 0)
            {
                por = "Klikom na dugme, kopirate šifru koju ste dobili posle šifrovanja";
            }
            else
            {
                por = "Klikom na dugme, kopirate poruku koju ste dobili posle dešifrovanja";
            }
            ToolTip2.SetToolTip(this.buttonCopy, por);
        }

        public void ubaciTekst(int put, int ch)
        {
            
                if (mode == 0)
                {
                    if(put==1)
                        tbPor1.Text = copyD;
                    if (ch == 1)
                        copyD = "";
                }
                else
                {
                    if (put == 1)
                        tbSif2.Text = copyS;
                    if (ch == 1)
                        copyS = "";
                }
           
        }
    }

}
