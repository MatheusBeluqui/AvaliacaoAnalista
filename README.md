

## Questionário

### 1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Resposta:
1. Base de Código: Um código, vários deploys. Todo projeto tem um repositório único.
2. Dependências: Declare e isole. Use um arquivo para listar tudo que seu app precisa.
3. Configuração: Mantenha no ambiente. Configurações variáveis vão em variáveis de ambiente.
4. Serviços de Apoio: Trate como anexos. Banco de dados, filas, etc., devem ser facilmente substituíveis.
5. Construir, Lançar, Executar: Separe essas etapas. Primeiro construa, depois lance, então execute.
6. Processos: Sem estado. Seu app não deve guardar nada localmente, use serviços externos.

### 2. Quais são as principais camadas no desenvolvimento de um software?

Resposta:
- Apresentação: Interface com o usuário.
- Aplicação: Gerencia o fluxo de dados.
- Domínio: Regras de negócio.
- Infraestrutura: Acesso a banco de dados, APIs, etc.

### 3. Diferencie Arquitetura SOA X Arquitetura microserviços.

Resposta:
- SOA: Serviços reutilizáveis e acoplados, com comunicação via ESB.
- Microserviços: Pequenas aplicações independentes, comunicação leve e fácil escalabilidade.

### 4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

Resposta:
- Objetivo: Gerenciar, proteger e monitorar APIs.
- Vantagens: Segurança, monitoramento, escalabilidade.
- Desvantagens: Complexidade e custo.

### 5. Qual a diferença entre uma Struct e uma Class?

Resposta:
- Struct: Tipo de valor, leve, sem herança.
- Class: Tipo de referência, mais complexa, suporta herança.

### 6. Explique a grande diferença entre .NET e .NET CORE.

Resposta:
- .NET: Para Windows, mais antigo.
- .NET Core: Multiplataforma, mais moderno e performático.

### 7. Quais as principais diferenças entre REST e GRPC?

Resposta:
- REST: HTTP e JSON, fácil de usar, mas mais lento.
- gRPC: HTTP/2 e Protobuf, mais rápido, mas mais complexo.

### 8. Explique como funciona um gerenciamento de rotas de uma SPA.

Resposta:
- Monitoram a URL e carregam componentes dinamicamente sem recarregar a página, usando a API History do navegador.

### 9. Falando sobre DevOps, comente o que conhece sobre.

Resposta:
- Integra desenvolvimento e operações, automação, CI/CD, monitoramento e feedback contínuo.

### 10. Explique sobre um método agile.

Resposta:
- Scrum: Trabalho em sprints curtos, com papéis definidos e reuniões frequentes para ajustar o processo.

### 11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

Resposta:
- CI: Integração contínua, testes automáticos.
- CD: Deploy contínuo, automação de deploy.
- Ferramentas: Jenkins, GitHub Actions, GitLab CI.

### 12. Qual a diferença entre Docker e Containers.

Resposta:
- Containers: Isolamento leve para aplicações.
- Docker: Plataforma para criar e gerenciar containers.

### 13. Qual a diferença entre Kubernetes e Openshift?

Resposta:
- Kubernetes: Orquestra containers.
- Openshift: Kubernetes + ferramentas adicionais da Red Hat.

### 14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

Resposta:
- Vantagens: Integração fácil, reutilização de código.
- Desvantagens: Complexidade, latência.
- Preocupações: Segurança, versão, escalabilidade.

### 15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

Resposta:
- Autenticação/autorização forte, HTTPS, validação de entrada, limitação de taxa, monitoramento.

### 16. Para que serve uma arquitetura de mensagerias?

Resposta:
- Comunicação assíncrona entre serviços, melhor escalabilidade e resiliência.

### 17. Explique a estratégia SAGA em arquitetura de microservice.

Resposta:
- Gerencia transações distribuídas com mensagens de compensação, garantindo consistência eventual.

### 18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

Resposta:
- Configurações e definições de estado no Git, mudanças aplicadas automaticamente ao cluster Kubernetes.
s