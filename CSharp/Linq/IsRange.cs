x => String.Compare(x.CEPInicial, "03500-000") >= 0 && String.Compare(x.CEPFinal, "04000-000") <= 0

x => x.CEPInicial.CompareTo("03500-000") >= 0 && x.CEPFinal.CompareTo("04000-000") <= 0

//https://pt.stackoverflow.com/q/363738/101
