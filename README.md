# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Codebase - Uma aplicação deve ter uma única base de código, que pode ser compartilhada entre vários ambientes (desenvolvimento, produção), 
todas compartilham o mesmo repositório para evitar a fragmentação do código e garantir que mudanças e melhorias estejam unificadas em um único lugar.

Config - As configurações da aplicação (chaves de API, strings de conexão) devem ser separadas do código fonte e gerenciadas via variáveis 
de ambiente para permitir alterar o comportamento da aplicação sem alterar o código.

Backing Services - Recursos externos que a aplicação consome (banco de dados, fila de mensagens) devem ser tratados como recursos anexáveis, e devem 
poder serem substituídos sem a necessidade de mudanças significativas na aplicação

Processes - Uma aplicação deve ser executada como um ou mais processos sem estado. Toda a informação necessária para que um processo funcione deve 
estar armazenada em um banco de dados ou outro serviço externo. Processos podem ser iniciados, interrompidos e substituídos a qualquer momento.

Dev/Prod Parity - O ambiente de desenvolvimento deve ser o mais similar possível ao de produção. Isso inclui o tempo de deploy, as bibliotecas usadas 
e as ferramentas empregadas em ambos os ambientes.

Logs - A aplicação deve tratar logs como um fluxo de eventos. Eles não devem ser gerenciados ou armazenados pela própria aplicação. Em vez disso, devem 
ser enviados para um serviço externo de agregação, onde podem ser monitorados e analisados.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Apresentação, aplicação, domínio, persistência, banco de dados e infraestrutura.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

SOA foca em serviços maiores e centralizados, com forte integração por ESB, é mais pesado e padronizado, enquanto microserviços promovem componentes menores, 
independentes e comunicação descentralizada, são mais ágeis, leves e fáceis de escalar.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

Um API Management serve para controlar, monitorar e aprimorar o uso de APIs em arquiteturas de serviços distribuídos. Os benefícios são: a centralização da 
segurança, o acompanhamento do desempenho, o controle do tráfego, e o versionamento, além de facilitar a descoberta das APIs. As desvantagens são: aumentar a 
latência nas requisições, custos extras, ser um ponto único de falha e equipes que não estão familiarizadas podem ter dificuldades para se adaptar.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Structs são geralmente usadas para representar dados pequenos e imutáveis, classes são para entidades mais complexas que envolvem herança e comportamento.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.Net é o framwork de desenvolvimento da Microsoft. o .Net Core é uma das versões desse framework. Caso a pergunta seja a grande diferença entre o .Net Framework e o .Net Core 
a resposta seria que o .Net framework é mais antigo e voltado para desenvolvimento da plataforma windows, e o .Net Core é multiplataforma.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST usa HTTP/1.1 como protocolo e usa JSON ou XML para trocar dados, enquanto gRPC usa HTTP/2 e utiliza Protocol Buffers. REST também é geralmente unidirecional, seguindo o 
padrão de requisição e resposta, e o gRPC permite comunicação bidirecional.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

O gerenciamento de rotas em uma SPA permite uma navegação sem a necessidade de recarregar a página inteira. Quando o usuário interage com a aplicação, como clicar em um botão, o 
roteador intercepta essas ações e em vez de carregar uma nova página, ele usa a API de History do navegador para alterar a URL da barra de endereços sem recarregar a página.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

Conheço as ferramentas de CI/CD do Azure Devops, Jenkins e SonarQube


10. Explique sobre um método agile.

**Resposta:**
O método Adile que eu trabalhei toda a vida foi o Scrum. Nele, as tarefas são chamadas histórias e elas são divididas em períodos de trabalho chamados sprints. Um time de 
desenvolvimento multidisciplinar deve completar as tarefas daquela sprint naquele período e gerar um pacote de melhorias para ser entrege aos steakeholders. O scrum tem
algumas cerimônias periódicas como a reunião de planejamento, as reuniões diárias, a revisão e a retrospectiva.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

CI e CD são práticas do ciclo de desenvolvimento para melhorar a qualidade do código e acelerar o desenvolvimento. Algumas ferramentas comuns são o Jenkins, GitLab e Azure Devops.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Containers são unidades que empacotam uma aplicação para ela ser executada em qualquer ambiente e Doker é uma plataforma de criação e gerenciamento de containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é um sistema de orquestração de containers, OpenShift é uma plataforma de Kubernetes, construída sobre ele, mas com recursos adicionais.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
APIs permitem que diferentes sistemas se comuniquem e compartilhem dados, permitem a integração com serviços de terceiros, facilitando a adição de 
novas funcionalidades às aplicações entre outros benefícios.
Como desvantagem: perda de desempenho, podem ser alvos de ataques, necessitando de medidas de segurança melhores e a dependência externa pode 
acabar virando um gargalo ou um backdor.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Utilizando autenticação e autorização, HTTPS, criptografia dos dados, registro das atividades da API.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Para a comunicação entre sistemas de forma assíncrona e escalável, principalmente em sistemas distribuídos e microserviços.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

A estratégia SAGA é um padrão de gerenciamento de transações para garantir a consistência dos dados.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma abordagem que utiliza o Git como o único repositório para gerenciar a infraestrutura e 
as aplicações, especialmente em ambientes Kubernetes. O estado desejado da infraestrutura é definido em um repositório 
Git, onde ferramentas como ArgoCD ou Flux monitoram continuamente por alterações. Quando uma mudança é detectada, essas 
ferramentas aplicam automaticamente as novas configurações ao cluster, garantindo que a infraestrutura esteja sempre 
alinhada com o que está definido no Git. Essa prática promove consistência, auditoria e recuperação fácil, já que todas 
as mudanças são versionadas e podem ser revertidas rapidamente se necessário. No entanto, a implementação do GitOps pode 
exigir uma adaptação cultural e técnica nas equipes, além de um bom monitoramento para garantir que as alterações sejam 
aplicadas corretamente. Essa abordagem representa uma evolução significativa na gestão de aplicações e infraestrutura, permitindo 
um desenvolvimento mais ágil e escalável.