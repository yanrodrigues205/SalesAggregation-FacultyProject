using SalesAggregation_FacultyProject;

Produtos p1 = new Produtos();
p1.setCodigo(1);
p1.setNome("Sabonete");
p1.setDecricao("Sabonete muito bom");
p1.setValor(2);
p1.setQuantidade(3);

int total_p1 = p1.getValor() * p1.getQuantidade();
int total_p2 = 0;
int total_geral = total_p1 = total_p2;
List<Produtos> produtos_comprados = new List<Produtos>();
produtos_comprados.Add(p1);
Venda v = new Venda(1, "15/06/2023", 90, produtos_comprados);
v.nota_fiscal();




