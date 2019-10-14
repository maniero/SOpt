$sql = mysqli_query($conexao, "UPDATE cadastro set
                                nome_aluno = '$nome',
                                data_nascimento = '$dataNasc',
                                sexo = '$sexo', 
                                celular = '$numcel',
                                telefone = '$numtel',
                                endereco = '$endereco',
                                numero = '$numres',
                                uf = '$uf',
                                rg = '$rg',
                                prontuario = '$prontuario',
                                data_validade = '$datavalidade',
                                curso = '$curso',
                                semestre = '$semestre',
                                periodo = '$periodo',
                                email = '$email',
                                senha = '$senha'
                                where id = (SELECT MAX(id) FROM cadastro));

//https://pt.stackoverflow.com/q/90129/101
