# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
- Codebase - Cada aplicação deve ter o próprio código fonte, deve haver uma única versão de código que é usada em todos os ambientes.
- Dependencies - A aplicação deve declarar todas as suas dependências explicitamente.
- Config - Configurações de ambiente devem ser separadas do código, estando disponíveis nos ambientes.
- Baking Services - Serviço que a aplicação depende, no entanto, a aplicação deve estar pronta para substituí-lo se necessário.
- Port Binding - As portas que são utilizadas na aplicação devem ser configuraveis a cada ambiente.
- Build, Release, Run - Separação das fases da aplicação em build, release e run. O Build cria o pacote executável, Release adiciona configurações de ambiente e Run é o momento em que aplicação é executada. 

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
As camadas no desenvolvimento de software variam de acordo com o padrão estrutural que está sendo usado. As camadas mais comuns são:
- Camada de Apresentação
- Camada de Negócio
- Camada de Dados
- Camada de Serviço
- Camada de Infraestrutura

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
- SOA possui serviços maiores, integrados e reutilizáveis podendo ter várias funcionalidades.
- Microserviço possui serviços menores, independentes e são mais escaláveis.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O API Management tem objetivo de centralizar, gerenciar e monitorar APIs na arquitetura de serviços distribuídos. Entre as vantagens estão:
- Segurança
- Desempenho
- Escalabilidade

As desvantagens:
- Custos
- Complexibilidade
- Falha no API Management pode afetar todas as APIs

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
- Struct é um tipo de valor, armazenada na stack, não pode ser herdada
- Class é um tipo de referência, armazenada na heap, pode ser herdada 

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.Net Core é multiplataforma enquanto .Net funciona apenas no Windows.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
<br><b>REST:</b>

- Protocolo HTTP
- JSON e XML
- Síncrono

<b>GRPC:</b>
- Protocolo HTTP/2, 
- Protobuf
- Síncrono e assíncrono

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O conteúdo da página é atualizado dinamicamente e as rotas são previamente definidas.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é a junção de desenvolvimento e infraestrutura que tem como objetivo automatizar e agilizar os processos de entrega de software. Dentre esses processos estão o de integração contínua, entrega contínua, monitoramento e orquestração de containers.


10. Explique sobre um método agile.

**Resposta:**
<p>SCRUM é um método agile utilizado no gerenciamento de projetos, atuando de forma interativa e incremental.</p>
<p>No SCRUM há papéis que são representados por Product Owner, Scrum Master e a equipe de desenvolvimento.</p>
<p>O Product Backlog trata-se de todas as atividades que precisam ser realizadas no produto, são organizadas pelo Product Owner e entregue ao time de desenvolvimento.</p>
<p>Alguns eventos são realizados durante o ciclo de desenvolvimento, entre eles a Sprint Planning, Daily, Sprint Review e Sprint Retrospective. Os eventos são organizados pelo SCRUM Master</p>
<p>Durante a Sprint Planning é definido o Sprint Backlog, que são os itens que serão entregues durante a Sprint. Na Sprint Review são apresentados os itens PO e stakeholders.</p>
<p>A Sprint é o ciclo de desenvolvimento e dura de 1 a 4 semanas, no fim desse ciclo é feita a Sprint Retrospective que é utilizada para analisar a Sprint como um todo.</p>
<p>Todos os dias da Sprint é feita a Daily onde os membros da equipe dizem o que fizeram, o que estão fazendo e se há algum impedimento.</p>



11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (continuous integration) e CD (continuous delivery) tem como objetivo melhorar a qualidade e a velocidade das entregas de aplicações.
- CI - Integração do código desenvolvido por vários membros da equipe em um repositório, sendo atualizado diversas vezes no dia de forma automatizada.
- CD - Tem como objetivo deixar o código pronto para produção, sendo o código atualizado com frequência e automático.
<p>Ferramentas comuns que são utilizadas são: Azure DevOps e Jenkins</p>

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker é a ferramenta que cria e gerencia containers. Já os containers são ambientes em que as aplicações rodam de forma isolada e onde são empacotadas todas as dependências da aplicação.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

- Kubernetes - É opens ource, possui mais flexibilidade e configurações mais complexas.
- OpenShift - Possuí suporte, é utilizado como base o Kubernetes, interface mais simples


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
<br><b>Vantagens:</b>
- Facilidade de integração
- Escalabilidade
- Performance
- Reusabilidade

<b>Desvantagens:</b>
- Segurança
- Complexibilidade
- Manutenção
- Latência

As preocupações que devemos ter são: segurança, documentação, latência e gerenciamento.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Algumas práticas podem ser utilizadas como:
- Autenticação e autorização
- Criptografia
- Validações na entrada de dados
- Usuários devem ter apenas o acesso necessário
- Limite de requisições
- Logs
- Monitoramento
- Uso de CORS
- Testes de segurança


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Uma arquitetura de mensagerias serve para que os sistemas se comuniquem de forma mais eficiente, flexível e escalável.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
A SAGA permite que os microserviços continuem funcionando de forma confiável, mesmo com falhas.

SAGA é uma forma de gerenciar transações distribuídas, dividindo uma transação em várias sub-transações. Se uma falhar, ações de compensação são feitas para reverter as anteriores e manter a consistência.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma metodologia que utiliza o Git como a única fonte de verdade para gerenciar configurações de infraestrutura e aplicações. Utilizando Kubernetes, poderá
armazenar todos os arquivos de configuração YAML em um repositório Git. 

Ferramentas como ArgoCD e Flux monitoram esse repositório. Ao detectar alterações, aplicam automaticamente as mudanças no cluster do Kubernetes.

Como vantagens está o rastreamento já que todo o histórico fica no git e a aplicação automática das alterações acelerando o processo de deploy.