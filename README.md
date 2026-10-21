1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

Base de código: manter uma base de código versionada para diferentes ambientes.
Dependências: declarar e isolar as bibliotecas necessárias.
Configurações: manter configurações específicas de cada ambiente fora do código.
Serviços de apoio: acessar bancos, filas e outros serviços como recursos conectados por configuração.
Build, release e execução: separar compilação, preparação da versão e execução.
Processos: executar processos sem estado persistente local, utilizando serviços externos para armazenar dados. 

2. Quais são as principais camadas no desenvolvimento de um software?

Apresentação, responsável pela interface; aplicação, que coordena os casos de uso; domínio, que concentra as regras de negócio; e infraestrutura, responsável por bancos de dados e integrações externas.

3. Diferencie Arquitetura SOA e arquitetura de microserviços.

SOA organiza funcionalidades em serviços reutilizáveis, frequentemente voltados à integração de sistemas empresariais. Microserviços priorizam serviços com responsabilidades delimitadas, autonomia e implantação independente. A diferença está principalmente no escopo, no acoplamento e na governança.

4. Qual é o objetivo de um API Management? Cite vantagens e desvantagens.

Gerenciar a exposição e o ciclo de vida das APIs, aplicando políticas de acesso, limites de requisições, documentação e monitoramento. As vantagens são padronização, controle e visibilidade. As desvantagens incluem custo, complexidade operacional e possível latência adicional no gateway.

5. Qual é a diferença entre uma Struct e uma Class?

Em C#, "struct" é um tipo por valor: a atribuição copia seu conteúdo. "class" é um tipo por referência: a atribuição copia a referência ao objeto. Classes permitem herança de outras classes; structs não. Ambas podem implementar interfaces.

6. Explique a grande diferença entre .NET e .NET Core.

Se a comparação for com o .NET Framework, ele é a implementação tradicional voltada ao Windows. O .NET Core surgiu como uma alternativa multiplataforma e de código aberto. A partir da versão 5, sua evolução passou a se chamar apenas .NET. Portanto, o .NET moderno é a continuidade do .NET Core.

7. Quais são as principais diferenças entre REST e gRPC?

REST é um estilo arquitetural baseado em recursos, geralmente utilizando HTTP e JSON. gRPC utiliza chamadas remotas, contratos tipados e, normalmente, HTTP/2 com Protocol Buffers. REST facilita integrações públicas e uso em navegadores; gRPC oferece mensagens compactas e suporte a streaming, sendo útil na comunicação entre serviços.

8. Explique como funciona o gerenciamento de rotas de uma SPA.

Um roteador no navegador associa URLs a componentes e atualiza a interface sem recarregar a página inteira. Ele também gerencia parâmetros e histórico de navegação. Ao utilizar a History API, o servidor precisa estar configurado para permitir o acesso direto às rotas da aplicação.

9. Falando sobre DevOps, comente o que conhece sobre.

DevOps aproxima desenvolvimento e operações por meio de colaboração, automação e responsabilidade compartilhada. Envolve práticas como CI/CD, infraestrutura como código e monitoramento, buscando entregas mais rápidas e confiáveis.

10. Explique sobre um método ágil.

Scrum é um framework ágil que organiza o trabalho em ciclos chamados Sprints. A equipe define um objetivo, desenvolve um incremento utilizável e inspeciona o resultado. Planejamento, reuniões diárias, revisão e retrospectiva ajudam a acompanhar o trabalho e melhorar continuamente.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

CI automatiza a integração de alterações, compilação e testes. CD pode significar entrega contínua, mantendo versões prontas para publicação, ou implantação contínua, publicando automaticamente após as verificações. Exemplos de ferramentas são GitHub Actions, GitLab CI/CD, Jenkins e Azure Pipelines.

12. Qual é a diferença entre Docker e containers?

Container é um ambiente isolado para executar processos e suas dependências, geralmente compartilhando o kernel do host. Docker é um conjunto de ferramentas para construir imagens e executar e gerenciar containers.

13. Qual é a diferença entre Kubernetes e OpenShift?

Kubernetes orquestra aplicações em containers, gerenciando implantação, escalabilidade e recuperação. OpenShift é uma plataforma da Red Hat baseada em Kubernetes, com ferramentas integradas, políticas e suporte empresarial.

14. Quais são as vantagens e desvantagens de APIs e quais preocupações devemos ter ao escolher essa abordagem?

APIs facilitam integração, reutilização de funcionalidades e evolução independente dos sistemas. Em contrapartida, podem introduzir latência, falhas de comunicação e complexidade operacional. Devemos avaliar segurança, disponibilidade, contratos, versionamento, documentação e limites de consumo.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIs?

Com HTTPS, autenticação, autorização por operação e recurso, validação de entradas e controle de requisições. Também é necessário proteger credenciais, atualizar dependências, monitorar acessos e realizar testes de segurança. A autorização deve impedir que um usuário acesse dados de outro ao alterar identificadores.

16. Para que serve uma arquitetura de mensageria?

Permite comunicação assíncrona entre sistemas por filas ou tópicos, reduzindo acoplamento e ajudando a absorver picos de demanda. Exige tratamento de falhas, reprocessamento e mensagens duplicadas, preferencialmente com consumidores idempotentes.

17. Explique a estratégia SAGA em arquitetura de microserviços.

SAGA divide uma operação distribuída em transações locais. Se uma etapa falhar, ações de compensação corrigem os efeitos das anteriores. Pode funcionar por coreografia, com eventos entre serviços, ou por orquestração, com um coordenador. 

18. Descreva seu entendimento sobre GitOps utilizando Kubernetes.

GitOps mantém o estado desejado do ambiente em configurações declarativas versionadas no Git. Ferramentas como Argo CD ou Flux comparam essas configurações com o Kubernetes e reconciliam as diferenças. Isso permite revisão por Pull Requests, rastreabilidade e maior controle das alterações.

19. Descreva um case de sucesso em que você atuou diretamente no desenvolvimento.

Em um projeto para o Grupo OSAN, desenvolvi uma API em PHP, integrada a um site WordPress, para consultar dados dos planos e se comunicar com a API bancária para gerar boletos. A solução também permitia verificar pagamentos em atraso no sistema.

Minha atuação foi diretamente no desenvolvimento dessa integração. O desafio foi conectar as informações dos planos à comunicação com o banco e à consulta da situação das cobranças. Como resultado, o site passou a oferecer essas funcionalidades integradas, apoiando a geração de boletos e o acompanhamento de pendências.
