using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace net.UyghurDev.Text
{
   /// <summary>
   /// ئۇيغۇرچە ئېلىپبە تەرتىپى بۇيىچە سورتلاش
   /// <para>تۈزگۈچى: ئەلى ئەركىن</para>
   /// <para>ئۇيغۇر يۇمشاق دېتال ئىجادىيەت تورى</para>
   /// </summary>
    public class Sort:IComparer
    {
        Dictionary<char, int> UyghurAlphabetTable;
        public Sort()
        {
            //ئېلىپبە تەرتىپى
            UyghurAlphabetTable = new Dictionary<char, int>();
            UyghurAlphabetTable.Add('ا', 1);
            UyghurAlphabetTable.Add('ە', 2);
            UyghurAlphabetTable.Add('ب', 3);
            UyghurAlphabetTable.Add('پ', 4);
            UyghurAlphabetTable.Add('ت', 5);
            UyghurAlphabetTable.Add('ج', 6);
            UyghurAlphabetTable.Add('چ', 7);
            UyghurAlphabetTable.Add('خ', 8);
            UyghurAlphabetTable.Add('د', 9);
            UyghurAlphabetTable.Add('ر', 10);
            UyghurAlphabetTable.Add('ز', 11);
            UyghurAlphabetTable.Add('ژ', 12);
            UyghurAlphabetTable.Add('س', 13);
            UyghurAlphabetTable.Add('ش', 14);
            UyghurAlphabetTable.Add('غ', 15);
            UyghurAlphabetTable.Add('ف', 16);
            UyghurAlphabetTable.Add('ق', 17);
            UyghurAlphabetTable.Add('ك', 18);
            UyghurAlphabetTable.Add('گ', 19);
            UyghurAlphabetTable.Add('ڭ', 20);
            UyghurAlphabetTable.Add('ل', 21);
            UyghurAlphabetTable.Add('م', 22);
            UyghurAlphabetTable.Add('ن', 23);
            UyghurAlphabetTable.Add('ھ', 24);
            UyghurAlphabetTable.Add('و', 25);
            UyghurAlphabetTable.Add('ۇ', 26);
            UyghurAlphabetTable.Add('ۆ', 27);
            UyghurAlphabetTable.Add('ۈ', 28);
            UyghurAlphabetTable.Add('ۋ', 29);
            UyghurAlphabetTable.Add('ې', 30);
            UyghurAlphabetTable.Add('ى', 31);
            UyghurAlphabetTable.Add('ي', 32);


        }
        
        /// <summary>
        /// سېلىشتۇرۇش
        /// </summary>
        /// <param name="objA">بىرىنچى سۆز</param>
        /// <param name="objB">ئىككىنچى سۆز</param>
        /// <returns>نەتىجە</returns>
         int IComparer.Compare(object objA, object objB)
        {

            return compareString((string)objA,(string)objB);
        }

        /// <summary>
        /// ئىككى سۆزنى سېلىشتۇرۇش
        /// </summary>
        /// <param name="strA">بىرىنچى سۆز</param>
        /// <param name="strB">ئىككىنچى سۆز</param>
        /// <returns>نەتىجە</returns>
         private int compareString(string strA, string strB)
         {
             strA = strA.Replace("ئ", "");
             strB = strB.Replace("ئ", "");
             int nMin = 0;
             int nAlength = strA.Length;
             int nBlength = strB.Length;
             if (nAlength < nBlength)
             {
                 nMin = nAlength;
             }
             else
             {
                 nMin = nBlength;
             }
             for (int i = 0; i < nMin; i++)
             {
                 char chrA = strA[i];
                 char chrB = strB[i];
                 //if (chrA == 1574 || chrB == 1574)
                 //{
                 //   i++;
                 //}
                 switch (this.compareChar(chrA, chrB))
                 {
                     case 1:
                         return 1;

                     case -1:
                         return -1;
                 }
             }
             if (nAlength < nBlength)
             {
                 return -1;
             }
             if (nAlength > nBlength)
             {
                 return 1;
             }
             return 0;
         }

        /// <summary>
        /// ئىككى ھەرىپنى سېلىشتۇرۇش
        /// </summary>
        /// <param name="chrA">بىرىنچى ھەرىپ</param>
        /// <param name="chrB">ئىككىنچى ھەرىپ</param>
        /// <returns>نەتىجە</returns>
         private int compareChar(char chrA, char chrB)
         {

             int nA = 0;
             int nB = 0;
             nA = this.getCharCode(chrA);
             nB = this.getCharCode(chrB);
             if (nA > nB)
             {
                 return 1;
             }
             else if (nA < nB)
             {
                 return -1;
             }
             else
             {
                 return 0;
             }
         }

        /// <summary>
        /// ھەرىپ كودىنى ئېلىش
        /// </summary>
        /// <param name="chr">ھەرىپ</param>
        /// <returns>كودى</returns>
         private int getCharCode(char chr)
         {
             if (UyghurAlphabetTable.ContainsKey(chr))
             {
                 return UyghurAlphabetTable[chr];
             }
             else
             {
                 return -1;
             }
         }
    }

    
}
