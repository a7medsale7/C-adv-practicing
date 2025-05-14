using polymerphism_prac;


internal class Program
{
    //1
    public static void DrawShape(Shape shape)
    {
        shape.Draw();
    }
    //2
    public static void sendmess(Notification notification)
    {
        notification.Send();
        notification.Log();
    }

    //3
    public static void display_info(BankAccount account)
    {
        Console.WriteLine($"Account {account.AccountNumber} - {account.AccountType} - Interest: {account.CalculateInterest()}");
    }

    //4

    public static void payInterest(PaymentMethod account)
    {
        Console.WriteLine($"--- Processing Payment with {account.type} ---");
        account.Pay();
        Console.WriteLine(); 
    }





    private static void Main(string[] args)
    {
        #region shape_prob1
        //Shape c = new Circle();
        //DrawShape(c);
        //Shape r = new Rectangle();
        //DrawShape(r);
        //Shape t = new Triangle();
        //DrawShape(t);
        ////chat additional solution
        //var shapes = new List<Shape> { new Circle(), new Rectangle(), new Triangle() };
        //foreach (var shape in shapes)
        //{
        //    DrawShape(shape);
        //} 
        #endregion

        #region notificatioin_prob2
        //Notification sms = new SMSNotification();
        //sms.Recipient = "1234567890";
        //sendmess(sms);
        //Notification email = new EmailNotification();
        //email.Recipient = " ahmed@example.com";
        //sendmess(email);
        //Notification push = new PushNotification();
        //push.Recipient = "DVC101";
        //sendmess(push);
        #endregion

        #region Bank_prob3
        //BankAccount account1 = new SavingsAccount();
        //account1.AccountNumber = "123456789";
        //account1.AccountType = "Savings";
        //account1.Balance = 1000;
        //display_info(account1);
        //Console.WriteLine($"Interest: {account1.CalculateInterest()}");
        //BankAccount account2 = new CurrentAccount();
        //account2.AccountNumber = "987654321";
        //account2.AccountType = "Current";
        //account2.Balance = 2000;
        //display_info(account2);
        //Console.WriteLine($"Interest: {account2.CalculateInterest()}");
        //BankAccount account3 = new FixedDepositAccount();
        //account3.AccountNumber = "456789123";
        //account3.AccountType = "Fixed Deposit";
        //account3.Balance = 5000;
        //display_info(account3);
        //Console.WriteLine($"Interest: {account3.CalculateInterest()}"); 
        #endregion

        #region pay_prob4
        PaymentMethod paymentMethod1 = new CreditCardPayment();
        paymentMethod1.type = "Credit Card";
        paymentMethod1.amount = 1000;
        paymentMethod1.cardNumber = "1234-5678-9012-3456";
        payInterest(paymentMethod1);
        //PaymentMethod paymentMethod2 = new PayPalPayment();
        //paymentMethod2.type = "Debit Card";
        //paymentMethod2.amount = 500;
        //paymentMethod2.Email = "ahmed@ex.com";
        //payInterest(paymentMethod2);
        //PaymentMethod paymentMethod3 = new CryptoPayment();
        //paymentMethod3.type = "Crypto";
        //paymentMethod3.amount = 2000;
        //paymentMethod3.walletAddress = "Bitcoin";
        //payInterest(paymentMethod3);
        #endregion




























    }
}

