# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

- **Codebase:** Um aplicativo deve ser mantido em um repositório de controle de versão, como Git, para rastrear todas as alterações no código-fonte ao longo do tempo. Isso permite que a equipe de desenvolvimento colabore de forma eficaz e garanta que todas as alterações sejam rastreadas e revertidas, se necessário, facilitando a implantação e a manutenção do aplicativo.

- **Dependencies:** Todas as dependências de um aplicativo devem ser explicitamente declaradas e isoladas do sistema operacional subjacente. Isso garante que o aplicativo seja executado de forma consistente em diferentes ambientes e evita conflitos de dependência.

- **Config:** A configuração de um aplicativo deve ser armazenada em variáveis de ambiente ou em um arquivo de configuração externo. Isso permite que a configuração seja facilmente alterada sem a necessidade de recompilar o aplicativo e garante que as configurações sensíveis, como chaves de API, sejam mantidas em segredo.

- **Backing services:** Um aplicativo normalmente se conecta a serviços externos, como bancos de dados, filas de mensagens e caches, a existencia de serviços de backup permite que os serviços sejam facilmente substituídos ou escalados sem afetar o aplicativo.

- **Build, release, run:** Um aplicativo deve ser construído, lançado e executado de forma consistente em todos os ambientes. Isso garante que o aplicativo seja implantado de forma confiável e repetível, sem a necessidade de intervenção manual.

- **Processes:** Um aplicativo deve ser executado como um ou mais processos independentes. Isso permite que o aplicativo seja escalado horizontalmente e tolerante a falhas, sem depender de um único servidor.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Um software normalmente é divido em, pelo menos, 3 camadas: UI (User Interface), Lógica de Negócio e Acesso a Dados.

- **UI (User Interface)** É a camada que interage com o usuário, seja por meio de uma interface gráfica, linha de comando ou API. É responsável por receber as entradas do usuário e exibir as saídas.

- **Lógica de Negócio:** É a camada que contém as regras de negócio da aplicação. É responsável por processar as entradas recebidas da camada de interface com o usuário e gerar as saídas esperadas.

- **Acesso a Dados:** É a camada que interage com o banco de dados ou qualquer outro meio de armazenamento de dados. É responsável por persistir e recuperar os dados necessários para a aplicação.

Além dessas camadas, um software pode ter outras camadas, como a camada de Segurança, a camada de Infraestrutura e a camada de Apresentação.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Ambas as arquiteturas são baseadas em serviços, mas diferem em alguns aspectos:

- **Arquitetura SOA (Service-Oriented Architecture):** É uma abordagem de arquitetura de software que se baseia no conceito de serviços. Cada serviço é responsável por uma parte específica da lógica de negócio e pode ser reutilizado por outras aplicações. A arquitetura SOA é caracterizada pela sua flexibilidade e reusabilidade além de ser consideravelmente mais simples de se implementar do que a arquitetura de microsserviços.

- **Arquitetura de Microserviços:** Cada microsserviço é uma aplicação independente e autônoma, que se comunica com outros microsserviços por meio de APIs. A arquitetura de microsserviços é caracterizada pela sua escalabilidade e resiliência, mas nem sempre é a escolha certa para todas as aplicações, pois pode aumentar a complexidade e o custo de manutenção.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

Outro termo que desconhecia, com base no que pesquisei, o API Management é uma prática de gerenciamento de APIs que visa facilitar o desenvolvimento, a implantação e a manutenção de APIs em ambientes distribuídos. Ele fornece recursos de dashboard para monitorar o desempenho das APIs, controle de acesso para proteger as APIs de acessos não autorizados e ferramentas de documentação para facilitar a integração com as APIs.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Por mais que parecidas, as classes e as structs tem algumas diferenças importantes:

- **Class:** É um tipo de referência que representa um conjunto de dados e comportamentos relacionados, as classes são mais adequadas para tipos de dados complexos e grandes, como objetos de domínio e componentes de software.

- **Struct:** É um tipo de valor que representa um conjunto de dados relacionados, as structs são mais adequadas para tipos de dados pequenos e simples, como números inteiros, datas e coordenadas.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

O .NET Framework é uma plataforma de desenvolvimento de software da Microsoft que suporta a criação e execução de aplicativos Windows, Web e Mobile. Ele é uma plataforma madura e amplamente utilizada, mas tem algumas limitações, como a dependência do Windows e a falta de suporte para contêineres e sistemas operacionais não-Windows.

Em contrapartida o .NET Core é uma versão mais leve e modular do .NET Framework que suporta a criação e execução de aplicativos multiplataforma, não obrigatóriamente requerendo Windows e podendo ser utilizado em sistemas Linux e macOS. Ele é mais rápido, mais leve e mais flexível do que o .NET Framework, e é amplamente utilizado para o desenvolvimento de aplicativos modernos e escaláveis.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

Sendo dois dos protocolos de comunicação mais populares para serviços web, REST e gRPC têm algumas diferenças importantes:

- **REST (Representational State Transfer):** É um estilo de arquitetura de software que define um conjunto de restrições para a criação de serviços web. Ele é baseado no uso de recursos, identificados por URLs, e opera sobre o protocolo HTTP. REST é amplamente utilizado e fácil de entender, mas pode ser lento e ineficiente para comunicações de alto desempenho.

- **gRPC (gRPC Remote Procedure Call):** É um framework de comunicação de código aberto desenvolvido pela Google que permite a comunicação entre serviços usando chamadas de procedimento remoto. Ele é baseado no protocolo HTTP/2 e usa o formato de serialização de dados protobuf. gRPC é mais rápido e eficiente do que REST, mas pode ser mais complexo de implementar e depurar.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

O gerenciamento de rotas em uma Single Page Application (SPA) é responsável por mapear URLs para componentes específicos da aplicação e atualizar a interface do usuário de acordo com a rota atual. Isso permite que os usuários naveguem pela aplicação sem recarregar a página inteira.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps é uma cultura e prática de desenvolvimento de software que visa integrar as equipes de desenvolvimento e operações para melhorar a colaboração, a comunicação e a eficiência no ciclo de vida do software. Ele se baseia em princípios como automação, colaboração, integração contínua e entrega contínua para acelerar o desenvolvimento e a implantação de software.

10. Explique sobre um método agile.

**Resposta:**

Um dos métodos ágeis mais populares é o Scrum, que é baseado em ciclos de desenvolvimento curtos chamados sprints. Cada sprint tem uma duração fixa, geralmente de 2 a 4 semanas, e é composto por várias etapas, como planejamento, desenvolvimento, revisão e retrospectiva. O Scrum é caracterizado pela sua flexibilidade, transparência e foco na entrega de valor ao cliente.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

CI (Integração Contínua) e CD (Entrega Contínua) são práticas de desenvolvimento de software que visam automatizar o processo de construção, teste e implantação de código. CI envolve a integração frequente do código de vários desenvolvedores em um repositório compartilhado, enquanto CD envolve a entrega automatizada de código para um ambiente de produção.

12. Qual a diferença entre Docker e Containers.

**Resposta:**

Docker é uma plataforma de código aberto que facilita a criação, implantação e execução de aplicativos em contêineres. Os contêineres são unidades de software que empacotam o código e suas dependências em um único pacote, tornando-os portáteis e fáceis de implantar em diferentes ambientes.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Desconheço a diferença entre Kubernetes e Openshift, com base no que pesquisei, Kubernetes é uma plataforma de orquestração de contêineres de código aberto desenvolvida pelo Google, enquanto o OpenShift é uma plataforma de contêineres baseada no Kubernetes desenvolvida pela Red Hat. O OpenShift adiciona recursos adicionais, como suporte a desenvolvimento de aplicações, gerenciamento de contêineres e segurança, para facilitar a implantação e operação de aplicativos em contêineres.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

APIs (Interfaces de Programação de Aplicativos) são uma maneira eficaz de permitir que diferentes sistemas e aplicativos se comuniquem entre si. Elas têm várias vantagens, como a reutilização de código, a separação de preocupações e a interoperabilidade entre plataformas. No entanto, as APIs também têm algumas desvantagens, como a necessidade de documentação e a possibilidade de exposição de dados sensíveis.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Podemos garantir um nível de segurança satisfatório no uso de APIs adotando as seguintes práticas:

- **Autenticação:** Exigir que os usuários autentiquem-se antes de acessar a API, utilizando tokens de acesso, chaves de API ou outros mecanismos de autenticação.

- **Autorização:** Limitar o acesso dos usuários a recursos específicos da API com base em suas permissões e funções, como limitar o acesso de leitura e escrita a determinados recursos.

- **Criptografia:** Proteger os dados transmitidos entre o cliente e o servidor com criptografia, como HTTPS, evitando assim que os dados sejam interceptados ou alterados.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Uma arquitetura de mensageria é um padrão de arquitetura de software que permite que os sistemas se comuniquem de forma assíncrona por meio de mensagens. Isso permite que os sistemas sejam desacoplados e escalados independentemente, tornando-os mais flexíveis e resilientes.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

O padrão SAGA é uma maneira de gerenciar a consistência de dados entre microsserviços em cenários de transação distribuída. Uma saga é uma sequência de transações que atualiza cada serviço e publica uma mensagem ou evento para disparar a próxima etapa de transação.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

Não possuo conhecimento sobre o assunto, com base no que pesquisei, GitOps é uma prática de desenvolvimento de software que se baseia no uso do Git e do Kubernetes para automatizar o processo de implantação de aplicativos em contêineres. Ele permite que as equipes de desenvolvimento gerenciem a infraestrutura como código e implementem alterações de forma segura e confiável.
