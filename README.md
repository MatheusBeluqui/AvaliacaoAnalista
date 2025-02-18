# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**
- Logs:
	- Tratar logs como streams de eventos;
	- Evitar gravá-los em arquivos locais;
	
- Configurações:
    – Armazenar configurações em variáveis de ambiente;
    - Evitar armazenar no código;
	
- Código Base:
	- Manter uma única base de código; 
	- Versionar;
	- Realizar Deploys em múltiplos ambientes;

- Processos: 
	- Executar a aplicação como processos stateless;
	- Compartilhar via armazenamento;

- Dependências: 
	– Declarar e isolar dependências em um gerenciador como por exemplo: npm, pip, composer;
	
- Concorrência: 
	- Escalar a aplicação criando múltiplas instâncias de processos;
**

2. Quais são as principais camadas no desenvolvimento de um software?

**
- Camada de apresentação (frontend): gerencia a interface com o usuário, podendo pertencer a uma aplicação desktop, web ou aplicativo. As principais tecnologias da camada de apresentação são: HTML, CSS, JavaScript, React, Angular, etc. A partir da camada de  apresentação é realizada a comunicação com o backend por meio de APIs; 

- Camada de Aplicação (backend): gerencia toda a lógica, regras de negócio e validações. Também implementa serviços, APIs e define fluxos de trabalho. As principais tecnologias são: C# (.NET), Java (Spring Boot), Python, etc.

- Camada de Persistência (Banco de dados): gerencia o armazenamento e recuperação dos dados. Podendo ser relacional (PostgreSQL, SQL Server, etc), NoSQL (MongoDB, Firebase, etc). Pode ser trabalhado por meio da utilização de ORMs tais como: Sequelize, Entity Framework, etc.
**


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**
- Escopo: 
	- (SOA) Integração de sistemas grandes;
	- (Microserviços) Aplicações modulares e escaláveis;
	
- Acoplamento: 
	- (SOA) Moderado a alto;
	- (Microserviços) Baixo;
	
- Banco de Dados: 
	- (SOA) Compartilhado entre serviços;
	- (Microserviços) Cada serviço tem seu próprio banco;
	
- Comunicação: 
	- (SOA) ESB, SOAP, XML;
	- (Microserviços) REST, gRPC, Kafka, RabbitMQ;
	
- Escalabilidade: 
	- (SOA) Limitada pelo ESB;
	- (Microserviços) Alta escalabilidade independente;
	
- Governança: 
	- (SOA) Centralizada;
	- (Microserviços) Descentralizada;
	
- Manutenção: 
	- (SOA) Mais difícil por acoplamento;
	- (Microserviços) Mais fácil devido à modularidade;
**


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**
O gerenciamento de APIs é como um conjunto de regras e ferramentas que ajudam a organizar e proteger as conexões entre diferentes sistemas e aplicativos. Ele funciona como um "porteiro" que controla quem pode acessar as APIs, acompanha o uso delas e garante que tudo funcione de forma segura e eficiente.

Em sistemas onde vários serviços se comunicam entre si, como em aplicativos modernos, esse gerenciamento ajuda a evitar sobrecarga, melhorar a segurança e garantir que tudo esteja funcionando corretamente.

- Vantagens:
	- Segurança e Controle de Acesso;
	- Controle de Tráfego e Rate Limiting;
	- Monitoramento e Analytics;
	- Versionamento e Governança;
	- Facilidade de Integração;
	
- Desvantagens: 
	- Custo Adicional;
	- Latência Adicional;
	- Complexidade na Implementação;
**


5. Qual a diferença entre uma Struct e uma Class?

**
A diferença fundamental entre 'Struct' e 'Class' está na forma como são armazenadas e gerenciadas na memória.

 - Struct: Armazenada na stack (pilha), não suporta herança, tipo por valor;
 - Class: Armazenada na heap (memória dinâmica), suporta herança e polimorfismo;
**


6. Explique a grande diferença entre .NET e .NET CORE.

**
A grande diferença está no fato do .NET CORE ser multiplataforma (roda no Windows, Linux, macOS) enquanto que o .NET roda apenas no Windows.
**


7. Quais as principais diferenças entre REST e GRPC?

**
A principal diferença entre REST e gRPC é a maneira como se comunicam, a eficiência que oferecem e o suporte para diferentes linguagens de programação.
**


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**
Permite navegação fluída e responsiva entre seções e páginas de uma aplicação sem recarregar toda a página, melhorando a experiência do usuário.
**


9. Falando sobre DevOps, comente o que conhece sobre.

**
DevOps é uma ideia e um conjunto de práticas que busca juntar o desenvolvimento de software (Dev) com as operações de TI (Ops). O principal objetivo do DevOps é acelerar o processo de desenvolvimento, aumentar a frequência das entregas e melhorar a qualidade do software, tudo isso através de colaboração, automação e feedback constante.
**


10. Explique sobre um método agile.

**
Scrum: uma maneira de organizar e gerenciar projetos de forma flexível e gradual. Embora seja muito usado para criar software, pode ser aplicado em qualquer tipo de projeto que precise se adaptar rapidamente às mudanças. É como se fosse um conjunto de regras que ajuda as equipes a trabalhar de forma mais eficiente e a fazer ajustes quando necessário.
**


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**
CI (Integração Contínua) e CD (Entrega Contínua/Implantação Contínua) são práticas super importantes no desenvolvimento ágil que ajudam a automatizar e tornar mais fácil a entrega de software:

- Integração Contínua (CI) é uma prática onde os desenvolvedores colocam seu código em um repositório que todo mundo usa várias vezes ao dia. A ideia é pegar erros rapidinho, melhorar a qualidade do software e acelerar o tempo de entrega.

- Entrega Contínua/Continuous Deployment (CD) são práticas que estendem o conceito de CI:
	- Entrega Contínua garante que o software esteja sempre pronto para ser lançado a qualquer hora. As mudanças no código são  testadas automaticamente, e a equipe pode colocar essas atualizações em produção com um clique ou um comando bem fácil.
	
	- Implantação Contínua leva a entrega contínua para o próximo nível. As mudanças são colocadas automaticamente em produção  assim que passam nos testes, sem precisar de ninguém para fazer isso manualmente. Isso ajuda a ter um retorno ainda mais  rápido sobre as alterações.
**


12. Qual a diferença entre Docker e Containers.

**
- Docker: plataforma de código aberto que ajuda a criar, implantar e gerenciar containers. É uma ferramenta que torna mais fácil construir aplicações em ambientes isolados, facilitando o empacotamento e a distribuição de software.

- Containers: pacotes leves e portáteis que guardam uma aplicação e tudo o que ela precisa para rodar, permitindo que sejam executadas de forma isolada em qualquer lugar. Eles usam o mesmo núcleo do sistema operacional, mas funcionam como se fossem ambientes independentes.
**


13. Qual a diferença entre Kubernetes e Openshift?

**
- Kubernetes: sistema de gerenciamento de containers criado pelo Google. Ele facilita a automação da implantação, escalonamento e gerenciamento de aplicações que rodam em containers.

- OpenShift: plataforma de containers que se baseia no Kubernetes e foi criada pela Red Hat. É uma versão do Kubernetes que traz recursos extras para facilitar o desenvolvimento e a implantação de aplicações.
**


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**
- Vantagens:
	- Reusabilidade;
	- Interoperabilidade;
	- Facilidade de Integração;
	- Segurança;
	- Escalabilidade;
	
- Desvantagens:
	- Complexidade;
	- Desempenho;
	- Gerenciamento de Versionamento;
	- Dependências;
	
- Preocupações:
	- Design da API: Tenha um design claro e consistente, usando princípios RESTful ou GraphQL quando necessário;
	- Documentação: Crie uma documentação acessível e completa para ajudar outros desenvolvedores a adotar a API;
	- Autenticação e Autorização: Use métodos seguros, como OAuth, para proteger a API e controlar o acesso;
	- Gerenciamento de Versionamento: Planeje como lidar com as versões da API para evitar interrupções para os usuários;
	- Monitoramento e Logging: Implemente monitoramento e registro para acompanhar o uso da API e detectar problemas rapidamente;

**


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**
- Autenticação Forte;
- Controle de Acesso;
- HTTPS Sempre;
- Validação de Entrada;
- Rate Limiting (limites nas requisições);
- Monitoramento e Logging;
- Atualizações e Patches;
- CORS Configurado;
**


16. Para que serve uma arquitetura de mensagerias?

**
Uma arquitetura de mensageria é uma forma de fazer com que diferentes partes de um sistema se comuniquem, especialmente em aplicativos que estão espalhados por várias máquinas.
**


17. Explique a estratégia SAGA em arquitetura de microservice.

**
A estratégia SAGA é um jeito de gerenciar transações em sistemas de microserviços, garantindo que os dados permaneçam consistentes em operações que envolvem várias partes. Em vez de usar aquelas transações de banco de dados tradicionais (que podem ser complicadas em microserviços), a SAGA quebra uma transação em várias operações menores, que são gerenciadas uma por uma.
**


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**
GitOps é uma maneira de gerenciar e entregar infraestrutura e aplicações usando o Git como a única referência. No caso do Kubernetes, o GitOps traz várias práticas que ajudam a automatizar e facilitar a implantação e o gerenciamento de aplicações.**
