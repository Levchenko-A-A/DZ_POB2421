using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_4
{
    internal class MasIndex
    {
        private string[]? masString;
        public int lengMas {  get; set; }
        public int count { get; } = 20; 
        private bool errFlag;
        public MasIndex(int lenght)
        {
            this.lengMas = lenght;
            errFlag=false;
            masString = new string[lenght];
        }
        public string this[int index]
        {
            get 
            { 
                if(Ok(index))
                {
                    errFlag = false;
                    return masString[index];
                }
                else
                {
                    Console.WriteLine("Индекс введен не верно.");
                    errFlag = true;
                    return null;
                }
            }
            set
            {
                if (Ok(index))
                {
                    masString[index] = value;
                    errFlag = false;
                }
                errFlag = true;
            }
        }
        private bool Ok(int index)
        {
            if (index >= 0 && index < lengMas)
                return true;
            return false;
        }
        public void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < lengMas; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    masString[i] += random.Next(0, 10).ToString();
                    
                }
            }
        }
        public MasIndex Merge(MasIndex first, MasIndex second)
        {
            int tmpLenght=first.lengMas+second.lengMas;
            MasIndex tmp = new MasIndex(tmpLenght);
            if (first.lengMas == second.lengMas)
            {
                for (int i = 0; i < first.lengMas; i++)
                {
                    tmp[i] = first[i];
                    tmp[i+lengMas] = second[i];
                }
            }
            return tmp;
        }
        public MasIndex MasDistinc (MasIndex temp)
        {
            
            for(int i=0; i<temp.lengMas;i++)
            {
                string tmp = temp[i];
                char[] tmp1 = tmp.Distinct().ToArray();
                tmp = new string(tmp1);
                temp[i] = tmp;
            }
            return temp;
        }
    }
}
