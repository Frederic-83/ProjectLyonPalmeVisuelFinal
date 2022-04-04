# projetCsharp


---

# Projet Lyon Palme 

## 1. Présentation d’ensemble du projet 

  *Définition du besoin* : organiser les listes des prets des adherents

on decide de creer un tableau qui comprenne les prets des materieaux par les adherents de lyon palmes, ainsi que les dates de chaques prets.
Cela permet a la societe Lyon palme de savoir quelles materielles sont encore disponibles, ou sinon qui l'a maintenant et quand il devra etre retournée

ceci est creer sur C# par l'application Microsoft Visuel Studios.

---

### Initialiser 

Pour commencer, on doit installer un logiciel Heroku Cli, qu’on peut télécharger par le site officiel sous n’importe quel moyen. 
  + Avec Ubuntu : 
  ```
  $ sudo snap install heroku –classic
  ```

 + Avec HomeBrew :
  ``` 
  brew install heroku/brew/heroku
  ```
Dès que l'installation est complète, on peut accéder heroku dans l’invite de commande. On doit se loger avec un compte Heroku pour pouvoir l’utiliser. 
Pour loger sur heroku Cli: entrer la commande suivante, et puis entrer votre nom d’utilisateur et votre mot de passe : 
```
$ Login Heroku
```

### Accéder à GitHub 

Pour que le deployement peut être possible, on doit aussi assurer qu’on peut accéder à GitHub/Lab. On va donc entrer un répertoire Github sur Heroku Cli. On utilise mone répertoire comme exemple :
```
$ git clone https://github.com/Frederic-83/projetCsharp
```

Pour mieux incorporer votre future application avec le répertorie, on doit entrer dans le même répertorie. 
```
$ cd projetCsharp
```

### Créer l’Application Heroku 

Dès qu’on est dans le répertoire, on peut donc créer notre propre application avec la commande suivant: 
```
$ Heroku create
```

Par contre, on peut nommer notre application en écrivant le nom après create (on note qu'on ne peut pas utiliser les espaces et les lettres en majuscule): 
```
$ Heroku create projetcsharpfrederic
```

on peut aussi modifier ce ligne de commande pour que qu'on peut changer le location geographique par defaut de l'application.
dans ce cas, on met m'application de nationalite d'européen.
```
$ Heroku create projetcsharpfrederic --region eu
```

Lorsque on creer le compte, on a le possibilite de l'associer avec des addons qui permet a installer les languages de programmation dans l'application.
pour plus d'informations, et de voire quelles languages sont applicable avec les apps Heroku, utiliser le lien suivant:

```
https://devcenter.heroku.com/articles/buildpacks?msclkid=c497cf43b3ea11ecbeb2825b811ddaf3
```



### Instanciation de l'application Heroku:

Dès que l’application est créée, on peut le déployer avec le code suivant : 
```
$ git push heroku main
```

Lorsque l’application est créer/déployé, on peut e voire si c’est fonctionnel avec le code suivant : 
```
$ heroku ps:scale web=1
```

### (Si le code retourne un message d’erreur, on doit recommencer le code au-dessus) 

Comme l’appli est déployé, on peut le voir à n’importe quel moment : 
```
$ Heroku open
```

### View Logs : 

Lorsque le site web de l’appli est créer, on peut voir le(s) logs associer avec la commande suivante : 
```
$ heroku logs –tail
```

Lorsque cette commande est exécutée, on peut voir tous les logs depuis la création. Pour sortir des logs, on doit simplement entre *ctrl+c.* 

### Créer un ProcFile: 

Un Procfile est un fichier texte dans le répertoire racine de votre application, pour déclarer explicitement quelle commande doit être exécutée pour démarrer votre application. Pour le créer, on entre la commande suivante : 
```
web: projetcsharpfrederic projetCsharp
```

Le code suivant peut être utiliser dans le cas qu’on utilise un fichier ProcFile.windows 
```
web: python manage.py runserver 0.0.0.0:5000
```

### Installer les dépendances d'applications 

Pour pouvoir utiliser les dépendances qui sont dans le fichier requirements.text, on devrait avoir accès à u environnement virtuel, ou venv. On peut l’accéder en installant le Virtual environnement sur Heroku Cli: 
```
$ python3 -m venv venv
``` 

Puis, pour l’activer le venv, la commande dépende du système de l’invite de commande utilisé : 
  +Avec Microsoft Windows System : 
  ```
  .\venv\Scripts\activate
  ```

  +Avec Linux System : 
  ```
  source venv/bin/activate
  ```

Dès qu’on est dans un venv, on peut donc avoir le fichier des dépendances d’application avec la commande suivante : 
```
$ pip install -r requirements.txt
```

Dès qu’on a le fichier, on peut l’ouvrir est voire les dépendances qu’on peut utiliser. La commande pour l’afficher les dépendances sont : 
```
$ pip list
```

### Exécuter l’appli en local 

(On note que l’étape précédant doit être fait avant de démarrer cet étape) 

Pour commencer l’appli en mode local, on doit exécuter collectstatic afin que heroku peut utiliser Django, avec cette commande : 
```
$ python manage.py collectstatic
```

Or, si vous vous utiliser u autre system d’invite de commande, on peut utiliser les alternatives. 
 + Dans le cas de Windows Système : 
   ```
   $ heroku local -f Procfile.windows
   ```

 + Dans le cas de Linux System : 
   ```
   $ heroku local
   ```

Si les étapes ont été correctement appliqué, on peut voir le site avec *http://localhost:5000.* Si ce n’est pas le cas, vérifier que collectstatic est actuellement exécuter. 
Pour sortir du local, entrer *cntr+c* 

