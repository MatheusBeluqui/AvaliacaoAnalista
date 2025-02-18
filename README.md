# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

Há alguns anos, conheci o canal no YouTube [DevOps Bootcamp](https://www.youtube.com/@DevOpsBootcamp), onde tive a oportunidade de aprender sobre processos de DevOps.
Um dos temas abordados foi a criação de aplicações mais escaláveis, confiáveis e fáceis de manter, especialmente em ambientes de nuvem. Esse conceito me fez lembrar do Twelve-Factor App, que define boas práticas para o desenvolvimento de software.

Abaixo, listo seis fatores do Twelve-Factor App que considero importantes:

1º: Config (Configuração) – Todas as configurações da aplicação, como credenciais de banco e chaves de API, devem ser armazenadas em variáveis de ambiente, nunca no código. Isso evita a exposição de dados sensíveis e facilita a troca de configurações entre ambientes (desenvolvimento, teste, produção).

2º: Dependencies (Dependências) – A aplicação deve declarar todas as suas dependências de forma explícita (exemplo: package.json no Node.js). Isso garante que qualquer ambiente onde a aplicação for executada tenha exatamente o que ela precisa, sem depender de pacotes instalados no sistema operacional.

3º: Logs – Os logs da aplicação devem ser tratados como um fluxo contínuo de eventos e enviados para um sistema externo de monitoramento (como Elastic Stack ou Datadog). Isso facilita a análise e o acompanhamento do que está acontecendo na aplicação em tempo real.

4º: Build, Release, Run (Construção, Lançamento e Execução) – O processo de deploy deve ser dividido em três etapas:

Build: Compilar o código e gerar os arquivos prontos para execução.
Release: Combinar o código gerado com as configurações necessárias para produção.
Run: Executar a aplicação com a versão lançada.
Isso evita mudanças inesperadas no ambiente e garante estabilidade no deploy.

5º: Concurrency (Concorrência) – A aplicação deve ser projetada para rodar múltiplas instâncias (processos) de forma escalável. Isso permite que diferentes partes da aplicação rodem separadamente (exemplo: um processo para requisições web e outro para processamento de filas), melhorando o desempenho.

6º: Admin Processes (Processos Administrativos) – Tarefas administrativas, como migração de banco de dados ou scripts de manutenção, devem ser executadas separadamente da aplicação principal. Isso evita interferências na operação normal do sistema.


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

As camadas de desenvolvimento de software podem variar dependendo das necessidades do projeto.
Listo as que eu julgo ser importantes:

- Camada de Apresentação (Interface do Usuário);
- Camada de Aplicação (Lógica de Negócios);
- Camada de Dados (Banco de Dados);
- Camada de Infraestrutura (Sistema Operacional e Hardware);
- Camada de Serviços (APIs e Microserviços);
- Camada de Segurança;
- Camada de Testes.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Tenho trabalhado em um contexto de microfrontends e arquitetura MVC (Model-View-Controller), que se encaixam bem em sistemas baseados em microserviços.

- Arquitetura de Microserviços: o sistema é dividido em pequenos serviços independentes e autônomos, que podem ser desenvolvidos, implantados e escalados de forma independente. Cada microserviço é responsável por uma funcionalidade específica e comunica-se com outros microserviços através de APIs leves (geralmente HTTP RESTful);

- Arquitetura SOA (Arquitetura Orientada a Serviços): foca na construção de sistemas como um conjunto de serviços reutilizáveis e bem definidos. Visa a integração entre diferentes sistemas de forma centralizada, o que pode gerar um maior acoplamento entre os componentes.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

Fornecer uma camada centralizada para gerenciar, monitorar, proteger e facilitar o consumo de APIs. Ele serve como um intermediário entre os consumidores de API e os serviços oferecidos, proporcionando um controle mais eficaz sobre o tráfego de dados e facilitando a integração e comunicação entre sistemas diferentes.

Vantagens:
- Segurança: ele fornece mecanismos robustos de autenticação, autorização e proteção contra ataques, além de criptografia de dados;
- Facilidade de Monitoramento: Permite o monitoramento em tempo real das APIs, com relatórios sobre uso, performance, erros e latência. Isso ajuda na identificação rápida de problemas e otimização de desempenho;
- Controle de Versionamento: Ajuda a gerenciar diferentes versões de APIs, facilitando a migração e garantindo a compatibilidade entre consumidores e provedores ao longo do tempo;
- Política de Acesso: Facilita a aplicação de políticas de acesso, como rate limiting (limitação de requisições por um tempo), garantindo que serviços não sejam consumidos excessivamente;
- Documentação Automática: Muitos sistemas de API Management geram documentação automaticamente, facilitando o consumo das APIs pelos desenvolvedores;
- Agilidade na Integração: Facilita a integração de sistemas heterogêneos, fornecendo um ponto central para a exposição de APIs e serviços.

Desvantagens:
- Ponto Único de Falha: Como o API Management centraliza o tráfego de APIs, ele se torna um ponto único de falha. Se o sistema de gerenciamento falhar, isso pode afetar todos os consumidores de API;
- Desempenho: O API Management adiciona uma camada extra entre o consumidor e o provedor de serviços, o que pode introduzir latência, afetando a performance geral do sistema;
- Dependência da Plataforma: Se uma solução de API Management de um fornecedor específico for escolhida, pode haver uma dependência de tecnologia, o que limita a flexibilidade de escolha futura ou a portabilidade entre plataformas;
- Custo Adicional: Implementar e manter uma solução de API Management pode envolver custos extras, especialmente em soluções mais complexas, como o uso de plataformas de terceiros ou ferramentas especializadas.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

A diferença está relacionada ao comportamento em memória, herança e semântica de dados. Ambas são usadas para agrupar dados, mas com algumas diferenças importantes:

Struct:
- Tipo valor por cópia;
- Não pode herdar de outras structs ou classes;
- Alocada na pilha (stack - armazena dados temporários);
- Não pode ser nula, a menos que seja Nullable;
- Mais eficiente em termos de memória e velocidade;
- Útil para tipos pequenos e imutáveis.

Class:
- Tipo referência;
- Suporta herança;
- Alocada no heap (armazena dados com vida útil mais longa em tempo de execução);
- Pode ser nula;
- Menos eficiente devido à alocação no heap;
- Melhor para objetos complexos que exigem herança ou polimorfismo.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET ou .NET Framework foi lançado em 2002 e é exclusivo para Windows, monolítico, com mais bibliotecas e APIs, mas menos eficiente, menos flexível e não otimizado para desempenho em ambientes modernos.

Já o .NET Core foi lançado em 2016 e é uma versão mais leve e flexível da plataforma .NET. É multiplataforma, modular e mais eficiente em termos de desempenho e focado no desenvolvimento de aplicações modernas.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

As principais diferenças estão relacionadas à forma de comunicação, desempenho, protocolos utilizados, tipos de dados e casos de uso.

REST:
- Protocolo HTTP/1.1 ou HTTP/2;
- Comunicação baseada em texto (JSON ou XML), com suporte para verbos HTTP como GET, POST, PUT, DELETE, etc;
- É baseado em requisição-resposta;
- É mais simples e amplamente adotado;
- É ideal para APIs públicas e aplicações web.

GRPC:
- Usa apenas HTTP/2;
- Usa Protocol Buffers (binário e mais eficiente);
- É mais rápido e eficiente devido ao formato binário e ao uso do HTTP/2;
- Suporta chamadas síncronas, assíncronas e streaming bidirecional;
- Requer configuração de interfaces e é mais complexo;
- É mais adequado para microserviços e sistemas de alto desempenho.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

O gerenciamento de rotas em uma SPA (Single Page Application) é fundamental para garantir uma navegação fluida sem recarregar a página inteira.
Em frameworks como Angular, React ou Vue, as rotas são configuradas dentro de um módulo ou arquivo de configuração, onde você pode mapear caminhos de URL para componentes específicos. O roteador é configurado para capturar as mudanças na URL e renderizar os componentes apropriados sem a necessidade de recarregar a página.
A navegação é rápida e fluida, e recursos podem ser carregados sob demanda para melhorar a performance.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

Estudei sobre DevOps há um tempo como mencionei na primeira resposta do questionário e o que aprendi sobre é que são práticas e ferramentas que visa unificar, integrar e automatizar os processos de desenvolvimento de software e operações de TI. 
A cultura DevOps incentiva na colaboração entre equipes de desenvolvimento e operações, permitindo uma entrega mais rápida, eficiente e de  alta qualidade, com menos erros.


10. Explique sobre um método agile.

**Resposta:**

Atualmente, trabalho com Scrum e tenho conhecimento sobre os rituais, que facilitam a organização do trabalho e garantem a entrega eficiente de valor ao cliente. O Scrum é um dos métodos mais populares e é baseado em ciclos curtos de desenvolvimento chamados sprints. Ele define papéis como Product Owner, Scrum Master e a equipe de desenvolvimento, além de ter cerimônias como a Daily Standup, Sprint Planning, Sprint Review e Sprint Retrospective. O foco é entregar incrementos de valor de forma contínua.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

A Integração Contínua (CI) é uma prática de desenvolvimento onde os desenvolvedores frequentemente integraram o código no repositório compartilhado. Isso é feito várias vezes ao dia, permitindo detectar rapidamente erros de integração e de código. A ideia é ter um processo automatizado de construção e testes para garantir que o código enviado não quebre o sistema e esteja em um estado funcional a todo momento.
Ferramentas para CI (Jenkins, Travis, Circle, GitLab) e dentre essas ferramentas eu já usei GitLab no processo de integração e deploy.

A Entrega Contínua (CD) vai além da CI, garantindo que o código integrado seja automaticamente preparado para produção. Com Entrega Contínua, o código passa por testes automáticos e é preparado para ser implantado de forma contínua, mas o deployment pode ser feito manualmente ou em um ambiente de produção controlado.
O Desdobramento Contínuo (Continuous Deployment) é uma prática mais avançada, onde o código aprovado nos testes é automaticamente implantado em produção, sem intervenção manual.
Ferramentas para CD (Jenkins, GitLab, Spinnaker, AWS CodePipeline, Azure DevOps) e dentre essas ferramentas eu utilizo o Azure DevOps.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Containers são unidades de software que empacotam e isolam um aplicativo e todas as suas dependências (como bibliotecas, arquivos e configurações necessárias) em uma unidade de execução consistente. São baseados em tecnologias de virtualização que compartilham o mesmo sistema operacional subjacente, mas com isolamento completo entre os processos. São mais leves e rápidos em termos de recursos.

Docker é uma plataforma que facilita a criação, implantação e execução de containers. Ele fornece ferramentas e APIs para criar, testar e gerenciar containers de maneira simples. Ele automatiza o processo de empacotar e configurar o ambiente necessário para os containers, tornando o processo de criação e distribuição mais eficiente.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Ambos são plataformas de orquestração de containers, mas o OpenShift é uma solução baseada no Kubernetes com algumas adições e modificações específicas. Diferenças:

Kubernetes:
- Plataforma open-source para orquestração de containers;
- Permite mais flexibilidade, podendo rodar containers com permissões elevadas (root);
- Exige mais configuração e personalização;
- Não inclui ferramentas de CI/CD nativas, sendo necessário configurar separadamente;
- Tem uma comunidade open-source e suporte de diversas distribuições.

OpenShift:
- É uma distribuição do Kubernetes com funcionalidades adicionais, criada pela Red Hat;
- Tem políticas de segurança mais rígidas, como containers não podendo rodar como root por padrão;
- Oferece uma interface gráfica mais amigável e recursos integrados;
- Inclui funcionalidades de CI/CD integradas, facilitando a automação de builds e deploys;
- Oferece suporte corporativo pago, ideal para empresas que precisam de estabilidade e garantia de suporte.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

APIs oferecem muitos benefícios em termos de modularidade, escalabilidade e integração, mas exigem uma boa gestão e práticas adequadas de segurança, manutenção e documentação.

Vantagens:
- Desacoplamento: APIs permitem que diferentes sistemas e serviços se comuniquem sem que uma parte precise saber como a outra foi implementada, facilitando a evolução independente das partes;
- Reusabilidade: Uma API bem definida pode ser reutilizada por diferentes aplicações, economizando tempo e esforço de desenvolvimento;
- Escalabilidade: APIs permitem que a arquitetura de sistemas cresça mais facilmente, pois é possível integrar novos serviços ou aumentar a carga de trabalho sem grandes mudanças nas aplicações principais;
- Facilidade de Integração: APIs tornam mais simples a integração com sistemas externos, como serviços de terceiros ou novos módulos dentro do próprio sistema;
- Adoção de Novas Tecnologias: Facilitam a migração de tecnologias, já que você pode substituir uma parte do sistema sem afetar o restante da arquitetura;
- Segurança: As APIs podem ser configuradas com medidas de segurança (autenticação, autorização, criptografia) para proteger dados e interações.

Desvantagens:
- Complexidade de Manutenção: À medida que o número de APIs aumenta, também aumenta a complexidade de gerenciar, versionar e documentar todas as interfaces;
- Latência: Cada chamada de API pode adicionar uma sobrecarga de latência, especialmente se houver comunicação entre múltiplos serviços ou se a rede não for eficiente;
- Segurança: A exposição de APIs pode abrir portas para riscos de segurança, especialmente se não forem adotadas práticas de segurança adequadas, como autenticação, controle de acesso e criptografia;
- Dependências Externas: Se uma API externa falhar ou não estiver disponível, pode comprometer a funcionalidade de todo o sistema, causando impactos no negócio;
- Gerenciamento de Versionamento: Alterações nas APIs podem quebrar integrações existentes, exigindo um controle de versão cuidadoso.

As preocupações que devemos ter ao usar APIs são:
- Definição de objetivos e casos de uso;
- Segurança;
- Performance: evitar problemas de latência ou gargalos;
- Versionamento;
- Documentação;
- Monitoramento e Logs.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Adotar boas práticas e implementar uma série de medidas que protejam tanto os dados quanto as integrações entre os sistemas.
Por exemplo: implementar autenticação e autorização, criptografias, validação de entrada (dados, limite de acessos, tamanhos), monitoramentos, restrições e segurança (verificação de vulnerabilidades, gerenciamento de tokens e sessões). Eu acredito que com essas abordagens preventivas já vamos garantir um nível de segurança interessante no manuseio de APIs.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Uma arquitetura de mensageria é uma forma de fazer com que diferentes sistemas, aplicativos ou serviços se comuniquem de maneira eficiente. Ao invés de esperar que um sistema responda imediatamente, os sistemas trocam mensagens. Isso permite que eles se comuniquem sem travar uns aos outros, mesmo em grandes volumes de dados. É como se fosse um serviço de correios digital, que entrega as mensagens de um sistema para o outro sem que eles precisem parar o que estão fazendo.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

A estratégia SAGA é um padrão de gerenciamento de transações em sistemas distribuídos onde a consistência e a integridade dos dados precisam ser mantidas sem depender de um banco de dados centralizado. Ao invés de usar uma única transação que abrange vários microserviços, a SAGA divide a transação em uma série de transações menores, cada uma executada por um microserviço específico. Ela ajuda a garantir a consistência e a integridade do sistema sem precisar de um único ponto de controle.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

GitOps permite que você defina, gerencie e implemente configurações de clusters Kubernetes através de repositórios Git, mantendo a infraestrutura e os aplicativos sincronizados automaticamente com o que está armazenado no Git.