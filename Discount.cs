using System 
public class Discount 
{
    public static void main( string[] args )
    {
        float amount, discount ,amountToBePaid;
        Console.write("your total shopping amount is here");
        amount=float.Parse(Console.ReadLine());
        if(amount<=100)
        {
            Console.write("tou have paid:Rs.%0.2f",amount);
        }
        else
        {
            if(amount>100 && amount<=200)
            {
                discount = (amount*5)/100;
                amountToBePaid = amount -discount;
                Console.write("After applying the discount, you have to pay:Rs.%0.2f",amountToBePaid);
            }
            else
            {
                discount = (amount*25)/100;
                amountToBePaid = amount-discount;
                Console.write("After applying the discount,you have to pay:Rs.%0.2f",amountToBePaid );
            }
        }
        
    }
}