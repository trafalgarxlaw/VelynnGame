<p align=center>
Bryan Côté – COTB05079000<br/>
Yassine H - XXXXX<br/>
Philippe Leblanc - XXXX<br/>
<br/><br/><br/><br/><br/><br/>
Projet d'analyse et de modélisation<br/>
INM5151, gr. 10
<br/><br/><br/><br/><br/><br/>
Concept of Operations<br/>
Alpha Strike
<br/><br/><br/><br/><br/><br/>
Travail présenté à<br/>
M. Hafedh MILI
<br/><br/><br/><br/><br/><br/>
Département d’informatique<br/>
Université du Québec à Montréal<br/>
Le 11 février 2020
</p>

# 1. INTRODUCTION

Ce document vise, en premier lieux, a éclairer le lecteur sur le concept du système que notre équipe s’apprête a prendre en charge tout au long du contrat selon le standard IEEE STD 1362-1998. Il sera diviser en plusieurs sections et sous sections qui expliquerons touts les elements nécessaires a la comprehension globale du projet qui s’apprête a être entamé à l’intention du lecteur. 

### 1.1 Identification du système

Le tout nouveau système que nous voulons proposé se resume a se qu’ont pourrait appeler un « Sandbox FPS ». En effet, il s’agit d’un nouveaux concept de jeux video 3D qui possède certaines caractéristiques unique qui seront discuté en details plus tard dans le document afin de mieux comprendre en quoi ce system est different des jeux de tire standard dans l’industrie actuelle. Le jeu se jouera initialement de façon locale ( mode multi-joueurs sera developpé par la suite).

Notre jeu aura le nom de Alpha Strike et il s’agira de la premiere version (1.0) de ce system.

### 1.2 Objectifs du document


L’objectif de ce document  est essentiellement de décrire et communiquer les différerents besoins des usager du system en place dans l’industrie actuel qui motive le projet que nous voulons réaliser.  Ainsi, une nouvelle approche sera implémenter en réponse de ces manquement dans notre system.

Ce document s’adresse au commanditaire de notre projet afin de transmettre, de façon transparente, une bonne comprehension des besoins des usagers. Il s’adresse aussi au développeurs, tout comme au usager, pour s’assurer que le document décrit leurs besoins de façon fidèle et prendre en compte tout changement mineur potentiel.

### 1.3 Vue d’ensemble du système

Le l’objectif du system que nous voulons developper vise a combler le besoin d’entrainement au tir (à l’arme a feu) qu’un utilisateur pourrait avoir avant qu’une partie de jeux officiel se lance. Cet entrainement pourrait s’appliquer de près ou de loin a n’importe quel jeu de tir présent sur le marché. Ceci est justement du au sous-system « Sandbox » que notre jeux aura.

Nos commanditaire sont principalement les futures utilisateurs de notre system et nous supporte en réponse de leurs besoins a travers la plateforme go fund me. Afin de garder l’intérêt de nos supporteurs, le développement de notre system sera diviser sous plusieurs livrables afin d’apporter de la valeurs de façon soutenu a la réalisation de chaque sous-system composant le projet finale. Ainsi, nous nous assurons de nous aligner constamment avec les exigeances de nos utilisateurs en accumulant le feedback de chaque livrables mis en ligne.

**Diagramme de context:** 
![test](Img/DiagrammeContext.png)


# 2. RÉFÉRENCES
- Unity. https://unity.com/
- “Screen Tearing”, 10 octobre 2019. https://en.wikipedia.org/wiki/Screen_tearing 

# 3. LA SITUATION OU LE SYSTÈME ACTUEL

Il existe actuellement dans certains jeux de tir à la première personne un mode de pratique dans lequel le joueur peut s’exercer sur différentes armes. Cependant, dans bon nombre de cas les cibles sont immobiles ou sur un trajet prédéterminé ce qui, à la longue, n’exerce plus vraiment aucun réflexe. Le système que l’on propose réglera ce problème.

### 3.1 Contexte, objectifs et portée du système actuel

Le jeu de tir à la première personne est l’un des types de jeux vidéo les plus populaires, donc le niveau des joueurs qui y jouent varie énormément. Pour s’améliorer, ces personnes doivent évidemment posséder le ou les jeu(x) en question et l’environnement de pratique sera dédié seulement à ce jeu. De plus, sachant que la plupart des jeux AAA se vendent autour de 80$ CAD, la facture monte vite en tenant compte que cette fonctionnalité n’est pas offerte de base dans tous les jeux.

Une fois dans l’environnement de pratique, le joueur se bute souvent au même type de problème, soit la possibilité de tirer différentes armes, mais sans aucun but précis. La plupart du temps, des cibles peuvent être présentes, mais immobiles, ou des « bots » peuvent suivre une trajectoire prédéterminée dans le tableau. Ceci a comme résultat que le joueur aura eu la chance de savoir un peu mieux comment chaque fusil du jeu se comporte, mais n’aura pas du tout exercer ses réflexes, sa précision et sa façon de bouger.

En ce moment, un joueur qui s’exerce à un jeu A ne peut pas transposer cette expérience dans un autre jeu B. Le fait qu’il n’y ait pas de but précis autre que de tirer les armes spécifiques à un jeu fait en sorte que cette pratique n’est qu’utile pour que ce jeu.

### 3.2 Politiques opérationnelles et contraintes

Les jeux AAA de type FPS sont souvent parmi les plus gourmands sur le marché du jeu vidéo. L’espace mémoire requis varie d’un jeu à l’autre, mais de nos jours il n’est pas rare que cela monte dans les 80go-100go. De plus, il est important de considérer la carte graphique, car il sera peut-être possible de rouler le jeu avec une carte un peu plus vieille, mais pour être compétitif dans ces jeux il est crucial d’avoir une expérience de jeu fluide avec de bonnes performances. Finalement, une bonne connexion internet est nécessaire et de préférence branchée, car le Wi-Fi peut être parfois instable.

### 3.3 Description du système actuel ou de la situation courante

#### 3.3.1 L’environnement opérationnel et ses caractéristiques

Pour faire rouler un jeu de tir à la première personne, un joueur doit avoir en sa possession tous les composants de bureau, soit son ordinateur personnel, moniteur, clavier, souris, un système de son ou écouteurs, ainsi qu’une connexion internet. 

En détails, les jeux d’aujourd’hui nécessitent un grand nombre de Go en espace mémoire de libre pour pouvoir être installé. Il faut aussi en prévoir un certain surplus pour les mises à jour à venir.

Pour ne pas avoir de problèmes de performances, le joueur voudra se doter d’une carte graphique récente pour rouler le plus grand nombre de jeux avec fluidité.

Un moniteur avec un bon taux de rafraîchissement (par exemple 144hz et +) est un bon avantage à avoir en comparatif aux moniteurs plus âgés qui sont plutôt de 60 ou 75hz. Ceux qui en font l’expérience parviennent difficilement à expliquer la différence, mais une fois qu’un joueur fait l’expérience d’un bon moniteur avec un taux de rafraîchissement plus élevé, il ne veut pas retourner en arrière. Tous les mouvements à l’écran sont plus fluides et il y a moins de « screen-tearing » ou déchirement d’écran. Les jeux de tir à la première personne reconnus pour leur rapidité amplifient ce problème de par le fait que le flux vidéo n’est pas toujours synchronisé avec le taux de rafraîchissement du moniteur.

Un bon casque d’écoute est recommandé pour avoir un son plus précis et plus immersif. De plus, ces casques ont la plupart du temps un microphone permettant la communication avec les coéquipiers en ligne.

En terme de connexion internet, tous les joueurs s’entendent pour dire qu’il est primordial de jouer avec une connexion câblée. Le Wi-Fi étant trop instable, en étant branché le joueur s’assure de ne pas avoir de mauvaises surprises durant ses parties. Un bon forfait internet chez le fournisseur est recommandé avec des bons taux de téléchargement et d’envoi, ainsi qu’avec une grande capacité de téléchargement disponible. Idéalement, un forfait avec téléchargement illimité est la meilleure option puisque les jeux sont de grande taille.

#### 3.3.2 Les interfaces du système actuel avec les systèmes/procédures externes

Les menus de jeux se ressemblent tous et offrent la possibilité au joueur :
- modifier ses contrôles, ce qui affectera un fichier de configuration local sur son pc
- commencer une nouvelle partie de pratique ce qui initialisera soit une partie en local ou établira une connexion sur un serveur entre plusieurs joueurs en ligne
- un système d’amis qui communique avec la base de données pour l’historique des messages et qui utilise également un serveur pour permettre à deux personnes de clavarder ensemble

#### 3.3.3 Les fonctionnalités, fonctions, et caractéristiques (« features ») du système actuel

Joueur :
- La physique de base, soit les déplacements comme avancer, reculer, sauter et bouger sa tête (perspective de première personne qui répond aux mouvements de la souris)
- Interactions avec les armes comme tirer et les recharger
- Clavarder, communiquer vocalement (mode en ligne seulement)

Fusil :
- Tirer des munitions
- Se recharger
- Avoir un recul qui affecte la façon dont l’arme se comporte si on tient la gâchette enfoncée

Bot :
- Suivre une trajectoire prédéterminée
- Attaquer les joueurs selon une intelligence artificielle / difficulté réglable

#### 3.3.4	Les coûts d’opération du système

Selon la popularité d’un jeu FPS, allant parfois jusque dans les millions de joueurs connectés en même temps, les compagnies doivent investir de bons montant dans des solutions d’hébergement de serveurs pour offrir un service fiable en tout temps.

#### 3.3.5	Les facteurs de risques opérationnels

Qui dit plus grand jeu, dit plus grande possibilité de failles et la communauté y jouant étant plus grande, ceci ouvre souvent la porte aux gens malveillants de tenter de ruiner l’expérience pour les joueurs honnêtes. Certaines personnes créent et utilisent des « hacks » pour tricher dans leurs parties. Une autre méthode employée par ces personnes peut être les attaques DDoS (par déni de service). Ce type d’attaque bombarde les serveurs de jeu pour tout simplement les rendre indisponibles pour les autres.

#### 3.3.6	Les caractéristiques de performance telles la vitesse, les volumes, les fréquences, et les taux de transmission ou production

Les compagnies de jeux permettent souvent aux joueurs de se connecter sur leurs serveurs par région. Ceci fait en sorte qu’un joueur Européen sera connecté avec des gens plus près de lui plutôt que de jouer sur des serveurs nord-américains, ce qui rendrait la partie désagréable pour les deux parties impliquées de par les baisses en performances.

#### 3.3.7	Les attributs de qualité tels la disponibilité, la précision, l’efficience, les possibilités d’expansion, la flexibilité, l’interopérabilité, la facilité d’entretien, la portabilité, le fiabilité, la réutilisabilité, la facilité à fournir le support, les problèmes de survie et l’utilisabilité

Ayant souvent besoin de mises à jour pour régler tout type de problèmes, les compagnies de jeux annoncent souvent à l’avance sur leurs différentes plateformes lorsque des maintenances auront lieu et le temps d’interruption du système qui sera requis.

#### 3.3.8	Les mesures prises pour assurer la sécurité, la confidentialité, l’intégrité et la continuité des opérations en cas d’urgence.

Il existe des mesures de sécurité pour protéger les données confidentielles comme les informations personnelles (profil, données de paiement, etc). En effet, il est souvent possible d’ajouter la double authentification (2F) à son compte pour le sécuriser davantage. De plus, les joueurs peuvent rejoindre le service à la clientèle et répondre à des questions de sécurité en cas de problèmes avec leur compte utilisateur.

### 3.4 Les modes d’opération du système ou de la situation actuelle

Les jeux actuels offrent souvent deux modes de pratique, soit en ligne ou hors-ligne.

En général, le joueur sera placé en mode hors-ligne dans un serveur local et pourra faire ce qu’il veut, selon les fonctionnalités offertes.

Le mode en ligne en revanche connectera le joueur à d’autres personnes et ils pourront progresser en coopérant contre des « bots » qui auront une intelligence artificielle qui peut souvent varier. Il est souvent possible de choisir la difficulté à laquelle on veut les affronter.

### 3.5 Les classes d’utilisateurs et les autres personnels impliqués

#### 3.5.1. La structure organisationnelle

Il n'y a pas de structure organisationnelle. Les joueurs jouent en mode local, c’est-à-dire hors-ligne ou ils sont connectés ensemble en ligne sur un serveur hébergé directement par la compagnie du jeu en question, ou par un tiers qui fait l’hébergement et la gestion des serveurs pour cette compagnie.

#### 3.5.2. Le profil de chaque classe d’utilisateurs

Le joueur est celui qui utilise le jeu pour s’améliorer, plus précisément l’environnement de pratique dans le cas présent. Lors d’une séance de pratique, le joueur peut être seul ou en équipe avec d’autres joueurs contre l’ordinateur (« bots »). Les fonctionnalités sont limitées dans ces environnements de pratique, mais en général un joueur peut se déplacer, tirer différentes armes. À tout moment, un joueur peut mettre fin à la pratique et retourner au menu principal du jeu.

#### 3.5.3 Les interactions entre les utilisateurs

Si un joueur se pratique en ligne, il peut communiquer avec ses coéquipiers par « chat », soit textuel ou vocal. Dans certains cas, la notion de tir allié existe, donc un joueur pourra infliger du dégât à son coéquipier et lui faire perdre de l’énergie.

#### 3.5.4 Autre personnel impliqué

Il existe souvent un support technique sur les sites des éditeurs de jeux vidéo. Que ce soit par téléphone ou par le biais du site, il est possible pour les joueurs de contacter ces équipes de support pour tenter de régler les problèmes rencontrés sur le jeu.

#### 3.6 L’environnement de support

Les jeux de tir à la première personne sont plus populaires sur ordinateurs personnels et sont maintenant souvent offerts autant sur Windows que Linux. Ces jeux nécessitent souvent des maintenances pour régler des failles, faire des ajustements pour satisfaire les joueurs ou pousser du nouveau contenu. Un jeu qui vient d’être lancé aura des maintenances plus fréquentes, mais il n’est pas rare de voir un jeu avoir des mises à jour mensuelles ou hebdomadaires, toujours de tailles variées.

Pour obtenir du support en cas de problème avec le jeu, un joueur peut souvent envoyer des rapports de « bugs » lorsqu’ils surviennent, se tourner vers l’internet pour trouver de l’aide soit sur le site du jeu ou sur des forums comme Reddit ou même YouTube. Étant très populaires, il existe souvent des solutions en ligne pour les problèmes dans les jeux FPS, car beaucoup de gens ont le même problème en même temps.

Un autre moyen qui est parfois offert est d’appeler directement un service à la clientèle sur les sites des jeux ou d’utiliser un système de billetterie pour créer un incident qui sera investigué par une équipe de support.

# 4. LA JUSTIFICATION ET LA NATURE DES CHANGEMENTS

Cette section porte sur la justification des changement qui sont implementé dans notre system en réponse des problèmes rencontrés avec la situation dans l’industrie actuelle. Ainsi, les raisons justifiant les changement apporté permettront de mieux comprendre le contexte des caractéristiques du nouveau système.

### 4.1 Justifications des changements

Tout d’abord, on peut constater un manque dans l’environnement de certains jeux de tirs actuelles qui est, entre autre, la possibilité de s’entrainer afin d’améliorer ses competences sur le jeux. Certes, certains environnement offre cette possibilité, mais le désavantage d’un mode d’entrainement que peut inclure un jeux aujourd’hui est que les competences qui seront acquise chez le joueurs ne pourront être applicable chez d’autre jeux de tirs en raisons de plusieurs facteurs d’implementations que font en sorte que la mécanique et la physique des jeux sont très différentes

Notre mission est donc de proposer une solution a ce besoin a l’aide d’un nouveau concept que nous développeront pour nos utilisateurs. Il s’agit d’un jeux personalisable (Sandbox) ou un joueur pourrait s’entrainer en choisissant/modifiant plusieurs paramètres définissant sa partie d’entrainement. En d’autre terme, l’utilisateur a le contrôle total sur les paramètres physique du jeux, sur les caractéristiques des armes qu’il utilise, la fluidité de mouvement du personnage qu’il incarne, etc. Ainsi, un joueur peut, s’il le veut, personaliser les elements d’une partie pour s’entrainer a un autre jeu qui n’offre peut-être pas cette possibilité. Les competences developper lors d’une partie peut donc être portable d’un jeu a un autre.


L’une des faiblesses du nouveau concept serait la necessité de mise a jours régulières qui permettrais d’offrir la possibilité de modifier certains paramètre du jeux en alignement avec les nouveaux jeux de tirs qui sorte dans le marché actuel. Ainsi, les utilisateurs de notre jeux pourront personaliser en profondeur leurs parties pour s’entrainer a de nouveaux jeux.

### 4.2 Description des changements
Cette Section portera sur la description des nouvelles fonctionnalités, processus, interfaces et autres changements requis afin de répondre au facteurs identifié en 4.1.

#### Les changements aux fonctionnalités
1) Les nouvelles fonctionnalité qui seront incluse dans le nouveau system comparativement aux  mode d’entrainement des jeux que nous pouvons trouver sur le marché sont touts les aspects du « gameplay » personnalisables que peut modifier le joueur : Par exemple la physique du recule d’une arme, l’environnement (elements) de la piece de jeu, le types d’adversaire et autres aspects qui pourront être implementer a la demande de nos utilisateurs au fils du temps. l’objectif fixée de cette fonctionnalité est d’offrir un environnement d’entrainement au tir étant portable(en terme de compétences developpé) d’un jeux a un autre. Une autre fonctionnalité consideré par notre system est d’integrer un « leaderboard » afin que les utilisateurs puissent comparer leurs score et créer un aspect compétitif a notre projet
 

#### Les changements aux interfaces
1) L’interface du nouveau system est au coeur meme de la mission du nouveau system. Il y aura donc un changement au niveau de l’interface de notre jeux par rapport aux jeux de tirs traditionnel pour répondre aux objectifs de notre system. L’interface du jeux sera conçus de sorte que l’utilisateur puisse définir en tout temps les paramètres de son entrainement au tir. L’interface du menu sera donc disponible a l’utilisateur en tout temps, incluant une partie d’entrainment pour effectuer les modifications ou achat (d’armes ou autre item) qu’il souhaite.
   
#### Les changements de personnel
3) La forte necessité de mise jours et autre regulations dont notre système aura besoins de façon régulière, requière forcement des changement au niveau du personnel nécessaire au maintient de notre jeu. Les nouvelles exigence que notre system entraine est le suivis des apparitions de nouveau jeux, nouvelles armes ou nouveau mode de jeux afin d’implementer des réglages d’entrainement dans notre nouveau system. Ceci nécessite du personnel qui écoute et implémente ses changements.
   
#### Les changements dans l’environnement opérationnel
4) Puisque le développement est très focaliser sur l’aspect sandbox durant les entrainement, L’utilisation d’un « Game Engine » tel que Unity nous aide durant le développement et dans le rendue 3D de notre jeu. Notre system depend donc entièrement de Unity en ce qui attrais en rendu visuel 3D. Ces facteurs entraine un changement complexe au niveau de l’environnement opérationnel de notre jeux qui peut être diviser en trois partie: le processus de reflexion des sous systèmes du jeux qui seront personalisable, le processus d’implementation du coté sandbox selon la physique du moteur de jeu Unity et le rendu 3D.
   
#### Les changements aux opérations
5) Les changements aux operations que cela entraine sont au niveau de la maintenance. Une fois que le squelette de notre jeu Sandbox sera completer, un travail périodique de notre personnel sera nécessaire afin de réfléchir et d’implementer toutes personalisation jugé pertinente par nos utilisateurs.
   
#### Les changements dans le support
6) Le principal changement dans le support de développement de notre projet est offerte par le moteur de jeu que nous avons choisis, c’est a dire Unity. Tout autre language de programmation qui sera utiliser possède ca propre documentation en harmonie avec ce moteur de jeu,
En ce qui concerne le support que nous offrons, une équipe sera disponibles pour toute suggestion d’ajout ou de modifications en se qui concerne les caractéristiques de notre projet.

#### Les autres changements
7) Le role de nos utilisateurs dans la direction que prendra notre projet aura un impact direct sur leurs experience d’entrainement au tir, puisque c’est eux meme qui propose les fonctionnalité de personalisation qu’aura notre jeu Sandbox.


### 4.3 L’ordre de priorité dans les changements

Le projet comporte des changements dont les priorité peuvent varié selon leur importances. L'ordre de priorité sera divisé comme suit: 

- **Essentielle**: caractéristique ou fonction qui doit nécessairement être fournie par le nouveau système.
   La possibilité de personnalisé,de facon basique, son environnement d'entrainement incluant la physique du jeu serais fortement souhaitable une fois que la base du projet sera terminé. Ceci donnera un sens a la caracteristique Sandox du jeu.

   La construction du squelette de notre jeux sandbox est essentiel a la viabilité de notre projet a long terme. Toute les autres fonctionnalité qui seront developpé par la suite dépendront de notre squelette. Ce qui sera essentielle de developer en premier sera en d’autre terme, les physique de base du jeu d’entrainement, ce qui inclut: Un menu, les mouvements basics du personnage, la capacité de tirer avec une arme, la physique de l’arme,un environnement d’entrainement personalisable basique.


- **Souhaitable**: caractéristique importante mais non essentielle à être fournie par le nouveau système. Un mode multi-joueurs incluant un chat vocale.
  
- **Optionnelle**: caractéristique que le système pourrait offrir. Ce qui serais optionnel dans notre projet est touts achats d'armes, de skin, ou autre accesoir personalisable  pouvant ameliorer l'experience de l'utilisateur via le menue du jeu.

### 4.4 Les changements considérés mais non-inclus

Cette section identifie les changements et les nouvelles caractéristiques que notre equipe a  considérés à la section 4.2 mais qui seront non-inclus dans le projet.

La fonctionnalité peremttant d'etablir un tableaux des scores ne sera pas incluse dans le projet apres reflexion. Nous penseons qu'elle derive de la mission de notre projet et qu'elle n'est pas essentielle au succes du jeux que nous voulons developper. le but de notre projet etant de creer un environnement d'entrainement le plus maniable possible par l'utilisateur, Il ne serais pas pertinenent de s'eloigner de cet objectif dans ce qu'inclus le projet. De plus, pour que les scores de nos utilisateurs est un sens comparatif, il faudrais que touts les parametres personalisables de la partie d'entrainement sois exactement identiques et consistante, ce qui rendrais difficile d'obtenir des resultat equitable au niveau mondiale. En eliminant cette charge de travaille qui requiert une tres grande gestion de base de donnes et de la regulation, notre equipe pourra se focaliser sur le besoin que nous cherchons a satisfaire a travers notre system.


### 4.5 Hypothèses et contraintes

Cette section décrit les hypothèses et les contraintes applicables aux changements et aux nouvelles caractéristiques déjà identifiés. Il s’agit de tout ce qui risque d’affecter les utilisateurs durant le développement et l’opération du nouveau système.

Une hypothese que nous envisageons  est la forte demande de nouvelles fonctionnalités de la part de notre communauté d’utilisateur via kickstarter.com. Une fois que la base du projet sera terminé, notre communauté prendra une place importante dans l’avancement de notre projet en nous proposant des idées de fonctionnalités a implementer dans notre jeux en plus des notres. Ceci nécessitera bien évidemment des ressources alloué a l’écoute et a l’analyse des petits projets proposé que nous allons ajouté a notre system en fonction du budget disponible. 

Une fois que les fonds necessaires au developpement de la fonctionnalité multijoueurs du jeu seront diponible, nous estimerons la charge d'utilisateurs que devera soutenir les serveurs multi-joueurs. Actuellement, notre hypothese basé sur notre communauté prevois 5000 joueurs simultané. 

# 5. LE CONCEPT DU SYSTÈME PROPOSÉ

Cette section portera sur le système qui résulte de l’application des changements proposés à la section 4. Il s’agit d’une description de haut-niveau indiquant les caractéristiques et fonctionnalités du système sans s’attarder sur sa conception. Le niveau de détail de cette section est suffisant pour qu’un utilisateur puisse vérifier que le système proposé répond à ses besoins.

Certains elements de conceptions seront utile afin d'avoir un apercus de la structure du developpement.

1) Contraintes de conception : Le moteur graphique de notre jeux sera une contrainte de conception importante durant le developpement. Nous dependerons entierement de la fiabilité du support Unity tout au long du developpement. 


2) Stratégies de conception : Notre strategie de conception sera fortement alignée avec notre communauté QuickStarter. Chaque projet proposé par notre communauté sera etudié, validé et developper par notre equipe si les ressources alloué le permette.

ce qui suit reprend une à une les rubriques de la section 3, mais pour décrire le système proposé. Si une fonctionnalité ou caractéristique du système proposé est identifique au système actuel, alors « aucun de changement » est indiqué, sans rentrer dans le détail.

#### 5.1 Contexte, objectifs et portée du système proposé

Le Context du system que l'on propose est centré dans le domaine du jeux video. Plus precisement, les jeux de tirs à l'arme a feu. Nous proposon un jeux d'entrainement au tir aux caracteristiques unique qui nous differencie des systems actuelles. Notre objectif est de creer un jeux d'entrainement au tirs entierement personnalisable en concordance avec nos utilisateurs et supporteurs provenant de la plateforme Quickstarter.com. La porté de notre system inclus plusieurs milliers d'utilisateurs (5000 joueurs) qui seront eventuellement amené a joué en multijoueurs une fois l'infrastructure de ce sous system deployé. Un joueurs pourra personnalisé son environnement d'entrainement, de la physique de son personnage à l'environnement qui l'entoure, lors de sa partie d'entrainement. Ainsi, il pourra s'entrainer et s'amuser sans restriction particuliere ce qui permettra la portabilité des competences qu'il aura developpé. La premieve version de notre system aura un fonctionnement basic et restrint. Se sera le squelette de notre system et n'inclura pas de fonctionnalité permettant de personalisé les aspect du "gameplay". Les fonctionnalités qui seront ajouté par la suite proviendrons des propositions faite au fil du temps par notre equipe et notre communauté QuickStarter. Nous serons donc en permanence en contact avec nos utilisateurs et ainsi, nous pourrons offrir un produit construit en bonne partie avec leurs demandes.

#### 5.2 Politiques opérationnelles et contraintes

Notre system sera disponible pour telechargement local 24h/24h puisqu'il n'y aura pas de mode multi-joueurs durant ces premieres versions. Une fois que les ressources seront suffisante apres le deploiement de la premiere version, nous prevoyont un maximum 5000 utilisateurs simultané dans nos serveurs multi-joueurs qui seront dipsonible 24h/24 aussi.

Le nombre minimum d'employer necessaire (Notre equipe) pour operer le system sera le meme pour les premieres versions. Nous ajusterons selon le besoin au fil du temps.

Notre system necessite naturellement un ordinateur suffisament puissant pour faire tourner un jeux moyen. Plus precisement, voici le materiel necessaire minimum pour fair fonctionner de maniere convenablement fluid un jeux Unity :

**Unity Editor system requirements**
![test](Img/requirements.png)

#### 5.3 Description du système proposé 

1) **L’environnement opérationnel et ses caractéristiques.**
   
   Le moteur graphique Unity qu'utilise notre jeux est au centre de l'environnement operationnel qu'aura la premiere version de notre system. Se sera a la fois notre environnement de developpement et la source du rendu 3D. Le moteur du jeux utilisera les ressources graphiques de bas niveaux de lordinateur pour offrir au joueurs une experience fluide et optimisé.

2) **Les principales composantes du système et leurs interconnexions**
   ![test](Img/Composantes.png)

   
3) **les interfaces du système avec les systèmes/procédures externes.**
   
   Le menu du jeux sera l'interface principale de l'utilisateur. Se sera a travers elle qu'il pourra personnalisé ca partie d'entrainement. Cet interface modifira les scripts a utiliser lors de la partie d'entrainement pour l'ajuster au preferences de l'utilisateurs.
   Il sera aussi possible d'acheter des armes de haute qualité a l'aide du menu. Un system d'affichage des achats disponibles sera integrer dans une section du menu. L'utilisateur sera ensuite rediriger vers notre site pour finaliser son achat.
   
4) **les fonctionnalités, fonctions, et caractéristiques (« features ») du système.**
   
   La premiere version qui sera developpé comprendra une physique fonctionnel de base. Un personnage pouvant se deplacer et sauter. La fonctionnalité de tirer avec une arme specifique sera incluse dans cette version. L'environnement d'entrainement sera une chambre fermé avec des cibles simple.
   
   
5) **Les coûts d’opération du système.**
   
   La platefrome QuickStarter.com sera notre source de revenue pour le lancement de la permiere version du jeux.
   
6) **Les facteurs de risques opérationnels.**
   
   Le plus gros risque dont nous devons nous focaliser pour le moment est le support que devera soutenir nos serveurs lorsque l'infrastructure multi-joueurs sera mise en place. Il est difficile de predire a l'heur actuelle le gain d'utilisateurs potentiel que notre jeux aura.
   
7) **les caractéristiques de performance telles la vitesse, les volumes, les fréquences, et les taux de transmission ou production.**

    Vue que la permiere version sera fonctionnel de facon local, les seules restrictions de performance seront celles de la machine utilisé. En revanche, une evaluation selon le nombre d'utilisateur actif sera faite pour planifier la mise en place de notre infrastructure multi-joueur. 5000 joueurs simultané est notre hypothese actuelle pour notre fonctionnalité multi-joueur.
   
8)  **Les attributs de qualité tels la disponibilité.**
    
    Notre equipe mettra l'accent sur la qualité de chaque nouvelles fonctionnalité proposer par notre communauté, chacune d'elle sera etudié comme un projet appart a intégré a notre squelette. Les possibilité d'expansion sont tres grande, ce qui engendre un risque de stabilité. C'est pour cela que l'energie qui sera depensé dans la qualité du squelette de notre projet est indispensable a la portabilité (differentes plateformes de jeux si l'occasion se présente) et a la viabilité a long terme du projet. Avoir une bonne base dans notre premiere version permettra une excellente flexibilité ainsi qu'une facilité d'entretien pour nos developpeur a long terme. De plus, une grande partie du support sera disponible via l'equipe de support spécialisé de notre moteur Unity, ce qui accroit la fiabilité en notre projet.
    
9)  **Les mesures prises pour assurer la sécurité, la confidentialité, l’intégrité et la continuité des opérations en cas d’urgence.**

    Notre system permettra effectivement l'achat d'armes et de differents accesoir de toute sorte. Ceci implique la necessité d'une protection efficace lors des transactions. Puisque nous somme encore a une phase prematurer dans notre projet, toute transaction sera faite par l'intermediare de Quickstarter.com et Paypal. Ainsi, nous allouons a ce stade ce facteur de securité a des specialiste dans le domaine.



#### 5.4 Les modes d’opération du système ou de la situation proposé

L'element clef qui sera ajouté dans les modes d'operation hors-ligne et eventuellement en ligne sera la personalisations détaillé des environnements des parties de jeux.

#### 5.5 Les classes d’utilisateurs et les autres personnels impliqués

- Aucun de changement

#### 5.5.1 La structure organisationnelle
- Aucun de changement

#### 5.5.2 Le profil de chaque classe d’utilisateurs

- Aucun de changement

#### 5.5.3 Les interactions entre les utilisateurs

- Aucun de changement

#### 5.5.4 Autre personnel impliqué

La communauté QuickStarter est une forme de personnel, en plus de l'equipe de developpement, qui sera fortement impliqué dans la direction que prendra notre projet puisque l'equipe de developpement se basera en grande partie sur elle pour s'orienter.

#### 5.6 L’environnement de support
- Aucun de changement

# 6.	LES SCÉNARIOS D’OPÉRATION

<table>
 <tr>
  <td>Nom</td>
  <td>Lance une partie</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td>La partie est lancé pour l'utilisateur</td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de lance une partie <br>
4.	Le système lui affiche les modes de jeux disponibles <br>
5.	Le mode de jeu est sélectionné par l’utilisateur <br>
6.	Le système affiche la page de chargement de la carte à l’utilisateur <br>
7.	La partie est lancé
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>5a.  L’usager annule son choix <br>
6a.  Le système affiche les options du menu
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>1 fois par partie</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Acheter un produit</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td>L'utilisateur a en sa possession l'objet acheté</td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi d’accéder au magasin <br>
4.	Le système lui affiche les produits disponibles par catégorie, soit les armes, ainsi que les thèmes de pièce. <br>
5.	L’usager choisi son produit choisi <br>
6.	Le système affiche une confirmation du choix de l’utilisateur <br>
7.	L’usager confirme son achat <br>
8.	Le système débite l’argent du compte de l’usager et lui débloque le produit <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>7a.  L’utilisateur annule son achat <br>
8a.  Le système affiche les produits disponibles <br><br> 

8b.  Le système détecte un manque de fonds pour l’usager et lui afficher un message d’erreur expliquant la situation <br>
9b. Le système affiche les produits disponibles <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>1 fois par session</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Appliquer un skin</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi d’éditer ses paramètres de jeu <br>
4.	Le système lui affiche le contenu éditable, soit le choix de son arme, de sa salle et de ses contrôles de jeux <br>
5.	L’utilisateur sélectionne ses changements <br>
6.	Le système affiche un message de confirmation sur les changements de l’utilisateur <br>
7.	L’usager confirme les changements <br>
8.	Le système applique les changements <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>7a.  L’usager annule son choix  <br>
8a.  Le système affiche le contenu éditable, avec les changements préétablis par l’usager, sans toutefois les appliquer <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>1 fois par partie</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Quitter la partie</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de quitter le jeu <br>
4.	Le système affiche un message de confirmation pour quitter le jeu <br>
5.	L’usager confirme sa volonté de quitter <br>
6.	Le système met fin au jeu <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>4a.  L’utilisateur annule son choix <br>
5a.  Le système affiche le menu <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>1 fois par partie</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Consulter ses statistiques</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de visualiser ses statistiques <br>
4.	Le système affiche les statistiques globales de l’utilisateur, soit sa précision générale, son record de points et sa meilleure arme <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>5a.  L’utilisateur applique un filtre sur ses statistiques, soit une arme précise ou une période de temps précise <br>
6a.  Le système affiche les statistiques de l’utilisateur <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>Approximativement 1 fois avant une partie</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Tirer une cible</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de lancer une partie <br>
4.	Le système lui affiche les modes de jeux disponibles <br>
5.	Le mode de jeu est sélectionné par l’utilisateur <br> 
6.	Le système charge et lance la partie <br>
7.	Le système affiche aléatoirement des cibles sur la carte de jeu <br>
8.	L’utilisateur, en appuyant sur la touche gauche de sa souris (par défaut), envoi des projectiles vers les cibles <br>
9.	Le système vérifie si la cible a bien été atteinte <br>
10.	L’usager reçoit de l’argent comme la cible a été touché <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>8a.  L’utilisateur ne reçoit pas d’argent car celui-ci a raté la cible <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>100 fois par partie</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Se déplacer sur la carte</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de lancer une partie <br>
4.	Le système lui affiche les modes de jeux disponibles <br>
5.	Le mode de jeu est sélectionné par l’utilisateur <br>
6.	Le système charge et lance la partie <br>
7.	L’usager, à l’aide de de sa souris, ainsi que les touches a,w,s,d et espace de son clavier (par défaut), tente de se déplacer <br>
8.	Le système analyse la touche appuyée par l’utilisateur <br>
9.	L’usager est déplacé <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>9a.  Le système constate que l’usager se retrouve dans l’impossibilité de se déplacer <br>
10a. L’usager n’est pas délacé <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>50 fois par partie</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Recharger son arme</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de lancer une partie <br>
4.	Le système lui affiche les modes de jeux disponibles <br>
5.	Le mode de jeu est sélectionné par l’utilisateur <br>
6.	Le système charge et lance la partie <br>
7.	L’utilisateur, en appuyant sur la touche r de son clavier, tente de recharger son arme <br>
8.	 Le système vérifie si l’arme contient déjà son plein potentiel de balle et su l’usager possède encore des munitions <br>
9.	Le système déduit les balles disponibles et les ajoute dans l’arme courante de l’usager <br>
10.	L’usager peut continuer sa séance de tirs <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>9a.  Le système détecte que l’arme de l’usager est pleine, et donc ne procède pas à sa recharge <br>
10a.  L’usager peut continuer sa séance de tir <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>20 foirs par partie</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Voir les crédits</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de voir les crédits du jeu <br>
4.	Le système débute une cinématique affichant les membres de l’équipe de développement du programme <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td></td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>1 fois par 60 parties</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

<table>
 <tr>
  <td>Nom</td>
  <td>Déclarer un bogue</td>
 </tr>
 <tr>
  <td>Niveau</td>
  <td>But utilisateur</td>
 </tr>
 <tr>
  <td>Acteurs</td>
  <td>Usager</td>
 </tr>
 <tr>
  <td>Préconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Postconditions </td>
  <td></td>
 </tr>
 <tr>
  <td>Scénario principal </td>
  <td>1.	L’utilisateur Accède au menu <br>
2.	Le système affiche les options disponibles <br>
3.	L’usager choisi de déclarer un bogue <br>
4.	Le système lui affiche un formulaire demandant plus de détails sur le bogue <br>
5.	L’utilisateur rempli le formulaire en mentionnant les conditions pour recréer le bogue <br>
6.	Le système reçoit le formulaire et informe l’usager de la réception du cas <br>
7.	Le système créer un cas et en informe l’équipe de développeur <br>
  </td>
 </tr>
 <tr>
  <td>Scénarios alternatifs </td>
  <td>5a.  L’utilisateur renonce à l’envoi du formulaire <br>
6a.  Le système retourne au menu et affiche les options disponibles <br>
  </td>
 </tr>
 <tr>
  <td>Fréquence d’occurrence </td>
  <td>1 fois par 100 parties</td>
 </tr>
 <tr>
  <td>Autres commentaires/exigences </td>
  <td></td>
 </tr>
</table>

# 7.	LE SOMMAIRE DES IMPACTS
### 7.1 Les impacts opérationnels

Les impacts sur les joueurs qui décideront de se procurer notre jeu seront minimes, car la base est déjà très similaire du monde du jeu actuel, particulièrement des jeux FPS. En fait, même un novice pourra très rapidement s’y retrouver. L’utilisateur de notre système n’aura pas à avoir de connaissances quelconques pour pouvoir s’amuser sur notre jeu, puisqu’on encourage tous les joueurs, à tous les niveaux, de se pratiquer dans notre environnement conçu spécialement pour eux.

Dans une itération future, les joueurs auront la possibilité de soumettre des commentaires et recommandations aux développeurs via un formulaire intégré au jeu, ce qui facilitera le suivi de la satisfaction et l’évolutivité de notre projet.

Finalement, étant donné que le projet est financé par la communauté via le site web Kickstarter pour faciliter son lancement, il y aura aussi présence minime de publicités, mais sans que ce soit invasif et que cela nuise à l’expérience utilisateur. Nous offrirons aussi des bonus par tranches de donateurs sur Kickstarter, par exemple enlever complètement les publicités, skins d’armes, carte unique, etc.

### 7.2 Les impacts organisationnels

Notre jeu ne nécessitera pas d’équipe de support à temps plein, puisque ce sera un Free-To-Play qui se jouera majoritairement hors-ligne. Par contre, les données statistiques des joueurs, ainsi que leurs informations de profils seront sauvegardées sur des serveurs. En cas de problème ce seront des administrateurs systèmes qui en seront avisés via un outil de billetterie par lequel les utilisateurs pourront soumettre leurs problèmes. Un « SLA » devra être respecté pour assurer un service fiable et permettre aux joueurs de pouvoir, idéalement en tout temps, utiliser toutes les fonctionnalités du jeu, que ce soit hors-ligne ou en ligne.

En terme de perte de données en cas de désastre, des sauvegardes seront automatisées sur les serveurs de façon à ce que les statistiques et toutes les données reliées aux parties qui ont été jouées par les joueurs ne soient pas perdues.

### 7.3 Les impacts durant le développement

Les principaux aspects qui impacteront les développeurs durant le développement du projet seront les retours de la part des utilisateurs, les tests et tout ce qui concerne les spécificités du nouveau contenu.

- Tests : Ils devront être faits régulièrement et rigoureusement pour assurer que notre environnement est stable et qu’il respecte bien les objectifs établis. Les développeurs doivent être en mesure d’offrir une expérience très personnalisable, tout en la rendant fluide et agréable.
- Commentaires et suggestions des utilisateurs : En effet, étant donné que le projet est propulsé par la communauté Kickstarter, les développeurs seront très à l’écoute de cette dernière tout au long du développement. Ceci aidera à assurer que les joueurs auront beaucoup plus ce qu’ils recherchent d’un environnement de pratique et mettra beaucoup plus rapidement les développeurs sur la bonne voie.
- Nouveau contenu : Notre environnement de pratique proposera un menu de personnalisation complètement pensé pour recréer l’atmosphère des jeux les plus populaires du moment (gravité, vitesse, style, etc). Ceci dit, pour obtenir ces spécificités, les développeurs auront à explorer tout ce qui se fait dans le moment, ainsi qu’à suivre aussi les commentaires des joueurs pour essayer d’être le plus précis possible. Les développeurs proposeront régulièrement des mises à jour pour toujours garder le jeu le plus complet possible et assurer la rétention des joueurs.

# 8.	L’ANALYSE DU SYSTÈME PROPOSÉ

#### 8.1 Le sommaire des améliorations

Principalement, l’implémentation de ce nouveau système permet une plus grande portabilité du jeu, essentiellement grâce au fait qu’il pourra fonctionner sur différents systèmes d’exploitation. Celui-ci est aussi en mesure d’ajuster ses commandes en fonction de ses préférences et du jeu auquel il désire s’améliorer. Ensuite, il y a le fait que le jeu est gratuit, contrairement à la plupart de ses compétiteurs. Cela a donc pour effet de réduire la barrière à l’entrée et rend le jeu facilement accessible à tous. 

Dans un autre ordre d’idées, comme le jeu est plutôt simple, celui-ci n’utilise pas énormément d’espace disque, il est donc facile et rapide de l’installer sur un ordinateur. En effet, ce paramètre va à contresens des jeux semblables, qui peuvent prendre près de 60 gigaoctet de données. De plus, l’aspect personnalisation des armes et de l’environnement de tir vient nous démarquer de la compétition, en offrant une plus grande liberté de choix aux utilisateurs.


#### 8.2 Les inconvénients et limites

Comme l’aspect modifiable des contrôles peut être difficilement saisissable pour l’usager, il est possible qu’un utilisateur soit un peu confus pour ses premières visites sur l’application.

La première version ne disposera pas de système global de pointage. En effet, cette fonctionnalité demande énormément d’efforts en termes de coût et de maintenance pour une première version. Il est toutefois possible que celle-ci soit implémenté dans une prochaine version.

Une autre limite du jeu est que celui-ci est simpliste à première vue. Toutefois, cela peut tout autant en être sa force. Comme ile ne prend pas beaucoup d’espace mémoire, et qu’il permet de recréer le contexte de jeu de plusieurs autres FPS, il est un choix optimal pour des utilisateurs souhaitant améliorer leurs performances de tir dans différents environnements. 


#### 8.3 Les alternatives et compromis considérés

Il est possible qu’un tutoriel soit implémenté afin de permettre une meilleure compréhension de l’utilisation de l’aspect modifiables des contrôles de l’usager. Cette décision sera prise à la suite de la mise en place de la première version du jeu. Si les retours des utilisateurs sont plutôt favorables à un tutoriel, celui-ci sera mis en place. 

Par soucis de manque de fonds pour le développement, il est probable de réduire le nombre de skins et personnalisation des couleurs et texture de la salle de tir afin de se focusser sur la plus grande fonctionnalité du jeu, soit la personnalisation des paramètres de jeu. Dans la mesure du possible, des paramètres par défaut devrait être disponible pour recréer l’environnement de jeux populaires tel que Counter Strike, Call of Duty et Halo, par exemple.

# 9.  NOTES

# 10. ANNEXES
# 11. GLOSSAIRE

**FPS** :Le jeu de tir à la première personne ou en vue subjective, souvent appelé Doom-like et FPS, sigle pour l'expression anglaise first-person shooter, est un genre de jeu vidéo de tir fondé sur des combats en vision subjective (« à la première personne »), c'est-à-dire que le joueur voit l'action à travers les yeux du protagoniste.

**Sandbox**: Le gameplay non linéaire désigne dans un jeu vidéo la possibilité qu'ont les joueurs de compléter des épreuves selon des séquences variables. Chaque joueur peut ne rencontrer qu'une partie des épreuves possibles, lesquelles pouvant en outre être jouées dans un ordre différent. Inversement, un jeu vidéo avec un gameplay linéaire confronte le joueur à une séquence fixe d'épreuves : chaque joueur rencontre chaque épreuve et ce, dans le même ordre.

**SLA**: Le terme SLA (Service Level Agreement) définit la qualité d’un service offert entre un fournisseur de service et un client. Dans le monde du support par exemple, cela peut se caractériser par les objectifs comme par exemple une fenêtre de temps à respecter pour régler un problème.
