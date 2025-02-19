# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:** Acredito que pode variar para cada padrão de projeto, mas geralmente utilizo as seguintes camadas.
Domain:
    Camada responsável pelas entidades e pelas regras de negócio do domínio da aplicação
Application:
    Camada responsável pela regra de negócio e pelo processamento de dados, como validação de dados, por exemplo. 
Presentation:
    Camada responsável pela interface de usuário, o frontend da aplicação. Se for uma aplicação web é nessa camada que ficam os componentes de interface
    HTML, CSS e javascript

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O objetivo de um API Managemnt é facilitar o gerenciament e a segurança de um sistema de serviços baseados em API's.
As principais vantangens são a segurança, escalabilidade e a documentação.
E as principais desvantagens são o custo e a complexidade na sua implementação.
O principal exemplo que conheço é o Azure API Management.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** Em uma Struct é possível definir apenas propriedades e é utilizado para construir DTO's, já em uma classe é possível definir além das propriedades, os métodos.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** No meu entendimento a grande diferença é que o .Net funciona apenas em Windows e o .Net Core funciona não apenas em Windows quanto 
em outros sistemas operacionais, como Mac OS e Linux


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST Trabalha normalmente com JSON além de que os endpoints serem identificados por URI'S e é baseado em HTTP 1.1 através dos protocolos GET, POST, PUT e DELETE.
GRPC utiliza o protocolo de buffers.



8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**


10. Explique sobre um método agile.

**Resposta:**
Nesse caso vou abordar o Scrum, que é uma maneira que permite as equipes trabalhar de uma forma colaborativa em períodos curtos de trabalho (Sprint). 
Participam o Product Owner que faz as intermediações com o cliente além de definir as prioridades do projeto. As vezes pode existir a presençao de um Scrum Master que é 
o responsável por minimizar os impedimentos e garantir as boas práticas do Scrum. 
A equipe atua com um Backlog definido a cada sprint.
As sprints são marcadas por algumas cerimônias, nas quais as principais podem ser a Sprint Planning, Sprint review e as dailies.
E o objetivo é garantir o máximo das entregas previstas no início de cada sprint. 


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** Conheço o Azure DevOps e o Jenkins. O principal objetivo do CI/CD é garantir a entrega diária dos desenenvolvedores de um projeto e garantir o deploy em seus devidos ambientes. 


12. Qual a diferença entre Docker e Containers.

**Resposta:** Docker é a uma ferramenta utilizada para o gerenciamento e execução de containers. Já os containers é uma forma de 
distribuir uma aplicação com as suas dependências. O que facilita o trabalho em uma equipe de desenvolvimento, pois, garante que toda a 
equipe trabalhe sob o mesmo ambiente independente também do sistema operacional e versões de outras aplicações instaladas no sistema operacional. 


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
VANTAGENS:
Uma das principais vantagens da utilização de API's é a facilidade em que diferentes sistemas podem se comunicar entre si e também 
a facilidade em que novos serviços podem ser adicionados ao sistema e também que diferentes fucnionalidades podem ser desenvolvidas e mantidas 
com facilidade. 


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Uma boa política de segurança, geralmente utilizando autenticação e permissões baseadas em roles, utilizando tokens de autenticação, 
prevenir ao máximo a possibilidade de injeções SQL no sistema


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Em sistemas baseados em micro serviços, onde cada serviço desconhece as regras de negócio um de outros, o ssistema de mensageria é fundamental
para garantir a comunicação entre os serviços. Por exemplo, em um sistemas de pedidos, ao realizar o pedido de um determinado produto, o serviço de estoque
desconhece os serviços de produtos, dos pedidos e de pagamento. Ao ser ralizado os request para o pagamento e esse for bem sucedido, por exemplo, o serviço do
pagamento publica uma mensagem para o serviço do estoque que irá consumir essa mensagem para dar baixa da quantidade dos produto que foi vendida, e ao mesmo tempo
também publica uma mensagem para o serviço des pedidos para o usuário saber que a compra foi bem sucedida.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
