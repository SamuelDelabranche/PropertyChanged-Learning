# Projet : Synchronisation TextBox et DataGrid avec PropertyChanged

Ce projet est un exercice simple pour comprendre et illustrer le fonctionnement de l'événement `PropertyChanged` dans une application. Il utilise un `TextBox` et un `DataGrid` pour démontrer comment synchroniser les données entre les deux contrôles à l'aide de la notification de changement de propriété.

## Description

Ce projet consiste en une application de démonstration qui permet de sélectionner un élément dans un `DataGrid` et d'afficher ses données dans un `TextBox`. Les utilisateurs peuvent modifier les données dans le `TextBox`, et ces modifications sont automatiquement reflétées dans l'élément sélectionné du `DataGrid`. Cette synchronisation est rendue possible grâce à l'implémentation de l'interface `INotifyPropertyChanged`, qui notifie automatiquement les changements de propriété.

### Fonctionnalités principales

- **Sélection dans DataGrid** : Lorsque l'utilisateur sélectionne un élément dans le `DataGrid`, les détails de cet élément sont affichés dans le `TextBox`.
- **Modification et Mise à jour** : Les modifications effectuées dans le `TextBox` sont immédiatement mises à jour dans l'élément sélectionné du `DataGrid`.
- **Notification de changement** : Utilisation de l'événement `PropertyChanged` pour notifier les modifications de données et mettre à jour l'interface utilisateur en conséquence.
