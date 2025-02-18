# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Não tenho conhecimento sobre os Twelve-Factor.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Depende da arquitetura escolhida, mas geralmente as camidas ficam divididas em:
Presentation/UI: Camada em que a aplicação vai demonstrar alguma informação, podendo ser renderizando html ou servindos dados através de uma API.
Application/Services: Camada aonde casos de uso representado o negócio fica. Ex: Criação de usuário
Core/Domain: Camada aonde fica concentrada regras que são utilizadas por toda a aplicação, como entidades de banco de dados, extensions, DTOs.
Infrastructure: Camada que faz acesso a serviços externos, como DBs, mensageria, comunicação entre APIs.
Tests: Camada aonde fica os testes automatizados da aplicação.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
Não tenho familiaridade com SOA, mas sei que é uma arquitetura distribuida que compartilha recursos entre aplicações, enquanto microserviços são isolados e não compartilham recursos.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Não tenho conhecimento de API Management, mas sei que gerencia recursos.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Não é possivel alterar uma propriedade de um struct sem criar um novo objeto na memoria, classe é possivel

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
A versão do .NET antes do 5, era apenas para windows, a partir do .NET Core se tornou multiplataforma.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
Ambos defidem padrões para uma API, REST utilizando JSON/XML, e GRPc utiliza um formato semelhante a binario.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
As rotas são gerenciadas através da URL.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
Geralmente trabalho com um time de DevOps e só preciso me preocupar com o código, mas DevOps faz a ponte entre código e infra, fornencendo os recursos necessários para a aplicação estar no ar, com monitoramento e resiliencia.

10. Explique sobre um método agile.

**Resposta:**
O metodo agile, surgiu com boas praticas, para entregar com velocidade e ao mesmo tempo se adaptar as mudanças, geralmente é feito em forma de sprints de 2 semanas, em que é planejado todo o entregavel possivel naquele tempo, se adaptando caso surja algum impedimento e definindo prioridades, geralmente acompanhado de um quadro com kanbam.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI e CD, são etapas para entregar a aplicação com segurança, desde o versionamento do código até passar por uma automação para a publicação, aonde são realizados testes, de linter, build e automatizados(unitarios, integração) 


12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker é a ferramente que orquestra containers, Containers são recursos isolados que possuem todas as dependencias necessárias.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Só conheço o kubernetes, que faz o gerenciamento de containers docker, controla número de pods, especifica horário de cronjobs.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Vantagens: Facilidade de integração, reutilização.
Desvantagem: segurança.
Preocupação com segurança(autenticação e autorização, CORS, rate limit), latencia.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Autenticação e autorização, CORS, logs, monitoramento(latencia, requisições 5XX), rate limit.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
A comunicação de mensageria é assincrona, é usada em cenários em que a resposta não precisa ser imediata e as etapas para a ação serão concluidas após um tempo.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Não tenho familiaridade com SAGA.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Nunca cheguei a configurar uma comunicação entre um sistema de versionamento e kubernetes, mas já cheguei a configurar o github actions com um EC2, usando docker.
Mas após a configuração a cada alteração em determinada branch, é feito o processo de build da aplicação e a publicação da mesma.