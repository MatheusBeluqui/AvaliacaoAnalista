# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
1. Codebase:
A ideia do Codebase é ter um único repositório para todo o código de uma aplicação. Isso significa que o código-fonte deve ser versionado e gerenciado através de um sistema de controle de versão, como Git. Ter uma base de código única facilita o rastreamento de alterações e a colaboração entre os desenvolvedores, além de garantir que todas as instâncias da aplicação utilizem o mesmo código. Um erro que deve ser evitado é colocar mais de uma aplicação no mesmo repositório, pois isso irá dificultar o rastreamento, análise de código, correção de problemas, gerar versões das aplicações, voltar versões, pois ao voltar uma alteração de uma aplicação você será obrigado a voltar mais do que necessário ou terá que reverver partes específicas do código o que pode gerar erros e conflitos difíceis de serem resolvidos.
Para permitir que a mesma base código seja publicada em diferentes ambientes podemos utilizar variáveis de ambientes ou arquivos de configuração que serão alterados de acordo com o fluxo de publicação. É importante resaltar que mesmo tendo a mesma base de código é possível publicar diferentes versões para situações específicas, seja para testar uma versão ou para fazer o rollback de alguma feature.

2. Dependencies:
Todas as dependências de uma aplicação devem ser declaradas de forma explícita. Isso significa que qualquer biblioteca ou framework necessário para a aplicação deve ser listado e gerenciado através de arquivos de configuração. Dessa forma, a aplicação não depende de pacotes instalados globalmente no ambiente de execução, promovendo maior consistência e previsibilidade em diferentes ambientes. Isso ajuda no processo de configuração da estação de trabalho e publicação. Em vez de ter que instalar várias libs que um projeto precisa, o próprio gerenciador de pacotes faz a instalação, gerenciamento de conflitos e suas dependências com um único comando.

1. Config:
A configuração da aplicação deve ser separada do código e armazenada no ambiente, normalmente isso é feito na esteira que faz a publicação. Isso permite que você modifique configurações, como variáveis de ambiente e parâmetros de conexão, sem alterar o código da aplicação. Manter a configuração fora do código facilita a adaptação da aplicação para diferentes ambientes (desenvolvimento, teste, produção) sem necessidade de reimplementações.

1. Backing Services:
Os serviços auxiliares, como bancos de dados, sistemas de cache e sistemas de mensagens, devem ser tratados como recursos anexados. Isso significa que eles podem ser alterados ou atualizados sem precisar modificar a aplicação principal. A aplicação deve se conectar a esses serviços de forma modular, possibilitando a substituição ou alteração desses serviços sem impacto direto no código da aplicação, importante lembrar que para que exista essa compatibilidade deve levar em consideração a versão e as configurações utilizadas para cada serviço auxiliar.

1. Build, Release, Run:
O ciclo de vida da aplicação deve ser dividido em três fases distintas: construção (build), lançamento (release) e execução (run). A fase de construção envolve a criação dos artefatos necessários, a fase de lançamento prepara esses artefatos para o ambiente de produção e a fase de execução é onde a aplicação realmente roda. Separar esses processos permite um controle mais rigoroso e previsível sobre como a aplicação é preparada e implantada.

1. Processes:
A aplicação deve ser executada como uma série de processos sem estado. Isso significa que cada instância da aplicação deve ser independente e não depender de dados locais ou estado mantido na memória. Em vez disso, qualquer persistência de dados deve ser feita em sistemas externos, como bancos de dados. Isso ajuda a garantir que a aplicação possa ser escalada facilmente e mantenha a integridade dos dados. Caso seja necessário manter dados dos usuários na memória do processo é melhor utilizar um datastore que possui data de expiração.

1. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
Apresentação, Aplicação, Negócio, Acesso de dados e Infraestrutura

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
A Arquitetura Orientada a Serviços (SOA) e a Arquitetura de Microserviços possuem várias diferenças em seu design e aplicação. SOA tende a ter serviços mais reutilizáveis, projetados para serem usados por várias aplicações dentro de uma organização, frequentemente utilizando protocolos como SOAP e frequentemente dependendo de um ESB (Enterprise Service Bus) para comunicação e integração. Já microserviços são menores e mais focados, cada um responsável por uma única funcionalidade específica, utilizando protocolos leves como HTTP/REST e facilitando a comunicação direta entre serviços sem a necessidade de um ESB.

Enquanto SOA pode apresentar um certo grau de acoplamento devido à dependência de um ESB, os microserviços são altamente desacoplados e independentes, permitindo que cada serviço seja desenvolvido, implantado e escalado de forma autônoma. A implementação de SOA envolve tecnologias específicas e requer uma governança robusta para gerenciar a comunicação e integração entre serviços, enquanto os microserviços se beneficiam de tecnologias modernas como contêineres (Docker) e orquestradores (Kubernetes), e são frequentemente acompanhados por práticas DevOps para integração e entrega contínuas.

Os ciclos de vida dos serviços em SOA costumam ser mais longos e a integração contínua pode ser mais complexa. Em comparação, os microserviços são desenvolvidos e implantados em ciclos mais curtos e iterativos, aproveitando práticas DevOps para maior agilidade. SOA é geralmente mais adequado para grandes corporações com necessidades complexas de integração e reutilização, enquanto microserviços são ideais para aplicações modernas que requerem flexibilidade, agilidade e escalabilidade.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Com o crescimento da quantidade de APIs dentro de uma uma organização, é necessário adotar um mecanismo de gerenciamento. 
O objetivo do API Management na arquitetura de serviços distribuídos é fornecer uma camada de controle e gerenciamento centralizada para todas as APIs de uma empresa ou separada por contexto. 
Ele facilita a criação, manutenção, segurança e monitoramento de APIs, além de permitir a orquestração e integração entre diferentes serviços distribuídos. As vantagens incluem a melhoria da segurança através do controle de acesso centralizado e proteção contra ameaças, além de oferecer ferramentas para monitoramento e análise do uso das APIs. O API Management centraliza o gerenciamento das APIs, facilita a documentação e a criação de portais para desenvolvedores, e permite a aplicação de políticas de uso como limites de taxa e gerenciamento de cotas. Também facilita a transformação de dados entre diferentes formatos e a orquestração de múltiplos serviços em fluxos de trabalho complexos.

Por outro lado, o API Management pode adicionar complexidade ao sistema devido à necessidade de configuração e manutenção adicionais, além de representar um custo significativo tanto em termos de licenciamento quanto de implementação. Ele também pode introduzir latência nas requisições e criar uma dependência da plataforma de gerenciamento, potencialmente resultando em um ponto único de falha e risco de lock-in com um fornecedor específico. A decisão de implementar um API Management deve considerar as necessidades específicas do sistema, o volume de APIs e o ambiente operacional, equilibrando os benefícios de segurança e gerenciamento centralizado com os custos e desafios adicionais que ele pode trazer.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Em C#, structs e classes são dois tipos de estruturas de dados com diferenças significativas. Structs são tipos de valor, alocados na stack, e copiados inteiramente quando atribuídos. Eles são ideais para pequenas estruturas de dados com comportamento simples. Classes, por outro lado, são tipos de referência, alocados no heap, e copiam apenas referências quando atribuídos. Elas são mais adequadas para objetos complexos que necessitam de herança e possuem um ciclo de vida mais longo. Structs não suportam herança (exceto para interfaces) e são geralmente imutáveis, enquanto classes suportam herança, são mutáveis e permitem a criação de hierarquias de objetos. A escolha entre usar structs ou classes depende da necessidade de desempenho e complexidade do objeto no seu aplicativo.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET e .NET Core são duas plataformas de desenvolvimento distintas com diferenças importantes em termos de arquitetura, objetivos e funcionalidades. O .NET Framework é uma plataforma proprietária da Microsoft, projetada para funcionar exclusivamente em Windows, com uma arquitetura monolítica fortemente integrada ao sistema operacional. Ele é amplamente utilizado em ambientes corporativos tradicionais para desenvolver aplicações desktop, web e serviços backend no Windows. Em contraste, .NET Core é uma plataforma open-source e multiplataforma, que pode ser executada em Windows, macOS e Linux. Desenvolvido para atender às necessidades modernas de desenvolvimento, .NET Core é modular, leve e ideal para aplicações que exigem alta performance, flexibilidade e portabilidade. Enquanto o .NET Framework é otimizado para aplicações Windows e oferece bom desempenho nesse ambiente, .NET Core é geralmente mais rápido, eficiente e escalável, sendo adequado para arquiteturas modernas como microservices e aplicações distribuídas.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
GRPC é uma implementação da Google para o RPC (Remote procedure Call), existem outras implementações.
REST e GRPC podem ser considerados primos e utilizam o protocolo http para comunicação, porém como as chamadas REST eram lentas para alguns propósitos, foi criado o GRPC
REST e GRPC são abordagens diferentes para a comunicação entre serviços em sistemas distribuídos. REST, que utiliza HTTP/HTTPS e geralmente trabalha com JSON ou XML, é amplamente suportado e fácil de integrar em diversas plataformas, sendo ideal para aplicações web e serviços onde a compatibilidade e simplicidade são importantes. Em contraste, gRPC utiliza HTTP/2 e Protocol Buffers para maior eficiência, oferecendo menor latência e suporte a comunicação bidirecional e streaming. gRPC é mais adequado para sistemas que requerem alta performance e baixa latência, como comunicações internas entre microservices. Enquanto REST é mais verboso e independente de estado, gRPC utiliza contratos fortemente tipados, permitindo a geração automática de código. A escolha entre REST e gRPC deve considerar os requisitos específicos do projeto, como desempenho, compatibilidade e complexidade.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O gerenciamento de rotas em uma SPA (Single Page Application) permite a navegação entre diferentes seções da aplicação sem recarregar a página inteira. 
Utilizando mecanismos como o hash-based routing, que usa o símbolo "#" na URL, ou a History API do HTML5, a aplicação pode alterar o conteúdo exibido sem novas requisições HTTP completas. O roteador é o componente central que define e gerencia essas rotas, mapeando URLs para componentes específicos. A navegação pode ser feita por links ou programaticamente, com o roteador interceptando a ação e atualizando a URL conforme necessário, renderizando o novo componente correspondente. Isso proporciona uma navegação rápida e uma experiência de usuário fluida, semelhante a uma aplicação desktop. No caso do roteamento baseado na History API, é importante configurar o servidor para tratar todas as rotas não reconhecidas, retornando a página inicial da aplicação para permitir que o roteador da SPA faça o restante do trabalho.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é uma abordagem que une desenvolvimento de software e operações de TI para melhorar a colaboração e a eficiência na entrega de aplicações. O objetivo é acelerar o ciclo de vida do desenvolvimento, desde a criação até a produção, promovendo uma integração contínua e uma entrega contínua de software. Com práticas como automação, monitoramento e feedback rápido, DevOps busca otimizar processos, reduzir falhas e melhorar a qualidade do software. A colaboração entre equipes de desenvolvimento e operações é central para garantir que o software seja desenvolvido e implantado de forma mais rápida e confiável.

10. Explique sobre um método agile.

**Resposta:**
Scrum é um framework ágil usado para gerenciar projetos de desenvolvimento de software de forma colaborativa e eficiente. Ele organiza o trabalho em ciclos chamados sprints, que duram entre duas a quatro semanas. Durante cada sprint, a equipe trabalha em um conjunto específico de tarefas previamente definidas. Ao final de cada sprint, há uma revisão para mostrar o que foi realizado e uma retrospectiva para avaliar o processo e identificar melhorias. Os principais papéis em Scrum são o Product Owner, que define e prioriza os requisitos do projeto; o Scrum Master, que facilita o processo e resolve problemas; e a equipe de desenvolvimento, que realiza o trabalho técnico. Scrum foca em comunicação contínua, adaptação rápida e entrega constante de valor ao cliente.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (Integração Contínua) e CD (Entrega Contínua) são práticas que ajudam a manter a qualidade do software e a acelerar o ciclo de desenvolvimento.

A Integração Contínua envolve a integração regular de código no repositório principal, geralmente várias vezes ao dia. Isso ajuda a identificar problemas rapidamente e a garantir que o código funcione bem com o restante da aplicação. Já a Entrega Contínua vai um passo além, automatizando o processo de liberação do código para produção, permitindo que as atualizações sejam entregues com mais frequência e de forma mais confiável.

Ferramentas comuns para CI e CD incluem Jenkins, que é amplamente utilizado para automatizar a integração e entrega de código; GitLab CI/CD, que oferece integração contínua e entrega contínua dentro de uma única plataforma; e CircleCI, conhecida por sua facilidade de uso e rapidez. Outras ferramentas como Travis CI e Bamboo também são populares e ajudam a gerenciar esses processos, melhorando a eficiência e a qualidade do software.

No Azure, há várias ferramentas para gerenciar a integração e entrega contínua. O Azure DevOps oferece um conjunto completo de ferramentas para automatizar a construção, teste e implantação de software, incluindo o Azure Pipelines, que facilita a criação de pipelines para integração e entrega contínuas. O GitHub Actions, integrado ao GitHub, permite criar workflows personalizados diretamente em repositórios para automatizar processos de CI/CD. Azure Repos fornece controle de versão para gerenciar o código-fonte, enquanto o Azure Pipelines suporta a automação de builds e deploys em diversos ambientes, incluindo contêineres. O Azure Kubernetes Service (AKS) e o Azure Container Registry (ACR) ajudam na automação de construção e implantação de aplicações containerizadas. Essas ferramentas ajudam a otimizar o desenvolvimento de software ao automatizar e integrar processos.

12. Qual a diferença entre Docker e Containers.

**Resposta:**

Docker é uma plataforma que facilita a criação, distribuição e execução de contêineres. Contêineres são unidades leves e portáteis que empacotam uma aplicação e suas dependências, garantindo que ela funcione da mesma forma em diferentes ambientes. A principal diferença é que Docker é uma ferramenta que usa contêineres para empacotar e gerenciar aplicações. Em outras palavras, contêineres são o conceito e a tecnologia subjacente, enquanto Docker é uma solução específica para trabalhar com essa tecnologia. Docker fornece uma interface e um conjunto de ferramentas para criar, distribuir e gerenciar contêineres de forma eficiente.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes e OpenShift são plataformas para gerenciar contêineres, mas têm diferenças. 
Kubernetes é um sistema open-source de orquestração de contêineres que fornece uma base robusta para gerenciar aplicações em larga escala, mas pode exigir configurações e integrações adicionais para funcionalidades avançadas. 
OpenShift, desenvolvido pela Red Hat, é uma distribuição do Kubernetes que inclui uma interface mais amigável, ferramentas integradas para desenvolvimento e segurança, e suporte empresarial. OpenShift tem versões pagas, como o OpenShift Container Platform e o OpenShift Online, que oferecem suporte e recursos adicionais, enquanto a versão gratuita, OpenShift Origin, é voltada para aprendizado e projetos pessoais. A principal diferença é que OpenShift vem com funcionalidades e suporte adicionais, facilitando o uso e a gestão de contêineres em ambientes corporativos.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

APIs (Interfaces de Programação de Aplicações) são ferramentas essenciais para conectar diferentes sistemas e serviços. Entre suas vantagens, destacam-se a facilidade de integração entre sistemas distintos, a capacidade de escalar funcionalidades de forma modular e a promoção da reutilização de código. No entanto, as desvantagens incluem a complexidade na gestão de múltiplas APIs, problemas de segurança se não forem bem protegidas, e a possibilidade de dependência entre sistemas que pode causar problemas se uma API falhar.

Ao escolher usar APIs, é importante considerar a segurança, garantindo que as APIs estejam protegidas contra acesso não autorizado e ataques. A documentação clara e atualizada também é crucial para facilitar a integração e manutenção. Além disso, é necessário garantir que a API seja bem projetada para atender às necessidades atuais e futuras, evitando problemas com a escalabilidade e a manutenção.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Para garantir um nível de segurança satisfatório no uso de APIs, é essencial adotar algumas práticas-chave. Primeiro, é importante usar autenticação robusta, como OAuth, para garantir que apenas usuários autorizados possam acessar a API. Além disso, implementar criptografia, como HTTPS, protege os dados durante a transmissão. As APIs devem ser projetadas com controle de acesso adequado, limitando as permissões de acordo com a necessidade de cada usuário. A validação e a sanitização de entradas ajudam a prevenir ataques de injeção e outros tipos de exploração. Monitorar e registrar o uso da API permite identificar e responder rapidamente a atividades suspeitas. Essas medidas ajudam a proteger a API contra ameaças e a garantir a integridade e confidencialidade dos dados.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Uma arquitetura de mensagerias serve para facilitar a comunicação entre diferentes sistemas e aplicações. Ela permite que mensagens sejam enviadas e recebidas de forma assíncrona, ajudando a desacoplar componentes e melhorar a escalabilidade e a resiliência do sistema. Ao usar uma fila de mensagens ou um sistema de mensageria, as aplicações podem trocar informações de forma eficiente, sem precisar estar diretamente conectadas, o que permite uma integração mais flexível e reduz a dependência entre elas. Isso é útil para processar tarefas em background, balancear carga e garantir que mensagens importantes não sejam perdidas, mesmo que um dos sistemas esteja temporariamente fora de serviço.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
A estratégia SAGA é usada em arquiteturas de microservices para gerenciar transações distribuídas e garantir a consistência de dados entre diferentes serviços. 
Em vez de usar uma transação única e global, que pode ser complexa e difícil de gerenciar, a SAGA divide a transação em várias etapas menores, cada uma sendo um microserviço separado.

Cada etapa executa uma ação e, se necessário, reverte suas mudanças em caso de falha, usando compensações. Isso garante que, mesmo se uma parte da transação falhar, o sistema pode manter a integridade dos dados e continuar funcionando sem grandes problemas. A estratégia SAGA ajuda a manter a consistência de dados em sistemas distribuídos, minimizando a complexidade e melhorando a resiliência geral.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é uma abordagem para gerenciar operações e infraestrutura usando Git como a fonte de verdade para configurações. Em um ambiente Kubernetes, GitOps utiliza repositórios Git para armazenar e versionar as configurações e manifestos do Kubernetes.

Quando uma mudança é feita no repositório Git, uma ferramenta de GitOps detecta essa alteração e aplica automaticamente as mudanças no cluster Kubernetes. Isso permite um gerenciamento mais eficiente e automatizado das aplicações e infraestrutura, garantindo que o estado do cluster esteja sempre alinhado com o que está definido no Git. GitOps simplifica o processo de deploy, melhora a rastreabilidade e facilita a recuperação de desastres, pois todas as alterações estão documentadas no repositório Git.