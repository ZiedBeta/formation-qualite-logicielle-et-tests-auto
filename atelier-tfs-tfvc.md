1 - Sur TFS cr�er un nouveau projet TTAuto
2 - Cr�er un r�pository TFVC et cr�� une Branche "Main"

3- Sur votre ordinateur connecter visual studio � Fichier > Controle de Code source (ou bien via le panel "Team Explorer")
4 - Une fois connect�, Clicker sur "Explorateur du contr�le de source"
5 - Mapper l'espace de travail (workspace) � un dossier local sur le disque
6 - A partir de l'explorateur de sources, cr�er un dossier "Main" sur la racine du r�pository
7 - Archiver les modifications
8 - V�rifier que le dossier a �t� bien cr�� sur TFS

9 - Sur TFS, dans le board du projet TTAuto, cr�er un nouveau "WorkItem" : "Initialize TTAuto WPF application" et notez son num�ro

10 - Sur votre ordinateur, cr�er un projet WPF TTAuto dans le r�pertoire Main de votre "workspace"
11 - Apportez des modifications au projet et Archiver le: 
	Avant d'archiver Ajouter le dossier TTAuto dans le workspace via le panel "Explorateur du contr�le de code source"
	Associer le work item aux modifications. Utilisez le num�ro du Work Item
	Ajouter un commentaire
	Archiver les modifications

12 - V�rifier que vos changements sont sur TFS
13 - Acc�dez au Board et v�rifier que le workitem que vous avez cr�� � l'�tape (9) a bien une association avec le check in que vous venez de faire


14 - Cr�er une build d�finition pour le projet TTAuto
15 - Dans les templates de projet, selectionner .Net Desktop
16 - V�rifier les �tapes de build
17 - Activer l'int�gration continue, dans l'onglet "Triggers"
18 - Sauvegardez et lancer la build
19 - Une fois la build termin�e, v�rifier qu'un Art�fact de build est pr�sent

19' - Apportez une modification dans le fichier MainApplication.cs

20 - Cr�er un nouvel workitem et une nouvelle branche portant le nom de la feature
	Pr ferez une convention de nommage pour les branches, par exemple
		feature/num�ro-du-work-item-nom-de-la-feature pour les features
		bug/num�ro-du-work-un-texte-descriptif pour les bugs
		chore/num�ro-du-work-item-texte-descriptif pour les t�ches de cleanup


21 - Constatez la cr�ation d'un nouveau dossier sur le disque, ouvrir la solution cr��e dans le dossier portant le nom de la feature
		
22 - Dans le panel "Explorateur du contr�le de source", s�lectionner la branche nouvellement cr��e, dans le menu contextuel cliquer sur "Afficher l'historique"
23 - Cliquer sur "Suivi de l'ensemble des modifications"
24 - Apportez des modifications sur la branche et une modification dans le fichier MainApplication.cs - m�me ligne que dans l'�tape "19'"
25 - Comparez mes modifications entre la branche "Main" et la nouvelle branche feature

26 - Ouvrir la solution TTAuto de la branche Main et merger la feature branch and la branch main
27 - R�soudre les conflits et Archiver
28 - Supprimer la feature branch depuis TFS