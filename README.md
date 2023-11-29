*Realize o clone desse repositorio! (Diretorio na máquina de sua preferencia)

		* As instruções estão dentro de cada projeto. Verifique e implemente, após realizar os testes e responder as questões *

# Questões Teóricas

* Qual a diferença entre uma Struct e uma Class?

Enquanto a class é um tipo de referência, a struct é um tipo de valor, então por utilizar menos espaço de memória, a struct fica armazenada na stack e não na heap, tendo uma performance melhor. A struct pode ser utilizada quando precisamos armazenar valores primitivos para representações simples.

* Explique a grande diferença entre .NET e .NET CORE.

A grande diferença é que o .net core é mais recente e possui menos bibliotecas, porém ele é cross-platform, funciona em outros sistemas operacionais além do windows.

* Quais as principais diferenças entre REST e GRPC?

No REST, o modelo de comunicação é unário, onde o cliente envia um request e o servidor devolve um response antes do client poder enviar o próximo request, já no GRPC, temos um streaming bidirecional, onde o cliente e o servidor podem enviar e receber várias solicitações e respostas simultaneamente. Outra diferença é que o formato normalmente usado em REST é JSON e em GRPC é protobuf.

* Explique como funciona um gerenciamento de rotas de uma SPA.

O gerenciamento ocorre do lado do cliente, utilizando alguma biblioteca, no react por exemplo, podemos utilizar o react router, onde cada rota vai ser um componente react.

* Falando sobre DevOps, comente o que conhece sobre.

Entendo sobre devops como uma metodologia que abrange todo o ciclo de vida de uma aplicação ou implementação, desde o desenvolvimento, até o deploy e a posterior monitoração.

* Explique sobre um método agile.

Vou falar sobre o Scrum, onde temos os seguintes termos: 
PO: a pessoa que define os itens que compôem o product backlog e os priorizas nas sprints plannings; 
Scrum Master: a pessoa que atua como um facilitador para a equipe, ajudando em necessidades e nas práticas do Scrum;
Product Backlog: é uma lista contendo as demandas;
Sprint: a divisão dos períodos no Scrum, os ciclos;
Sprint Backlog: a lista de demandas que será realizada dentro do Sprint atual;
Sprint Planning: a reunião envolvendo os participantes da equipe, junto com o PO e o Scrum Master, onde será definido o sprint backlog;
Sprint Review: uma reunião para a equipe mostrar o que foi alcançado dentro da sprint que terminou;
Daily Scrum: uma reunião rápida e diária, onde o time comenta o que foi feito no dia anterior, o que será realizado no próximo dia e se houve algum impedimento.

* Comente sobre CI e CD e algumas ferramentas do dia a dia.

CI/CD é a integração e entrega contínua, tem muito a ver com DevOps, uma ferramenta que conheço e utilizo para implementação dessas práticas é o Jenkins, onde quando configurado, a partir de um commit, já são executados os testes, e se não houver erros, o sistema já realiza o build e o posterior deploy da aplicação no ambiente.

* Qual a diferença entre Docker e Containers.

Containers são pacotes contendo o código de uma aplicação, ou parte dele, junto de suas dependências, bibliotecas, e tudo que seja necessário para ele ser corretamente executado. Já Docker é uma plataforma que facilita a criação e a administração dos containers.

* Qual a diferença entre Kubernetes e Openshift?

O Openshift foi construído com base no Kubernetes e extende suas funcionalidades ao mesmo tempo qua facilita, sendo mais fácil para integrar com softwares.

* Quais as vantagens e desvantagens sobre API e quais preocupaçõe devemos ter quando escolhemos essa abordagem?

Vantagens: 
Possibilidade de utilizar o mesmo código em diversas interfaces, assim desacoplando as funcionalidades e diminuiando a duplicidade de código dentro das aplicações;
Opção de utilizar linguagens e tecnologias diferentes;
Melhor organização de código, podendo utilizar uma arquitetura específica para a API; Desvantagens: 
Maior complexidade de desenvolvimento;
Possibilidade de fugir de um padrão conforme o número de APIs vai aumentando;

* Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

Com autenticação e tokens, limitação de chamadas, utilizando health check, e também utilizando algum api gateway ou management.

* Quando devemos utilizar um sistema de mensageria e quais as preocupações dessa abordagem?

Podemos utilizar mensageria quando:
Queremos um baixo acoplamento entre os sistemas, tornando a comunicação assíncrona;
Queremos integrar sistemas de diferentes linguagens;
Para a aplicação que vai produzir a mensagem não precisar verificar se a aplicação que vai consumir está disponível no momento;
Quando precisamos que sejam realizadas novas tentativas de consumo da mensagem caso ocorra alguma falha na primeira vez. 
Preocupações: 
Maior complexidade de desenvolvimento;
Utilização desnecessária quando é necessário um modelo mais síncrono.

* Qual a diferença entre Mensagem e Eventos?

Mensagem é o que efetivamente é enviado de um sistema para o outro quando integrados dentro do contexto de mensageria, já eventos são gatilhos disparados dentro da aplicação por conta da alteração de estado de alguma entidade.

* Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Base de código: Utilizar algum versionador de código, e apenas devemos ter uma aplicação para cada base de código.
Configuração: Configurações hardcode são más práticas, e é sugerido utilizar variáveis de ambiente para armazenar as configurações.
Serviços de Apoio: O desenvolvimento da aplicação deve ser feito com baixo acoplamento a serviços como banco de dados ou mensageria por exemplo, para caso sejá necessário alguma substituição.
Descartabilidade: Os processos devem ser descartáveis, eles devem iniciar rapidamente e desligar graciosamente, e também devem estar preparados para falhas catastróficas.
Paridade Dev/Prod: A ideia aqui é reduzir as diferenças entre esses ambientes em três aspectos: 
Temporal: Deve ser possível o deploy de uma aplicação em pouco tempo;
Pessoal: As pessoas que desenvolvem o código e as que realizam ou gerenciam o deploy são as mesmas ou próximas;
Ferramentas: os ambientes devem ser idênticos para que não ocorra diferença de comportamento da aplicação;
Processos Administrativos: Caso seja necessário realizar algum processo, como um database migration, é recomendado realizar de um ambiente idêntico, mesma versão, pacotes, configuração, etc, para que sejam minimizados os riscos.

* Quais são as principais camadas no desenvolvimento de um software?

No geral, é dividido em IHM, BLL E DAL.
Para desenvolvimento de APIs, geralmente separo nas seguintes camadas
UI, Applcation, Domain, Infra 

* Diferencie Arquitetura SOA X Arquitetura microserviços.

Arquitetura SOA é um método de desenvolvimento de software que usa componentes chamados de serviços para criar aplicações. Arquitetura de microserviços é uma evolução do estilo de arquitetura SOA. Embora cada serviço de SOA seja um recurso de negócio completo, cada microserviço é um componente de software muito menor, especializado em apenas uma única tarefa.
As diferenças ficam por conta da comunicação, onde no SOA é utilizado um ESB e nos microserviços, mais normalmente é utilizado APIs RESTful. E também por conta da implantação, no SOA, caso um novo serviço seja adicionado ou algum seja alterado, será necessário reconstruir a aplicação inteira, já os microserviços são totalmente independentes.

* Cite dois APIs Managements, dois API Gateways utilizados no mercado e os diferencie.

 Os Gateways apenas realizam uma filtragem para as APIs, redirecionando e controlando o acesso, já os Managements, além de realizar a mesma função do Gateway, também possuem toda uma série de opções para análises de dados referentes aos acessos, respostas e utilização das APIs.
 Kong e Sensedia são duas opções, acho que a principal diferença é devido ao Sensedia não possuir nenhuma versão grátis, assim sendo uma solução mais completa, com mais integrações e com um foco maior em análises.