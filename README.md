# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

1- Codebase: a aplicação não pode ter mais de uma codebase. Ela deve ser representada em um ou mais repositórios (contanto que os repositórios compartilhem um commit inicial). Uma codebase pode ter mais de um deploy rodando (exemplo: dev, qa, homologação, produção), e mesmo que cada deploy rode a sua própria versão do repositório, contanto que esse repositório seja um fork, ele irá contar como um deploy separado da mesma codebase.

2- Dependencies: todas as dependências externas da aplicação devem ser declaradas explicitamente no projeto. Em vez de depender de pacotes instalados globalmente no ambiente do sistema, a aplicação precisa isolar e gerenciar as dependências diretamente, geralmente usando arquivos específicos, como package.json para Node.js, pom.xml para Java ou requirements.txt para Python. Isso permite que o aplicativo seja executado de forma confiável em diferentes ambientes, garantindo que a mesma versão de cada dependência seja usada em todos os deploys.

3- Config: configurações que variam entre os ambientes (como credenciais de acesso, URLs de bancos de dados, variáveis de modo de operação) devem ser separadas do código-fonte da aplicação e gerenciadas via variáveis de ambiente. Dessa forma, o código permanece genérico e reutilizável, enquanto as configurações específicas de cada ambiente (dev, qa, produção) são ajustadas dinamicamente, conforme necessário. Isso também reduz o risco de informações sensíveis serem expostas ou versionadas acidentalmente no repositório.

4- Backing Services: qualquer serviço que a aplicação consuma como uma "dependência externa" (seja ele um banco de dados, sistema de cache, ou fila de mensagens) deve ser tratado como um recurso acoplável, ou seja, pode ser adicionado e substituído facilmente sem alterar o código. Isso significa que a aplicação deve interagir com serviços de apoio de forma modular, sem se amarrar a um recurso específico. Esse tipo de abordagem facilita mudanças rápidas nos recursos utilizados pela aplicação, permitindo que, por exemplo, um banco de dados MySQL local possa ser trocado por um banco gerenciado em nuvem sem complicações.

5- Build, Release, Run: o processo de desenvolvimento e implantação deve ser dividido em três etapas bem definidas:

- Build: fase onde o código é transformado em um executável, sendo compilado ou "empacotado" junto com suas dependências;
- Release: combinação do build com a configuração do ambiente para gerar uma versão específica da aplicação pronta para produção;
- Run: a execução da aplicação em produção, que utiliza uma versão específica da release. Esse fluxo de três etapas permite maior controle e previsibilidade, pois cada etapa é independente e isolada das demais, facilitando a replicação de versões específicas entre diferentes ambientes.

6- Processes: a aplicação deve ser projetada para ser executada como um conjunto de processos isolados e sem estado, o que significa que dados temporários, sessões e cache não devem ser armazenados localmente nos processos da aplicação. Ao invés disso, toda informação necessária para o estado da aplicação deve estar em serviços externos, como bancos de dados ou caches distribuídos. Isso permite que a aplicação seja escalável horizontalmente, pois qualquer instância pode atender a qualquer solicitação, promovendo resiliência e disponibilidade.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

- Apresentação:
  - Responsável pela interação do usuário final com o sistema;
  - Inclui front-ends de sistemas web, aplicativos mobile, aplicações embarcadas para terminais específicos (exemplo: um totem de atendimento para cancelas), etc.;
- Domínio:
  - É a camada que representa, em código, os casos de uso descritos na documentação do software;
  - Também incluem as Entidades, que são as classes representando os objetos tratados na regra de negócio;
- Dados:
  - Inclui todos os componentes necessários para realizar a persistência dos dados da aplicação, seus sub componentes são:
    - Data source: uma classe que representa a fonte de dados, essa classe é responsável pelo gerenciamento bruto da persistência de dados (exemplo: DbContext, do Entity Framework);
    - Models: representação dos modelos de dados do sistema, definindo as estruturas das entidades que serão persistidas. Em frameworks como o Entity Framework, eles são mapeados diretamente para tabelas do banco de dados;
    - Repositories: são abstrações das Data Sources que oferecem métodos para a manipulação e consulta de dados, interagindo com um ou mais Data Sources no processo;

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

- **Arquitetura SOA (Service-Oriented Architecture)**:
  SOA organiza a aplicação em serviços grandes e autônomos, onde cada serviço oferece uma funcionalidade específica e pode ser reutilizado em diferentes partes do sistema. A comunicação entre os serviços é geralmente centralizada em um barramento (ESB - Enterprise Service Bus), que facilita a integração e coordenação dos serviços, mas pode ser um ponto único de falha e, às vezes, um gargalo. Cada serviço é independente, mas eles geralmente são mais "pesados" e possuem dependências mútuas, o que pode tornar o sistema mais complexo e difícil de escalar.

- **Arquitetura de Microserviços**:
  Na arquitetura de microsserviços, a aplicação é dividida em pequenas partes independentes, onde cada microsserviço implementa uma funcionalidade específica e pode ser desenvolvido, implantado e escalado de forma isolada dos demais. A comunicação interna entre microsserviços é descentralizada, e ocorre por APIs HTTP ou mensagens assíncronas. Geralmente, a arquitetura de microsserviços necessita de um API Gateway para apresentar um único ponto de entrada padronizado para consumidores externos.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

O objetivo do uso de ferramentas de API Management é facilitar o gerenciamento das APIs que interligam os serviços distribuídos, essas ferramentas possibilitam a criação intuitiva de API Gateways. 
- **Vantagens**: empodera o usuário com ferramentas de coleta de métricas, políticas de segurança e otimização de desempenho;
- **Desvantagens**: cria um único ponto de falha (se o API Gateway ou a própria ferramenta de API Management caírem, o serviço cai junto), também pode aumentar os custos (licenciamento de software, infraestrutura);

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

- **Struct**: 
  - São utilizadas em casos mais simples, é muito comum que structs sejam usados para tipos genéricos como coordenadas, datas etc.;
  - São tipos de valor, ou seja, todas as instâncias de um struct são armazenadas na memória stack. Isso significa que toda vez que uma variável é atribuída à instância um struct, o valor recebido pela variável é um cópia da instância do struct na variável original;
  - Portanto, instâncias de structs conseguem ser mais performáticas em alguns casos, como no desalocação (por serem desalocadas junto à stack) e na manipulação de arrays (value types são armazenados sequencialmente em arrays);
- **Class**:
  - São usadas para casos mais complexos, onde a instância representa um conjunto de valores;
  - São tipos de referência, armazenados na heap. Isso significa que todas as variáveis atribuídas à uma instância de uma classe recebem uma referência de memória para o valor da classe, que fica armazenado na heap;
  - Instâncias de classe são mais performáticas em algoritmos que atribuem instâncias de valores grandes para variáveis, pois só é copiada a referência para o valor, e não o valor inteiro;
6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET (também conhecido como .NET Framework) é restrito ao Windows e não receberá versões mais novas, o .NET Core (conhecido como somente .NET a partir da versão 5) é multiplataforma e recebe novas versões (sendo a mais recente a 9, e a LTS mais recente a 8).

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST é baseada em HTTP, e é estruturada ao redor dos verbos HTTP (GET, POST, PUT, DELETE, PATCH etc.), as payloads geralmente são transportadas em formato de JSON. gRPC é baseada em HTTP 2, e é estruturada em chamadas de protocolos pela rede, que funcionam como se fossem chamadas de funções locais.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Um SPA tem todas as suas rotas listadas em um componente de roteamento, que faz uma tradução das strings de rotas para os componentes a serem renderizados. Todas as trocas dos componentes que são exibidos na tela ocorrem sem o recarregamento da página.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps integra o desenvolvimento às operações de TI. O objetivo é utilizar técnicas como pipelines para encurtar o ciclo de desenvolvimento e aumentar a frequência de deploys. 

10. Explique sobre um método agile.

**Resposta:**

Scrum.
O Scrum é organizado em sprints, que são ciclos de trabalho. Cada sprint dura em torno de 1 a 4 semanas e resulta em incrementos no produto (também chamados de entregáveis ou *deliverables*). Os entregáveis são tarefas guardadas em um backlog, a cada sprint, algumas tarefas são selecionadas para serem executadas.
O Scrum inclui três papéis específicos: Time de desenvolvimento (responsáveis por executar os entregáveis), Scrum master (atua como um facilitador que remove impedimentos externos) e Product Owner (responsável por gerenciar o backlog do produto, atribuindo prioridades aos entregáveis e alinhando a equipe com os objetivos do negócio).

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

A ferramenta de CI/CD que mais uso no meu dia a dia é o Azure Devops. Nele, uso pipelines para separar os diferentes deploys de clientes, cada um com suas próprias configurações. Infelizmente, no local onde trabalho não existem testes automatizados para serem integrados na pipeline.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Contêineres é um conceito de virtualização de ambientes de aplicações, onde cada aplicação é envelopada em seu próprio contêiner (incluindo suas próprias dependências e configurações de ambiente) e todos os contêineres compartilham do mesmo núcleo de sistema operacional.

Docker é uma plataforma de execução de contêineres. O Docker fornece ferramentas para a criação de imagens, execução e configuração de contêineres.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Kubernetes é uma plataforma de orquestração de contêineres, ele permite gerenciar vários clusters de contêineres e planeja a execução desses clusters com base nos requisitos computacionais de cada contêiner e nos recursos disponíveis.

O OpenShift é uma plataforma construída sobre o Kubernetes que oferece uma solução CaaS (Contêineres como Serviço). Ele vem com mais recursos integrados de fábrica, como ferramentas de monitoramento, suporte a CI/CD nativo, registro de imagens de contêiner etc.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

O uso de APIs é vantajoso quando se há uma necessidade de que um determinado software se comunique com outro sem que ambos compartilhem do mesmo código-fonte. Isso engloba casos como comunicações entre sistemas de diferentes empresas, comunicações cliente-servidor onde cada um tem a sua codebase e comunicações entre serviços distribuídos.

As desvantagem de usar APIs é que ambos os sistemas precisam entender perfeitamente a estrutura que foi estabelecida para a API. Caso contrário, os sistemas que consomem a API podem acabar apresentando falhas.

Portanto, a principal preocupação nessa abordagem é entender a estrutura da API que se deseja consumir. Também é essencial ter uma preocupação com segurança: APIs devem implementar autenticação e autorização para protegerem recursos privados.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

- Implementando Autenticação e Autorização para proteger recursos privados;
- Utilizando canais de comunicação seguros (como o HTTPS);
- Sanitizando todas as entradas de dados para prevenir ataques de SQL Injection, XSS e DoS;
- Limitando as requisições por segundo de usuários e o consumo de recursos que cada usuário tem direito;
- Gerando logs de todas as operações feitas pela API;
- Configurando o CORS de acordo com as origens desejadas;

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Uma arquitetura de mensageria permite o processamento assíncrono e distribuído de requisições dentro de um sistema.
Isso possibilita a criação de sistemas desacoplados, onde os emissores de eventos e ouvintes de eventos não dependem da implementação um do outro para funcionarem.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

A estratégia SAGA serve para gerenciar ações em microsserviços que necessitem de múltiplas transações que envolvem múltiplos microsserviços. Essa estratégia consiste em dividir a transação inicial em múltiplas sub-transações, onde cada uma das sub-transações é executada pelo seu próprio microsserviço.
As sub-transações podem ser coordenadas das seguintes maneiras:
- **Coreografadas**: cada transação é executada sem um controle centralizado. Cada transação pode desencadear outras transações caso seja necessário;
- **Orquestradas**: as transações são executadas de maneira centralizada por um orquestrador. O orquestrador emite os eventos para que os microsserviços executem as próximas transações;

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

GitOps é um modelo de Infraestrutura como Código que considera o repositório Git como única fonte de verdade para o estado desejado do sistema quando implantado, ou seja, o repositório reflete o código na sua versão desejada e as configurações desejadas (tanto a nível de aplicação como a nível de Kubernetes e automações).
Assim que há uma atualização no repositório (causada, por exemplo, por um commit de merge), uma ferramenta que observa o repositório por mudanças de estado (como o Jenkins) aplica a versão nova do repositório no cluster Kubernetes.
Esse modelo é interessante pois torna o ciclo de desenvolvimento e implantação uma tarefa muito mais declarativa do que imperativa: todas as informações necessárias para a implantação do projeto já estão no repositório, basta um simples commit para que elas sejam aplicadas no determinado ambiente.