using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week4_Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Exercice 8
            Console.WriteLine("Entrez une phrase afin de compter les espaces");
            string phrase=Convert.ToString(Console.ReadLine());
            int result=Espace(phrase);
            Console.WriteLine("Il y a " + result + " espaces dans la phrase");
            */
            /*
            //Exercice 7
            Console.WriteLine("Entrez un chiffre pour trouver son factoriel");
            int c = Convert.ToInt32(Console.ReadLine());
            int result = factoriel(c);
            Console.WriteLine("Le factoriel de " + c + " est " + result);
            */
            
            //Exercice 6
            Console.WriteLine("Entrez la chaine de charactere à compresser");
            string chaine = Convert.ToString(Console.ReadLine());
            char[] tab = ChiffreCompress(chaine);
            for (int i = 0; i < tab.Length; i++)
            {
                if(i%2==0)
                {
                    Console.Write(tab[i]);
                }
                else
                {
                    Console.WriteLine(" is present "+(int)tab[i]+" times");
                }
            }
            
            //Console.WriteLine("Entrez le charactere a convertir");
            /*EXO3
            char c = Convert.ToChar(Console.ReadLine());
            int ascii = ASCII(c);
            Console.Write(ascii);
            */
            /*
            string chaine = Convert.ToString(Console.ReadLine());
            char[] ascii2 = ASCIIORDRE(chaine);
            for (int i = 0; i < ascii2.Length; i++)
            {
                Console.Write(ascii2[i]);
            }
            */
            /*
            Exercice2
            Console.WriteLine("Entrez la liste de chiffre qui doit être vérifiée");
            string tabtest = Convert.ToString(Console.ReadLine());
            int[] tab = new int[tabtest.Length];
            for(int i=0; i < tabtest.Length; i++)
            {
                tab[i] = tabtest[i];
            }
            Console.WriteLine("Entrez le tableau dans lequelle la séquence va être cherchée");
            string tabtest2 = Convert.ToString(Console.ReadLine());
            int[] tab2 = new int[tabtest2.Length];
            for (int i = 0; i < tabtest2.Length; i++)
            {
                tab2[i] = tabtest2[i];
            }
            bool test = séquence(tab, tab2);
            if(test==true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */
            /*
            //Exercice1
            Console.WriteLine("Entrez un mot dont la premiere et dernière lettre seront permutées");
            string retournement = Convert.ToString(Console.ReadLine());
            char[] result = Retournement(retournement);
            Console.Write("Le résultat est : ");
            for(int i=0; i < result.Length; i++)
            {
                Console.Write(result[i]);
            }
            */
            Console.ReadKey();
        }
        static char[] Retournement(string retournement)
        {

            char[] recup = new char[retournement.Length];

            recup[0] = retournement[retournement.Length - 1];
            recup[recup.Length - 1] = retournement[0];
            for (int i = 1; i <= recup.Length - 2; i++)
            {
                recup[i] = retournement[i];
            }
            return recup;
        }
        static bool séquence(int[] séquence, int[] tab)
        {
            if (séquence.Length > tab.Length)
            {
                return false;
            }
            int cpt = 0;
            for (int i = 0; i < tab.Length; i++)
            {

                if (tab[i] != séquence[cpt])
                {
                    cpt = 0;
                }
                if (tab[i] == séquence[cpt])
                {
                    cpt++;
                    if (cpt == séquence.Length)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static int ASCII(char c)
        {
            int value = (int)c;

            return value;
        }
        static char[] ASCIIORDRE(string c)
        {
            int[] value = new int[c.Length];
            char[] valueCopie = new char[c.Length];
            string cCopie = c;
            int max = value[0];
            int cpt = 0;
            int cpttableau = 0;
            int j = 0;
            int[] value2 = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = ASCII(c[i]);
                valueCopie[i] = c[i];
            }
            for (int i = 0; j < value.Length; i++)
            {
                if (i == value.Length)
                {
                    i = 0;
                }
                if (max < value[i])
                {
                    max = value[i];
                    cpttableau = i;
                }
                cpt++;
                if (cpt == value.Length)
                {
                    cpt = 0;
                    valueCopie[j] = cCopie[cpttableau];
                    value[cpttableau] = 0;
                    j++;
                    max = 0;
                    i = 0;
                }
            }
            return valueCopie;
        }
        static char[] StringCompress(string c)
        {
            char lettre = c[0];
            int cpt = 1;
            int j = 0;
            
            int compteurtaille = 2;
            for(int i=0;i<c.Length;i++)
            {
                if (i<=c.Length-2&&c[i] != c[i+1])
                {
                    compteurtaille = compteurtaille + 2;
                }
            }
            char[] value = new char[compteurtaille];
            cpt = 1;
            for (int i = 0; i < c.Length; i++)
            {
                if (i <= c.Length - 2 && c[i] == c[i + 1])
                {
                    cpt++;
                }
                else if(i<c.Length-1)
                {
                    value[j] = lettre;
                    value[j + 1] = (char)cpt;
                    j +=2;
                    lettre = c[i + 1];
                    cpt = 1;
                }
                if (i < c.Length-1)
                {
                    value[value.Length - 2] = lettre;
                    value[value.Length - 1] = (char)cpt;
                }
            }
            return value;
        }
        static void Armstrong()
        {
            for (int i = 0; i <= 999; i++)
            {
                int a = 0, b = 0, c = 0;

                a = i / 100 - (i % 100 / 100); //les centaines
                c = i % 100;
                b = (c - (c % 10)) / 10; // les dizaines 
                c = c % 10; //les unités

                if (a * a * a + b * b * b + c * c * c == i)
                {
                    Console.WriteLine("The number " + i + " is Armstrong");
                }
            }
        }
        static char[] ChiffreCompress(string c)
        {
            char lettre = c[0];
            int cpt = 1;
            int j = 0;

            int compteurtaille = 2;
            for (int i = 0; i < c.Length; i++)
            {
                if (i <= c.Length - 2 && c[i] != c[i + 1])
                {
                    compteurtaille = compteurtaille + 2;
                }
            }
            char[] value = new char[compteurtaille];
            cpt = 1;
            for (int i = 0; i < c.Length; i++)
            {
                if (i <= c.Length - 2 && c[i] == c[i + 1])
                {
                    cpt++;
                }
                else if (i < c.Length - 1)
                {
                    value[j] = lettre;
                    value[j + 1] = (char)cpt;
                    j += 2;
                    lettre = c[i + 1];
                    cpt = 1;
                }
                if (i < c.Length - 1)
                {
                    value[value.Length - 2] = lettre;
                    value[value.Length - 1] = (char)cpt;
                }
            }
            return value;
        }
        static int factoriel(int c)
        {
            int chiffre = 1;
            for(int i=c;i>0;i--)
            {
                chiffre = chiffre * i;
            }
            return chiffre;
        }
        static int Espace(string c)
        {
            int cpt = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ' ')
                {
                    cpt++;
                }
            }
            return cpt;
        }
    }
}
