using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_2_4
{
    class Morse_matrix : String_matrix, IMorse_crypt
    {
        public const int Size_2 = Alphabet.Size;
        private int offset_key = 0;



        public Morse_matrix(int offset = 0)
        {
            if (((offset >= 0) & (offset < Alphabet.Size)) == true)
                offset_key = offset;
            else Console.WriteLine("Morse_matrix. Offset errr, initialization by default");

            fd(Alphabet.Dictionary_arr);
            sd();
        }

        public Morse_matrix(string[,] Dict_arr, int offset = 0)
        {
            if (((offset >= 0) & (offset < Alphabet.Size)) == true)
                offset_key = offset;
            else Console.WriteLine("Morse_matrix. Offset errr, initialization by default");

            if (Dict_arr == null)
                Dict_arr = Alphabet.Dictionary_arr;

            fd(Dict_arr);
            sd();
        }

        private void fd(string[,] Dict_arr)
        {
            for (int ii = 0; ii < Size1; ii++)
                for (int jj = 0; jj < Size_2; jj++)
                    this[ii, jj] = Dict_arr[ii, jj];
        }


        private void sd()
        {
            int off = Size_2 - offset_key;
            for (int jj = 0; jj < off; jj++)
                this[1, jj] = this[1, jj + offset_key];
            for (int jj = off; jj < Size_2; jj++)
                this[1, jj] = this[1, jj - off];
        }

        public static Morse_matrix operator +(Morse_matrix tbl1, Morse_matrix tbl2)
        {
            Morse_matrix res_str_matrix = new Morse_matrix();
            for (int i = 0; i < Size1; i++)
                for (int j = 0; j < Size_2; j++)
                    res_str_matrix[i, j] = tbl1[i, j] + tbl2[i, j];
            return res_str_matrix;
        }

        public string crypt(string word)
        {
            string str_rslt = null;
            foreach (char c in word.ToCharArray())
            {
                string rslt = "";
                for (int i = 0; i < Size_2; i++)
                {
                    if (this[0, i] == c.ToString())
                    {
                        rslt = this[1, i];
                        //rslt = rslt.Trim();
                        str_rslt = str_rslt + rslt;
                    }
                }
            }
            return str_rslt;
        }

        public string decrypt(string[] signal)
        {
            string str_rslt = null;
            foreach (string c in signal)
            {
                string rslt = "";
                for (int i = 0; i < Size2; i++)
                {
                    if (this[1, i].Trim() == c.Trim())
                    {
                        rslt = this[0, i];
                        str_rslt = str_rslt + rslt;
                    }
                }
            }
            return str_rslt;
        }

        public void Res_beep(string rslt)
        {
            foreach (char c2 in rslt.ToCharArray())
            {
                if (c2 == '.')
                    Console.Beep(1000, 250);
                else if (c2 == '-')
                {
                    Console.Beep(1000, 750);
                }

            }
            System.Threading.Thread.Sleep(50);
        }
    }
}
