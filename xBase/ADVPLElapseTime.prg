cTic := Time()
While .T.
    If VerifyOnServ(nTimeOut) != nil .or. ElapTime2Sec(ElapTime(cTic, Time())) <= nTimeOut
       Exit
    EndIf
EndDo

//https://pt.stackoverflow.com/q/352127/101
