# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** 1- CodeBase: Utilizar apenas um repositorio com controle de versionamento como o git.
2 - Configuration: Manter as configuracoes sigilosas fora do codigo.
3 - Dependencies: Declarar isoladamente as dependencias do projeto, e utilizar pacotes de gerenciadores de dependencias.
4 - Backing Services: Usar serviços externos como banco de dados, cookies, cache, etc...
5 - Build, Release, Run: Separar o processo de build, release e run em etapas distintas.
6 - Concurrency: Escalar a aplicação horizontalmente, aumentando o numero de instancias do mesmo processo.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Front-end/UI, Back-end/Business Logic e Database Layer

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** SOA: é uma arquitetura que utiliza servicos monoliticos, com um barramento de servicos (ESB) e comunicação via SOAP. Microserviços: é uma arquitetura que utiliza serviços independentes, com comunicação via REST ou gRPC, cada serviço é isolado e pode ser escalado individualmente.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** O objetivo de um API Management é gerenciar, monitorar e proteger as APIs de uma aplicação, garantindo que elas sejam consumidas de forma segura e eficiente.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** Struct: normalmente utilizado para representar valores simples.
Class: Ja e utilizado para representar objetos complexos.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** Basicamente são a mesma tecnolgia com a diferença que o .NET CORE é multiplataforma, ou seja, pode ser executado em Windows, Linux e MacOS, enquanto o .NET Framework é limitado ao Windows.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** Rest: é um estilo de arquitetura que utiliza HTTP como protocolo de comunicação, comumente utilizado para APIs web.
GRPC: é um framework de comunicação remota que utiliza HTTP/2 como protocolo de transporte sendo mais eficiente e rápido que REST.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** Uma SPA é uma aplicaçao web que consegue troar de telas sem precisa fazer o refresh.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** É o conjunto de praticas que visa integrar o desenvolvimento de software e a operação de sistemas, com o objetivo de melhorar a colaboração, automação e entrega contínua de software.

10. Explique sobre um método agile.

**Resposta:** Um dos metodos que ja utilizei foi o scrum que utiliza ciclos de desenolvimentos curtos chamados sprints, com reuniões diarias para acompanhamento do progresso e planejamento das tarefas.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** CI: verifica automaticamente as alterações no codigo e executa testes oara encontarr erros mais cedo.
CD: Automatiza a preparação e, dependendo da estrategia, a publicação das novas versões do software.

12. Qual a diferença entre Docker e Containers.

**Resposta:** Docker é uma pkataforma de criação de containers. Containers são ambientes isolados que acrregam uma aplicação e todas os componentes para executa-la.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Kubernetes é uma plataforma para orquestração de containers, e Openshit e uma plataforma baseada em Kibernetes que acrescenta ferramentas e recursos para facilitar a gestão de containers e aplicações em produção.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** As vantagens de utilizar APIs incluem a capacidade de reutilização de código, facilidade de manutenção e escalabilidade. As desvantagens podem incluir complexidade na gestão e segurança. Quando escolhemos essa abordagem, devemos ter preocupações com performance, segurança e manutenção.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Através do uso de autenticação e autorização adequadas, criptografia de dados em trânsito e monitoramento contínuo das atividades da API.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Permitir a comunicação assíncrona entre diferentes serviços ou componentes de um sistema, facilitando a escalabilidade das aplicações.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** A estratégia SAGA é um padrão de design para gerenciar transações distribuídas em sistemas de microserviços. Em vez de usar uma transação única que abrange todos os serviços, a SAGA divide a transação em uma série de etapas menores, cada uma sendo uma transação local em um serviço específico. Se uma etapa falhar, as etapas anteriores podem ser revertidas através de ações compensatórias, garantindo a consistência do sistema.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** GitOps é uma abordagem de gerenciamento de infraestrutura e aplicações em Kubernetes que utiliza o Git como fonte única de verdade. Todas as alterações na configuração do cluster e nas aplicações são feitas através de commits no repositório Git, e ferramentas de automação monitoram o repositório para aplicar essas mudanças automaticamente no cluster. Isso garante rastreabilidade, versionamento e consistência entre o estado desejado (definido no Git) e o estado real do cluster.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Tenho experiência com desenvolvimento de aplicações web, tanto em projetos acadêmicos quanto em projetos freelance.

Um dos meus principais projetos foi meu Trabalho de Conclusão de Curso(https://pge-front.vercel.app/), voltado ao gerenciamento de frotas de caminhões. A aplicação busca centralizar informações sobre veículos, motoristas e manutenções, além de trabalhar com o acompanhamento do consumo de combustível por quilômetro rodado, ajudando a identificar oportunidades de melhoria na gestão operacional.

Também desenvolvi duas landing pages para profissionais autônomas: uma para uma clínica de estética(https://leticia-pessoa.vercel.app/) e outra para uma personal trainer(https://personal-giovanna.vercel.app/). Nesses projetos, o foco foi apresentar os serviços de maneira profissional, organizar as informações e facilitar o contato de potenciais clientes por meio de canais de atendimento.
