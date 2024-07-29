# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

- Codebase: controle de repositório, bem como plataformas como github, gitlab, azure devops onde o time consegue colaborar com o desenvolvimento do serviço com PR's (pull requests, code review, merges) tendo um controle de versão mais controlado e uma melhor cooperação no desenvolvimento do software.

- Dependencies: Declara e isola explicitamente todas as dependências da aplicação. Utiliza sistemas de gerenciamento de pacotes (como npm, pip, NuGet) para listar todas as bibliotecas e ferramentas necessárias, incluindo ORMs para manipulação de dados (como Entity Framework e Dapper), serviços de armazenamento (como SFTP), serviços de segurança (como Azure AD, LDAP, OAuth 2.0), e padrões de arquitetura em mensageria (como Kafka, RabbitMQ, Service Bus). Isso garante que a aplicação possa ser instalada e executada de forma consistente em qualquer ambiente.

- Config: Armazena a configuração da aplicação de forma que seja fácil de alterar sem modificar o código-fonte. Todas as configurações devem ser armazenadas em variáveis de ambiente, que podem incluir informações sensíveis como senhas e chaves de API, ou parâmetros operacionais como o intervalo de execução de jobs. Em ambientes como Kubernetes, essas configurações podem ser gerenciadas usando ConfigMaps e Secrets. Ferramentas adicionais como AWS Parameter Store, HashiCorp Vault, e Azure Key Vault podem ser usadas para gerenciar e acessar configurações de forma segura.

- Logs: Uma forte ferramenta para monitoramento e análise, existem vários mecanismos de implementação de log para controle, sendo possível coletar métricas de throughput baixo, latência, disponibilidade de recursos sempre visando a qualidade do software.

- Dev/prod parity: é o princípio que defende a manutenção de ambientes de desenvolvimento e produção o mais semelhante possível. Isso inclui consistência em configuração, dependências, dados e estado da aplicação. Manter essa paridade ajuda a minimizar problemas durante o deploy, facilita a depuração e melhora a eficiência do desenvolvimento, resultando em um processo de desenvolvimento e deployment mais robusto e confiável.

- Build, Release, Run: divide o ciclo de vida da aplicação em três fases distintas para promover uma abordagem modular e controlada ao desenvolvimento e deployment onde o Build é responsável pela compilação e empacotamento do código-fonte e suas dependências em um artefato de deploy. A seguir temos a Release que associa o artefato de build com a configuração do ambiente e cria uma release pronta para a execução. E por fim temos o Run que executa a aplicação no ambiente de destino, utilizando o artefato e a configuração da release.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Camada de Análise, Camada de Desenvolvimento, Camada de CI/CD (Integração Contínua/Entrega Contínua), Camada de Operações e Monitoramento e Camada de Infraestrutura.

Responsabilidade de cada camada.

- Análise: Compreender e definir os requisitos do sistema. Analisar o problema e identificar soluções técnicas e de negócios.
Desenvolvimento: Implementar o código-fonte da aplicação com base nos requisitos definidos. Criar e testar funcionalidades e garantir a qualidade do software.

- CI/CD: Automatizar o processo de build, teste e deploy da aplicação. Garantir que o código seja integrado, testado e entregue de forma eficiente e contínua.

- Operações e Monitoramento: Gerenciar e monitorar a aplicação em ambientes de produção. Garantir a operação contínua e a escalabilidade da aplicação.

- Infraestrutura: Gerenciar a infraestrutura necessária para a execução da aplicação. Prover os recursos de hardware e software necessários.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Arquitetura Orientada a Serviços (SOA)
Características:

- Serviços Reutilizáveis: SOA promove a criação de serviços que podem ser reutilizados por diferentes aplicações. Cada serviço é projetado para realizar uma funcionalidade específica.
- Interoperabilidade: Utiliza padrões como SOAP e WSDL para permitir a comunicação entre diferentes plataformas e tecnologias.
- ESB (Enterprise Service Bus): Um componente centralizado que facilita a integração entre serviços, roteamento de mensagens e transformação de dados.
- Granularidade dos Serviços: Os serviços são tipicamente mais complexos e podem abranger múltiplas funcionalidades.
- Governança: Foco em uma abordagem centralizada para a governança, controle de versões e segurança dos serviços.

Pontos Positivos:

- Integração: Facilita a integração de sistemas heterogêneos usando padrões abertos.
- Reutilização: Permite reutilizar serviços existentes, evitando a duplicação de funcionalidades.
- Governança Centralizada: Fornece uma abordagem controlada para o gerenciamento e a segurança dos serviços.

Pontos Negativos:

- Complexidade: A dependência do ESB e a natureza dos serviços mais monolíticos podem aumentar a complexidade da arquitetura.
- Desempenho: A introdução do ESB pode adicionar latência e sobrecarga.
- Escalabilidade: A escalabilidade pode ser mais difícil de alcançar devido à natureza monolítica dos serviços.

Arquitetura de Microserviços
Características:

- Serviços Independentes: A aplicação é dividida em pequenos serviços autônomos, cada um responsável por uma funcionalidade específica.
- Desacoplamento: Os serviços são independentes e se comunicam via APIs RESTful, gRPC, ou sistemas de mensageria.
- Desenvolvimento e Deploy Independentes: Permite que equipes desenvolvam e implantem serviços separadamente, facilitando atualizações e manutenção.
- Granularidade dos Serviços: Serviços são pequenos e focados em uma única responsabilidade.
- Gerenciamento de Estado: Os serviços são tipicamente stateless, com o gerenciamento de estado externo.

Pontos Positivos:

- Escalabilidade: Facilita o escalonamento granular e independente dos serviços com base na demanda.
- Desacoplamento: Permite que serviços sejam desenvolvidos, implantados e escalados de forma independente, promovendo a agilidade.
- Resiliência: A falha de um serviço não compromete a aplicação como um todo, aumentando a robustez.

Pontos Negativos:

- Complexidade Operacional: A gestão de múltiplos serviços e a comunicação entre eles pode ser complexa e exigir uma infraestrutura robusta.
- Gerenciamento de Dados: A consistência de dados distribuídos e a gestão de transações podem ser desafiadoras.
- Curva de Aprendizado: A configuração e o gerenciamento de uma arquitetura de microserviços pode ser complexo e exigir uma curva de aprendizado significativa.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

API Management é fundamental para garantir a eficácia, segurança e usabilidade das APIs em uma arquitetura de serviços distribuídos.
Proporciona uma série de benefícios significativos, como centralização, segurança avançada, otimização de desempenho, visibilidade detalhada, facilidade de desenvolvimento e suporte a versionamento e documentação. No entanto, também introduz desafios como complexidade adicional, custos, possíveis pontos únicos de falha, latência extra, curva de aprendizado e sobrecarga operacional.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Diferenças:

- Tipo de Valor vs Tipo de Referência:

struct: É um tipo de valor. Isso significa que uma struct é armazenada na pilha (stack), e seu valor é copiado quando é atribuído a outra variável ou passado como parâmetro.
class: É um tipo de referência. Isso significa que uma class é armazenada no heap, e quando você atribui uma class a outra variável passa como parâmetro, você está passando uma referência ao objeto, não uma cópia do objeto.

- Herança:

struct: Não pode herdar de outra struct ou class, e não pode ser herdada. Pode implementar interfaces, mas não suporta herança.
class: Suporta herança, permitindo que uma classe herde de outra classe e possa ser herdada.

- Construtores:

struct: Não pode ter um construtor sem parâmetros explícito definido pelo usuário. Um construtor padrão é sempre fornecido e inicializa todos os campos para valores padrão.
class: Pode ter construtores sem parâmetros e pode definir construtores personalizados.

- Nullabilidade:

struct: Não pode ser null (exceto quando é usado com Nullable<T>). Sempre contém um valor.
class: Pode ser null. Uma variável de class pode não referir a nenhum objeto.

- Tamanho e Complexidade:

struct: Ideal para tipos pequenos e simples, como coordenadas ou pontos, que são frequentemente criados e destruídos.
class: Melhor para objetos mais complexos e grandes, com estados que devem ser compartilhados e manipulados por referência.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET é a plataforma moderna unificada introduzida com .NET 5 e versões subsequentes, que integra as melhores características do .NET Framework e do .NET Core em uma única base. Ela oferece suporte contínuo para desenvolvimento multiplataforma em Windows, macOS e Linux, além de melhorias constantes em desempenho e escalabilidade. Em contraste, .NET Core foi a versão anterior projetada especificamente para ser multiplataforma e modular, permitindo o desenvolvimento eficiente de aplicações cross-platform e de alto desempenho. Enquanto .NET Core facilitava a criação de aplicativos que podiam rodar em diferentes sistemas operacionais e era ideal para ambientes de nuvem e contêineres, o .NET unifica essas capacidades, proporcionando uma plataforma consolidada que simplifica o desenvolvimento e a manutenção de aplicações modernas, além de suportar a migração de sistemas legados do .NET Framework.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST usa HTTP/1.1 com dados em JSON ou XML, o que facilita a integração mas pode resultar em maior sobrecarga. gRPC utiliza HTTP/2 e Protocol Buffers, oferecendo comunicação mais eficiente e compacta, com suporte para streaming bidirecional, ideal para aplicações de alta performance e microserviços.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Em uma Single Page Application (SPA), o gerenciamento de rotas é responsável por controlar a navegação e exibição de diferentes conteúdos sem recarregar a página inteira. Isso é feito por meio de um roteador, que intercepta as mudanças na URL e atualiza dinamicamente o conteúdo da página. O processo geralmente segue estes passos:

- Configuração das Rotas: O roteador é configurado com um conjunto de rotas, que são mapeamentos entre URLs e componentes ou visualizações específicas da aplicação.
- Interceptação de Navegação: Quando um usuário navega para uma nova URL, o roteador intercepta essa navegação, evitando o carregamento completo da página pelo servidor.
- Atualização do Conteúdo: Com base na URL, o roteador seleciona e renderiza o componente correspondente, atualizando apenas a parte da página necessária para refletir a nova visualização, enquanto mantém o restante do estado da aplicação intacto.
- Histórico de Navegação: O roteador geralmente utiliza o History API do navegador ou o hash da URL para manipular o histórico de navegação, permitindo que o usuário use o botão de voltar e avance normalmente.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

No contexto de DevOps, a pipeline de CI/CD (Integração Contínua e Entrega Contínua) automatiza o fluxo de trabalho desde o desenvolvimento até o deploy, integrando processos cruciais como testes de quality assurance e controle de quality gates para garantir que o código atenda aos padrões de qualidade antes do deploy. A pipeline também gerencia a deploy frequency, permitindo atualizações frequentes e rápidas do software. Adicionalmente, ferramentas como Helm e Kubernetes (k8s) são configuradas dentro da pipeline para orquestrar e automatizar a implantação de aplicativos em ambientes de contêineres, facilitando a gestão e escalabilidade de serviços.

10. Explique sobre um método agile.

**Resposta:**

Scrum é um framework ágil que cadencia as entregas em sprints. Em uma sprint existem algumas reuniões e pessoas chaves para a efetividade do método bem como a Planning (planejamento do sprint), a daily (reuniões diárias para levantar se existe algum impeditivo), review (revisão do trabalho entregue na sprint) e retrospectiva (momento de perceber pontos positivos, negativos e traçar ações visando a melhoria). Geralmente nesse método se tem o Product Owner, que define e prioriza o backlog do produto, o Scrum Master, que facilita o processo e remove impedimentos, e a Equipe de Desenvolvimento.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

Integração Contínua (CI) refere-se ao processo de automatizar a construção e testes do código sempre que um commit é realizado. Isso inclui a execução de testes unitários, de integração e de aceitação para garantir que o código esteja funcionando corretamente e atendendo aos padrões de qualidade. Esse processo é configurado para ser acionado automaticamente por meio de uma pipeline sempre que um desenvolvedor faz um push para o repositório, permitindo a detecção rápida de problemas.

Entrega Contínua (CD), por sua vez, estende o conceito de CI ao processo de deploy, automatizando a configuração e a atualização de ambientes de desenvolvimento, staging e produção. Em uma pipeline de CD, após a construção e os testes bem-sucedidos, o código pode ser automaticamente implantado em ambientes de staging ou produção. Muitas vezes, o deploy para produção pode requerer aprovação adicional de membros da equipe técnica, como arquitetos, desenvolvedores ou SREs (Site Reliability Engineers), garantindo que apenas versões aprovadas e estáveis sejam liberadas para o ambiente de produção.

12. Qual a diferença entre Docker e Containers.

**Resposta:**

Containers são unidades leves e portáteis que isolam aplicativos e suas dependências para execução consistente em qualquer ambiente. Docker é uma plataforma que facilita a criação, gerenciamento e orquestração desses containers, oferecendo ferramentas e uma infraestrutura específica para seu uso.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

O Red Hat OpenShift é uma plataforma empresarial baseada no Kubernetes e outros componentes open source. Ele oferece recursos adicionais, suporte e integração para aplicações nativas em nuvem em ambientes híbridos e multicloud. Enquanto o Kubernetes automatiza a implantação, gerenciamento e escalonamento de containers, o OpenShift vai além, fornecendo ferramentas como automação, monitoramento e CI/CD para acelerar o desenvolvimento e a entrega de aplicações em containers em escala.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

As APIs oferecem diversos benefícios. Primeiramente, elas promovem a aceleração do desenvolvimento, permitindo que você aproveite funcionalidades prontas e economize tempo na criação de novas soluções. Além disso,  facilitam a integração com ecossistemas externos, como redes sociais, pagamentos online e serviços de mapas, ampliando as capacidades da sua aplicação.
Contudo, é importante estar ciente das preocupações de segurança relacionadas às APIs. Uma delas é a vulnerabilidade de autenticação e autorização, que pode permitir acesso não autorizado a recursos sensíveis caso não seja implementada corretamente. Além disso, a exposição de dados confidenciais é um risco se a API estiver mal configurada, comprometendo a privacidade dos usuários.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

- Autenticação e Autorização: Implemente mecanismos robustos de autenticação e autorização para controlar o acesso aos recursos da API.
- Criptografia com HTTPS: Use HTTPS para proteger a transmissão de dados entre a API e os clientes.
- Validação de Entrada: Verificar os dados de entrada para evitar ataques.
- Auditoria e Monitoramento: Registre atividades da API e monitore em busca de anomalias.
- Testes de Segurança: Realize testes regulares para identificar vulnerabilidades e corrigi-las.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

A arquitetura de mensageria é fundamental para cenários event-driven. Nesse modelo, eventos são gerados por diferentes partes do sistema e propagados por meio de mensagens. Por exemplo, quando um pedido é feito em um aplicativo de e-commerce, um evento de “pedido criado” é publicado e consumido por outros serviços, como o de estoque ou faturamento.

Além disso, existem padrões específicos para lidar com mensagens em bancos de dados. O Inbox Repository Pattern é usado para armazenar eventos em uma tabela de entrada (inbox) antes de processá-los. Isso garante que os eventos sejam registrados antes de qualquer ação ser tomada, evitando perda de dados.

Já o Outbox Pattern é usado para garantir a consistência entre o banco de dados e a mensageria. Nesse caso, os eventos são gravados primeiro em uma tabela de saída (outbox) e, em seguida, enviados para a fila de mensagens. Isso evita falhas de transação e garante que os eventos sejam entregues mesmo se o serviço de mensageria falhar temporariamente.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

A estratégia SAGA em arquitetura de microsserviços é especialmente útil para cenários em que várias operações precisam ser executadas de forma coordenada, mas os serviços envolvidos são independentes e distribuídos. Ela lida com a consistência entre serviços, garantindo que as operações sejam executadas corretamente, mesmo quando ocorrem falhas. A SAGA utiliza eventos de domínio para comunicação entre serviços, e existem duas abordagens principais: a SAGA Coreografada, onde cada serviço inicia e compensa suas próprias operações, e a SAGA Orquestrada, onde um coordenador controla todas as etapas. Em resumo, a estratégia SAGA é uma abordagem poderosa para lidar com complexidade, escalabilidade e consistência em sistemas distribuídos baseados em microsserviços.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

GitOps compartilha muitos dos princípios e práticas de DevOps e Kubernetes, com ênfase adicional na utilização de Git para gerenciar configurações e mudanças. Ferramentas de monitoramento como Prometheus e Grafana continuam sendo essenciais, fornecendo visibilidade contínua e ajudando a garantir que as operações e o desempenho das aplicações sejam monitorados de forma eficiente. A configuração de ambientes no GitOps também é gerenciada por meio de arquivos de configuração armazenados em Git, onde ConfigMaps e Secrets são definidos e versionados como código, garantindo que todas as alterações sejam rastreáveis e auditáveis. Além disso, o uso de requests e limits para CPU e memória em Kubernetes é alinhado com o GitOps para assegurar que os recursos sejam alocados de forma adequada e eficiente. O GitOps integra essas práticas com a vantagem de um controle e uma visibilidade aprimorados sobre a infraestrutura e a configuração das aplicações através do Git.