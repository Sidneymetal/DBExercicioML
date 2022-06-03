CREATE TABLE "Usuarios" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "email" varchar(256),
  "cpf" char(14),
  "data_Nascimento" date,
  "senha" varchar(30)
);

CREATE TABLE "Produtos" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "descricao" varchar,
  "valor" decimal,
  "data_Cadastro" timestamp,
  "id_Vendedor" int
);

CREATE TABLE "Vendedores" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "email" varchar(256),
  "cnpj" char(18),
  "data_Cadastro" timestamp
);

CREATE TABLE "Transportadores" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "telefone" varchar(14),
  "email" varchar(256)
);

CREATE TABLE "Pedidos" (
  "id" int PRIMARY KEY,
  "data_Pedido" timestamp,
  "status" varchar(30),
  "id_Transportadora" int,
  "id_Usuario" int
);

CREATE TABLE "ProdutosXPedidos" (
  "id" int PRIMARY KEY,
  "id_Produto" int,
  "id_Pedido" int
);

ALTER TABLE "Produtos" ADD FOREIGN KEY ("id_Vendedor") REFERENCES "Vendedores" ("id");

ALTER TABLE "ProdutosXPedidos" ADD FOREIGN KEY ("id_Pedido") REFERENCES "Pedidos" ("id");

ALTER TABLE "ProdutosXPedidos" ADD FOREIGN KEY ("id_Produto") REFERENCES "Produtos" ("id");

ALTER TABLE "Pedidos" ADD FOREIGN KEY ("id_Transportadora") REFERENCES "Transportadores" ("id");

ALTER TABLE "Pedidos" ADD FOREIGN KEY ("id_Usuario") REFERENCES "Usuarios" ("id");
