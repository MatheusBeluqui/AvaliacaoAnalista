# nodeesafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

1 Base de Código (Codebase)

Local onde vamos verisonar o o codigo(github, codecommit etc), é muito importante um controle de versão dos projetos para eliminar divergencia entre ambientes, ter auditoria que caso tenhamsoo algum oriblema conseguimos sabe de onde e quem fez o deploy, conseguindo corrigir 

2 Configurações (Config)

ter as configurações de uma forma externa ao inves do codigo, nos ajuda a dar manutenção, exemplo url de apis organizadas em um ambiente de configuração ou em varaives na qual voce pode editar a qualquer momento, tokens organizados em cofres como o secrets manager etc  

3 Serviços de Apoio (Backing Services)

Em uma arquitura modera, o codigo irá se comunicar com outros serviços de maneira que iremos dispribuir responsabilidades (em outros microserviços ou containers aclopados para determmida parte do nosso processo)

4-Processos sem Estado (Processes / Stateless)

a aplicação, nao deve armazenar o estado de aplicaçoes, devemos utilziar um outro serviço para armazenar informações, mesmo que sejam temporarias como Serviços de Apoio (Backing Services)

5-Construção, Lançamento e Execução (Build, Release, Run)

Organização e ciclo de uma entrga de software

6-Descartabilidade (Disposability)

**os processos de uma aplicação devem ser descartáveis**, o que significa que eles podem ser iniciados ou interrompidos a qualquer momento com o mínimo de impacto.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

- Camada de Apresentação
  - Camada na qual é responsavel pela apresentação ao usuario(telas, imputs de entradas etc)
- CAmada de negocio
  - Onde contemtodas as regras de negocio, validação  e orquestração de eventos
- Camada de Dados 
  - responsavel por armazenar os dados de clientes, processos, e etc

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

**SOA**

O SOA é um estilo arquitetural focado em integrar e reutilizar sistemas legados e corporativos para funções específicas do ecossistema da empresa.

**Exemplo soa** 

**No SOA (Integração Corporativa com Barramento):**

O RH cadastra a admissão no sistema interno e envia os dados para um **barramento central (ESB)**. O barramento traduz e distribui a informação sozinho: cria o registro no **ERP Senior** (folha de pagamento) e abre as tarefas de TI no **Jira**. Os sistemas não se conversam diretamente, apenas se plugam no barramento.

Sobre Microserviços

Já os microsserviços são serviços menores, desacoplados e independentes, cada um focado em uma funcionalidade ou regra de domínio específica, com deploy e banco de dados próprios.

- **Exemplo 1 - Sistema de Agendamento de Gate:**

  Utilizado pela equipe que organiza e controla as janelas de entrada e saída no porto. Sua arquitetura é 100% voltada para essa função, sem dependência direta de outros sistemas legados.
- **Exemplo 2 - Sistema de Avarias de Terminal Tractor (TT):**

  Focado em conectar facilitadores e operadores de TT para registrar avarias em tempo real e acompanhar a solução de problemas crônicos nos equipamentos.

Os microserviços sao ideias para arquiteturas mais e quando nao ha muitos recursos disponiveis a volta para se reaproveitar

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** 

O **API Management (APIM)** tem como objetivo centralizar o gerenciamento, a exposição, a segurança e a governança de APIs corporativas, atuando como um ponto de entrada unificado (*API Gateway*) que conecta consumidores aos serviços distribuídos de backend.

- **Vantagens:** Centraliza autenticação e autorização (OAuth2, JWT, tokens); aplica controle de tráfego (*Rate Limiting* e *Throttling*); fornece documentação centralizada via Portal do Desenvolvedor; e unifica métricas e observabilidade.
- **Desvantagens:** Pode se tornar um Ponto Único de Falha (SPOF) se não tiver redundância; introduz latência de rede adicional em cada requisição; e traz risco de acoplamento caso regras de negócio sejam indevidamente embutidas nas suas políticas.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

- **Struct:** É um **Value Type** (tipo por valor), alocado prioritariamente na memória **Stack**. Ao ser atribuído ou passado para um método, seu valor completo é copiado. Não suporta herança de classes (apenas implementação de interfaces). É indicado para estruturas pequenas, leves e imutáveis (ex.: `DateTime`, coordenadas).
- **Class:** É um **Reference Type** (tipo por referência), alocado na memória **Heap**, enquanto a variável guarda apenas o ponteiro/endereço na Stack. Ao ser atribuído a outra variável, copia-se apenas a referência. Possui suporte pleno à orientação a objetos (herança, polimorfismo) e seu ciclo de memória é gerenciado pelo **Garbage Collector (GC)**.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET (.NET Framework tradicional):

**Plataforma e Hospedagem:** É uma plataforma legada e proprietária, fortemente atrelada ao ecossistema **Windows** e dependente de servidores web tradicionais como o **IIS**.

.NET Core (.NET moderno):

- **Multiplataforma e Código Aberto:** Foi completamente reescrito do zero como *open-source*, rodando de forma nativa e com alto desempenho em **Linux, Windows e macOS**.
- **Foco em Nuvem e Microsserviços:** Foi projetado nativamente para arquiteturas modernas, microsserviços e **containers Docker/Kubernetes**, com um consumo de memória e CPU substancialmente menor.
- **Servidor Embutido e Independência:** Já vem com um servidor web integrado ultrarrápido , permitindo vincular a porta diretamente no container sem depender de um servidor externo instalado. Suporta deploys autocontidos (*self-contained*), onde o runtime viaja empacotado junto com a própria aplicação.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST usa JSON (textual, fácil leitura) enquanto gRPC usa Protocol Buffers (Protobuf), formato binário mais compacto e eficiente.

REST segue padrão requisição/resposta simples. gRPC suporta streaming bidirecional, permitindo fluxo contínuo de mensagens.

REST é usado em APIs públicas e integrações externas. gRPC é mais performático para comunicação entre microsserviços, com menor latência e menor consumo de banda.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
Em uma SPA (Single Page Application), o gerenciamento de rotas é responsável por controlar a navegação entre as telas da aplicação sem a necessidade de recarregar a página inteira no navegador.

Quando o usuário acessa uma funcionalidade, a aplicação identifica a rota solicitada e carrega apenas o componente correspondente, mantendo a mesma página carregada.

Por exemplo, após realizar o login, o sistema pode exibir a tela principal da aplicação sem dar refresh na página ou abrir uma nova página no navegador. A navegação acontece internamente pela própria aplicação.

Isso proporciona uma experiência mais rápida e fluida para o usuário, reduzindo recarregamentos desnecessários e melhorando a performance percebida.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
AWS:

- Lambda: Desenvolvo integrações event-driven (webhooks, agendamentos)
- CloudWatch: Monitoro logs, criaria alertas (SNS → Teams)
- EventBridge: Agendo processos (ex: dia 5/mês, 08h BRT)
- CI/CD: Deploy automático ao fazer push (CodeBuild valida mudanças)
- SQS FIFO: Processamento sequencial de fila (similar RabbitMQ)
- Secrets Manager: Armazeno credenciais (tokens, chaves)
- IAM: Controle permissões por função
- S3: Versiono artefatos, resultados de processos
- DynamoDB: Gerencio fila de integrações

Fora da aws que eu tenhoo conehcimento 
Docker: Experiência prática (Lambdas executam em containers, entendo layers)
Kubernetes: Conhecimento teórico (não uso em produção, mas entendo orquestração de containers)

10. Explique sobre um método agile.

**Resposta:**
Trabalho com metodologias ágeis há mais de 3 anos, utilizando Scrum com sprints de duas semanas. Entre as cerimônias, considero a Sprint Planning uma das mais importantes, pois nela definimos as entregas da sprint, avaliamos a capacidade do time e alinhamos prioridades para garantir entregas previsíveis e de valor para o cliente.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI/CD é uma prática DevOps que automatiza o processo de integração,
teste e entrega de código em produção.

• CI (Continuous Integration): Toda mudança de código é testada/validada
• CD (Continuous Deployment): Código validado é automaticamente entregue em produção

vou da um exemplo do meu dia a dia 
Passo 1: Desenvolvimento

1. Escrevo o código em um projeto Lambda
2. Faz commit: git push origin novo-integracao
3. Git ativa o webhook para CodePipeline

Passo 2: CI (Integração Contínua)
4. CodePipeline dispara CodeBuild
5. CodeBuild executa buildspec.yml que:

- Verifica git diff (só faz build se houve mudança no monorepo)
- Valida sintaxe Python
- Executa testes (se houver)
- Gera artefato (zip com código)

Passo 3: CD (Continuous Deployment)
6. Se tudo passou, CodePipeline envia artefato para S3
7. Lambda é atualizada automaticamente com novo código
8. Deploy concluído — mudança está em produção

aproveitei para explicar o processo de CI/CD e dentro dos passos explicar as ferramentas que uso que sao da AWS, mas o processo é semelhante a outras 

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Container é uma tecnologia de virtualização que permite empacotar
uma aplicação e suas dependências para executar isoladamente.
Cada container é independente ou seja se um falha, não afeta os outros.

Docker é a ferramenta que cria e gerencia esses containers.
Você define o que entra no container (código, libs, configurações)
e Docker cuida de empacotar tudo para funcionar.

Um exemplo que posso comentar é que Container é a caixa; 
Docker é o software que constrói a caixa.

Na prática, em Lambda cada função roda em seu próprio container isolado,
garantindo que o ambiente seja sempre o mesmo (dev, homolog, produção).

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Kubernetes é um motor de orquestração de containers. Diferentemente de Docker,
onde criamos containers manualmente e indicamos suas dependências, Kubernetes
é escalável e consegue perceber a necessidade de aumento de containers,
ajustando automaticamente.

Sobre a diferença entre Kubernetes e OpenShift:

Kubernetes é a base, o núcleo puro de orquestração.
OpenShift é Kubernetes + camadas adicionais como console web, CI/CD e segurança.

OpenShift incorpora tecnologias adicionais dentro da ferramenta.

Uma boa analogia: é como um framework de uma linguagem de programação.
A linguagem funciona normalmente com tudo que contém, porém o framework
já oferece atributos prontos para usar imediatamente, sem precisar
configurar tudo do zero.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
VANTAGENS DE API:

1. Integração entre sistemas

Permite criar scripts e buscar informações rápidas de outros sistemas
sem precisar acessar a aplicação, apenas utilizando tokens de autenticação.

2. Divisão de responsabilidades

Precisamos apenas usar a API enquanto o responsável do servidor cuida
de todo o processo. Esse desacoplamento é essencial para estabilidade
e manutenção independente.

3. Escalabilidade

Possibilita escalar processos de forma performática através de requisições
paralelas, distribuindo a carga eficientemente.

4. Reutilização

Uma API centralizada (como Senior) recebe requisições de diversos sistemas
e pontos, mantendo os dados atualizados com múltiplas fontes em tempo real.

5. Segurança

A autenticação permite identificar a origem dos dados e controlar as
permissões de cada usuário da API, garantindo acesso apenas ao necessário.

DESVANTAGENS DE API:

1. Dificuldade de personalização

Ficamos limitados às rotas disponíveis no servidor para buscar, atualizar
e cadastrar informações. Qualquer mudança requer contato com o responsável
do sistema para modificar ou criar novas rotas.

2. Dependência de confiabilidade

Se o sistema não for confiável e cair, ficamos incapazes de contornar o
problema até que o servidor seja restaurado.

3. Custo por requisição

Algumas APIs cobram por chamada. Volumes altos, como 1 milhão de requisições
mensais, podem representar custos significativos.

acredito que servidores e sitemas bem escopados nao existem tantas desvantagens, e mais beneficios

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Para garantir um nível de segurança satisfatório no uso de APIs,
a autenticação é fundamental.

AUTENTICAÇÃO NO SERVIDOR:
Em sistemas grandes, a autenticação é obrigatória e já existe.
É o primeiro nível de segurança que o servidor precisa ter para
autenticar seus usuários e validar quem está acessando a API.

SEGURANÇA NO CLIENTE (lado da aplicação):
Do lado do cliente, as principais preocupações de segurança são:

1. Não expor tokens ou senhas de autenticação

   • Nunca deixar credenciais em código-fonte
                         • Nunca commitar secrets no git
                         • Nunca logar tokens em logs
2. Armazenar credenciais em cofres seguros

   • Usar Secrets Manager (ou similares: Vault, 1Password)
                         • Tokens criptografados e protegidos
                         • Acesso controlado por permissões (IAM)
3. Outras práticas essenciais

   • HTTPS obrigatório (criptografia em trânsito)
                         • Validação de entrada (evita injection attacks)
                         • Tratamento de erros sem expor informações sensíveis
                         • Rate limiting respeitado
                         • Retry com backoff exponencial
                         • Monitoramento e alertas (CloudWatch, Vault logs)
                         • Rotação periódica de tokens
4. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Arquitetura de mensageria é um padrão de comunicação assíncrona
entre sistemas através de filas ou tópicos de mensagens.

Utilizo SQS FIFO que recebe mensagens de integrações com IDs.  
O FIFO organiza essas mensagens pela ordem de chegada e as  
processa de maneira sequencial e organizada.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

Saga é um padrão utilizado em microsserviços para gerenciar transações distribuídas. Em vez de uma única transação envolvendo vários serviços, cada serviço executa sua própria transação local. Se ocorrer alguma falha, ações compensatórias são executadas para desfazer as etapas anteriores e manter a consistência dos dados.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps é um padrão onde Git é a fonte de verdade para o estado do Kubernetes.
Fluxo:

1. Você faz commit de um arquivo YAML no Git
2. GitOps operator (ArgoCD, Flux) detecta mudança
3. Aplica no cluster automaticamente
4. Kubernetes executa

Benefício: Tudo em Git (versionamento, auditoria, rollback)

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
CASE 1: AGENDAMENTO DE ENTREGAS (FARMÁCIA)

Desenvolvi SPA de ponta a ponta permitindo fornecedores sugerir
datas de entrega e gerentes aceitar/contrapropor conforme disponibilidade.

Stack: JavaScript (frontend) + Cosmos (backend) + SQL Server (dados)

CASE 2: DISPATCHER DE INTEGRAÇÕES (AWS)

Criei sistema centralizado que orquestra integrações via fila SQS FIFO.

Fluxo:
Produtor (Lambda) - SQS FIFO → Dispatcher (Lambda) - API Externa

O Dispatcher lê cada mensagem, busca autenticação em Secrets Manager,
faz POST com retry automático (backoff exponencial), e atualiza status
em DynamoDB.

Benefícios: desacoplamento, confiabilidade, reutilização, ordem garantida.

Desafios: rate limiting, idempotência, timeout, segurança, monitoramento.

CASE 1: MONITORAMENTO CENTRALIZADO

Desenvolvi sistema que monitora todas as Lambdas de integração
detectando erros, throttles e duração excessiva via CloudWatch Alarms.

Stack: CloudWatch → SNS → Lambda → Teams (Power Automate)

Benefício: alertas em tempo real, observabilidade completa, resposta rápida via teams 

