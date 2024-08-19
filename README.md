# Para Üstü Uygulaması

This is a C# console application developed as a homework project for Balıkesir University. The program simulates an ATM machine, allowing users to withdraw specific amounts of money using available denominations.

## How It Works

1. **ATM Setup:**  
   The application first asks the user to load the ATM with cash in denominations of 200, 100, 50, 20, 10, 5, and 1 TL. The user is prompted to input the number of notes or coins for each denomination.

2. **Money Withdrawal:**
   - The user is then asked to enter the amount of money they wish to withdraw.
   - The application calculates and dispenses the money using the available denominations.
   - If the requested amount exceeds the total cash available in the ATM, the user is notified, and the transaction is canceled.
   - The user is given the option to either make another withdrawal or exit the application.

3. **Denomination Availability Check:**
   - During the withdrawal process, if there aren't enough notes in a particular denomination to fulfill the request, the transaction is canceled and the user is notified of the shortfall.

## Features

- Handles all common denominations of Turkish Lira.
- Validates user input for correct and realistic scenarios.
- Displays detailed information about the transaction, including the number of notes dispensed.
- Provides the option to withdraw more money or exit the program after each transaction.

## Usage

1. Run the program.
2. Load the ATM with cash by entering the quantity for each denomination.
3. Enter the amount you wish to withdraw.
4. Follow the on-screen instructions to complete or cancel the transaction.

## Example

Here's an example of a session:

```
Para Uygulaması'na hoş geldin! Uygulamaya başlamadan önce ATM'ye günlük nakit koymamız gerekiyor.
200,100,50,20,10,5 ve 1 TL'lik banknot/madeni paraların yerleştirilmesi gerekiyor.
ATM'ye yerleştirilecek 200 TL'nin adetini giriniz: 10
...
Lütfen çekmek istediğiniz tutarı giriniz.
Paranız 1TL'lik bozuk para ve 5TL, 10TL, 20TL, 50TL, 100TL, 200TL'lik banknotlarla teslim edilecektir: 360
Bankadan çekmek istediğiniz tutar: 360 TL.
Çekme işlemi tamamlandı. Paranız;
1 adet 200 TL,
1 adet 100 TL,
1 adet 50 TL,
1 adet 10 TL,
şeklinde teslim edilmiştir. Kartınızı geri almayı unutmayın.
```

## Notes

- Make sure the total amount you wish to withdraw does not exceed the amount available in the ATM.
- The application only accepts positive integers as input for withdrawal amounts.
