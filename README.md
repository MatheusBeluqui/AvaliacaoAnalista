# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Tenho projetos pessoais na Heroku, com processos completos de CI/CD implementados então conheço um pouco dos principios do Twelve-Factor App. 

Codebase: A aplicação deve ter um único repositório versionado, independente do ambiente (dev, prod, staging). Uso Git para isso, e sempre mantenho uma estratégia clara de branches para evitar bagunça no versionamento. Faço essas interações desde prompts de comando ate plataformas como Git Extensions, o próprio Visual Studio ou ate mesmo trabalhando dentro da azure repos.

Config: Nunca se deve armazenar credenciais no código. O ideal é usar variáveis de ambiente ou um Secrets Manager (como Azure Key Vault ou AWS Secrets Manager) para manter os dados seguros.

Dependencies: A aplicação precisa declarar todas as suas dependências explicitamente. No .NET, uso NuGet, e no Angular, NPM.

Build, Release, Run: O ciclo de deploy deve ser bem separado. Primeiro se gera um build, depois se define o ambiente (release) e só então a aplicação roda. Isso evita deploys com código diferente do que foi testado.

Logs: Os logs precisam ser armazenados externamente e não dentro da aplicação. Sempre configuro Serilog + Elastic Stack ou Application Insights para conseguir monitoramento eficiente e debugar produção sem depender de logs locais.

Concurrency: A aplicação precisa ser escalável, rodando múltiplos processos separados ao invés de depender de threads internas. Já trabalhei com isso usando Kubernetes e RabbitMQ para distribuir carga e manter os serviços rodando de forma independente.

2. Quais são as principais camadas no desenvolvimento de um software?

Depende do projeto, mas geralmente sigo essa estrutura:

Frontend: Interface do usuário. Normalmente trabalho com Angular ou React.
Backend: Onde ficam as regras de negócio. Costumo usar .NET Core para APIs.
Banco de Dados: Relacional (SQL Server, PostgreSQL) ou NoSQL (MongoDB, Redis).
Mensageria: Para comunicação assíncrona entre serviços, uso RabbitMQ ou Azure Service Bus.
Segurança: Implementação de OAuth2, JWT, Identity Server para controle de acesso.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

SOA: Centraliza serviços, o que pode gerar acoplamento alto.
Microservices: Divide o sistema em serviços independentes, cada um com seu banco de dados e comunicação via APIs ou eventos.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

O API Management é tipo um intermediário que ajuda a organizar e proteger as APIs. Ele controla segurança, autenticação, rate limiting e monitoramento.

Vantagens:
Segurança reforçada (JWT, OAuth2).
Monitoramento de requisições.
Controle de versionamento.

Desvantagens:
Pode adicionar latência extra por ter varios serviços comunicando entre si.
Tem um custo mais elevado, principalmente em soluções como Azure API Management por exemplo.

5. Qual a diferença entre uma Struct e uma Class?

Uma classe eu crio uma referência, e ela é totalmente personalizavel consigo trocar valores, usar OOP, etc.
Uma struct é quando se quer criar um valor simples e imutavel.

6. Explique a grande diferença entre .NET e .NET CORE.

A maior diferença é que o .net roda só pra windows e o core atende diferentes clients, ele é bem mais leve e otimizado por ter sido totalmente reescrito. 

7. Quais as principais diferenças entre REST e GRPC?

REST é melhor para construir Apis num geral, normalmente usamos json para as requisições o que é mais legivel, e GRPC é indicado para microsserviços pois é mais rapido e usa protobuffs binários.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

Isso depende muito da biblioteca ou framework que trabalharemos, mas se tratando de angular, ele ja tem o Routes dele definido onde ele ja espera que voce defina um Path e importe o componente que será carregado naquela rota. 

9. Falando sobre DevOps, comente o que conhece sobre.

DevOps é automatização e um facilitador para integrar processos, permite fazer deploys de forma descomplicada e bem confiável.
Conheço das práticas de CI/CD. Doker e Kubernetes para fazer a orquestração de conteineres.

10. Explique sobre um método agile.

Já estou bem habituado a práticas como Planing, Daily's, acompanhamento do burning down, acompanhamento de sprints, refinamentos técnicos, reviews, reunioes de GMUD e etc...
Isso tudo já faz parte da minha rotina. 

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

Conheço sobre automatização de publicações direto no iis dentro de servidores de clientes desde a parte de configurar os deployments groups no azure para fazer a comunicação com o servidor, configuração das pipelines de acordo com o projeto para o build, até a configuração das tasks da release como por exemplo o IISAplicationPool, IISAplicationWeb, e a parte de deploy como o Deploy IIS Website/App.

12. Qual a diferença entre Docker e Containers.

Container sozinho é uma parte que é criada que tem de forma bem leve tudo que é necessario para rodar uma aplicação de forma independente.
O Docker por si só ele ajuda nesse gerenciamento e criação de conteineres. 

13. Qual a diferença entre Kubernetes e Openshift?

Kubernetes me garante fazer toda a configuração através de um cluster, dos containeres, e la eu consigo garantir toda a orquestração desses containeres , auto-scaling, e balanceamento de carga por exemplo.

Openshift, não conheço me sei que ele é como o Kubernetes, so que com um custo elevado e com mais segurança.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

Sempre traalhei com o uso de apis então vejo muitas vantagens como escalabilidade, facilidade com integrações, no caso do .net suporte a diferentes clients.
Acredito que as desvantagens sejam, que apis devem ter um grande foco na parte de segurança pois são mais sucetiveis a ataques, e podem gerar latencia dependendo do numero de requisições.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

Primeiro de tudo usar https para segurança, colocar o uso de Authorization e Authentication com tokens JWT, fazer a configuração de cors da aplicação, trabalhar com dados sensíveis criptografados, registrar logs e fazer o monitoramento, e tambem fazer auditoria do sistema pra controle de acesso.

16. Para que serve uma arquitetura de mensagerias?

São extremamente performáticas para trocas de informações e suporta grande volume de dados, garante bem o processamento pois se algo acontecer a mensagem fica na fila ate ser processada, e ainda é possivel criar multiplos consumidores para aumentar a performance. 

17. Explique a estratégia SAGA em arquitetura de microservice.

Basicamente é usar a abordagem acima para atraves de eventos garantir que todas as etapas sejam feitas, muito utilizada em microserviços isso facilita no desacoplamento, garante o processamento, permite colocar mais consumidores para acelerar o processo, e conseguimos ainda através de eventos desfazer ações caso algum erro aconteça no processo.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

Nunca atuei na configuração mas sei que o ArgoCD voce configura com o manifesto do Kubernetes e ele automaticamente reflete e garante a sincronização com o estado do GIT.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

Fui responsável por um processo massivo de importação de 5TB de imagens de CNHs de uma base do DETRAN para dentro do sistema. O grande desafio era capturar cada arquivo, enviá-lo para o sistema sem sobrecarregar a infraestrutura e garantir que a indexação fosse feita corretamente.

Além disso, após a importação, as CNHs precisavam ser armazenadas no storage do MinIO e indexadas pelo próprio sistema para permitir buscas eficientes no futuro.

O volume de dados era gigantesco, e não havia possibilidade de processamento síncrono, pois o sistema ficaria indisponível para os usuários.

Então adotei as seguintes estratégias:

Criei uma aplicação como produtora para que cada arquivo da base do DETRAN fosse enviado para uma fila no RabbitMQ.
Na aplicação principal construi workers para ficar em background recebendo os arquivos das filas, fazendo a validação necessária e depois enviando para o MinIO
Após a confirmação de upload, um evento era disparado notificando o sistema para indexar os dados no banco.
Assim que o arquivo era salvo no MinIO, a API do sistema era acionada para indexar os metadados da CNH no SQL Server.
Para otimizar buscas futuras, algumas informações chave eram armazenadas no banco, enquanto o arquivo original ficava no MinIO.
Para garantir que nenhuma imagem fosse perdida, implementei logs estruturados com o Serilog.
Se um arquivo falhasse, ele era reprocessado automaticamente e enviado para uma fila Dead Letter que configurei para análise posterior mas não foi necessária.
