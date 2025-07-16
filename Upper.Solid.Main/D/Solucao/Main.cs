using Upper.Solid.D.Solucao;

IRespirador pulmaoArtificial = new PulmaoArtificial();
var corpoRobo = new CorpoHumano(pulmaoArtificial);
corpoRobo.Viver();

IRespirador pulmao = new PulmaoArtificial();
var corpoHumano = new CorpoHumano(pulmao);
corpoHumano.Viver();

// Notamos aqui que não precisamos alterar código-fonte devido a dependências desnecessárias e, no fim,
// ainda cumprimos todos os princípios SOLID.