USE GalloTube;

INSERT INTO Tag(Id, Name) VALUES
(1, 'Comédia'),
(2, 'Jogos'),
(3, 'Músicas'),
(4, 'Comidas'),
(5, 'Entretenimento'),
(6, 'Terror'),
(7, 'Animais'),
(8,'Notícias');

INSERT INTO Videos(Id, Name, Description, UploadDate, Duration, Thumbnail) VALUES
( 1, 'Minha Reação à Conversa Mais Chocante!', 'Pessoal, vocês não vão acreditar no que está prestes a acontecer neste vídeo! Eu estou completamente chocado com o que ela disse para ele. Prepare-se para ver minha reação ao drama mais inesperado e cheio de reviravoltas. Pegue a pipoca, porque isso vai ser incrível!', 2023, 10, '\\img\\videos\\01.jpg'),
( 2, 'Um Desabafo Necessário: Compartilhando Notícias Difíceis', 'Amigos, este vídeo é um pouco mais sério e importante. Eu preciso contar algo difícil para todos vocês e compartilhar uma situação complicada que estou enfrentando. Sentem-se comigo, pois precisamos conversar sobre isso. Sua compreensão e apoio significam muito para mim neste momento.', 2023, 14, '\\img\\videos\\02.jpg'),
( 3, 'Rotina de Cuidados com Minha Chinchila de Estimação!', 'Neste vídeo, compartilho todos os segredos sobre como cuido da minha adorável chinchila de estimação. Desde a configuração ideal da gaiola até a dieta, exercícios divertidos e até mesmo banhos de poeira! Se você está pensando em ter uma chinchila ou já tem uma, essas dicas vão te ajudar a proporcionar o melhor cuidado possível para seu peludo fofo.', 2023, 12, '\\img\\videos\\03.jpg'),
( 4, 'Explorando o Threads: Adeus, Twitter!', 'E aí, galera! Hoje é o dia de darmos uma olhada no aplicativo Threads e eu estou animado para compartilhar as novidades com vocês. Com recursos incríveis e uma nova abordagem, será que o Twitter vai ficar para trás? Vamos explorar juntos o que o Threads tem a oferecer e como isso pode mudar nossa experiência nas redes sociais. Prepare-se para uma análise completa e sincera!', 2023, 11, '\\img\\videos\\04.jpg'),
( 5, 'Minha Maior Surpresa ao Ver as Câmeras de Casa!', 'E aí, pessoal! Hoje, vou contar a vocês sobre um momento hilário e constrangedor. Decidi dar uma olhada nas câmeras de segurança da minha casa e... bem, digamos que me deparei com uma cena que nunca esperava ver!', 2023, 142, '\\img\\videos\\05.jpg'),
( 6, 'Quase Enlouqueci com Zelda: Minha Épica Aventura no Game!', 'E aí, galera gamer! Hoje venho compartilhar minha experiência épica jogando Zelda. Entre labirintos desafiadores, inimigos poderosos e quebra-cabeças enigmáticos, posso dizer que "quase enlouqueci" é um eufemismo! Preparem-se para mergulhar na minha jornada cheia de emoções, frustrações e, claro, algumas conquistas incríveis. Quem mais já passou por momentos assim? Vamos trocar histórias nos comentários!', 2023, 15, '\\img\\videos\\06.jpg'),
( 7, 'Decisão Difícil: Quem é Melhor, Raze ou Omen em Valorant?', 'E aí, pessoal! Hoje estamos mergulhando em uma discussão acalorada: quem é o melhor entre Raze e Omen em Valorant? Vou analisar suas habilidades, estratégias e impacto no jogo para tentar chegar a uma conclusão. Mas quero ouvir a opinião de vocês também! Votem nos comentários e vamos descobrir juntos qual agente reina supremo no mundo de Valorant.', 2023, 10, '\\img\\videos\\07.jpg'),
( 8, 'O Melhor Lanche que Já Provei!', 'Hoje vou compartilhar com vocês uma experiência gastronômica simplesmente inesquecível. Estou falando do lanche que me deixou sem palavras, o sabor supremo que conquistou o topo da minha lista. Preparem-se para viajar comigo pelos sabores e texturas desse lanche incrível que vai fazer vocês salivarem só de ouvir.', 2023, 9, '\\img\\videos\\08.jpg'),
( 9, 'Quando Quase Fui Parar na Cadeia no Canadá!', 'Oi pessoal! Hoje vou compartilhar com vocês uma história de tirar o fôlego: o dia em que estive à beira de ser preso no Canadá! Uma sequência de eventos malucas e um mal-entendido épico me levaram à beira de uma situação complicada. Preparem-se para rir, se surpreender e ficar de queixo caído com essa história tão louca quanto verdadeira. Lembrem-se, nunca subestimem as aventuras que a vida nos reserva!', 2023, 17, '\\img\\videos\\09.jpg'),
( 10, 'Se eu rir aumenta +1 minuto de vídeo', 'Prepare-se para não conseguir parar de rir enquanto compartilho minhas reações e comentários sarcásticos sobre os desafios loucos e danças desajeitadas que encontro. Não perca essa divertida aventura repleta de risadas incontroláveis e momentos épicos do TikTok!', 2023, 22, '\\img\\videos\\10.jpg'),
( 11, 'Desvendando o Processo de Fabricação do Saxofone!', 'Olá, amantes da música! Neste vídeo, vamos mergulhar no fascinante mundo da fabricação de saxofones. Desde a seleção dos materiais até os ajustes finais, vou guiá-los por todas as etapas envolvidas na criação desse instrumento icônico. Preparem-se para uma jornada pelo processo artesanal por trás do som do saxofone que todos nós conhecemos e amamos.', 2023, 16, '\\img\\videos\\11.jpg');

INSERT INTO VideoTag VALUES
( 1, 5),
( 2, 8),
( 3,  5), (3, 7),
( 4, 5), (4, 8),
( 5, 6),
( 6,  2), (6, 5),
( 7,  2), (7, 5),
( 8, 4),
( 9, 5),
( 10, 1), (10, 5),
( 11, 3), (11, 5);