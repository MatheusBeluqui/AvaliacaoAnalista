# Desafio

Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto. Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

   - **Codebase**: Cada aplicação deve ter uma base de código única, armazenada em um repositório versionado.
   - **Dependencies**: Todas as dependências da aplicação devem ser declaradas, facilitando a reprodutibilidade em diferentes ambientes.
   - **Config**: Configurações específicas de ambiente devem ser separadas do código e definidas por variáveis de ambiente.
   - **Backing Services**: Qualquer serviço adicional (banco de dados, cache) deve ser tratado como um recurso externo e conectável.
   - **Build, Release, Run**: O ciclo de vida da aplicação deve ser dividido em três fases: build (compilação), release (preparação) e run (execução).
   - **Logs**: Logs são fluxos de eventos e não devem ser gerenciados pela aplicação, mas por um serviço externo de captura e processamento.

2. Quais são as principais camadas no desenvolvimento de um software?

   As principais camadas são:
   - **Apresentação (UI)**: Interface com o usuário.
   - **Aplicação**: Intermediária que controla o fluxo de dados entre UI e Domínio.
   - **Domínio**: Contém as regras de negócio.
   - **Infraestrutura**: Suporta as outras camadas, incluindo persistência de dados e comunicação externa.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

   A arquitetura **SOA** organiza serviços em módulos grandes com foco na reutilização, enquanto a **Arquitetura de Microserviços** divide responsabilidades em serviços pequenos, independentes e escaláveis.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

   - **Objetivo**: API Management gerencia, monitora e protege APIs.
   - **Vantagens**: Segurança centralizada, controle de tráfego e escalabilidade.
   - **Desvantagens**: Pode adicionar latência e complexidade na configuração.

5. Qual a diferença entre uma Struct e uma Class?

   - `Struct` é um tipo de valor, alocado na pilha, mais eficiente para dados menores.
   - `Class` é um tipo de referência, alocado no heap e suporta herança, adequado para estruturas maiores.

6. Explique a grande diferença entre .NET e .NET CORE.

   `.NET Framework` é voltado para Windows, enquanto `.NET Core` (agora .NET 5+) é multiplataforma e ideal para aplicações de alto desempenho e escaláveis.

7. Quais as principais diferenças entre REST e GRPC?

   REST usa HTTP e JSON, sendo simples e amplamente usado. gRPC utiliza HTTP/2 e Protobuf, ideal para comunicações rápidas e bidirecionais entre microsserviços.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

   Em uma SPA, o roteador JavaScript gerencia as URLs e carrega os componentes dinamicamente, sem recarregar a página.

9. Falando sobre DevOps, comente o que conhece sobre.

   Sobre DevOps ja trabalhei com as ferramentas Azure e AWS, criando a pipelines CI/CD, utilizando o jenkins e github.

10. Explique sobre um método agile.

    O **Scrum** organiza o trabalho em Sprints e promove adaptação contínua e entregas incrementais com comunicação frequente.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

    - CI (Integração Contínua) verifica e integra o código automaticamente.
    - CD (Entrega Contínua) prepara o código para produção.
    - Ferramentas: **Jenkins**, **GitLab CI**, **Azure DevOps**.

12. Qual a diferença entre Docker e Containers.

    Docker é uma plataforma para criar e gerenciar containers, enquanto containers são unidades leves que isolam aplicações e suas dependências.

13. Qual a diferença entre Kubernetes e Openshift?

    Kubernetes orquestra containers, enquanto OpenShift adiciona funcionalidades sobre Kubernetes, como uma interface amigável e segurança aprimorada.

14. **Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?**

    - **Vantagens**: Flexibilidade e integração entre serviços.
    - **Desvantagens**: Aumento da complexidade e riscos de falhas.
    - **Preocupações**: Segurança, versionamento e escalabilidade.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

    Com autenticação, criptografia (HTTPS), controle de acesso e limites de requisição (rate limiting).

16. Para que serve uma arquitetura de mensagerias?

    Facilita a comunicação assíncrona entre serviços, melhorando escalabilidade e desacoplamento.

17. Explique a estratégia SAGA em arquitetura de microservice.

    SAGA gerencia transações distribuídas por meio de passos compensatórios, garantindo consistência entre serviços sem bloquear comunicações.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

    GitOps usa o Git como fonte central para configurações e implantações em Kubernetes, permitindo automação e auditoria de mudanças com CI/CD integrados.