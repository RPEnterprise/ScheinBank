using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using ScheinyNickelBank.DataAccess;
using ScheinyNickelBank.Interface;
namespace ScheinyNickelBank.Business
{
    public class TransactionBL: ITransaction
    {

        private Int32 transaction_id; 
        private String transaction_amount; 
        private String transaction_type; 
        private String account_number;

        public DataSet GetAllTransactions(string accountnumber)
        {
            TransactionDA tda = new TransactionDA();
            return tda.GetAllTransactions(accountnumber);

        }

        public void InsertTransaction(string accountnumber, string amount, int transtype)
        {
            TransactionDA tda = new TransactionDA();
            tda.InsertTransaction(accountnumber, amount, transtype);
        }

        public Int32 TransactionID {

            get { return transaction_id; }
            set { transaction_id = value; } 
        }
        public String TransactionAmount {

            get { return transaction_amount; }
            set { transaction_amount = value; } 
        }
        public String TransactionType {

            get { return transaction_type; }
            set { transaction_type = value; } 
        }
        public String AccountNumber {

            get { return account_number; }
            set { account_number = value; }
        }


    }
}
