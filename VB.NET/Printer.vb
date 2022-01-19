qry = "SELECT * FROM Win32_PrinterDriver"
For Each driver In objWMIService.ExecQuery(qry)
    If driver.Name = "..." Then driver.Delete_
Next

'https://pt.stackoverflow.com/q/40450/101
