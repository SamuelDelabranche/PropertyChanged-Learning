# Projet : Synchronisation TextBox et DataGrid avec PropertyChanged

Ce projet est un exercice simple pour comprendre et illustrer le fonctionnement de l'�v�nement `PropertyChanged` dans une application. Il utilise un `TextBox` et un `DataGrid` pour d�montrer comment synchroniser les donn�es entre les deux contr�les � l'aide de la notification de changement de propri�t�.

## Description

Ce projet consiste en une application de d�monstration qui permet de s�lectionner un �l�ment dans un `DataGrid` et d'afficher ses donn�es dans un `TextBox`. Les utilisateurs peuvent modifier les donn�es dans le `TextBox`, et ces modifications sont automatiquement refl�t�es dans l'�l�ment s�lectionn� du `DataGrid`. Cette synchronisation est rendue possible gr�ce � l'impl�mentation de l'interface `INotifyPropertyChanged`, qui notifie automatiquement les changements de propri�t�.

### Fonctionnalit�s principales

- **S�lection dans DataGrid** : Lorsque l'utilisateur s�lectionne un �l�ment dans le `DataGrid`, les d�tails de cet �l�ment sont affich�s dans le `TextBox`.
- **Modification et Mise � jour** : Les modifications effectu�es dans le `TextBox` sont imm�diatement mises � jour dans l'�l�ment s�lectionn� du `DataGrid`.
- **Notification de changement** : Utilisation de l'�v�nement `PropertyChanged` pour notifier les modifications de donn�es et mettre � jour l'interface utilisateur en cons�quence.
