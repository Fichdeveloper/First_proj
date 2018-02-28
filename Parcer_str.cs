using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polinom_C
{
    class Parcer_str
    {
        private List<string> bin_list = new List<string>();
        private List<int> function = new List<int>();
        private List<string> const_one = new List<string>();

        private string seg_bin;
        private int count;

        public Parcer_str(int count)
        {
            this.count = count;
        }

        public void Get_count_one(string m_line,string another_line)
        {
            int contain = 0;
            int fail_count = 0;
            for (int i=0;i<m_line.Length;i++)
            {
                    if (m_line[i]!=another_line[i])
                    {
                        contain = i;
                        fail_count++;
                    }
            }

                if (fail_count==1)
                {
                char[] replace_mass = m_line.ToCharArray();
                replace_mass[contain] = 'x';

                for (int i = 0; i < replace_mass.Count(); i++)
                {
                    Console.WriteLine(replace_mass[i]+"repla");
                }
                Console.WriteLine();
                }
            fail_count = 0;
            }
        
        public static string ReverseString(string s)
        {
            string copy = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                copy += s[i];
            }
            return copy;
        }

        public void Binary_mass()
        {
            for (int i=0;i<Math.Pow(count,2);i++)
            {
                int clon_i = i;
                for (int j = 0; j < count; j++)
                {
                    int result = clon_i % 2;
                    seg_bin += result.ToString();
                    clon_i /= 2;
                }
                
                bin_list.Add(ReverseString(seg_bin));
                seg_bin = "";
            }
        
            for (int i = 0; i < Math.Pow(count,2)-1; i++)
            {
                Console.WriteLine(i+"|"+bin_list[i]);
            }            
        }

        public void Add_Const_one()
        {
            for (int i = 0; i < Math.Pow(count, 2)-1; i++)
            {
                function.Add(Convert.ToInt32(Console.ReadLine()));
                if (function[i] == 1)
                {
                    const_one.Add(bin_list[i]);
                }
            }

            
        }

        public void Gluing_function()
        {
           
            for (int i = 0; i < const_one.Count; i++)
            {
                string a=const_one[i];
                for (int j = i+1; j < const_one.Count; j++)
                {
                    string b = const_one[j];
                    Get_count_one(a, b);
                }
            }


            for (int i = 0; i < const_one.Count; i++)
            {
                Console.WriteLine(i + "|" + const_one[i]);
            }
        }
    }
}
