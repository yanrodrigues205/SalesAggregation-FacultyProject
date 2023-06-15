using SalesAggregation_FacultyProject;

Pessoas p1 = new Pessoas();
p1.setCodigo(20);
p1.setNome("Yan");
p1.setSobrenome("Rodrigues");
p1.setIdade(18);
Pessoas p2 = new Pessoas();
p2.setCodigo(21);
p2.setNome("Yan");
p2.setSobrenome("ANdrade");
p2.setIdade(18);
List<Pessoas> pessoas_gerais = new List<Pessoas>();
pessoas_gerais.Add(p1);
pessoas_gerais.Add(p2);

Conta c1 = new Conta(1, "Santander", "Presidente Prudente - SP", pessoas_gerais);
c1.imprimir();
