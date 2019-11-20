SELECT TOP 1 * 
         FROM BusinessCadTabPreco
         RIGHT JOIN BusinessCadTabPrecoItem ON BusinessCadTabPreco.CdTabela = BusinessCadTabPrecoItem.CdTabela
         WHERE  BusinessCadTabPreco.CdEmpresa =01
         AND CdProduto =".$row['CdProduto']."
         ORDER BY  BusinessCadTabPreco.DtSincronizar DESC
         
--https://pt.stackoverflow.com/q/108502/101
