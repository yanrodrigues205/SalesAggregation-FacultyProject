using SalesAggregation_FacultyProject;
int codigo = 500;

Produtos p1 = new Produtos();
p1.setCodigo(codigo++);
p1.setNome("Sabonete");
p1.setDecricao("Sabonete muito bom");
p1.setValor(2);
p1.setQuantidade(3);

Produtos p2 = new Produtos();
p2.setCodigo(codigo++);
p2.setNome("Desodorente");
p2.setDecricao("Desodorente protege 56 horas");
p2.setValor(15);
p2.setQuantidade(2); 

int total_p1 = p1.getValor() * p1.getQuantidade();
int total_p2 = p2.getValor() * p2.getQuantidade();
int total_geral = total_p1 + total_p2;
List<Produtos> produtos_comprados = new List<Produtos>();
produtos_comprados.Add(p1);
produtos_comprados.Add(p2);
Venda v = new Venda(1, "15/06/2023", total_geral, produtos_comprados);
v.nota_fiscal();




