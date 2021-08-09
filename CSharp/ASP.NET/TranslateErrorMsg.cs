Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

<system.web>
   <globalization responseEncoding="UTF-8"
                  requestEncoding="UTF-8"
                  culture="pt-BR"
                  uiCulture ="pt-BR"
                  enableClientBasedCulture="true" />
   .....
</system.web>

[DataType(DataType.Date, ErrorMessage = "O campo \"Data\" deve ser uma data")]

//https://pt.stackoverflow.com/q/313745/101
