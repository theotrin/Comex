CREATE TABLE clientes
(
id SERIAL PRIMARY KEY,
nome TEXT,
email TEXT,
data_nascimento DATE,
cidade TEXT
);

SELECT * FROM clientes;

INSERT INTO clientes (nome,email,data_nascimento,cidade)
VALUES(
'Theo',
'theo@email.com',
'2000-01-01',
'Itacoatiara'
);

CREATE TABLE pedidos(
	pedido_id SERIAL PRIMARY KEY,
	data_pedido DATE,
	valor_total DECIMAL,
	cliente_id INTEGER,

	FOREIGN KEY (cliente_id)
	REFERENCES clientes (id)
	ON DELETE CASCADE
);

INSERT INTO clientes (nome, email, data_nascimento, cidade) VALUES
('João da Silva', 'joao.silva@example.com', '1985-02-15', 'São Paulo'),
('Maria Oliveira', 'maria.oliveira@example.com', '1990-06-22', 'Rio de Janeiro'),
('Carlos Santos', 'carlos.santos@example.com', '1988-11-10', 'Belo Horizonte');

INSERT INTO pedidos (data_pedido, valor_total, cliente_id) VALUES
('2024-01-15', 150.00, 1),
('2024-02-20', 200.50, 2),
('2024-03-10', 99.99, 1),
('2024-04-05', 250.00, 3);

SELECT * FROM clientes;
SELECT * FROM pedidos;

SELECT nome,email FROM clientes;

UPDATE clientes SET email = 'theo@gmail.com' WHERE nome = 'Theo';

UPDATE pedidos SET valor_total = 190.00 WHERE valor_total > 190.00;

DELETE  FROM pedidos WHERE pedido_id = 1;

--Filtre os Seus Registros com WHERE
SELECT * FROM clientes WHERE cidade LIKE 'Rio de Janeiro';

SELECT * FROM pedidos WHERE valor_total > 60;

--Ordene os Seus Dados com o ORDER BY
SELECT * FROM clientes ORDER BY nome;

SELECT * FROM pedidos ORDER BY valor_total DESC;

--Junte Registros de Tabelas com JOIN
SELECT nome, pedidos.valor_total FROM clientes
INNER JOIN pedidos ON clientes.id = pedidos.cliente_id;

SELECT clientes.nome, id FROM pedidos 
LEFT JOIN clientes ON clientes.id = pedidos.cliente_id;