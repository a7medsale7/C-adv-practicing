🏁 Example 1: Shape Drawing System
Goal: Create an abstract class Shape with a method Draw(). Then implement Circle, Rectangle, and Triangle classes that override Draw().

👇 Instructions:
Create abstract class Shape with an abstract method Draw().

Each subclass prints its own draw message.

🧪 Expected Output:
csharp
Copy
Edit
Drawing a Circle
Drawing a Rectangle
Drawing a Triangle

===========================================================================================

Task 2: Advanced Notification System
🧠 Concept:
You have a system that sends notifications via different channels: Email, SMS, and Push.

📋 Requirements:
Create an abstract class Notification with:

Property: Recipient

Abstract method: Send()

Virtual method: Log() that logs the message

Subclasses: EmailNotification, SMSNotification, and PushNotification

Override Send() with their own logic

Override Log() (optional: call base.Log())

🧪 Example Output:
plaintext
Copy
Edit
Sending Email to ahmed@example.com
[LOG] Email sent to ahmed@example.com

Sending SMS to +201234567890
[LOG] SMS sent to +201234567890

Sending Push Notification to device ID: DVC101
[LOG] Push sent to DVC101

==================================================================================
🔥 Task 3: Bank Account System
🧠 Concept:
Different account types (e.g. SavingsAccount, CurrentAccount, FixedDeposit) calculate interest differently.

📋 Requirements:
Create abstract class BankAccount

Properties: Balance, AccountNumber

Abstract method: CalculateInterest()

Method: DisplayInfo() that prints account type and interest

Create subclasses and override interest logic

SavingsAccount: 4%

CurrentAccount: 2%

FixedDeposit: 8%

🧪 Example Output:
plaintext
Copy
Edit
Account 1001 - Savings - Interest: 400
Account 1002 - Current - Interest: 200
Account 1003 - FixedDeposit - Interest: 800

========================================================================

🔥 Task 4: Online Payment Gateway System
🧠 Concept:
Users can pay with different methods: CreditCard, PayPal, and Crypto.

📋 Requirements:
Abstract class: PaymentMethod

Properties: Amount, User

Abstract method: Pay()

Subclasses:

CreditCard: prints last 4 digits + charges 2%

PayPal: prints email + charges 3%

Crypto: prints wallet ID + charges 1.5%

🧪 Example Output:
plaintext
Copy
Edit
Paying 1020.00 with Credit Card (ending in 1234) [Fee: 20]
Paying 1030.00 with PayPal (ahmed@mail.com) [Fee: 30]
Paying 1015.00 with Crypto (wallet: abc123) [Fee: 15]
