# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:** Não tenho conhecimento mas posso aprender


2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**São 6 camadas de desenvolvimento de software, onde todas são importantes para o desenvolvimento. Camada de Apresentação, Camada de Aplicação, Camada de Persistência de Dados, Camada de Infraestrutura, Camada de Banco de Dados e a Camada de Serviços.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:** Ambas possuem a organização de estruturar a comunicação e implantação de um serviço. Em SOA, o foco maior é na comunicação de serviços independentes e
reutilizáveis através de interfaces bem definidas. Talvez, a implementação mais conhecida seja a SOAP - web services, mas existem outras maneiras de implementação. A arquitetura de microserviços foi uma evolução do SOA, onde o objetivo é criar serviços menores e independentes de responsabilidade única. Cada microserviço deve possuir seu banco de dados e sua regra de negócios bem definida.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:** Possui o objetivo de monitorar APIs, garantindo o funcionamento de sua arquitetura perante aos serviços de consumidores ou de outros. Trazendo
segurança para processos de autenticação e garantindo uma escalabilidade adequada, fornecendo caches, melhorando assim seu desempenho.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:** A principal diferença está no comportamento de alocação de memória.
- Um struct, o valor é armazenado diretamente na variável.
- Uma classe, a variável contém uma referência - assim, quando referenciada em outro lugar, não estamos levando o objeto inteiro, apenas sua referência.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:** Ambas as versões fazem parte do ecossistema .NET.
O .NET Framework foi criado para executar somento no Windows. Já o .NET Core foi criado para ser multiplataforma, podendo ser executado em Linux, MacOS além do
Windows.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:** REST utiliza o protocolo HTTP - usando GET, POST, PUT e DELETE (mais conhecidos), já o GRPC utiliza o protocolo HTTP/2 - usando o Protobuf.


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:** Necessário para navegação em diferentes páginas acessadas na web, de acordo com a mudança de URL.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:** Atuo com Azure e com AWS, configurando arquivos de extensão .yaml para o devido funcionamento da esteira de deploy. Configuração de variáveis, análise de
logs para verificar possíveis erros de implantação, além de verificar a saúde da aplicação, seja utilizando o Lens ou o Rancher.


10. Explique sobre um método agile.

**Resposta:** Simplicidade na entrega e autonimia das equipes, são alguns dos pontos que uma metodologia agile bem implementada, pode trazer como benefício, seja ela
Kanban ou Scrum, a organização e o objetivo final de entregas continuas deve ser priorizado. A quem prefira o Kanban por ser uma prática mais "simples" do Scrum que não possui tantas cerimônias e etapas do ciclo de desenvolvimento.


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:** GitHub Actions - builds diretamente do GitHub. Jenkins - ferramenta personalizavel open-source para configuração de CI/CD. Existem muitas outras,
porém, nestas duas podemos ter uma integração continua da aplicação em desenvolvimento, garantindo uma entrega organizada e continua, implantando com
maior segurança para o ambiente de produção.


12. Qual a diferença entre Docker e Containers.

**Resposta:** Um container é como se fosse um pacote onde a aplicação pode ser isolada junto com suas bibliotecas e configurações. O Docker é uma plataforma que
gerencia e executa esses "pacotes" - containers.


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:** Não tenho conhecimento mas posso aprender


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:** Uma das grandes vantagens de se usar a API é sua facilidade em integração e escalabilidade, além da segurança e configuração de controle de acesso.
Uma de suas desvantagens talvez, pode ser a latência e performancem pois com o tempo problemas com timeout pode ser um dos maiores problemas de degradação.


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:** Com metodos seguros de Autenticação da aplicação. Cuidado na exposição da base de dados. Monitoramento com logs claros e objetivos. Configuração de CORS
e segurança no Front End utilizado.


16. Para que serve uma arquitetura de mensagerias?

**Resposta:** Serve para manter uma comunicação assincrona de processos entre sistemas ou serviços de uma aplicação.


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:** Não tenho conhecimento, mas posso aprender


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:** Ainda possuo pouco conhecimento para comparar o GitOps usando o Kubernetes, não saberia responder esta questão.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:** Atuei alocada sozinha em um grande cliente automobilistico, onde o objetivo era facilitar e auxiliar com fornecimento de dados do SAP para a aplicação interna da empresa, auxiliando em extração de relatórios finais para áreas financeira e contábil.
Estas informações contribuiam para a elaboração de livros Fiscais da empresa. Utilizei o SAP - FI, com .Net Framework na versão 3.5, utilizava o TFS para versionamento de
código e banco de dados Oracle. Os desafios eram muitos, pois não tinham pessoas me auxiliando com testes, anotação de requisitos ou um líder técnico, além do desafio nos dados que exigiam grandes conversões.

20. Descrever cases (profissionais ou projetos de estudo) em que já tenha atuado com as tecnologias especificadas em cada tópico;
**Resposta:** Não posso descrever detalhadamente os projetos devido ao acordo que sempre assino de sigilo das informações de cada projeto que atuo. Foram diversos projetos,
mas os nomes de empresas que posso citar são Enterplay, Guide e Casas Bahia.
