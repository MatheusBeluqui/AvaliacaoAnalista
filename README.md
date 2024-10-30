# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

- Codebase: Uma aplicação deve ter uma única codebase, que é versionada e pode ser implantada em diferentes ambientes (desenvolvimento, teste, produção). Isso garante consistência em todo o ciclo de vida do desenvolvimento e facilita a colaboração entre desenvolvedores.

- Dependencies: Todas as dependências da aplicação devem ser explicitamente declaradas e gerenciadas. Isso é crucial para garantir que a aplicação funcione da mesma forma em todos os ambientes. Utilizar gerenciadores de pacotes (como npm, pip, etc.) para gerenciar bibliotecas e pacotes ajuda a evitar problemas de incompatibilidade.

- Config: As configurações da aplicação (como senhas, variáveis de ambiente, URLs de serviço, etc.) devem ser separadas do código e armazenadas em variáveis de ambiente. Isso permite que a mesma codebase seja usada em diferentes ambientes, evitando a necessidade de modificar o código para ajustes de configuração.

- Backing Services: Serviços de suporte (como bancos de dados, sistemas de fila, serviços de cache, etc.) devem ser tratados como recursos anexados. A aplicação deve ser capaz de trocar um serviço por outro sem necessidade de alteração do código. Isso promove flexibilidade e escalabilidade, permitindo que os desenvolvedores mudem os serviços conforme necessário.

- Build, Release, Run: O processo de construção, lançamento e execução da aplicação deve ser separado. O build é o processo de compilar e gerar os artefatos da aplicação. O release é o processo de empacotar o build com a configuração apropriada. O run é a execução da aplicação em produção. Essa separação permite um controle mais granular sobre cada fase e facilita a implantação contínua.

- Processes: A aplicação deve ser executada como um ou mais processos sem estado. Isso significa que cada instância do aplicativo deve ser independente e capaz de ser iniciada, parada ou escalada de forma dinâmica. Qualquer estado deve ser armazenado em serviços externos (como bancos de dados ou caches), o que facilita o escalonamento horizontal e a resiliência da aplicação.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

- Frontend (Presentation Layer): Responsável pela interação com o usuário e pela exibição de informações.

- Backend (Business Logic Layer, Application Layer) Contém as regras e processos que definem como os dados podem ser criados, armazenados e modificados.

- Data (Data Access Layer, Database Layer): Gerencia a comunicação com o banco de dados e a persistência dos dados.

- Services (Integration Layer): Conecta diferentes sistemas e serviços, permitindo a comunicação entre eles.

- Infrastructure: Inclui aspectos como servidores, rede, armazenamento e outras tecnologias subjacentes que suportam a aplicação.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

- Arquitetura SOA: é uma abordagem de design de software que estrutura aplicações como um conjunto de serviços interconectados. Esses serviços são reutilizáveis e podem ser usados por diferentes aplicações dentro de uma organização.

- Arquitetura Microserviços: A arquitetura de microserviços divide uma aplicação em pequenos serviços independentes, cada um responsável por uma única funcionalidade específica e se comunicando entre si via APIs.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

- O API Management tem como objetivo gerenciar, monitorar e proteger APIs em uma arquitetura de serviços distribuídos. Ele atua como uma camada intermediária entre os consumidores de APIs (como aplicações e serviços) e os provedores (como microserviços ou sistemas backend), facilitando a interação e garantindo a segurança, a escalabilidade e a governança das APIs.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

A principal diferença entre struct e class é que a struct é um tipo de valor, enquanto a class é um tipo de referência:

- Semântica: As classes usam semântica de referência, enquanto as structs usam semântica de valor.
- Atribuição: Quando uma variável de uma struct é atribuída a outra, o valor é copiado. Já com as classes, uma variável é apenas uma referência a um objeto.
- Performance: As structs são mais eficientes em termos de desempenho quando passadas como argumentos ou copiadas.
- Herança: As classes suportam herança, permitindo que você crie uma nova classe baseada em outra existente. Structs, por outro lado, não suportam herança.

A struct é mais apropriada para armazenar somente dados, enquanto a class é mais apropriada para armazenar dados e seus respectivos métodos.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

A principal diferença entre .NET e .NET Core é a portabilidade e o suporte a múltiplas plataformas.
- .NET: Exclusivo para Windows
- .NET Core: Multiplataforma

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

- Protocolo:

    REST: Baseado em HTTP/HTTPS, utiliza métodos como GET, POST, PUT e DELETE.
    gRPC: Baseado em HTTP/2, permitindo comunicação bidirecional e multiplexação de chamadas.

- Formato de Dados:

    REST: Normalmente utiliza JSON ou XML como formatos de troca de dados.
    gRPC: Utiliza Protocol Buffers (protobuf), que são mais compactos e eficientes em termos de tamanho e velocidade de serialização/deserialização.

- Modelo de Comunicação:

    REST: É stateless, ou seja, cada requisição é independente e não mantém estado entre elas.
    gRPC: Suporta comunicação bidirecional e streaming, permitindo enviar e receber múltiplas mensagens em uma única conexão.

- Desempenho:

    REST: Geralmente mais simples, mas pode ser menos eficiente em termos de performance devido ao uso de texto (JSON/XML) e à sobrecarga do HTTP/1.1.
    gRPC: Mais eficiente em termos de desempenho devido ao uso de binário e ao HTTP/2, permitindo latência reduzida e maior throughput.

- Usabilidade:

    REST: Mais fácil de usar e integrar com navegadores e aplicações web, devido à sua simplicidade e uso de formatos textuais.
    gRPC: Requer mais configuração e entendimento de Protocol Buffers, mas oferece melhor suporte para microserviços e sistemas complexos.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

O gerenciamento de rotas em uma SPA permite a navegação entre diferentes partes da aplicação sem recarregar a página. Ele funciona da seguinte maneira:

- API de Histórico: Utiliza a API de histórico do navegador para atualizar a URL sem novas requisições ao servidor.
- Roteadores: Um roteador associa URLs a componentes específicos, renderizando o componente correspondente quando a URL muda.
- Manipulação de Eventos: Clica em links ou botões dispara eventos que o roteador intercepta, atualizando a URL e o conteúdo da página sem recarregá-la.
- Renderização Condicional: A aplicação exibe conteúdo com base na rota ativa, monitorando a URL atual.
- Recuperação de Dados: Busca dados de APIs conforme necessário para preencher as páginas.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps é uma abordagem que integra o desenvolvimento de software (Dev) e as operações de TI (Ops) com o objetivo de melhorar a colaboração e a eficiência entre equipes, promovendo um ciclo de vida de desenvolvimento mais ágil e contínuo. 

10. Explique sobre um método agile.

**Resposta:**

Um dos métodos agile seria o Scrum, ele um framework que organiza o trabalho em ciclos curtos e iterativos, chamados de sprints, que geralmente duram de duas a quatro semanas. O objetivo é entregar incrementos de produto em cada sprint.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

- Integração Contínua (CI)
CI é a prática de integrar código de desenvolvedores em um repositório compartilhado várias vezes ao dia. Cada integração é verificada automaticamente por meio de testes, permitindo que os problemas sejam detectados e corrigidos rapidamente.

- Entrega Contínua (CD)
CD é a extensão da CI, que garante que o software possa ser implantado em produção a qualquer momento. Isso envolve a automação de processos de testes e deploy, garantindo que novos recursos e correções possam ser entregues de forma rápida e confiável.

- Ferramentas:
Azure DevOps, Jenkins, GitLab CI/CD, GitHub Actions

12. Qual a diferença entre Docker e Containers.

**Resposta:**

- Docker: É uma plataforma que permite criar e gerenciar containers.
- Containers: São instâncias isoladas de aplicações que incluem tudo o que é necessário para sua execução.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Kubernetes é a base de orquestração de containers, enquanto OpenShift é uma distribuição do Kubernetes com recursos adicionais focados em facilitar o uso e aumentar a segurança.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

Vantagens das APIs:
- Integração: Facilita a comunicação entre sistemas e a troca de dados.
- Reutilização: Permite que funcionalidades sejam usadas em várias aplicações, economizando tempo.
- Escalabilidade: Facilita a adição de novos serviços sem impactar o sistema existente.
- Desacoplamento: Permite desenvolvimento independente de front-end e back-end.
- Flexibilidade: Possibilita a escolha de tecnologias adequadas para diferentes partes do sistema.

Desvantagens das APIs:
- Complexidade: Adiciona complexidade ao sistema, especialmente com muitos serviços.
- Segurança: Vulnerabilidades podem surgir se a proteção não for adequada.
- Desempenho: Chamadas de API podem causar latência.
- Gerenciamento de Versões: Mudanças na API podem quebrar integrações existentes.
- Manutenção: Exige monitoramento e atualizações contínuas.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Autenticação e Autorização: Utilizar protocolos robustos, como OAuth 2.0 e OpenID Connect, para garantir que apenas usuários e sistemas autorizados possam acessar a API.

Criptografia: Implementar HTTPS para proteger dados em trânsito e criptografar informações sensíveis armazenadas, evitando que dados sejam interceptados durante a transmissão.

Validação de Entrada: Sempre validar todas as entradas da API para prevenir ataques de injeção, como SQL Injection, e outros tipos de exploração.

Uso de API Gateway: Utilizar um API Gateway para centralizar a segurança, permitindo a implementação de autenticação, autorização e controle de tráfego de forma mais eficaz.

Registro e Monitoramento: Manter logs de acessos e erros para monitorar atividades suspeitas e responder rapidamente a incidentes de segurança.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Uma arquitetura de mensagerias facilita a comunicação entre componentes de um sistema ao permitir a troca assíncrona de mensagens, promovendo desacoplamento, escalabilidade e resiliência na troca de informações.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

A estratégia SAGA em arquitetura de microserviços é um padrão de gerenciamento de transações que busca garantir a consistência de dados em um ambiente distribuído. Em vez de uma única transação que abrange vários serviços (o que pode ser complicado em microserviços), a SAGA divide a transação em uma série de etapas menores, cada uma representando uma operação em um serviço diferente.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

GitOps é uma prática que utiliza Git como a única fonte de verdade para a configuração e o estado desejado de um sistema, especialmente em ambientes de Kubernetes. Essa abordagem integra o desenvolvimento e a operação, promovendo a automação e a consistência na entrega de aplicações.