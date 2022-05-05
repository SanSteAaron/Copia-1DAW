using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank_ASS;

namespace BankAccountTest_ASS
{
    [TestClass]
    public class BankAccountTest_ASS
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {     
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount_ASS account = new BankAccount_ASS("Mr. Bryan Walton", beginningBalance);
            account.Debit(debitAmount);
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Debit_WhenBankAccountIsFrezee_ShouldThrowException()
        {
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount_ASS account = new BankAccount_ASS("Mr. Bryan Walton", beginningBalance);
            account.FreezeAccount();
            account.Debit(debitAmount);
        }
        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount_ASS account = new BankAccount_ASS("Mr. Bryan Walton",beginningBalance);
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount_ASS.DebitAmountExceedsBalanceMessage);
            }
        }

        public void Debit_DebitAmountLessThanZeroMessage()
        {
            double beginningBalance = 11.99;
            double debitAmount = -1.99;
            BankAccount_ASS account = new BankAccount_ASS("Mr. Bryan Walton", beginningBalance);
            try
            {
                account.Debit(debitAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount_ASS.DebitAmountLessThanZeroMessage);
            }
        }

        public void Credit_CreditAmountLessThanZeroMessage()
        {
            double beginningBalance = 11.99;
            double creditAmount = -1.99;
            BankAccount_ASS account = new BankAccount_ASS("Mr. Bryan Walton", beginningBalance);
            try
            {
                account.Credit(creditAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount_ASS.CreditAmountLessThanZeroMessage);
            }
        }
    }
}
