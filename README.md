# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

CODEBASE: Define que deve haver uma única base de código para cada aplicação, rastreada em um sistema de controle de versão, como Git. Mesmo que a aplicação seja implantada em diferentes ambientes (dev, qa, produção), o código base é o mesmo.

CONFIG: Separar a configuração do código-fonte. As configurações específicas de ambiente, como conexões de banco e credenciais, devem ser definidas fora do código e gerenciadas como variáveis de ambiente. Isso garante flexibilidade e segurança.

DEPENDENCIES: A aplicação deve declarar e isolar suas dependências. Em .NET, isso geralmente significa gerenciar as dependências por meio de pacotes NuGet, garantindo que a aplicação seja independente do ambiente onde será executada.

BACKING SERVICES: Tratam serviços como bancos de dados, serviços de cache e APIs externas como recursos anexáveis e intercambiáveis. Eles são referenciados por URL ou credenciais armazenadas como variáveis de ambiente.

PROCESSES: A aplicação deve ser executada como um ou mais processos stateless. Isso significa que o estado da aplicação não deve ser armazenado na memória do processo, mas sim em um banco de dados ou outro serviço de persistência, facilitando escalabilidade.

LOGS: Logs devem ser tratados como um fluxo contínuo de eventos. Eles devem ser direcionados para a saída padrão e processados posteriormente por sistemas de agregação de logs, como o Elastic Stack, facilitando o monitoramento e o troubleshooting.


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

As principais camadas são apresentação (Frontend), aplicação (Backend), dados (Persistência) e integração.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

SOA (Arquitetura Orientada a Serviços) é uma abordagem monolítica, com serviços interdependentes que se comunicam via um barramento. Já a arquitetura de Microserviços promove independência total entre serviços leves, cada um encapsulando uma função específica, com comunicação por APIs REST ou gRPC, permitindo escalabilidade e agilidade com menor acoplamento em relação ao SOA.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

O API Management é fundamental para gerenciar, monitorar e proteger APIs em uma arquitetura de serviços distribuídos.

Entre suas vantagens estão a centralização do controle de acesso e autenticação, a análise e monitoramento de uso das APIs e a padronização na documentação.

No entanto, algumas desvantagens incluem a adição de uma camada de complexidade e de overhead ao sistema, além de uma possível dependência de terceiros para o gerenciamento, especialmente quando se opta por uma solução em nuvem.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Struct é um tipo de dado por valor, armazenado na stack. Ideal para dados pequenos e imutáveis. Não suporta herança, apenas implementação de interfaces. Já Class é um tipo de dado por referência, armazenado no heap. Suporta herança e é mais flexível, mas consome mais memória e pode exigir coleta de lixo.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET (antigo .NET Framework) é voltado para Windows e integra funcionalidades específicas do sistema operacional. Já o .NET Core é multiplataforma e open-source, feito para rodar em Windows, Linux e macOS.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST é baseado em HTTP e usa JSON para transferência de dados. É mais simples e amplamente compatível, mas pode ser mais lento e verboso. O gRPC usa HTTP/2 e Protobuf, ideal para comunicação entre microserviços de alta performance e baixa latência. No entanto, tem suporte limitado em navegadores e é mais complexo de implementar.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Em uma SPA, o gerenciamento de rotas permite navegar entre páginas sem recarregar o navegador. As rotas são gerenciadas no frontend (geralmente com frameworks como Angular, React ou Vue.Js) e atualizam a URL sem uma nova requisição ao servidor.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps é uma cultura que integra desenvolvimento e operações para entregar software mais rápido e com qualidade. Envolve práticas de CI/CD, automação de testes e monitoramento, possibilitando uma entrega contínua e confiável.


10. Explique sobre um método agile.

**Resposta:**

O método ágil é uma abordagem de gerenciamento de projetos que enfatiza a flexibilidade, colaboração e entrega incremental. Em vez de seguir um planejamento rígido, as equipes ágeis trabalham em ciclos curtos, permitindo adaptação rápida às mudanças e foco nas necessidades do cliente.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

CI (Continuous Integration) e CD (Continuous Delivery/Deployment) são práticas para automação de build, testes e deploy. Ferramentas como Jenkins, GitHub Actions, e Azure DevOps ajudam a automatizar esses processos, garantindo entregas frequentes e de qualidade.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Docker é uma plataforma que facilita a criação, distribuição e execução de containers. Um container é uma unidade de software que encapsula código e dependências para rodar em qualquer ambiente.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

O Kubernetes é uma plataforma de orquestração de containers open-source e muito configurável. E o OpenShift é uma distribuição do Kubernetes pela Red Hat com ferramentas adicionais de gerenciamento e uma interface mais amigável.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

O uso de APIs traz flexibilidade, reusabilidade e facilita a integração com outros sistemas. No entanto, exige segurança extra, políticas de versionamento e uma infraestrutura confiável, podendo enfrentar problemas de latência. As principais preocupações são segurança (autenticação e autorização), gestão de versão e documentação clara.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Recomendo sempre implementar autenticação (OAuth, JWT), usar HTTPS para proteger dados em trânsito, aplicar rate limiting e monitoramento e configurar CORS adequadamente.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Uma arquitetura de mensageria permite que os serviços se comuniquem de forma assíncrona e desacoplada, facilitando o escalonamento e aumentando a resiliência.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

Saga é uma estratégia para garantir consistência de dados em transações distribuídas entre microserviços. Cada serviço executa uma transação local e emite um evento para o próximo passo. Se algo falhar, cada serviço executa ações de compensação para desfazer as transações.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

GitOps é uma prática de gerenciar a infraestrutura e as aplicações de um ambiente Kubernetes usando Git como única fonte de verdade. Com GitOps, as mudanças são aplicadas automaticamente ao cluster Kubernetes assim que o código é atualizado, garantindo uma consistência e um histórico completo de alterações.
