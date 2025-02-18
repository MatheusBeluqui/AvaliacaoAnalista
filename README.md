# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
É uma metodologia que ajuda na construção de aplicações escaláveis, dentre os principais fatores, cito:
a aplicação deve ter uma única base de código versionada para múltiplos ambientes; 
todas as dependências devem ser explicitamente declaradas; 
configurações como chaves de API e credenciais devem ser armazenadas no ambiente, nunca no código;
serviços de apoio,como bancos de dados, devem ser tratados como recursos externos substituíveis;
o processo de desenvolvimento deve ser dividido em etapas claras de build, release e run; 
e a aplicação deve ser executada como processos stateless, sem armazenar estado localmente, facilitando a escalabilidade.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
As principais camadas são a camada de apresentação que representa a interface do Usuário; camada de aplicação onde fica a lógica de negócios;
camada de dados que contem o banco de dados; camada de infraestrutura que representa o sistema operacional e o hardware; camada de serviços 
que é APIs e microserviços; camada de Segurança; camada de Testes.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
A principal diferença entre a arquitetura orientada a serviços (SOA) e a arquitetura de microsserviços está no escopo: 
a SOA atua em nível empresarial, enquanto os microsserviços focam em uma única aplicação. A SOA segue uma abordagem 
centralizada de cima para baixo, com um portfólio de serviços compartilhados e reutilizados em toda a empresa, 
utilizando um barramento de serviço empresarial (ESB) para conectar os serviços, o que pode levar a problemas de 
acoplamento e exigir alta coordenação. Já os microsserviços adotam um modelo descentralizado de baixo para cima, dividindo 
uma aplicação em serviços independentes, cada um com seu próprio armazenamento de dados e comunicação via sistemas simples
como APIs RESTful, JMS ou pub/sub, resultando em uma arquitetura mais modular, resiliente e flexível.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
Centralizar e gerenciar o ciclo de vida das APIs, facilitando o controle de acesso, segurança, monitoramento, escalabilidade
e integração entre serviços. Ele atua como um intermediário que simplifica a comunicação entre os serviços e os consumidores, 
garantindo eficiência e padronização. A vantagem é que O API Management oferece segurança aprimorada, com controle de autenticação 
e proteção contra ameaças, além de facilitar o monitoramento e análise do uso das APIs, permitindo a identificação de gargalos
e a otimização do desempenho Por outro lado, sua implementação e manutenção podem gerar custos adicionais, e a
complexidade introduzida pode exigir uma camada extra de configuração e gerenciamento, demandando conhecimento específico para
operação eficiente.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
A diferença entre struct e class está principalmente no armazenamento e no comportamento. Uma struct é um tipo de valor,
armazenado diretamente na memória, copiado por valor e ideal para objetos leves e imutáveis. Já uma class é um tipo de 
referência, armazenada como um ponteiro para a memória, copiada por referência e mais adequada para objetos
complexos com gerenciamento de estado. Além disso, structs não permitem herança, enquanto classes suportam herança e polimorfismo,
oferecendo maior flexibilidade para modelagem de hierarquias. Em resumo, structs são usadas para dados simples, e classes para
objetos mais complexos.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
A diferença entre .NET e .NET Core está na sua abordagem e alcance. O .NET é uma plataforma mais antiga, voltada principalmente 
para o Windows, sendo usada para desenvolver aplicações desktop, web e serviços tradicionais. Por outro lado, o .NET Core, que agora 
é parte do .NET 5+, é uma versão moderna, leve e multiplataforma, compatível com Windows, Linux e macOS. Ele foi projetado para 
cenários mais atuais, como microsserviços, aplicações em nuvem e containers, além de ser open source e ter suporte nativo para 
ferramentas como Docker.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
O REST é um estilo arquitetônico utilizado para criar APIs web. Ele se baseia no protocolo HTTP e geralmente utiliza formatos de
dados como JSON ou XML, que são fáceis de ler e interpretar. O REST é conhecido por sua simplicidade e flexibilidade, sendo ideal
para integrações com navegadores, aplicativos móveis e sistemas heterogêneos. Ele funciona com operações padrão, como GET, POST, 
PUT e DELETE, para manipular recursos. No entanto, não tenho conhecimento sobre o gRPC, então não posso comentar sobre suas 
características ou compará-lo com o REST.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O gerenciamento de rotas em uma SPA permite a navegação entre diferentes views ou componentes sem recarregar a página inteira,
proporcionando uma experiência fluida ao usuário. Isso é feito no lado do cliente, onde um roteador JavaScript mapeia URLs específicas 
para componentes correspondentes por exemplo, /sobre carrega o componente "Sobre". Quando uma rota é acessada, o conteúdo é carregado
e renderizado dinamicamente, substituindo o anterior.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é um método que une desenvolvimento e operações para acelerar a entrega de software com qualidade, usando automação e colaboração.
O objetivo é tornar o processo mais ágil, eficiente e confiável.

10. Explique sobre um método agile.

**Resposta:**
O Scrum é uma maneira de organizar o trabalho em equipe para projetos, focando em entregas rápidas e contínuas. Ele divide o trabalho
em etapas curtas chamadas sprints. Podendo haver diariamente, uma reuniões rápidas para alinhar o progresso e resolver dificuldades.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI e CD são práticas que automatizam a integração e entrega de software, facilitando entregas rápidas. Ferramentas como GitLab CI/CD, 
GitHub Actions e Azure DevOps ajudam a testar e liberar o código automaticamente.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
O Docker é a ferramenta que ajuda a trabalhar com containers, enquanto containers são a forma de isolar e executar aplicações de 
maneira eficiente e portável.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes é uma plataforma de código aberto para gerenciar containers, enquanto o OpenShift é uma solução empresarial baseada no 
Kubernetes, com ferramentas adicionais e suporte integrado. 

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem? 

**Resposta:**
As APIs oferecem vantagens como integração simplificada entre sistemas, escalabilidade, reutilização de funcionalidades e flexibilidade
para diferentes tecnologias, como desvantagens tem a complexidade no desenvolvimento, os riscos de segurança, possíveis 
atrasos devido à latência e a necessidade de versionamento cuidadoso para evitar quebras. Ao adotar APIs, é essencial preocupar-se com
segurança, desempenho otimizado, versionamento bem planejado.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Para garantir um nível de segurança no uso de APIs, é necessário adotar práticas como autenticação, usando métodos como OAuth ou API keys 
e autorização para controlar os acessos, tambem é importante utilizar HTTPS para criptografar a comunicação, validar todas as
entradas de dados para prevenir ataques como injeção de SQL ou XSS, e implementar limitação de taxa para evitar abusos. Outras medidas 
incluem manter as APIs atualizadas e seguir boas práticas de desenvolvimento, como o uso de tokens de curta duração e a exposição mínima
de endpoints.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
A mensageria serve para facilitar a comunicação assíncrona e confiável entre sistemas, serviços ou componentes de uma aplicação. Ela permite
que diferentes partes de um sistema troquem informações por meio de mensagens, sem precisar se conectar diretamente ou estar ativas ao mesmo
tempo. Isso é especialmente útil em cenários onde a disponibilidade, escalabilidade e desacoplamento são importantes, como em microsserviços,
integrações entre sistemas ou processamento de tarefas em segundo plano. 

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
A estratégia SAGA é usada em microsserviços para gerenciar transações de forma consistente, já que cada microsserviço tem seu próprio banco de
dados e transações ACID tradicionais não são possíveis. Ela divide uma operação complexa em etapas menores, executadas por diferentes microsserviços.
Se uma etapa falhar, a SAGA aplica compensações para desfazer as etapas anteriores e manter a consistência. Contendo duas formas de ser implementada:
SAGA Orquestrada, com um orquestrador central controlando o fluxo, ou SAGA Coreografada, onde microsserviços se comunicam por eventos.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
GitOps usa o Git para gerenciar e automatizar o Kubernetes, sincronizando o cluster com o estado definido no repositório, garantindo consistência 
e facilidade de rollback.