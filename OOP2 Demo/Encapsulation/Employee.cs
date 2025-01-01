using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Demo.Encapsulation
{
    internal struct Employee
    {
        //Encapsulation: Separetes data definations into setters and getters
        #region Attributes
        private int id;
        private string? name;
        private decimal salary;
        #endregion
        #region Getter & Setter
        //Applaying setters ad getters [Old Approach]
        //Getter
        public int GetId()
        {
            return id;
        }
        //Setter
        public int SetId(int val)
        {
            id = val;
        }
        #endregion

        #region Property
        // Applaying Encapsulation property [New Approach]

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        #endregion

        #region Constructor
        public Employee(int id, string? name, decimal salary)
        {
            this.id = id;
            this.name = name;  
            this.salary = salary;
        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"ID={this.id} \n Name={this.name} \n Salary={this.salary:c}";
        } 
        #endregion
    }
}
