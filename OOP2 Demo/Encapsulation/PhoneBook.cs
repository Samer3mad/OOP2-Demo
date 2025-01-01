using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Demo.Encapsulation
{
    internal struct PhoneBook
    {
        #region Fields
        private string[] names;
        private ulong[] nums;
        private int size;
        #endregion
        //Getter
        public long GetPersonNumber(string name)
        {
            for (int i = 0; i < size; i++)
                if (name == names[i]
                    return (long)nums[i];
            return -1;
        }

        //Setter
        public void SetNumber(string name, ulong val)
        {
            for (int i = 0; i < size; i++)
                if (name == names[i]) {
                    nums[i] = val;
                    return;
                }
        }

        #region Property
        public int Size
        {
            get { return size; }

        } 
        #endregion

        #region Constructor
        public PhoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            nums = new string[size];
        }
        #endregion

        #region Methods
        public void AddPerson(uint pos, string name, ulong num)
        {
            if (names is not null && nums is not null && pos < size)
            {
                names[pos] = name;
                nums[pos] = num;
            }
        } 
        #endregion

    }
}
