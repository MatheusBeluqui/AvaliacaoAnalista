# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Não conheço

**Resposta:**

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

camada de apresentação), lógica de negócio, acesso a dados e infraestrutura.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

Microserviços constroem aplicações como serviços pequenos e autônomos. SOA tem serviços abrangentes; Microserviços têm serviços focados em uma única função. Microserviços utilizam comunicação direta via HTTP/REST. O desenvolvimento em SOA é monolítico e complexo, enquanto Microserviços permitem entrega contínua e independente. 


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

O objetivo é a estrutura para facilitar a criação e gerenciamento de api’s. 
Pros: Facilita segurança, criação de política e Monitoramento. Centralização e organização de API’s.
Contras: Aumenta complexidade, custo e dependência de tecnologia. Ex. Azure Management API 


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

A diferença está na alocação de memória. Uma Struct utiliza a passagem por valor. Class utiliza a passagem por referência.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

.NET Core é multiplataforma Open Source e multiplataforma. Diferente do .NET tradicional que só é possível ser executado em máquinas Windows.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST  é um estilo arquitetural, utiliza métodos HTTP,  onde seus endpoints são melhores utilizados para comunicação com APIS que faz um sentido de negócio, possuí um conjunto de regras pra otimizar essa comunicação, evitando ambiguidades e outros problemas. Ex. Endpoints  de CRUD

GRPC é um framework Google onde seus endpoints são mais utilizado melhor utilizado como “comandos” pra execução te funções especificas e comunicação de eventos de grande volume de dados. Ex. Endpoint que recebe um payload de confirmação de alguma task.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**


Apesar de entender que um Single Page Application permitir navegações independentes sem a necessidade de carregamento de uma página específica, eu teria que revisar pra entender como funcionariam os métodos de estados de um framework específico. Então na saberia explicar o ciclo com exatidão. Sem resposta.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps é uma área de TI voltada para implantação e monitoria a aplicações. Existe uma grande gama de ferramentas e técnicas que facilitam a automação das publicações em ambientes presentes de um software, com grande foco em alta disponibilidade. Lidam diretamente com processo de CI/CD, juntamente com equipes de Devenvolvimento e Segurança para garantir a dispobilidade do Software.

10. Explique sobre um método agile.

**Resposta:**

O Agile é um método com foco na demonstração rápida de valor da construção de um software utilizando um conjunto de boas práticas para que seja possível alta produtividade de diferentes profissionais e papéis em toda essa construção. 

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

O Continuous Integration / Continuous Delivering abstrai e automatiza toda a complexidade de uma implantação de gerenciamento de versões em ambientes produtivos e novas releases. Assim que um time de desenvolvimento finaliza um implementação, pegando por exemplo uma nova feature, uma vez ela enviada para repositório, ela rapidamente estará publicada em uma ambiente respectivo. É composta por uma séries de tasks escritas que automatizam processos internos, um pipeline de execução que antes seriam feitas na mão como build, execução de teste unitários e geração de artefatos e assemblies para publicação.

E uma vez passada pela diretrizes de ambientes nessa esteira (pipelines) de desenvolvimento, rapidamente pode ser disponibilizada para o cliente final.
****

Ex. Azure Pipelines e Jenkins.


12. Qual a diferença entre Docker e Containers.

**Resposta:**

Docker é uma ferramenta utilizada para criação, gerenciamento e execução de Containers.
Containers são pequenas partes isoladas de software e independentes que podem ser empacotadas e virtualizadas, compartilhando um mesmo kernel de sistema operacional.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

O Openshift é uma variação do Kubernetes, com a mesma finalidade porém com recursos diretentes. Não saberia explicar a diferença no bit entre elas pois nunca utilizei e não tive experiência.

Kubernetes é uma extensa plataforma de gerenciamento de recursos de aplicações conteinerizadas e comunicação entre ambientes e microsserviços. Um orquestrador.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

Vantagem:

Facilidade de comunicação entre microsserviços que modularizam toda uma aplicação em pequenas partes com suas responsabilidades facilitando a manutenção, por exemplo.

Desvantagem: 
Há uma maior preocupação quanto a segurança dos dados trafegados, autenticações e autorizações.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**


Não tornando-as totalmente acessível para o público, criando uma série de políticas e restrições para uso específico dos seus endpoints, seja por token ou ouro mecanismo, por exemplo. Levar em consideração não somente Autenticação e  Autorização, mas também restrição de comunicações utilizando o CORS, por exemplo.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Para que seja possível trabalhar-se de forma assíncrona, tornando possível a alta disponibilidade , resiliência das aplicações e comunicação entre API’S e microsserviços.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

Não conheço. Talvez já tenha utilizado. Mas não posso falar sobre. Irei estudar.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

Não tenho conhecimento sobre o GitOps apesar de saber que é uma metodologia para facilitar uma automação de infra com versionamento.  Sei que ambos trabalham juntos, não tenho essa experiência.
