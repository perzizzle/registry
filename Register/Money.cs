using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class Money
    {
        //cent representation of amount
        public int amount { get; set; }
        
        /*might be necessary in the future
        public const int hundred = 100 * 100;
        public const int twenty = 20 * 100;
        public const int ten = 10 * 100;
        public const int five = 5 * 100;
        public const int one = 1 * 100;

        public const int quarter = 25;
        public const int dime = 10;
        public const int nickel = 5;
        public const int penny = 1;*/

        public Money(int amount)
        {
            this.amount = amount;
        }

        public Money(string sAmount)
        {
            try
            {
                this.amount = int.Parse(sAmount);
            }
            catch (Exception ex){
                //never use ex
                Console.WriteLine("Cannot convert to int");
                throw;
            }
            
        }

        public Money(string sDollar, string sCent)
        {
            try
            {
                this.amount = int.Parse(sDollar)*100 + int.Parse(sCent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot convert to int");
                throw;
            }

        }

        public Money(int dollar, int cent)
        {
            this.amount = dollar * 100 + cent;
        }

        public Money(int hundred, int twenty, int ten, int five, int one, int quarter, int dime, int nickel, int penny)
        {
            this.amount = hundred*100 + twenty*100 + ten*100 + five*100 + one*100 + quarter + dime + nickel + penny;
        }

    }
}
