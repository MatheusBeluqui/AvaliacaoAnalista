# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Codebase: manter o código versionado em um repositório Git.

Dependencies: declarar e gerenciar as dependências da aplicação.

Config: manter configurações fora do código, utilizando variáveis de ambiente.

Backing Services: tratar bancos de dados, filas e outros serviços como recursos externos.

Build, Release, Run: separar os processos de compilação, publicação e execução.

Logs: gerar logs como fluxo de eventos, permitindo monitoramento e diagnóstico de problemas.

2. Quais são as principais camadas no desenvolvimento de um software?

As principais são apresentação, aplicação, domínio ou regras de negócio e infraestrutura/acesso a dados. Essa separação facilita manutenção, testes, organização do código e evolução do sistema.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

As principais são apresentação, aplicação, domínio ou regras de negócio e infraestrutura/acesso a dados. Essa separação facilita manutenção, testes, organização do código e evolução do sistema.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

Resposta:

SOA trabalha com serviços reutilizáveis e integração entre sistemas, muitas vezes utilizando um barramento de serviços (ESB). Microserviços dividem a aplicação em serviços menores, independentes, com responsabilidades específicas e possibilidade de deploy e escalabilidade individual.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

Centralizar o gerenciamento das APIs, controlando autenticação, autorização, limites de requisições, monitoramento e versionamento.

Vantagens: segurança, governança, controle de acesso e monitoramento centralizado.

Desvantagens: custo adicional, maior complexidade de infraestrutura e possível aumento de latência.


5. Qual a diferença entre uma Struct e uma Class?

Em C#, Struct é um tipo por valor, enquanto Class é um tipo por referência. Struct é indicada para representar dados pequenos, enquanto Class é mais utilizada para objetos com comportamento, identidade e ciclo de vida próprios. Classes também suportam herança entre classes.


6. Explique a grande diferença entre .NET e .NET CORE.

O .NET Framework tradicional é voltado principalmente para Windows. O .NET Core surgiu como uma plataforma moderna, open source e multiplataforma. A partir do .NET 5, o .NET Core passou a ser chamado apenas de .NET, unificando a evolução da plataforma.


7. Quais as principais diferenças entre REST e GRPC?

REST normalmente utiliza HTTP com JSON, sendo bastante utilizado em APIs públicas e integrações web. gRPC utiliza HTTP/2 e Protocol Buffers, oferecendo comunicação mais eficiente, contratos definidos e suporte a streaming. É bastante utilizado na comunicação entre serviços internos.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

Em uma SPA, as rotas são gerenciadas no frontend, sem precisar recarregar a página inteira. Frameworks como Angular e React permitem associar URLs a componentes, controlar navegação, parâmetros e proteger rotas através de mecanismos de autenticação e autorização.


9. Falando sobre DevOps, comente o que conhece sobre.

Em uma SPA, as rotas são gerenciadas no frontend, sem precisar recarregar a página inteira. Frameworks como Angular e React permitem associar URLs a componentes, controlar navegação, parâmetros e proteger rotas através de mecanismos de autenticação e autorização.

9. Falando sobre DevOps, comente o que conhece sobre.

Resposta:

DevOps integra desenvolvimento e operações, buscando automatizar processos e melhorar a entrega de software. Envolve CI/CD, testes automatizados, infraestrutura como código, containers, monitoramento e observabilidade. O objetivo é realizar entregas mais rápidas, seguras e consistentes.


10. Explique sobre um método agile.

Scrum é um framework ágil que organiza o desenvolvimento em ciclos chamados Sprints. Utiliza planejamento, reuniões diárias, revisão e retrospectiva para acompanhar entregas, identificar impedimentos e melhorar continuamente o processo.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

CI é a integração contínua do código, com execução automática de builds e testes. CD automatiza a entrega ou implantação das aplicações nos ambientes. Ferramentas comuns são GitHub Actions, Azure DevOps, Jenkins, GitLab CI e Docker.


12. Qual a diferença entre Docker e Containers.

Container é uma tecnologia de isolamento que permite executar aplicações com suas dependências. Docker é uma plataforma utilizada para construir, distribuir e executar containers. Ou seja, Docker é uma ferramenta que utiliza a tecnologia de containers.


13. Qual a diferença entre Kubernetes e Openshift?

Kubernetes é uma plataforma open source para orquestração de containers, gerenciando deploys, escalabilidade e disponibilidade. OpenShift é uma plataforma da Red Hat baseada em Kubernetes, que adiciona recursos integrados de segurança, gerenciamento, desenvolvimento e operação.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

APIs facilitam a integração entre sistemas, reutilização de funcionalidades e separação de responsabilidades.

Como desvantagens, temos dependência de rede, latência, versionamento e maior necessidade de monitoramento.

É importante considerar segurança, autenticação, disponibilidade, performance, tratamento de erros e compatibilidade entre versões.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

Utilizando HTTPS, autenticação OAuth2/JWT quando adequada, autorização por permissões, validação de entradas, rate limiting e gerenciamento seguro de credenciais. Também é importante manter logs, monitoramento, atualização de dependências e testes periódicos de segurança.


16. Para que serve uma arquitetura de mensagerias?

Permite comunicação assíncrona entre sistemas, reduzindo o acoplamento entre serviços. Ferramentas como RabbitMQ e Kafka ajudam no processamento de eventos, distribuição de mensagens, escalabilidade e tratamento de falhas.


17. Explique a estratégia SAGA em arquitetura de microservice.

SAGA é um padrão utilizado para controlar transações distribuídas entre microserviços. Cada serviço executa sua transação local e, caso ocorra uma falha, são executadas ações compensatórias para desfazer os efeitos das etapas anteriores. Pode ser implementada por coreografia ou orquestração.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

GitOps utiliza o Git como fonte de verdade das configurações de infraestrutura e aplicações. As alterações são versionadas e ferramentas como Argo CD ou Flux sincronizam o estado do cluster Kubernetes com o que está definido no repositório. Isso facilita auditoria, rastreabilidade e rollback.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

GitOps utiliza o Git como fonte de verdade das configurações de infraestrutura e aplicações. As alterações são versionadas e ferramentas como Argo CD ou Flux sincronizam o estado do cluster Kubernetes com o que está definido no repositório. Isso facilita auditoria, rastreabilidade e rollback.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

Resposta:

Participei de um projeto de modernização de uma plataforma de bots e serviços, envolvendo aplicações Node.js, TypeScript, APIs REST, Redis, MariaDB, Docker e Kubernetes.

Um dos principais desafios foi preparar os serviços para execução em um ambiente Kubernetes, garantindo comunicação entre aplicações, estabilidade e possibilidade de escalabilidade.

Atuei na configuração dos Deployments e Services, ajustes de variáveis de ambiente, integração com Redis e banco de dados, além da análise de logs e resolução de problemas de comunicação entre os serviços.

Também realizei testes com múltiplas réplicas do backend, validando a comunicação interna do cluster e o funcionamento das aplicações.

O resultado foi a validação da infraestrutura e dos principais serviços no Kubernetes, permitindo avançar na modernização da plataforma com uma arquitetura mais preparada para escalabilidade e manutenção.
