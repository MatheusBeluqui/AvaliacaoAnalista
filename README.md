# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Codebase:  A base de código deve ser unificada e comum para todos os participantes do processo de criação do software e a base de código precisa ser temporal e auditável. Para isso são utilizadas ferramentas como o Git.
Dependências: São artefatos externos dos quais sua aplicação depende para ser executada corretamente, existem ferramentas que auxiliam nesse processo como o Nuget do .NET, npm do NodeJS
Serviços de Apoio: São serviços que são consumidos por uma aplicação principal para que esta funcione e desempenhe suas funções. Para citar alguns serviços temos bancos de dados como SQL Server ou Oracle, alguns serviços de cache como redis e filas como RabbitMQ ou IBM.RabbitMQ
Build, release, run: Consiste na maneira como uma aplicação é entregue e é divida em três etapas: O build que é quando o código é transformado em um executavél, a release que é a etapa onde o pacote gerado no estágio de build é aplicado dentro de uma configuração específica e por fim o run em que a aplicação é executada
Configurações: As configurações para execução de um projeto são quaisquer parâmetros que podem variar com fatores externos, como o ambiente onde a aplicação será executada
Processos: Quando uma aplicação entra no estágio de execução, esta passa a ser composta por múltiplos processos. Estes processos podem ser representados por várias estruturas, como diferentes threads ou até mesmo sub-rotinas

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
- Camada de Apresentação
- Camada de Negócio
- Camada de Dados
- Camada de Serviço
- Camada de Infraestrutura

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
SOA: Diferentes serviços com recursos compartilhados, armazenamento de dados compartilhado, fica mais lento à medida que mais serviços são adicionados.
Arquitetura microserviços: Serviços menores, independentes e específicos, armazenamento de dados independente


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O API Management se refere ao processo de criação, publicação e gerenciamento de conexões de API em uma configuração corporativa 

Vantagens:
Aprimoramento da Experiência do Cliente
Agilidade nos Negócios
Redução de Custos
Integração de Sistemas Simplificada
Análise de Dados Mais Precisa

Desvantagens:
Custos
Complexibilidade

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct é um tipo de valor e é armazenado na stack e ela não pode ser herdada. Já uma class é armazenada na heap e é um tipo de referência


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET é a plataforma original de desenvolvimento da Microsoft. Ele é usado para criar aplicações Windows, como o Windows Forms. O .NET Core é uma versão mais recente e moderna do .NET que é multiplataforma


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

GRPC:
Utiliza protocolo HTTP 2.0
Protocol Buffers 
Baixa compatibilidade com navegadores
É uma excelente opção para trabalhar com sistemas multilíngues , streaming em tempo real

REST:
PIs REST seguem um modelo de comunicação de solicitação-resposta que normalmente é construído em HTTP 1.1
REST segue a padronização do protocolo HTTP
JSON/XML



8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Todo o conteúdo é carregado de uma vez ou obtido dinâmicamente e as rotas são previamente definidas


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
É uma cultura que promove a colaboração entre todas as funções envolvidas no desenvolvimento e na manutenção do software, alguns dos benefícios são: Velocidade, Entrega rápida, Confiabilidade, Colaboração melhorada.


10. Explique sobre um método agile.

**Resposta:**
Scrum é um conjunto de boas práticas empregado no gerenciamento de projetos complexos e segue seis principios:
Flexibilidade dos resultados
Flexibilidade dos prazos
Times pequenos
Revisões constantes
Colaboração
Orientação a objetos.
O Scrum também conta com alguns ritos como Daily, sprints, sprint review, sprint planning, sprint retro

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI e CD são siglas para Integração Contínua (Continuous Integration) e Entrega Contínua (Continuous Delivery), a integração contínua consiste na junção de diferentes alterações de código em um repositório central
A entrega contínua é um método de automação das fases de desenvolvimento. Nela, as alterações realizadas no código são testadas automaticamente e, em seguida, carregadas em um repositório para que sejam posteriormente implantadas em um ambiente de produção
Algumas das ferramentas que já utilizei no meu dia a dia foram Jenkins, ArgoCD


12. Qual a diferença entre Docker e Containers.

**Resposta:**
Imagens e contêineres do Docker são tecnologias de implantação de aplicativos, docker é a ferramenta que gerencia os containers


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é uma estrutura de contêiner como serviço de código aberto, automatiza a implantação, o dimensionamento e as operações de aplicativos
Kubernetes oferece mais flexibilidade como uma estrutura de código aberto e pode ser instalado em quase qualquer plataforma
OpenShift tem políticas de segurança mais rigorosas.
OpenShift fornece uma variedade de recursos de automação


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Vantagens:
- Facilidade de integração
- Escalabilidade
- Reusabilidade

Desvantagens:
- Segurança
- Manutenção
- Latência

As preocupações são: segurança, documentação, latência.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Podemos utilizar algumas técnicas como autenticação e autorização, uso de CORS, Logs, testes de segurança


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Arquitetura em mensageria consiste na utilização de mensagens para a comunicação entre serviços internos ou externos do sistema, ou seja, consiste na utilização de mensagens para estabelecer a comunicação síncrona ou assíncrona entre aplicações.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
SAGA conta com duas estratégias de utilização: Coreografia e Orquestração. 
A coreografia consiste em cada microsserviço realizando uma chamada de forma assíncrona com outro ao finalizar seu processamento com sucesso.
A orquestração trabalha de forma síncrona, delegando a um “responsável” o poder de organizar esse fluxo de entrega, centralizando as chamadas dos microsserviços e separando por steps ou pequenos flows.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps utiliza o git como uma fonte para gerenciar as configurações de infraestrutura e aplicação. Já atuei em um projeto onde temos um repositório com arquivos YAML que gerenciam as aplicações no kubernetes, nesse arquivo configuramos quantidade de pods, variaveis de ambiente e volumes para a aplicação