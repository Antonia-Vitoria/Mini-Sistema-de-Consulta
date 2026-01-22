create database projetoclientes;
GO

create table clientes ( id int primary key, nome varchar(50), email varchar(50));
GO

insert into clientes values (1, 'Ana', 'ana@comercial.edu.br');
insert into clientes values (2, 'Benja', 'benja@comercial.edu.br');
insert into clientes values (3, 'Cesar', 'cezar@comercial.edu.br');
select * from clientes;
