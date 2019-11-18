using System;

namespace SoftwareDesignExam
{
    class Program
    {

        public static void main(String[] args)
        {
            BuyerUserFactory user = new BuyerUserFactory();

            Buyer buyer = null;



            buyer = user.MakeUser(buyer);

        }
       
    }
}
