public decimal GetCustomerBalance(long accountCurrentAdvisorId) {
    return this.Table.Where(x => x.AccountCurrentAdvisorId == accountCurrentAdvisorId)
                     .Select(x => x.CustomerBalance).First();
}

//https://pt.stackoverflow.com/q/57956/101
