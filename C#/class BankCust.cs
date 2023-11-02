class BankCust
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public int Amount,withdrawl,deposite;
        public int balance = 1000;
        public void getdata(int AccountNo,string Name,int Amount)
        {
            this.AccountNo = AccountNo;
            this.Name = Name;
            deposite = balance + Amount;
            withdrawl = balance - Amount;
        }