# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

Infelizmente eu não conheço todos os processos, mas vou citar alguns que conheço e acho importantes:

	Código:
Na minha opinião, a parte mais importante, a base de código precisa ser bem escrita e centralizada (em um repositório por exemplo), uma estrutura bem feita e centralizada, abre os caminhos para fácil entendimento de qualquer dev que irá trabalhar na solução e também mantém o código sempre atualizado entra todos, além de manter ambientes (local, QA e prod) se comportando da mesma forma, como tem que ser;
	Configurações de ambiente:
Exatamente para não termos divergências de comportamento, principalmente, as configurações de ambiente devem ser separadas, a maioria das aplicações já começam por aí, deixando uma config pra cada ambiente pra na hora de compilar, o motor de compilação ter inteligência o suficiente pra saber o ambiente que está sendo utilizado e usar as configurações pertinentes de cada um;
	Dependências:
É raro hoje em dia uma aplicação que roda somente com a tecnologia usada, sem nenhuma dependência. Usando um exemplo do Angular, todas as dependências ficam separadas no “package.json”. Ali se encontra a versão que estamos usando da aplicação e todas suas dependências, tudo centralizado no mesmo lugar, com um comando (no caso do angular, ng install), é instalado todas as dependências do projeto.
	Logs:
Na minha opinião, toda aplicação precisa de log. Facilita em tudo, entendimento do processo, facilita manutenção etc. Logs são necessários principalmente para termos melhor entendimento de qualquer processo, principalmente onde ele quebra. Uma aplicação com uma boa estrutura de log, como temos a audit aqui na BTP, facilita e muito saber de todo o ciclo de vida não só da aplicação como dos dados tbm;

	Ciclo de vida:
A aplicação deve ter um ciclo de vida entre desenvolvimento, homologação e liberação e build, aonde é liberado o que já foi construído e testado em produção para acesso dos usuários finais;
	Processos:
É mais complicado trabalhar em uma aplicação que é um monolito, cheio de dependências entre si, a aplicação deve ter processos separados e responsabilidades bem descritas e tratadas de forma separada, dando a devida responsabilidade pra cada parte, isso ajuda tanto na manutenção quando na escalabilidade da aplicação.


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

Eu conheço basicamente 3 camadas:
Apresentação ou view: Aonde o usuário vai interagir com a aplicação e serão apresentados os dados pertinentes a aplicação e aquele usuário;
Regras de negócio: Aonde terão as regras que são implementadas e tratadas;
Persistência de dados: Aonde os dados tanto da aplicação quanto do usuário vão estar guardados



3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Não conheço a definição teórica de SOA, mas sempre achei ambos muito iguais, com objetivo de separar cada responsabilidade individualmente, no caso do SOA, em services. A maior diferença que vejo entre eles é o protocolo de comunicação, o SOA normalmente usa protocolos mais complexos, no qual você consegue fazer algumas validações e controles direto no protocolo, microservices costuma usar protocolos mais simples, como o REST por exemplo.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

A API Management é responsável por administrar e gerenciar o acesso das APIS, exatamente para ter um controle maior, principalmente do acesso a API e troca de informações entre o que vai consumir essa API e a API em si, além de fazer controle de acesso, além de centralizar o ponto de entrada de chamada da API.
Uma das vantagens é exatamente ter um controle de acesso, dificultando acesso de forma pública, consiga acessar facilmente a api, ou até mesmo pelo Swagger da aplicação. Além de centralizar o ponto de entrada, qualquer um front, por exemplo, pode ser acoplado a aplicação, chamando a api só pra consumir os dados, sem precisar mudar as regras de negócio, facilitando a integração.
Uma das desvantagens, é que dependendo do servidor, pode gerar problemas de latência, as requisições demorando mais a retornar devido ao servidor, gerando até timeout em requisições que demoram demais, gerando até lentidão no uso do front, já que espera a requisição retornar. Também se é usada api de terceiros, você acaba ficando limitado ao que eles te disponibilizam, como por exemplo a api do google maps, que depois que passou a ser paga, as aplicações que usavam de forma gratuita, pararam.



5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Basicamente o Struct tem os dados acessados diretamente, já a class é mais um apontamento de referência. o Struct costuma ser usado pra coisa mais imutáveis e classe são estruturas mais complexas, podendo serem setados valores, gerando mutabilidade.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

O .NET é algo feito pra rodar só no Windows, já o .NET CORE é feito pra multi-plataforma, não deixando a tecnologia limitada a somente uma plataforma única (nesse caso, o windows).


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

Infelizmente só tive experiência profissional com REST, com GRPC só vi em teoria. Sei que o REST usa http 1, basicamente usando json ou xml na comunicação. Sei que o GRPC usa http 2, que é mais complexo porém tem algumas vantagens e usa outro tipo de comunicação.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

As aplicações convencionais carregam um html a cada página da aplicação, já a SPA, ela mantém uma estrutura, que é normalmente configurada em um layout (contendo normalmente: menu, footer, header,  conteúdo etc), o que a SPA faz é carregar a cada rota somente o conteúdo do layout, mantendo as outras definições de layout e não precisando carregar a página inteira a cada troca de rota, mudando somente o “miolo” da aplicação de acordo com as solicitações do usuário.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

Não conheço tudo sobre o que um DevOps faz, mas nas esuipes que eu trabalhei e tivemos um DevOps atendendo, eu via que ele era o cara que levantava, configurava e mantinha os servidores (QA e PROD) saudáveis para o desenvolvimento da aplicação.


10. Explique sobre um método agile.

**Resposta:**

Já trabalhei com 2 métodos ágeis, o SCRUM e o KANBAN:

O Scrum eu já trabalho faz muitos anos, é gigantesco, acho difícil algum projeto seguir o SCRUM perfeitamente, mas normalmente é utilizado as melhores definições de processo e seus rituais, como daily, grooming, planning, e demo. Com um acompanhamento diário e normalmente acompanha a entrega contínua, que se faz ao final de cada sprint. Normalmente o Scrum não é tão flexível após o comprometimento da entrega da sprint. Já o KANBAN é um pouco mais flexível, principalmente nessa parte de tasks comprometidas, mas é uma entrega contínua bem parecida com o Scrum.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

Não sei definir de fato ambos, mas sei que são ferramentas que ajudam, aceleram e deixam de forma mais seguras, toda a parte de entrega de valor pro cliente, criando pipeline com todo o build do ambiente, gerando build da aplicação e rodando testes unitário e automáticos, além de fazer deploy nos ambientes setados, facilitando tanto a entrega quanto o próprio desenvolvimento, pois caso a pipeline quebre, já fica de fácil acesso prodev descobrir em qual processo quebrou, alóem de entregar valor pro cliente de forma totalmente automatizada. Infelizmente só tive experiência com o Jenkins.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Um container é um pacote que contém tudo o que a aplicação necessita pra rodar, código compilado, dependências etc.
O Docker é uma ferramenta que cria e gerencia containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Infelizmente não tive experiência com Openshift, só com o Kubernetes, como ele é open source da google. Não sei se é a definição correta mas ele é um “Manager” de containers, com uma certa complexidade de ser configurado. Acredito que o Openshift seja algo no mesmo objetivo só que talvez um pouco mais complexo ou com mais ferramentas.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

Fácil inicialização, hoje tem ferramentas que com pouquíssima quantidade de conhecimento ou código, você já consegue levantar uma API. Ferramentas como o Slim do PHP ou até mesmo o NodeJs fazem isso com muita facilidade, além de também ter muita vantagem de estar completamente desacoplado da view, podendo acoplar qualquer front em qualquer tecnologia simplesmente sabendo quais dados passar e o que esperar de retorno. A grande desvantagem e algo que eu procuro me preocupar muito é a segurança, sem pelo menos uma autenticação e um tratamento pros dados que chegam, qualquer pessoa que fizer uma pesquisa rápida na internet consegue pelo network do próprio browser achar o endpoint e os dados que são passados e injetar dados e até códigos.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

No mínimo autenticação, tratamento de nível de acesso e tratamentos pra todos os dados que chegam pra evitar injeções maliciosas.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

É usada pra trocar informações de forma assíncrona e desacoplada entre aplicações ou até componentes, usando mensagens como “padrão” pra que que qualquer tecnologia consiga se comunicar com a outra sem precisar de nenhum tipo de dependência entre elas.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

Não conheço a estratégia SAGA, eu poderia procurar no google e dar uma resposta genérica de lá, mas quando eu não conheço, eu admito e me dá oportunidade pra crescer e aprender mais.


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

O Kubernetes executa e administra dentro dele de acordo com o que GitOps configura e define, para criar automatizações de pipeline que funcione automaticamente a partir dos commits feitos no repositório, gerando ambiente na ordem certa, criando dependências na ordem certa, compilando e rodando na ordem certa etc.