# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Código Base (Codebase): A aplicação deve ter um único código-fonte versionado, compartilhado entre todos os ambientes (produção, teste, desenvolvimento).
Configuração (Config): As configurações específicas do ambiente (keys, connections, etc.) devem ser armazenadas em variáveis de ambiente, fora do código-fonte, para facilitar a configuração em diferentes ambientes.
Dependências (Dependencies): Dependências devem ser declaradas explicitamente e isoladas, sem depender de pacotes instalados globalmente no sistema operacional.
Logs: Trate logs como fluxos de eventos. A aplicação deve produzir logs como fluxo contínuo de saída padronizada sem se preocupar com o armazenamento ou gerenciamento de logs. O processamento e armazenamento dos logs deve ser de um sistema externo, como Datadog.
Armazenamento (Backing Services): Serviços como bancos de dados, filas de mensagens, e caches devem ser tratados como recursos que podem ser facilmente trocados sem alterar o código da aplicação. Eles são configurados via variáveis de ambiente e podem ser anexados ou desanexados dinamicamente.
Execução (Processes): Execute a aplicação como um ou mais processos sem estado. Os processos da aplicação devem ser stateless (sem estado), ou seja, eles não devem armazenar qualquer tipo de dado persistente. Qualquer estado necessário deve ser armazenado em serviços externos, como bancos de dados ou caches.
Desenvolvimento/Produção Igual (Dev/Prod Parity): Mantenha paridade entre os ambientes de desenvolvimento, teste e produção. A ideia é minimizar as diferenças entre os ambientes para reduzir bugs e inconsistências, garantindo que o desenvolvimento, testes e deploy sejam o mais próximo possível, promovendo entregas rápidas e confiáveis.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Camada de Apresentação (UI/UX): Interface com o usuário final, onde a interação ocorre.

Camada de Aplicação: Contém a lógica de negócios da aplicação, como processamento de dados e validação.

Camada de Serviço: Abstrai as operações de negócio que podem envolver várias camadas, incluindo lógica adicional para integração com serviços externos.

Camada de Persistência: Responsável por gerenciar a comunicação com os bancos de dados ou qualquer armazenamento de dados.

Camada de Infraestrutura: Gestão de componentes subjacentes, como servidores, redes, segurança, etc.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
SOA (Service-Oriented Architecture): Envolve a construção de serviços grandes e reutilizáveis, que podem ser compartilhados entre várias aplicações. A comunicação geralmente ocorre via protocolos mais pesados como SOAP.

Arquitetura de Microserviços: Divide a aplicação em serviços menores e independentes, focando na modularidade e no desenvolvimento autônomo. A comunicação é geralmente via protocolos como HTTP/REST.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O API Management (Gerenciamento de APIs) é uma prática e uma ferramenta essencial para gerenciar o ciclo de vida de APIs em ambientes de serviços distribuídos, como arquiteturas de microserviços. Seu principal objetivo é fornecer uma maneira centralizada de gerenciar, monitorar, proteger e otimizar o uso das APIs que conectam diferentes serviços e sistemas.

Vantagens:

Melhora a segurança e controle de acesso.
Simplifica a governança e a gestão de políticas de uso.
Facilita a escalabilidade e o versionamento de APIs.
Desvantagens:

Custo.
Requer configuração e manutenção adequadas.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Class: É um tipo de referência que é alocado na heap e suporta herança, polimorfismo e encapsulamento.

Struct: É um tipo de valor que é alocado na stack, não suporta herança, mas é mais eficiente em termos de memória para tipos pequenos.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET: É a versão original, proprietária e baseada em Windows do framework .NET.

.NET Core: É multiplataforma, open-source e projetado para performance e flexibilidade, permitindo execução em Windows, Linux e macOS.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST: Baseado em HTTP/1.1, utiliza JSON para comunicação, fácil de usar e amplamente suportado.

gRPC: Baseado em HTTP/2, usa protocolo de buffer para serialização, oferece maior performance e suporte a comunicação bidirecional com streaming

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Uma SPA (Single Page Application) utiliza um roteador no lado do cliente para gerenciar a navegação dentro da aplicação sem recarregar a página. URLs são manipuladas via History API do navegador.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é uma abordagem de desenvolvimento de software que une as equipes de Desenvolvimento (Dev) e Operações (Ops) para melhorar a colaboração, automação de processos, integração contínua, e entrega contínua de software. O objetivo principal do DevOps é acelerar o ciclo de desenvolvimento, melhorar a qualidade do software, e garantir uma entrega rápida e confiável de produtos e serviços.

10. Explique sobre um método agile.

**Resposta:**
Um método ágil, como o Scrum, envolve ciclos de desenvolvimento curtos chamados sprints, permitindo feedback contínuo e ajustes rápidos. O foco é na entrega incremental de software com valor para o cliente.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (Continuous Integration): Prática de integrar código continuamente em um repositório compartilhado, seguido de testes automáticos.
CD (Continuous Delivery/Deployment): Prática de automação para implantar código em produção de forma contínua.


12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker: É uma tecnologia de containerização que oferece uma ferramenta para empacotar aplicativos e suas dependências em containers. Ele inclui o Docker Engine (responsável por criar e executar containers), o Docker Hub (um repositório de imagens de containers), e outras ferramentas auxiliares.

Containers: São unidades de software que empacotam o código de um aplicativo e todas as suas dependências (bibliotecas, configurações, etc.) para que ele possa ser executado de forma consistente em qualquer ambiente. Containers são isolados do sistema operacional subjacente e dos outros containers, o que os torna leves e portáteis.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes: É um sistema de orquestração de containers de código aberto desenvolvido originalmente pelo Google. Ele automatiza a implantação, o dimensionamento e o gerenciamento de aplicativos containerizados. Kubernetes é altamente extensível e possui uma ampla comunidade de usuários e desenvolvedores.

OpenShift: É uma plataforma de orquestração de containers desenvolvida pela Red Hat que é construída sobre o Kubernetes. OpenShift oferece uma experiência "enterprise-ready" e adiciona recursos adicionais como suporte nativo a CI/CD, integração com ferramentas de segurança e conformidade, e uma interface de gerenciamento amigável.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
APIs (Interfaces de Programação de Aplicações) são peças fundamentais para a comunicação entre diferentes sistemas ou serviços. Elas permitem que diferentes aplicativos compartilhem dados e funcionalidades, sendo especialmente cruciais em arquiteturas de microserviços e sistemas distribuídos.

Vantagens:
Interoperabilidade: APIs permitem a comunicação e troca de dados entre diferentes sistemas, plataformas e linguagens de programação.
Reusabilidade de Código: A funcionalidade existente pode ser reutilizada em diferentes partes do aplicativo ou em diferentes aplicativos, reduzindo duplicação de esforço e tempo de desenvolvimento.
Escalabilidade: Com a separação de responsabilidades através de APIs, cada componente do sistema pode ser escalado independentemente.
Manutenção e Atualização Facilitadas: Alterações podem ser feitas em um serviço específico sem afetar o restante da aplicação, desde que a interface da API permaneça consistente.
Desvantagens:
Dependência e Acoplamento: Sistemas que dependem fortemente de APIs externas podem se tornar vulneráveis a falhas ou alterações nas APIs.
Latência e Desempenho: A comunicação entre APIs pode introduzir latência adicional, especialmente em ambientes distribuídos.
Segurança: As APIs expõem pontos de entrada que podem ser explorados por agentes mal-intencionados se não forem protegidas adequadamente.
Gerenciamento Complexo: Em arquiteturas grandes e distribuídas, o número de APIs pode crescer rapidamente, tornando o gerenciamento complexo.
Preocupações ao Usar APIs:
Segurança: Implementar autenticação e autorização robustas (ex.: OAuth2, JWT), usar HTTPS para criptografia de dados em trânsito, e validar todas as entradas para evitar injeções de código.
Governança: Definir políticas claras sobre versionamento, uso, limites de taxa e controles de acesso para garantir o uso seguro e eficiente das APIs.
Documentação: Manter documentação atualizada e acessível para facilitar o uso e integração das APIs por desenvolvedores.
Monitoramento e Logging: Monitorar o desempenho, uso e erros das APIs para detectar problemas rapidamente e responder a incidentes de segurança.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Para garantir um nível de segurança satisfatório ao usar APIs, é importante seguir algumas boas práticas:

Autenticação e Autorização Robustas:

Use protocolos seguros de autenticação, como OAuth2, OpenID Connect, e tokens JWT, para garantir que apenas usuários e serviços autenticados possam acessar as APIs.
Implemente autorização para assegurar que os usuários autenticados só possam acessar os recursos permitidos.
Uso de HTTPS/TLS:

Todas as comunicações de APIs devem ser criptografadas com HTTPS/TLS para proteger os dados em trânsito contra ataques de interceptação (man-in-the-middle).
Validação de Entrada e Sanitização:

Valide todas as entradas e parâmetros de solicitação para evitar ataques de injeção de SQL, injeção de comandos, e ataques de injeção de código.
Use bibliotecas e práticas seguras para evitar vulnerabilidades comuns.
Limitação de Taxa e Throttling:

Implemente limitações de taxa (rate limiting) e throttling para evitar abusos, como ataques de negação de serviço (DDoS), protegendo a infraestrutura contra sobrecargas.
Logging e Monitoramento:

Registre todas as atividades da API, incluindo falhas de autenticação, acessos não autorizados e outras atividades suspeitas, e monitore esses logs para detectar e responder rapidamente a atividades maliciosas.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Uma arquitetura de mensageria utiliza sistemas de mensagens para permitir a comunicação assíncrona entre diferentes componentes de software que podem estar em servidores diferentes. Isso é especialmente útil em ambientes de microserviços, onde serviços independentes precisam se comunicar de maneira eficiente e desacoplada.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
A Estratégia SAGA é um padrão de design usado para gerenciar transações distribuídas em uma arquitetura de microserviços. Como as transações tradicionais de banco de dados (ACID) não se aplicam bem em ambientes distribuídos, SAGA coordena uma série de operações de compensação para garantir a consistência dos dados.

Como Funciona:
Transações Longas Divididas em Passos Menores: Uma SAGA divide uma transação longa em várias transações menores que são coordenadas através de uma série de etapas (ou "compensações").
Compensações: Cada operação tem uma compensação correspondente que desfaz a operação caso ocorra um erro, garantindo que o sistema volte a um estado consistente.
Padrões de SAGA:
Coreografia: Cada serviço envolve sua própria lógica de compensação e sabe quando iniciar a próxima etapa, dependendo dos eventos emitidos por outros serviços.
Orquestração: Um serviço central (o orquestrador) coordena a execução de todos os passos da SAGA e toma as decisões de fluxo.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma prática de DevOps que utiliza repositórios Git como fonte única de verdade para as operações de infraestrutura e aplicações. No contexto do Kubernetes, GitOps permite gerenciar o estado desejado do cluster Kubernetes e suas aplicações de forma declarativa.

Como Funciona:
Repositório Git como Fonte de Verdade: O repositório Git contém todos os arquivos de configuração e manifests do Kubernetes que definem o estado desejado da infraestrutura e das aplicações.
Automação de Deploy: Ferramentas de GitOps (como ArgoCD ou Flux) monitoram o repositório Git em busca de alterações e automaticamente aplicam essas mudanças ao cluster Kubernetes.
Feedback e Rollbacks: As ferramentas de GitOps também monitoram o estado atual do cluster em relação ao estado desejado definido no Git, fornecendo feedback imediato sobre mudanças e permitindo rollbacks automatizados em caso de falhas.
