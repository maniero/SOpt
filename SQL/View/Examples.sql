CREATE VIEW dbo.SeattleOnly
AS
SELECT p.LastName, p.FirstName, e.JobTitle, a.City, sp.StateProvinceCode
FROM HumanResources.Employee e
INNER JOIN Person.Person p
ON p.BusinessEntityID = e.BusinessEntityID
    INNER JOIN Person.BusinessEntityAddress bea 
    ON bea.BusinessEntityID = e.BusinessEntityID 
    INNER JOIN Person.Address a 
    ON a.AddressID = bea.AddressID
    INNER JOIN Person.StateProvince sp 
    ON sp.StateProvinceID = a.StateProvinceID
WHERE a.City = 'Seattle'

SELECT * FROM dbo.SeattleOnly WHERE LastName = 'Willians';

#Note que retornará 4 colunas. No fundo isto é o mesmo que escrever:

SELECT p.LastName, p.FirstName, e.JobTitle, a.City, sp.StateProvinceCode
FROM HumanResources.Employee e
INNER JOIN Person.Person p
ON p.BusinessEntityID = e.BusinessEntityID
    INNER JOIN Person.BusinessEntityAddress bea 
    ON bea.BusinessEntityID = e.BusinessEntityID 
    INNER JOIN Person.Address a 
    ON a.AddressID = bea.AddressID
    INNER JOIN Person.StateProvince sp 
    ON sp.StateProvinceID = a.StateProvinceID
WHERE a.City = 'Seattle' AND p.LastName = 'Willians'

#https://pt.stackoverflow.com/q/35413/101
