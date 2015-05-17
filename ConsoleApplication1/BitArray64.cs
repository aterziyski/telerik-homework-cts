using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApplication1
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        private int[] GetNumberBits()
        {
            ulong number = this.Number;
            int[] bitsArray = new int[64];

            ulong varTmp = number;

            for (ulong i = 63; i >= 0; i--)
            {
                ulong bitPart = 2 ^ i;
                if (varTmp > bitPart)
                {
                    varTmp -= bitPart;
                    bitsArray[63 - i] = 1;
                }
            }

            return bitsArray;

        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bitsArray = this.GetNumberBits();

            for (int i = 0; i <= bitsArray.Length; i++)
            {
                yield return bitsArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Equals(BitArray64 varTmp)
        {
            if (ReferenceEquals (null, varTmp))
            {
                return false;
            }

            if (ReferenceEquals (this, varTmp))
            {
                return true;
            }

            return this.number == varTmp.number;
        }

        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;

            if (temp == null)
                return false;

            return this.Equals(temp);
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode();
        }

        public bool IsOutOfIndexBoundsBounds(int index)
        {
            if (index > 63 || index < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int this[int index]
        {
            get
            {
                if (IsOutOfIndexBoundsBounds(index))
                {
                    throw new IndexOutOfRangeException("The number is out of range");
                }
                else
                {
                    int[] bitsArray = this.GetNumberBits();
                    return bitsArray[index];
                }
            }
        }

        public static bool operator ==(BitArray64 value1, BitArray64 value2)
        {
            return BitArray64.Equals(value1, value2);
        }

        public static bool operator !=(BitArray64 value1, BitArray64 value2)
        {
            return !BitArray64.Equals(value1, value2);
        }

        public override string ToString()
        {
            return this.Number.ToString();
        }
    }
}
