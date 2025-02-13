# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

**Codebase (Base de Código)**
Uma aplicação deve ter uma única base de código versionada (por exemplo, em Git) e ser utilizada em vários ambientes (produção, release, desenvolvimento). Múltiplos repositórios para a mesma aplicação indicam um problema na arquitetura.

**Config (Configuração)**
Configurações como chaves de API, strings de conexão e variáveis de ambiente devem ser armazenadas fora do código-fonte. Isso permite a flexibilidade entre ambientes sem modificar o código.

**Backing Services (Serviços de Apoio)**
Bancos de dados, filas de mensagens e serviços externos devem ser tratados como recursos anexados, ou seja, a aplicação não deve diferenciar um serviço local de um serviço remoto.

**Processes (Processos)**
A aplicação deve ser executada como um ou mais processos independentes e sem estado. Caso for preciso armazenar dados entre requisições, deve utilizar um banco de dados ou cache.

**Port Binding (Vinculação de Porta)**
Aplicações devem ser auto-contidas, expondo serviços via uma porta configurável, sem depender de servidores embutidos como Apache ou Nginx.

**Logs**
Logs devem ser tratados como fluxos contínuos e enviados para um sistema externo (como Elastic Stack, Datadog ou Splunk), em vez de serem armazenados localmente.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Uma abordagem clássica que tenho usado bastante para o desenvolvimento de software, é a seguinte baseada no Clean Architecture:

**Apresentação (UI - User Interface)**
Responsável pela interação do usuário com o sistema. Geralmente implementada com Angular, React, Blazor ou outras tecnologias frontend.

**Aplicação (Application Layer)**
Contém as regras de negócio, validações e serviços que coordenam o fluxo da aplicação. Atua como intermediária entre a UI e a camada de domínio.

**Domínio (Domain Layer)**
Representa a lógica central do negócio, incluindo entidades, regras e operações principais. Segue com o conceito de POCO (Plain Old CLR Objects) no .NET para manter independência.

**Infraestrutura (Infrastructure Layer)**
Gerencia acesso a banco de dados, cache, APIs externas, mensageria e logging. Essa camada isola detalhes técnicos da aplicação.

**Banco de Dados (Persistence Layer)**
Camada onde os dados são armazenados e gerenciados, seja em SQL Server, PostgreSQL, MongoDB, etc.. Pode incluir repositórios para interagir com a aplicação.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Tendo experiência com ambas as arquiteturas, sei que ambas são abordagens para construir sistemas distribuídos, mas diferem principalmente na forma de comunicação e escalabilidade.

**SOA (Service-Oriented Architecture)**
A SOA organiza um sistema em serviços reutilizáveis e modulares, que se comunicam entre si, normalmente por meio de um ESB (Enterprise Service Bus). Essa abordagem geralmente utiliza protocolos mais pesados, como SOAP e XML, para integração, tornando a comunicação mais robusta, porém menos flexível.

**Microservices (Arquitetura de Microserviços)**
A arquitetura de microserviços divide a aplicação em pequenos serviços independentes, cada um responsável por uma funcionalidade específica e se comunicando geralmente via APIs. Diferentemente da SOA, cada microserviço tem seu próprio banco de dados e lógica, reduzindo o acoplamento e permitindo maior escalabilidade. A comunicação é distribuída por HTTP (REST, GraphQL) ou mensageria (RabbitMQ, Kafka), utilizando tecnologias mais leves e modernas, como JSON e gRPC.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

No mundo dos serviços distribuídos, ter várias APIs expostas pode rapidamente se tornar um caos sem um gerenciamento adequado. O API Management (APIM) entra justamente para controlar, proteger e monitorar essas APIs, garantindo segurança, performance e organização. Ele funciona como uma camada intermediária entre os consumidores (frontend, terceiros, parceiros) e os serviços backend, oferecendo recursos como autenticação, rate limiting, caching e monitoramento.
**Vantagens:**
**Segurança** - permite que faça o controle de acesso com autenticação JWT, API Keys, OAuth2, além da proteção contra ataques como DDoS.
**Monitoramento e analyutics** - impende que um usuário sobrecarrege o sistema, e garante que a API continue operando para todos.

**Desvantagens:**
**Pode adicionar latência** - como é uma camada intermediária, pode impactar um pouco a velocidade das requisições.
**Custo operacional** - as ferramentas como Azure API Management, Kong podem ter custos altos dependendo do tráfego.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
A diferença principal ali entre o Struct e uma Class está na forma como elas são armazenadas na memória e no comportamente delas dentro do código.
O **Struct** é um tipo de valor, armazenado na stack, o que a torna mais rápida e eficiente para pequenas estruturas de dados. Não suporta heranã e geralmente é usada para representar objetos simples.
Uma **Class** é um tipo de referência, armazenado no heap, o que permite maior flexibilidade, como herança e polimorfismo. Ideal para objetos mais complexos e que precisam ser passados por referência.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

**.NET Frameworkd** é a versão mais antiga, limitada ao Windows, usado principalmente para aplicações legadas como sistemas empresariais e aplicações desktop com Windows Forms e WPF.
**.NET Core** foi criado para ser multiplataforma (roda no Windows, Linux e macOS), tem melhor performance, suporta containers/Docker e é open-source.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

A diferença principal entre REST e gRPC está na forma de comunicação e desempenho.
**REST** - usa HTTP e geralmente JSON para troca de dados; mais flexível e fácil de integrar, já que funciona bem em navegadores e qualquer linguagem.
**gRPC** - usa o HTTP/2 e Protobuf, que são mais rápidos e eficientes; melhor para comunicação entre microsserviços por ser mais performática e consumir menos banda; suporta streaming bidirecional, o que permite comunicação mais dinâmica.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Uma SPA (Single Page Application), o gerenciamento de rotas funciona do lado do cliente, sem recaregar a página por completo.
O frontend intercepta mudança de URL e carre o conteúdo dinamicamente;
Usa histório do navegador (History API) ou hashes (#/minha-rota) para navegação;
Os frameworkd como Angular (Router), React (React Router) e Vue (Vue Router) gerenciam as rotas.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

Tenho experiência com DevOps há bastante tempo, principalmente no uso de CI/CD para integração e entrega contínua. Também utilizo Infraestrutura como Código (IaC) para gerenciar servidores como código, com ferramentas como Terraform.
**Ferramentas que utilizo no dia a dia:** Github Actions, GitLab CI, Jenkins, Azure DevOps. Para containers e orquestração: Docker, Kubernetes. 
Monitoramento: Prometheus, Grafana, Datadog.

10. Explique sobre um método agile.

**Resposta:**
Explicando então um pouco sobre a metodologia ágil **Scrum** na qual faz parte do meu dia a dia de trabalho.
- Trabalho dividido em sprints (garalmente de 1 a 4 seamanas).
- Reuniões diárias (daily) para alinhar o progresso.
- No início de cada sprint, há uma planning para o planejamento das demandas a serem executadas.
- No final de cada sprint, há uma review e uma retrospectiva para ajustes.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

O CI/CD (Integração Contínua / Entrega Contínua ou Deployment) automatiza os processos de build, testes e deploy, garantindo entregas mais rápidas e confiáveis.

**CI (Continuous Integration)**
Os desenvolvedores fazem commits frequentes, e o código é compilado e testado automaticamente, evitando falhas antes de ser integrado ao repositório principal.
**CD (Continuous Delivery / Continuous Deployment)**
Continuous Delivery - O código está sempre pronto para produção, mas o deploy é feito manualmente.
Continuous Deployment - O deploy acontece automaticamente assim que uma nova versão estável é aprovada.
**Ferramentas que utilizo no dia a dia:**
CI/CD Pipelines: GitHub Actions, GitLab CI, Jenkins, Azure DevOps.
Containers e orquestração: Docker, Kubernetes.

12. Qual a diferença entre Docker e Containers.

**Resposta:**

A diferença principal é que o Docker é uma plataforma, enquanto containers são a tecnologia usada para isolar e executar aplicações.
**Containers** - são ambientes isolados que empacotam uma aplicação junto com suas dependências, o que garante que ela rode da mesma forma em qualquer sistema.
**Docker** - é uma ferramente que facilita a criação, gerenciamento e execução de containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

A diferença é que o Kubernetes é um orquestrador de containers, enquanto o OpenShift é uma plataforma baseada em Kubernetes, que adiciona mais recursos e facilidades.
**Kubernetes** - é open-source, ele gerencia e orquesta containers, o que permite escalabilidade e automação de deploys. É flexível, mas exige mais configuração manual.
**OpenShift** - usa o Kubernetes como base, mas adiciona outras ferramentas extras, como uma interface mais amigável, integração com CI/CD e segurança.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

As APIs são a base da comuncação entre os sistemas modernos. Segue as vantagens e desvantagens.
**Vantagens** - **modularidade** - permite que diferentes sistemas se integrem facilmente; **escalabilidade** - facilita a divisão do sistema em parte independentes (exemplo: microserviços); **reutilização** - um mesmo seriviço pode ser usado por múltiplas aplicações; **facilidade de integração** - conecta aplicações web, mobile e terceiros de forma padronizada.
**Desvantagens** - **latência e performance** - cada requisção adiciona um tmepo de resposta, principalmente se houver várias chamadas encadeadas; **segurança** - se mal implementada, pode expor dados sensíveis (ex: APIs sem autenticação adequada); **gerenciamento e versionamento** - mudanças na API podem impactar clientes que dependem dela.

**Algumas preocupações**
Segurança - implementação autneticação e controle de acesso (JWT, OAuth2, API Keys);
Performance - evitar chamadas desnecessárias e usar cache sempre que possível;
Versionamento - manter diferentes versões da API para evitar quebra de compatibilidade.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Principais medidas de segurança:
**Autenticação e autorização** - usar JWT, OAuth2 ou API Keys para controlar quem poe acessar a API.
**Criptografia** - sempre usar HTTPS/TLS para proteger os dados em trânsito.
**Rate limiting e trhottling** - limitar requisiões para evitar abusos e ataques DDoS.
**Logs e monitoramento** - implementar a auditoria para detectar acessos suspeitos.
**Versionamento seguro** - evitar expor APIs antigas sem suporte a novas medidas de segurança.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

A arquitetura de mensageria serve para permitir comunicação assíncrona entre sistemas, o que os tornam mais desacoplados, escaláveis e eficientes.
**Desacoplamento** - serviços não precisam esperar respostas imediatas, o que torna o sistema mais flexível.
**Escalabilidade** - permite processar grandes volumes de dados sem sobrecarregar serviços.
**Resiliência** - se um serviço falhar, as mensagens ficam na fila até serem processadas.
**Ferramentas que são populares:** RabbitMQ, Kafka, SQS (AWS).


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

A estratégica SAGA ela é usada para gerenciar trnsações distribuídas em microserviços, o que garante consistência eventual sem precisar de um banco de dados centralizado.
Em microsserviços, cada serviço ele tem seu próprio banco, o que dificulda transações ACID tradicionais.
SAGA permite que cada serviço execute sua parte da transação e, caso algo dê errado, realize uma compensação para reverter as operações já feitas.

**Tipos de SAGA**
**Coreografia** - cada serviço se comunica por eventos, sem precisar de um orquestrador.
**Orquestração** - um serviço central (orquestrador) controla o fluxo, chamando cada serviço na ordem correta.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

O meu entendimento é que o GitOps é uma abordagem para gerenciar infraestrutura e aplicações usando Git como fonte única de verdade. Com o Kubernetes, sigifnica que qualquer mudança na infraestrutura ou configuração e feita via Git e automaticamente aplicada ao cluster.
Ferramenta que uso no dia a dia é o **ArgoCD** que monitoram o repositório.
Quando há uma mudança, o Kubernetes atualiza automaticamente os recursos.
**Vantagens** - maior controle - qualquer alteração fica registrada no git.
Deploys automaticados - sem necessidade de aplicar manualmente com kubectl.
Rollback fácil - se algo der errado, basta reverter o commit no Git.