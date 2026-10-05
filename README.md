# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**

- Codebase: uma base de código só por aplicação, versionada no Git, e dela saem os deploys de dev, homologação e produção.
- Dependências: tudo que a aplicação precisa fica declarado no projeto (no .NET, os pacotes NuGet no .csproj). Não dá pra contar com algo que "já estava instalado no servidor".
- Configuração: o que muda de um ambiente pro outro (connection string, URL de serviço, chave) fica fora do código, em variável de ambiente ou cofre de segredos.
- Backing services: banco, fila, cache etc. são recursos plugados por configuração. Trocar o banco local por um na nuvem não deveria exigir mudança de código.
- Build, release e run separados: o build gera o artefato, o release junta esse artefato com a config do ambiente e o run só executa. Se algo der errado, volta pro release anterior.
- Processos stateless: a aplicação não guarda estado em memória ou disco local. Sessão e arquivos vão pra um serviço externo, e aí dá pra subir várias instâncias sem problema.

Os outros são port binding, concorrência, descartabilidade, paridade entre dev e prod, logs como fluxo de eventos e processos administrativos.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**

A divisão mais comum é apresentação, aplicação, domínio e infraestrutura. A apresentação é por onde o sistema é acessado (tela, controllers da API). A aplicação coordena os casos de uso. O domínio é onde ficam as regras de negócio de verdade. A infraestrutura cuida do acesso a banco, mensageria e serviços externos.

O ponto principal é não misturar as responsabilidades e manter o domínio sem depender de tecnologia, como propõe a Clean Architecture. Isso facilita testar e trocar peças sem quebrar o resto.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**

As duas dividem o sistema em serviços, mas com objetivos diferentes. No SOA os serviços são maiores, pensados pra serem reaproveitados pela empresa toda, e normalmente conversam por um barramento central (ESB) que faz roteamento, transformação e orquestração, muitas vezes com SOAP. É comum compartilharem banco e terem uma governança centralizada.

Nos microserviços cada serviço é pequeno, cuida de um pedaço do negócio, tem o próprio banco e é publicado de forma independente. A comunicação é mais leve (REST, gRPC, mensageria) e a inteligência fica nos serviços, não no meio de campo. Cada time é dono do seu serviço.

Na minha visão, o SOA busca reaproveitamento e integração, e microserviços buscam autonomia e escalar cada parte separadamente.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**

É uma camada na frente das APIs pra publicar, proteger e acompanhar o uso delas, como o Azure API Management. Geralmente vem com gateway, portal pro desenvolvedor e métricas.

Vantagens: centraliza a entrada, a autenticação (OAuth2, API key), o rate limiting, o versionamento e o cache, e dá visibilidade de quem está consumindo o quê. O portal com documentação também ajuda muito quem integra.

Desvantagens: é mais um salto na requisição (latência), pode virar ponto único de falha se não estiver bem configurado, tem custo, pode prender a um fornecedor e existe a tentação de colocar regra de negócio no gateway, o que não é o lugar dela.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**

Struct é tipo de valor e class é tipo de referência. Quando passo uma struct pra um método ou atribuo a outra variável, vai uma cópia. Com class vai só a referência, então as duas variáveis apontam pro mesmo objeto e uma alteração aparece nas duas.

Struct não tem herança (só implementa interface) e faz sentido pra coisas pequenas e de preferência imutáveis, como `DateTime` ou uma coordenada. Class é o padrão pro resto: suporta herança, pode ser null e fica no heap, gerenciada pelo Garbage Collector.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**

O .NET Framework é o original, só roda no Windows e hoje está parado na versão 4.8, recebendo só correções. O .NET Core veio como uma reescrita open source e multiplataforma (Windows, Linux, macOS), mais leve e rápida, e funciona bem com containers e nuvem.

A partir da versão 5 a Microsoft juntou tudo e tirou o "Core" do nome. O .NET atual (6, 7, 8...) é a continuação do Core e é o que se usa em projeto novo. Este teste mesmo está em .NET 8.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**

REST trabalha em cima de HTTP com recursos e verbos (GET, POST, PUT, DELETE), normalmente trafegando JSON. É simples, legível, qualquer navegador consome e é fácil de testar no Postman.

gRPC usa HTTP/2 e Protocol Buffers, que é binário. O contrato fica num arquivo .proto e o código de cliente e servidor é gerado a partir dele. É mais rápido, as mensagens são menores e tem streaming nos dois sentidos, mas no navegador precisa de gRPC-Web.

No geral, REST vai bem em API pública e com front-end, e gRPC é uma boa escolha na comunicação interna entre microserviços, quando desempenho importa.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**

Na SPA o servidor manda uma página só e a navegação acontece no navegador. O roteador do framework (no Angular ou no React, por exemplo) observa a URL e troca o componente exibido sem recarregar a página.

Existem duas formas. Com a History API a URL fica limpa (/clientes/10), mas o servidor precisa devolver o index.html pra qualquer rota, senão o F5 dá 404. Com hash (/#/clientes/10) isso não acontece, porque o que vem depois do # nem chega no servidor.

Fora isso, o roteador costuma dar suporte a parâmetros na rota, rotas filhas, guards pra bloquear página sem login e lazy loading, que carrega o módulo só quando a rota é acessada.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**

DevOps é mais cultura do que ferramenta. A ideia é quebrar a separação entre quem desenvolve e quem opera, pra entregar com mais frequência e menos susto. Isso passa muito por automação: build, testes e deploy em pipeline, infraestrutura como código, containers e um bom monitoramento com logs, métricas e alertas.

Outro ponto importante é medir. As métricas DORA (frequência de deploy, lead time, taxa de falha e tempo de recuperação) ajudam a ver se o time está melhorando de fato.

10. Explique sobre um método agile.

**Resposta:**

O mais conhecido é o Scrum. O trabalho é dividido em sprints curtas, de uma a quatro semanas, e no fim de cada uma tem algo entregue. O Product Owner prioriza o backlog, o Scrum Master ajuda a tirar impedimentos e o time de desenvolvimento executa.

Os eventos são a planning (o que entra na sprint), a daily (alinhamento rápido do dia), a review (mostrar o que foi feito pra quem interessa) e a retrospectiva (o que melhorar no processo).

Também existe o Kanban, que não trabalha com sprint: é um fluxo contínuo num quadro, com limite de tarefas em andamento pra não acumular coisa começada e não terminada.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**

CI é integração contínua: a cada push ou PR o pipeline compila, roda os testes e a análise de código, então o problema aparece cedo e não na véspera da entrega. CD pode ser entrega contínua, quando o artefato fica pronto pra produção e alguém aprova o deploy, ou deploy contínuo, quando vai direto pra produção se o pipeline passar.

Ferramentas: Azure DevOps ou GitHub Actions pros pipelines, SonarQube pra qualidade de código e Docker pra empacotar a aplicação.

12. Qual a diferença entre Docker e Containers.

**Resposta:**

Container é o conceito: um processo isolado que leva a aplicação junto com as dependências e usa o kernel do próprio host. Por isso é bem mais leve que uma máquina virtual.

Docker é a ferramenta mais popular pra criar e rodar containers, com o Dockerfile, o engine e o Docker Hub. Mas não é a única, o Podman por exemplo faz o mesmo papel. Então Docker usa containers, mas container não depende de Docker.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**

Kubernetes é o orquestrador open source: cuida de deploy, escala, reiniciar o que caiu, balanceamento e descoberta de serviços. Só que muita coisa em volta (ingress, monitoramento, registry, CI/CD) você escolhe e monta.

O OpenShift é o Kubernetes da Red Hat com tudo isso já incluído: console web, registry, pipelines e uma segurança mais rígida por padrão, como não deixar container rodar como root. Além disso tem suporte comercial. Todo OpenShift é Kubernetes, mas vem mais pronto e mais opinativo, e é pago.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**

A grande vantagem é o desacoplamento. O front, o app mobile e os parceiros consomem a mesma API, cada lado evolui no seu ritmo e tecnologias diferentes conversam sem problema.

Por outro lado, tudo passa a depender de rede, então aparecem latência, mais pontos de falha e uma superfície de ataque maior. Manter compatibilidade com quem já consome também dá trabalho.

As preocupações que eu teria: segurança, um contrato bem documentado (Swagger/OpenAPI), versionamento pra não quebrar cliente, paginação e cache pra desempenho, timeout, retry e circuit breaker pra resiliência, rate limiting, logs e rastreamento, e idempotência nas operações mais sensíveis.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**

Começa pelo básico: HTTPS sempre, e mTLS entre serviços quando fizer sentido. Pra autenticação, OAuth 2.0 / OpenID Connect com JWT de vida curta, validando assinatura, expiração, audiência e escopo, e dando a cada cliente só o acesso que ele precisa.

Depois vem validar tudo que entra (pra evitar injection), não devolver stack trace em erro, ter rate limiting no gateway e guardar segredos num cofre como o Azure Key Vault, nunca no código ou no appsettings versionado.

E não para no deploy: logs de auditoria, alertas, dependências atualizadas e testes de segurança periódicos. O OWASP API Security Top 10 é uma boa referência pra revisar.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**

Serve pra comunicação assíncrona entre sistemas por meio de um broker, como RabbitMQ ou Kafka. Quem envia publica a mensagem e segue a vida, sem esperar o outro lado responder.

Isso desacopla os serviços, segura picos de carga (a fila funciona como um amortecedor) e deixa tudo mais resiliente: se o consumidor cair, a mensagem fica lá esperando. Também é a base de uma arquitetura orientada a eventos.

Mas exige cuidado. A consistência passa a ser eventual, a mesma mensagem pode chegar duas vezes (o consumidor precisa ser idempotente) e é preciso ter retry, dead-letter queue e monitoramento das filas.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**

Saga resolve o problema de manter os dados consistentes quando uma operação passa por vários microserviços, cada um com seu banco, sem uma transação única entre eles.

A operação vira uma sequência de transações locais. Cada serviço faz a sua parte e avisa o próximo. Se um passo falha, os anteriores são desfeitos com transações de compensação. Por exemplo, num pedido: reservo o estoque, tento cobrar, e se o pagamento falhar eu libero o estoque reservado.

Ela pode ser feita por coreografia, onde cada serviço reage aos eventos dos outros sem um coordenador (simples no começo, mas difícil de acompanhar quando cresce), ou por orquestração, onde um componente central comanda os passos e as compensações (o fluxo fica mais claro, ao custo de mais uma peça).

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**

GitOps é tratar o Git como a fonte da verdade do que deve estar rodando no cluster. Os manifestos ficam num repositório, e um agente dentro do cluster, como o Argo CD, fica comparando o que está no Git com o que está rodando e corrige a diferença.

Qualquer mudança é feita por pull request: alguém revisa, aprova, e o merge faz o deploy. Com isso tenho histórico de tudo, rollback com um git revert, e se alguém alterar algo direto no cluster o agente volta ao que está no Git. Também é mais seguro, porque o pipeline não precisa de credencial do cluster: o CI só gera a imagem e atualiza a tag no repositório de manifestos.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**

A conferência de documentos dos lotes de clientes era feita manualmente pela operação: análise de PDFs, validação de cálculos e regras específicas de cada cliente. Fui o desenvolvedor da solução que automatizou esse processo com IA, da arquitetura à produção.

Modelei no SQL Server uma estrutura configurável (clientes, tipos de análise, prompts por etapa e controle de status) com arquitetura independente de provedor: as stored procedures seguem um contrato único e o processamento pode ser direcionado para Anthropic, OpenAI ou Google sem mudança na lógica. Usei function calling com saída estruturada em JSON, prompt caching e processamento em batch para reduzir custo.

Desafios:

- Diferenças entre provedores: padronizei as integrações no mesmo contrato e criei um sanitizador para respostas malformadas.
- Performance: os relatórios usavam subconsultas correlacionadas via linked server; materializei as leituras remotas em tabelas temporárias e reduzi bastante o tempo de execução.
- Documentos corrompidos: identifiquei cabeçalhos HTTP gravados antes do marcador %PDF- e tratei os arquivos na entrada.
- Carga histórica: mais de mil lotes com uma solução de 10 scripts para execução e reprocessamento controlados.

Resultado: o pipeline está em produção, usado diariamente com vários clientes e tipos de análise. Novos clientes entram basicamente por parametrização.

Tecnologias: Java, SQL Server, APIs de LLM (Anthropic, OpenAI, Google).