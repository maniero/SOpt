SqlDataSource1.InsertCommand = @"insert into Pessoa values (@Nome, @CPF, @Classe); 
insert into Prestador_Servico values (SCOPE_IDENTITY(), 123, ...);";

//https://pt.stackoverflow.com/q/259176/101
