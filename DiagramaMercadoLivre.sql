CREATE TABLE "mlt_usuarios" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "email" varchar(256),
  "cpf" char(14),
  "data_nascimento" date,
  "senha" varchar(30)
);

CREATE TABLE "mlt_produtos" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "descricao" varchar,
  "valor" decimal,
  "data_cadastro" timestamp,
  "id_vendedor" int
);

CREATE TABLE "mlt_vendedores" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "email" varchar(256),
  "cnpj" char(18),
  "data_cadastro" timestamp
);

CREATE TABLE "mlt_transportadores" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "telefone" varchar(14),
  "email" varchar(256)
);

CREATE TABLE "mlt_pedidos" (
  "id" int PRIMARY KEY,
  "data_Pedido" timestamp,
  "status" varchar(30),
  "id_transportadora" int,
  "id_usuario" int
);

CREATE TABLE "mlt_produtosXpedidos" (
  "id" int PRIMARY KEY,
  "id_produto" int,
  "id_pedido" int
);

ALTER TABLE "mlt_produtos" ADD FOREIGN KEY ("id_vendedor") REFERENCES "mlt_vendedores" ("id");

ALTER TABLE "mlt_produtosXpedidos" ADD FOREIGN KEY ("id_pedido") REFERENCES "mlt_pedidos" ("id");

ALTER TABLE "mlt_produtosXpedidos" ADD FOREIGN KEY ("id_produto") REFERENCES "mlt_produtos" ("id");

ALTER TABLE "mlt_pedidos" ADD FOREIGN KEY ("id_transportadora") REFERENCES "mlt_transportadores" ("id");

ALTER TABLE "mlt_pedidos" ADD FOREIGN KEY ("id_usuario") REFERENCES "mlt_usuarios" ("id");
