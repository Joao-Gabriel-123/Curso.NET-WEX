--Comando INNER JOIN, relaciona tabelas pegando todos os valores de ambas as tabelas

--Juntando a tabela enderecos com a tabela clientes
SELECT *
FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4

--Juntando a tabela enderecos com a tabela clientes, mas selecionando dados específicos
SELECT 
    Clientes.Nome,
    Clientes.Sobrenome,
    Clientes.Email,
    Enderecos.Rua,
    Enderecos.Bairro,
    Enderecos.Cidade,
    Enderecos.Estado
FROM Clientes
INNER JOIN Enderecos ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4